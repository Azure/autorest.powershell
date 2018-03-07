import { TypeDeclaration } from "./type-declaration";

export class Field {
  public visibility = "public";

  constructor(public name: string, public type: TypeDeclaration) {

  }

  public get implementation(): string {
    return `${this.visibility} ${this.type.use} ${this.name};`
  }
}