import { Schema } from "#common/code-model/schema";
import { Statement, OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { Serialization, Validation } from "./extended-type-declaration";

export class EnumFeatures implements Serialization, Validation {
  constructor(public schema: Schema) {
  }

  public validateValue(propertyName: string): string {
    return ``;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${propertyName} = ${containerName}.StringProperty("${serializedName}");`;
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonString s ? s.Value : null`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }

  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }

}
