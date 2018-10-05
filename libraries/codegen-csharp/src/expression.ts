/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '@microsoft.azure/autorest.codegen';
import { Async, Modifier } from './access-modifier';
import { Cast, IsNotNull, IsNull } from './comparisons';
import { Parameter } from './parameter';
import { OneOrMoreStatements, Statements } from './statements/statement';
import { TypeDeclaration } from './type-declaration';
import { LocalVariable } from './variable';

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
  IsNull: Expression;
  IsNotNull: Expression;
  toString(): string;
  Cast(toType: TypeDeclaration): Expression;
}

export abstract class BaseExpression implements Expression {
  abstract value: string;
  toString(): string {
    return this.value;
  }
  get IsNull(): Expression {
    return IsNull(this);
  }
  get IsNotNull(): Expression {
    return IsNotNull(this);
  }
  Cast(toType: TypeDeclaration): Expression {
    return Cast(this, toType);
  }
}

/** an expression of a constant string value  */
export class StringExpression extends BaseExpression {
  public value: string;
  constructor(value: string) {
    super();
    this.value = `@"${value.replace(/"/g, '""')}"`;
  }
}

/** an arbitrary user-defined expression  */
export class LiteralExpression extends BaseExpression {
  constructor(public value: string) {
    super();
  }
}

/** a c# 'is' expression */
export function Is(expression: ExpressionOrLiteral, isType: TypeDeclaration): Expression {
  return new IsExpression(expression, isType);
}

/** a c# 'is' expression */
export class IsExpression extends BaseExpression {
  constructor(public expression: ExpressionOrLiteral, public isType: TypeDeclaration) {
    super();
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
  get IsNull(): Expression {
    return IsNull(this);
  }
  get IsNotNull(): Expression {
    return IsNotNull(this);
  }
  Cast(toType: TypeDeclaration): Expression {
    return Cast(this, toType);
  }
  get value(): string {
    return this.name;
  }
  public toString(): string {
    return this.value;
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
  public toString(): string {
    return this.value;
  }
  get IsNull(): Expression {
    return IsNull(this);
  }
  Cast(toType: TypeDeclaration): Expression {
    return Cast(this, toType);
  }
  get IsNotNull(): Expression {
    return IsNotNull(this);
  }

}
