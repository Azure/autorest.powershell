import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model } from "remodeler/code-model";

export async function process(service: Host) {
  return await processCodeModel(inferStuff, service);
}

async function inferStuff(model: Model, service: Host): Promise<Model> {
  return model;
}