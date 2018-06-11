import { Namespace } from '#csharp/code-dom/namespace';
import { State } from '../generator';
import { Import } from '#csharp/code-dom/import';

export class ServiceNamespace extends Namespace {
  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || "INVALID.NAMESPACE", state.project);
    this.apply(objectInitializer);
    this.addUsing(new Import("static Microsoft.Rest.ClientRuntime.IEventListenerExtensions"));
  }
}