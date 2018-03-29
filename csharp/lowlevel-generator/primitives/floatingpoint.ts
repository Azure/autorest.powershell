import { TypeDeclaration } from "../type-declaration";
import { Numeric } from "#csharp/lowlevel-generator/primitives/integer";

export class Float extends Numeric {
  get implementation(): string {
    return `float`;
  };
  get use(): string {
    return `float`
  }

  serializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `/* float json serialize for ${propertyName} */`;
  }
  jsondeserialize(propertyName: string): string {
    return `/* float json deserialize for ${propertyName} */`;
  }
}
