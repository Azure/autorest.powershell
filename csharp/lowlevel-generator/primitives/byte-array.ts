import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class ByteArray implements TypeDeclaration {
  get implementation(): string {
    return `byte[]`;
  };
  get use(): string {
    return `byte[]`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* byte array validate value for ${propertyName} */`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* byte array json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
}