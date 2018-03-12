import { Type } from "./type";
import { comment, docCommentPrefix, sortByName, indent, EOL } from "#common/text-manipulation";
import { Namespace } from "./namespace";

export class Interface extends Type {
  constructor(parent: Namespace, name: string, interfaces = new Array<Interface>(), genericParameters = new Array<string>(), where?: string) {
    super(parent, name, interfaces, genericParameters, where);
    parent.addInterface(this);
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
