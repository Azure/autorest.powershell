/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Statement } from '#csharp/code-dom/statements/statement';

export class LiteralStatement implements Statement {
  constructor(public implementation: string) {
  }
}
