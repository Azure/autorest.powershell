import { Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Primitive } from '#csharp/schema/primitive';

export class Boolean extends Primitive {
  isXmlAttribute: boolean = false;
  jsonType = ClientRuntime.JsonBoolean;

  constructor(schema: Schema, public isRequired: boolean) {
    super(schema);
  }

  get declaration(): string {
    return `bool${this.isRequired ? '' : '?'}`;
  }

  validateValue(property: Variable): string {
    return ``;
  }
}
