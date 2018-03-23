import { Namespace } from "#csharp/code-dom/namespace";
import { State } from "../generator";

export class SupportNamespace extends Namespace {
  constructor(parent: Namespace, private state: State, objectInitializer?: Partial<SupportNamespace>) {
    super("Support", parent);
    this.apply(objectInitializer);
  }

}