import { TypeDeclaration } from "#csharp/code-dom/type-declaration";

export class Date implements TypeDeclaration {
  get implementation(): string {
    return `System.DateTime`;
  };
  get use(): string {
    return `System.DateTime`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}