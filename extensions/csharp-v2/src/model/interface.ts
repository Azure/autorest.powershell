/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, } from '@microsoft.azure/codegen';
import { KnownMediaType } from "@microsoft.azure/autorest.codemodel-v3"

import { Expression, ExpressionOrLiteral, Interface, Namespace, OneOrMoreStatements, Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ModelInterfaceProperty } from './interface-property';
import { ModelClass } from './model-class';

export class ModelInterface extends Interface implements EnhancedTypeDeclaration {
  get schema(): Schema {
    return this.implementation.schema;
  }
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    return this.implementation.deserializeFromContainerMember(mediaType, container, serializedName, defaultValue);
  }
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return this.implementation.deserializeFromNode(mediaType, node, defaultValue);
  }
  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.implementation.deserializeFromString(mediaType, content, defaultValue);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.implementation.deserializeFromResponse(mediaType, content, defaultValue);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return this.implementation.serializeToContent(mediaType, value);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return this.implementation.serializeToNode(mediaType, value, serializedName);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return this.implementation.serializeToContainerMember(mediaType, value, container, serializedName);
  }

  get isXmlAttribute(): boolean {
    return this.implementation.isXmlAttribute;
  }

  get isRequired(): boolean {
    return this.implementation.isRequired;
  }

  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(eventListener, property);
  }
  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(eventListener, property);
  }

  get hasHeaderProperties(): boolean {
    return this.implementation.hasHeaderProperties;
  }
  constructor(parent: Namespace, schema: Schema, public implementation: ModelClass, public state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.csharp.name}`);
    this.partial = true;
    this.apply(objectInitializer);
    const implData = (schema.details.csharp = schema.details.csharp || {});
    implData.interfaceImplementation = this;
    this.description = `${schema.details.default.description}`;

    for (const { key: propertyName, value: property } of items(schema.properties)) {
      this.add(new ModelInterfaceProperty(this, property, state.path('properties', propertyName)));
    }

    // mark it as json serializable
    if (!schema.details.default.isHeaderModel) {
      if (this.state.project.jsonSerialization) {
        this.interfaces.push(ClientRuntime.IJsonSerializable);
      }
      if (this.state.project.xmlSerialization) {
        this.interfaces.push(ClientRuntime.IXmlSerializable);
      }
    }

  }
}
