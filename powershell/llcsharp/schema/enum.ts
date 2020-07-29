/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema } from '../code-model';
import { Schema as NewSchema } from '@azure-tools/codemodel';
import { String, NewString } from './string';
import { dotnet, toExpression } from '@azure-tools/codegen-csharp';

export class EnumImplementation extends String {
  public isXmlAttribute = false;
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

export class NewEnumImplementation extends NewString {
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
