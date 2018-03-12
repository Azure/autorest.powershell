import { Class } from "#csharp/code-dom/class";
import { Project } from "../project";
import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";

export class EnumClass extends Class {
  protected constructor(parent: Namespace, name: string, state: State) {
    super(parent, name);
  }

  public static async create(schema: Schema, state: State): Promise<EnumClass> {

    const result = new EnumClass(state.project.supportNamespace, schema.extensions["x-ms-enum"].name, state);

    // state.model.details.namespace = project.supportNamespace.fullName;

    return result;
  }
}