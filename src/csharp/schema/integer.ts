import { nameof } from '#common/text-manipulation';
import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Primitive } from '#csharp/schema/primitive';

export class Numeric extends Primitive {
  public isXmlAttribute: boolean = false;
  public jsonType = ClientRuntime.JsonNumber;

  constructor(schema: Schema, public isRequired: boolean, protected numericType: string) {
    super(schema);
  }
  get declaration(): string {
    return `${this.numericType}`;
  }
  validateValue(property: Variable): string {
    return `
${this.validateMinimum(property)}
${this.validateMaximum(property)}
${this.validateExclusiveMinimum(property)}
${this.validateExclusiveMaximum(property)}
${this.validateMultipleOf(property)}
`.trim();
  }
  protected validateMinimum(property: Variable): string {
    return this.schema.minimum && !this.schema.exclusiveMinimum ? `await listener.AssertIsGreaterThanOrEqual(${nameof(property.value)},${property},${this.schema.minimum});` : '';
  }
  protected validateMaximum(property: Variable): string {
    return this.schema.maximum && !this.schema.exclusiveMaximum ? `await listener.AssertIsLessThanOrEqual(${nameof(property.value)},${property},${this.schema.maximum});` : '';
  }
  protected validateExclusiveMinimum(property: Variable): string {
    return this.schema.minimum && this.schema.exclusiveMinimum ? `await listener.AssertIsGreaterThan(${nameof(property.value)},${property},${this.schema.minimum});` : '';
  }
  protected validateExclusiveMaximum(property: Variable): string {
    return this.schema.maximum && this.schema.exclusiveMaximum ? `await listener.AssertIsLessThan(${nameof(property.value)},${property},${this.schema.maximum});` : '';
  }
  protected validateMultipleOf(property: Variable): string {
    return this.schema.multipleOf ? `await listener.AssertIsMultipleOf(${nameof(property.value)},${property},${this.schema.multipleOf});` : '';
  }

}
