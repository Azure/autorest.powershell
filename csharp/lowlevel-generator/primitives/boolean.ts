import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { PropertyType } from '../type-declaration';

export class Boolean implements PropertyType {
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
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.BooleanProperty("${serializedName}", ref ${propertyName});`
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonBoolean.Create(${instance})`;
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonBoolean b ? b : default(${this.implementation})`;
  }
}
