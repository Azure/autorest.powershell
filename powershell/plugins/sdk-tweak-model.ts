/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { ArraySchema, ChoiceSchema, ChoiceValue, CodeModel, ConstantSchema, DictionarySchema, getAllProperties, HttpHeader, Language, MultipleChoices, ObjectSchema, Operation, OperationGroup, Parameter, ParameterLocation, Property, Schema, SchemaType, SealedChoiceSchema } from '@autorest/codemodel';
import { escapeString, docComment, serialize, pascalCase, DeepPartial, camelCase } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { SdkModel } from '../utils/SdkModel';
import { ModelState } from '../utils/model-state';
import { StatusCodes } from '../utils/http-definitions';
import { items, values, keys, Dictionary, length, isValue } from '@azure-tools/linq';
import { SchemaDetails } from '../llcsharp/code-model';
import { AutorestExtensionHost as Host } from '@autorest/extension-base';
import { codemodel, schema } from '@azure-tools/codemodel-v3';
import { VirtualProperty, getAllPublicVirtualPropertiesForSdk, getAllPublicVirtualPropertiesForSdkWithoutInherited, valueType } from '../utils/schema';
import { SchemaDefinitionResolver } from '../llcsharp/exports';
import { SchemaT } from '@azure-tools/codemodel-v3/dist/code-model/exports';
import { isReserved } from '../utils/code-namer';
import { verbEnum } from '../internal/powershell-declarations';

type State = ModelState<SdkModel>;


async function tweakModel(state: State): Promise<SdkModel> {
  const model = state.model;

  addUsings(model);

  tweakSchema(model);

  model.globalParameters = model.globalParameters ?? [];

  addAzureProperties(model.globalParameters);

  tweakGlobalParameter(model.globalParameters);

  await tweakOperation(state);

  addClientRequiredConstructorParametersDeclaration(model);

  return model;
}


function addClientRequiredConstructorParametersDeclaration(model: SdkModel) {
  const declarations: Array<string> = [];
  for (const parameter of values(model.globalParameters)) {
    if (parameter.language.default.name === '$host') {
      // skip $host
      continue;
    }
    if (parameter.required && (<any>parameter).readOnly) {
      declarations.push(`${parameter.schema.language.csharp?.fullname} ${parameter.language.default.name.substring(0, 1).toLowerCase() + parameter.language.default.name.substring(1)}`);
    }
  }
  model.language.default.requiredConstructorParametersDeclaration = declarations.join(', ');
}


function tweakSchema(model: SdkModel) {
  for (const obj of values(model.schemas.objects)) {
    const optionalParameters = Array<string>();
    const requiredParameters = Array<string>();
    for (const property of values(obj.properties)) {
      property.language.csharp = <any>{
        name: property.language.default.name.substring(0, 1).toUpperCase() + property.language.default.name.substring(1),
        formattedPropertySummary: (property.readOnly ? 'Gets ' : 'Gets or sets ') + property.language.default.description.substring(0, 1).toLowerCase() + property.language.default.description.substring(1)
      };
    }
    const publicProperties = obj.extensions && obj.extensions['x-ms-azure-resource'] ? getAllPublicVirtualPropertiesForSdkWithoutInherited(obj.language.default.virtualProperties) : getAllPublicVirtualPropertiesForSdk(obj.language.default.virtualProperties);
    for (const virtualProperty of publicProperties) {
      if (virtualProperty.name.toLowerCase() === obj.language.default.name.toLowerCase()) {
        // If the name is same as class name, will add 'Property' suffix
        virtualProperty.name = virtualProperty.name + 'Property';
      }
      if (virtualProperty.required && (virtualProperty.property.schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>virtualProperty.property.schema).choices.length === 1)
        || (virtualProperty.property.schema.type === SchemaType.Choice && (<ChoiceSchema>virtualProperty.property.schema).choices.length === 1)) {
        // For choice or seal choice with only one value and required, will not be handled as constant
        continue;
      }

      let type = virtualProperty.property.schema.language.csharp?.fullname || '';
      type = (valueType(virtualProperty.property.schema.type) || (virtualProperty.property.schema.type === SchemaType.SealedChoice && ((<SealedChoiceSchema>virtualProperty.property.schema).choiceType.type !== SchemaType.String || (virtualProperty.property.schema.extensions && !virtualProperty.property.schema.extensions['x-ms-model-as-string'])))) && !virtualProperty.required ? `${type}?` : type;
      const CamelName = camelCase(virtualProperty.name);
      virtualProperty.required ? requiredParameters.push(`${type} ${CamelName}`) : optionalParameters.push(`${type} ${CamelName} = default(${type})`);
    }
    if (obj.parents && (obj.parents.immediate.length === 1 && !(obj.extensions && obj.extensions['x-ms-azure-resource']))) {
      // If there is only one direct parent parameter and extension x-ms-azure-resource is not set, will implement it as base class
      let baseConstructorParametersCall = Array<string>();
      const baseRequiredParameters = Array<string>();
      const baseOptionalParameters = Array<string>();
      const combinedProperties = getAllPublicVirtualPropertiesForSdk(obj.parents.immediate[0].language.default.virtualProperties);
      for (const virtualProperty of values(combinedProperties)) {
        if (virtualProperty.required) {
          baseRequiredParameters.push(virtualProperty.name);
        } else {
          baseOptionalParameters.push(virtualProperty.name);
        }
      }
      baseConstructorParametersCall = [...baseRequiredParameters, ...baseOptionalParameters].map((p) => camelCase(p) || '');
      if (baseConstructorParametersCall.length > 0) {
        obj.language.default.baseConstructorCall = `base(${baseConstructorParametersCall.join(', ')})`;
      }
    }
    obj.language.default.constructorParametersDeclaration = [...requiredParameters, ...optionalParameters].join(', ');
  }
}

function addUsings(model: SdkModel) {
  model.usings = [
    'Microsoft.Rest.Azure'];
  if (model.schemas.objects || model.schemas.sealedChoices) {
    model.usings.push('Models');
  }
}

function addMethodParameterDeclaration(operation: Operation, state: State) {
  if (operation.language.default.pageable?.nextPageOperation) {
    addPageableMethodParameterDeclaration(operation);
  } else {
    addNormalMethodParameterDeclaration(operation, state);
  }
}

function typePostfix(schema: Schema): string {
  return valueType(schema.type) || (schema.type === SchemaType.SealedChoice && ((<SealedChoiceSchema>schema).choiceType.type !== SchemaType.String || (schema.extensions && !schema.extensions['x-ms-model-as-string']))) ? '?' : '';
}

function addNormalMethodParameterDeclaration(operation: Operation, state: State) {
  let declarations: Array<string> = [];
  const optionalDeclarations: Array<string> = [];
  const requiredDeclarations: Array<string> = [];
  const requiredArgs: Array<string> = [];
  const optionalArgs: Array<string> = [];
  const schemaDefinitionResolver = new SchemaDefinitionResolver();
  const args: Array<string> = [];
  let bodyParameters: Array<Parameter> = [];
  if (operation.requests && operation.requests.length > 0) {
    bodyParameters = (operation.requests[0].parameters || []).filter(p => p.protocol.http?.in === ParameterLocation.Body);
  }

  (operation.parameters || []).filter(p => p.implementation != 'Client' && !(p.extensions && p.extensions['x-ms-parameter-grouping'])
    && !(p.required && p.schema.type === SchemaType.Choice && (<ChoiceSchema>p.schema).choices.length === 1)
    && !(p.required && p.schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>p.schema).choices.length === 1)).forEach(function (parameter) {
    let type = parameter.schema.language.csharp?.fullname || parameter.schema.language.csharp?.name || '';
    if (parameter.extensions && parameter.extensions['x-ms-odata']) {
      type = `Microsoft.Rest.Azure.OData.ODataQuery<${type}>`;
    }
    const postfix = typePostfix(parameter.schema);
    if (!(parameter.required && parameter.schema.type === SchemaType.Constant)) {
      // skip required const parameter
      parameter.required ? requiredDeclarations.push(`${type} ${parameter.language.default.name}`) : optionalDeclarations.push(`${type}${postfix} ${parameter.language.default.name} = default(${type}${postfix})`);
      parameter.required ? requiredArgs.push(parameter.language.default.name) : optionalArgs.push(parameter.language.default.name);
    }
  });

  bodyParameters.filter(p => !(p.extensions && p.extensions['x-ms-parameter-grouping'])
    && !(p.required && p.schema.type === SchemaType.Choice && (<ChoiceSchema>p.schema).choices.length === 1)
    && !(p.required && p.schema.type === SchemaType.SealedChoice && (<SealedChoiceSchema>p.schema).choices.length === 1)).forEach(function (parameter) {
    if (parameter.extensions && parameter.extensions['x-ms-client-flatten']) {
      const constructorParametersDeclaration = <string>parameter.schema.language.default.constructorParametersDeclaration;
      constructorParametersDeclaration.split(', ').forEach(function (p) {
        requiredDeclarations.push(p);
        requiredArgs.push(p.split(' ')[1]);
      });
    } else {
      const type = parameter.schema.language.csharp && parameter.schema.language.csharp.fullname && parameter.schema.language.csharp.fullname != '<INVALID_FULLNAME>' ? parameter.schema.language.csharp.fullname : parameter.schema.language.default.name;
      const postfix = typePostfix(parameter.schema);
      parameter.required ? requiredDeclarations.push(`${type} ${parameter.language.default.name}`) : optionalDeclarations.push(`${type}${postfix} ${parameter.language.default.name} = default(${type}${postfix})`);
      parameter.required ? requiredArgs.push(parameter.language.default.name) : optionalArgs.push(parameter.language.default.name);
    }
  });

  declarations = [...requiredDeclarations, ...optionalDeclarations];
  operation.language.default.syncMethodParameterDeclaration = declarations.join(', ');
  declarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclaration = declarations.join(', ');
  declarations.pop();
  declarations.push('System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null');
  operation.language.default.syncMethodParameterDeclarationWithCustomHeader = declarations.join(', ');
  declarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclarationWithCustomHeader = declarations.join(', ');

  args.push(...requiredArgs, ...optionalArgs);
  operation.language.default.syncMethodInvocationArgs = args.join(', ');
  const argsWithCustomerHeaders: Array<string> = [...args];
  args.push('null');
  args.push('cancellationToken');
  argsWithCustomerHeaders.push('customHeaders');
  argsWithCustomerHeaders.push('cancellationToken');
  operation.language.default.asyncMethodInvocationArgs = args.join(', ');
  operation.language.default.asyncMethodInvocationArgsWithCustomerHeaders = argsWithCustomerHeaders.join(', ');
}

function addPageableMethodParameterDeclaration(operation: Operation) {
  const pageableMethodDeclarations: Array<string> = ['string nextPageLink'];
  operation.language.default.syncMethodParameterDeclaration = pageableMethodDeclarations.join(', ');

  pageableMethodDeclarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclaration = pageableMethodDeclarations.join(', ');

  pageableMethodDeclarations.pop();
  pageableMethodDeclarations.push('System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null');
  operation.language.default.syncMethodParameterDeclarationWithCustomHeader = pageableMethodDeclarations.join(', ');

  pageableMethodDeclarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclarationWithCustomHeader = pageableMethodDeclarations.join(', ');

  const pageableMethodArgs: Array<string> = ['nextPageLink'];
  operation.language.default.syncMethodInvocationArgs = pageableMethodArgs.join(', ');

  pageableMethodArgs.push('null');
  pageableMethodArgs.push('cancellationToken');
  operation.language.default.asyncMethodInvocationArgs = pageableMethodArgs.join(', ');
}

function tweakGlobalParameter(globalParameters: Array<Parameter>) {
  if (!globalParameters) {
    return;
  }
  globalParameters.forEach(function (parameter) {
    if (parameter.language.default.name === 'apiVersion') {
      // change apiVersion to ApiVersion since the track 1 SDK expects it.
      parameter.language.default.name = 'ApiVersion';
      if (parameter.schema.apiVersions) {
        parameter.clientDefaultValue = parameter.schema.apiVersions[0];
      }
    }
  });
}

async function tweakOperation(state: State) {
  for (const operationGroup of state.model.operationGroups) {
    if (isReserved(operationGroup.$key)) {
      operationGroup.$key = pascalCase(`${operationGroup.$key}Model`);
      operationGroup.language.default.name = operationGroup.$key;
    }
    for (const operation of operationGroup.operations) {
      let initializeResponseBody = '';
      operation.language.default.returnTypeHeader = {};
      operation.language.default.returnTypeHeader.name = '';
      if (operation.responses) {
        const schemas = new Set();
        operation.responses.forEach(function (resp) {
          if ((<any>resp).schema) {
            schemas.add((<any>resp).schema);
          }
        });
        const respCountWithBody = schemas.size;
        const isHead = operation.requests && operation.requests[0].protocol.http?.method === 'head';
        if (isHead) {
          initializeResponseBody = '_result.Body = (_statusCode == System.Net.HttpStatusCode.OK);';
        }
        const responses = operation.responses.filter(r => (<any>r).schema);
        const hasHeaderResponse = operation.responses.some(r => (<any>r).protocol.http.headers);
        const headerSchema = pascalCase(operationGroup.$key + (operation.language.default.original ?? operation.language.default.name) + 'Headers');
        operation.language.default.returnTypeHeader.name = hasHeaderResponse ? headerSchema : '';
        let headerPostfix = hasHeaderResponse ? `,${headerSchema}` : '';
        if (respCountWithBody === 0) {
          const statusCodes = new Array<string>();
          operation.responses.forEach(resp => statusCodes.push(resp.protocol.http?.statusCodes[0]));
          if (isHead && operation.responses?.length === 2 && statusCodes.includes('404') && !hasHeaderResponse) {
            operation.language.default.responseType = 'Microsoft.Rest.Azure.AzureOperationResponse<bool>';
            operation.language.default.returnType = 'bool';
          } else {
            headerPostfix = hasHeaderResponse ? (isHead ? `AzureOperationResponse<bool,${headerSchema}>` : `AzureOperationHeaderResponse<${headerSchema}>`) : 'AzureOperationResponse';
            operation.language.default.responseType = `Microsoft.Rest.Azure.${headerPostfix}`;
            operation.language.default.returnType = hasHeaderResponse ? (isHead ? 'bool' : headerSchema) : 'void';
          }
        } else if (respCountWithBody === 1) {
          const respSchema = (<any>responses[0]).schema;
          if (operation.language.default.pageable) {
            const responseType = respSchema.language.default.virtualProperties.owned.find((p: VirtualProperty) => p.name === pascalCase(operation.language.default.pageable.itemName)).property.schema.elementType.language.csharp.fullname;
            // Mark response as pageable
            respSchema.language.default.pagable = true;
            operation.language.default.responseType = `Microsoft.Rest.Azure.AzureOperationResponse<${operation.language.default.pageable.ipageType}<${responseType}>>`;
            operation.language.default.returnType = `${operation.language.default.pageable.ipageType}<${responseType}>`;
            operation.language.default.deserializeType = `${operation.language.default.pageable.pageType}<${responseType}>`;
          } else {
            const postfix = (valueType(respSchema.type)
              || (respSchema.type === SchemaType.SealedChoice && respSchema.extensions && !respSchema.extensions['x-ms-model-as-string'])
              || (respSchema.type === SchemaType.Choice && valueType((<ChoiceSchema>respSchema).choiceType.type))
              || (respSchema.type === SchemaType.SealedChoice && respSchema.extensions && valueType((<SealedChoiceSchema>respSchema).choiceType.type))
            ) ? '?' : '';
            const fullname = (respSchema.type === SchemaType.Choice || (respSchema.type === SchemaType.SealedChoice && (valueType((<SealedChoiceSchema>respSchema).choiceType.type) || (respSchema.extensions && respSchema.extensions['x-ms-model-as-string'])))) ? (<SealedChoiceSchema>respSchema).choiceType.language.csharp?.fullname : respSchema.language.csharp.fullname;
            operation.language.default.responseType = `Microsoft.Rest.Azure.AzureOperationResponse<${fullname}${postfix}${headerPostfix}>`;
            operation.language.default.returnType = `${fullname}${postfix}`;
          }
        } else {
          operation.language.default.responseType = `Microsoft.Rest.Azure.AzureOperationResponse<object${headerPostfix}>`;
          operation.language.default.returnType = 'object';
        }
      } else {
        operation.language.default.responseType = 'Microsoft.Rest.Azure.AzureOperationResponse';
        operation.language.default.returnType = 'void';
      }
      operation.language.default.initializeResponseBody = initializeResponseBody;
      addMethodParameterDeclaration(operation, state);
      setFailureStatusCodePredicate(operation);
    }
  }
}

function setFailureStatusCodePredicate(operation: Operation) {
  const failureStatusCodePredicate = Array<string>();
  for (const resp of values(operation.responses)) {
    const status = resp.protocol.http?.statusCodes[0];
    failureStatusCodePredicate.push(`(int)_statusCode != ${status}`);
  }
  if (failureStatusCodePredicate.length > 0) {
    operation.language.default.failureStatusCodePredicate = failureStatusCodePredicate.join(' && ');
  } else {
    operation.language.default.failureStatusCodePredicate = '!_httpResponse.IsSuccessStatusCode';
  }
}

function addAzureProperties(globalParameters: Array<Parameter>) {
  const primitiveTypeMap = new Map<string, string>([
    ['integer', 'int'],
    ['number', 'double'],
    ['boolean', 'bool'],
    ['string', 'string']
  ]);

  // To align with track 1 SDK, move API version to the beginning
  if (globalParameters.length > 0 && globalParameters[globalParameters.length - 1].language.default.name === 'apiVersion') {
    const apiVersion = globalParameters.pop();
    if (apiVersion) {
      apiVersion.clientDefaultValue = (<ConstantSchema>apiVersion.schema).value.value;
      apiVersion.language.default.description = 'The API version to use for this operation.';
      globalParameters.unshift(apiVersion);
    }
  }
  const credential = new Parameter('Credentials', 'Credentials needed for the client to connect to Azure.', new Schema('credentials', 'credentials', SchemaType.Object));
  credential.language.default.serializedName = 'credentials';
  credential.required = true;
  // Todo: Will need to add readOnly in the class Parameter
  (<any>credential).readOnly = true;
  credential.schema.language.csharp = <SchemaDetails>{
    ...credential.schema.language.default,
    fullname: 'Microsoft.Rest.ServiceClientCredentials'
  };
  globalParameters.unshift(credential);

  const acceptLanguage = new Parameter('AcceptLanguage', 'The preferred language for the response.', new Schema('accept-language', 'accept-language', SchemaType.String));
  acceptLanguage.language.default.serializedName = 'accept-language';
  acceptLanguage.schema.language.csharp = <SchemaDetails>{
    ...acceptLanguage.schema.language.default,
    fullname: primitiveTypeMap.get(acceptLanguage.schema.type)
  };
  acceptLanguage.clientDefaultValue = 'en-US';
  globalParameters.push(acceptLanguage);

  const longRunningOperationRetryTimeout = new Parameter('LongRunningOperationRetryTimeout', 'The retry timeout in seconds for Long Running Operations. Default\n        /// value is 30.', new Schema('longRunningOperationRetryTimeout', 'longRunningOperationRetryTimeout', SchemaType.Integer));
  longRunningOperationRetryTimeout.language.default.serializedName = 'longRunningOperationRetryTimeout';
  longRunningOperationRetryTimeout.schema.language.csharp = <SchemaDetails>{
    ...longRunningOperationRetryTimeout.schema.language.default,
    fullname: primitiveTypeMap.get(longRunningOperationRetryTimeout.schema.type)
  };
  longRunningOperationRetryTimeout.clientDefaultValue = 30;
  globalParameters.push(longRunningOperationRetryTimeout);

  const generateClientRequestId = new Parameter('GenerateClientRequestId', 'Whether a unique x-ms-client-request-id should be generated. When \n        /// set to true a unique x-ms-client-request-id value is generated and \n        /// included in each request. Default is true.', new Schema('generateClientRequestId', 'generateClientRequestId', SchemaType.Boolean));
  generateClientRequestId.language.default.serializedName = 'generateClientRequestId';
  generateClientRequestId.schema.language.csharp = <SchemaDetails>{
    ...generateClientRequestId.schema.language.default,
    fullname: primitiveTypeMap.get(generateClientRequestId.schema.type)
  };
  generateClientRequestId.clientDefaultValue = true;
  globalParameters.push(generateClientRequestId);
}

export async function tweakSdkModelPlugin(service: Host) {
  const state = await new ModelState<SdkModel>(service).init();
  const debug = await service.getValue('debug') || false;
  try {
    service.writeFile({ filename: 'sdk-code-model-v4-tweaksdk.yaml', content: serialize(await tweakModel(state)), sourceMap: undefined, artifactType: 'code-model-v4' });
  } catch (E) {
    if (debug && E instanceof Error) {
      console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack} `);
    }
    throw E;
  }
}