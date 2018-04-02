import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { TypeDeclaration } from "../type-declaration";

export class Duration implements TypeDeclaration {
  constructor(protected required: boolean) {
  }
  get implementation(): string {
    return `TimeSpan${this.required ? '' : '?'}`;
  };
  get use(): string {
    return `TimeSpan${this.required ? '' : '?'}`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return ``;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* duration json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
}