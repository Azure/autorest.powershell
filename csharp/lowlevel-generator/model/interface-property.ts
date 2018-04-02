import { InterfaceProperty } from "#csharp/code-dom/interface-property";
import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";
import { ModelInterface } from "./interface";

export class ModelInterfaceProperty extends InterfaceProperty {
  constructor(parent: ModelInterface, property: codeModel.PropertyReference<codeModel.Schema>, state: State, objectInitializer?: Partial<ModelInterfaceProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.required, state.path("schema")));
    this.apply(objectInitializer);
  }
}