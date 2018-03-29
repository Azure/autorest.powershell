import { Property } from "#csharp/code-dom/property";
import { TypeDeclaration, LibraryType } from "../type-declaration";
import { ModelClass } from "./class";
import { ModelInterface } from "./interface";
import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";
import { ToDo } from "#csharp/code-dom/mscorlib";
import { Interface } from "#csharp/code-dom/interface";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class ModelProperty extends Property {
  private required: boolean;
  constructor(parent: ModelClass, property: codeModel.PropertyReference<codeModel.Schema>, protected serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.required, state.path("schema")));
    this.apply(objectInitializer);
    this.required = property.details.required;
  }

  public get validatePresenceStatement(): OneOrMoreStatements {
    if (this.required) {
      return (<TypeDeclaration>this.type).validatePresence(this.name);
    }
    return ``;
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).serializationImplementation("result", this.name, this.serializedName);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).jsondeserialize(this.name);
  }
}
