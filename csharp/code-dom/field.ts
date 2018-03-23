import { TypeDeclaration } from "./type-declaration";
import { Expression } from "#csharp/code-dom/expression";
import { AccessModifier } from "#csharp/code-dom/access-modifier";
import { Initializer } from "#csharp/code-dom/initializer";

export class Field extends Initializer implements Expression {
  public visibility: AccessModifier = AccessModifier.Public;
  public isStatic: boolean = false;
  public description: string = "";

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Field>) {
    super();
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `${this.visibility} ${this.type.use} ${this.name};`
  }

  public get value(): string {
    return `${this.name}`;
  }
}

export class ConstantField extends Field {
  constructor(name: string, type: TypeDeclaration, public valueExpression: Expression, objectInitializer?: Partial<ConstantField>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    const stat = this.isStatic ? " static " : " ";
    return `${this.visibility}${stat}${this.type.use} ${this.name} = ${this.valueExpression.value};`
  }
}

