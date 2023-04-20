/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { KnownMediaType, JsonType, getPolymorphicBases } from '@azure-tools/codemodel-v3';

import { Expression, ExpressionOrLiteral, Interface, Namespace, OneOrMoreStatements, Variable, Access, InterfaceProperty, Attribute, StringExpression, LiteralExpression, Property, TypeDeclaration } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { Schema } from '../code-model';
import { Schema as NewSchema, Language, ObjectSchema } from '@azure-tools/codemodel';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ModelClass } from './model-class';
import { TypeContainer } from '@azure-tools/codegen-csharp';
import { DeepPartial } from '@azure-tools/codegen';
import { values } from '@azure-tools/linq';
import { VirtualProperty as NewVirtualProperty, VirtualProperties as NewVirtualProperties, Mutability } from '../../utils/schema';
import { isEnumImplementation, addPSArgumentCompleterAttribute } from '../../cmdlets/class';
import { ArrayOf } from '../exports';


export function addInfoAttribute(targetProperty: Property, pType: TypeDeclaration, isRequired: boolean, isReadOnly: boolean, description: string, serializedName: string) {

  let pt = <any>pType;
  while (pt.elementType) {
    switch (pt.elementType.schema.type) {
      case JsonType.Object:
        if (pt.elementType.schema.details.csharp.interfaceImplementation) {
          pt = {
            declaration: pt.elementType.schema.details.csharp.interfaceImplementation.declaration,
            schema: pt.elementType.schema,
          };
        } else {
          // arg! it's not done yet. Hope it's not polymorphic itself. 
          pt = {
            declaration: `${pt.elementType.schema.details.csharp.namespace}.${pt.elementType.schema.details.csharp.interfaceName}`,
            schema: pt.elementType.schema,
          };
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
    ptypes.push(`typeof(${pt.schema.details.csharp.namespace}.${pt.schema.details.csharp.interfaceName}_Reference)`);
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

export function newAddInfoAttribute(targetProperty: Property, pType: TypeDeclaration, isRequired: boolean, isReadOnly: boolean, mutability: Mutability, description: string, serializedName: string) {

  let pt = <any>pType;
  while (pt.elementType) {
    switch (pt.elementType.schema.type) {
      case JsonType.Object:
        if (pt.elementType.schema.language.csharp.interfaceImplementation) {
          pt = {
            declaration: pt.elementType.schema.language.csharp.interfaceImplementation.declaration,
            schema: pt.elementType.schema,
          };
        } else {
          // arg! it's not done yet. Hope it's not polymorphic itself. 
          pt = {
            declaration: `${pt.elementType.schema.language.csharp.namespace}.${pt.elementType.schema.language.csharp.interfaceName}`,
            schema: pt.elementType.schema,
          };
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

  if (pt.schema && pt.schema.language.csharp.byReference) {
    ptypes.push(`typeof(${pt.schema.language.csharp.namespace}.${pt.schema.language.csharp.interfaceName}_Reference)`);
    // do we need polymorphic types for by-resource ? Don't think so.
  } else {
    ptypes.push(`typeof(${pt.declaration})`);
    if (pt.schema && pt.schema.language.csharp.classImplementation && pt.schema.language.csharp.classImplementation.discriminators) {
      ptypes.push(...[...pt.schema.language.csharp.classImplementation.discriminators.values()].map(each => `typeof(${each.modelInterface.fullName})`));
    }
  }

  targetProperty.add(new Attribute(ClientRuntime.InfoAttribute, {
    parameters: [
      new LiteralExpression(`\nRequired = ${isRequired}`),
      new LiteralExpression(`\nReadOnly = ${isReadOnly}`),
      new LiteralExpression(`\nRead = ${mutability.read}`),
      new LiteralExpression(`\nCreate = ${mutability.create}`),
      new LiteralExpression(`\nUpdate = ${mutability.update}`),
      new LiteralExpression(`\nDescription = ${new StringExpression(description ?? '').value}`),
      new LiteralExpression(`\nSerializedName = ${new StringExpression(serializedName).value}`),
      new LiteralExpression(`\nPossibleTypes = new [] { ${ptypes.join(',').replace(/\?/g, '').replace(/undefined\./g, '')} }`),
    ]
  }));
}


export class ModelInterface extends Interface implements EnhancedTypeDeclaration {
  get schema(): NewSchema {
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

  public isNullable = true;

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
  constructor(parent: TypeContainer, interfaceName: string, public classImplementation: ModelClass, public state: State, objectInitializer?: DeepPartial<ModelInterface>) {
    super(parent, interfaceName);
    this.partial = true;
    this.apply(objectInitializer);
  }

  get isInternal(): boolean {
    return this.accessModifier === Access.Internal;
  }

  init() {
    (<any>this).init = () => { }; // only allow a single init!
    this.schema.language.csharp = this.schema.language.csharp || new Language();
    const implData = (this.schema.language.csharp = this.schema.language.csharp || {});
    //implData.interfaceImplementation = this;
    this.description = `${this.schema.language.csharp.description}`;

    const virtualProperties: NewVirtualProperties = this.schema.language.csharp.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: []
    };
    if (this.schema.language.csharp.virtualProperties) {

      for (const virtualProperty of values(virtualProperties.owned)) {
        if (virtualProperty.private && !this.isInternal) {
          continue;
        }

        const modelProperty = virtualProperty.property;

        const internalSet = !!(!this.isInternal && (modelProperty.readOnly || !!virtualProperty.readOnly || (<any>modelProperty.language.csharp).constantValue));

        const isRequired = !!modelProperty.required;
        const mutability = { read: !!virtualProperty.read, update: !!virtualProperty.update, create: !!virtualProperty.create };
        const pType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>modelProperty.schema, isRequired, this.state.path('schema'));
        const p = this.add(new InterfaceProperty(virtualProperty.name, pType, {
          description: modelProperty.language.default.description,
          setAccess: internalSet ? Access.Internal : Access.Public
        }));

        this.addInfoAttribute(p, pType, isRequired, internalSet, mutability, modelProperty.language.default.description, modelProperty.serializedName);

        if (isEnumImplementation(modelProperty.schema)) {
          addPSArgumentCompleterAttribute(p, modelProperty.schema);
        } else if (pType instanceof ArrayOf && isEnumImplementation((<any>modelProperty.schema).elementType)) {
          addPSArgumentCompleterAttribute(p, (<any>modelProperty.schema).elementType);
        }

        if (!this.isInternal && (<any>modelProperty.language.csharp).constantValue !== undefined) {
          p.setAccess = Access.Internal;
        }
      }

      for (const virtualProperty of values(virtualProperties.inlined)) {

        // don't publicly expose the 'private' properties.
        if (virtualProperty.private && !this.isInternal) {
          continue;
        }

        const modelProperty = virtualProperty.property;
        const isRequired = !!virtualProperty.required;
        const mutability = { read: !!virtualProperty.read, update: !!virtualProperty.update, create: !!virtualProperty.create };

        const pType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>modelProperty.schema, isRequired, this.state.path('schema'));

        const internalSet = !!(!this.isInternal && (modelProperty.readOnly || !!virtualProperty.readOnly || (<any>modelProperty.language.csharp).constantValue));

        const p = this.add(new InterfaceProperty(virtualProperty.name, pType, {
          description: modelProperty.language.default.description,
          setAccess: internalSet ? Access.Internal : Access.Public
        }));
        this.addInfoAttribute(p, pType, isRequired, internalSet, mutability, modelProperty.language.default.description, modelProperty.serializedName);

        if (isEnumImplementation(modelProperty.schema)) {
          addPSArgumentCompleterAttribute(p, modelProperty.schema);
        } else if (pType instanceof ArrayOf && isEnumImplementation((<any>modelProperty.schema).elementType)) {
          addPSArgumentCompleterAttribute(p, (<any>modelProperty.schema).elementType);
        }
      }
    }

    if (!this.isInternal) {
      // mark it as json serializable
      if (!this.schema.language.csharp.isHeaderModel) {
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

  addInfoAttribute(p: Property, pType: TypeDeclaration, isRequired: boolean, internalSet: boolean, mutability: Mutability, description: string, serializedName: string) {
    if (!this.isInternal) {
      return newAddInfoAttribute(p, pType, isRequired, internalSet, mutability, description, serializedName);
    }
  }
}
