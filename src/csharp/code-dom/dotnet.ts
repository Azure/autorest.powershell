import { intersect } from '#common/intersect';
import { Expression, LiteralExpression, valueOf, ExpressionOrLiteral, toExpression } from '#csharp/code-dom/expression';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { Property } from '#csharp/code-dom/property';
import { TypeDeclaration } from './type-declaration';
import { Dictionary } from '#common/dictionary';

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

  public newInstance(...parameters: Array<ExpressionOrLiteral>): Expression {
    return toExpression(`new ${this.fullName}(${parameters.joinWith(each => valueOf(each))})`);
  }
}

export class EnumType implements TypeDeclaration {
  constructor(private namespace: Namespace, private name: string) {
  }

  public get declaration(): string {
    return `${this.namespace}.${this.name}`;
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


export interface Index<T> {
  [key: number]: T;
}

export const None: Namespace = new Namespace('');
const system: Namespace = new Namespace('System');
const threading = new Namespace('Threading', system);
const tasks = new Namespace('Tasks', threading);
const action = new LibraryType(system, 'Action');
const collections = new Namespace('Collections', system);
const generic = new Namespace('Generic', collections);
const net = new Namespace('Net', system);
const io = new Namespace('IO', system);
const http = new Namespace('Http', net);
const headers = new Namespace('Headers', http);
const task = new LibraryType(tasks, 'Task');

const xml = new Namespace('Xml', system);
const xmllinq = new Namespace('Linq', xml);
const stringClass = new LibraryType(system, 'String');


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
  String: intersect(stringClass, {
    Empty: new LiteralExpression("System.String.Empty"),
  }),
  DateTime: new LibraryType(system, 'DateTime'),
  EventArgs: new LibraryType(system, 'EventArgs'),
  Exception: new LibraryType(system, 'Exception'),
  AggregateException: new LibraryType(system, 'AggregateException'),
  TimeSpan: new LibraryType(system, 'TimeSpan'),
  Type: new LibraryType(system, 'Type'),
  Uri: new LibraryType(system, 'Uri'),
  IFormatProvider: new LibraryType(system, 'IFormatProvider'),
  Xml: intersect(xml, {
    Linq: intersect(xmllinq, {
      XElement: new LibraryType(xmllinq, 'XElement'),
      XAttribute: new LibraryType(xmllinq, 'XAttribute')
    })
  }),
  IO: intersect(io, {
    Stream: new LibraryType(io, 'Stream')
  }),
  Net: intersect(net, {
    Http: intersect(http, {
      HttpRequestMessage: new LibraryType(http, 'HttpRequestMessage'),
      HttpResponseMessage: new LibraryType(http, 'HttpResponseMessage'),
      Headers: intersect(headers, {
        HttpHeaders: new LibraryType(headers, 'HttpHeaders'),
        HttpResponseHeaders: new LibraryType(headers, 'HttpResponseHeaders'),
      })
    }),
    HttpStatusCode: intersect(new LibraryType(net, 'HttpStatusCode'), <Dictionary<LiteralExpression> & Index<LiteralExpression>>{
      default: new LiteralExpression(''),
      100: new LiteralExpression('System.Net.HttpStatusCode.Continue'),
      101: new LiteralExpression('System.Net.HttpStatusCode.SwitchingProtocols'),
      200: new LiteralExpression('System.Net.HttpStatusCode.OK'),
      201: new LiteralExpression('System.Net.HttpStatusCode.Created'),
      202: new LiteralExpression('System.Net.HttpStatusCode.Accepted'),
      203: new LiteralExpression('System.Net.HttpStatusCode.NonAuthoritativeInformation'),
      204: new LiteralExpression('System.Net.HttpStatusCode.NoContent'),
      205: new LiteralExpression('System.Net.HttpStatusCode.ResetContent'),
      206: new LiteralExpression('System.Net.HttpStatusCode.PartialContent'),
      300: new LiteralExpression('System.Net.HttpStatusCode.Ambiguous'),
      301: new LiteralExpression('System.Net.HttpStatusCode.Moved'),
      302: new LiteralExpression('System.Net.HttpStatusCode.Redirect'),
      303: new LiteralExpression('System.Net.HttpStatusCode.SeeOther'),
      304: new LiteralExpression('System.Net.HttpStatusCode.NotModified'),
      305: new LiteralExpression('System.Net.HttpStatusCode.UseProxy'),
      306: new LiteralExpression('System.Net.HttpStatusCode.Unused'),
      307: new LiteralExpression('System.Net.HttpStatusCode.TemporaryRedirect'),
      400: new LiteralExpression('System.Net.HttpStatusCode.BadRequest'),
      401: new LiteralExpression('System.Net.HttpStatusCode.Unauthorized'),
      402: new LiteralExpression('System.Net.HttpStatusCode.PaymentRequired'),
      403: new LiteralExpression('System.Net.HttpStatusCode.Forbidden'),
      404: new LiteralExpression('System.Net.HttpStatusCode.NotFound'),
      405: new LiteralExpression('System.Net.HttpStatusCode.MethodNotAllowed'),
      406: new LiteralExpression('System.Net.HttpStatusCode.NotAcceptable'),
      407: new LiteralExpression('System.Net.HttpStatusCode.ProxyAuthenticationRequired'),
      408: new LiteralExpression('System.Net.HttpStatusCode.RequestTimeout'),
      409: new LiteralExpression('System.Net.HttpStatusCode.Conflict'),
      410: new LiteralExpression('System.Net.HttpStatusCode.Gone'),
      411: new LiteralExpression('System.Net.HttpStatusCode.LengthRequired'),
      412: new LiteralExpression('System.Net.HttpStatusCode.PreconditionFailed'),
      413: new LiteralExpression('System.Net.HttpStatusCode.RequestEntityTooLarge'),
      414: new LiteralExpression('System.Net.HttpStatusCode.RequestUriTooLong'),
      415: new LiteralExpression('System.Net.HttpStatusCode.UnsupportedMediaType'),
      416: new LiteralExpression('System.Net.HttpStatusCode.RequestedRangeNotSatisfiable'),
      417: new LiteralExpression('System.Net.HttpStatusCode.ExpectationFailed'),
      426: new LiteralExpression('System.Net.HttpStatusCode.UpgradeRequired'),
      500: new LiteralExpression('System.Net.HttpStatusCode.InternalServerError'),
      501: new LiteralExpression('System.Net.HttpStatusCode.NotImplemented'),
      502: new LiteralExpression('System.Net.HttpStatusCode.BadGateway'),
      503: new LiteralExpression('System.Net.HttpStatusCode.ServiceUnavailable'),
      504: new LiteralExpression('System.Net.HttpStatusCode.GatewayTimeout'),
      505: new LiteralExpression('System.Net.HttpStatusCode.HttpVersionNotSupported')
    }),
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
    return actionParameters.length === 0 ? action : new LibraryType(system, `Action<${actionParameters.filter(each => each.declaration).joinWith(each => each.declaration)}>`);
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

