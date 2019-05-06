/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { Expression, ExpressionOrLiteral, toExpression, System } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { Schema } from '../code-model';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { Primitive } from './primitive';
import { ClientRuntime } from '../clientruntime';

export class Duration extends Primitive {
  public isXmlAttribute: boolean = false;
  public jsonType = ClientRuntime.JsonString;

  constructor(public schema: Schema, public isRequired: boolean) {
    super(schema);
  }
  get declaration(): string {
    return `global::System.TimeSpan${this.isRequired ? '' : '?'}`;
  }

  protected castJsonTypeToPrimitive(tmpValue: string, defaultValue: string) {
    return `global::System.Xml.XmlConvert.ToTimeSpan( ${tmpValue} )`;
  }

  get convertObjectMethod() {
    return `(v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() )`
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`${ClientRuntime.JsonString.new(`global::System.Xml.XmlConvert.ToString(${value})`)}`);
      case KnownMediaType.QueryParameter:
        if (this.isRequired) {
          return toExpression(`"${serializedName}=" + global::System.Uri.EscapeDataString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)${value}))`);
        } else {
          return toExpression(`(null == ${value} ? ${System.String.Empty} : "${serializedName}=" + global::System.Uri.EscapeDataString(global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)${value})))`);
        }
    }
    return toExpression(`/* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {

    return (`/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }
  public validatePresence(eventListener: Variable, property: Variable): string {
    return ``;
  }
}
