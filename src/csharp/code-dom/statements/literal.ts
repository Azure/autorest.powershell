import { Statement } from '#csharp/code-dom/statements/statement';

export class LiteralStatement implements Statement {
  constructor(public implementation: string) {
  }
}