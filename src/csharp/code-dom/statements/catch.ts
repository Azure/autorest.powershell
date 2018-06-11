import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Parameter } from '#csharp/code-dom/parameter';
import { Expression } from '#csharp/code-dom/expression';

export function Catch(parameter: Parameter, body: OneOrMoreStatements, objectInitializer?: Partial<CatchStatement>): CatchStatement {
  return new CatchStatement(parameter, body, objectInitializer);
}

export class CatchStatement extends Statements {
  public when?: Expression;

  constructor(protected parameter: Parameter, body: OneOrMoreStatements, objectInitializer?: Partial<CatchStatement>) {
    super(body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    const when = this.when ? ` when (${this.when})` : ``;
    return `
catch(${this.parameter.declaration})${when}
{
${indent(super.implementation)}
} `.trim();
  }
}