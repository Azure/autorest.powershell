import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function Finally(body: OneOrMoreStatements, objectInitializer?: Partial<FinallyStatement>): FinallyStatement {
  return new FinallyStatement(body, objectInitializer);
}

export class FinallyStatement extends Statements {
  constructor(body: OneOrMoreStatements, objectInitializer?: Partial<FinallyStatement>) {
    super(body);
    this.apply(objectInitializer);
  }

  public get implementation(): string {
    return `
finally
{
${indent(super.implementation)}
} `.trim();
  }
}