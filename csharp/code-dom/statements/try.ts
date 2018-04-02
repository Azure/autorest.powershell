import { indent } from "#common/text-manipulation";
import { OneOrMoreStatements, Statements } from "#csharp/code-dom/statements/statement";

export class Try extends Statements {
  constructor(statements: OneOrMoreStatements, objectInitializer?: Partial<Try>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
try
{
${indent(super.implementation)}
}`.trim();
  }
}
