/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType, HeaderProperty, HeaderPropertyType } from '@microsoft.azure/autorest.codemodel-v3';
import { Access } from '@microsoft.azure/codegen-csharp';
import { Expression, ExpressionOrLiteral } from '@microsoft.azure/codegen-csharp';
import { BackedProperty } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements } from '@microsoft.azure/codegen-csharp';
import { Variable } from '@microsoft.azure/codegen-csharp';
import { Property, Schema } from '../code-model';
import { EnhancedVariable } from '../extended-variable';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';


import { State } from '../generator';
import { ModelClass } from './model-class';

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
  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    if (this.required) {
      return (<EnhancedTypeDeclaration>this.type).validatePresence(eventListener, this);
    }
    return ``;
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return (<EnhancedTypeDeclaration>this.type).validateValue(eventListener, this);
  }

  private required: boolean;
  // DISABLED
  // public IsHeaderProperty: boolean;
  public schema: Schema;
  public serializedName: string;
  private typeDeclaration: EnhancedTypeDeclaration;

  // constructor(property: Property, serializedName: string, state: State, objectInitializer?: Partial<ModelProperty>) {
  constructor(name: string, schema: Schema, isRequired: boolean, serializedName: string, description: string, state: State, objectInitializer?: Partial<ModelProperty>) {
    const decl = state.project.modelsNamespace.resolveTypeDeclaration(schema, isRequired, state.path("schema"));
    super(name, decl);
    this.typeDeclaration = decl;
    this.serializedName = serializedName;
    this.schema = schema;
    if (this.schema.readOnly) {
      this.setAccess = Access.Internal;
    }
    this.apply(objectInitializer);
    this.description = description;
    this.required = isRequired;
    // DISABLED
    // this.IsHeaderProperty = property.details.csharp[HeaderProperty] === HeaderPropertyType.HeaderAndBody || property.details.csharp[HeaderProperty] === HeaderPropertyType.Header;
  }


}
