import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Constructor } from '#csharp/code-dom/constructor';
import { StringExpression } from '#csharp/code-dom/expression';
import { InitializedField } from '#csharp/code-dom/field';
import { Interface } from '#csharp/code-dom/interface';
import { Method } from '#csharp/code-dom/method';
import * as mscorlib from '#csharp/code-dom/mscorlib';
import { String } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Operator } from '#csharp/code-dom/operator';
import { Parameter } from '#csharp/code-dom/parameter';
import { Property } from '#csharp/code-dom/property';
import { OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Struct } from '#csharp/code-dom/struct';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';
import { Schema } from '#common/code-model/schema';
import { State } from '../generator';
import { ObjectFeatures } from '#csharp/schema/object';
import { EnumFeatures } from '#csharp/schema/enum';

export class EnumClass extends Struct implements Serialization, Validation {
  schemaWithFeatures: EnumFeatures;
  constructor(schemaWithFeatures: EnumFeatures, state: State, objectInitializer?: Partial<EnumClass>) {
    if (!schemaWithFeatures.schema.details.csharp.enum) {
      throw new Error("ENUM AINT XMSENUM");
    }

    super(state.project.supportNamespace, schemaWithFeatures.schema.details.csharp.enum.name, undefined, {
      interfaces: [new Interface(new Namespace("System"), "IEquatable", {
        genericParameters: [`${schemaWithFeatures.schema.details.csharp.enum.name}`]
      })],
    });
    this.schemaWithFeatures = schemaWithFeatures;

    this.apply(objectInitializer);

    // add known enum values
    for (const evalue of schemaWithFeatures.schema.details.csharp.enum.values) {
      const field = this.addField(new InitializedField(evalue.name, this, new StringExpression(evalue.value)));
      field.static = Modifier.Static;
      field.description = evalue.description;
    }

    // add backingField
    const backingField = this.add(new Property('value', String, {
      getAccess: Access.Private,
      setAccess: Access.Private
    }));

    // add private constructor
    const p = new Parameter('underlyingValue', String)
    const ctor = this.addMethod(new Constructor(this, {
      access: Access.Private,
      parameters: [p],
    })).add(`this.${backingField.value} = ${p.value};`);

    // add toString Method
    this.addMethod(new Method("ToString", mscorlib.String, {
      override: Modifier.Override,
      description: `Returns string representation for ${this.name}`
    })).add(`return this.${backingField.value};`)

    // add Equals Method(thistype)
    this.addMethod(new Method("Equals", mscorlib.Bool, {
      description: `Compares values of enum type ${this.name}`,
      parameters: [new Parameter("e", this)]
    })).add(`return ${backingField.value}.Equals(e.${backingField.value});`)

    // add Equals Method(object)
    this.addMethod(new Method("Equals", mscorlib.Bool, {
      override: Modifier.Override,
      description: `Compares values of enum type ${this.name} (override for Object)`,
      parameters: [new Parameter("obj", mscorlib.Object)]
    })).add(`return obj is ${this.name} && Equals((${this.name})obj);`)

    // add implicit operator(string)
    this.addMethod(new Operator(`implicit operator ${this.name}`, {
      static: Modifier.Static,
      description: `Implicit operator to convert string to ${this.name}`,
      parameters: [new Parameter('value', mscorlib.String)]
    })).add(`return new ${this.name}(value);`);

    // add implicit operator(thistype)
    this.addMethod(new Operator(`implicit operator string`, {
      static: Modifier.Static,
      description: `Implicit operator to convert ${this.name} to string`,
      parameters: [new Parameter('e', this)]
    })).add(`return e.${backingField.value};`);

    // add operator ==
    this.addMethod(new Method(`operator ==`, mscorlib.Bool, {
      static: Modifier.Static,
      description: `Overriding == operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return e2.Equals(e1);`);

    // add opeator !=
    this.addMethod(new Method(`operator !=`, mscorlib.Bool, {
      static: Modifier.Static,
      description: `Overriding != operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return !e2.Equals(e1);`);

    // add getHashCode
    this.addMethod(new Method(`GetHashCode`, mscorlib.Int, {
      override: Modifier.Override,
      description: `Returns hashCode for enum ${this.name}`,
    })).add(`return this.${backingField.value}.GetHashCode();`);
  }

  public validateValue(propertyName: string): OneOrMoreStatements {
    return this.schemaWithFeatures.validateValue(propertyName);
  }
  public validatePresence(propertyName: string): OneOrMoreStatements {
    return this.schemaWithFeatures.validatePresence(propertyName);
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.schemaWithFeatures.jsonSerializationImplementation(containerName, propertyName, serializedName);
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.schemaWithFeatures.jsonSerializationImplementation(containerName, propertyName, serializedName);
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return this.schemaWithFeatures.jsonDeserializationImplementationOnNode(nodeExpression);
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return this.schemaWithFeatures.serializeInstanceToJson(instance);
  }
}