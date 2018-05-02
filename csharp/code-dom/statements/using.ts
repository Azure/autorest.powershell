import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statement, Statements } from '#csharp/code-dom/statements/statement';

export class Using extends Statements {
  constructor(private usingStatement: Statement | string, statements: OneOrMoreStatements, objectInitializer?: Partial<Using>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
using( ${this.usingStatement} )
{
${indent(super.implementation)}
}`.trim();
  }
}

