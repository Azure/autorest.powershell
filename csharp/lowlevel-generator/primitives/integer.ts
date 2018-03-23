import { TypeDeclaration } from "../type-declaration";

export class Integer implements TypeDeclaration {
  get implementation(): string {
    return `int`;
  };
  get use(): string {
    return `int`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* integer validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* integer json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* integer json deserialize for ${propertyName} */`;
  }
}