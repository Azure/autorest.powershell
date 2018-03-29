import { TypeDeclaration } from "../type-declaration";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class DateTime implements TypeDeclaration {
  constructor(protected required: boolean) {
  }
  get implementation(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  };
  get use(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return ``;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* datetime json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.CreateDateTime(${instance})`;
  }
}

export class DateTime1123 implements TypeDeclaration {
  constructor(protected required: boolean) {
  }
  get implementation(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  };
  get use(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  }

  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return ``;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* datetime1123 json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.CreateDateTimeRfc1123(${instance})`;
  }
}


export class UnixTime implements TypeDeclaration {
  constructor(protected required: boolean) {
  }
  get implementation(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  };
  get use(): string {
    return `System.DateTime${this.required ? '' : '?'}`;
  }

  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return ``;
  }
  serializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsondeserialize(propertyName: string): string {
    return `/* unixtime json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonNumber.Create(${instance})`;
  }
}

