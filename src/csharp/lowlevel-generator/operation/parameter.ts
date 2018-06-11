

import { Method } from '#csharp/code-dom/method';
import * as mscorlib from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { ExtendedVariable } from '#csharp/lowlevel-generator/extended-variable';
import { POINT_CONVERSION_UNCOMPRESSED } from 'constants';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';
import { State } from '../generator';
import { HttpOperationParameter, Schema } from '#csharp/lowlevel-generator/code-model';

/** represents a method parameter for an http operation (header/cookie/query/path) */
export class OperationParameter extends Parameter implements ExtendedVariable {
  public typeDeclaration: Serialization & Validation;
  public param: HttpOperationParameter;

  constructor(parent: Method, param: HttpOperationParameter, state: State, objectInitializer?: Partial<OperationParameter>) {
    const typeDeclaration = state.project.modelsNamespace.resolveTypeDeclaration(param.schema, param.required, state.path('schema'));
    super(param.details.csharp.name, typeDeclaration);
    this.param = param;
    this.typeDeclaration = typeDeclaration;
    this.apply(objectInitializer);
    this.description = param.details.csharp.description || '';
  }

  public get validatePresenceStatement(): OneOrMoreStatements {
    return this.typeDeclaration.validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return this.typeDeclaration.validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */';// (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */';// (<TypeDeclaration>this.type).jsonDeserializationImplementation(this.name);
  }
}

/** represents a method parameter for an http operation (body) */
export class OperationBodyParameter extends Parameter implements ExtendedVariable {
  public typeDeclaration: Serialization & Validation;

  constructor(parent: Method, name: string, description: string, schema: Schema, required: boolean, state: State, objectInitializer?: Partial<OperationBodyParameter>) {
    const typeDeclaration = state.project.modelsNamespace.resolveTypeDeclaration(schema, required, state.path('schema'));
    super(name, typeDeclaration);
    this.typeDeclaration = typeDeclaration;

    this.apply(objectInitializer);
    this.description = description || schema.details.csharp.description;
  }
  public get validatePresenceStatement(): OneOrMoreStatements {
    return this.typeDeclaration.validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return this.typeDeclaration.validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* body parameter */';//  (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* body parameter */';// (<TypeDeclaration>this.type).jsonDeserializationImplementation(this.name);
  }
}

export class CallbackParameter extends Parameter {
  private genParameters: string;
  public bodyResponse: (Serialization & Validation) | null;
  public headerResponse: (Serialization & Validation) | null;
  public supportNamespace: Namespace;
  public responseType: mscorlib.LibraryType;

  // constructor(parent: Method, name: string, responseParameters: Array<TypeDeclaration>, state: State, objectInitializer?: Partial<CallbackParameter>) {
  constructor(parent: Method, name: string, bodyResponse: (Serialization & Validation) | null, headerResponse: (Serialization & Validation) | null, state: State, objectInitializer?: Partial<CallbackParameter>) {
    let responseDelegateType: mscorlib.LibraryType;
    let responsePayloadType: mscorlib.LibraryType;

    const genericParameters = bodyResponse ?
      headerResponse ?
        `<${bodyResponse.declaration},${headerResponse.declaration}>` :
        `<${bodyResponse.declaration}>` :
      headerResponse ?
        `<${headerResponse.declaration}>` :
        ``;

    super(name, new mscorlib.LibraryType(`${ClientRuntime.fullName}.OnResponse${genericParameters}`));
    this.genParameters = genericParameters;
    this.bodyResponse = bodyResponse;
    this.headerResponse = headerResponse;
    this.supportNamespace = state.project.supportNamespace;
    this.responseType = new mscorlib.LibraryType(`${ClientRuntime.fullName}.Response${genericParameters}`);
    this.apply(objectInitializer);
  }

  get bodyJsonDeserializeStatement(): string {
    return this.bodyResponse ? `async () => ${this.bodyResponse.jsonDeserializationImplementationOnNode(`Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )`)} ` : ``;
  }

  get bodyXmlDeserializeStatement(): string {
    return this.bodyResponse ? `async () => ${this.bodyResponse.declaration}.FromXml(await _response.Content.ReadAsStringAsync())` : ``;
  }

  get headerDeserializeStatement(): string {
    return this.headerResponse ? `async () => ${this.headerResponse.declaration}.FromHeaders( _response)` : ``;
  }

  get responseConstructorForJsonBody(): string {
    return this.bodyResponse && this.headerResponse ?
      `new ${ClientRuntime.fullName}.Response${this.genParameters}(${this.bodyJsonDeserializeStatement},${this.headerDeserializeStatement})` :  // both
      `new ${ClientRuntime.fullName}.Response${this.genParameters}(${this.bodyJsonDeserializeStatement}${this.headerDeserializeStatement})`; // either/neither
  }

  get responseConstructorForXmlBody(): string {
    return this.bodyResponse && this.headerResponse ?
      `new ${ClientRuntime.fullName}.Response${this.genParameters}(${this.bodyXmlDeserializeStatement},${this.headerDeserializeStatement})` :  // both
      `new ${ClientRuntime.fullName}.Response${this.genParameters}(${this.bodyXmlDeserializeStatement}${this.headerDeserializeStatement})`; // either/neither
  }
}
