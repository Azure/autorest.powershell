import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Class } from "#csharp/code-dom/class";
import { Parameter } from "#csharp/code-dom/parameter";

import { Model } from "#remodeler/code-model";
import { State } from "../generator";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { Method } from "#csharp/code-dom/method";

export class OperationParameter extends Parameter {
  protected constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }
  public static async create(parent: Method, param: codemodel.Parameter, state: State): Promise<OperationParameter> {
    if (param.schema) {
      const type = await state.project.modelsNamespace.resolveTypeDeclaration(param.schema, state.path('schema'));
      const parameter = new OperationParameter(param.details.name, type);
      parent.addParameter(parameter);

      parameter.description = param.details.description || "";

      return parameter;
    }
    throw Error("NO SCHEMA!");
  }

  public get validate(): string {
    return ``;
  }
}

export class OperationBodyParameter extends Parameter {
  protected constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }
  public static async create(parent: Method, name: string, description: string, schema: codemodel.Schema, state: State): Promise<OperationBodyParameter> {
    const type = await state.project.modelsNamespace.resolveTypeDeclaration(schema, state.path('schema'));
    const parameter = new OperationBodyParameter(name, type);
    parent.addParameter(parameter);

    parameter.description = description || schema.details.description || "";

    return parameter;

  }

}

export const undefinedType: TypeDeclaration = new mscorlib.LibraryType("Microsoft.Rest.undefined");

export class CallbackParameter extends Parameter {
  protected constructor(name: string, type: TypeDeclaration) {
    super(name, type);
  }
  public static async create(parent: Method, name: string, bodyType: codemodel.Schema | undefined  /*, headerType: codemodel.Schema*/, state: State): Promise<CallbackParameter> {
    const body = bodyType ? await state.project.modelsNamespace.resolveTypeDeclaration(bodyType, state) || undefinedType : undefinedType;
    // const header = await state.project.modelsNamespace.resolveTypeDeclaration(headerType, state) || undefined;
    const header = undefinedType;
    const onResponseType = new mscorlib.LibraryType(`Microsoft.Rest.OnResponse<${body.use},${header.use}>`);

    const parameter = new CallbackParameter(name, onResponseType);
    parent.addParameter(parameter);

    // parameter.description = description || schema.details.description || "";

    return parameter;
  }
}