import { intersect } from '#common/intersect';
import { Expression, LiteralExpression } from '#csharp/code-dom/expression';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { Property } from '#csharp/code-dom/property';
import { TypeDeclaration } from './type-declaration';

export class LibraryType implements TypeDeclaration {
  private get fullName() {
    return this.namespace.fullName ? `${this.namespace.fullName}.${this.name}` : this.name;
  }
  private namespace: Namespace;
  constructor(namespace: Namespace | string, private name: string) {
    this.namespace = typeof (namespace) === 'string' ? new Namespace(namespace) : namespace;
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

export const None: Namespace = new Namespace('');
const system: Namespace = new Namespace('System');
const threading = new Namespace('Threading', system);
const tasks = new Namespace('Tasks', threading);
const action = new LibraryType(system, 'Action');
const collections = new Namespace('Collections', system);
const generic = new Namespace('Generic', collections);
const net = new Namespace('Net', system);
const http = new Namespace('Http', net);
const task = new LibraryType(tasks, 'Task');

export const System = intersect(system, {
  Threading: intersect(threading, {
    CancellationToken: new LibraryType(threading, 'CancellationToken'),
    CancellationTokenSource: new LibraryType(threading, 'CancellationTokenSource'),

    Tasks: intersect(tasks, {
      Task(taskType?: TypeDeclaration): TypeDeclaration {
        return taskType ? new LibraryType(tasks, `Task<${taskType.declaration}>`) : task;
      }
    })

  }),
  DateTime: new LibraryType(system, 'DateTime'),
  EventArgs: new LibraryType(system, 'EventArgs'),
  Exception: new LibraryType(system, 'Exception'),
  AggregateException: new LibraryType(system, 'AggregateException'),
  TimeSpan: new LibraryType(system, 'TimeSpan'),
  Type: new LibraryType(system, 'Type'),
  IFormatProvider: new LibraryType(system, 'IFormatProvider'),
  Net: intersect(net, {
    Http: intersect(http, {
      HttpRequestMessage: new LibraryType(http, 'HttpRequestMessage'),
      HttpResponseMessage: new LibraryType(http, 'HttpResponseMessage'),
    })
  }),
  Collections: intersect(collections, {
    Hashtable: new LibraryType(collections, "Hashtable"),
    Generic: intersect(generic, {
      Dictionary(keyType: TypeDeclaration, valueType: TypeDeclaration): TypeDeclaration {
        return new LibraryType(generic, `Dictionary<${keyType.declaration},${valueType.declaration}>`);
      },
      KeyValuePair(keyType: TypeDeclaration, valueType: TypeDeclaration): TypeDeclaration {
        return new LibraryType(generic, `KeyValuePair<${keyType.declaration},${valueType.declaration}>`);
      },
      IEnumerable(type: TypeDeclaration): TypeDeclaration {
        return new LibraryType(generic, `IEnumerable<${type.declaration}>`);
      }
    })
  }),
  Action(...actionParameters: Array<TypeDeclaration>): TypeDeclaration {
    return actionParameters.length === 0 ? action : new LibraryType(system, `Action<${actionParameters.joinWith(each => each.declaration)}>`);
  },

  Func(...funcParameters: Array<TypeDeclaration>): TypeDeclaration {
    return new LibraryType(system, `Func<${funcParameters.joinWith(each => each.declaration)}>`);
  }
});

export const Unknown: TypeDeclaration = new LibraryType(None, 'null');
export const ToDo: TypeDeclaration = new LibraryType(None, 'null');
export const Void: TypeDeclaration = new LibraryType(None, 'void');
export const String: TypeDeclaration = new LibraryType(None, 'string');
export const Int: TypeDeclaration = new LibraryType(None, 'int');
export const Long: TypeDeclaration = new LibraryType(None, 'long');
export const Double: TypeDeclaration = new LibraryType(None, 'double');
export const Float: TypeDeclaration = new LibraryType(None, 'float');
export const Binary: TypeDeclaration = new LibraryType(None, 'byte[]');
export const Bool: TypeDeclaration = new LibraryType(None, 'bool');
export const Object: TypeDeclaration = new LibraryType(None, 'object');
export const Dynamic: TypeDeclaration = new LibraryType(None, 'dynamic');
export const ThisObject: TypeDeclaration = new LibraryType(None, 'this object');
export const Var: TypeDeclaration = new LibraryType(None, 'var');

export const True = new LiteralExpression('true');
export const False = new LiteralExpression('false');

// export const Date: TypeDeclaration = new LibraryType(System, 'DateTime');
// export const Duration: TypeDeclaration = new LibraryType(System, 'TimeSpan');

export const Null = new LiteralExpression('null');
export const This = new LiteralExpression('this');
