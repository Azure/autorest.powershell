/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType } from '@azure-tools/codemodel-v3';
import { Expression, ExpressionOrLiteral } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { Variable } from '@azure-tools/codegen-csharp';
import { EnhancedTypeDeclaration } from './schema/extended-type-declaration';

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
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression;

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression;

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements;

  validatePresenceStatement(eventListener: Variable): OneOrMoreStatements;
  validationStatement(eventListener: Variable): OneOrMoreStatements;

}
