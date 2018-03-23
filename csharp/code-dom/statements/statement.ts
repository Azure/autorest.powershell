import { EOL, indent } from "#common/text-manipulation";
import { LiteralStatement } from "#csharp/code-dom/statements/literal";
import { Initializer } from "../initializer";

export type OneOrMoreStatements = string | (() => Iterable<string | Statement>) | Iterable<string | Statement> | Statement;
export type ManyStatements = OneOrMoreStatements | (() => Iterable<OneOrMoreStatements>);

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
    return this.statements.length
  }

  public add(statements: ManyStatements): Statements {
    if (typeof statements === 'function') {
      // console.error(statements);
      for (const each of statements()) {
        this.aadd(each);
      }
      //statements = statements();
      return this;
    }
    return this.aadd(statements);
    /*if (typeof statements === 'string') {
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
    return this;*/
  }
  private aadd(statements: OneOrMoreStatements): Statements {
    if (typeof statements === 'function') {
      console.error(statements);
      statements = statements();
    }
    if (typeof statements === 'string') {
      this.statements.push(new LiteralStatement(statements));
      return this;
    }
    if (typeof statements === 'object') {
      console.error(statements);
      if (isStatement(statements)) {
        this.statements.push(statements);
      } else if (statements instanceof Statements) {
        this.statements.push(...statements.statements)
      }
      else {
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


