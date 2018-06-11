import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function Case(value: string, body: OneOrMoreStatements, objectInitializer?: Partial<CaseStatement>): CaseStatement {
  return new CaseStatement(value, body, objectInitializer);
}

export class CaseStatement extends Statements {
  constructor(protected value: string, body: OneOrMoreStatements, objectInitializer?: Partial<CaseStatement>) {
    super(body);
    this.apply(objectInitializer);
  }

  protected get statementsImplementation(): string {
    return indent(super.implementation);
  }
  public get implementation(): string {
    return `
case ${this.value}:
${this.statementsImplementation}
${indent('break')};
`.trim();
  }
}

export function DefaultCase(body: OneOrMoreStatements, objectInitializer?: Partial<CaseStatement>): CaseStatement {
  return new DefaultCaseStatement(body, objectInitializer);
}

export class DefaultCaseStatement extends CaseStatement {
  constructor(body: OneOrMoreStatements, objectInitializer?: Partial<DefaultCaseStatement>) {
    super("", body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    return `
default:
${this.statementsImplementation}
${indent('break')};
`.trim();
  }
}


export function TerminalDefaultCase(body: OneOrMoreStatements, objectInitializer?: Partial<CaseStatement>): TerminalDefaultCaseStatement {
  return new TerminalDefaultCaseStatement(body, objectInitializer);
}

export class TerminalDefaultCaseStatement extends CaseStatement {
  constructor(body: OneOrMoreStatements, objectInitializer?: Partial<TerminalDefaultCaseStatement>) {
    super("", body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    return `
default:
${this.statementsImplementation}
`.trim();
  }
}


export function TerminalCase(value: string, body: OneOrMoreStatements, objectInitializer?: Partial<CaseStatement>): TerminalCaseStatement {
  return new TerminalCaseStatement(value, body, objectInitializer);
}

export class TerminalCaseStatement extends CaseStatement {
  constructor(value: string, body: OneOrMoreStatements, objectInitializer?: Partial<TerminalCaseStatement>) {
    super(value, body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    return `
case ${this.value}:
${this.statementsImplementation}
`.trim();
  }
}
