import { TypeDeclaration } from "../type-declaration";

export class Boolean implements TypeDeclaration {
  get implementation(): string {
    return `bool`;
  };
  get use(): string {
    return `bool`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* boolean validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* boolean json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* boolean json deserialize for ${propertyName} */`;
  }
}


export class NullableBoolean extends Boolean {
  get implementation(): string {
    return `bool?`;
  };
  get use(): string {
    return `bool?`;
  }
}