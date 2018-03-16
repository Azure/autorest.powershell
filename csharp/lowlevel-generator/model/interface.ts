import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { ModelInterfaceProperty } from "./interface-property";

export class ModelInterface extends Interface {
  constructor(parent: Namespace, schema: Schema, state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.name}`);
    this.apply(objectInitializer);

    schema.details.privateData["interface-implementation"] = this;

    for (const propertyName in schema.properties) {
      this.addProperty(new ModelInterfaceProperty(this, schema.properties[propertyName], state.path('properties', propertyName)));
    }


  }

}