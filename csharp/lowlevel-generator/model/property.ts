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
  constructor(parent: ModelClass, property: codeModel.PropertyReference<codeModel.Schema>, state: State, objectInitializer?: Partial<ModelProperty>) {
    super(property.details.name, state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.required, state.path("schema")));
    this.apply(objectInitializer);
  }

  public get validatePresenceStatement(): OneOrMoreStatements {
    return ``;
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).jsondeserialize(this.name);
  }
}
