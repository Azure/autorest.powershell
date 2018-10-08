/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { EOL, Initializer } from '@microsoft.azure/codegen';
import { LiteralStatement } from './literal';

export type fIterable<T> = Iterable<T> | (() => Iterable<T>);

export interface Statement {
  implementation: string;
}

export type StatementOrLiteral = Statement | string;
export type OneOrMoreStatements = StatementOrLiteral | fIterable<StatementOrLiteral>;
export type OneOrMoreStatements2 = OneOrMoreStatements | fIterable<OneOrMoreStatements>;
export type OneOrMoreStatements3 = OneOrMoreStatements2 | fIterable<OneOrMoreStatements2>;
export type OneOrMoreStatements4 = OneOrMoreStatements3 | fIterable<OneOrMoreStatements3>;
export type OneOrMoreStatements5 = OneOrMoreStatements4 | fIterable<OneOrMoreStatements4>;

export type StatementPossibilities = OneOrMoreStatements5 | Statements;

export function toStatement(statement: StatementOrLiteral): Statement {
  return typeof statement === 'string' ? new LiteralStatement(statement) : statement;
}

export function isStatement(object: StatementPossibilities): object is Statement {
  return (<any>object).implementation ? true : false;
}

export class Statements extends Initializer implements Statement {
  protected statements = new Array<Statement>();
  private scope = new Array<Statements>();

  constructor(statements?: StatementPossibilities, objectIntializer?: Partial<Statements>) {
    super();
    this.scope.push(this);
    if (statements) {
      this.add(statements);
    }
    this.apply(objectIntializer);
  }

  push(innerScope: Statements) {
    this.add(innerScope);
    this.scope.push(innerScope);
    return this.scope.last;
  }

  pop() {
    if (this.scope.last === this) {
      throw new Error(`Can not pop past base of statement collection.`);
    }
    this.scope.pop();
    return this.scope.last;
  }

  public get count(): number {
    return this.statements.length;
  }

  public insert(statements: StatementPossibilities): Statements {
    if (typeof (statements) === 'string') {
      this.statements.splice(0, 0, new LiteralStatement(statements));
      return this;
    }
    if (statements instanceof Statements) {
      this.statements.splice(0, 0, statements);
      return this;
    }
    if (isStatement(statements)) {
      this.statements.splice(0, 0, statements);
      return this;
    }
    if (typeof (statements) === 'function') {
      return this.insert(statements());
    }
    for (const each of statements) {
      this.insert(each);
    }
    return this;
  }

  public add(statements: StatementPossibilities): Statements {
    if (this.scope.last !== this) {
      this.scope.last.add(statements);
      return this;
    }
    if (typeof (statements) === 'string') {
      this.statements.push(new LiteralStatement(statements));
      return this;
    }
    if (statements instanceof Statements) {
      this.statements.push(statements);
      return this;
    }
    if (isStatement(statements)) {
      this.statements.push(statements);
      return this;
    }
    if (typeof (statements) === 'function') {
      return this.add(statements());
    }
    for (const each of statements) {
      this.add(each);
    }
    return this;
  }

  public get implementation(): string {
    return `${this.statements.joinWith(each => each.implementation, EOL)}`.trim();
  }
}
