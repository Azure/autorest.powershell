/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, LiteralExpression, toExpression, valueOf } from '#csharp/code-dom/expression';
import { StatementPossibilities, Statements } from '#csharp/code-dom/statements/statement';

export function If(conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
  return new IfStatement(conditional, statements, objectInitializer);
}

export class IfStatement extends Statements {
  constructor(private conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
if (${valueOf(this.conditional)})
{
${indent(super.implementation)}
}`.trim();
  }
}

export function While(conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
  return new WhileStatement(conditional, statements, objectInitializer);
}

export class WhileStatement extends Statements {
  conditional: Expression;
  constructor(conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.conditional = toExpression(conditional);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
while (${this.conditional.value})
{
${indent(super.implementation)}
}`.trim();
  }
}

export class ElseIfStatement extends Statements {
  conditional: Expression;
  constructor(conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
    super(statements);
    this.conditional = toExpression(conditional);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
else if (${this.conditional.value})
{
${indent(super.implementation)}
}`.trim();
  }
}

export function ElseIf(conditional: ExpressionOrLiteral, statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
  return new ElseIfStatement(conditional, statements, objectInitializer);
}


export function Else(statements: StatementPossibilities, objectInitializer?: Partial<ElseStatement>) {
  return new ElseStatement(statements, objectInitializer);
}

export class ElseStatement extends Statements {
  constructor(statements: StatementPossibilities, objectInitializer?: Partial<IfStatement>) {
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