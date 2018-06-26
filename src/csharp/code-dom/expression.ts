import { Variable, LocalVariable } from "#csharp/code-dom/variable";
import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { Statement, OneOrMoreStatements, Statements } from "#csharp/code-dom/statements/statement";
import { Parameter } from "#csharp/code-dom/parameter";
import { indent } from "#common/text-manipulation";
import { Async, Modifier } from "#csharp/code-dom/access-modifier";

export type ExpressionOrLiteral = Expression | string;
export function toExpression(expression: ExpressionOrLiteral): Expression {
  return typeof expression === 'string' ? new LiteralExpression(expression) : expression;
}
export function valueOf(expression: ExpressionOrLiteral): string {
  return typeof expression === 'string' ? expression : expression.value;
}
/** An expression is a combination of operands (variables, literals, method calls) and operators that can be evaluated to a single value  */
export interface Expression {
  value: string;
  toString(): string;
}

/** an expression of a constant string value  */
export class StringExpression implements Expression {
  public value: string;
  constructor(value: string) {
    this.value = `@"${value.replace(/"/g, '""')}"`;
  }
  public toString(): string {
    return this.value;
  }
}

/** an arbitrary user-defined expression  */
export class LiteralExpression implements Expression {
  constructor(public value: string) {
  }
  public toString(): string {
    return this.value;
  }
}

/** a c# 'is' expression */
export function Is(expression: ExpressionOrLiteral, isType: TypeDeclaration): Expression {
  return new IsExpression(expression, isType);
}

/** a c# 'is' expression */
export class IsExpression implements Expression {
  constructor(public expression: ExpressionOrLiteral, public isType: TypeDeclaration) {
  }
  get value(): string {
    return `${valueOf(this.expression)} is ${this.isType.declaration}`;
  }
}

/** a c# 'is' expression that declares a local variable  */
export function IsDeclaration(expression: ExpressionOrLiteral, isType: TypeDeclaration, name: string): IsExpressionDeclaration {
  return new IsExpressionDeclaration(expression, isType, name);
}

/** a c# 'is' expression that declares a local variable  */
export class IsExpressionDeclaration extends LocalVariable implements Expression {
  constructor(public expression: ExpressionOrLiteral, public isType: TypeDeclaration, name: string) {
    super(name, isType);
  }
  public get check(): Expression {
    return new LiteralExpression(`${valueOf(this.expression)} is ${this.isType.declaration} ${this.name}`);
  }

  get value(): string {
    return this.name;
  }
}

export function Lambda(parameters: Array<Parameter>, body: OneOrMoreStatements, objectIntializer?: Partial<LambdaExpression>) {

}

export class LambdaExpression extends Statements implements Expression {
  public async: Async = Modifier.None;

  constructor(protected parameters: Array<Parameter>, protected body: OneOrMoreStatements, objectIntializer?: Partial<LambdaExpression>) {
    super(body);
    this.apply(objectIntializer);
  }

  get value(): string {
    return `
${this.async}(${this.parameters.joinWith(each => each.name)}) => {
${indent(super.implementation)}
}
`.trim();
  }

}