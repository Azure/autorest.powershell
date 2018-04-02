import { deserialize, serialize } from "#common/yaml";
import { Model } from "#remodeler/code-model";
import { Host } from "@microsoft.azure/autorest-extension-base";
import { State } from "./generator";
import { Project } from "./project";

// todo:
// interpretations:
//  - readonly properties
//  - nullable values?
//

// model constructors?
//    - allOf creation?

// validations
// serialization/deserialization/polymorphic deserializer/shape deserializer?
// url construction
// security
// mime-type
// create schema for returned headers and deserialize (or... add parameters to OnResponse?)
// streams
// non json payloads (xml, formdata, multipart-mime)

// client runtime


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