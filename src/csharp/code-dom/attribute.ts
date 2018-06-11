import { Initializer } from '#common/initializer';
import { Expression, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

/** An c# Attribute that can be placed on methods, classes, members and parameters */
export class Attribute extends Initializer {
  public parameters = new Array<ExpressionOrLiteral>();

  constructor(public type: TypeDeclaration, objectIntializer?: Partial<Attribute>) {
    super();
    this.apply(objectIntializer);
  }

  get value(): string {
    const params = this.parameters.length > 0 ? `(${this.parameters.joinWith(each => toExpression(each).value)})` : '';
    return `[${this.type.declaration}${params}]`;
  }
}
