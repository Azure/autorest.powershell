/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, } from '@microsoft.azure/codegen';
import { KnownMediaType } from "@microsoft.azure/autorest.codemodel-v3"

import { Expression, ExpressionOrLiteral, Interface, Namespace, OneOrMoreStatements, Variable, Access, InterfaceProperty } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ModelClass } from './model-class';
import { TypeContainer } from '@microsoft.azure/codegen-csharp/dist/type-container';

export class ModelInterface extends Interface implements EnhancedTypeDeclaration {
  get schema(): Schema {
    return this.classImplementation.schema;
  }

  get defaultOfType() {
    return this.classImplementation.defaultOfType;
  }

  get convertObjectMethod() {
    return this.classImplementation.convertObjectMethod;
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
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return this.classImplementation.serializeToContent(mediaType, value, mode);
  }

  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    return this.classImplementation.serializeToNode(mediaType, value, serializedName, mode);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.classImplementation.serializeToContainerMember(mediaType, value, container, serializedName, mode);
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
  constructor(parent: TypeContainer, interfaceName: string, public classImplementation: ModelClass, public state: State, objectInitializer?: Partial<ModelInterface>) {
    super(parent, interfaceName);
    this.partial = true;
    this.apply(objectInitializer);
  }

  get isInternal(): boolean {
    return this.accessModifier === Access.Internal;
  }

  init() {
    const implData = (this.schema.details.csharp = this.schema.details.csharp || {});
    //implData.interfaceImplementation = this;
    this.description = `${this.schema.details.csharp.description}`;

    const virtualProperties = this.schema.details.csharp.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: []
    };
    if (this.schema.details.csharp.virtualProperties) {

      for (const property of [...virtualProperties.owned]) {
        if (property.private && !this.isInternal) {
          continue;
        }

        const actual = property.property;

        const internalSet = !this.isInternal && (actual.schema.readOnly || actual.details.csharp.constantValue);


        const isRequired = actual.details.csharp.required;
        const pType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>actual.schema, isRequired, this.state.path('schema'))
        const p = this.add(new InterfaceProperty(property.name, pType, {
          description: "Owned Property",
          setAccess: internalSet ? Access.Internal : Access.Public
        }));
        if (!this.isInternal && actual.details.csharp.constantValue !== undefined) {
          p.setAccess = Access.Internal;
        }
      }

      for (const property of [...virtualProperties.inlined]) {
        const actual = property.property;
        const isRequired = actual.details.csharp.required;
        const pType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>actual.schema, isRequired, this.state.path('schema'))

        const internalSet = !this.isInternal && (actual.schema.readOnly || actual.details.csharp.constantValue);

        this.add(new InterfaceProperty(property.name, pType, {
          description: "Inlined Property",
          setAccess: internalSet ? Access.Internal : Access.Public
        }));
      }
    }

    if (!this.isInternal) {
      // mark it as json serializable
      if (!this.schema.details.csharp.isHeaderModel) {
        if (this.state.project.jsonSerialization) {
          this.interfaces.push(ClientRuntime.IJsonSerializable);
        }
        if (this.state.project.xmlSerialization) {
          this.interfaces.push(ClientRuntime.IXmlSerializable);
        }
      }
    }
    return this;
  }

}
