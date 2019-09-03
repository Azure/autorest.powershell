/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType, knownMediaType, ParameterLocation, getPolymorphicBases, isSchemaObject, JsonType, Property, Schema, processCodeModel, StringFormat, codemodel, ModelState } from '@azure-tools/codemodel-v3';
import { pascalCase, deconstruct, fixLeadingNumber } from '@azure-tools/codegen';
import { items, keys, values, select, } from '@azure-tools/linq';

import { Channel, Host } from '@azure-tools/autorest-extension-base';
import { OAuthFlows } from '@azure-tools/codemodel-v3/dist/code-model/security-scheme';
import { parentPort } from 'worker_threads';

export const HeaderProperty = 'HeaderProperty';
export enum HeaderPropertyType {
  Header = 'Header',
  HeaderAndBody = 'HeaderAndBody'
}
type State = ModelState<codemodel.Model>;


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


function dropDuplicatePropertiesInChildSchemas(schema: Schema, state: State, map: Map<string, Property> = new Map()) {
  let success = true;
  for (const parent of schema.allOf) {
    // handle parents first
    if (!dropDuplicatePropertiesInChildSchemas(parent, state, map)) {
      return false;
    }
  }
  for (const { key: id, value: property } of items(schema.properties)) {
    // see if it's in the parent.
    const pProp = map.get(property.serializedName);
    if (pProp) {
      // if the parent prop is the same type as the child prop
      // we're going to drop the child property.
      if (pProp.schema.type === property.schema.type) {
        // if it's an object type, it has to be the exact same schema type too
        if (pProp.schema.type != JsonType.Object || pProp.schema === property.schema) {
          state.verbose(`Property '${property.serializedName}' in '${schema.details.default.name}' has a property the same as the parent, and is dropping the duplicate.`, {});
          delete schema.properties[id];
        } else {
          const conflict = `Property '${property.serializedName}' in '${schema.details.default.name}' has a conflict with a parent schema (allOf ${schema.allOf.joinWith(each => each.details.default.name)}.`;
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

async function tweakModel(state: State): Promise<codemodel.Model> {
  const title = pascalCase(fixLeadingNumber(deconstruct(await state.getValue('title', state.model.info.title))));
  state.setValue('title', title);

  const serviceName = await state.getValue('service-name', titleToAzureServiceName(title));
  state.setValue('service-name', serviceName);

  const model = state.model;

  const set = new Set<Schema>();
  const removes = new Set<string>();

  for (const key of keys(model.schemas)) {
    const value = model.schemas[key];
    if (set.has(value)) {
      // this schema is already in the collection. let's drop it when we're done
      removes.add(key);
    } else {
      set.add(value);
    }
  }

  // we're going to create a schema that represents the distinct sum 
  // of all operation PATH parameters
  const universalId = new Schema(`${serviceName}Identity`, {
    type: JsonType.Object, description: 'Resource Identity', details: {
      default: {
        uid: 'universal-parameter-type'
      }
    }
  });
  model.schemas['universal-parameter-type'] = universalId;

  for (const operation of values(model.http.operations)) {
    for (const param of operation.parameters.filter(each => each.in === ParameterLocation.Path)) {
      const name = param.details.default.name;
      if (!universalId.properties[name]) {
        universalId.properties[name] = new Property(name, {
          schema: param.schema, description: param.description, serializedName: name, details: {
            default: {
              description: param.description,
              name: name,
              required: false,
              readOnly: false,
              uid: `universal-parameter:${name}`
            }
          }
        });
      }
    }
  }

  if (await state.getValue('azure', false)) {
    universalId.properties['id'] = new Property('id', {
      schema: new Schema('_identity_type_', { type: JsonType.String, description: 'Resource identity path' }),
      description: 'Resource identity path', serializedName: 'id', details: {
        default: {
          description: 'Resource identity path',
          name: 'id',
          required: false,
          readOnly: false,
          uid: 'universal-parameter:resource identity'
        }
      }
    });
  }

  // remove schemas that are referenced elsewhere previously.
  for (const each of removes.values()) {
    delete model.schemas[each];
  }

  // if an operation has a response that has a schema with string/binary we should make the response  application/octet-stream
  for (const operation of values(model.http.operations)) {
    for (const responses of values(operation.responses)) {
      for (const response of responses) {
        if (response.schema) {
          if (response.schema.type === JsonType.String && response.schema.format === StringFormat.Binary) {
            response.mimeTypes = [KnownMediaType.Stream];
          }
        }
      }
    }
  }

  // schemas that have parents and implement properties that are in the parent schemas
  // will have the property dropped in the child schema
  for (const schema of values(model.schemas)) {
    if (schema.allOf.length > 0) {
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
    for (const operation of values(model.http.operations)) {
      for (const responses of values(operation.responses)) {
        for (const response of responses) {
          // for a given response, find the possible models that can be returned from the service
          for (const header of values(response.headers)) {

            if (!response.schema) {
              // no response schema? can we fake one?
              // service.Message({ Channel: Channel.Debug, Text: `${header.key} is in ${operation.details.default.name} but there is no response model` });
              continue;
            }

            // if the method response has a schema and it's an object, we're going to add our properties to the schema object.
            // yes, this means that the reponse model may have properties that are undefined if the server doesn't send back the header
            // and other operations might add other headers that are not the same.

            // if the method's response is a primitive value (string, boolean, null, number) or an array, we can't modify that type obviously
            // in which case, we're going to add a header

            // work with schemas that have objects only.

            if (isSchemaObject(response.schema)) {
              response.schema.details.default.hasHeaders = true;
              const property = response.schema.properties[header.key];
              if (!property) {
                state.message({ Channel: Channel.Debug, Text: `Adding header property '${header.key}' to model ${response.schema.details.default.name}` });

                // create a property for the header value
                const newProperty = new Property(header.key, { schema: header.schema, description: header.description });
                newProperty.details.default.name = header.key;
                newProperty.details.default.required = false;

                // mark it that it's a header-only property
                newProperty.details.default[HeaderProperty] = HeaderPropertyType.Header;

                // add it to this model.
                response.schema.properties[header.key] = newProperty;
              } else {
                // there is a property with this name already.
                // was this previously declared as a header only property?
                if (!property.details.default[HeaderProperty]) {

                  state.message({ Channel: Channel.Debug, Text: `Property ${header.key} in model ${response.schema.details.default.name} can also come from the header.` });
                  // no.. There is duplication between header and body property. Probably because of etags.
                  // tell it to be a header-and-body property.
                  property.details.default[HeaderProperty] = HeaderPropertyType.HeaderAndBody;
                  property.details.default.name = header.key;
                }
              }
            }
          }
        }
      }
    }
  }

  // remove well-known header parameters from operations and add mark the operation has supporting that feature

  for (const operation of values(model.http.operations)) {
    // if we have an operation with a body, and content-type is a multipart/formdata
    // then we should go thru the parameters of the body and look for a string/binary parameters
    // and remember to add another parameter for the filename of the string/binary
    if (operation.requestBody && knownMediaType(operation.requestBody.contentType) === KnownMediaType.Multipart) {
      for (const prop of values(operation.requestBody.schema.properties)) {
        if (prop.schema.type === JsonType.String && prop.schema.format === 'binary') {
          prop.details.default.isNamedStream = true;
        }
      }
    }

    // move well-known hearder parameters into details, and we can process them in the generator how we please.
    // operation.details.default.headerparameters = values(operation.parameters).linq.where(p => p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name)).linq.toArray();

    // remove if-match and if-none-match parameters from the operation itself.
    // operation.parameters = values(operation.parameters).linq.where(p => !(p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name))).linq.toArray();

  }

  // identify models that are polymorphic in nature
  for (const schema of values(model.schemas)) {
    // if this actual type is polymorphic, make sure we know that.
    if (schema.discriminator) {
      schema.details.default.isPolymorphic = true;
    }


    const parents = getPolymorphicBases(schema);
    if (parents.length > 0) {
      // if our parent is polymorphic, then we must have a discriminator value
      schema.details.default.discriminatorValue = schema.extensions['x-ms-discriminator-value'] || schema.details.default.name;

      // and make sure that all our polymorphic parents have a reference to this type.
      for (const parent of getPolymorphicBases(schema)) {

        parent.details.default.polymorphicChildren = parent.details.default.polymorphicChildren || new Array<Schema>();
        parent.details.default.polymorphicChildren.push(schema);
      }
    }
  }

  // identify parameters that are constants
  for (const operation of values(model.http.operations)) {
    for (const parameter of values(operation.parameters)) {
      if (parameter.required && parameter.schema.enum.length === 1) {
        // parameters with an enum single value are constants
        parameter.details.default.constantValue = parameter.schema.enum[0];
      }
    }
  }

  const enumsToSkip = new Set<string>();
  // identify properties that are constants
  for (const schema of values(model.schemas)) {
    for (const property of values(schema.properties)) {
      if (property.details.default.required && property.schema.enum.length === 1) {
        // properties with an enum single value are constants
        // add the constant value
        property.details.default.constantValue = property.schema.enum[0];

        // mark as skip the generation of this model
        enumsToSkip.add(property.schema.details.default.uid);

        // make it a string and keep its name
        property.schema = new Schema(property.schema.details.default.name, { type: property.schema.type });
      } else {
        enumsToSkip.delete(property.schema.details.default.uid);
      }
    }
  }

  // mark enums that shouldn't be generated
  for (const schema of values(model.schemas)) {
    if (enumsToSkip.has(schema.details.default.uid)) {
      schema.details.default.skip = true;
    }
  }

  for (const operation of values(model.http.operations)) {
    for (const { key: responseCode, value: responses } of items(operation.responses)) {
      for (const response of values(responses)) {
        if (responseCode === 'default' || response.extensions['x-ms-error-response'] === true) {
          response.details.default.isErrorResponse = true;
        }
      }
    }
  }

  return model;
}

// Universal version -
// tweaks the code model to adjust things so that the code will generate better.

export async function tweakModelPlugin(service: Host) {
  return processCodeModel(tweakModel, service, 'remodeler');
}
