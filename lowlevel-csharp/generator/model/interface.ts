import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp-code-dom/namespace";
import { Interface } from "#csharp-code-dom/interface";
import { ModelInterfaceProperty } from "./interface-property";

export class ModelInterface extends Interface {
  protected constructor(name: string, state: State) {
    super(`I${name}`);
  }

  public static async create(parent: Namespace, schema: Schema, state: State): Promise<ModelInterface> {
    if (schema.details.privateData["interface-implementation"]) {
      // if we've already created this type, return the implementation of it.
      return schema.details.privateData["interface-implementation"];
    }
    const modelInterface = new ModelInterface(schema.details.name, state);
    schema.details.privateData["interface-implementation"] = modelInterface;

    for (const propertyName in schema.properties) {
      const property = schema.properties[propertyName];

      ModelInterfaceProperty.create(modelInterface, property, state.path('properties', propertyName));
    }

    // add this to parent namespace
    parent.addInterface(modelInterface);

    return modelInterface;
  }
}