import { Type } from "./type";
import { comment, docCommentPrefix, sortByName, indent, EOL } from "#common/text-manipulation";

export class Interface extends Type {
  constructor(public name: string, public interfaces = new Array<Interface>(), public genericParameters = new Array<string>(), public where?: string) {
    super(name, interfaces, genericParameters, where);
  }

  public get implementation(): string {
    const colon = this.interfaces.length > 0 ? ' : ' : '';
    const implementsInterfaces = this.interfaces.map(v => v.fullName).join(', ');
    const description = comment(this.description, docCommentPrefix);
    const methods = this.methods.sort(sortByName).map(m => m.implementation).join(EOL);
    const properties = this.properties.sort(sortByName).map(m => m.declaration).join(EOL);

    return `
${description}    
${this.accessModifier} interface ${this.name}${colon}${implementsInterfaces} {
${indent(properties, 1)}
${indent(methods, 1)}
}
`.trim();
  }

  public get use(): string {
    return this.fullName;
  }

}
