import { Initializer } from "#common/initializer";
import { Access, Modifier, New, ReadOnly, Static, Volitile } from "#csharp/code-dom/access-modifier";
import { Expression } from "#csharp/code-dom/expression";
import { TypeDeclaration } from "./type-declaration";

export class Field extends Initializer implements Expression {
  public "new": New = Modifier.None;
  public access = Access.Public;
  public "static": Static = Modifier.None;
  public "readonly": ReadOnly = Modifier.None;
  public volitile: Volitile = Modifier.None;

  public description: string = "";

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Field>) {
    super();
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `${this.new}${this.access} ${this.static} ${this.readonly} ${this.volitile} ${this.type.use} ${this.name};`.slim()
  }

  public get value(): string {
    return `${this.name}`;
  }
}

export class InitializedField extends Field {
  constructor(name: string, type: TypeDeclaration, public valueExpression: Expression, objectInitializer?: Partial<InitializedField>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `${this.new}${this.access} ${this.static} ${this.readonly} ${this.volitile} ${this.type.use} ${this.name} = ${this.valueExpression.value};`.slim();
  }
}

