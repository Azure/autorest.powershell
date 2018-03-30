import { TypeDeclaration } from "./type-declaration";
import { Expression } from "#csharp/code-dom/expression";
import { Initializer } from "#common/initializer";
import { ParameterModifier } from "#csharp/code-dom/parameter-modifier";

export class Parameter extends Initializer implements Expression {
  public description: string = "";
  public genericParameters = new Array<string>();
  public where?: string;
  public modifier: ParameterModifier = ParameterModifier.None;
  public defaultInitializer?: string;

  public constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Parameter>) {
    super();
    this.apply(objectInitializer);
  }

  public get comment() {
    return `<param name="${this.name}"> ${this.description} </param>`;
  }
  public get declaration(): string {
    return `${this.modifier} ${this.type.use} ${this.name} ${this.defaultInitializer || ''}`.trim();
  }
  public get use(): string {
    return this.name;
  }

  public get value(): string {
    return `${this.name}`;
  }
}