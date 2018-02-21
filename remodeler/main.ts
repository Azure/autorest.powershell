import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { Remodeler } from "./remodeler";
import * as OpenAPI from "./oai3";
import { deserialize, serialize } from "./serialization";

export async function process(service: Host) {
  try {
    // Get the list of files 
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    // deserialize
    const remodeler = new Remodeler(await deserialize<OpenAPI.Model>(await service.ReadFile(files[0]), files[0]), service);

    // go!
    const codeModel = remodeler.remodel();

    // console.error(require("util").inspect(codeModel));

    // output the model 
    await service.WriteFile("somefile.txt", serialize(codeModel), undefined/*,"code-model-v2"*/);
  } catch (E) {
    console.error(E);
  }
}