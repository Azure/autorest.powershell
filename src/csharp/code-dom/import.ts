/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

export class Import {
  constructor(protected importStatement: string) {
  }

  public get implementation(): string {
    return `using ${this.importStatement};`;
  }
}

/** An Alias adds a using statement to a namespace, and can then be used as a type declaration too. */
export class Alias extends Import implements TypeDeclaration {

  constructor(public aliasName: string, protected typeDeclaration: TypeDeclaration) {
    super(`${aliasName} = ${typeDeclaration.declaration}`);
  }

  public get fullDefinition(): TypeDeclaration {
    return this.typeDeclaration;
  }

  public get declaration(): string {
    return this.aliasName;
  }
}