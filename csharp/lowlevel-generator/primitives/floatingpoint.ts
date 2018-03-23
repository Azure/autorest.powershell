import { TypeDeclaration } from "../type-declaration";

export class Float implements TypeDeclaration {
  get implementation(): string {
    return `float`;
  };
  get use(): string {
    return `float`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* float validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* float json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* float json deserialize for ${propertyName} */`;
  }
}