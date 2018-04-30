import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model } from "#common/code-model/code-model";
import { map } from "#common/text-manipulation";
import { isHttpOperation } from "#common/code-model/http-operation";

// Universal version - 
// tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return await processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {

  // consolodate compatible response types.
  map(model.http.operations, (key, operation) => {
    if (!isHttpOperation(operation)) return null;
    // TODO: mimetypes might start with the mimetype and have extra stuff after
    // this should be fixed if it happens.

    // if an operation response has a application/json and text/json, remove the text/json and add that mime type to the list of 'accepts'
    return map(operation.responses, (key, response) => {
      const content = response.content;
      if (content["application/json"] && content["text/json"]) {
        content["application/json"].accepts.push("text/json");
        delete content["text/json"];
        service.Message({
          Channel: Channel.Debug,
          Text: `operation '${operation.details.name}' lists both "application/json" and "text/json" -- these are being combined.`
        })

      }
      return null;
    });
  });
  return model;
}