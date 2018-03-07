import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";

export class ArrayOf implements TypeDeclaration {

  constructor(protected type: TypeDeclaration) {
  }

  get implementation(): string {
    return `/* ARRAY */`;
  };
  get use(): string {
    return `${this.type.use}[]`;
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}