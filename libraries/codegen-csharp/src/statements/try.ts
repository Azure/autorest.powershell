/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { indent } from '@microsoft.azure/autorest.codegen';
import { Parameter } from '../parameter';
import { OneOrMoreStatements, StatementPossibilities, Statements } from './statement';

export function Try(body: StatementPossibilities, objectInitializer?: Partial<TryStatement>): TryStatement {
  return new TryStatement(body, objectInitializer);
}

export class TryStatement extends Statements {
  constructor(body: StatementPossibilities, objectInitializer?: Partial<TryStatement>) {
    super(body);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
try
{
${indent(super.implementation)}
}`.trim();
  }
}


export function _Catch(parameter: Parameter | undefined, body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>): TryStatement {
  return new _CatchStatement(parameter, body, objectInitializer);
}

export class _CatchStatement extends Statements {
  constructor(protected parameter: Parameter | undefined, body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>) {
    super(body);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    const p = this.parameter ? ` (${this.parameter.declaration})` : '';
    return `
catch${p}
{
${indent(super.implementation)}
}`.trim();
  }
}
