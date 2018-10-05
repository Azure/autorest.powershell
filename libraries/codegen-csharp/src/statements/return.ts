/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ExpressionOrLiteral, valueOf } from '../expression';
import { Statements } from './statement';

export function Return(expression?: ExpressionOrLiteral, objectInitializer?: Partial<ReturnStatement>) {
  return new ReturnStatement(expression, objectInitializer);
}

export class ReturnStatement extends Statements {
  constructor(public expression?: ExpressionOrLiteral, objectInitializer?: Partial<ReturnStatement>) {
    super();
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `return ${this.expression ? valueOf(this.expression) : ''};`;
  }
}
