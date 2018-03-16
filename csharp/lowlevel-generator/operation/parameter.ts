import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Class } from "#csharp/code-dom/class";
import { Parameter } from "#csharp/code-dom/parameter";

import { Model } from "#remodeler/code-model";
import { State } from "../generator";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { Method } from "#csharp/code-dom/method";

export class OperationParameter extends Parameter {
  constructor(parent: Method, param: codemodel.Parameter, state: State, objectInitializer?: Partial<OperationParameter>) {
    super(param.details.name, state.project.modelsNamespace.resolveTypeDeclaration(param.schema, state.path('schema')));
    this.apply(objectInitializer);
    this.description = param.details.description || "";

  }

  public get validate(): string {
    return ``;
  }
}

export class OperationBodyParameter extends Parameter {
  constructor(parent: Method, name: string, description: string, schema: codemodel.Schema, state: State, objectInitializer?: Partial<OperationBodyParameter>) {
    super(name, state.project.modelsNamespace.resolveTypeDeclaration(schema, state.path('schema')));
    this.apply(objectInitializer);
    this.description = description || schema.details.description || "";

  }
}

export const undefinedType: TypeDeclaration = new mscorlib.LibraryType("Microsoft.Rest.undefined");

export class CallbackParameter extends Parameter {
  constructor(parent: Method, name: string, bodyType: codemodel.Schema | undefined  /*, headerType: codemodel.Schema*/, state: State, objectInitializer?: Partial<CallbackParameter>) {
    const ss = bodyType === undefined ? undefinedType : state.project.modelsNamespace.resolveTypeDeclaration(bodyType, state);
    super(name, new mscorlib.LibraryType(`Microsoft.Rest.OnResponse<${ss.use},${undefinedType.use}>`));
    this.apply(objectInitializer);
  }
}