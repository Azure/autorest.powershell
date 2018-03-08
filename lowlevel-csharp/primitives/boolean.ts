import { TypeDeclaration } from "#csharp-code-dom/type-declaration";

export class Boolean implements TypeDeclaration {
  get implementation(): string {
    return `bool`;
  };
  get use(): string {
    return `bool`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}