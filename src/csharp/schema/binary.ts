/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '#common/media-types';
import { nameof } from '#common/text-manipulation';
import { System } from '#csharp/code-dom/dotnet';
import { Expression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class Binary implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;
  constructor(public schema: Schema, public isRequired: boolean) {
  }

  get declaration(): string {
    return System.IO.Stream.declaration;
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    if (mediaType === KnownMediaType.Stream) {
      // dunno.
    }
    return toExpression(`null /* deserializeFromContainerMember doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return toExpression(`null /* deserializeFromNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return undefined;
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    if (mediaType === KnownMediaType.Stream) {
      return toExpression(`new System.Net.Http.StreamContent(${value})`);
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
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
