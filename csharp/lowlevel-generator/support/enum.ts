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
import { PropertyType } from '#csharp/lowlevel-generator/type-declaration';
import { Schema } from '#common/code-model/schema';
import { State } from '../generator';

export class EnumClass extends Struct implements PropertyType {
  constructor(schema: Schema, state: State, objectInitializer?: Partial<EnumClass>) {
    if (!schema.details.enum) {
      throw new Error("ENUM AINT XMSENUM");
    }

    super(state.project.supportNamespace, schema.details.enum.name, undefined, {
      interfaces: [new Interface(new Namespace("System"), "IEquatable", {
        genericParameters: [`${schema.details.enum.name}`]
      })],
    });
    this.apply(objectInitializer);

    // add known enum values
    for (const evalue of schema.details.enum.values) {
      const field = this.addField(new InitializedField(evalue.name, this, new StringExpression(evalue.value)));
      field.static = Modifier.Static;
      field.description = evalue.description;
    }

    // add backingField
    const backingField = this.addProperty(new Property('value', String, {
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

  public validateValue(propertyName: string): string {
    return ``;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): string {
    return `${containerName}.SafeAdd( "${serializedName}", ${this.serializeInstanceToJson(propertyName)});`.trim();
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return `${propertyName} = ${containerName}.StringProperty("${serializedName}");`
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return `${nodeExpression} is Carbon.Json.JsonString s ? s : null`;
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return `Carbon.Json.JsonString.Create(${instance})`;
  }
}