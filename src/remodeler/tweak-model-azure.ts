import { Model } from '#common/code-model/code-model';
import { isHttpOperation } from '#common/code-model/http-operation';
import { isSchemaObject, JsonType, Property } from '#common/code-model/schema';
import { items, keys, length, values } from '#common/dictionary';
import { ModelState } from '#common/model-state';
import { processCodeModel } from '#common/process-code-model';
import { map } from '#common/text-manipulation';
import { deserialize, serialize } from '#common/yaml';
import { ArtifactMessage, Channel, Host } from '@microsoft.azure/autorest-extension-base';

// Azure version -
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {

  // service.Message({ Channel: Channel.Debug, Text: "THIS IS THE AZURE TWEAKER" });

  // TODO:
  // look at models, and extract out any case that has an IRESOURCE, IPROXYRESOURCE, etc.
  // and use the common versions of those models.

  // Is the result marked x-ms-pagable?
  // identify the next link (null means just get the results as an array)
  // if nextLinkName is null, then it won't actually page, but we'd like to unroll the contents anyway.
  for (const operation of values(model.http.operations)) {
    if (operation.extensions['x-ms-pageable']) {
      // it's marked pagable.
      operation.details.default.pageable = {
        responseType: `pageable`,
        nextLinkName: operation.extensions['x-ms-pageable'].nextLinkName || undefined,
        itemName: operation.extensions['x-ms-pageable'].itemName || 'value',
        operationName: operation.extensions['x-ms-pageable'].operationName || `${operation.operationId}Next`,
      };
      continue;
    }

    // let's just check to see if it looks like it's supposed to be a collection
    for (const responses of values(operation.responses_new)) {
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
      delete operation.responses_new['201'];
      delete operation.responses_new['202'];

      delete operation.responses['201'];
      delete operation.responses['202'];
    }
  }
  return model;
}
