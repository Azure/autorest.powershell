import { TypeDeclaration as BaseTypeDeclaration } from "#csharp/code-dom/type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
export interface TypeDeclaration extends BaseTypeDeclaration {
  validatePresence(propertyName: string): OneOrMoreStatements;
  validateValue(propertyName: string): OneOrMoreStatements;
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements;
  serializeInstanceToJson(instance: string): OneOrMoreStatements;
  jsondeserialize(propertyName: string): OneOrMoreStatements;
}

export class LibraryType implements TypeDeclaration {
  constructor(private fullName: string) {
  }

  public get use(): string {
    return `${this.fullName}`;
  }

  public validatePresence(propertyName: string): OneOrMoreStatements {
    return ``;
  }

  public validateValue(propertyName: string): OneOrMoreStatements {
    return '';
  }

  public get implementation(): string {
    return ``;
  }

  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return ``;
  }
  jsondeserialize(propertyName: string): OneOrMoreStatements {
    return ``;
  }
}