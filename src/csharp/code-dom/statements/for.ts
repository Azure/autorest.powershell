import { indent } from '#common/text-manipulation';
import { Expression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';

export function For(initialization: Expression, condition: Expression, loop: Expression, statements: OneOrMoreStatements, objectInitializer?: Partial<ForStatement>) {
  return new ForStatement(initialization, condition, loop, statements, objectInitializer);
}

export class ForStatement extends Statements {
  constructor(public initialization: Expression, public condition: Expression, public loop: Expression, statements: OneOrMoreStatements, objectInitializer?: Partial<ForStatement>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
for( ${this.initialization.value} ; ${this.condition.value} ; ${this.loop.value})
{
${indent(super.implementation)}
}`.trim();
  }
}

export function ForEach(variable: string, enumerable: Expression, statements: OneOrMoreStatements, objectInitializer?: Partial<ForStatement>) {
  return new ForEachStatement(variable, enumerable, statements, objectInitializer);
}

export class ForEachStatement extends Statements {
  constructor(public variable: string, public enumerable: Expression, statements: OneOrMoreStatements, objectInitializer?: Partial<ForStatement>) {
    super(statements);
    this.apply(objectInitializer);
  }
  public get implementation(): string {
    return `
foreach( var ${this.variable} in ${this.enumerable.value} )
{
${indent(super.implementation)}
}`.trim();
  }
}
