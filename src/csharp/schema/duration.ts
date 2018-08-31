import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { KnownMediaType } from '#common/media-types';
import { ExpressionOrLiteral, Expression, toExpression } from '#csharp/code-dom/expression';
import { Variable } from '#csharp/code-dom/variable';
import { Schema } from '#csharp/lowlevel-generator/code-model';


export class Duration implements EnhancedTypeDeclaration {
  public isXmlAttribute: boolean = false;

  constructor(public schema: Schema, public isRequired: boolean) {
  }
  get declaration(): string {
    return `System.TimeSpan${this.isRequired ? '' : '?'}`
  }
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
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
    return toExpression(``);
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return toExpression(`null /* deserializeFromResponse doesn't support '${mediaType}' ${__filename}*/`);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return `/* serializeToContainerMember doesn't support '${mediaType}' ${__filename}*/`;
  }
  validateValue(property: Variable): string {
    return ``;
  }
  public validatePresence(property: Variable): string {
    return ``;
  }
}