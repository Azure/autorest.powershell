import { fixPropertyName } from '#common/text-manipulation';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { PropertyType } from '../type-declaration';

export class ArrayOf implements PropertyType {

  constructor(protected type: PropertyType, protected required: boolean, protected minItems: number | undefined, protected maxItems: number | undefined, protected unique: boolean | undefined) {
  }

  get implementation(): string {
    return `/* ARRAY */`;
  };
  get use(): string {
    return `${this.type.use}[]`;
  }
  public validatePresence(propertyName: string): OneOrMoreStatements {
    if (this.required) {
      return `await listener.AssertNotNull(${fixPropertyName(propertyName)},${propertyName});`
    }
    return ``;
  }
  validateValue(propertyName: string): OneOrMoreStatements {
    if (!this.type.validateValue(`${propertyName}[{__i}]`)) {
      return '';
    }
    return `
if( ${propertyName} != null )  {
    for(int __i = 0; __i< ${propertyName}.Length; __i++) {
        ${this.type.validateValue(`${propertyName}[__i]`)}
    }
}
`.trim();
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.XNodeArray.Create( ${instance}, __each=> ${this.type.serializeInstanceToJson("__each")})`;
  }

  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.ArrayProperty("${serializedName}", ref ${propertyName}, __each => ${this.type.jsonDeserializationImplementationOnNode("__each")} );`
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `/** TODO : DESERIALIZE NODE OF ARRAY **/`;
  }
}