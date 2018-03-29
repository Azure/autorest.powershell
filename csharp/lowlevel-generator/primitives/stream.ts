import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class Stream implements TypeDeclaration {
  get implementation(): string {
    return `System.IO.Stream`;
  };
  get use(): string {
    return `System.IO.Stream`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* stream validate value for ${propertyName} */`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `/* stream json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* stream json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
}