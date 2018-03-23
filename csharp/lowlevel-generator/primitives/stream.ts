import { TypeDeclaration } from "../type-declaration";

export class Stream implements TypeDeclaration {
  get implementation(): string {
    return `System.IO.Stream`;
  };
  get use(): string {
    return `System.IO.Stream`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return `/* stream validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* stream json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* stream json deserialize for ${propertyName} */`;
  }
}