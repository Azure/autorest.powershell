import { Expression, LiteralExpression } from "#csharp/code-dom/expression";

export function Ternery(booleanExpression: Expression, trueResult: Expression, falseResult: Expression) {
  return new LiteralExpression(`${booleanExpression.value} ? ${trueResult.value} : ${falseResult.value}`);
}