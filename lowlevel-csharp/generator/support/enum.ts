import { Class } from "#csharp-code-dom/class";
import { Project } from "../project";
import { State } from "../generator";
import { Schema } from "#remodeler/code-model";

export class EnumClass extends Class {
  protected constructor(name: string, state: State) {
    super(name);
  }

  public static async create(schema: Schema, state: State): Promise<EnumClass> {

    const result = new EnumClass(schema.extensions["x-ms-enum"].name, state);
    state.project.supportNamespace.addClass(result);
    // state.model.details.namespace = project.supportNamespace.fullName;

    return result;
  }
}