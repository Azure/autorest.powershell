import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "../../code-dom/mscorlib";
import * as message from "../messages";

import { Class } from "../../code-dom/class";
import { OperationMethod } from "../operation/method";
import { ModelState } from "#common/model-state";
import { Model } from "#remodeler/code-model";
import { Namespace } from "../../code-dom/namespace";
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
    for (const operation in state.model.components.operations) {
      result.addMethod(await OperationMethod.Process(state.path('components', 'operations', operation), state.model.components.operations[operation]));
    }

    // add constructors 

    return result;
  }
}

