/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { items, } from '@microsoft.azure/codegen';
import { KnownMediaType, JsonType, getPolymorphicBases } from "@microsoft.azure/autorest.codemodel-v3"

import { Expression, ExpressionOrLiteral, Interface, Namespace, OneOrMoreStatements, Variable, Access, InterfaceProperty, Attribute, StringExpression, LiteralExpression, Property, TypeDeclaration } from '@microsoft.azure/codegen-csharp';
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

  public isNullable: boolean = true;

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
    (<any>this).init = () => { }; // only allow a single init!

    const implData = (this.schema.details.csharp = this.schema.details.csharp || {});
    //implData.interfaceImplementation = this;
    this.description = `${this.schema.details.csharp.description}`;

    const virtualProperties = this.schema.details.csharp.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: []
    };
    if (this.schema.details.csharp.virtualProperties) {

      for (const virtualProperty of [...virtualProperties.owned]) {
        if (virtualProperty.private && !this.isInternal) {
          continue;
        }

        const modelProperty = virtualProperty.property;

        const internalSet = !!(!this.isInternal && (modelProperty.details.csharp.readOnly || modelProperty.details.csharp.constantValue));

        const isRequired = !!modelProperty.details.csharp.required;
        const pType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>modelProperty.schema, isRequired, this.state.path('schema'))
        const p = this.add(new InterfaceProperty(virtualProperty.name, pType, {
          description: modelProperty.details.csharp.description,
          setAccess: internalSet ? Access.Internal : Access.Public
        }));

        this.addInfoAttribute(p, pType, isRequired, internalSet, modelProperty.details.csharp.description, modelProperty.serializedName);

        if (!this.isInternal && modelProperty.details.csharp.constantValue !== undefined) {
          p.setAccess = Access.Internal;
        }
      }

      for (const virtualProperty of [...virtualProperties.inlined]) {

        // don't publicly expose the 'private' properties.
        if (virtualProperty.private && !this.isInternal) {
          continue;
        }

        const modelProperty = virtualProperty.property;
        const isRequired = !!modelProperty.details.csharp.required;
        const pType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>modelProperty.schema, isRequired, this.state.path('schema'))

        const internalSet = !!(!this.isInternal && (modelProperty.details.csharp.readOnly || modelProperty.details.csharp.constantValue));

        const p = this.add(new InterfaceProperty(virtualProperty.name, pType, {
          description: modelProperty.details.csharp.description,
          setAccess: internalSet ? Access.Internal : Access.Public
        }));
        this.addInfoAttribute(p, pType, isRequired, internalSet, modelProperty.details.csharp.description, modelProperty.serializedName);

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

  addInfoAttribute(p: Property, pType: TypeDeclaration, isRequired: boolean, internalSet: boolean, description: string, serializedName: string) {
    if (!this.isInternal) {
      return addInfoAttribute(p, pType, isRequired, internalSet, description, serializedName);
    }
  }
}

export function addInfoAttribute(targetProperty: Property, pType: TypeDeclaration, isRequired: boolean, isReadOnly: boolean, description: string, serializedName: string) {

  let pt = <any>pType;
  while (pt.elementType) {
    switch (pt.elementType.schema.type) {
      case JsonType.Object:
        if (pt.elementType.schema.details.csharp.interfaceImplementation) {
          pt = pt.elementType.schema.details.csharp.interfaceImplementation;
        } else {
          // arg! it's not done yet. Hope it's not polymorphic itself. 
          pt = { declaration: `${pt.elementType.schema.details.csharp.namespace}.${pt.elementType.schema.details.csharp.interfaceName}` }
        }
        break;

      case JsonType.Array:
        pt = pt.elementType;
        break;

      default:
        pt = pt.elementType;
        break;
    }
  }
  const ptypes = new Array<string>();

  if (pt.schema && pt.schema.details.csharp.byReference) {
    ptypes.push(`typeof(${pt.schema.details.csharp.namespace}.${pt.schema.details.csharp.interfaceName}_Reference)`)
    // do we need polymorphic types for by-resource ? Don't think so.
  } else {
    ptypes.push(`typeof(${pt.declaration})`);
    if (pt.schema && pt.schema.details.csharp.classImplementation && pt.schema.details.csharp.classImplementation.discriminators) {
      ptypes.push(...[...pt.schema.details.csharp.classImplementation.discriminators.values()].map(each => `typeof(${each.modelInterface.fullName})`));
    }
  }


  targetProperty.add(new Attribute(ClientRuntime.InfoAttribute, {
    parameters: [
      new LiteralExpression(`\nRequired = ${isRequired}`),
      new LiteralExpression(`\nReadOnly = ${isReadOnly}`),
      new LiteralExpression(`\nDescription = ${new StringExpression(description).value}`),
      new LiteralExpression(`\nSerializedName = ${new StringExpression(serializedName).value}`),
      new LiteralExpression(`\nPossibleTypes = new [] { ${ptypes.join(',').replace(/\?/g, '').replace(/undefined\./g, '')} }`),
    ]
  }));
}

