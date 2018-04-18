import { Method } from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Parameter } from "#csharp/code-dom/parameter";
import { OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { ClientRuntime } from "#csharp/lowlevel-generator/clientruntime";
import * as codemodel from "#remodeler/code-model";
import { State } from "../generator";
import { PropertyType } from "../type-declaration";
import { Namespace } from "#csharp/code-dom/namespace";
import { pascalCase, fixLeadingNumber, deconstruct } from "#common/text-manipulation";


export class OperationParameter extends Parameter {

  constructor(parent: Method, public param: codemodel.Parameter, state: State, objectInitializer?: Partial<OperationParameter>) {

    super(param.details.name, state.project.modelsNamespace.resolveTypeDeclaration(param.schema, param.required, state.path('schema')));
    this.apply(objectInitializer);
    this.description = param.details.description || "";


  }
  public get validatePresenceStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */'// (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* operation parameter */'// (<TypeDeclaration>this.type).jsonDeserializationImplementation(this.name);
  }
}

export class OperationBodyParameter extends Parameter {
  constructor(parent: Method, name: string, description: string, schema: codemodel.Schema, required: boolean, state: State, objectInitializer?: Partial<OperationBodyParameter>) {
    super(name, state.project.modelsNamespace.resolveTypeDeclaration(schema, required, state.path('schema')));
    this.apply(objectInitializer);
    this.description = description || schema.details.description || "";
  }
  public get validatePresenceStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).validatePresence(this.name);
  }
  public get validationStatement(): OneOrMoreStatements {
    return (<PropertyType>this.type).validateValue(this.name);
  }
  public get jsonSerializationStatement(): OneOrMoreStatements {
    return '/* body parameter */'//  (<TypeDeclaration>this.type).jsonserialize(this.name);
  }
  public get jsonDeserializationStatement(): OneOrMoreStatements {
    return '/* body parameter */'// (<TypeDeclaration>this.type).jsonDeserializationImplementation(this.name);
  }

}

export class CallbackParameter extends Parameter {
  private genParameters: string;
  bodyResponse: PropertyType | null
  headerResponse: PropertyType | null;
  supportNamespace: Namespace;
  responseType: mscorlib.LibraryType;

  // constructor(parent: Method, name: string, responseParameters: Array<TypeDeclaration>, state: State, objectInitializer?: Partial<CallbackParameter>) {
  constructor(parent: Method, name: string, bodyResponse: PropertyType | null, headerResponse: PropertyType | null, state: State, objectInitializer?: Partial<CallbackParameter>) {
    let responseDelegateType: mscorlib.LibraryType;
    let responsePayloadType: mscorlib.LibraryType;

    const genericParameters = bodyResponse ?
      headerResponse ?
        `<${bodyResponse.use},${headerResponse.use}>` :
        `<${bodyResponse.use}>` :
      headerResponse ?
        `<${headerResponse.use}>` :
        ``;


    super(name, new mscorlib.LibraryType(`${ClientRuntime.fullName}.OnResponse${genericParameters}`));
    this.genParameters = genericParameters;
    this.bodyResponse = bodyResponse;
    this.headerResponse = headerResponse;
    this.supportNamespace = state.project.supportNamespace;
    this.responseType = new mscorlib.LibraryType(`${ClientRuntime.fullName}.Response${genericParameters}`)
    this.apply(objectInitializer);
  }

  get bodyJsonDeserializeStatement(): string {
    return this.bodyResponse ? `async () => ${this.bodyResponse.jsonDeserializationImplementationOnNode(`Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )`)} ` : ``;
  }

  get bodyXmlDeserializeStatement(): string {
    return this.bodyResponse ? `async () => ${this.bodyResponse.use}.FromXml(await _response.Content.ReadAsStringAsync())` : ``;
  }

  get headerDeserializeStatement(): string {
    return this.headerResponse ? `async () => ${this.headerResponse.use}.FromHeaders( _response)` : ``;
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