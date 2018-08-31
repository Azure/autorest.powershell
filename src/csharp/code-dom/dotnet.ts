import { Dictionary } from '#common/dictionary';
import { intersect } from '#common/intersect';
import { Expression, ExpressionOrLiteral, LiteralExpression, toExpression, valueOf } from '#csharp/code-dom/expression';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { Property } from '#csharp/code-dom/property';
import { TypeDeclaration } from './type-declaration';
import { Text } from '#common/file-generator';

export class ClassType implements TypeDeclaration {
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

  public new(...parameters: Array<ExpressionOrLiteral>): Expression {
    return toExpression(`new ${this.fullName}(${parameters.joinWith(valueOf)})`);
  }

  public Cast(expression: ExpressionOrLiteral) {
    return toExpression(`(${this.declaration})${expression}`);
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
const text = new Namespace('Text', system);
const tasks = new Namespace('Tasks', threading);
const action = new ClassType(system, 'Action');
const collections = new Namespace('Collections', system);
const generic = new Namespace('Generic', collections);
const net = new Namespace('Net', system);
const io = new Namespace('IO', system);
const http = new Namespace('Http', net);
const headers = new Namespace('Headers', http);
const task = new ClassType(tasks, 'Task');
const encoding = new ClassType(text, 'Encoding');

const xml = new Namespace('Xml', system);
const xmllinq = new Namespace('Linq', xml);
const stringClass = new ClassType(system, 'String');

export const System = intersect(system, {
  Threading: intersect(threading, {
    CancellationToken: new ClassType(threading, 'CancellationToken'),
    CancellationTokenSource: new ClassType(threading, 'CancellationTokenSource'),

    Tasks: intersect(tasks, {
      Task(taskType?: TypeDeclaration): TypeDeclaration {
        return taskType ? new ClassType(tasks, `Task<${taskType.declaration}>`) : task;
      }
    })
  }),
  String: intersect(stringClass, {
    Empty: new LiteralExpression('System.String.Empty'),
    IsNullOrEmpty: (expression: ExpressionOrLiteral) => toExpression(`${System.String}.IsNullOrEmpty(${toExpression(expression)})`),
    IsNullOrWhitespace: (expression: ExpressionOrLiteral) => toExpression(`${System.String}.IsNullOrWhitespace(${toExpression(expression)})`),
  }),
  DateTime: new ClassType(system, 'DateTime'),
  EventArgs: new ClassType(system, 'EventArgs'),
  Exception: new ClassType(system, 'Exception'),
  AggregateException: new ClassType(system, 'AggregateException'),
  TimeSpan: new ClassType(system, 'TimeSpan'),
  Type: new ClassType(system, 'Type'),
  Uri: new ClassType(system, 'Uri'),
  IFormatProvider: new ClassType(system, 'IFormatProvider'),
  Xml: intersect(xml, {
    Linq: intersect(xmllinq, {
      XElement: new ClassType(xmllinq, 'XElement'),
      XAttribute: new ClassType(xmllinq, 'XAttribute')
    })
  }),
  IO: intersect(io, {
    Stream: new ClassType(io, 'Stream')
  }),
  Text: intersect(text, {
    Encoding: intersect(encoding, {
      UTF8: new LiteralExpression(`${encoding.declaration}.UTF8`)
    })
  }),
  Net: intersect(net, {
    Http: intersect(http, {
      HttpRequestMessage: new ClassType(http, 'HttpRequestMessage'),
      HttpResponseMessage: new ClassType(http, 'HttpResponseMessage'),
      Headers: intersect(headers, {
        HttpHeaders: new ClassType(headers, 'HttpHeaders'),
        HttpResponseHeaders: new ClassType(headers, 'HttpResponseHeaders'),
      }),
      StringContent: new ClassType(http, 'StringContent'),
    }),
    HttpStatusCode: intersect(new ClassType(net, 'HttpStatusCode'), <Dictionary<LiteralExpression> & Index<LiteralExpression>>{
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
    Hashtable: new ClassType(collections, 'Hashtable'),
    Generic: intersect(generic, {
      Dictionary(keyType: TypeDeclaration, valueType: TypeDeclaration): TypeDeclaration {
        return new ClassType(generic, `Dictionary<${keyType.declaration},${valueType.declaration}>`);
      },
      KeyValuePair(keyType: TypeDeclaration, valueType: TypeDeclaration): TypeDeclaration {
        return new ClassType(generic, `KeyValuePair<${keyType.declaration},${valueType.declaration}>`);
      },
      IEnumerable(type: TypeDeclaration): TypeDeclaration {
        return new ClassType(generic, `IEnumerable<${type.declaration}>`);
      }
    })
  }),
  Action(...actionParameters: Array<TypeDeclaration>): TypeDeclaration {
    return actionParameters.length === 0 ? action : new ClassType(system, `Action<${actionParameters.filter(each => each.declaration).joinWith(each => each.declaration)}>`);
  },

  Func(...funcParameters: Array<TypeDeclaration>): TypeDeclaration {
    return new ClassType(system, `Func<${funcParameters.joinWith(each => each.declaration)}>`);
  }
});

export const dotnet = {
  Unknown: new ClassType(None, 'null'),
  ToDo: new ClassType(None, 'null'),
  Void: new ClassType(None, 'void'),
  String: new ClassType(None, 'string'),
  Int: new ClassType(None, 'int'),
  Long: new ClassType(None, 'long'),
  Double: new ClassType(None, 'double'),
  Float: new ClassType(None, 'float'),
  Binary: new ClassType(None, 'byte[]'),
  Bool: new ClassType(None, 'bool'),
  Object: new ClassType(None, 'object'),
  Dynamic: new ClassType(None, 'dynamic'),
  ThisObject: new ClassType(None, 'this object'),
  Var: new ClassType(None, 'var'),
  True: new LiteralExpression('true'),
  False: new LiteralExpression('false'),
  Null: new LiteralExpression('null'),
  This: new LiteralExpression('this'),
};
