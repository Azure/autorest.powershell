/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ExpressionOrLiteral, LiteralExpression, valueOf } from '#csharp/code-dom/expression';

export function Ternery(booleanExpression: ExpressionOrLiteral, trueResult: ExpressionOrLiteral, falseResult: ExpressionOrLiteral) {
  return new LiteralExpression(`${valueOf(booleanExpression)} ? ${trueResult} : ${falseResult}`);
}