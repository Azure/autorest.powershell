import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Expression } from '#csharp/code-dom/expression';


export function Try(body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>): TryStatement {
  return new TryStatement(body, objectInitializer);
}

export class TryStatement extends Statements {
  constructor(body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>) {
    super(body);
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
