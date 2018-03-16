import { Host } from "@microsoft.azure/autorest-extension-base";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { Import } from "#csharp/code-dom/import";
import { Class } from "#csharp/code-dom/class";
import { ApiClass } from "./operation/api-class";
import { Model } from "#remodeler/code-model";
import { Project } from "./project";
import { State } from "./generator";
import { deserialize } from "#common/yaml";

// todo:
// interpretations:
//  - readonly properties
//  - nullable values?
//

// model constructors? 
//    - allOf creation?
// enum generator
// validations
// serialization/deserialization/polymorphic deserializer/shape deserializer?
// url construction
// security
// mime-type 
// create schema for returned headers and deserialize (or... add parameters to OnResponse?)
// streams
// non json payloads (xml, formdata, multipart-mime)

// client runtime

// later: refactor create/async to be consistent

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


  } catch (E) {
    console.error(E);
  }
}