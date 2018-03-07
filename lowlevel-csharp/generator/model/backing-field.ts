import * as codeModel from "#remodeler/code-model";
import { State } from "../generator";

import { Field } from "../../code-dom/field";
import { ModelClass } from "./class";
import { TypeDeclaration } from "#lowlevel-csharp/code-dom/type-declaration";

export class BackingField extends Field {
  protected constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }

  public static async create(parent: ModelClass, name: string, typeDecl: TypeDeclaration, state: State) {
    const backingField = new BackingField(name, typeDecl);
    backingField.visibility = "private";

    parent.addField(backingField);
    return backingField;
  }
}