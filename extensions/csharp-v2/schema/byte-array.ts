/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType, knownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { camelCase, deconstruct, nameof } from '@microsoft.azure/codegen';
import { Expression, ExpressionOrLiteral, toExpression, valueOf, System } from '@microsoft.azure/codegen-csharp';
import { If } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { Schema } from '../code-model';
import { popTempVar, pushTempVar } from './primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { ClientRuntime } from '../clientruntime';

export class ByteArray implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  get declaration(): string {
    return `byte[]`;
  }

  get convertObjectMethod() {
    return `i => i`;
  }

  public isNullable = true;

  get defaultOfType() {
    return toExpression(`null /* byte array */`);
  }
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    try {
      const tmp = pushTempVar();

      switch (mediaType) {
        case KnownMediaType.Xml: {
          return toExpression(`If( ${valueOf(container)}?.Element("${serializedName}")?.Value, out var ${tmp}) ? System.Convert.FromBase64String(${tmp}.Replace("_","/").Replace("-","+").PadRight(  ${tmp}.Length  + ${tmp}.Length * 3 % 4, '=')) : ${defaultValue}`);
        }
        case KnownMediaType.Json: {
          return toExpression(`If( ${valueOf(container)}?.PropertyT<${ClientRuntime.JsonString}>("${serializedName}"), out var ${tmp}) ?  System.Convert.FromBase64String( ((string)${tmp}).Replace("_","/").Replace("-","+").PadRight(  ((string)${tmp}).Length  + ((string)${tmp}).Length * 3 % 4, '=') ) : null`);
        }
        case KnownMediaType.Header: {
          //const tmp = `__${camelCase(['header', ...deconstruct(serializedName)])}`;
          return toExpression(`System.Linq.Enumerable.FirstOrDefault(${serializedName}) is string ${tmp} ? System.Convert.FromBase64String(${tmp}) : ${defaultValue}`);
        }
      }
    } finally {
      popTempVar();
    }
    return toExpression(`null /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Json:
        return toExpression(`${ClientRuntime.JsonString.new(`System.Convert.ToBase64String(${value})`)}`);
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return toExpression(`null /* serializeToContent doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromString doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    try {
      const b = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Xml: {
          return `AddIf( null != ${value} ? ${System.Xml.Linq.XElement.new(serializedName, System.Convert.ToBase64String(value))}  : null, ${container}.Add);`
        }

        case KnownMediaType.Json: {
          return `AddIf( null != ${value} ? ${System.Convert.ToBase64String(value)} : null ,(v)=> ${container}.Add( "${serializedName}",v) );`;
        }

        case KnownMediaType.Header: {
          return If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}", ${System.Convert.ToBase64String(value)});`);
        }
      }

    } finally {
      popTempVar();
    }
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
  }

  constructor(public schema: Schema, public isRequired: boolean) {
  }

  validateValue(eventListener: Variable, property: Variable): string {
    return ``;
  }

  public validatePresence(eventListener: Variable, property: Variable): string {
    if (this.isRequired) {
      return `await ${eventListener}.AssertNotNull(${nameof(property.value)},${property});`.trim();
    }
    return ``;
  }
}
