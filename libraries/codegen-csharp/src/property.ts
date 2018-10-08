/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Dictionary, intersect } from '@microsoft.azure/codegen';

import { docComment, EOL, indent } from '@microsoft.azure/codegen';
import { Abstract, Access, Extern, highestAccess, Modifier, New, Override, Sealed, Static, Virtual } from './access-modifier';
import { Attribute } from './attribute';
import { summary } from './doc-comments';
import { Expression, ExpressionOrLiteral, toExpression, valueOf } from './expression';
import { OneOrMoreStatements, Statement, Statements } from './statements/statement';
import { TypeDeclaration } from './type-declaration';
import { ExpressionStatement, Instance, Variable } from './variable';

export class Property extends Variable implements Instance {
  public 'new': New = Modifier.None;
  public getAccess = Access.Public;
  public setAccess = Access.Public;
  public 'static': Static = Modifier.None;
  public virtual: Virtual = Modifier.None;
  public sealed: Sealed = Modifier.None;
  public override: Override = Modifier.None;
  public abstract: Abstract = Modifier.None;
  public extern: Extern = Modifier.None;
  public attributes = new Array<Attribute>();
  public metadata: Dictionary<any> = {};
  public description: string = '';

  protected get visibility(): Access {
    return highestAccess(this.getAccess, this.setAccess);
  }

  public add<T extends object>(item: T & (Attribute)): T {
    if (item instanceof Attribute) {
      this.attributes.push(item);
      return item;
    }
    throw Error(`FATAL - UNABLE TO ADD UNKNOWN TYPE for '${JSON.stringify(item)}'`);
  }

  protected get attributeDeclaration(): string {
    return this.attributes.length > 0 ? `${this.attributes.joinWith(each => `${each.value}`, EOL)}${EOL}` : '';
  }

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Property>) {
    super();
    this.apply(objectInitializer);

    if (!this.description.trim()) {
      this.description = `FIXME: Property ${name} is MISSING DESCRIPTION`;
    }
  }

  protected get getterDeclaration(): string {
    return this.getAccess === this.visibility ? 'get' : `${this.getAccess} get`;
  }
  protected get setterDeclaration(): string {
    return this.setAccess === this.visibility ? 'set' : `${this.setAccess} set`;
  }
  protected get getter(): string {
    return `${this.getterDeclaration};`;
  }

  protected get setter(): string {
    return `${this.setterDeclaration};`;
  }

  public get declaration(): string {
    return `
${docComment(summary(this.description))}
${this.attributeDeclaration}${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.declaration} ${this.name} {${this.getter}${this.setter}}
`.slim();
  }
  public get value(): string {
    return `${this.name}`;
  }
  public get valuePrivate(): string {
    return `${this.name}`;
  }

  public assign(expression: ExpressionOrLiteral): OneOrMoreStatements {
    return `${this.name} = ${valueOf(expression)};`;
  }
  public assignPrivate(expression: ExpressionOrLiteral): OneOrMoreStatements {
    return this.assign(expression);
  }
  public get declarationExpression(): Expression {
    return this;
  }
  public get declarationStatement(): Statement {
    throw new Error(`Property can not be a declaration statement`);
  }
  public invokeMethod(methodName: string, ...parameters: Array<Expression>): ExpressionStatement {
    const e = `${this.value}.${methodName}(${parameters.joinWith(valueOf)})`;
    return intersect(
      toExpression(e), {
        implementation: `${e};`
      });
  }

}

export class ImplementedProperty extends Property {
  getterStatements?: Statement;
  setterStatements?: Statement;
  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<ImplementedProperty>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return (`
${docComment(summary(this.description))}
${this.attributeDeclaration}${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.declaration} ${this.name}`.slim() +

      `
{
    ${this.getter}
    ${this.setter}
}
`).trim();
  }

  protected get getter(): string {
    if (!this.getterStatements) {
      return '';
    }
    return `${this.getterDeclaration}
    {
${indent(this.getterStatements.implementation, 2)}
    }`.trim();
  }

  protected get setter(): string {
    if (!this.setterStatements) {
      return '';
    }
    return `${this.setterDeclaration}
    {
${indent(this.setterStatements.implementation, 2)}
    }`.trim();
  }
}

export class LambdaProperty extends Property {
  constructor(public name: string, public type: TypeDeclaration, public expression: Expression, objectInitializer?: Partial<LambdaProperty>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {

    return `
${docComment(summary(this.description))}
${this.attributeDeclaration}${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.declaration} ${this.name} => ${valueOf(this.expression)};
`.slim();
  }
}

export class LazyProperty extends Property {
  private backingName: string;
  public instanceAccess: string = 'this';

  constructor(public name: string, public type: TypeDeclaration, public expression: Expression, objectInitializer?: Partial<LazyProperty>) {
    super(name, type);
    this.backingName = `_${this.name.uncapitalize()}`;
    this.apply(objectInitializer);
  }

  public get declaration(): string {

    return `
${ docComment(summary(`Backing field for <see cref="${this.name}" /> property.`))}
private ${this.static} ${this.type.declaration} ${this.backingName};
EOL
${docComment(summary(this.description))}
${this.attributeDeclaration}${this.new}${this.visibility} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.type.declaration} ${this.name} => ${this.instanceAccess}.${this.backingName}?? (${this.instanceAccess}.${this.backingName} = ${this.expression.value});
`.slim();
  }
}

export class BackedProperty extends ImplementedProperty {
  public backingName: string;
  public initializer?: ExpressionOrLiteral;
  constructor(name: string, type: TypeDeclaration, objectInitializer?: Partial<BackedProperty>) {
    const backingName = `_${name.uncapitalize()}`;
    super(name, type, {
      getterStatements: new Statements(`return this.${backingName};`),
      setterStatements: new Statements(`this.${backingName} = value;`)
    });
    this.backingName = backingName;

    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `
${docComment(summary(`Backing field for <see cref="${this.name}" /> property.`))}
private ${this.type.declaration} ${this.backingName}${this.initializer ? `= ${valueOf(this.initializer)}` : ''};
EOL
${super.declaration}
`.trim();
    // ${docComment(summary(this.description))}
    // ${ this.attributeDeclaration } ${ this.new } ${ this.visibility } ${ this.static } ${ this.virtual } ${ this.sealed } ${ this.override } ${ this.abstract } ${ this.extern } ${ this.type.declaration } ${ this.name } { ${ this.getterDeclaration } { return this.${ this.backingName }; } ${ this.setterDeclaration } { this.${ this.backingName } = value; } }
    // EOL
  }

  public get value(): string {
    return `${this.name}`;
  }
  public get valuePrivate(): string {
    return `this.${this.backingName}`;
  }
  public assignPrivate(expression: ExpressionOrLiteral): OneOrMoreStatements {
    return `${this.backingName} = ${valueOf(expression)};`;
  }
}
