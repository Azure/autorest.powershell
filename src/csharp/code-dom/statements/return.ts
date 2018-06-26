import { indent } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, valueOf } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function Return(expression?: ExpressionOrLiteral, objectInitializer?: Partial<ReturnStatement>) {
  return new ReturnStatement(expression, objectInitializer);
}

export class ReturnStatement extends Statements {
  constructor(public expression?: ExpressionOrLiteral, objectInitializer?: Partial<ReturnStatement>) {
    super();
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `return ${this.expression ? valueOf(this.expression) : ""};`;
  }
}