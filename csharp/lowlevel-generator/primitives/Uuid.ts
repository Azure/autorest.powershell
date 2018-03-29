import { TypeDeclaration } from "../type-declaration";
import { fixPropertyName } from "#common/text-manipulation";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class Uuid implements TypeDeclaration {
  constructor(protected required: boolean) {
  }

  get implementation(): string {
    return `string`;
  };
  get use(): string {
    return `string`
  }
  public validatePresence(propertyName: string): string {
    return this.required ? `await listener.AssertNotNull(${fixPropertyName(propertyName)},${propertyName});`.trim() : '';
  }
  validateValue(propertyName: string): string {
    return `await listener.AssertRegEx(${fixPropertyName(propertyName)},${propertyName},@"^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$")`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* uuid json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }
}