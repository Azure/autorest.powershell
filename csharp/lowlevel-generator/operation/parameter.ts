import * as codemodel from "#remodeler/code-model";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Class } from "#csharp/code-dom/class";
import { Parameter } from "#csharp/code-dom/parameter";

import { Model } from "#remodeler/code-model";
import { State } from "../generator";
import { TypeDeclaration, LibraryType } from "../type-declaration";
import { Method } from "#csharp/code-dom/method";
import { ClientRuntime } from "#csharp/lowlevel-generator/clientruntime";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";

export class OperationParameter extends Parameter {
  constructor(parent: Method, param: codemodel.Parameter, state: State, objectInitializer?: Partial<OperationParameter>) {

    super(param.details.name, state.project.modelsNamespace.resolveTypeDeclaration(param.schema, param.required, state.path('schema')));
    this.apply(objectInitializer);
    this.description = param.details.description || "";
  }
  public get validatePresenceStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */'// (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */'// (<TypeDeclaration>this.type).jsondeserialize(this.name);
  }
}

export class OperationBodyParameter extends Parameter {
  constructor(parent: Method, name: string, description: string, schema: codemodel.Schema, required: boolean, state: State, objectInitializer?: Partial<OperationBodyParameter>) {
    super(name, state.project.modelsNamespace.resolveTypeDeclaration(schema, required, state.path('schema')));
    this.apply(objectInitializer);
    this.description = description || schema.details.description || "";
  }
  public get validatePresenceStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<TypeDeclaration>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* body parameter */'//  (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* body parameter */'// (<TypeDeclaration>this.type).jsondeserialize(this.name);
  }

}

export const undefinedType: TypeDeclaration = new LibraryType(`${ClientRuntime.fullName}.undefined`);

export class CallbackParameter extends Parameter {
  constructor(parent: Method, name: string, bodyType: codemodel.Schema | undefined  /*, headerType: codemodel.Schema*/, state: State, objectInitializer?: Partial<CallbackParameter>) {
    const ss = bodyType === undefined ? undefinedType : state.project.modelsNamespace.resolveTypeDeclaration(bodyType, true, state);
    super(name, new mscorlib.LibraryType(`${ClientRuntime.fullName}.OnResponse<${ss.use},${undefinedType.use}>`));
    this.apply(objectInitializer);
  }
}