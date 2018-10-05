/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@microsoft.azure/autorest.codegen';
import { Expression, ExpressionOrLiteral } from '@microsoft.azure/autorest.codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/autorest.codegen-csharp';
import { TypeDeclaration } from '@microsoft.azure/autorest.codegen-csharp';
import { Variable } from '@microsoft.azure/autorest.codegen-csharp';
import { Schema } from '../code-model';

/** A TypeDeclaration that can assist in generating code for a variety of serialization, validation and other common use cases */
export interface EnhancedTypeDeclaration extends TypeDeclaration {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression;

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression;

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined;

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined;

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined;

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression;

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression;

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements;

  /** is a value for this required */
  isRequired: boolean;

  /** when encoding as xml, is this encoded as an attribute */
  isXmlAttribute: boolean;

  /** the underlying schema for this type declarartion. */
  schema: Schema;

  /** emits the code required to validate that this is set to a value */
  validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements;

  /** emits the code required to validate that this has a permissable value */
  validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements;
}
