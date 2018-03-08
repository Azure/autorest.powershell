import { TypeDeclaration } from "#csharp-code-dom/type-declaration";

export class Float implements TypeDeclaration {
  get implementation(): string {
    return `float`;
  };
  get use(): string {
    return `float`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}