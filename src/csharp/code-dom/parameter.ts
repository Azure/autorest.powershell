/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Attribute } from '#csharp/code-dom/attribute';
import { Expression, ExpressionOrLiteral, valueOf } from '#csharp/code-dom/expression';
import { ParameterModifier } from '#csharp/code-dom/parameter-modifier';
import { OneOrMoreStatements, Statement } from '#csharp/code-dom/statements/statement';
import { Variable } from '#csharp/code-dom/variable';
import { TypeDeclaration } from './type-declaration';

/** represents a method parameter */
export class Parameter extends Variable {
  public description: string = '';
  public genericParameters = new Array<string>();
  public where?: string;
  public modifier: ParameterModifier = ParameterModifier.None;
  public defaultInitializer?: string;
  public attributes = new Array<Attribute>();
  protected get attributeDeclaration(): string {
    return this.attributes.length > 0 ? `${this.attributes.joinWith(each => `${each.value}`, ' ')} ` : '';
  }

  public constructor(public name: string, public type: TypeDeclaration, objectInitializer?: Partial<Parameter>) {
    super();
    this.apply(objectInitializer);

    if (!this.description.trim()) {
      this.description = `FIXME: Parameter ${name} is MISSING DESCRIPTION`;
    }
  }

  public get comment() {
    return `<param name="${this.name}">${this.description}</param>`;
  }
  public get declaration(): string {
    return `${this.attributeDeclaration}${this.modifier} ${this.type.declaration} ${this.name} ${this.defaultInitializer || ''}`.trim();
  }
  public get use(): string {
    return this.name;
  }

  public get value(): string {
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
}
