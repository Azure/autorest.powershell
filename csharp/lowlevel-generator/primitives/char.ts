import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { TypeDeclaration } from "../type-declaration";

export class Char implements TypeDeclaration {
  constructor(protected required: boolean, private choices?: Array<string>) {

  }
  get implementation(): string {
    return `char${this.required ? '' : ' ?'}`;
  }

  get use(): string {
    return `char${this.required ? '' : ' ?'}`;
  }

  public validatePresence(propertyName: string): string {
    return ``;
  }

  validateValue(propertyName: string): string {
    return `
${this.validateEnum(propertyName)}
    `.trim();
    ;
  }

  private validateEnum(propertyName: string): string {
    if (!this.choices) {
      return '';
    }
    return '// todo validate enum choices';
  }

  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* char json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }

}
