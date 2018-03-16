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
  constructor(protected project: Project, protected state: State, objectInitializer?: Partial<ApiClass>) {
    super(project.serviceNamespace, state.model.details.name);
    this.apply(objectInitializer);
    // add basics
    this.sender = this.addProperty(new Property("Sender", ISendAsync));

    // remember the namespace for this class.
    state.model.details.namespace = project.serviceNamespace.fullName;

    // add operations from code model
    for (const operationName in state.model.components.operations) {
      this.addMethod(new OperationMethod(this, state.model.components.operations[operationName], state.path('components', 'operations', operationName)));
    }

  }

}

