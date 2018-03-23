import { Class } from "#csharp/code-dom/class";
import { Project } from "../project";
import { State } from "../generator";
import { Schema } from "#remodeler/code-model";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";
import { ConstantField } from "#csharp/code-dom/field";
import { StringExpression } from "#csharp/code-dom/expression";
import { Constructor } from "#csharp/code-dom/constructor";
import { Parameter } from "#csharp/code-dom/parameter";
import { String } from "#csharp/code-dom/mscorlib";
import { Property } from "#csharp/code-dom/property";
import { AccessModifier } from "#csharp/code-dom/access-modifier";
import { Method } from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Struct } from "#csharp/code-dom/struct";
import { Operator } from "#csharp/code-dom/operator";
import { TypeDeclaration } from "#csharp/lowlevel-generator/type-declaration";

export class EnumClass extends Struct implements TypeDeclaration {
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
      const field = this.addField(new ConstantField(evalue.name, this, new StringExpression(evalue.value)));
      field.isStatic = true;
      field.description = evalue.description;
    }

    // add backingField
    const backingField = this.addProperty(new Property('value', String));
    backingField.readVisibility = AccessModifier.Private;
    backingField.writeVisibility = AccessModifier.Private;

    // add private constructor 
    const p = new Parameter('underlyingValue', String)
    const ctor = this.addMethod(new Constructor(this, {
      accessModifier: AccessModifier.Private,
      parameters: [p],
    })).add(`this.${backingField.value} = ${p.value};`);

    // add toString Method
    this.addMethod(new Method("ToString", mscorlib.String, {
      isOverride: true,
      description: `Returns string representation for ${this.name}`
    })).add(`return this.${backingField.value};`)

    // add Equals Method(thistype)
    this.addMethod(new Method("Equals", mscorlib.Bool, {
      description: `Compares values of enum type ${this.name}`,
      parameters: [new Parameter("e", this)]
    })).add(`return ${backingField.value}.Equals(e.${backingField.value});`)

    // add Equals Method(object)
    this.addMethod(new Method("Equals", mscorlib.Bool, {
      isOverride: true,
      description: `Compares values of enum type ${this.name} (override for Object)`,
      parameters: [new Parameter("obj", mscorlib.Object)]
    })).add(`return obj is ${this.name} && Equals((${this.name})obj);`)

    // add implicit operator(string)
    this.addMethod(new Operator(`implicit operator ${this.name}`, {
      isStatic: true,
      description: `Implicit operator to convert string to ${this.name}`,
      parameters: [new Parameter('value', mscorlib.String)]
    })).add(`return new ${this.name}(value);`);

    // add implicit operator(thistype)
    this.addMethod(new Operator(`implicit operator string`, {
      isStatic: true,
      description: `Implicit operator to convert ${this.name} to string`,
      parameters: [new Parameter('e', this)]
    })).add(`return e.${backingField.value};`);

    // add operator ==
    this.addMethod(new Method(`operator ==`, mscorlib.Bool, {
      isStatic: true,
      description: `Overriding == operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return e2.Equals(e1);`);

    // add opeator != 
    this.addMethod(new Method(`operator !=`, mscorlib.Bool, {
      isStatic: true,
      description: `Overriding != operator for enum ${this.name}`,
      parameters: [new Parameter('e1', this), new Parameter('e2', this)]
    })).add(`return !e2.Equals(e1);`);

    // add getHashCode
    this.addMethod(new Method(`GetHashCode`, mscorlib.Int, {
      isOverride: true,
      description: `Returns hashCode for enum ${this.name}`,
    })).add(`return this.${backingField.value}.GetHashCode();`);
  }

  public validateValue(propertyName: string): string {
    return ``;
  }
  public validatePresence(propertyName: string): string {
    return ``;
  }
  jsonserialize(propertyName: string): string {
    return '/***/';
  }
  jsondeserialize(propertyName: string): string {
    return '/***/';
  }
}