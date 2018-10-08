/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { CommaChar, docComment, EOL, indent } from '@microsoft.azure/codegen';
import { Abstract, Access, Async, Extern, Modifier, New, Override, Sealed, Static, Virtual } from './access-modifier';
import { Class } from './class';
import { summary, xmlize } from './doc-comments';
import { dotnet } from './dotnet';
import { Expression, toExpression, valueOf } from './expression';
import { Parameter } from './parameter';
import { StatementPossibilities, Statements } from './statements/statement';
import { TypeDeclaration } from './type-declaration';

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
  public returnsDescription: string = '';
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
    if (!this.returnsDescription.trim()) {
      this.returnsDescription = `FIXME: Method ${name} <returns> is MISSING DESCRIPTION`;
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

  protected get returnsDocumentation(): string {
    if (this.returnType.declaration !== 'void') {
      return docComment(xmlize('returns', this.returnsDescription));
    }
    return '';
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.returnsDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.declaration} ${this.name}(${parameterDeclaration})
`.slim();
  }

  public get interfaceDeclaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.returnsDocumentation}
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
    this.access = Access.Default;
    this.apply(objectIntializer);
  }

  public get declaration(): string {
    const parameterDeclaration = this.parameters.joinWith(p => p.declaration, CommaChar);
    return `
${this.summaryDocumentation}
${this.parameterDocumentation}
${this.returnsDocumentation}
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
${this.returnsDocumentation}
${this.new}${this.access} ${this.static} ${this.virtual} ${this.sealed} ${this.override} ${this.abstract} ${this.extern} ${this.async} ${this.returnType.declaration} ${this.name}(${parameterDeclaration}) => ${valueOf(this.expression)}
`.slim();
  }

  public get implementation(): string {
    return `${this.declaration};`.slim();
  }
}
