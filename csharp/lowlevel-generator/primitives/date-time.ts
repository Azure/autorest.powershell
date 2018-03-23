import { TypeDeclaration } from "../type-declaration";

export class DateTime implements TypeDeclaration {
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
    return `/* datetime validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* datetime json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* datetime json deserialize for ${propertyName} */`;
  }
}

export class DateTime1123 implements TypeDeclaration {
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
    return `/* datetime1123 validate value for ${propertyName} */`;
  }
  jsonserialize(propertyName: string): string {
    return `/* datetime1123 json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* datetime1123 json deserialize for ${propertyName} */`;
  }
}

