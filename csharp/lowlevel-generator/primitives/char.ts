import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { PropertyType } from '../type-declaration';

export class Char implements PropertyType {
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

  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.StringProperty("${serializedName}", ref ${propertyName});`
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonString s ? s : default(${this.implementation})`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }
}
