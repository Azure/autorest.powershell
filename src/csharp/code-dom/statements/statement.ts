import { Initializer } from '#common/initializer';
import { EOL } from '#common/text-manipulation';
import { LiteralStatement } from '#csharp/code-dom/statements/literal';

export type OneOrMoreStatements = string | (() => Iterable<string | Statement>) | Iterable<string | Statement> | Statement;
export type StatementPossibilities = OneOrMoreStatements | (() => Iterable<OneOrMoreStatements>);

export type StatementOrLiteral = Statement | string;
export function toStatement(statement: StatementOrLiteral): Statement {
  return typeof statement === 'string' ? new LiteralStatement(statement) : statement;
}

export interface Statement {
  implementation: string;
}

export function isStatement(object: OneOrMoreStatements): object is Statement {
  return (<any>object).implementation ? true : false;
}

export class Statements extends Initializer implements Statement {
  protected statements = new Array<Statement>();

  constructor(statements?: OneOrMoreStatements, objectIntializer?: Partial<Statements>) {
    super();
    if (statements) {
      this.add(statements);
    }
    this.apply(objectIntializer);
  }

  public get count(): number {
    return this.statements.length;
  }

  public add(statements: StatementPossibilities): Statements {
    if (typeof statements !== 'function') {
      return this.appendStatements(statements);
    }
    // unroll statements
    for (const each of statements()) {
      this.appendStatements(each);
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
