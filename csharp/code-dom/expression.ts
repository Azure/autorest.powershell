export interface Expression {
  value: string;
}

export class StringExpression implements Expression {
  public value: string;
  constructor(value: string) {
    this.value = `@"${value.replace(/"/g, '""')}"`;
  }
}