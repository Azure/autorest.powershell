import { processCodeModel } from "#common/process-code-model";
import { Host } from "@microsoft.azure/autorest-extension-base";
import { Model } from "#common/code-model/code-model";

export async function process(service: Host) {
  return await processCodeModel(inferStuff, service);
}

async function inferStuff(model: Model, service: Host): Promise<Model> {
  return model;
}