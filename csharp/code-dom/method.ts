import { Statement, Statements } from "./statements/statement";
import { Parameter } from "./parameter";
import { TypeDeclaration } from "./type-declaration";
import * as mscorlib from "./mscorlib";
import { AccessModifier } from "#csharp/code-dom/access-modifier";
import { docCommentPrefix, comment, indent, EOL, CommaChar, join, joinComma, docComment } from "#common/text-manipulation";
import { xmlize, summary } from "#csharp/code-dom/doc-comments";


export class Method extends Statements {
  public parameters = new Array<Parameter>();
  public accessModifier = AccessModifier.Public;
  public isAsync = false;
  public isOverride = false;
  public isNew = false;
  public description: string = "";
  public isStatic: boolean = false;

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
    const overrideOrNew = this.isOverride ? " override " : this.isNew ? " new " : " ";
    const stat = this.isStatic ? " static" : "";
    const asynch = this.isAsync ? "async " : "";
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.accessModifier}${stat}${overrideOrNew}${asynch}${this.returnType.use} ${this.name}(${parameterDeclaration}) 
`.trim();
  }

  public get implementation(): string {
    return `
${this.declaration}
{
${indent(super.implementation)}  
}`.trim();

  }
}