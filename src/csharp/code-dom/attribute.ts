/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Initializer } from '#common/initializer';
import { ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

/** An c# Attribute that can be placed on methods, classes, members and parameters */
export class Attribute extends Initializer {
  public parameters = new Array<ExpressionOrLiteral>();

  constructor(public type: TypeDeclaration, objectIntializer?: Partial<Attribute>) {
    super();
    this.apply(objectIntializer);
  }

  get value(): string {
    const params = this.parameters.length > 0 ? `(${this.parameters.joinWith(each => valueOf(toExpression(each)))})` : '';
    return `[${this.type.declaration}${params}]`;
  }
}
