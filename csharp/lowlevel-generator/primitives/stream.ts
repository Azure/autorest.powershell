import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { PropertyType } from "../type-declaration";

export class Stream implements PropertyType {
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
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `/* stream json serialize for ${propertyName} */`;
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `/* stream json deserialize for ${propertyName} */`;
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return ``;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return '';
  }
}