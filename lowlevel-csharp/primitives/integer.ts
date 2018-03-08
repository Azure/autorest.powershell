import { TypeDeclaration } from "#csharp-code-dom/type-declaration";

export class Integer implements TypeDeclaration {
  get implementation(): string {
    return `int`;
  };
  get use(): string {
    return `int`;
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}