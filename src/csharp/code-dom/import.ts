/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

export function Import(namespace: string) {
  return new ImportDirective(namespace);
}

export function ImportStatic(namespace: TypeDeclaration) {
  return new ImportDirective(namespace.declaration);
}

export class ImportDirective {
  constructor(protected namespaceOrType: string) {
  }

  public get implementation(): string {
    return `using ${this.namespaceOrType};`;
  }
}

export class ImportStaticDirective extends ImportDirective {
  constructor(namespace: string) {
    super(namespace);
  }
  public get implementation(): string {
    return `using static ${this.namespaceOrType};`;
  }
}

/** An Alias adds a using statement to a namespace, and can then be used as a type declaration too. */
export class Alias extends ImportDirective implements TypeDeclaration {

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