import { TypeDeclaration } from "../type-declaration";

export class ArrayOf implements TypeDeclaration {

  constructor(protected type: TypeDeclaration) {
  }

  get implementation(): string {
    return `/* ARRAY */`;
  };
  get use(): string {
    return `${this.type.use}[]`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* validate array values for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* json deserialize for ${propertyName} */`;
  }
}