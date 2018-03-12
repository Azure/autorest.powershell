import { TypeDeclaration } from "#csharp/code-dom/type-declaration";

export class Stream implements TypeDeclaration {
  get implementation(): string {
    return `System.IO.Stream`;
  };
  get use(): string {
    return `System.IO.Stream`
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}