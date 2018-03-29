import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { fixPropertyName } from "#common/text-manipulation";

export class Wildcard implements TypeDeclaration {

  constructor(protected leafType: TypeDeclaration) {
  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `System.Collections.Generic.Dictionary<string,${this.leafType.use}>`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* wildcard validate value for ${propertyName} */`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* wildcard json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonObject.Create( ${instance}, __each=> ${this.leafType.serializeInstanceToJson("__each")})`;
  }
}


export class UntypedWildcard implements TypeDeclaration {

  constructor() {

  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `System.Collections.Generic.Dictionary<string,object>`;
  }
  public validatePresence(propertyName: string): string {
    return `await listener.AssertNotNull(${fixPropertyName(propertyName)},${propertyName});`.trim();
  }
  validateValue(propertyName: string): string {
    return `/* untyped wildcard validate value for ${propertyName} */`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* untyped wildcard json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
}
