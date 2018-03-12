import { Namespace } from "#csharp/code-dom/namespace";
import { Project } from "../project";
import { State } from "../generator";
import { ModelsNamespace } from "../model/namespace";
import * as message from "../messages";

export class ServiceNamespace extends Namespace {
  protected constructor(name: string, public state: State) {
    super(name, state.project);
  }

  public static async create(state: State): Promise<ServiceNamespace> {
    // set the serviceNamespace
    const name = await state.service.GetValue("namespace") || "Sample.API";

    state.project.addNamespace(new ServiceNamespace(name, state));
    return state.project.serviceNamespace;
  }
}