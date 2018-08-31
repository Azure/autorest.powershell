import { Initializer } from '#common/initializer';
import { Expression, ExpressionOrLiteral, LiteralExpression, toExpression, valueOf } from '#csharp/code-dom/expression';
import { OneOrMoreStatements, Statement, toStatement } from '#csharp/code-dom/statements/statement';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { IsNull, IsNotNull, Cast } from '#csharp/code-dom/comparisons';
import { intersect } from '#common/intersect';

/** represents any declaration of a variable (may be Parameter, LocalVariable, Field or Property) */
export interface Variable extends Expression {
  assign(expression: ExpressionOrLiteral): OneOrMoreStatements;
  assignPrivate(expression: ExpressionOrLiteral): OneOrMoreStatements;
  declarationStatement: Statement;
  declarationExpression: Expression;
}

export abstract class Variable extends Initializer implements Variable {
  get IsNull(): Expression {
    return IsNull(this);
  }
  toString(): string {
    return this.value;
  }
  get IsNotNull(): Expression {
    return IsNotNull(this);
  }
  Cast(toType: TypeDeclaration): Expression {
    return Cast(this, toType);
  }
}

/** A ReferenceVariable can be passed as by 'ref' in C# */
export interface ReferenceVariable extends Variable {
  byref: Expression;
}

export interface Instance {
  invokeMethod(methodName: string, ...parameters: Array<Variable>): ExpressionStatement;
}

export type ExpressionStatement = Expression & Statement;


/** represents a locally declared variable */
export class LocalVariable extends Variable implements Instance, Statement {
  public initializer?: ExpressionOrLiteral;

  constructor(protected name: string, public type: TypeDeclaration, objectIntializer?: Partial<LocalVariable>) {
    super();
    this.apply(objectIntializer);
  }

  public get value(): string {
    return `${this.name}`;
  }
  public get implementation(): string {
    return this.declarationStatement.implementation;
  }
  public get declarationStatement(): Statement {
    return toStatement(`${this.declarationExpression};`);
  }
  public get declarationExpression(): Expression {
    return toExpression(`${this.type.declaration} ${this.name}${this.initializer ? ` = ${valueOf(this.initializer)}` : ''}`);
  }
  public assign(expression: ExpressionOrLiteral): OneOrMoreStatements {
    return `${this.name} = ${valueOf(expression)};`;
  }
  public assignPrivate(expression: ExpressionOrLiteral): OneOrMoreStatements {
    return this.assign(expression);
  }
  public invokeMethod(methodName: string, ...parameters: Array<Expression>): ExpressionStatement {
    const e = `${valueOf(this)}.${methodName}(${parameters.joinWith(valueOf)})`;
    return intersect(
      toExpression(e), {
        implementation: `${e};`
      });
  }
  public member(memberName: string) {
    return new MemberVariable(this, memberName);
  }
}


export class MemberVariable extends LocalVariable {
  constructor(private variable: Variable, private memberName: string, objectIntializer?: Partial<MemberVariable>) {
    super(`${variable}.${memberName}`, { declaration: 'var' });
    this.apply(objectIntializer);
  }
}