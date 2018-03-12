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

  private ready: Promise<ApiClass>;
  protected sender: Property;
  protected constructor(protected project: Project, name: string, protected state: State) {
    super(project.serviceNamespace, name);

    // add basics
    this.sender = this.addProperty(new Property("Sender", ISendAsync));

    // finish in async constructor
    this.ready = (async () => {
      state.model.details.namespace = project.serviceNamespace.fullName;

      // add operations from code model
      for (const operationName in state.model.components.operations) {
        await OperationMethod.create(this, state.model.components.operations[operationName], state.path('components', 'operations', operationName));
      }

      // add constructors 
      return this;
    })();
  }

  public static create(project: Project, state: State): Promise<ApiClass> {
    return new ApiClass(project, state.model.details.name, state).ready;
  }
}

