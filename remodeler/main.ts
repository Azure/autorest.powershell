import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { Remodeler } from "./remodeler";
import * as OpenAPI from "./oai3";
import { deserialize, serialize } from "./serialization";
import { writeFileSync } from "fs";
import { ModelState } from "#common/model-state";



export async function process(service: Host) {
  try {
    // Get the list of files 
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    const original = await service.ReadFile(files[0]);
    // writeFileSync("C:/work/2018/autorest.incubator/generated/original.yaml", serialize(JSON.parse(original)));

    // deserialize
    const remodeler = new Remodeler(new ModelState(service, await deserialize<OpenAPI.Model>(await service.ReadFile(files[0]), files[0]), files[0]));

    // go!
    const codeModel = remodeler.remodel();

    // console.error(require("util").inspect(codeModel));

    // output the model 
    await service.WriteFile("code-model-v2.yaml", serialize(codeModel), undefined/*,"code-model-v2"*/);

  } catch (E) {
    console.error(E);
  }
}