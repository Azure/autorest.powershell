import { KnownMediaType } from '#common/media-types';
import { Expression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';

/** A TypeDeclaration that can assist in generating code for a variety of serialization, validation and other common use cases */
export interface EnhancedTypeDeclaration extends TypeDeclaration {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression;

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression;

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined;

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
  validatePresence(property: Variable): OneOrMoreStatements;

  /** emits the code required to validate that this has a permissable value */
  validateValue(property: Variable): OneOrMoreStatements;
}
