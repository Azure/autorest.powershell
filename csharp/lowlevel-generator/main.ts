import { deserialize, serialize } from "#common/yaml";
import { Model } from "#remodeler/code-model";
import { Host } from "@microsoft.azure/autorest-extension-base";
import { State } from "./generator";
import { Project } from "./project";

export async function process(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length != 1) {
      throw new Error("Inputs missing.");
    }

    const filename = files[0];

    const codeModelText = await service.ReadFile(filename);
    const model = await deserialize<Model>(codeModelText, filename);

    const modelState = new State(service, model, filename);

    const project = new Project(modelState);

    await project.writeFiles(async (filename, content) => await service.WriteFile(filename, content, undefined));
    await service.WriteFile("code-model-v2.csharp.yaml", serialize(model), undefined);

  } catch (E) {
    console.error(E);
  }
}