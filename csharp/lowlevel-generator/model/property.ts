import { Property } from "#csharp/code-dom/property";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { ModelClass } from "./class";
import { ModelInterface } from "./interface";
import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";
import { ToDo } from "#csharp/code-dom/mscorlib";
import { Interface } from "#csharp/code-dom/interface";

export class ModelProperty extends Property {
  constructor(parent: ModelClass, property: codeModel.PropertyReference<codeModel.Schema>, state: State, objectInitializer?: Partial<ModelProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, state.path("schema")));
    this.apply(objectInitializer);
  }
}
