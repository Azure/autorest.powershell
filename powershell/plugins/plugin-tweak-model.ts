/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { Property, SealedChoiceSchema, codeModelSchema, CodeModel, StringSchema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, ChoiceSchema, Schema, ConstantSchema, ConditionalValue } from '@autorest/codemodel';
import { pascalCase, deconstruct, fixLeadingNumber, serialize, KnownMediaType } from '@azure-tools/codegen';
import { items, keys, values, Dictionary, length } from '@azure-tools/linq';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';

import { Channel, AutorestExtensionHost as Host, Session, startSession } from '@autorest/extension-base';
import { defaultCipherList } from 'constants';
import { String } from '../llcsharp/schema/string';
import { JsonType } from '../utils/schema';

export const HeaderProperty = 'HeaderProperty';
export enum HeaderPropertyType {
  Header = 'Header',
  HeaderAndBody = 'HeaderAndBody'
}
type State = ModelState<PwshModel>;


// For now, we are not dynamically changing the service-name. Instead, we would figure out a method to change it during the creation of service readme's.
export function titleToAzureServiceName(title: string): string {
  const titleCamelCase = pascalCase(deconstruct(title)).trim();
  const serviceName = titleCamelCase
    // Remove: !StartsWith(Management)AndContains(Management), Client, Azure, Microsoft, APIs, API, REST
    .replace(/(?!^Management)(?=.*)Management|Client|Azure|Microsoft|APIs|API|REST/g, '')
    // Remove: EndsWith(ServiceResourceProvider), EndsWith(ResourceProvider), EndsWith(DataPlane), EndsWith(Data)
    .replace(/ServiceResourceProvider$|ResourceProvider$|DataPlane$|Data$/g, '');
  return serviceName || titleCamelCase;
}


function dropDuplicatePropertiesInChildSchemas(schema: ObjectSchema, state: State, map: Map<string, Property> = new Map()) {
  let success = true;
  for (const parent of values(schema.parents?.immediate)) {
    //handle parents first
    if (!dropDuplicatePropertiesInChildSchemas(<ObjectSchema>parent, state, map)) {
      return false;
    }
  }
  for (const { key: id, value: property } of items(schema.properties)) {
    //see if it's in the parent.
    const pProp = map.get(property.serializedName);
    if (pProp) {
      //if the parent prop is the same type as the child prop
      //we're going to drop the child property.
      if (pProp.schema.type === property.schema.type) {
        //if it's an object type, it has to be the exact same schema type too
        if (pProp.schema.type != SchemaType.Object || pProp.schema === property.schema) {
          state.verbose(`Property '${property.serializedName}' in '${schema.language.default.name}' has a property the same as the parent, and is dropping the duplicate.`, {});
          if (schema.properties) {
            delete schema.properties[id];
          }
        } else {
          const conflict = `Property '${property.serializedName}' in '${schema.language.default.name}' has a conflict with a parent schema (allOf ${schema.parents?.immediate.joinWith(each => each.language.default.name)}.`;
          state.error(conflict, [], {});
          success = false;
        }
      }
    }
    else {
      map.set(property.serializedName, property);
    }
  }
  return success;
}

export async function tweakModelV2(state: State): Promise<PwshModel> {
  const title = pascalCase(fixLeadingNumber(deconstruct(await state.getValue('title', state.model.info.title))));
  state.setValue('title', title);

  const serviceName = await state.getValue('service-name', titleToAzureServiceName(title));
  state.setValue('service-name', serviceName);

  const model = state.model;
  const schemas = model.schemas;
  // xichen: do we need other schema types?
  const allSchemas: Array<Schema> = [...schemas.objects ?? [], ...schemas.choices ?? [], ...schemas.sealedChoices ?? []];

  model.commands = <any>{
    operations: new Dictionary<any>(),
    parameters: new Dictionary<any>(),
  };

  // we're going to create a schema that represents the distinct sum 
  // of all operation PATH parameters
  const universalId = new ObjectSchema(`${serviceName}Identity`, '');
  // xichen: Add 'universal-parameter-type' in language.default.uid, so that we can find it later
  universalId.language.default.uid = 'universal-parameter-type';
  universalId.apiVersions = universalId.apiVersions || [];
  state.model.schemas.objects = state.model.schemas.objects || [];
  (<any>universalId.language.default).uid = 'universal-parameter-type';
  state.model.schemas.objects.push(universalId);

  for (const group of values(model.operationGroups)) {
    for (const operation of values(group.operations)) {
      for (const response of values(operation.responses)) {
        // Mark returned object in response
        const respSchema: Schema = (<any>response).schema;
        if (respSchema?.type === SchemaType.Object) {
          respSchema.extensions = respSchema.extensions || {};
          respSchema.extensions['is-return-object'] = true;
        }
      }
      for (const param of values(operation.parameters).where(each => each.protocol?.http?.in === ParameterLocation.Path)) {
        const name = param.language.default.name;
        const hasName = universalId.properties?.find((prop) => prop.language.default.name.toLocaleLowerCase() === name.toLocaleLowerCase());
        if (!hasName) {
          if (!universalId.properties) {
            universalId.properties = [];
          }
          const newProp = new Property(name, param.language.default.description, param.schema);
          newProp.required = false;
          newProp.readOnly = false;
          newProp.serializedName = param.language.default.serializedName;
          universalId.properties.push(newProp);
        }
      }
    }
  }

  if (await state.getValue('azure', false)) {
    const idScheam = new Schema('_identity_type_', 'Resource identity path', SchemaType.String);
    const idProp = new Property('id', 'Resource identity path', idScheam);
    idProp.readOnly = false;
    idProp.required = false;
    idProp.language.default.uid = 'universal-parameter:resource identity';
    if (!universalId.properties) {
      universalId.properties = [];
    }
    universalId.properties.push(idProp);
  }

  // xichen: do nothing in m3 logic. Comment it out
  // if an operation has a response that has a schema with string/binary we should make the response  application/octet-stream
  // for (const operationGroups of values(model.operationGroups)) {
  //   for (const operation of values(operationGroups.operations)) {
  //     for (const response of values(operation.responses)) {
  //       if ((response as any).schema) {
  //         const respSchema = response as any;
  //         if (respSchema.type === SchemaType.String && respSchema.format === StringFormat.Binary) {
  //           // WHY WAS THIS HERE?!
  //           // response.mimeTypes = [KnownMediaType.Stream];
  //         }
  //       }
  //     }
  //   }
  // }

  // schemas that have parents and implement properties that are in the parent schemas
  // will have the property dropped in the child schema
  for (const schema of values(model.schemas.objects)) {
    if (length(schema.parents?.immediate) > 0) {
      if (!dropDuplicatePropertiesInChildSchemas(schema, state)) {
        throw new Error('Schemas are in conflict.');
      }
    }
  }


  if (await state.getValue('use-storage-pipeline', false)) {
    // we're going to create new models for the reponse headers ?

  } else {

    // if an operation has a body parameter with string/binary, we should make the request application/octet-stream

    // === Header Schemas ===
    // go thru the operations, find responses that have header values, and add a property to the schemas that are returned with those values
    for (const operationGroups of values(model.operationGroups)) {
      for (const operation of values(operationGroups.operations)) {
        for (const response of values(operation.responses)) {
          // for a given response, find the possible models that can be returned from the service
          for (const header of values(response.protocol.http?.headers)) {

            if (!(<any>response).schema) {
              // no response schema? can we fake one?
              // service.message{ Channel: Channel.Debug, Text: `${header.key} is in ${operation.details.default.name} but there is no response model` });
              continue;
            }


            // if the method response has a schema and it's an object, we're going to add our properties to the schema object.
            // yes, this means that the reponse model may have properties that are undefined if the server doesn't send back the header
            // and other operations might add other headers that are not the same.

            // if the method's response is a primitive value (string, boolean, null, number) or an array, we can't modify that type obviously
            // in which case, we're going to add a header

            // work with schemas that have objects only.

            if ((<any>response).schema.type === SchemaType.Object) {
              const respSchema = <ObjectSchema>((<any>response).schema);
              const curHeader = <any>header;
              const headerKey = <string>curHeader.header;

              respSchema.language.default.hasHeaders = true;

              const property = values(getAllProperties(respSchema)).first((each) => each.language.default.name === headerKey);
              if (!property) {
                state.message({ Channel: Channel.Debug, Text: `Adding header property '${headerKey}' to model ${respSchema.language.default.name}` });

                // create a property for the header value
                const newProperty = new Property(headerKey, curHeader.description || '', curHeader.schema);
                newProperty.language.default.required = false;

                // mark it that it's a header-only property
                newProperty.language.default[HeaderProperty] = HeaderPropertyType.Header;

                // add it to this model.
                if (!respSchema.properties) {
                  respSchema.properties = [];
                }
                respSchema.properties.push(newProperty);
              } else {
                // there is a property with this name already.
                // was this previously declared as a header only property?
                if (!property.language.default[HeaderProperty]) {

                  state.message({ Channel: Channel.Debug, Text: `Property ${headerKey} in model ${respSchema.language.default.name} can also come from the header.` });
                  // no.. There is duplication between header and body property. Probably because of etags.
                  // tell it to be a header-and-body property.
                  property.language.default[HeaderProperty] = HeaderPropertyType.HeaderAndBody;
                  property.language.default.name = headerKey;
                }
              }
            }
          }
        }
      }
    }
  }

  // remove well-known header parameters from operations and add mark the operation has supporting that feature

  for (const operationGroups of values(model.operationGroups)) {
    for (const operation of values(operationGroups.operations)) {
      // if we have an operation with a body, and content-type is a multipart/formdata
      // then we should go thru the parameters of the body and look for a string/binary parameters
      // and remember to add another parameter for the filename of the string/binary
      const request = operation.requests?.[0];
      request?.parameters?.filter((param) => param.schema.type !== SchemaType.Object && param.protocol.http?.in === 'body' && param.protocol.http?.style === KnownMediaType.Multipart)
        .forEach((param) => {
          for (const prop of values(getAllProperties(<ObjectSchema>param.schema))) {
            if (prop.schema.type === SchemaType.Binary) {
              prop.language.default.isNamedStream = true;
            }
          }
        });

      // move well-known hearder parameters into details, and we can process them in the generator how we please.
      // operation.details.default.headerparameters = values(operation.parameters).where(p => p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name)).toArray();

      // remove if-match and if-none-match parameters from the operation itself.
      // operation.parameters = values(operation.parameters).where(p => !(p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name))).toArray();

    }
  }

  // identify models that are polymorphic in nature
  for (const schema of allSchemas) {
    if (schema instanceof ObjectSchema) {
      const objSchema = <ObjectSchema>schema;
      // if this actual type is polymorphic, make sure we know that.
      // parent class
      if (objSchema.discriminator) {
        objSchema.language.default.isPolymorphic = true;
        if (objSchema.children) {
          objSchema.language.default.polymorphicChildren = objSchema.children?.all;
        }
      }

      // sub class
      if (objSchema.discriminatorValue) {
        objSchema.language.default.discriminatorValue = objSchema.extensions?.['x-ms-discriminator-value'];
      }
    }
  }

  // identify parameters that are constants
  for (const group of values(model.operationGroups)) {
    for (const operation of values(group.operations)) {
      for (const parameter of values(operation.parameters)) {
        if (parameter.required) {
          if (parameter.schema.type === SchemaType.Choice) {
            const choiceSchema = <ChoiceSchema>parameter.schema;
            if (choiceSchema.choices.length === 1) {
              parameter.language.default.constantValue = choiceSchema.choices[0].value;
            }
          } else if (parameter.schema.type === SchemaType.Constant) {
            const constantSchema = <ConstantSchema>parameter.schema;
            parameter.language.default.constantValue = constantSchema.value.value;
          } else if (parameter.schema.type === SchemaType.SealedChoice) {
            const sealedChoiceSchema = <SealedChoiceSchema>parameter.schema;
            if (sealedChoiceSchema.choices.length === 1) {
              parameter.language.default.constantValue = sealedChoiceSchema.choices[0].value;
              if (sealedChoiceSchema.language.default.skip !== false) {
                sealedChoiceSchema.language.default.skip = true;
              }
            }
          }
        } else {
          if (parameter.schema.type === SchemaType.SealedChoice) {
            const sealedChoiceSchema = <SealedChoiceSchema>parameter.schema;
            if (sealedChoiceSchema.choices.length === 1) {
              sealedChoiceSchema.language.default.skip = false;
            }
          }
        }
      }
    }
  }

  // identify properties that are constants
  for (const schema of values(schemas.objects)) {
    for (const property of values(schema.properties)) {
      if (property === undefined) {
        continue;
      }
      if (property.required) {
        if (property.schema.type === SchemaType.Choice) {
          const choiceSchema = <ChoiceSchema>property.schema;
          if (choiceSchema.choices.length === 1) {
            // properties with an enum single value are constants
            // add the constant value
            property.language.default.constantValue = choiceSchema.choices[0].value;
          }
        } else if (property.schema.type === SchemaType.Constant) {
          const constantSchema = <ConstantSchema>property.schema;
          property.language.default.constantValue = constantSchema.value.value;
        } else if (property.schema.type === SchemaType.SealedChoice) {
          const sealedChoiceSchema = <SealedChoiceSchema>property.schema;
          if (sealedChoiceSchema.choices.length === 1) {
            property.language.default.constantValue = sealedChoiceSchema.choices[0].value;
            if (sealedChoiceSchema.language.default.skip !== false) {
              sealedChoiceSchema.language.default.skip = true;
            }
          }
        }
      } else {
        if (property.schema.type === SchemaType.SealedChoice) {
          const sealedChoiceSchema = <SealedChoiceSchema>property.schema;
          if (sealedChoiceSchema.choices.length === 1) {
            sealedChoiceSchema.language.default.skip = false;
          }
        }
      }
    }
  }

  // xichen: Do we need skip?
  //   const enumsToSkip = new Set<string>();
  //   // identify properties that are constants
  //   for (const schema of values(model.schemas)) {
  //     for (const property of values(schema.properties)) {
  //       if (property.details.default.required && length(property.schema.enum) === 1) {
  //         // properties with an enum single value are constants
  //         // add the constant value
  //         property.details.default.constantValue = property.schema.enum[0];

  //         // mark as skip the generation of this model
  //         enumsToSkip.add(property.schema.details.default.uid);

  //         // make it a string and keep its name
  //         property.schema = new Schema(property.schema.details.default.name, { type: property.schema.type });
  //       } else {
  //         enumsToSkip.delete(property.schema.details.default.uid);
  //       }
  //     }
  //   }

  //   // mark enums that shouldn't be generated
  //   for (const schema of values(model.schemas)) {
  //     if (enumsToSkip.has(schema.details.default.uid)) {
  //       schema.details.default.skip = true;
  //     }
  //   }

  return model;
}
// async function tweakModel(state: State): Promise<codemodel.Model> {
//   const title = pascalCase(fixLeadingNumber(deconstruct(await state.getValue('title', state.model.info.title))));
//   state.setValue('title', title);

//   const serviceName = await state.getValue('service-name', titleToAzureServiceName(title));
//   state.setValue('service-name', serviceName);

//   const model = state.model;
//   model.schemas = model.schemas || [];

//   const set = new Set<Schema>();
//   const removes = new Set<string>();

//   for (const key of keys(model.schemas)) {
//     const value = model.schemas[key];
//     if (set.has(value)) {
//       // this schema is already in the collection. let's drop it when we're done
//       removes.add(key);
//     } else {
//       set.add(value);
//     }
//   }

//   // we're going to create a schema that represents the distinct sum 
//   // of all operation PATH parameters
//   const universalId = new Schema(`${serviceName}Identity`, {
//     type: JsonType.Object, description: 'Resource Identity', details: {
//       default: {
//         uid: 'universal-parameter-type'
//       }
//     }
//   });
//   model.schemas['universal-parameter-type'] = universalId;

//   for (const operation of values(model.http.operations)) {
//     for (const param of values(operation.parameters).where(each => each.in === ParameterLocation.Path)) {
//       const name = param.details.default.name;
//       if (!universalId.properties[name]) {
//         universalId.properties[name] = new Property(name, {
//           schema: param.schema, description: param.description, serializedName: name, details: {
//             default: {
//               description: param.description,
//               name: name,
//               required: false,
//               readOnly: false,
//               uid: `universal-parameter:${name}`
//             }
//           }
//         });
//       }
//     }
//   }

//   if (await state.getValue('azure', false)) {
//     universalId.properties['id'] = new Property('id', {
//       schema: new Schema('_identity_type_', { type: JsonType.String, description: 'Resource identity path' }),
//       description: 'Resource identity path', serializedName: 'id', details: {
//         default: {
//           description: 'Resource identity path',
//           name: 'id',
//           required: false,
//           readOnly: false,
//           uid: 'universal-parameter:resource identity'
//         }
//       }
//     });
//   }

//   // remove schemas that are referenced elsewhere previously.
//   for (const each of removes.values()) {
//     delete model.schemas[each];
//   }

//   // if an operation has a response that has a schema with string/binary we should make the response  application/octet-stream
//   for (const operation of values(model.http.operations)) {
//     for (const responses of values(operation.responses)) {
//       for (const response of responses) {
//         if (response.schema) {
//           if (response.schema.type === JsonType.String && response.schema.format === StringFormat.Binary) {
//             // WHY WAS THIS HERE?!
//             // response.mimeTypes = [KnownMediaType.Stream];
//           }
//         }
//       }
//     }
//   }

//   // schemas that have parents and implement properties that are in the parent schemas
//   // will have the property dropped in the child schema
//   for (const schema of values(model.schemas)) {
//     if (length(schema.allOf) > 0) {
//       if (!dropDuplicatePropertiesInChildSchemas(schema, state)) {
//         throw new Error('Schemas are in conflict.');
//       }
//     }
//   }


//   if (await state.getValue('use-storage-pipeline', false)) {
//     // we're going to create new models for the reponse headers ?

//   } else {

//     // if an operation has a body parameter with string/binary, we should make the request application/octet-stream

//     // === Header Schemas ===
//     // go thru the operations, find responses that have header values, and add a property to the schemas that are returned with those values
//     for (const operation of values(model.http.operations)) {
//       for (const responses of values(operation.responses)) {
//         for (const response of responses) {
//           // for a given response, find the possible models that can be returned from the service
//           for (const header of values(response.headers)) {

//             if (!response.schema) {
//               // no response schema? can we fake one?
//               // service.message{ Channel: Channel.Debug, Text: `${header.key} is in ${operation.details.default.name} but there is no response model` });
//               continue;
//             }

//             // if the method response has a schema and it's an object, we're going to add our properties to the schema object.
//             // yes, this means that the reponse model may have properties that are undefined if the server doesn't send back the header
//             // and other operations might add other headers that are not the same.

//             // if the method's response is a primitive value (string, boolean, null, number) or an array, we can't modify that type obviously
//             // in which case, we're going to add a header

//             // work with schemas that have objects only.

//             if (isSchemaObject(response.schema)) {
//               response.schema.details.default.hasHeaders = true;
//               const property = response.schema.properties[header.key];
//               if (!property) {
//                 state.message({ Channel: Channel.Debug, Text: `Adding header property '${header.key}' to model ${response.schema.details.default.name}` });

//                 // create a property for the header value
//                 const newProperty = new Property(header.key, { schema: header.schema, description: header.description });
//                 newProperty.details.default.name = header.key;
//                 newProperty.details.default.required = false;

//                 // mark it that it's a header-only property
//                 newProperty.details.default[HeaderProperty] = HeaderPropertyType.Header;

//                 // add it to this model.
//                 response.schema.properties[header.key] = newProperty;
//               } else {
//                 // there is a property with this name already.
//                 // was this previously declared as a header only property?
//                 if (!property.details.default[HeaderProperty]) {

//                   state.message({ Channel: Channel.Debug, Text: `Property ${header.key} in model ${response.schema.details.default.name} can also come from the header.` });
//                   // no.. There is duplication between header and body property. Probably because of etags.
//                   // tell it to be a header-and-body property.
//                   property.details.default[HeaderProperty] = HeaderPropertyType.HeaderAndBody;
//                   property.details.default.name = header.key;
//                 }
//               }
//             }
//           }
//         }
//       }
//     }
//   }

//   // remove well-known header parameters from operations and add mark the operation has supporting that feature

//   for (const operation of values(model.http.operations)) {
//     // if we have an operation with a body, and content-type is a multipart/formdata
//     // then we should go thru the parameters of the body and look for a string/binary parameters
//     // and remember to add another parameter for the filename of the string/binary
//     if (operation.requestBody && knownMediaType(operation.requestBody.contentType) === KnownMediaType.Multipart) {
//       for (const prop of values(operation.requestBody.schema.properties)) {
//         if (prop.schema.type === JsonType.String && prop.schema.format === 'binary') {
//           prop.details.default.isNamedStream = true;
//         }
//       }
//     }

//     // move well-known hearder parameters into details, and we can process them in the generator how we please.
//     // operation.details.default.headerparameters = values(operation.parameters).where(p => p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name)).toArray();

//     // remove if-match and if-none-match parameters from the operation itself.
//     // operation.parameters = values(operation.parameters).where(p => !(p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name))).toArray();

//   }

//   // identify models that are polymorphic in nature
//   for (const schema of values(model.schemas)) {
//     // if this actual type is polymorphic, make sure we know that.
//     if (schema.discriminator) {
//       schema.details.default.isPolymorphic = true;
//     }


//     const parents = getPolymorphicBases(schema);
//     if (length(parents) > 0) {
//       // if our parent is polymorphic, then we must have a discriminator value
//       schema.details.default.discriminatorValue = schema.extensions['x-ms-discriminator-value'] || schema.details.default.name;

//       // and make sure that all our polymorphic parents have a reference to this type.
//       for (const parent of getPolymorphicBases(schema)) {

//         parent.details.default.polymorphicChildren = parent.details.default.polymorphicChildren || new Array<Schema>();
//         parent.details.default.polymorphicChildren.push(schema);
//       }
//     }
//   }

//   // identify parameters that are constants
//   for (const operation of values(model.http.operations)) {
//     for (const parameter of values(operation.parameters)) {
//       if (parameter.required && length(parameter.schema.enum) === 1) {
//         // parameters with an enum single value are constants
//         parameter.details.default.constantValue = parameter.schema.enum[0];
//       }
//     }
//   }

//   const enumsToSkip = new Set<string>();
//   // identify properties that are constants
//   for (const schema of values(model.schemas)) {
//     for (const property of values(schema.properties)) {
//       if (property.details.default.required && length(property.schema.enum) === 1) {
//         // properties with an enum single value are constants
//         // add the constant value
//         property.details.default.constantValue = property.schema.enum[0];

//         // mark as skip the generation of this model
//         enumsToSkip.add(property.schema.details.default.uid);

//         // make it a string and keep its name
//         property.schema = new Schema(property.schema.details.default.name, { type: property.schema.type });
//       } else {
//         enumsToSkip.delete(property.schema.details.default.uid);
//       }
//     }
//   }

//   // mark enums that shouldn't be generated
//   for (const schema of values(model.schemas)) {
//     if (enumsToSkip.has(schema.details.default.uid)) {
//       schema.details.default.skip = true;
//     }
//   }

//   for (const operation of values(model.http.operations)) {
//     for (const { key: responseCode, value: responses } of items(operation.responses)) {
//       for (const response of values(responses)) {
//         if (responseCode === 'default' || response.extensions['x-ms-error-response'] === true) {
//           response.details.default.isErrorResponse = true;
//         }
//       }
//     }
//   }

//   return model;
// }

// Universal version -
// tweaks the code model to adjust things so that the code will generate better.

export async function tweakModelPlugin(service: Host) {
  //const session = await startSession<PwshModel>(service, {}, codeModelSchema);
  const state = await new ModelState<PwshModel>(service).init();
  //const result = tweakModelV2(session);
  await service.writeFile({ filename: 'code-model-v4-tweakcodemodel-v2.yaml', content: serialize(await tweakModelV2(state)), sourceMap: undefined, artifactType: 'code-model-v4' });
  //return processCodeModel(tweakModelV2, service, 'tweakcodemodel-v2');
}
