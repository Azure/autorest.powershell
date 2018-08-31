import { CommaChar, docComment, EOL, indent } from '#common/text-manipulation';
import { Abstract, Access, Async, Extern, Modifier, New, Override, Sealed, Static, Virtual } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { summary } from '#csharp/code-dom/doc-comments';
import { Expression, valueOf, toExpression } from '#csharp/code-dom/expression';
import { Parameter } from './parameter';
import { OneOrMoreStatements, StatementPossibilities, Statements } from './statements/statement';
import { TypeDeclaration } from './type-declaration';
import { dotnet } from '#csharp/code-dom/dotnet';

export class Method extends Statements {
  public parameters = new Array<Parameter>();
  public 'new': New = Modifier.None;
  public access = Access.Public;
  public 'static': Static = Modifier.None;
  public virtual: Virtual = Modifier.None;
  public sealed: Sealed = Modifier.None;
  public override: Override = Modifier.None;
  public abstract: Abstract = Modifier.None;
  public extern: Extern = Modifier.None;
  public async: Async = Modifier.None;
  public isPartial = false;
  public description: string = '';
  public body?: StatementPossibilities;

  constructor(public name: string, protected returnType: TypeDeclaration = dotnet.Void, objectIntializer?: Partial<Method>) {
    super();
    this.apply(objectIntializer);
    // easy access to allow statements in the initalizer.
    if (this.body) {
      this.add(this.body);
    }
    if (!this.description.trim()) {
      this.description = `FIXME: Method ${name} is MISSING DESCRIPTION`;
    }

  }

  public addParameter(parameter: Parameter): Parameter {
    this.parameters.push(parameter);
    return parameter;
  }

  protected get summaryDocumentation(): string {
    return docComment(summary(this.description));
  }

  protected get parameterDocumentation(): string {
    return docComment(this.parameters.joinWith(p => p.comment, EOL));
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.declaration} ${this.name}(${parameterDeclaration})
`.slim();
  }

  public get interfaceDeclaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.returnType.declaration} ${this.name}(${parameterDeclaration});
`.slim();
  }

  public get implementation(): string {
    return `
${this.declaration}
{
${indent(super.implementation)}
}`.trim();
  }

  public invoke(...parameters: Array<Expression>): Expression {
    return toExpression(`${this.name}(${parameters.joinWith(valueOf)})`);
  }
  public addTo(parent: Class): Method {
    parent.addMethod(this);
    return this;
  }
}

export class PartialMethod extends Method {
  public isPartial = true;
  constructor(name: string, returnType: TypeDeclaration = dotnet.Void, objectIntializer?: Partial<PartialMethod>) {
    super(name, returnType);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
partial ${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.declaration} ${this.name}(${parameterDeclaration})
`.slim();
  }

  public get implementation(): string {
    return `${this.declaration};`.slim();
  }
}

export class LambdaMethod extends Method {
  constructor(name: string, returnType: TypeDeclaration = dotnet.Void, protected expression: Expression, objectIntializer?: Partial<PartialMethod>) {
    super(name, returnType);
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.declaration} ${this.name}(${parameterDeclaration}) => ${valueOf(this.expression)}
`.slim();
  }

  public get implementation(): string {
    return `${this.declaration};`.slim();
  }
}
