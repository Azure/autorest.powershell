import { indent } from "#common/text-manipulation";
import { OneOrMoreStatements, Statements } from "#csharp/code-dom/statements/statement";

export class Finally extends Statements {
  constructor(statements: OneOrMoreStatements, objectInitializer?: Partial<Finally>) {
    super(statements);
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