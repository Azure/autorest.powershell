
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { String } from '#csharp/schema/string';

export class EnumImplementation extends String {
  public isXmlAttribute: boolean = false;

  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }

  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}`; }
}
