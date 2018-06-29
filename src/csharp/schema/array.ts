import { fixPropertyName } from '#common/text-manipulation';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Serialization, Validation } from './extended-type-declaration';

export class ArrayOf implements Serialization, Validation {

  constructor(protected type: Serialization & Validation, protected required: boolean, protected minItems: number | undefined, protected maxItems: number | undefined, protected unique: boolean | undefined) {
  }

  get declaration(): string {
    return `${this.type.declaration}[]`;
  }
  public validatePresence(propertyName: string): OneOrMoreStatements {
    if (this.required) {
      return `await listener.AssertNotNull(${fixPropertyName(propertyName)},${propertyName});`;
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
    return `null/** TODO : DESERIALIZE NODE OF ARRAY **/`;
  }
}