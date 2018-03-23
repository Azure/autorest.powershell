import { TypeDeclaration } from "../type-declaration";

export class Uuid implements TypeDeclaration {
  get implementation(): string {
    return `Guid`;
  };
  get use(): string {
    return `Guid`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* uuid validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* uuid json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* uuid json deserialize for ${propertyName} */`;
  }
}