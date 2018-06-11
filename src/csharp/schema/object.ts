
import { fixPropertyName } from '#common/text-manipulation';
import { OneOrMoreStatements, Statement } from '#csharp/code-dom/statements/statement';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Serialization, Validation } from './extended-type-declaration';

export class ObjectFeatures implements Serialization, Validation {
  constructor(public schema: Schema) {
  }
  public validatePresence(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertNotNull(${fixPropertyName(propertyName)}, ${propertyName}); `.trim();
  }
  public validateValue(propertyName: string): OneOrMoreStatements {
    return `await listener.AssertObjectIsValid(${fixPropertyName(propertyName)}, ${propertyName}); `;
  }
  public jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  public jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    // we're always going to go thru FromJson; it'll handle nulls and polymorphism.
    return `${propertyName} = ${this.classDeclaration}.FromJson(${containerName}.Property("${serializedName}"));`.trim();
  }
  public jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${this.classDeclaration}.FromJson(${nodeExpression})`;
  }
  public serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `${instance}?.ToJson()`;
  }

  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.interfaceName}`; }
  get classDeclaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }
}
