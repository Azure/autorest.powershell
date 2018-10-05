/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '@microsoft.azure/autorest.codegen';
import { Expression } from '../expression';
import { Parameter } from '../parameter';
import { StatementPossibilities, Statements } from './statement';

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
