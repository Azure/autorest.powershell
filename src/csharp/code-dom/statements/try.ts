import { indent } from '#common/text-manipulation';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Expression } from '#csharp/code-dom/expression';
import { Parameter } from '#csharp/code-dom/parameter';


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


export function Catch(parameter: Parameter | undefined, body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>): TryStatement {
  return new CatchStatement(parameter, body, objectInitializer);
}

export class CatchStatement extends Statements {
  constructor(protected parameter: Parameter | undefined, body: OneOrMoreStatements, objectInitializer?: Partial<TryStatement>) {
    super(body);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    const p = this.parameter ? ` (${this.parameter.declaration})` : '';
    return `
catch${p}
{
${indent(super.implementation)}
}`.trim();
  }
}
