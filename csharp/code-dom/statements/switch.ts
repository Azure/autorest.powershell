import { Statement } from "#csharp/code-dom/statements/statement";
import { Expression } from "#csharp/code-dom/expression";
import { Case } from "#csharp/code-dom/statements/case";
import { indent, EOL } from "#common/text-manipulation";

export type OneOrMoreCases = (() => Iterable<Case>) | Iterable<Case> | Case;

export class Switch implements Statement {
  protected caseStatements = new Array<Case>();

  public get implementation(): string {
    return `
switch( ${this.expression.value} )
{
${indent(this.caseStatements.map(each => each.implementation).join(EOL))}
}`
  }
  constructor(protected expression: Expression, cases: OneOrMoreCases) {
    this.add(cases);
  }
  public add(cases: OneOrMoreCases) {
    if (typeof cases === 'function') {
      cases = cases();
    }
    if (cases instanceof Case) {
      this.caseStatements.push(cases);
    }
    else {
      for (const caseStatement of cases) {
        this.caseStatements.push(caseStatement);
      }
    }
  }

}