import { TypeDeclaration } from "./type-declaration";

export class Parameter {
  public description: string = "";

  public constructor(private name: string, private type: TypeDeclaration, public genericParameters = new Array<string>(), public where?: string) {

  }

  public get implementation(): string {
    return `parameter;`
  }
}