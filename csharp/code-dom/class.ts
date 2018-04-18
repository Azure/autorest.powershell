import { EOL, comment, docCommentPrefix, indent, sortByName } from "#common/text-manipulation";
import { Field } from "./field";
import { Namespace } from "./namespace";
import { Type } from "./type";
import { Method } from "#csharp/code-dom/method";

export function sortByNamePartialFirst(a: Method, b: Method): number {
  if (a.isPartial !== b.isPartial) {
    return a.isPartial ? -1 : 1;
  }
  return sortByName(a, b);
}

export class Class extends Type {
  protected classOrStruct: "class" | "struct" = "class";
  public isStatic: boolean = false;

  protected fields = new Array<Field>();
  public partial: boolean = false;

  constructor(namespace: Namespace, name: string, public parent?: Class, objectIntializer?: Partial<Class>) {
    super(namespace, name);
    this.apply(objectIntializer);
    namespace.addClass(this);
  }

  public get declaration(): string {
    const colon = (this.parent || this.interfaces.length > 0) ? ' : ' : '';
    const comma = (this.parent && this.interfaces.length > 0) ? ", " : '';

    const extendsClass = this.parent ? this.parent.fullName : '';
    const implementsInterfaces = this.interfaces.map(v => v.fullName).join(', ');
    const description = comment(this.description, docCommentPrefix);
    const partial = this.partial ? "partial " : "";
    const stat = this.isStatic ? "static " : "";

    return `
${description}
${this.accessModifier} ${stat}${partial}${this.classOrStruct} ${this.name}${colon}${extendsClass}${comma}${implementsInterfaces}
`.trim();
  }

  public get implementation(): string {
    const fields = this.fields.sort(sortByName).map(m => m.declaration).join(EOL);
    const methods = this.methods.sort(sortByNamePartialFirst).map(m => m.implementation).join(EOL);
    const properties = this.properties.sort(sortByName).map(m => m.declaration).join(EOL);
    return `
${this.declaration} 
{
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
