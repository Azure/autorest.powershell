import { Initializer } from '#common/initializer';
import { Expression, LiteralExpression, toExpression } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statement, toStatement } from '#csharp/code-dom/statements/statement';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { isThrowStatement } from 'typescript';

/** represents any declaration of a variable (may be Parameter, LocalVariable, Field or Property) */
export interface Variable extends Expression {
  assign(expression: Expression): OneOrMoreStatements;
  assignPrivate(expression: Expression): OneOrMoreStatements;
  declarationStatement: Statement;
  declarationExpression: Expression;
}

export interface Instance {
  invokeMethod(methodName: string, ...parameters: Array<Variable>): ExpressionStatement;
}

export type ExpressionStatement = Expression & Statement;


/** represents a locally declared variable */
export class LocalVariable extends Initializer implements Variable, Instance {
  public initializer?: Expression;

  constructor(protected name: string, public type: TypeDeclaration, objectIntializer?: Partial<LocalVariable>) {
    super();
    this.apply(objectIntializer);
  }

  public get value(): string {
    return `${this.name}`;
  }
  public get declarationStatement(): Statement {
    return toStatement(`${this.declarationExpression};`);
  }
  public get declarationExpression(): Expression {
    return toExpression(`${this.type.declaration} ${this.name}${this.initializer ? ` = ${this.initializer.value}` : ''}`);
  }
  public assign(expression: Expression): OneOrMoreStatements {
    return `${this.name} = ${expression.value};`;
  }
  public assignPrivate(expression: Expression): OneOrMoreStatements {
    return this.assign(expression);
  }
  public toString(): string {
    return this.value;
  }

  public invokeMethod(methodName: string, ...parameters: Array<Expression>): ExpressionStatement {
    const e = `${this.value}.${methodName}(${parameters.joinWith(each => each.value)})`;
    return {
      implementation: `${e};`,
      value: e,
    };
  }
}