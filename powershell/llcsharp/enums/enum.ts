/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Access, Modifier, toExpression } from '@azure-tools/codegen-csharp';
import { Constructor } from '@azure-tools/codegen-csharp';
import { Expression, ExpressionOrLiteral, StringExpression } from '@azure-tools/codegen-csharp';
import { Field } from '@azure-tools/codegen-csharp';
import { Interface } from '@azure-tools/codegen-csharp';
import { Method } from '@azure-tools/codegen-csharp';
import { Schema } from '../code-model';

import { KnownMediaType } from '@azure-tools/codemodel-v3';
import { dotnet } from '@azure-tools/codegen-csharp';
import { Namespace } from '@azure-tools/codegen-csharp';
import { Operator } from '@azure-tools/codegen-csharp';
import { Parameter } from '@azure-tools/codegen-csharp';
import { Property } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements } from '@azure-tools/codegen-csharp';
import { Struct } from '@azure-tools/codegen-csharp';
import { Variable } from '@azure-tools/codegen-csharp';
import { EnumImplementation, NewEnumImplementation } from '../schema/enum';
import { EnhancedTypeDeclaration, NewEnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { State, NewState } from '../generator';
import { DeepPartial } from '@azure-tools/codegen';

import { Schema as NewSchema } from '@azure-tools/codemodel';

export class EnumClass extends Struct implements EnhancedTypeDeclaration {
  implementation: EnumImplementation;
  get schema(): Schema {
    return this.implementation.schema;
  }
  get convertObjectMethod() {
    return this.implementation.convertObjectMethod;
  }

  get defaultOfType() {
    return toExpression('null /* enum value */');
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
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    return this.implementation.serializeToNode(mediaType, value, serializedName, mode);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return this.implementation.serializeToContent(mediaType, value, mode);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.implementation.serializeToContainerMember(mediaType, value, container, serializedName, mode);
  }

  get isXmlAttribute(): boolean {
    return this.implementation.isXmlAttribute;
  }

  get isNullable(): boolean {
    return this.implementation.isNullable;
  }

  get isRequired(): boolean {
    return this.implementation.isRequired;
  }

  constructor(schemaWithFeatures: EnumImplementation, state: State, objectInitializer?: DeepPartial<EnumClass>) {
    if (!schemaWithFeatures.schema.details.csharp.enum) {
      throw new Error(`ENUM AINT XMSENUM: ${schemaWithFeatures.schema.details.csharp.name}`);
    }

    super(state.project.supportNamespace, schemaWithFeatures.schema.details.csharp.enum.name, undefined, {
      interfaces: [new Interface(new Namespace('System'), 'IEquatable', {
        genericParameters: [`${schemaWithFeatures.schema.details.csharp.enum.name}`]
      })],
    });
    this.description = schemaWithFeatures.schema.details.csharp.description;
    this.implementation = schemaWithFeatures;
    this.partial = true;

    this.apply(objectInitializer);

    // add known enum values
    for (const evalue of schemaWithFeatures.schema.details.csharp.enum.values) {
      this.addField(new Field(evalue.name, this, { initialValue: new StringExpression(evalue.value), static: Modifier.Static, description: evalue.description }));
    }

    // add backingField
    const backingField = this.add(new Property('_value', dotnet.String, {
      getAccess: Access.Private,
      setAccess: Access.Private,
      description: `the value for an instance of the <see cref="${this.name}" /> Enum.`
    }));

    // add private constructor
    const p = new Parameter('underlyingValue', dotnet.String, { description: 'the value to create an instance for.' });
    const ctor = this.addMethod(new Constructor(this, {
      access: Access.Private,
      parameters: [p],
      description: `Creates an instance of the <see cref="${this.name}" Enum class./>`
    })).add(`this.${backingField.value} = ${p.value};`);

    // add toString Method
    this.addMethod(new Method('ToString', dotnet.String, {
      override: Modifier.Override,
      description: `Returns string representation for ${this.name}`,
      returnsDescription: 'A string for this value.'
    })).add(`return this.${backingField.value};`);

    // add Equals Method(thistype)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      description: `Compares values of enum type ${this.name}`,
      parameters: [new Parameter('e', this, { description: 'the value to compare against this instance.' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add(`return ${backingField.value}.Equals(e.${backingField.value});`);

    // add Equals Method(object)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      override: Modifier.Override,
      description: `Compares values of enum type ${this.name} (override for Object)`,
      parameters: [new Parameter('obj', dotnet.Object, { description: 'the value to compare against this instance.' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add(`return obj is ${this.name} && Equals((${this.name})obj);`);

    // add implicit operator(string)
    this.addMethod(new Operator(`implicit operator ${this.name}`, {
      static: Modifier.Static,
      description: `Implicit operator to convert string to ${this.name}`,
      parameters: [new Parameter('value', dotnet.String, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return new ${this.name}(value);`);

    // add static creation 
    this.addMethod(new Method('CreateFrom', dotnet.Object, {
      static: Modifier.Static,
      access: Access.Internal,
      description: `Conversion from arbitrary object to ${this.name}`,
      parameters: [new Parameter('value', dotnet.Object, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return new ${this.name}(System.Convert.ToString(value));`);

    // add implicit operator(thistype)
    this.addMethod(new Operator('implicit operator string', {
      static: Modifier.Static,
      description: `Implicit operator to convert ${this.name} to string`,
      parameters: [new Parameter('e', this, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return e.${backingField.value};`);

    // add operator ==
    this.addMethod(new Method('operator ==', dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding == operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this, { description: 'the value to compare against <see cref="e2" />' }), new Parameter('e2', this, { description: 'the value to compare against <see cref="e1" />' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add('return e2.Equals(e1);');

    // add opeator !=
    this.addMethod(new Method('operator !=', dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding != operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this, { description: 'the value to compare against <see cref="e2" />' }), new Parameter('e2', this, { description: 'the value to compare against <see cref="e1" />' })],
      returnsDescription: '<c>true</c> if the two instances are not equal to the same value'
    })).add('return !e2.Equals(e1);');

    // add getHashCode
    this.addMethod(new Method('GetHashCode', dotnet.Int, {
      override: Modifier.Override,
      description: `Returns hashCode for enum ${this.name}`,
      returnsDescription: 'The hashCode of the value'
    })).add(`return this.${backingField.value}.GetHashCode();`);
  }

  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(eventListener, property);
  }
  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(eventListener, property);
  }
}

export class NewEnumClass extends Struct implements NewEnhancedTypeDeclaration {
  implementation: NewEnumImplementation;
  get schema(): NewSchema {
    return this.implementation.schema;
  }
  get convertObjectMethod() {
    return this.implementation.convertObjectMethod;
  }

  get defaultOfType() {
    return toExpression('null /* enum value */');
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
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    return this.implementation.serializeToNode(mediaType, value, serializedName, mode);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return this.implementation.serializeToContent(mediaType, value, mode);
  }

  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.implementation.serializeToContainerMember(mediaType, value, container, serializedName, mode);
  }

  get isXmlAttribute(): boolean {
    return this.implementation.isXmlAttribute;
  }

  get isNullable(): boolean {
    return this.implementation.isNullable;
  }

  get isRequired(): boolean {
    return this.implementation.isRequired;
  }

  constructor(schemaWithFeatures: NewEnumImplementation, state: NewState, objectInitializer?: DeepPartial<NewEnumClass>) {
    if (!schemaWithFeatures.schema.language.csharp?.enum) {
      throw new Error(`ENUM AINT XMSENUM: ${schemaWithFeatures.schema.language.csharp?.name}`);
    }

    super(state.project.supportNamespace, schemaWithFeatures.schema.language.csharp?.enum.name, undefined, {
      interfaces: [new Interface(new Namespace('System'), 'IEquatable', {
        genericParameters: [`${schemaWithFeatures.schema.language.csharp?.enum.name}`]
      })],
    });
    this.description = schemaWithFeatures.schema.language.csharp?.description;
    this.implementation = schemaWithFeatures;
    this.partial = true;

    this.apply(objectInitializer);

    // add known enum values
    for (const evalue of schemaWithFeatures.schema.language.csharp?.enum.values) {
      this.addField(new Field(evalue.name, this, { initialValue: new StringExpression(evalue.value), static: Modifier.Static, description: evalue.description }));
    }

    // add backingField
    const backingField = this.add(new Property('_value', dotnet.String, {
      getAccess: Access.Private,
      setAccess: Access.Private,
      description: `the value for an instance of the <see cref="${this.name}" /> Enum.`
    }));

    // add private constructor
    const p = new Parameter('underlyingValue', dotnet.String, { description: 'the value to create an instance for.' });
    const ctor = this.addMethod(new Constructor(this, {
      access: Access.Private,
      parameters: [p],
      description: `Creates an instance of the <see cref="${this.name}" Enum class./>`
    })).add(`this.${backingField.value} = ${p.value};`);

    // add toString Method
    this.addMethod(new Method('ToString', dotnet.String, {
      override: Modifier.Override,
      description: `Returns string representation for ${this.name}`,
      returnsDescription: 'A string for this value.'
    })).add(`return this.${backingField.value};`);

    // add Equals Method(thistype)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      description: `Compares values of enum type ${this.name}`,
      parameters: [new Parameter('e', this, { description: 'the value to compare against this instance.' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add(`return ${backingField.value}.Equals(e.${backingField.value});`);

    // add Equals Method(object)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      override: Modifier.Override,
      description: `Compares values of enum type ${this.name} (override for Object)`,
      parameters: [new Parameter('obj', dotnet.Object, { description: 'the value to compare against this instance.' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add(`return obj is ${this.name} && Equals((${this.name})obj);`);

    // add implicit operator(string)
    this.addMethod(new Operator(`implicit operator ${this.name}`, {
      static: Modifier.Static,
      description: `Implicit operator to convert string to ${this.name}`,
      parameters: [new Parameter('value', dotnet.String, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return new ${this.name}(value);`);

    // add static creation 
    this.addMethod(new Method('CreateFrom', dotnet.Object, {
      static: Modifier.Static,
      access: Access.Internal,
      description: `Conversion from arbitrary object to ${this.name}`,
      parameters: [new Parameter('value', dotnet.Object, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return new ${this.name}(System.Convert.ToString(value));`);

    // add implicit operator(thistype)
    this.addMethod(new Operator('implicit operator string', {
      static: Modifier.Static,
      description: `Implicit operator to convert ${this.name} to string`,
      parameters: [new Parameter('e', this, { description: `the value to convert to an instance of <see cref="${this.name}" />.` })]
    })).add(`return e.${backingField.value};`);

    // add operator ==
    this.addMethod(new Method('operator ==', dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding == operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this, { description: 'the value to compare against <see cref="e2" />' }), new Parameter('e2', this, { description: 'the value to compare against <see cref="e1" />' })],
      returnsDescription: '<c>true</c> if the two instances are equal to the same value'
    })).add('return e2.Equals(e1);');

    // add opeator !=
    this.addMethod(new Method('operator !=', dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding != operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this, { description: 'the value to compare against <see cref="e2" />' }), new Parameter('e2', this, { description: 'the value to compare against <see cref="e1" />' })],
      returnsDescription: '<c>true</c> if the two instances are not equal to the same value'
    })).add('return !e2.Equals(e1);');

    // add getHashCode
    this.addMethod(new Method('GetHashCode', dotnet.Int, {
      override: Modifier.Override,
      description: `Returns hashCode for enum ${this.name}`,
      returnsDescription: 'The hashCode of the value'
    })).add(`return this.${backingField.value}.GetHashCode();`);
  }

  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(eventListener, property);
  }
  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(eventListener, property);
  }
}