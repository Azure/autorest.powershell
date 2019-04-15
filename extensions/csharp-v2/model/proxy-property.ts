/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Field, TypeDeclaration, StatementPossibilities } from '@microsoft.azure/codegen-csharp';
import { Property } from '@microsoft.azure/codegen-csharp';
import { Statements } from '@microsoft.azure/codegen-csharp';
import { State } from '../generator';

export class OldProxyProperty extends Property {
  constructor(protected backingFieldObject: Field, protected bfType: TypeDeclaration, protected bfName: string, state: State, objectInitializer?: Partial<OldProxyProperty>) {
    super(bfName, bfType);
    this.apply(objectInitializer);
    this.get = new Statements(`return ${this.backingFieldObject.name}.${this.bfName};`);
    this.set = new Statements(`${this.backingFieldObject.name}.${this.bfName} = value;`);
  }
}
