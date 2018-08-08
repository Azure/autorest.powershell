import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Primitive } from '#csharp/schema/primitive';

export class Char extends Primitive {
  public isXmlAttribute: boolean = false;
  private choices?: Array<string>;
  jsonType = ClientRuntime.JsonString;

  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
    this.choices = schema.enum.length > 0 ? schema.enum : undefined;
  }

  get declaration(): string {
    return `char${this.isRequired ? '' : ' ?'}`;
  }

  validateValue(property: Variable): string {
    return `
${this.validateEnum(property)}
    `.trim();
  }

  private validateEnum(property: Variable): string {
    if (!this.choices) {
      return '';
    }
    return '// todo validate enum choices';
  }
}
