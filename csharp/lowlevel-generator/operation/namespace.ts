import { Namespace } from "#csharp/code-dom/namespace";
import { State } from "../generator";

export class ServiceNamespace extends Namespace {
  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.namespace || "INVALID.NAMESPACE", state.project);
    this.apply(objectInitializer);
  }
}