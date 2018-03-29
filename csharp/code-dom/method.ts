import { Statement, Statements } from "./statements/statement";
import { Parameter } from "./parameter";
import { TypeDeclaration } from "./type-declaration";
import * as mscorlib from "./mscorlib";
import { Access, New, Modifier, Static, Override, Virtual, Sealed, Abstract, Extern, Async } from "#csharp/code-dom/access-modifier";
import { docCommentPrefix, comment, indent, EOL, CommaChar, join, joinComma, docComment } from "#common/text-manipulation";
import { xmlize, summary } from "#csharp/code-dom/doc-comments";

export class Method extends Statements {
  public parameters = new Array<Parameter>();
  public "new": New = Modifier.None;
  public access = Access.Public;
  public "static": Static = Modifier.None;
  public virtual: Virtual = Modifier.None;
  public sealed: Sealed = Modifier.None;
  public override: Override = Modifier.None;
  public abstract: Abstract = Modifier.None;
  public extern: Extern = Modifier.None;
  public async: Async = Modifier.None;

  public description: string = "";

  constructor(public name: string, protected returnType: TypeDeclaration = mscorlib.Void, objectIntializer?: Partial<Method>) {
    super();
    this.apply(objectIntializer);
  }

  public addParameter(parameter: Parameter): Parameter {
    this.parameters.push(parameter);
    return parameter;
  }

  protected get summaryDocumentation(): string {
    return docComment(summary(this.description));
  }

  protected get parameterDocumentation(): string {
    return docComment(this.parameters.joinWith(p => p.comment, EOL));
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.use} ${this.name}(${parameterDeclaration}) 
`.slim();
  }

  public get implementation(): string {
    return `
${this.declaration}
{
${indent(super.implementation)}  
}`.trim();

  }
}

export class PartialMethod extends Method {
  constructor(name: string, returnType: TypeDeclaration = mscorlib.Void, objectIntializer?: Partial<PartialMethod>) {
    super(name, returnType);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
partial ${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.use} ${this.name}(${parameterDeclaration}) 
`.slim();
  }

  public get implementation(): string {
    return `${this.declaration};`.slim();
  }

}
