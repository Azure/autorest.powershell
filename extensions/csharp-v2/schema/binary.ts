/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { nameof } from '@microsoft.azure/codegen';
import { System, valueOf } from '@microsoft.azure/codegen-csharp';
import { Expression, ExpressionOrLiteral, toExpression } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { Schema } from '../code-model';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class Binary implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;
  constructor(public schema: Schema, public isRequired: boolean) {
  }

  get convertObjectMethod() {
    return `i=>i`;
  }
  public isNullable: boolean = true;

  get defaultOfType() {
    return toExpression(`null /* binary type */`);
  }

  get declaration(): string {
    return System.IO.Stream.declaration;
  }

  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    if (mediaType === KnownMediaType.Stream) {
      // dunno.
    };
    if (mediaType === KnownMediaType.Json) {
      return toExpression(`null /* no need to deserialize a stream here */ `);
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
    return toExpression(`${valueOf(content)}.Content.ReadAsStreamAsync()`);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    if (mediaType === KnownMediaType.Stream) {
      return toExpression(System.Net.Http.StreamContent.new(value));
    }
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    return toExpression(`null /* serializeToNode doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    if (mediaType === KnownMediaType.Json) {
      return `/* shouldn't need to serialize binary for a ${mediaType} */`;
    }
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
