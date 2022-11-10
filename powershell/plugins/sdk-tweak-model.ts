/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { ArraySchema, CodeModel, ConstantSchema, DictionarySchema, getAllProperties, HttpHeader, Language, ObjectSchema, Operation, Parameter, ParameterLocation, Property, Schema, SchemaType } from '@azure-tools/codemodel';
import { escapeString, docComment, serialize, pascalCase, DeepPartial, camelCase } from '@azure-tools/codegen';
import { PwshModel } from '../utils/PwshModel';
import { SdkModel } from '../utils/SdkModel';
import { ModelState } from '../utils/model-state';
import { StatusCodes } from '../utils/http-definitions';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { SchemaDetails } from '../llcsharp/code-model';
import { Host } from '@azure-tools/autorest-extension-base';
import { codemodel, schema } from '@azure-tools/codemodel-v3';
import { VirtualProperty, getAllPublicVirtualPropertiesForSdk } from '../utils/schema';
import { SchemaDefinitionResolver } from '../llcsharp/exports';
import { SchemaT } from '@azure-tools/codemodel-v3/dist/code-model/exports';

type State = ModelState<SdkModel>;


async function tweakModel(state: State): Promise<SdkModel> {
  const model = state.model;

  addUsings(model);

  addAzureProperties(model.globalParameters || []);

  tweakGlobalParameter(model.globalParameters || []);

  await tweakOperation(state);

  tweakSchema(model);

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

// add ? for value type
function nullValueType(type: string): string {
  if (['int', 'bool', 'float', 'double', 'long'].includes(type)) {
    return type + '?';
  }
  return type;
}

function tweakSchema(model: SdkModel) {
  for (const obj of values(model.schemas.objects)) {
    const constructorParametersDeclaration = Array<string>();
    for (const property of values(obj.properties)) {
      property.language.csharp = <any>{
        name: property.language.default.name.substring(0, 1).toUpperCase() + property.language.default.name.substring(1),
        formattedPropertySummary: (property.readOnly ? 'Gets ' : 'Gets or sets ') + property.language.default.description.substring(0, 1).toLowerCase() + property.language.default.description.substring(1)
      };
    }
    for (const virtualProperty of getAllPublicVirtualPropertiesForSdk(obj.language.default.virtualProperties)) {
      const type = nullValueType(virtualProperty.property.schema.language.csharp?.fullname || '');
      const CamelName = virtualProperty.property.language.default.name;
      constructorParametersDeclaration.push(`${type} ${CamelName} = default(${type})`);
    }
    if (obj.parents && obj.parents.immediate.length === 1) {
      // If there is only one direct parameter, will implement it as base class
      const baseConstructorParametersCall = Array<string>();
      const combinedProperties = getAllPublicVirtualPropertiesForSdk(obj.parents.immediate[0].language.default.virtualProperties);
      for (const virtualProperty of values(combinedProperties)) {
        baseConstructorParametersCall.push(camelCase(virtualProperty.name) || '');
      }
      if (baseConstructorParametersCall.length > 0) {
        obj.language.default.baseConstructorCall = `base(${baseConstructorParametersCall.join(', ')})`;
      }
    }
    obj.language.default.constructorParametersDeclaration = constructorParametersDeclaration.join(', ');
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
  const declarations: Array<string> = [];
  const schemaDefinitionResolver = new SchemaDefinitionResolver();
  const args: Array<string> = [];
  let bodyParameters: Array<Parameter> = [];
  if (operation.requests && operation.requests.length > 0) {
    bodyParameters = (operation.requests[0].parameters || []).filter(p => p.protocol.http?.in === ParameterLocation.Body);
  }
  [...(operation.parameters || []), ...bodyParameters].filter(p => p.implementation != 'Client').forEach(function (parameter) {
    const type = parameter.schema.language.default.fullName && parameter.schema.language.default.fullName != '<INVALID_FULLNAME>' ? parameter.schema.language.default.fullName : parameter.schema.language.default.name;
    const defaultOfType = schemaDefinitionResolver.resolveTypeDeclaration(parameter.schema, true, state).defaultOfType;
    parameter.required ? declarations.push(`${type} ${parameter.language.default.name}`) : declarations.push(`${type} ${parameter.language.default.name} = ${defaultOfType}`);
    args.push(parameter.language.default.name);
  });

  operation.language.default.syncMethodParameterDeclaration = declarations.join(', ');
  declarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclaration = declarations.join(', ');
  declarations.pop();
  declarations.push('System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null');
  operation.language.default.syncMethodParameterDeclarationWithCustomHeader = declarations.join(', ');
  declarations.push('System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)');
  operation.language.default.asyncMethodParameterDeclarationWithCustomHeader = declarations.join(', ');

  operation.language.default.syncMethodInvocationArgs = args.join(', ');
  args.push('null');
  args.push('cancellationToken');
  operation.language.default.asyncMethodInvocationArgs = args.join(', ');
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
    for (const operation of operationGroup.operations) {
      if (operation.responses) {
        const respCountWithBody = operation.responses.filter(r => (<any>r).schema).length;
        const responses = operation.responses.filter(r => (<any>r).schema);
        if (respCountWithBody === 0) {
          operation.language.default.responseType = 'Microsoft.Rest.Azure.AzureOperationResponse';
          operation.language.default.returnType = 'void';
        } else if (respCountWithBody === 1) {
          operation.language.default.responseType = `Microsoft.Rest.Azure.AzureOperationResponse<${(<any>responses[0]).schema.language.default.name}>`;
          operation.language.default.returnType = `${(<any>responses[0]).schema.language.default.name}`;
        } else {
          operation.language.default.responseType = 'Microsoft.Rest.Azure.AzureOperationResponse<Object>';
          operation.language.default.returnType = 'Object';
        }
      } else {
        operation.language.default.responseType = 'Microsoft.Rest.Azure.AzureOperationResponse';
        operation.language.default.returnType = 'void';
      }
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
    ['number', 'int'],
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
  const debug = await service.GetValue('debug') || false;
  try {
    service.WriteFile('sdk-code-model-v4-tweaksdk.yaml', serialize(await tweakModel(state)), undefined, 'code-model-v4');
  } catch (E) {
    if (debug) {
      console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    }
    throw E;
  }
}