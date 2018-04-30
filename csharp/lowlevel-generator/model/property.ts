import {BackedProperty} from "#csharp/code-dom/property";
import {OneOrMoreStatements} from "#csharp/code-dom/statements/statement";
import {State} from "../generator";
import {PropertyType} from "../type-declaration";
import {ModelClass} from "./class";
import {Property, Schema} from "#common/code-model/schema";

export class ModelProperty extends BackedProperty {
  private required: boolean;
  constructor(parent: ModelClass, property: Property<Schema>, protected serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.required, state.path("schema")));
    this.apply(objectInitializer);
    this.description = property.details.description || "";
    this.required = property.details.required;
  }

  public get validatePresenceStatement(): OneOrMoreStatements {
    if (this.required) {
      return (<PropertyType>this.type).validatePresence(this.name);
    }
    return ``;
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).jsonSerializationImplementation("result", this.name, this.serializedName);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).jsonDeserializationImplementationOnProperty("json", this.privateValue, this.serializedName);
  }

}
