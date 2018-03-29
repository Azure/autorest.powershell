import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class Date implements TypeDeclaration {
  constructor(protected required: boolean) {
  }

  get implementation(): string {
    return `System.DateTime`;
  };
  get use(): string {
    return `System.DateTime`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* date validate value for ${propertyName} */`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* date json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.CreateDate(${instance})`;
  }
}