import { Schema } from '#csharp/lowlevel-generator/code-model';
import { items } from '#common/dictionary';
import { Interface } from '#csharp/code-dom/interface';
import { Method } from '#csharp/code-dom/method';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { IJsonSerializable, JsonNode, JsonObject } from '#csharp/lowlevel-generator/clientruntime';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';
import { ModelClass } from '#csharp/lowlevel-generator/model/model-class';
import { State } from '../generator';
import { ModelInterfaceProperty } from './interface-property';

export class ModelInterface extends Interface implements Serialization, Validation {
  public validatePresence(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validatePresence(propertyName);
  }
  public validateValue(propertyName: string): OneOrMoreStatements {
    return this.classImplementation.validateValue(propertyName);
  }

  public jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.jsonSerializationImplementation('result', propertyName, serializedName);
  }
  public jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.jsonDeserializationImplementationOnProperty(containerName, propertyName, serializedName);
  }
  public jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return this.classImplementation.jsonDeserializationImplementationOnNode(nodeExpression);
  }
  public serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return this.classImplementation.serializeInstanceToJson(instance);
  }

  get hasHeaderProperties(): boolean {
    return this.classImplementation.hasHeaderProperties;
  }
  constructor(parent: Namespace, schema: Schema, public classImplementation: ModelClass, state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.csharp.name}`);
    this.apply(objectInitializer);
    const implData = (schema.details.csharp = schema.details.csharp || {});
    implData.interfaceImplementation = this;

    for (const { key: propertyName, value: property } of items(schema.properties)) {
      this.add(new ModelInterfaceProperty(this, property, state.path('properties', propertyName)));
    }

    // mark it as json serializable
    this.interfaces.push(IJsonSerializable);

  }
}
