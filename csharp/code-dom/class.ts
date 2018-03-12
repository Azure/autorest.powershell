import { Type } from "./type";
import { Interface } from "./interface";
import { comment, docCommentPrefix, sortByName, indent, EOL } from "#common/text-manipulation";
import { Field } from "./field";
import { Method } from "./method";
import { Property } from "./property";
import { Namespace } from "./namespace";

export class Class extends Type {
  protected fields = new Array<Field>();
  public partial: boolean = false;

  constructor(parent: Namespace, name: string, public parentClass?: Class, interfaces = new Array<Interface>(), genericParameters = new Array<string>(), where?: string) {
    super(parent, name, interfaces, genericParameters, where);
    parent.addClass(this);
  }

  public get declaration(): string {
    const colon = (this.parentClass || this.interfaces.length > 0) ? ' : ' : '';
    const comma = (this.parentClass && this.interfaces.length > 0) ? ", " : '';

    const extendsClass = this.parentClass ? this.parentClass.fullName : '';
    const implementsInterfaces = this.interfaces.map(v => v.fullName).join(', ');
    const description = comment(this.description, docCommentPrefix);
    const partial = this.partial ? "partial " : "";
    return `
${description}
${this.accessModifier} ${partial}class ${this.name}${colon}${extendsClass}${comma}${implementsInterfaces}
`.trim();
  }

  public get implementation(): string {
    const fields = this.fields.sort(sortByName).map(m => m.declaration).join(EOL);
    const methods = this.methods.sort(sortByName).map(m => m.implementation).join(EOL);
    const properties = this.properties.sort(sortByName).map(m => m.declaration).join(EOL);

    return `
${this.declaration} {
${indent(fields, 1)}
${indent(properties, 1)}
${indent(methods, 1)}
}
`.trim();
  }

  public addField(field: Field): Field {
    this.fields.push(field);
    return field;
  }

  public get use(): string {
    return `
${this.fullName}
`.trim()
  }
}