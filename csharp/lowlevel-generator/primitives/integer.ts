import { fixPropertyName } from "#common/text-manipulation";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { TypeDeclaration } from "../type-declaration";

export class Numeric implements TypeDeclaration {
  constructor(protected numericType: string, protected minimum: number | undefined, protected exclusiveMinimum: boolean | undefined, protected maximum: number | undefined, protected exclusiveMaximum: boolean | undefined, protected multipleOf: number | undefined) {

  }
  get implementation(): string {
    return `${this.numericType}`;
  };
  get use(): string {
    return `${this.numericType}`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `
${this.validateMinimum(propertyName)}
${this.validateMaximum(propertyName)}
${this.validateExclusiveMinimum(propertyName)}
${this.validateExclusiveMaximum(propertyName)}
${this.validateMultipleOf(propertyName)}
`.trim();
    ;
  }
  protected validateMinimum(propertyName: string): string {
    return this.minimum && !this.exclusiveMinimum ? `await listener.AssertIsGreaterThanOrEqual(${fixPropertyName(propertyName)},${propertyName},${this.minimum});` : "";
  }
  protected validateMaximum(propertyName: string): string {
    return this.maximum && !this.exclusiveMaximum ? `await listener.AssertIsLessThanOrEqual(${fixPropertyName(propertyName)},${propertyName},${this.maximum});` : "";
  }
  protected validateExclusiveMinimum(propertyName: string): string {
    return this.minimum && this.exclusiveMinimum ? `await listener.AssertIsGreaterThan(${fixPropertyName(propertyName)},${propertyName},${this.minimum});` : "";
  }
  protected validateExclusiveMaximum(propertyName: string): string {
    return this.maximum && this.exclusiveMaximum ? `await listener.AssertIsLessThan(${fixPropertyName(propertyName)},${propertyName},${this.maximum});` : "";
  }
  protected validateMultipleOf(propertyName: string): string {
    return this.multipleOf ? `await listener.AssertIsMultipleOf(${fixPropertyName(propertyName)},${propertyName},${this.multipleOf});` : "";
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return ``;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonNumber.Create(${instance})`;
  }
}

export class Integer extends Numeric {
  get implementation(): string {
    return `int`;
  };
  get use(): string {
    return `int`;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `/* integer json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* integer json deserialize for ${propertyName} */`;
  }
}
