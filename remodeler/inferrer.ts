import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model } from "remodeler/code-model";
import { map } from "#common/text-manipulation";

export async function process(service: Host) {
  return await processCodeModel(inferStuff, service);
}

async function inferStuff(model: Model, service: Host): Promise<Model> {
  map(model.components.operations, (key, operation) => {
    // TODO: mimetypes might start with the mimetype and have extra stuff after
    // this should be fixed if it happens.

    // if an operation response has a application/json and text/json, remove the text/json and add that mime type to the list of 'accepts'
    return map(operation.responses, (key, response) => {
      const content = response.content;
      if (content["application/json"] && content["text/json"]) {
        content["application/json"].accepts.push("text/json");
        delete content["text/json"];
      }
      return null;
    });
  });
  return model;
}