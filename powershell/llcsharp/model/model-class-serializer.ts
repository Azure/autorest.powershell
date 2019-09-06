/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { KnownMediaType, HeaderProperty, HeaderPropertyType, getAllProperties, JsonType } from '@azure-tools/codemodel-v3';
import { Initializer, EOL } from '@azure-tools/codegen';
import { items, values } from '@azure-tools/linq';

import { Access, Modifier, StringExpression, Expression, System, TypeContainer, TypeDeclaration, LocalVariable, And } from '@azure-tools/codegen-csharp';
import { Class } from '@azure-tools/codegen-csharp';
import { Constructor } from '@azure-tools/codegen-csharp';
import { IsDeclaration, toExpression } from '@azure-tools/codegen-csharp';
import { Method, PartialMethod } from '@azure-tools/codegen-csharp';

import { Parameter } from '@azure-tools/codegen-csharp';
import { ParameterModifier } from '@azure-tools/codegen-csharp';
import { TerminalCase } from '@azure-tools/codegen-csharp';
import { If, Not, ForEach } from '@azure-tools/codegen-csharp';
import { Return } from '@azure-tools/codegen-csharp';
import { Statements } from '@azure-tools/codegen-csharp';
import { Switch } from '@azure-tools/codegen-csharp';
import { Ternery } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';

import { dotnet } from '@azure-tools/codegen-csharp';
import { ModelClass } from './model-class';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { popTempVar, pushTempVar } from '../schema/primitive';

import { ModelProperty } from './property';
import { ObjectImplementation } from '../schema/object';
import { Schema } from '../code-model';

export class SerializationPartialClass extends Initializer {
  constructor(protected targetClass: Class, protected targetInterface: TypeDeclaration, protected serializationType: TypeDeclaration, protected serializationFormat: string, protected schema: Schema, protected resolver: (s: Schema, req: boolean) => EnhancedTypeDeclaration, objectInitializer?: Partial<SerializationPartialClass>) {
    super();
    this.apply(objectInitializer);
  }

  protected get virtualProperties() {
    return this.schema.details.csharp.virtualProperties || {
      owned: [],
      inherited: [],
      inlined: []
    };
  }
  protected get allVirtualProperties() {
    const vp = this.virtualProperties;
    return [...vp.owned, ...vp.inherited, ...vp.inlined];
  }

  protected contentParameter = new Parameter('content', this.serializationType, { description: `The ${this.serializationType.declaration} content that should be used.` });
  protected refContainerParameter = new Parameter('container', this.serializationType, { modifier: ParameterModifier.Ref, description: `The ${this.serializationType.declaration} container that the serialization result will be placed in.` });
  protected returnNowParameter = new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the serialization should be processed, or if the method should return instantly.' });

  protected get typeCref() {
    return `<see cref="${this.serializationType.declaration}" />`;
  }

  protected get thisCref() {
    return `<see cref="${this.targetClass.declaration}" />`;
  }

  protected get interfaceCref() {
    return `<see cref="${this.targetInterface.declaration}" />`;
  }

}

export class DeserializerPartialClass extends SerializationPartialClass {
  private beforeDeserialize!: Method;
  private afterDeserialize!: Method;
  constructor(targetClass: Class, targetInterface: TypeDeclaration, protected serializationType: TypeDeclaration, protected serializationFormat: string, protected schema: Schema, resolver: (s: Schema, req: boolean) => EnhancedTypeDeclaration, objectInitializer?: Partial<DeserializerPartialClass>) {
    super(targetClass, targetInterface, serializationType, serializationFormat, schema, resolver);
    this.apply(objectInitializer);
  }

  async init() {
    // add partial methods for extensibility
    this.addPartialMethods();
    this.addDeserializerConstructor();
    this.addDeserializerMethod();
  }

  protected addDeserializerConstructor() {
    const $this = this;

    const deserializerConstructor = this.targetClass.addMethod(new Constructor(this.targetClass, {
      parameters: [this.contentParameter], access: Access.Internal,
      description: `Deserializes a ${this.typeCref} into a new instance of ${this.thisCref}.`
    }));

    deserializerConstructor.add(function* () {
      const returnNow = new LocalVariable('returnNow', dotnet.Bool, { initializer: dotnet.False });
      yield returnNow.declarationStatement;

      yield `${$this.beforeDeserialize.name}(${$this.contentParameter}, ref ${returnNow.value});`;
      yield If(returnNow, 'return;');

      yield $this.deserializeStatements;

      if ($this.hasAadditionalProperties($this.schema)) {
        // this type has an additional properties dictionary
        yield '// this type is a dictionary; copy elements from source to here.';
        yield `CopyFrom(${$this.contentParameter.value});`;
      }

      yield `${$this.afterDeserialize.name}(${$this.contentParameter});`;
    });
  }

  private hasAadditionalProperties(aSchema: Schema): boolean {
    if (aSchema.additionalProperties) {
      return true;
    } else
      for (const each of aSchema.allOf) {
        const r = this.hasAadditionalProperties(each);
        if (r) {
          return r;
        }
      }
    return false;
  }

  get deserializeStatements() {
    const $this = this;

    return function* () {
      yield '// actually deserialize ';

      for (const virtualProperty of $this.allVirtualProperties) {
        // yield `// deserialize ${virtualProperty.name} from ${$this.serializationFormat}`;
        const type = $this.resolver(<Schema>virtualProperty.property.schema, virtualProperty.property.details.default.required);

        const cvt = type.convertObjectMethod;
        const t = `((${virtualProperty.originalContainingSchema.details.csharp.fullInternalInterfaceName})this)`;
        const tt = type ? `(${type.declaration})` : '';

        yield `${t}.${virtualProperty.name} = ${tt} ${$this.contentParameter}.GetValueForProperty("${virtualProperty.name}",${t}.${virtualProperty.name}, ${cvt});`;
      }
    };
  }

  protected addDeserializerMethod() {
    const $this = this;

    const deserialzeMethod = this.targetClass.addMethod(new Method(`DeserializeFrom${this.serializationFormat}`, this.targetInterface, {
      parameters: [this.contentParameter], static: Modifier.Static,
      description: `Deserializes a ${this.typeCref} into an instance of ${this.thisCref}.`,
      returnsDescription: `an instance of ${this.interfaceCref}.`
    }));

    deserialzeMethod.add(function* () {
      yield Return($this.targetClass.new($this.contentParameter));
    });

  }

  protected addPartialMethods() {
    const before = `BeforeDeserialize${this.serializationFormat}`;
    const after = `AfterDeserialize${this.serializationFormat}`;
    this.beforeDeserialize = this.targetClass.addMethod(new PartialMethod(before, dotnet.Void, {
      access: Access.Default,
      parameters: [this.contentParameter, this.returnNowParameter],
      description: `<c>${before}</c> will be called before the deserialization has commenced, allowing complete customization of the object before it is deserialized.
      If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
      Implement this method in a partial class to enable this behavior.`
    }));

    this.afterDeserialize = this.targetClass.addMethod(new PartialMethod(after, dotnet.Void, {
      access: Access.Default,
      parameters: [this.contentParameter],
      description: `<c>${after}</c> will be called after the deserialization has finished, allowing customization of the object before it is returned. Implement this method in a partial class to enable this behavior `
    }));
  }
}

export class SerializerPartialClass extends SerializationPartialClass {
  private beforeSerialize!: Method;
  private afterSerialize!: Method;
  constructor(targetClass: Class, targetInterface: TypeDeclaration, protected serializationType: TypeDeclaration, protected serializationFormat: string, protected schema: Schema, resolver: (s: Schema, req: boolean) => EnhancedTypeDeclaration, objectInitializer?: Partial<SerializerPartialClass>) {
    super(targetClass, targetInterface, serializationType, serializationFormat, schema, resolver);
    this.apply(objectInitializer);
  }

  async init() {
    this.addPartialMethods();
    this.addSerializer();

  }

  protected addSerializer() {
    const serializeMethod = this.targetClass.addMethod(new Method(`SerializeTo${this.serializationFormat}`, this.serializationType, {
      parameters: [this.refContainerParameter],
      description: `Serializes this instance of ${this.thisCref} into a ${this.typeCref}.`,
      returnsDescription: `a serialized instance of ${this.thisCref} /> as a ${this.typeCref}.`
    }));

  }

  protected addPartialMethods() {
    const before = `BeforeSerialize${this.serializationFormat}`;
    const after = `AfterSerialize${this.serializationFormat}`;
    // add partial methods for future customization
    this.beforeSerialize = this.targetClass.addMethod(new PartialMethod(before, dotnet.Void, {
      access: Access.Default,
      parameters: [this.refContainerParameter, this.returnNowParameter],
      description: `<c>${before}</c> will be called before the serialization has commenced, allowing complete customization of the object before it is serialized.
      If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
      Implement this method in a partial class to enable this behavior.`
    }));

    this.afterSerialize = this.targetClass.addMethod(new PartialMethod(after, dotnet.Void, {
      access: Access.Default,
      parameters: [this.refContainerParameter],
      description: `<c>${after}</c> will be called after the serialization has finished, allowing customization of the ${this.typeCref} before it is returned. Implement this method in a partial class to enable this behavior `
    }));
  }
}
