import { Statement } from "./statement";
import { Parameter } from "./parameter";
import { TypeDeclaration } from "./type-declaration";
import * as mscorlib from "./mscorlib";


export class Method {
  private statements = new Array<Statement>();
  private parameters = new Array<Parameter>();

  constructor(public name: string, private returnType: TypeDeclaration = mscorlib.Void) {

  }


  public addStatement(statement: Statement): Statement {
    this.statements.push(statement);
    return statement;
  }

  public addParameter(parameter: Parameter): Parameter {
    this.parameters.push(parameter);
    return parameter;
  }

  public get implementation(): string {
    return `xxxx;`
  }
}