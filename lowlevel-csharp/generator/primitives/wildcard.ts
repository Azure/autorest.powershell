import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";

export class Wildcard implements TypeDeclaration {

  constructor(protected leafType: TypeDeclaration) {
  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `Dictionary<string,${this.leafType.use}>`;
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}


export class UntypedWildcard implements TypeDeclaration {

  constructor() {

  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `Dictionary<string,object>`;
  }
  validation(propertyName: string): string {
    throw new Error("Method not implemented.");
  }
}
