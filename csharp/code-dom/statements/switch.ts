import { Statement } from "#csharp/code-dom/statements/statement";
import { Expression } from "#csharp/code-dom/expression";
import { Case } from "#csharp/code-dom/statements/case";
import { indent, EOL } from "#common/text-manipulation";
import { Initializer } from "#common/initializer";

export type OneOrMoreCases = (() => Iterable<Case>) | Iterable<Case> | Case;

export class Switch extends Initializer implements Statement {
  protected caseStatements = new Array<Case>();

  public get implementation(): string {
    return `
switch( ${this.expression.value} )
{
${indent(this.caseStatements.map(each => each.implementation).join(EOL))}
}`
  }
  constructor(protected expression: Expression, cases: OneOrMoreCases, objectInitializer?: Partial<Switch>) {
    super();
    this.apply(objectInitializer);
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