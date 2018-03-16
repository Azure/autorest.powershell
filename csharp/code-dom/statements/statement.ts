import { EOL, indent } from "#common/text-manipulation";
import { LiteralStatement } from "#csharp/code-dom/statements/literal";
import { Initializer } from "../initializer";

export type OneOrMoreStatements = string | (() => Iterable<string | Statement>) | Iterable<string | Statement> | Statement;

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

  public add(statements: OneOrMoreStatements): Statements {
    if (typeof statements === 'function') {
      statements = statements();
    }
    if (typeof statements === 'string') {
      statements = new LiteralStatement(statements);
    }
    if (typeof statements === 'object') {
      if (isStatement(statements)) {
        this.statements.push(statements);
      } else {
        for (const statement of statements) {
          this.statements.push(typeof statement === 'string' ? new LiteralStatement(statement) : statement);
        }
      }
    }
    return this;
  }

  public get implementation(): string {
    return `${this.statements.joinWith(each => each.implementation, EOL)}`.trim();
  }
}


