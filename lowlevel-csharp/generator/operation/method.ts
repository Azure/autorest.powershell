import { Class } from "../../code-dom/class";
import * as codemodel from "#remodeler/code-model";
import { Method } from "../../code-dom/method";
import * as mscorlib from "../../code-dom/mscorlib";
import { Parameter } from "../../code-dom/parameter";
import { OperationParameter } from "../operation/parameter";
import { ModelState } from "#common/model-state";
import { Model } from "#remodeler/code-model";
import * as message from "../messages";
import { all } from "#common/text-manipulation";

export class OperationMethod extends Method {
  protected constructor(code: ModelState<Model>, private operation: codemodel.HttpOperation) {
    super(operation.details.name, mscorlib.Task);
  }

  public static async Process(code: ModelState<Model>, operation: codemodel.HttpOperation): Promise<OperationMethod> {
    const result = new OperationMethod(code, operation);

    // add parameters
    await all(operation.parameters, async (parameter, index) => result.addParameter(await OperationParameter.Process(code.path('parameters', index), parameter)));


    // code.error("YouAreBad", message.sad);

    // add body paramter

    // add response delegate parameters

    // add cancellationToken parameter

    // add eventhandler parameter
    return result;
  }


}