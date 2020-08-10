/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType, HeaderProperty, HeaderPropertyType, JsonType } from '@azure-tools/codemodel-v3';
import { Access, isAnExpression, toExpression } from '@azure-tools/codegen-csharp';
import { Expression, ExpressionOrLiteral } from '@azure-tools/codegen-csharp';
import { BackedProperty } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { Variable } from '@azure-tools/codegen-csharp';
import { Property, Schema } from '../code-model';
import { EnhancedVariable } from '../extended-variable';
import { EnhancedTypeDeclaration, NewEnhancedTypeDeclaration } from '../schema/extended-type-declaration';


import { State, NewState } from '../generator';
import { ModelClass } from './model-class';
import { DeepPartial } from '@azure-tools/codegen';
import { Schema as NewSchema, SchemaType } from '@azure-tools/codemodel';

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
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName, mode);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this, mode);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, container, this, serializedName, mode);
  }
  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    if (this.required) {
      return (<EnhancedTypeDeclaration>this.type).validatePresence(eventListener, this);
    }
    return '';
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
  public details: any;

  constructor(name: string, schema: Schema, isRequired: boolean, serializedName: string, description: string, state: State, objectInitializer?: DeepPartial<ModelProperty>) {
    const decl = state.project.modelsNamespace.resolveTypeDeclaration(schema, isRequired, state.path('schema'));
    super(name, decl);
    this.typeDeclaration = decl;
    this.serializedName = serializedName;
    this.schema = schema;
    if (this.schema.readOnly) {
      this.set = undefined;
    }
    this.apply(objectInitializer);
    this.description = description;
    this.required = isRequired;
    if (this.schema.type === JsonType.Object && isAnExpression(this.get) && schema.details.csharp.classImplementation) {
      // for objects, the getter should auto-create a new object 
      this.get = toExpression(`(${this.get.value} = ${this.get.value} ?? new ${schema.details.csharp.fullname}())`);
    }
  }


}

export class NewModelProperty extends BackedProperty implements EnhancedVariable {
  /** emits an expression to deserialize a property from a member inside a container */
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string): Expression {
    return this.typeDeclaration.deserializeFromContainerMember(mediaType, container, serializedName, this);
  }

  /** emits an expression to deserialze a container as the value itself. */
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral): Expression {
    return this.typeDeclaration.deserializeFromNode(mediaType, node, this);
  }

  /** emits an expression serialize this to the value required by the container */
  serializeToNode(mediaType: KnownMediaType, serializedName: string, mode: Expression): Expression {
    return this.typeDeclaration.serializeToNode(mediaType, this, serializedName, mode);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, mode: Expression): Expression {
    return this.typeDeclaration.serializeToContent(mediaType, this, mode);
  }

  /** emits the code required to serialize this into a container */
  serializeToContainerMember(mediaType: KnownMediaType, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.typeDeclaration.serializeToContainerMember(mediaType, container, this, serializedName, mode);
  }
  public validatePresenceStatement(eventListener: Variable): OneOrMoreStatements {
    if (this.required) {
      return (<EnhancedTypeDeclaration>this.type).validatePresence(eventListener, this);
    }
    return '';
  }
  public validationStatement(eventListener: Variable): OneOrMoreStatements {
    return (<EnhancedTypeDeclaration>this.type).validateValue(eventListener, this);
  }

  private required: boolean;
  // DISABLED
  // public IsHeaderProperty: boolean;
  public schema: NewSchema;
  public serializedName: string;
  private typeDeclaration: NewEnhancedTypeDeclaration;
  public language: any;

  constructor(name: string, schema: NewSchema, isRequired: boolean, serializedName: string, description: string, state: NewState, objectInitializer?: DeepPartial<ModelProperty>) {
    const decl = state.project.modelsNamespace.NewResolveTypeDeclaration(schema, isRequired, state.path('schema'));
    super(name, decl);
    this.typeDeclaration = decl;
    this.serializedName = serializedName;
    this.schema = schema;
    // skip-for-time-being
    // if (this.schema.readOnly) {
    //   this.set = undefined;
    // }
    this.apply(objectInitializer);
    this.description = description;
    this.required = isRequired;
    if ((this.schema.type === SchemaType.Object || this.schema.type === SchemaType.Dictionary || this.schema.type === SchemaType.Any) && isAnExpression(this.get) && schema.language.csharp?.classImplementation) {
      // for objects, the getter should auto-create a new object 
      this.get = toExpression(`(${this.get.value} = ${this.get.value} ?? new ${schema.language.csharp?.fullname}())`);
    }
  }


}