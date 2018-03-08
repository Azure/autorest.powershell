import { Statement, Statements } from "./statements/statement";
import { Parameter } from "./parameter";
import { TypeDeclaration } from "./type-declaration";
import * as mscorlib from "./mscorlib";
import { AccessModifier } from "#csharp-code-dom/access-modifier";
import { docCommentPrefix, comment, indent, EOL, CommaChar, join, joinComma, docComment } from "#common/text-manipulation";


export class Method extends Statements {
  private parameters = new Array<Parameter>();
  public accessModifier = AccessModifier.Public;
  public isAsync = false;
  public description: string = "";

  constructor(public name: string, private returnType: TypeDeclaration = mscorlib.Void) {
    super();
  }

  public addParameter(parameter: Parameter): Parameter {
    this.parameters.push(parameter);
    return parameter;
  }

  public get declaration(): string {
    const description = docComment(this.description);
    const params = docComment(this.parameters.joinWith(p => p.comment, EOL));
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);

    const asynch = this.isAsync ? "async " : "";
    return `
${description}
${params}
${this.accessModifier} ${asynch}${this.returnType.use} ${this.name}(${parameterDeclaration}) {
${indent(super.implementation, 1)}  
}
`.trim();
  }

  public get implementation(): string {
    return `
${this.declaration}
`.trim();

  }
}