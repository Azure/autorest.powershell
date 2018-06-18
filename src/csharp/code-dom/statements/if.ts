import { indent } from '#common/text-manipulation';
import { Expression, LiteralExpression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function If(conditional: ExpressionOrLiteral, statements: OneOrMoreStatements, objectInitializer?: Partial<IfStatement>) {
  return new IfStatement(conditional, statements, objectInitializer);
}

export class IfStatement extends Statements {
  conditional: Expression;
  constructor(conditional: ExpressionOrLiteral, statements: OneOrMoreStatements, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.conditional = toExpression(conditional);
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

export class ElseIfStatement extends Statements {
  conditional: Expression;
  constructor(conditional: ExpressionOrLiteral, statements: OneOrMoreStatements, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.conditional = toExpression(conditional);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
else if(${this.conditional.value})
{
${indent(super.implementation)}
}`.trim();
  }
}

export function ElseIf(conditional: ExpressionOrLiteral, statements: OneOrMoreStatements, objectInitializer?: Partial<IfStatement>) {
  return new ElseIfStatement(conditional, statements, objectInitializer);
}


export function Else(statements: OneOrMoreStatements, objectInitializer?: Partial<ElseStatement>) {
  return new ElseStatement(statements, objectInitializer);
}

export class ElseStatement extends Statements {
  constructor(statements: OneOrMoreStatements, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
else
{
${indent(super.implementation)}
}`.trim();
  }
}

export function Not(conditional: Expression): Expression {
  return new LiteralExpression(`!(${conditional.value})`);
}