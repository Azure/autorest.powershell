import { Namespace } from '#csharp/code-dom/namespace';
import { State } from '../generator';
import { Import } from '#csharp/code-dom/import';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';

export class ServiceNamespace extends Namespace {
  constructor(public state: State, objectInitializer?: Partial<ServiceNamespace>) {
    super(state.model.details.csharp.namespace || "INVALID.NAMESPACE", state.project);
    this.apply(objectInitializer);
    this.addUsing(new Import(`static ${ClientRuntime.Extensions}`));
  }
}