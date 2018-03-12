import { TypeDeclaration } from "./type-declaration";
import { Expression } from "#csharp/code-dom/expression";

export class Parameter implements Expression {
  public description: string = "";

  public constructor(private name: string, private type: TypeDeclaration, public genericParameters = new Array<string>(), public where?: string) {

  }

  public get comment() {
    return `<param name="${this.name}"> ${this.description} </param>`;
  }
  public get declaration(): string {
    return `${this.type.use} ${this.name}`;
  }
  public get use(): string {
    return this.name;
  }

  public get value(): string {
    return `${this.name}`;
  }
}