import { Class } from "#csharp/code-dom/class";
import { Namespace } from "#csharp/code-dom/namespace";
import { Property } from "#csharp/code-dom/property";
import * as codemodel from "#remodeler/code-model";
import { ISendAsync } from "../clientruntime";
import { State } from "../generator";
import { OperationMethod } from "../operation/method";


export class ApiClass extends Class {

  protected sender: Property;
  constructor(namespace: Namespace, protected state: State, objectInitializer?: Partial<ApiClass>) {
    super(namespace, state.model.details.name);
    this.apply(objectInitializer);
    // add basics
    this.sender = this.addProperty(new Property("Sender", ISendAsync));

    // remember the namespace for this class.
    state.model.details.namespace = namespace.fullName;

    // add operations from code model
    for (const operationName in state.model.components.operations) {
      const operation = state.model.components.operations[operationName];
      if (codemodel.isHttpOperation(operation)) {
        this.addMethod(new OperationMethod(this, operation, state.path('components', 'operations', operationName)));
      }
    }
  }

}

