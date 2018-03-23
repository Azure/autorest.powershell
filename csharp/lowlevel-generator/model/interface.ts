import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { ModelInterfaceProperty } from "./interface-property";
import { TypeDeclaration } from "#csharp/lowlevel-generator/type-declaration";
import { ModelClass } from "#csharp/lowlevel-generator/model/class";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class ModelInterface extends Interface implements TypeDeclaration {
  validatePresence(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validatePresence(propertyName);
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validateValue(propertyName);
  }
  jsonserialize(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.jsonserialize(propertyName);
  }
  jsondeserialize(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.jsondeserialize(propertyName);
  }

  constructor(parent: Namespace, schema: Schema, public classImplementation: ModelClass, state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.name}`);
    this.apply(objectInitializer);

    schema.details.privateData.interfaceImplementation = this;

    for (const propertyName in schema.properties) {
      this.addProperty(new ModelInterfaceProperty(this, schema.properties[propertyName], state.path('properties', propertyName)));
    }


  }

}