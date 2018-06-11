import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statement, Statements } from '#csharp/code-dom/statements/statement';
import { Expression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';

export function Using(usingExpression: ExpressionOrLiteral, body: OneOrMoreStatements, objectInitializer?: Partial<UsingStatement>): UsingStatement {
  return new UsingStatement(usingExpression, body, objectInitializer);
}

export class UsingStatement extends Statements {
  usingExpression: Expression;
  constructor(usingExpression: ExpressionOrLiteral, statements: OneOrMoreStatements, objectInitializer?: Partial<UsingStatement>) {
    super(statements);
    this.usingExpression = toExpression(usingExpression);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
using( ${this.usingExpression.value} )
{
${indent(super.implementation)}
}`.trim();
  }
}

