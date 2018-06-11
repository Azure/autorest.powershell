import { indent } from '#common/text-manipulation';
import { Expression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function Return(expression: Expression, objectInitializer?: Partial<ReturnStatement>) {
  return new ReturnStatement(expression, objectInitializer);
}

export class ReturnStatement extends Statements {
  constructor(public expression: Expression, objectInitializer?: Partial<ReturnStatement>) {
    super();
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `return ${this.expression.value};`;
  }
}