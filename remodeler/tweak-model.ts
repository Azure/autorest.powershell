import { Host, ArtifactMessage, Channel } from '@microsoft.azure/autorest-extension-base';
import { deserialize, serialize } from '#common/yaml';
import { processCodeModel } from '#common/process-code-model';
import { ModelState } from '#common/model-state';
import { Model } from '#common/code-model/code-model';
import { map } from '#common/text-manipulation';
import { isHttpOperation } from '#common/code-model/http-operation';
import { values, items } from '#common/dictionary';
import { isSchemaObject, Property } from '#common/code-model/schema';

export const HeaderProperty = "HeaderProperty";
export enum HeaderPropertyType {
  Header = "Header",
  HeaderAndBody = "HeaderAndBody"
}

// Universal version - 
// tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return await processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {

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
          Text: `operation '${operation.details.name}' lists both "application/json" and "text/json" -- these are being combined.`
        })
      }
    };
  };

  // === Header Schemas ===
  // go thru the operations, find responses that have header values, and add a property to the schemas that are returned with those values
  for (const operation of values(model.http.operations)) {
    for (const response of values(operation.responses)) {
      for (const header of items(response.headers)) {

        // for a given response, find the possible models that can be returned from the service
        for (const mediaType of values(response.content)) {

          // work with schemas that have objects only. 
          if (isSchemaObject(mediaType.schema)) {
            const property = mediaType.schema.properties[header.key];
            if (!property) {
              service.Message({ Channel: Channel.Debug, Text: `Adding header property ${header.key} to model ${mediaType.schema.details.name}` });

              // create a property for the header value
              const newProperty = new Property(header.key, { schema: header.value.schema, description: header.value.description });

              // mark it that it's a header-only property
              newProperty.details[HeaderProperty] = HeaderPropertyType.Header;

              // add it to this model.
              mediaType.schema.properties[header.key] = newProperty;
            }
            else {
              // there is a property with this name already.
              // was this previously declared as a header only property?
              if (!property.details[HeaderProperty]) {

                service.Message({ Channel: Channel.Debug, Text: `Property ${header.key} in model ${mediaType.schema.details.name} can also come from the header.` });
                // no.. There is duplication between header and body property. Probably because of etags.
                // tell it to be a header-and-body property.
                property.details[HeaderProperty] = HeaderPropertyType.HeaderAndBody;
              }
            }
          }
        }
      }
    }
  }

  return model;
}