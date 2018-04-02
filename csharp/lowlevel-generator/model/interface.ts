import { Interface } from "#csharp/code-dom/interface";
import { Namespace } from "#csharp/code-dom/namespace";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { ModelClass } from "#csharp/lowlevel-generator/model/class";
import { TypeDeclaration } from "#csharp/lowlevel-generator/type-declaration";
import { Schema } from "#remodeler/code-model";
import { State } from "../generator";
import { ModelInterfaceProperty } from "./interface-property";

export class ModelInterface extends Interface implements TypeDeclaration {
  validatePresence(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validatePresence(propertyName);
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validateValue(propertyName);
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.serializationImplementation("result", propertyName, serializedName);
  }
  jsondeserialize(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.jsondeserialize(propertyName);
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return this.classImplementation.serializeInstanceToJson(instance);
  }

  constructor(parent: Namespace, schema: Schema, public classImplementation: ModelClass, state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.name}`);
    this.apply(objectInitializer);
    const implData = (schema.details.csharp = schema.details.csharp || {});
    implData.interfaceImplementation = this;

    for (const propertyName in schema.properties) {
      this.addProperty(new ModelInterfaceProperty(this, schema.properties[propertyName], state.path('properties', propertyName)));
    }
  }
}