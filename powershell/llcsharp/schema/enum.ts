/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Schema } from '../code-model';
import { Schema as NewSchema } from '@azure-tools/codemodel';
import { String } from './string';
import { dotnet, Expression, ExpressionOrLiteral, toExpression } from '@azure-tools/codegen-csharp';
import { KnownMediaType } from '@azure-tools/codemodel-v3';

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

    /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`${content}.Content.ReadAsStringAsync().ContinueWith( body => ${this.deserializeFromString(mediaType, 'body.Result', defaultValue)})`);
    }
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }
}
