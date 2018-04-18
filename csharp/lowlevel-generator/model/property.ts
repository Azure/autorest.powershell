import { Property, BackedProperty } from "#csharp/code-dom/property";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";
import { PropertyType } from "../type-declaration";
import { ModelClass } from "./class";

export class ModelProperty extends BackedProperty {
  private required: boolean;
  constructor(parent: ModelClass, property: codeModel.PropertyReference<codeModel.Schema>, protected serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
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
