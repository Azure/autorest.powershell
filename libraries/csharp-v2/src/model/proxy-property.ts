/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Field } from '@microsoft.azure/autorest.codegen-csharp';
import { ImplementedProperty, Property } from '@microsoft.azure/autorest.codegen-csharp';
import { Statements } from '@microsoft.azure/autorest.codegen-csharp';
import { State } from '../generator';

export class ProxyProperty extends ImplementedProperty {
  constructor(protected backingFieldObject: Field, protected backingFieldProperty: Property, state: State, objectInitializer?: Partial<ProxyProperty>) {
    super(backingFieldProperty.name, backingFieldProperty.type);
    this.apply(objectInitializer);
    this.getterStatements = new Statements(`return ${this.backingFieldObject.name}.${this.backingFieldProperty.name};`);
    this.setterStatements = new Statements(`${this.backingFieldObject.name}.${this.backingFieldProperty.name} = value;`);
  }
}
