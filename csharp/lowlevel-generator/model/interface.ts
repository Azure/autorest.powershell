import { Interface } from "#csharp/code-dom/interface";
import { Namespace } from "#csharp/code-dom/namespace";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { ModelClass } from "#csharp/lowlevel-generator/model/class";
import { PropertyType } from "#csharp/lowlevel-generator/type-declaration";
import { Schema } from "#remodeler/code-model";
import { State } from "../generator";
import { ModelInterfaceProperty } from "./interface-property";
import { Method } from "#csharp/code-dom/method";
import { JsonNode, JsonObject, IJsonSerializable } from "#csharp/lowlevel-generator/clientruntime";
import { Parameter } from "#csharp/code-dom/parameter";

export class ModelInterface extends Interface implements PropertyType {
  validatePresence(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validatePresence(propertyName);
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validateValue(propertyName);
  }

  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.jsonSerializationImplementation("result", propertyName, serializedName);
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.jsonDeserializationImplementationOnProperty(containerName, propertyName, serializedName);
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return this.classImplementation.jsonDeserializationImplementationOnNode(nodeExpression);;
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

    // mark it as json serializable
    this.interfaces.push(IJsonSerializable);

  }
}