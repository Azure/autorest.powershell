import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class Boolean implements TypeDeclaration {
  constructor(protected required: boolean) {
  }
  get implementation(): string {
    return `bool${this.required ? '' : '?'}`;
  };
  get use(): string {
    return `bool${this.required ? '' : '?'}`
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
    return `/* boolean json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonBoolean.Create(${instance})`;
  }
}
