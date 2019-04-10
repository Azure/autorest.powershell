/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Field, TypeDeclaration, StatementPossibilities } from '@microsoft.azure/codegen-csharp';
import { ImplementedProperty, Property } from '@microsoft.azure/codegen-csharp';
import { Statements } from '@microsoft.azure/codegen-csharp';
import { State } from '../generator';

export class OldProxyProperty extends ImplementedProperty {
  constructor(protected backingFieldObject: Field, protected bfType: TypeDeclaration, protected bfName: string, state: State, objectInitializer?: Partial<OldProxyProperty>) {
    super(bfName, bfType);
    this.apply(objectInitializer);
    this.getterStatements = new Statements(`return ${this.backingFieldObject.name}.${this.bfName};`);
    this.setterStatements = new Statements(`${this.backingFieldObject.name}.${this.bfName} = value;`);
  }
}
