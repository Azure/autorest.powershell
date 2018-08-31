import { dotnet, System } from '#csharp/code-dom/dotnet';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

export function IsNotNull(expression: ExpressionOrLiteral) {
  return toExpression(`${dotnet.Null} != ${valueOf(expression)}`);
}

export function IsNull(expression: ExpressionOrLiteral) {
  return toExpression(`${dotnet.Null} == ${valueOf(expression)}`);
}

export function Cast(expression: ExpressionOrLiteral, targetType: TypeDeclaration): Expression {
  return toExpression(`(${targetType.declaration})${expression}`);
}