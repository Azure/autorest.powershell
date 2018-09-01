/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { CommaChar } from '#common/text-manipulation';
import { Method } from './method';

export class Operator extends Method {
  constructor(name: string, objectIntializer?: Partial<Method>) {
    super(name);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);

    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.name}(${parameterDeclaration})
`.slim();
  }
}