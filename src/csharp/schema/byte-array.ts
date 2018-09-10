/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '#common/media-types';
import { camelCase, deconstruct, nameof } from '#common/text-manipulation';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from '#csharp/code-dom/expression';
import { If } from '#csharp/code-dom/statements/if';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { popTempVar, pushTempVar } from '#csharp/schema/primitive';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class ByteArray implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  get declaration(): string {
    return `byte[]`;
  }
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    switch (mediaType) {
      case KnownMediaType.Xml: {
        const xTmp = `__${camelCase(['xml', ...deconstruct(serializedName)])}`;
        return toExpression(`If( ${valueOf(container)}?.Element("${serializedName}")?.Value, out var ${xTmp}) ? System.Convert.FromBase64String(${xTmp}) : ${defaultValue}`);
      }

      case KnownMediaType.Header: {
        const tmp = `__${camelCase(['header', ...deconstruct(serializedName)])}`;
        return toExpression(`System.Linq.Enumerable.FirstOrDefault(${serializedName}) is string ${tmp} ? System.Convert.FromBase64String(${tmp}) : ${defaultValue}`);

      }
    }
    return toExpression(`null /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }
  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
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
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    try {
      const b = pushTempVar();
      switch (mediaType) {
        case KnownMediaType.Xml: {
          return `AddIf( null != ${value} ? new System.Xml.Linq.XElement("${serializedName}", System.Convert.ToBase64String(${value})) : null, ${container}.Add);`
        }
        case KnownMediaType.Header: {
          return If(`null != ${value}`, `${valueOf(container)}.Add("${serializedName}", System.Convert.ToBase64String(${value}));`);
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
