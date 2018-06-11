import { LiteralExpression, Expression } from '#csharp/code-dom/expression';
import { TypeDeclaration } from './type-declaration';
import { Namespace } from '#csharp/code-dom/namespace';
import { Method } from '#csharp/code-dom/method';
import { Class } from '#csharp/code-dom/class';
import { Property } from '#csharp/code-dom/property';
import { Parameter } from '#csharp/code-dom/parameter';

export class LibraryType implements TypeDeclaration {
  constructor(private fullName: string) {
  }

  public get declaration(): string {
    return `${this.fullName}`;
  }

  public toString(): string {
    return this.declaration;
  }

  public newInstance(...parameters: Array<Expression>): Expression {
    return { value: `new ${this.fullName}(${parameters.joinWith(each => each.value)})` };
  }
}

export class EnumType implements TypeDeclaration {
  constructor(private namespace: Namespace, private typeName: string) {
  }

  public get declaration(): string {
    return `${this.namespace}.${this.typeName}`;
  }

  public member(enumMember: string): Expression {
    return new LiteralExpression(`${this.declaration}.${enumMember}`);
  }

  public get definition(): string {
    return ``;
  }

  public toString(): string {
    return this.declaration;
  }

  public newProperty(name: string, objectInitializer?: Partial<Property>): Property {
    return new Property(name, this, objectInitializer);
  }
  public newParameter(name: string, objectInitializer?: Partial<Parameter>): Parameter {
    return new Parameter(name, this, objectInitializer);
  }

  public withMembers<T>(): T & EnumType {
    const $this = this;
    return <T & EnumType><any>new Proxy($this, {
      get(target, prop, receiver) {
        // return a property if there is one for this.
        if ((<any>target)[prop]) {
          return (<any>target)[prop];
        }
        return $this.member(prop.toString());
      }
    });
  }
}


export const Unknown: TypeDeclaration = new LibraryType('null');
export const ToDo: TypeDeclaration = new LibraryType('null');
export const Void: TypeDeclaration = new LibraryType('void');
export const String: TypeDeclaration = new LibraryType('string');
export const Int: TypeDeclaration = new LibraryType('int');
export const Long: TypeDeclaration = new LibraryType('long');
export const Double: TypeDeclaration = new LibraryType('double');
export const Float: TypeDeclaration = new LibraryType('float');
export const Date: TypeDeclaration = new LibraryType('DateTime');
export const Duration: TypeDeclaration = new LibraryType('TimeSpan');
export const Binary: TypeDeclaration = new LibraryType('byte[]');
export const Bool: TypeDeclaration = new LibraryType('bool');
export const Object: TypeDeclaration = new LibraryType('object');
export const ThisObject: TypeDeclaration = new LibraryType('this object');
export const Var: TypeDeclaration = new LibraryType('var');
export const Null = new LiteralExpression('null');
export const This = new LiteralExpression('this');

const task: TypeDeclaration = new LibraryType('System.Threading.Tasks.Task');
const action: TypeDeclaration = new LibraryType('System.Action');

export const TimeSpan: TypeDeclaration = new LibraryType('System.TimeSpan');
export const Exception: TypeDeclaration = new LibraryType('System.Exception');
export const CancellationToken: TypeDeclaration = new LibraryType('System.Threading.CancellationToken');
export const CancellationTokenSource: TypeDeclaration = new LibraryType('System.Threading.CancellationTokenSource');
export const HttpRequestMessage: TypeDeclaration = new LibraryType('System.Net.Http.HttpRequestMessage');
export const HttpResponseMessage: TypeDeclaration = new LibraryType('System.Net.Http.HttpResponseMessage');
export const EventArgs: TypeDeclaration = new LibraryType('System.EventArgs');

export function Func(...funcParameters: Array<TypeDeclaration>): TypeDeclaration {
  return new LibraryType(`System.Func<${funcParameters.joinWith(each => each.declaration)}>`);
}
export function Action(...actionParameters: Array<TypeDeclaration>): TypeDeclaration {
  return actionParameters.length === 0 ? action : new LibraryType(`System.Action<${actionParameters.joinWith(each => each.declaration)}>`);
}

export function Dictionary(keyType: TypeDeclaration, valueType: TypeDeclaration): TypeDeclaration {
  return new LibraryType(`System.Collections.Generic.Dictionary<${keyType.declaration},${valueType.declaration}>`);
}

export function Task(taskType?: TypeDeclaration): TypeDeclaration {
  return taskType ? new LibraryType(`System.Threading.Tasks.Task<${taskType.declaration}>`) : task;
}

export const MyEnum = new EnumType(new Namespace(""), "MyType").withMembers<{ A: Expression; B: Expression; C: Expression }>();
