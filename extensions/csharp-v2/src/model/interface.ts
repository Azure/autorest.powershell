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
import { TypeContainer } from '@microsoft.azure/codegen-csharp/dist/type-container';

export class ModelInterface extends Interface implements EnhancedTypeDeclaration {
  get schema(): Schema {
    return this.classImplementation.schema;
  }
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    return this.classImplementation.deserializeFromContainerMember(mediaType, container, serializedName, defaultValue);
  }
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return this.classImplementation.deserializeFromNode(mediaType, node, defaultValue);
  }
  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.classImplementation.deserializeFromString(mediaType, content, defaultValue);
  }

  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.classImplementation.deserializeFromResponse(mediaType, content, defaultValue);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return this.classImplementation.serializeToContent(mediaType, value);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return this.classImplementation.serializeToNode(mediaType, value, serializedName);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return this.classImplementation.serializeToContainerMember(mediaType, value, container, serializedName);
  }

  get isXmlAttribute(): boolean {
    return this.classImplementation.isXmlAttribute;
  }

  get isRequired(): boolean {
    return this.classImplementation.isRequired;
  }

  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.classImplementation.validatePresence(eventListener, property);
  }
  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.classImplementation.validateValue(eventListener, property);
  }

  get hasHeaderProperties(): boolean {
    // disabled
    // return this.classImplementation.hasHeaderProperties; 
    return false;
  }
  constructor(parent: TypeContainer, schema: Schema, public classImplementation: ModelClass, public state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, `I${schema.details.csharp.name}`);
    this.partial = true;
    this.apply(objectInitializer);
    const implData = (schema.details.csharp = schema.details.csharp || {});
    implData.interfaceImplementation = this;
    this.description = `${schema.details.csharp.description}`;

    const virtualProperties = this.schema.details.csharp.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: []
    };
    if (this.schema.details.csharp.virtualProperties) {
      for (const property of [...virtualProperties.owned]) {
        const actual = property.property;
        this.add(new ModelInterfaceProperty(property.name, <Schema>actual.schema, actual.details.csharp.required, state.path('properties'), { description: "Owned Property" }));
      }

      for (const property of [...virtualProperties.inlined]) {
        const actual = property.property;
        this.add(new ModelInterfaceProperty(property.name, <Schema>actual.schema, actual.details.csharp.required, state.path('properties'), { description: "Inlined Property" }));
      }
    }
    // mark it as json serializable
    if (!schema.details.csharp.isHeaderModel) {
      if (this.state.project.jsonSerialization) {
        this.interfaces.push(ClientRuntime.IJsonSerializable);
      }
      if (this.state.project.xmlSerialization) {
        this.interfaces.push(ClientRuntime.IXmlSerializable);
      }
    }

  }
}
