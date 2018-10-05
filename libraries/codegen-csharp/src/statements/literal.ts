/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Statement } from './statement';

export class LiteralStatement implements Statement {
  constructor(public implementation: string) {
  }
}
