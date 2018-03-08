import { TypeDeclaration } from "./type-declaration";
import { Expression } from "#csharp-code-dom/expression";

export class Field implements Expression {
  public visibility = "public";

  constructor(public name: string, public type: TypeDeclaration) {
  }

  public get declaration(): string {
    return `${this.visibility} ${this.type.use} ${this.name};`
  }

  public get value(): string {
    return `${this.name}`;
  }
}