import { nameof } from '#common/text-manipulation';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { KnownMediaType } from '#common/media-types';
import { String } from '#csharp/schema/string';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';

export class Uuid extends String {
  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }

  get declaration(): string {
    return `string`;
  }
  public validatePresence(property: Variable): string {
    return this.isRequired ? `await listener.AssertNotNull(${nameof(property.value)},${property});`.trim() : '';
  }
  validateValue(property: Variable): string {
    return `await listener.AssertRegEx(${nameof(property.value)},${property},@"^[0-9a-fA-F]{8}(-[0-9a-fA-F]{4}){3}-[0-9a-fA-F]{12}$");`;
  }
}