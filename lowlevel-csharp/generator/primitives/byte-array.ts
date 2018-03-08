import { TypeDeclaration } from "#csharp-code-dom/type-declaration";

export class ByteArray implements TypeDeclaration {
  get implementation(): string {
    return `byte[]`;
  };
  get use(): string {
    return `byte[]`;
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}