/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { CommaChar } from '@microsoft.azure/codegen';
import { Class } from './class';
import { Expression, toExpression, valueOf } from './expression';
import { Method } from './method';

export class Constructor extends Method {
  constructor(protected containingClass: Class, objectIntializer?: Partial<Method>) {
    super(containingClass.name);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);

    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.access} ${this.static} ${this.abstract} ${this.name}(${parameterDeclaration})
`.slim();
  }

  public invoke(...parameters: Array<Expression>): Expression {
    return toExpression(`new ${this.containingClass.name}(${parameters.joinWith(each => valueOf(each))})`);
  }
}