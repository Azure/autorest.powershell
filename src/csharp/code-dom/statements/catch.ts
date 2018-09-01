/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '#common/text-manipulation';
import { Expression } from '#csharp/code-dom/expression';
import { Parameter } from '#csharp/code-dom/parameter';
import { StatementPossibilities, Statements } from '#csharp/code-dom/statements/statement';

export function Catch(parameter: Parameter, body: StatementPossibilities, objectInitializer?: Partial<CatchStatement>): CatchStatement {
  return new CatchStatement(parameter, body, objectInitializer);
}

export class CatchStatement extends Statements {
  public when?: Expression;

  constructor(protected parameter: Parameter, body: StatementPossibilities, objectInitializer?: Partial<CatchStatement>) {
    super(body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    const when = this.when ? ` when (${this.when})` : ``;
    return `
catch(${this.parameter.declaration})${when}
{
${indent(super.implementation)}
} `.trim();
  }
}
