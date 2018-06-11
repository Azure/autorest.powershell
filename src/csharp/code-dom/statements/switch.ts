import { Initializer } from '#common/initializer';
import { EOL, indent } from '#common/text-manipulation';
import { Expression } from '#csharp/code-dom/expression';
import { CaseStatement } from '#csharp/code-dom/statements/case';
import { Statement } from '#csharp/code-dom/statements/statement';

export type OneOrMoreCases = (() => Iterable<CaseStatement>) | Iterable<CaseStatement> | CaseStatement;

export function Switch(expression: Expression, cases: OneOrMoreCases, objectInitializer?: Partial<SwitchStatement>): SwitchStatement {
  return new SwitchStatement(expression, cases, objectInitializer);
}

export class SwitchStatement extends Initializer implements Statement {
  protected caseStatements = new Array<CaseStatement>();

  public get implementation(): string {
    return `
switch( ${this.expression.value} )
{
${indent(this.caseStatements.map(each => each.implementation).join(EOL))}
}`;
  }
  constructor(protected expression: Expression, cases: OneOrMoreCases, objectInitializer?: Partial<SwitchStatement>) {
    super();
    this.apply(objectInitializer);
    this.add(cases);
  }
  public add(cases: OneOrMoreCases) {
    if (typeof cases === 'function') {
      cases = cases();
    }
    if (cases instanceof CaseStatement) {
      this.caseStatements.push(cases);
    }
    else {
      for (const caseStatement of cases) {
        this.caseStatements.push(caseStatement);
      }
    }
  }
}