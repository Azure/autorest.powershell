import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model, isHttpOperation } from "#remodeler/code-model";
import { map } from "#common/text-manipulation";

// Azure version - 
// Additional tweaks the code model to adjust things so that the code will generate better.

export async function process(service: Host) {
  return await processCodeModel(tweakModel, service);
}

async function tweakModel(model: Model, service: Host): Promise<Model> {
  // service.Message({ Channel: Channel.Debug, Text: "THIS IS THE AZURE TWEAKER" });

  return model;
}