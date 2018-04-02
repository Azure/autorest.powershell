import { fixPropertyName } from "#common/text-manipulation";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { TypeDeclaration } from "../type-declaration";

export class ArrayOf implements TypeDeclaration {

  constructor(protected type: TypeDeclaration, protected required: boolean, protected minItems: number | undefined, protected maxItems: number | undefined, protected unique: boolean | undefined) {
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

  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    // return `${containerName}.SafeAdd( "${serializedName}", Carbon.Json.XNodeArray.Create( ${propertyName}, __each=> ${this.type.returnSerializedValue("__each")}) );`
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* json deserialize for ${propertyName} */`;
  }
}