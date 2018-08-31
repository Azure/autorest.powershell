import { BackedProperty } from '#csharp/code-dom/property';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';
import { ModelClass } from './model-class';

import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { Schema, Property } from '#csharp/lowlevel-generator/code-model';
import { Access } from '#csharp/code-dom/access-modifier';
import { EnhancedVariable } from '#csharp/lowlevel-generator/extended-variable';
import { KnownMediaType } from '#common/media-types';
import { ExpressionOrLiteral, Expression } from '#csharp/code-dom/expression';
import { Variable } from '#csharp/code-dom/variable';

export class ModelProperty extends BackedProperty implements EnhancedVariable {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression {
    return this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression {
    return this.typeDeclaration.deserializeFromNode(mediaType, node, this);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, container, this, serializedName);
  }

  private required: boolean;
  public IsHeaderProperty: boolean;
  public schema: Schema;
  public serializedName: string;
  private typeDeclaration: EnhancedTypeDeclaration;

  constructor(parent: ModelClass, property: Property, serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
    const decl = state.project.modelsNamespace.resolveTypeDeclaration(property.schema, property.details.csharp.required, state.path("schema"));
    super(property.details.csharp.name, decl);
    this.typeDeclaration = decl;
    this.serializedName = serializedName;
    this.schema = property.schema;
    if (this.schema.readOnly) {
      this.setAccess = Access.Internal;
    }
    this.apply(objectInitializer);
    this.description = property.details.csharp.description;
    this.required = property.details.csharp.required;
    this.IsHeaderProperty = property.details.csharp[HeaderProperty] === HeaderPropertyType.HeaderAndBody || property.details.csharp[HeaderProperty] === HeaderPropertyType.Header;
  }

  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    if (this.required) {
      return (<EnhancedTypeDeclaration>this.type).validatePresence(eventListener, this);
    }
    return ``;
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return (<EnhancedTypeDeclaration>this.type).validateValue(eventListener, this);
  }
}
