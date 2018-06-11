import { comment, docCommentPrefix, EOL, indent, sortByName } from '#common/text-manipulation';
import { Method } from '#csharp/code-dom/method';
import { Field } from './field';
import { Namespace } from './namespace';
import { Type } from './type';
import { Expression } from '#csharp/code-dom/expression';
import { Property } from '#csharp/code-dom/property';
import { Attribute } from '#csharp/code-dom/attribute';
import { fail } from '#common/utility';

export function sortByNamePartialFirst(a: Method, b: Method): number {
  if (a.isPartial !== b.isPartial) {
    return a.isPartial ? -1 : 1;
  }
  return sortByName(a, b);
}

export class Class extends Type {
  protected classOrStruct: 'class' | 'struct' = 'class';
  public isStatic: boolean = false;

  protected fields = new Array<Field>();
  public partial: boolean = false;

  constructor(namespace: Namespace, name: string, public parent?: Class, objectIntializer?: Partial<Class>) {
    super(namespace, name);
    this.apply(objectIntializer);
    namespace.addClass(this);
  }

  public get signature(): string {
    const colon = (this.parent || this.interfaces.length > 0) ? ' : ' : '';
    const comma = (this.parent && this.interfaces.length > 0) ? ', ' : '';

    const extendsClass = this.parent ? this.parent.fullName : '';
    const implementsInterfaces = this.interfaces.map(v => v.fullName).join(', ');
    const description = comment(this.description, docCommentPrefix);
    const partial = this.partial ? 'partial ' : '';
    const stat = this.isStatic ? 'static ' : '';


    return `
${description}
${this.attributeDeclaration}${this.accessModifier} ${stat}${partial}${this.classOrStruct} ${this.name}${colon}${extendsClass}${comma}${implementsInterfaces}
`.trim();
  }

  public get definition(): string {
    const fields = this.fields.sort(sortByName).map(m => m.declaration).join(EOL);
    const methods = this.methods.sort(sortByNamePartialFirst).map(m => m.implementation).join(EOL);
    const properties = this.properties.sort(sortByName).map(m => m.declaration).join(EOL);
    return `
${this.signature}
{
${indent(fields, 1)}
${indent(properties, 1)}
${indent(methods, 1)}
}
`.trim();
  }

  public add<T extends object>(item: T & (Method | Property | Attribute | Field)): T {
    if (item instanceof Field) {
      this.fields.push(item);
      return item;
    }
    return super.add(item);
  }

  public addField(field: Field): Field {
    this.fields.push(field);
    return field;
  }

  public get declaration(): string {
    return `
${this.fullName}
`.trim();
  }

  public newInstance(...parameters: Array<Expression>): Expression {
    return { value: `new ${this.name}(${parameters.joinWith(each => each.value)})` };
  }

  public property(name: string): Property {
    return this.properties.find(p => p.name === name) || fail(`No property ${name}`);
  }

  public $<T extends (Property | Method | Field)>(name: string): T {
    return <T>this.properties.find(p => p.name === name) ||
      this.methods.find(p => p.name === name) ||
      this.fields.find(p => p.name === name) || fail(`No property ${name}`);
  }
}
