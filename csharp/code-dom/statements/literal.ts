import { Statement } from '#csharp/code-dom/statements/statement';

export class LiteralStatement implements Statement {
  constructor(public content: string) {
  }

  public get implementation(): string {
    return this.content;
  }
}