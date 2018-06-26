import { fixPropertyName } from '#common/text-manipulation';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Serialization, Validation } from './extended-type-declaration';

export class Uuid implements Serialization, Validation {
  constructor(protected required: boolean) {
  }

  get declaration(): string {
    return `string`;
  }
  public validatePresence(propertyName: string): string {
    return this.required ? `await listener.AssertNotNull(${fixPropertyName(propertyName)},${propertyName});`.trim() : '';
  }
  validateValue(propertyName: string): string {
    return `await listener.AssertRegEx(${fixPropertyName(propertyName)},${propertyName},@"^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$");`;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.StringProperty("${serializedName}", ref ${propertyName});`
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonString s ? s : null`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }
}