import { TypeDeclaration } from "#csharp/code-dom/type-declaration";

export class Uuid implements TypeDeclaration {
  get implementation(): string {
    return `Guid`;
  };
  get use(): string {
    return `Guid`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}