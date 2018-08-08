import { Initializer } from '#common/initializer';
import { EOL } from '#common/text-manipulation';
import { LiteralStatement } from '#csharp/code-dom/statements/literal';

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

  constructor(statements?: StatementPossibilities, objectIntializer?: Partial<Statements>) {
    super();
    if (statements) {
      this.add(statements);
    }
    this.apply(objectIntializer);
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

  private appendStatements(statements: OneOrMoreStatements): Statements {
    if (!statements) {
      return this;
    }

    if (typeof statements === 'function') {
      statements = statements();
    }

    if (typeof statements === 'string') {
      if (statements.trim().length > 0) {
        this.statements.push(new LiteralStatement(statements));
      }
      return this;
    }

    if (typeof statements === 'object') {
      if (isStatement(statements)) {
        this.statements.push(statements);
        return this;
      }

      if (statements instanceof Statements) {
        this.statements.push(...statements.statements)
        return this;
      }

      for (const statement of statements) {
        this.statements.push(typeof statement === 'string' ? new LiteralStatement(statement) : statement);
      }
    }
    return this;
  }

  public get implementation(): string {
    return `${this.statements.joinWith(each => each.implementation, EOL)}`.trim();
  }
}
