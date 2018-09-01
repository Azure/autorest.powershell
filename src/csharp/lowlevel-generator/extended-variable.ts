/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '#common/media-types';
import { Expression, ExpressionOrLiteral } from '#csharp/code-dom/expression';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';

export interface ExtendedVariable extends Variable {
  typeDeclaration: EnhancedTypeDeclaration;

  validatePresenceStatement: OneOrMoreStatements;
  validationStatement: OneOrMoreStatements;
}

export interface EnhancedVariable extends Variable {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression;

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression;

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string): Expression;

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType): Expression;

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string): OneOrMoreStatements;

  validatePresenceStatement(eventListener: Variable): OneOrMoreStatements;
  validationStatement(eventListener: Variable): OneOrMoreStatements;

}
