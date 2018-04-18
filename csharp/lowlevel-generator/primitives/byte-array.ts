import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { PropertyType } from "../type-declaration";

export class ByteArray implements PropertyType {
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
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `/* FIXME: byte array json deserialize for ${propertyName} */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '/* FIXME: byte array json serialize instance to json */';
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `/* FIXME: byte array json deserialize node */`;
  }
}