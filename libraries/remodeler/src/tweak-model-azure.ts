/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { codemodel, JsonType, processCodeModel } from '@microsoft.azure/autorest.codegen';
import { keys, length, values } from '@microsoft.azure/autorest.codegen';

import { Host } from '@microsoft.azure/autorest-extension-base';

const xmsPageable = 'x-ms-pageable';
// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: codemodel.Model, service: Host): Promise<codemodel.Model> {

  // service.Message({ Channel: Channel.Debug, Text: "THIS IS THE AZURE TWEAKER" });

  // TODO:
  // look at models, and extract out any case that has an IRESOURCE, IPROXYRESOURCE, etc.
  // and use the common versions of those models.

  // Is the result marked x-ms-pagable?
  // identify the next link (null means just get the results as an array)
  // if nextLinkName is null, then it won't actually page, but we'd like to unroll the contents anyway.
  for (const operation of values(model.http.operations)) {
    if (operation.extensions[xmsPageable]) {
      // it's marked pagable.
      operation.details.default.pageable = {
        responseType: `pageable`,
        nextLinkName: operation.extensions[xmsPageable].nextLinkName || undefined,
        itemName: operation.extensions[xmsPageable].itemName || 'value',
        operationName: operation.extensions[xmsPageable].operationName || `${operation.operationId}Next`,
      };
      continue;
    }

    // let's just check to see if it looks like it's supposed to be a collection
    for (const responses of values(operation.responses)) {
      for (const response of values(responses)) {
        // does the response have a schema?
        if (response.schema) {
          const schema = response.schema;

          // is this just an array response?
          if (schema.type === JsonType.Array) {
            operation.details.default.pageable = {
              responseType: `array`,
            };
            continue;
          }

          // if it returns an object, let's see what's inside...
          if (schema.type === JsonType.Object) {

            // does it have  a single member that is an array (ie, value :  [...])
            if (length(schema.properties) === 1 && schema.allOf.length === 0) {
              const propertyName = keys(schema.properties).linq.first();
              if (propertyName) {
                const property = schema.properties[propertyName];
                if (property.schema.type === JsonType.Array) {
                  // nested array!
                  operation.details.default.pageable = {
                    responseType: `nested-array`,
                    itemName: propertyName,
                  };
                }
                continue;
              }
            }

            // does it kinda look like a x-ms-pagable (value/nextlink?)
            if (length(schema.properties) === 2 && schema.allOf.length === 0) {
              if (schema.properties.nextLink) {
                const propertyName = keys(schema.properties).linq.where(each => each !== 'nextLink').linq.first();
                if (propertyName) {
                  const property = schema.properties[propertyName];
                  if (property.schema.type === JsonType.Array) {
                    // nested array!
                    operation.details.default.pageable = {
                      responseType: `nested-array`,
                      itemName: propertyName,
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
  for (const operation of values(model.http.operations)) {
    if (operation.extensions['x-ms-long-running-operation']) {
      operation.details.default.asjob = true;

      operation.details.default.lro = operation.extensions['x-ms-long-running-operation-options'] || {
        'final-state-via': 'default'
      };

      // LRO 201 and 202 responses are handled internally, so remove any 201/202 responses in the operation
      delete operation.responses['201'];
      delete operation.responses['202'];
    }
  }
  return model;
}
