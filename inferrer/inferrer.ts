import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { ModelState } from "#common/model-state";
import { Model } from "remodeler/code-model";
import { deconstruct, fixLeadingNumber, pascalCase, camelCase } from "#common/text-manipulation";

export async function process(service: Host) {
  try {
    // Get the list of files 
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    const original = await service.ReadFile(files[0]);

    // deserialize
    const codeModel = await deserialize<Model>(await service.ReadFile(files[0]), files[0]);



    // output the model 
    await service.WriteFile("code-model-v2.yaml", serialize(codeModel), undefined/*,"code-model-v2"*/);

  } catch (E) {
    console.error(E);
  }
}