import { Namespace } from "#csharp/code-dom/namespace";
import { Project } from "../project";
import { State } from "../generator";
import { ModelsNamespace } from "../model/namespace";
import * as message from "../messages";

export class ServiceNamespace extends Namespace {
  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.namespace || "INVALID.NAMESPACE", state.project);
    this.apply(objectInitializer);
  }
}