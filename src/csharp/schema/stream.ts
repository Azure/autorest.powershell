import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Serialization, Validation } from './extended-type-declaration';

export class Stream implements Serialization, Validation {
  get declaration(): string {
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