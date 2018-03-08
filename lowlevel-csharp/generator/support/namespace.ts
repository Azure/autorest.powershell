import { Namespace } from "#csharp-code-dom/namespace";
import { State } from "../generator";

export class SupportNamespace extends Namespace {
  protected constructor(name: string, parent: Namespace, private state: State) {
    super(name, parent);
  }

  public static async create(parent: Namespace, state: State): Promise<SupportNamespace> {
    // set the serviceNamespace

    state.project.addNamespace(new SupportNamespace("Support", parent, state));
    return state.project.supportNamespace;
  }
}