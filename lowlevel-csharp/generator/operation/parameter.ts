import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "../../code-dom/mscorlib";
import { Class } from "../../code-dom/class";
import { Parameter } from "../../code-dom/parameter";
import { ModelState } from "#common/model-state";
import { Model } from "#remodeler/code-model";

export class OperationParameter extends Parameter {
  protected constructor(code: ModelState<Model>, private param: codemodel.Parameter) {
    super(param.details.name, mscorlib.ToDo);
  }
  public static async Process(code: ModelState<Model>, param: codemodel.Parameter): Promise<OperationParameter> {
    const result = new OperationParameter(code, param);

    return result;
  }

}