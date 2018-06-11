import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Serialization, Validation } from './extended-type-declaration';

export class Date implements Serialization, Validation {
  constructor(protected required: boolean) {
  }
  get declaration(): string {
    return `System.DateTime`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* FIXME?: date validate value for ${propertyName} */`;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.StringProperty("${serializedName}", ref ${propertyName});`
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonString s ? s : default(${this.declaration})`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.CreateDate(${instance})`;
  }
}