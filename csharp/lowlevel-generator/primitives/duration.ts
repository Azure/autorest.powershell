import { TypeDeclaration } from "../type-declaration";

export class Duration implements TypeDeclaration {
  get implementation(): string {
    return `TimeSpan`;
  };
  get use(): string {
    return `TimeSpan`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* duration validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* duration json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* duration json deserialize for ${propertyName} */`;
  }
}