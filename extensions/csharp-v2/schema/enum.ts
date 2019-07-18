/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema } from '../code-model';
import { String } from './string';
import { dotnet, toExpression } from '@microsoft.azure/codegen-csharp';

export class EnumImplementation extends String {
  public isXmlAttribute: boolean = false;
  get isNullable(): boolean {
    return !this.isRequired;
  }

  constructor(schema: Schema, isRequired: boolean) {
    super(schema, isRequired);
  }

  get defaultOfType() {
    return this.isRequired ? toExpression(`((${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}${this.isRequired ? '' : '?'})"")`) : dotnet.Null;
  }

  get convertObjectMethod() {
    return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}.CreateFrom`;
  }


  get declaration(): string { return `${this.schema.details.csharp.namespace}.${this.schema.details.csharp.name}${this.isRequired ? '' : '?'}`; }
}
