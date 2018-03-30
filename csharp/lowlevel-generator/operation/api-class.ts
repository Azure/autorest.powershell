import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import * as message from "../messages";

import { Class } from "#csharp/code-dom/class";
import { OperationMethod } from "../operation/method";
import { ModelState } from "#common/model-state";
import { Model } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Project } from "../project";
import { State } from "../generator";
import { Property } from "#csharp/code-dom/property";
import { ISendAsync } from "../clientruntime";

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

