/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { docComment, EOL } from '@microsoft.azure/codegen';
import { Access, Modifier, New, ReadOnly, Static, Volitile } from './access-modifier';
import { Attribute } from './attribute';
import { xmlize } from './doc-comments';
import { Expression, ExpressionOrLiteral, valueOf } from './expression';
import { OneOrMoreStatements, Statement } from './statements/statement';
import { TypeDeclaration } from './type-declaration';
import { Variable } from './variable';

/** represents a field in a Class */
export class Field extends Variable {
  public 'new': New = Modifier.None;
  public access = Access.Public;
  public 'static': Static = Modifier.None;
  public 'readonly': ReadOnly = Modifier.None;
  public volitile: Volitile = Modifier.None;
  public attributes = new Array<Attribute>();
  protected get attributeDeclaration(): string {
    return this.attributes.length > 0 ? `${this.attributes.joinWith(each => `${each.value}`, EOL)}${EOL}` : '';
  }

  public description: string = '';

  constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Field>) {
    super();
    this.apply(objectInitializer);

    if (!this.description.trim()) {
      this.description = `FIXME: Field ${name} is MISSING DESCRIPTION`;
    }
  }

  public get declaration(): string {
    return `${docComment(xmlize('summary', this.description))}
    ${this.attributeDeclaration}${this.new}${this.access} ${this.static} ${this.readonly} ${this.volitile} ${this.type.declaration} ${this.name};`.slim();
  }

  public get value(): string {
    return `${this.name}`;
  }

  public assign(expression: ExpressionOrLiteral): OneOrMoreStatements {

    if (this.readonly) {
      throw new Error('Readonly Field can not be assigned');
    }
    return `${this.name} = ${valueOf(expression)};`;
  }
  public assignPrivate(expression: ExpressionOrLiteral): OneOrMoreStatements {
    if (this.readonly) {
      throw new Error('Readonly Field can not be assigned');
    }
    return this.assign(expression);
  }
  public get declarationExpression(): Expression {
    return this;
  }
  public get declarationStatement(): Statement {
    throw new Error(`Property can not be a declaration statement`);
  }
}

export class InitializedField extends Field {
  constructor(name: string, type: TypeDeclaration, public valueExpression: ExpressionOrLiteral, objectInitializer?: Partial<InitializedField>) {
    super(name, type);
    this.apply(objectInitializer);
  }

  public get declaration(): string {
    return `${docComment(xmlize('summary', this.description))}
${this.attributeDeclaration}${this.new}${this.access} ${this.static} ${this.readonly} ${this.volitile} ${this.type.declaration} ${this.name} = ${valueOf(this.valueExpression)};`.slim();
  }
}

