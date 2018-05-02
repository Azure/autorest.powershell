import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Expression } from '#csharp/code-dom/expression';

export class If extends Statements {
  constructor(public conditional: Expression, statements: OneOrMoreStatements, objectInitializer?: Partial<If>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
if(${this.conditional.value})
{
${indent(super.implementation)}
}`.trim();
  }
}
