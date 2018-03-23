import { TypeDeclaration } from "../type-declaration";

export class Date implements TypeDeclaration {
  get implementation(): string {
    return `System.DateTime`;
  };
  get use(): string {
    return `System.DateTime`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* date validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* date json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* date json deserialize for ${propertyName} */`;
  }
}