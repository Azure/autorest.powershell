import { Model } from '#common/code-model/code-model';
import { ParameterLocation } from '#common/code-model/http-operation';
import { getPolymorphicBases, isSchemaObject, Property, Schema, JsonType } from '#common/code-model/schema';
import { items, values } from '#common/dictionary';
import { processCodeModel } from '#common/process-code-model';
import { Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { StringFormat } from '#remodeler/known-format';
import { KnownMediaType } from '#common/media-types';

export const HeaderProperty = 'HeaderProperty';
export enum HeaderPropertyType {
  Header = 'Header',
  HeaderAndBody = 'HeaderAndBody'
}

// Universal version -
// tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return await processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {
  /* REMOVE THIS -- not handled here anymore   
    // consolodate compatible response types.
    for (const operation of values(model.http.operations)) {
      // TODO: mimetypes might start with the mimetype and have extra stuff after
      // this should be fixed if it happens.
  
      // if an operation response has a application/json and text/json, remove the text/json and add that mime type to the list of 'accepts'
      for (const response of values(operation.responses)) {
        const content = response.content;
        if (content['application/json'] && content['text/json']) {
          content['application/json'].accepts.push('text/json');
          delete content['text/json'];
          service.Message({
            Channel: Channel.Debug,
            Text: `operation '${operation.details.default.name}' lists both "application/json" and "text/json" -- these are being combined.`
          });
        }
      }
    }
  */

  // if an operation has a response that has a schema with string/binary we should make the response  application/octet-stream
  for (const operation of values(model.http.operations)) {
    for (const { key: responseCode, value: responses } of items(operation.responses_new)) {
      for (const response of responses) {
        if (response.schema) {
          if (response.schema.type === JsonType.String && response.schema.format === StringFormat.Binary) {
            response.mimeTypes = [KnownMediaType.Stream];
          }
        }
      }
    }
  }

  if (await service.GetValue('use-storage-pipeline')) {
    // we're going to create new models for the reponse headers ?

  } else {

    // if an operation has a body parameter with string/binary, we should make the request application/octet-stream

    // === Header Schemas ===
    // go thru the operations, find responses that have header values, and add a property to the schemas that are returned with those values
    for (const operation of values(model.http.operations)) {
      for (const { key: mediaType, value: responses } of items(operation.responses_new)) {
        for (const response of responses) {
          // for a given response, find the possible models that can be returned from the service
          for (const header of items(response.headers)) {

            if (!response.schema) {
              // no response schema? can we fake one?
              service.Message({ Channel: Channel.Debug, Text: `${header.key} is in ${operation.details.default.name} but there is no response model` });
            }

            // if the method response has a schema and it's an object, we're going to add our properties to the schema object. 
            // yes, this means that the reponse model may have properties that are undefined if the server doesn't send back the header
            // and other operations might add other headers that are not the same. 

            // if the method's response is a primitive value (string, boolean, null, number) or an array, we can't modify that type obviously
            // in which case, we're going to add a header

            // work with schemas that have objects only.

            if (isSchemaObject(response.schema)) {
              const property = response.schema.properties[header.key];
              if (!property) {
                service.Message({ Channel: Channel.Debug, Text: `Adding header property ${header.key} to model ${response.schema.details.default.name}` });

                // create a property for the header value
                const newProperty = new Property(header.key, { schema: header.value.schema, description: header.value.description });

                // mark it that it's a header-only property
                newProperty.details.default[HeaderProperty] = HeaderPropertyType.Header;

                // add it to this model.
                response.schema.properties[header.key] = newProperty;
              } else {
                // there is a property with this name already.
                // was this previously declared as a header only property?
                if (!property.details[HeaderProperty]) {

                  service.Message({ Channel: Channel.Debug, Text: `Property ${header.key} in model ${response.schema.details.name} can also come from the header.` });
                  // no.. There is duplication between header and body property. Probably because of etags.
                  // tell it to be a header-and-body property.
                  property.details.default[HeaderProperty] = HeaderPropertyType.HeaderAndBody;
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
    // move well-known hearder parameters into details, and we can process them in the generator how we please.
    operation.details.default.headerparameters = values(operation.parameters).linq.where(p => p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name)).linq.toArray();

    //
    operation.parameters = values(operation.parameters).linq.where(p => !(p.in === ParameterLocation.Header && ['If-Match', 'If-None-Match'].includes(p.name))).linq.toArray();

    /*
        for (const parameter of values(operation.parameters).linq.where(p => p.in === ParameterLocation.Header && p.name === 'if-match')) {
          switch (parameter.name) {
            case 'if-match':
              operation.details.ifmatch = parameter;
              remove.push(parameter.name);
              break;

            default:

          }
        }
        operation.parameters = operation.parameters.filter(each => remove.includes(each.name));
        */
  }

  // identify models that are polymorphic in nature
  for (const schema of values(model.schemas)) {
    // if this actual type is polymorphic, make sure we know that.
    if (schema.discriminator) {
      schema.details.default.isPolymorphic = true;
    }

    // make sure that all our polymorphic parents have a reference to this type.
    for (const parent of getPolymorphicBases(schema)) {
      parent.details.polymorphicChildren = parent.details.polymorphicChildren || new Array<Schema>();
      parent.details.polymorphicChildren.push(schema);
    }
  }

  // identify parameters that are constants
  for (const operation of values(model.http.operations)) {
    for (const parameter of values(operation.parameters)) {
      if (parameter.schema.enum.length === 1) {
        // parameters with an enum single value are constants
        parameter.details.default.constantValue = parameter.schema.enum[0];
      }


      if (parameter.name === 'api-version') {

        // only set it if it hasn't been set yet.
        if (!parameter.details.default.constantValue) {
          // api-version constant parameter pulls value from the model/info/version
          parameter.details.default.constantValue = model.info.version;
        }

        if (!parameter.details.default.constantValue) {
          // um... api-version didn't have an enum, and we didn't get from model.info.version.
          // that's not cool.
          service.Message({ Channel: Channel.Error, Text: `Parameter 'api-version' doesn't have a single enum-value, and model.info.version is '${model.info.version}' ` });
        }
      }
    }
  }

  for (const operation of values(model.http.operations)) {
    for (const { key: responseCode, value: responses } of items(operation.responses_new)) {
      for (const response of values(responses)) {
        if (responseCode === 'default' || response.extensions['x-ms-error-response'] === true) {
          response.details.default.isErrorResponse = true;
        }
      }
    }
  }

  return model;
}

