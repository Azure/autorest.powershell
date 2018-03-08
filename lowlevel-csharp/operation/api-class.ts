import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp-code-dom/mscorlib";
import * as message from "../messages";

import { Class } from "#csharp-code-dom/class";
import { OperationMethod } from "../operation/method";
import { ModelState } from "#common/model-state";
import { Model } from "#remodeler/code-model";
import { Namespace } from "#csharp-code-dom/namespace";
import { Project } from "../project";
import { State } from "../generator";


export class ApiClass extends Class {

  protected constructor(name: string, state: State) {
    super(name);
  }

  public static async create(project: Project, state: State): Promise<ApiClass> {
    const result = new ApiClass(state.model.details.name, state);
    state.model.details.namespace = project.serviceNamespace.fullName;

    // add this to parent namespace
    project.serviceNamespace.addClass(result);

    // add operations from code model
    for (const operationName in state.model.components.operations) {
      await OperationMethod.create(result, state.model.components.operations[operationName], state.path('components', 'operations', operationName));
    }

    // add constructors 

    return result;
  }
}

