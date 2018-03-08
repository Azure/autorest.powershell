import { TypeDeclaration } from "#csharp-code-dom/type-declaration";

export class Duration implements TypeDeclaration {
  get implementation(): string {
    return `TimeSpan`;
  };
  get use(): string {
    return `TimeSpan`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}