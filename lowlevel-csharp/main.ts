import { Host } from "@microsoft.azure/autorest-extension-base";
import { Namespace } from "./code-dom/namespace";
import { Interface } from "./code-dom/interface";
import { Using } from "./code-dom/using";
import { Class } from "./code-dom/class";
import { safeLoad } from "js-yaml";
import { ApiClass } from "./generator/operation/api-class";
import { Model } from "#remodeler/code-model";
import { Project } from "./generator/project";
import { State } from "./generator/generator";

export async function deserialize<T>(text: string, filename: string) {
  return <T>safeLoad(await text, {
    filename: filename,
  });
}

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

    const project = await Project.create(modelState);

    await project.writeFiles(async (filename, content) => await service.WriteFile(filename, content, undefined));
    // generate model classes
    // generate llapi class
    /* const ns = new Namespace("my.api");

    ns.add(new ApiClass(model));

    ns.header = `This is a generated class. You can go home now. We're going to look at how long of a string we can muck with to see if it actually will wrap properly. this text will go on forever really, if we let it. You know how weird taht is.`
    ns.add(new Using("System.Whatever"));

    const myInterface = ns.add(new Interface("IMyAPI"));
    const myclass = ns.add(new Class("MyAPI", undefined, [myInterface]));

    if (myclass instanceof Class) {
      myclass.description = "this is a class. there are many like it, but this one is my own.";
    }

    // const apiClass = ns.add(new Class("llapi"));
    // apiClass.add(new RestCallMethod());
    // apiClass.add(new );

    await ns.writeFiles(async (filename, content) => await service.WriteFile(filename, content, undefined));
    */





    console.error("done.");

  } catch (E) {
    console.error(E);
  }
}