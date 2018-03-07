import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";

export class Date implements TypeDeclaration {
  get implementation(): string {
    return `DateTime`;
  };
  get use(): string {
    return `DateTime`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}