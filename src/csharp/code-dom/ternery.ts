import { Expression, LiteralExpression, ExpressionOrLiteral, valueOf } from "#csharp/code-dom/expression";

export function Ternery(booleanExpression: ExpressionOrLiteral, trueResult: ExpressionOrLiteral, falseResult: ExpressionOrLiteral) {
  return new LiteralExpression(`${valueOf(booleanExpression)} ? ${trueResult} : ${falseResult}`);
}