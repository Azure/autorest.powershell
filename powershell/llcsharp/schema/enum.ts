/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema } from '../code-model';
import { Schema as NewSchema } from '@azure-tools/codemodel';
import { String } from './string';
import { dotnet, toExpression } from '@azure-tools/codegen-csharp';

export class EnumImplementation extends String {
  public isXmlAttribute = false;
  get isNullable(): boolean {
    return !this.isRequired;
  }

  constructor(schema: NewSchema, isRequired: boolean) {

    super(schema, isRequired);
  }

  get defaultOfType() {
    return this.isRequired ? toExpression(`((${this.schema.language.csharp?.namespace}.${this.schema.language.csharp?.name}${this.isRequired ? '' : '?'})"")`) : dotnet.Null;
  }

  get convertObjectMethod() {
    return `${this.schema.language.csharp?.namespace}.${this.schema.language.csharp?.name}.CreateFrom`;
  }


  get declaration(): string { return `${this.schema.language.csharp?.namespace}.${this.schema.language.csharp?.name}${this.isRequired ? '' : '?'}`; }
}
