import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Constructor } from '#csharp/code-dom/constructor';
import { StringExpression, ExpressionOrLiteral, Expression } from '#csharp/code-dom/expression';
import { InitializedField } from '#csharp/code-dom/field';
import { Interface } from '#csharp/code-dom/interface';
import { Method } from '#csharp/code-dom/method';

import { Namespace } from '#csharp/code-dom/namespace';
import { Operator } from '#csharp/code-dom/operator';
import { Parameter } from '#csharp/code-dom/parameter';
import { Property } from '#csharp/code-dom/property';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Struct } from '#csharp/code-dom/struct';
import { EnumImplementation } from '#csharp/schema/enum';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';
import { State } from '../generator';
import { KnownMediaType } from '#common/media-types';
import { Variable } from '#csharp/code-dom/variable';
import { dotnet } from '#csharp/code-dom/dotnet';

export class EnumClass extends Struct implements EnhancedTypeDeclaration {
  implementation: EnumImplementation;
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
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return this.implementation.serializeToNode(mediaType, value, serializedName);
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return this.implementation.serializeToContent(mediaType, value);
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

  constructor(schemaWithFeatures: EnumImplementation, state: State, objectInitializer?: Partial<EnumClass>) {
    if (!schemaWithFeatures.schema.details.csharp.enum) {
      throw new Error(`ENUM AINT XMSENUM: ${schemaWithFeatures.schema.details.default.name}`);
    }

    super(state.project.supportNamespace, schemaWithFeatures.schema.details.csharp.enum.name, undefined, {
      interfaces: [new Interface(new Namespace('System'), 'IEquatable', {
        genericParameters: [`${schemaWithFeatures.schema.details.csharp.enum.name}`]
      })],
    });
    this.implementation = schemaWithFeatures;

    this.apply(objectInitializer);

    // add known enum values
    for (const evalue of schemaWithFeatures.schema.details.csharp.enum.values) {
      const field = this.addField(new InitializedField(evalue.name, this, new StringExpression(evalue.value)));
      field.static = Modifier.Static;
      field.description = evalue.description;
    }

    // add backingField
    const backingField = this.add(new Property('_value', dotnet.String, {
      getAccess: Access.Private,
      setAccess: Access.Private
    }));

    // add private constructor
    const p = new Parameter('underlyingValue', dotnet.String);
    const ctor = this.addMethod(new Constructor(this, {
      access: Access.Private,
      parameters: [p],
    })).add(`this.${backingField.value} = ${p.value};`);

    // add toString Method
    this.addMethod(new Method('ToString', dotnet.String, {
      override: Modifier.Override,
      description: `Returns string representation for ${this.name}`
    })).add(`return this.${backingField.value};`);

    // add Equals Method(thistype)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      description: `Compares values of enum type ${this.name}`,
      parameters: [new Parameter('e', this)]
    })).add(`return ${backingField.value}.Equals(e.${backingField.value});`);

    // add Equals Method(object)
    this.addMethod(new Method('Equals', dotnet.Bool, {
      override: Modifier.Override,
      description: `Compares values of enum type ${this.name} (override for Object)`,
      parameters: [new Parameter('obj', dotnet.Object)]
    })).add(`return obj is ${this.name} && Equals((${this.name})obj);`);

    // add implicit operator(string)
    this.addMethod(new Operator(`implicit operator ${this.name}`, {
      static: Modifier.Static,
      description: `Implicit operator to convert string to ${this.name}`,
      parameters: [new Parameter('value', dotnet.String)]
    })).add(`return new ${this.name}(value);`);

    // add implicit operator(thistype)
    this.addMethod(new Operator(`implicit operator string`, {
      static: Modifier.Static,
      description: `Implicit operator to convert ${this.name} to string`,
      parameters: [new Parameter('e', this)]
    })).add(`return e.${backingField.value};`);

    // add operator ==
    this.addMethod(new Method(`operator ==`, dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding == operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return e2.Equals(e1);`);

    // add opeator !=
    this.addMethod(new Method(`operator !=`, dotnet.Bool, {
      static: Modifier.Static,
      description: `Overriding != operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return !e2.Equals(e1);`);

    // add getHashCode
    this.addMethod(new Method(`GetHashCode`, dotnet.Int, {
      override: Modifier.Override,
      description: `Returns hashCode for enum ${this.name}`,
    })).add(`return this.${backingField.value}.GetHashCode();`);
  }

  public validateValue(property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(property);
  }
  public validatePresence(property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(property);
  }
}
