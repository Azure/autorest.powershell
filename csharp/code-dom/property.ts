import { TypeDeclaration } from "./type-declaration";
import { Access, highestAccess, New, Static, Modifier, Virtual, Sealed, Override, Abstract, Extern } from "#csharp/code-dom/access-modifier";
import { Expression } from "#csharp/code-dom/expression";
import { Initializer } from "#csharp/code-dom/initializer";

export class Property extends Initializer implements Expression {
  public "new": New = Modifier.None;
  public getAccess = Access.Public;
  public setAccess = Access.Public;
  public "static": Static = Modifier.None;
  public virtual: Virtual = Modifier.None;
  public sealed: Sealed = Modifier.None;
  public override: Override = Modifier.None;
  public abstract: Abstract = Modifier.None;
  public extern: Extern = Modifier.None;

  protected get visibility(): Access {
    return highestAccess(this.getAccess, this.setAccess);
  }

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Property>) {
    super();
    this.apply(objectInitializer);
  }

  protected get getter(): string {
    return this.getAccess == this.visibility ? "get" : `${this.getAccess} get`
  };
  protected get setter(): string {
    return this.setAccess == this.visibility ? "set" : `${this.setAccess} set`
  };

  public get declaration(): string {
    return `${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.use} ${this.name} { ${this.getter}; ${this.setter}; }`.slim();
  }
  public get value(): string {
    return `${this.name}`;
  }
}
