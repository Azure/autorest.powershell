import {InterfaceProperty} from "#csharp/code-dom/interface-property";
import {State} from "../generator";
import {ModelInterface} from "./interface";
import {Property, Schema} from "#common/code-model/schema";

export class ModelInterfaceProperty extends InterfaceProperty {
  constructor(parent: ModelInterface, property: Property<Schema>, state: State, objectInitializer?: Partial<ModelInterfaceProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.required, state.path("schema")));
    this.apply(objectInitializer);
  }
}