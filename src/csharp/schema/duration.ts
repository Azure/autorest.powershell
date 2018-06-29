import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Serialization, Validation } from './extended-type-declaration';

export class Duration implements Serialization, Validation {
  constructor(protected required: boolean) {
  }
  get declaration(): string {
    return `System.TimeSpan${this.required ? '' : '?'}`
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  validateValue(propertyName: string): string {
    return ``;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `/* FIXME: duration json deserialize for ${propertyName} */`;
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `/* FIXME:  timespan deserialze node */`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return 'Carbon.Json.XNull.Instance/* FIXME : timespan serialize instance to  json */';
  }
}