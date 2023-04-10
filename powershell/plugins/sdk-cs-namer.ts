/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, SchemaResponse, CodeModel, Schema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, StringSchema, ChoiceSchema, SealedChoiceSchema, DictionarySchema, ArraySchema } from '@azure-tools/codemodel';
import { camelCase, deconstruct, excludeXDash, fixLeadingNumber, pascalCase, lowest, maximum, minimum, getPascalIdentifier, serialize } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { System } from '@azure-tools/codegen-csharp';

import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { SchemaDetails } from '../llcsharp/code-model';
import { SchemaDefinitionResolver } from '../llcsharp/schema/schema-resolver';
import { SdkModel } from '../utils/SdkModel';
import { ModelState } from '../utils/model-state';
import { DeepPartial } from '@azure-tools/codegen';
import { SchemaDetails as NewSchemaDetails, getMutability } from '../utils/schema';
import { Helper } from '../sdk/utility';
import { getEscapedReservedName } from '../utils/code-namer';


type State = ModelState<SdkModel>;


// function setPropertyNames(schema: Schema) {
//   // name each property in this schema
//   // skip-for-time-being
//   if (!isObjectSchema(schema)) {
//     return;
//   }
//   for (const propertySchema of values(schema.properties)) {
//     const propertyDetails = propertySchema.language.default;
//     const mutability = getMutability(propertySchema);
//     propertyDetails.required = propertySchema.required ?? false;
//     propertyDetails.readOnly = propertySchema.readOnly ?? false;
//     propertyDetails.read = mutability.read;
//     propertyDetails.update = mutability.update && !propertyDetails.readOnly;
//     propertyDetails.create = mutability.create && !propertyDetails.readOnly;

//     const className = schema.language.csharp?.name;

//     let pname = getPascalIdentifier(propertyDetails.name);
//     if (pname === className) {
//       pname = `${pname}Property`;
//     }

//     if (pname === 'default') {
//       pname = '@default';
//     }

//     propertySchema.language.csharp = {
//       ...propertyDetails,
//       name: pname // and so are the propertyNmaes
//     };

//     if (propertyDetails.isNamedStream) {
//       propertySchema.language.csharp.namedStreamPropertyName = pascalCase(fixLeadingNumber([...deconstruct(propertyDetails.name), 'filename']));
//     }
//   }

// }

function csharpForArray(elementType: Schema): string {
  if (elementType.type === SchemaType.Array) {
    // recursively generate the csharpForArray
    return `System.Collections.Generic.IList<${csharpForArray((<ArraySchema>elementType).elementType)}>`;
  }
  const rawElementType = elementType;
  const helper = new Helper();
  elementType = rawElementType;
  if ((rawElementType.type === SchemaType.Choice || rawElementType.type === SchemaType.SealedChoice) && !helper.IsEnum(rawElementType)) {
    elementType = (<ChoiceSchema | SealedChoiceSchema>rawElementType).choiceType;
  }
  const type = helper.GetCsharpType(elementType);
  const postfix = ((type && type !== 'string') || helper.IsEnum(rawElementType)) ? '?' : '';
  return `System.Collections.Generic.IList<${type ? type + postfix :
    (helper.IsEnum(rawElementType) ? rawElementType.language.default.name + '?' : rawElementType.language.default.name)}>`;
}

function setSchemaNames(schemaGroups: Dictionary<Array<Schema>>, azure: boolean, serviceNamespace: string) {
  const baseNamespace = new Set<string>();
  const subNamespace = new Map<string, Set<string>>();
  const helper = new Helper();

  for (const group of values(schemaGroups)) {
    for (const schema of group) {
      if (schema.language.default.skip) {
        continue;
      }
      let thisNamespace = baseNamespace;
      let thisApiversion = '';

      // create the namespace if required
      if (azure) {
        const versions = [...values(schema.apiVersions).select(v => v.version)];
        if (schema.language.default?.uid !== 'universal-parameter-type') {
          if (versions && length(versions) > 0) {
            thisApiversion = minimum(versions);
            thisNamespace = subNamespace.get(thisApiversion) || new Set<string>();
            subNamespace.set(thisApiversion, thisNamespace);
          }
        }
      }


      // for each schema, we're going to set the name
      // to the suggested name, unless we have collisions
      // at which point, we're going to add a number (for now?)
      const details = schema.language.default;
      let schemaName = details.name;
      const apiName = (!thisApiversion) ? '' : getPascalIdentifier(`Api ${thisApiversion}`);


      let n = 1;
      while (thisNamespace.has(schemaName)) {
        schemaName = `${details.name}_${n++}`;
      }
      thisNamespace.add(schemaName);

      // object types.
      if (schema.type === SchemaType.Object) {
        schema.language.default.name = getEscapedReservedName(schemaName, 'Model');
        schema.language.csharp = {
          ...details,
          apiversion: thisApiversion,
          apiname: apiName,
          name: getEscapedReservedName(schemaName, 'Model'),
          namespace: pascalCase([serviceNamespace, '.', 'Models']),  // objects have a namespace
          fullname: getEscapedReservedName(schemaName, 'Model'),
        };
      } else if (schema.type === SchemaType.Any) {
        schema.language.csharp = {
          ...details,
          apiversion: thisApiversion,
          apiname: apiName,
          name: schemaName,
          fullname: 'object',
        };
      } else if (schema.type === SchemaType.Array) {
        schema.language.csharp = {
          ...details,
          apiversion: thisApiversion,
          apiname: apiName,
          name: schemaName,
          fullname: csharpForArray((<ArraySchema>schema).elementType),
        };
      } else if (schema.type === SchemaType.Choice || schema.type === SchemaType.SealedChoice) {
        // oh, it's an enum type
        // ToDo: comment out for time being
        // const choiceSchema = <ChoiceSchema<StringSchema> | SealedChoiceSchema<StringSchema>>schema;
        // schema.language.csharp = <SchemaDetails>{
        //   ...details,
        //   interfaceName: 'I' + pascalCase(fixLeadingNumber([...deconstruct(schemaName)])),
        //   name: getPascalIdentifier(schemaName),
        //   namespace: pascalCase([serviceNamespace, '.', 'Support']),
        //   fullname: `${pascalCase([serviceNamespace, '.', 'Support'])}.${getPascalIdentifier(schemaName)}`,
        //   enum: {
        //     ...schema.language.default.enum,
        //     name: getPascalIdentifier(schema.language.default.name),
        //     values: choiceSchema.choices.map(each => {
        //       return {
        //         ...each,
        //         name: getPascalIdentifier(each.language.default.name),
        //         description: each.language.default.description
        //       };
        //     })
        //   }
        // };
        const choiceSchema = <ChoiceSchema<StringSchema> | SealedChoiceSchema<StringSchema>>schema;
        schema.language.csharp = <SchemaDetails>{
          ...details,
          interfaceName: 'I' + pascalCase(fixLeadingNumber([...deconstruct(schemaName)])),
          name: schemaName,
          namespace: pascalCase([serviceNamespace, '.', 'Support']),
          fullname: choiceSchema.extensions && !choiceSchema.extensions['x-ms-model-as-string'] && choiceSchema.choiceType.type === SchemaType.String ? getPascalIdentifier(schema.language.default.name) : helper.GetCsharpType(choiceSchema.choiceType),
          enum: {
            ...schema.language.default.enum,
            name: getPascalIdentifier(schema.language.default.name),
            values: choiceSchema.choices.map(each => {
              return {
                ...each,
                name: getPascalIdentifier(each.language.default.name),
                description: each.language.default.description
              };
            })
          }
        };
      } else if (schema.type !== SchemaType.Dictionary) {
        // here are primitive types
        const schemaDetails = <SchemaDetails>{
          ...details,
          name: schemaName,
          fullname: helper.GetCsharpType(schema)
        };
        // add jonconverters for some types
        if (schema.type === SchemaType.Date) {
          schemaDetails.jsonConverters = schemaDetails.jsonConverters || [];
          schemaDetails.jsonConverters.push('Microsoft.Rest.Serialization.DateJsonConverter');
        } else if (schema.type === SchemaType.UnixTime) {
          schemaDetails.jsonConverters = schemaDetails.jsonConverters || [];
          schemaDetails.jsonConverters.push('Microsoft.Rest.Serialization.UnixTimeJsonConverter');
        }
        schema.language.csharp = schemaDetails;
        // xichen: for invalid namespace case, we won't create model class. So we do not need consider dup case
        thisNamespace.delete(schemaName);
      } else {
        // handle dictionary
        const rawElementType = (<DictionarySchema>schema).elementType;
        let elementType = rawElementType;
        if ((rawElementType.type === SchemaType.Choice || rawElementType.type === SchemaType.SealedChoice) && !helper.IsEnum(rawElementType)) {
          elementType = (<ChoiceSchema | SealedChoiceSchema>rawElementType).choiceType;
        }

        let valueType = helper.GetCsharpType(elementType) ? helper.GetCsharpType(elementType) : rawElementType.language.default.name;
        if (rawElementType.type === 'any') {
          valueType = 'object';
        }
        if ((helper.GetCsharpType(elementType) && valueType !== 'string') || helper.IsEnum(rawElementType)) {
          valueType += '?';
        }
        schema.language.csharp = {
          ...details,
          apiversion: thisApiversion,
          apiname: apiName,
          name: schemaName,
          fullname: `System.Collections.Generic.IDictionary<string, ${valueType}>`,
        };
      }
    }
  }

}

// async function setOperationNames(state: State, resolver: SchemaDefinitionResolver) {
//   // keep a list of operation names that we've assigned.
//   const operationNames = new Set<string>();
//   for (const operationGroup of values(state.model.operationGroups)) {
//     for (const operation of values(operationGroup.operations)) {
//       const details = operation.language.default;

//       // come up with a name
//       const oName = getPascalIdentifier(operationGroup.$key + '_' + details.name);
//       let i = 1;
//       let operationName = oName;
//       while (operationNames.has(operationName)) {
//         // if we have used that name, try again.
//         operationName = `${oName}${i++}`;
//       }
//       operationNames.add(operationName);

//       operation.language.csharp = {
//         ...details, // inherit
//         name: operationName,
//       };

//       // parameters are camelCased.
//       for (const parameter of values(operation.parameters)) {
//         const parameterDetails = parameter.language.default;

//         let propName = camelCase(fixLeadingNumber(deconstruct(parameterDetails.serializedName)));

//         if (propName === 'default') {
//           propName = '@default';
//         }

//         parameter.language.csharp = {
//           ...parameterDetails,
//           name: propName
//         };
//       }

//       const responses = [...values(operation.responses), ...values(operation.exceptions)];

//       for (const rsp of responses) {
//         // per responseCode
//         const response = <SchemaResponse>rsp;
//         const responseTypeDefinition = response.schema ? resolver.resolveTypeDeclaration(<any>response.schema, true, state) : undefined;
//         const headerSchema = response.language.default.headerSchema;
//         const headerTypeDefinition = headerSchema ? resolver.resolveTypeDeclaration(<any>headerSchema, true, state.path('schemas', headerSchema.language.default.name)) : undefined;
//         let code = (System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]] ? System.Net.HttpStatusCode[response.protocol.http?.statusCodes[0]].value : (response.protocol.http?.statusCodes[0] || '')).replace('global::System.Net.HttpStatusCode', '');
//         let rawValue = code.replace(/\./, '');
//         if (response.protocol.http?.statusCodes[0] === 'default' || rawValue === 'default' || '') {
//           rawValue = 'any response code not handled elsewhere';
//           code = 'default';
//           response.language.default.isErrorResponse = true;
//         }
//         response.language.csharp = {
//           ...response.language.default,
//           responseType: responseTypeDefinition ? responseTypeDefinition.declaration : '',
//           headerType: headerTypeDefinition ? headerTypeDefinition.declaration : '',
//           name: (length(response.protocol.http?.mimeTypes) <= 1) ?
//             camelCase(fixLeadingNumber(deconstruct(`on ${code}`))) : // the common type (or the only one.)
//             camelCase(fixLeadingNumber(deconstruct(`on ${code} ${response.protocol.http?.mimeTypes[0]}`))),
//           description: (length(response.protocol.http?.mimeTypes) <= 1) ?
//             `a delegate that is called when the remote service returns ${response.protocol.http?.statusCodes[0]} (${rawValue}).` :
//             `a delegate that is called when the remote service returns ${response.protocol.http?.statusCodes[0]} (${rawValue}) with a Content-Type matching ${response.protocol.http?.mimeTypes.join(',')}.`

//         };
//       }
//     }
//   }
// }

function duplicateLRO(model: SdkModel) {
  for (const operationGroup of model.operationGroups) {
    for (const operation of operationGroup.operations) {
      if (operation.extensions && operation.extensions['x-ms-long-running-operation']) {
        const duplicate = new Operation('Begin' + operation.language.default.name, '', operation);
        // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
        const extensions = Object.assign({}, duplicate.extensions);
        delete extensions['x-ms-long-running-operation'];
        if (extensions && 'x-ms-examples' in extensions) {
          delete extensions['x-ms-examples'];
        }
        duplicate.extensions = extensions;
        duplicate.language.default.original = duplicate.language.default.name;
        duplicate.language.default.name = 'Begin' + duplicate.language.default.name;
        operationGroup.operations.push(duplicate);
      }
    }
  }
}

const xmsPageable = 'x-ms-pageable';
// nextLineName is required parameter in 'x-ms-pageable' but its value could be null
const defaultNextLinkName = '';
const defaultItemName = 'value';

function getPageClass(operation: Operation, model: SdkModel): string | null {
  if (!operation.extensions || !(xmsPageable in operation.extensions)) {
    return null;
  }
  const nextLinkName = operation.extensions[xmsPageable].nextLinkName || defaultNextLinkName;
  const itemName = operation.extensions[xmsPageable].itemName || defaultItemName;
  const pair = `${nextLinkName} ${itemName}`;
  if (!(pair in model.language.default.pageClasses)) {
    const className = Object.keys(model.language.default.pageClasses).length > 0 ? `Page${Object.keys(model.language.default.pageClasses).length}` : 'Page';
    model.language.default.pageClasses[pair] = className;
  }
  return model.language.default.pageClasses[pair];
}

function addNextPageOperation(model: SdkModel) {
  model.language.default.pageClasses = model.language.default.pageClasses || {};
  for (const operationGroup of model.operationGroups) {
    for (const operation of operationGroup.operations) {
      if (operation.extensions && xmsPageable in operation.extensions) {
        operation.language.default.pageable = {
          pageType: getPageClass(operation, model),
          ipageType: operation.extensions[xmsPageable].nextLinkName ? 'Microsoft.Rest.Azure.IPage' : 'System.Collections.Generic.IEnumerable',
          nextLinkName: operation.extensions[xmsPageable].nextLinkName || defaultNextLinkName,
          itemName: operation.extensions[xmsPageable].itemName || defaultItemName,
          operationName: operation.extensions[xmsPageable].operationName,
          nextPageOperation: false,
        };

        const extensions = Object.assign({}, operation.extensions);
        delete extensions[xmsPageable];

        if (operation.extensions[xmsPageable].nextLinkName) {
          const nextPageOperation = new Operation(operation.extensions[xmsPageable].operationName || `${operation.language.default.name}Next`, '', operation);
          nextPageOperation.language.default.pageable = {
            pageType: getPageClass(operation, model),
            ipageType: operation.extensions[xmsPageable].nextLinkName ? 'Microsoft.Rest.Azure.IPage' : 'System.Collections.Generic.IEnumerable',
            nextLinkName: operation.extensions[xmsPageable].nextLinkName || defaultNextLinkName,
            itemName: operation.extensions[xmsPageable].itemName || defaultItemName,
            operationName: operation.extensions[xmsPageable].operationName || `${operation.language.default.name}Next`,
            nextPageOperation: true,
          };
          nextPageOperation.extensions = extensions;

          // Set operation name, the name initialization in new Operation() doesn't work
          nextPageOperation.language.default.name = nextPageOperation.language.default.pageable.operationName || `${nextPageOperation.language.default.pageable.operationName}Next`;
          operationGroup.operations.push(nextPageOperation);
        }
        operation.extensions = extensions;
      }
    }
  }
}

function correctParameterNames(model: SdkModel) {
  for (const operationGroup of model.operationGroups) {
    for (const operation of operationGroup.operations) {
      for (const parameter of values(operation.parameters)) {
        parameter.language.default.name = getEscapedReservedName(parameter.language.default.name, 'Parameter');
      }
      if (operation.requests) {
        // body parameters
        for (const parameter of values(operation.requests[0].parameters)) {
          parameter.language.default.name = getEscapedReservedName(parameter.language.default.name, 'Parameter');
        }
      }
    }
  }
}

async function nameStuffRight(state: State): Promise<SdkModel> {
  const resolver = new SchemaDefinitionResolver();
  const model = state.model;

  // set the namespace for the service
  const serviceNamespace = await state.getValue('namespace', 'Microsoft.Azure.Sample');
  const azure = await state.getValue('azure', false) || await state.getValue('azure-arm', false);
  const clientName = getPascalIdentifier(model.language.default.name);

  // dolauli see model.details.csharp for c# related staff
  // set c# client details (name)
  model.language.csharp = {
    ...model.language.default, // copy everything by default
    name: clientName,
    namespace: serviceNamespace,
    fullname: `${serviceNamespace}.${clientName}`
  };

  setSchemaNames(<Dictionary<Array<Schema>>><any>model.schemas, azure, serviceNamespace);
  duplicateLRO(model);
  addNextPageOperation(model);
  correctParameterNames(model);
  return model;
}

export async function csnamerSdk(service: Host) {
  const state = await new ModelState<SdkModel>(service).init();
  await service.WriteFile('sdk-code-model-v4-csnamer.yaml', serialize(await nameStuffRight(state)), undefined, 'code-model-v4');
}
