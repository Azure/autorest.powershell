import { TypeDeclaration } from "../type-declaration";

export class Wildcard implements TypeDeclaration {

  constructor(protected leafType: TypeDeclaration) {
  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `System.Collections.Generic.Dictionary<string,${this.leafType.use}>`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* wildcard validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* wildcard json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* wildcard json deserialize for ${propertyName} */`;
  }
}


export class UntypedWildcard implements TypeDeclaration {

  constructor() {

  }

  get implementation(): string {
    return `/*wildcard*/`;
  };
  get use(): string {
    return `System.Collections.Generic.Dictionary<string,object>`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* untyped wildcard validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* untyped wildcard boolean json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* untyped wildcard json deserialize for ${propertyName} */`;
  }
}
