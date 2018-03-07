import { Property } from "../../code-dom/property";
import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";
import { ModelClass } from "./class";
import { ModelInterface } from "./interface";
import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";
import { ToDo } from "../../code-dom/mscorlib";
import { Interface } from "../../code-dom/interface";

export class ModelProperty extends Property {
  protected constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }

  public static async create(parent: ModelClass, property: codeModel.PropertyReference<codeModel.Schema>, state: State) {
    // get the typeDeclaration for the schema
    const typeDecl = await state.project.modelsNamespace.resolveTypeDeclaration(property.schema, state.path("schema"));

    if (typeDecl != null) {
      // create the property.
      const modelProperty = new ModelProperty(property.details.name, typeDecl);

      // add the new property to the parent 
      parent.addProperty(modelProperty);

      // return the property
      return modelProperty;
    }
    return null;
  }
}
