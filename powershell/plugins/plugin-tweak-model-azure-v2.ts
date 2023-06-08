/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { keys, length, values } from '@azure-tools/linq';

import { Channel, Host } from '@autorest/extension-base';
import { ModelState } from '../utils/model-state';
import { PwshModel } from '../utils/PwshModel';
import { getAllProperties, ObjectSchema, Response, SchemaType, Schema } from '@autorest/codemodel';
import { serialize } from '@azure-tools/codegen';
type State = ModelState<PwshModel>;

const xmsPageable = 'x-ms-pageable';

async function tweakModel(state: State): Promise<PwshModel> {
  const model = state.model;

  // service.Message({ Channel: Channel.Debug, Text: "THIS IS THE AZURE TWEAKER" });

  // TODO:
  // look at models, and extract out any case that has an IRESOURCE, IPROXYRESOURCE, etc.
  // and use the common versions of those models.

  // Is the result marked x-ms-pagable?
  // identify the next link (null means just get the results as an array)
  // if nextLinkName is null, then it won't actually page, but we'd like to unroll the contents anyway.
  for (const group of values(model.operationGroups)) {
    for (const operation of values(group.operations)) {
      if (operation.extensions && operation.extensions[xmsPageable]) {
        // it's marked pagable.
        operation.language.default.pageable = {
          responseType: 'pageable',
          nextLinkName: operation.extensions[xmsPageable].nextLinkName || undefined,
          itemName: operation.extensions[xmsPageable].itemName || 'value',
          operationName: operation.extensions[xmsPageable].operationName || `${operation.language.default.name}Next`,
        };
        continue;
      }

      // let's just check to see if it looks like it's supposed to be a collection
      for (const response of values(operation.responses)) {
        // does the response have a schema?
        // TODO: check schema
        if (getSchema(response)) {
          const schema = getSchema(response);

          // is this just an array response?
          if (schema.type === SchemaType.Array) {
            operation.language.default.pageable = {
              responseType: 'array',
            };
            continue;
          }

          // if it returns an object, let's see what's inside...
          if (schema.type === SchemaType.Object) {
            const objSchema = <ObjectSchema>schema;

            // does it have  a single member that is an array (ie, value :  [...])
            if (length(objSchema.properties) === 1 && !objSchema.parents) {
              const property = objSchema.properties?.[0];
              if (property) {
                if (property.schema.type === SchemaType.Array) {
                  // nested array!
                  operation.language.default.pageable = {
                    responseType: 'nested-array',
                    itemName: property.serializedName,
                  };
                }
                continue;
              }
            }

            // xichen: If response schema has only 2 properties and one of it is nextLink, the other is array

            // does it kinda look like a x-ms-pagable (value/nextlink?)
            if (length(objSchema.properties) === 2 && !objSchema.parents) {
              const hasNextLink = objSchema.properties?.some((prop) => prop.serializedName === 'nextLink');
              if (hasNextLink) {
                const property = objSchema.properties?.find((prop) => prop.serializedName !== 'nextLink');
                if (property) {
                  if (property.schema.type === SchemaType.Array) {
                    // nested array!
                    operation.language.default.pageable = {
                      responseType: 'nested-array',
                      itemName: property.serializedName,
                      nextLinkName: 'nextLink'
                    };
                  }
                  continue;
                }
              }

            }

          }
        }
      }
    }
  }


  // make sure that all operations with lro have an options block.
  for (const group of values(model.operationGroups)) {
    for (const operation of values(group.operations)) {
      if (operation.extensions && operation.extensions['x-ms-long-running-operation']) {
        operation.language.default.asjob = true;

        operation.language.default.lro = operation.extensions['x-ms-long-running-operation-options'] || {
          'final-state-via': 'default'
        };

        // LRO 201 and 202 responses are handled internally, so remove any 201/202 responses in the operation
        operation.responses = (<Array<Response>>(operation.responses)).filter(each => each.protocol.http?.statusCodes[0] !== '201' && each.protocol.http?.statusCodes[0] !== '202');
        //delete operation.responses['201'];
        //delete operation.responses['202'];
      }
    }
  }

  // xichen: Cannot find 'x-ms-metadata' from swagger repo. Are we still using it?

  // Api Version parameter handling for Azure.
  // if there is only a single api-version for the operation, let's just make it a constant
  // otherwise, we need to make it selectable, but default to the 'latest' version there is.
  for (const group of values(model.operationGroups)) {
    for (const operation of values(group.operations)) {
      const apiVersions = operation.apiVersions;
      for (const parameter of values(operation.parameters)) {

        if (parameter.language.default.serializedName === 'api-version') {
          // only set it if it hasn't been set yet.
          // if (parameter.details.default.constantValue) {
          //continue;
          //}

          if (apiVersions) {
            // set the constant value to the first one
            if (length(apiVersions) === 1) {
              parameter.language.default.constantValue = apiVersions[0].version;
              continue;
            }

            // otherwise, the parameter can't have a constant value
            parameter.language.default.constantValue = undefined;

            // mark it so that we can add profile support in the method generation
            parameter.language.default.apiversion = true;
          }
        }
      }
    }
  }

  // when make-sub-resources-byreference is specified, mark models with a writable id as byref.
  if (await state.getValue('azure', false) && await state.getValue('make-sub-resources-byreference', false)) {

    for (const schema of values(model.schemas.objects ?? [])) {
      // find schemas that have an 'id' and are not readonly
      if (values(getAllProperties(schema)).any(prop => prop.serializedName === 'id' && !prop.language.default.readOnly)) {

        // look thru the operations, and the PUT methods 
        for (const group of model.operationGroups) {
          for (const op of values(group.operations)) {
            for (const request of op.requests ?? []) {

              if (request.protocol.http?.method === 'put') {
                for (const response of op.responses ?? []) {
                  // see if any of the responses have the same schema as we are looking for 
                  if (getSchema(response) === schema) {
                    // tell it not to inline that 
                    schema.language.default.byReference = true;
                    break;
                  }
                }
                break;
              }

            }
          }
        }
      }
    }
  }

  return model;
}

function getSchema(response: Response): Schema {
  return (<any>response).schema;
}

// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function tweakModelAzurePluginV2(service: Host) {
  const state = await new ModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-tweakcodemodelazure-v2.yaml', serialize(await tweakModel(state)), undefined, 'code-model-v4');
}
