import { BackedProperty } from '#csharp/code-dom/property';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { State } from '../generator';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';
import { ModelClass } from './model-class';

import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { Schema, Property } from '#csharp/lowlevel-generator/code-model';

export class ModelProperty extends BackedProperty {
  private required: boolean;
  public IsHeaderProperty: boolean;
  public schema: Schema;

  constructor(parent: ModelClass, property: Property, public serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
    super(property.details.csharp.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.csharp.required, state.path("schema")));
    this.schema = property.schema;
    this.apply(objectInitializer);
    this.description = property.details.csharp.description;
    this.required = property.details.csharp.required;
    this.IsHeaderProperty = property.details.csharp[HeaderProperty] === HeaderPropertyType.HeaderAndBody || property.details.csharp[HeaderProperty] === HeaderPropertyType.Header;
  }

  public get validatePresenceStatement(): OneOrMoreStatements {
    if (this.required) {
      return (<Validation>this.type).validatePresence(this.name);
    }
    return ``;
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<Validation>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return (<Serialization>this.type).jsonSerializationImplementation("result", this.name, this.serializedName);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return (<Serialization>this.type).jsonDeserializationImplementationOnProperty("json", this.valuePrivate, this.serializedName);
  }
}
