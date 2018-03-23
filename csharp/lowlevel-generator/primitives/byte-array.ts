import { TypeDeclaration } from "../type-declaration";

export class ByteArray implements TypeDeclaration {
  get implementation(): string {
    return `byte[]`;
  };
  get use(): string {
    return `byte[]`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* byte array validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* byte array json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* byte array json deserialize for ${propertyName} */`;
  }
}