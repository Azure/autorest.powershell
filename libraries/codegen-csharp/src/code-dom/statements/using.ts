/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

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
