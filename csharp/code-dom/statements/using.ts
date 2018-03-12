import { Statements, Statement, OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { indent } from "#common/text-manipulation";

export class Using extends Statements {
  constructor(private usingStatement: Statement | string, statements: OneOrMoreStatements) {
    super(statements);
  }
  public get implementation(): string {
    return `
using( ${this.usingStatement} )
{
${indent(super.implementation)}
}`.trim();
  }
}

