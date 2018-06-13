import { NewResponse, ParameterLocation } from '#common/code-model/http-operation';
import { items, length, values } from '#common/dictionary';
import { EOL } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Expression } from '#csharp/code-dom/expression';
import { Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Parameter } from '#csharp/code-dom/parameter';
import { Case, DefaultCase, TerminalDefaultCase } from '#csharp/code-dom/statements/case';
import { Finally } from '#csharp/code-dom/statements/finally';
import { If } from '#csharp/code-dom/statements/if';
import { Statement } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Try } from '#csharp/code-dom/statements/try';
import { Using } from '#csharp/code-dom/statements/using';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { HttpOperation, Schema } from '#csharp/lowlevel-generator/code-model';
import { State } from '../generator';
import { CallbackParameter, OperationBodyParameter, OperationParameter } from '../operation/parameter';

export class OperationMethod extends Method {
  public methodParameters: Array<OperationParameter>;
  public bodyParameter?: OperationBodyParameter;
  public listenerParameter: Parameter;
  public senderParameter: Parameter;
  public callbacks = new Array<CallbackParameter>();

  constructor(protected parent: Class, public operation: HttpOperation, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(operation.details.csharp.name, dotnet.System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.async = Modifier.Async;

    // add parameters
    this.methodParameters = this.operation.parameters.map((value, index) => <OperationParameter>this.addParameter(new OperationParameter(this, value, this.state.path('parameters', index))));

    this.description = this.operation.details.csharp.description;

    // add body paramter
    // let bodyParameter: OperationBodyParameter;

    if (this.operation.requestBody) {
      const appjson = this.operation.requestBody.content['application/json'];
      if (appjson && appjson.schema) {

        this.bodyParameter = new OperationBodyParameter(this, 'body', this.operation.requestBody.description || '', appjson.schema, this.operation.requestBody.required, this.state.path('requestBody'));
        this.addParameter(this.bodyParameter);
      }
    }

    for (const { key: responseCode, value: responses } of items(this.operation.responses_new)) {
      for (const response of values(responses)) {
        const responseType = response.schema ? state.project.modelsNamespace.resolveTypeDeclaration(<Schema>response.schema, true, state) : null;
        const pp = new CallbackParameter(this, response.details.csharp.name, responseType, null, this.state);
        this.addParameter(pp);
        this.callbacks.push(pp);
      }
    }

    // add eventhandler parameter
    this.listenerParameter = this.addParameter(new Parameter('listener', ClientRuntime.IEventListener));

    // add optional parameter for sender
    this.senderParameter = this.addParameter(new Parameter('sender', ClientRuntime.ISendAsync));

    // todo: parameterized uris
    let baseUrl = `${this.operation.servers[0].url}`;
    baseUrl = baseUrl.endsWith('/') ? baseUrl : `${baseUrl}/`;

    let path = this.operation.path;

    const headerParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Header);
    const pathParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Path);
    const queryParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Query);
    const cookieParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Cookie);

    for (const pp of pathParams) {
      path = path.replace(`{${pp.param.name}}`, `{System.Uri.EscapeDataString(${pp.use})}`);
    }
    const cb = this.callbacks;
    const bp = this.bodyParameter;
    // add method implementation...
    const $this = this;
    this.add(function* () {
      const eventListener = new EventListener($this.listenerParameter);
      yield `// should we call validation?`;
      yield EOL;

      yield `// construct URL`;
      yield `var _url = $"${baseUrl}${path}${queryParams.length > 0 ? '?' : ''}${queryParams.joinWith(pp => `${pp.param.name}={System.Uri.EscapeDataString(${pp.use})}`, '&')}";`;
      yield eventListener.signal(ClientRuntime.Events.URLCreated, `_url`);
      yield EOL;

      yield `// generate request object `;
      yield `var request =  new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${$this.operation.method.capitalize()}, _url);`;
      yield eventListener.signal(ClientRuntime.Events.RequestCreated, `_url`);
      yield EOL;

      if (headerParams.length > 0) {
        yield `// add headers parameters`;
        for (const hp of headerParams) {
          yield If({ value: `null != ${hp.name}` }, `request.Headers.Add( "${hp.param.name}", ${hp.name});`);
        }
        yield EOL;
      }
      yield eventListener.signal(ClientRuntime.Events.HeaderParametersAdded, `_url`);

      if (bp) {
        yield `// set body content`;
        yield `request.Content = new System.Net.Http.StringContent( null != ${bp.use} ? ${bp.use}.ToJson(null) : "{}", System.Text.Encoding.UTF8);`;
        yield `request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");`;
        yield eventListener.signal(ClientRuntime.Events.BodyContentSet, `_url`);
      }

      yield `// make the call `;
      yield `await this.${$this.name}_Call(request,${cb.joinWith(each => each.use, ',')},${$this.listenerParameter.use},${$this.senderParameter.use});`;

    });

  }

}

export class EventListener {
  constructor(protected expression: Expression) {
  }

  signal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    return new FireEvent(this.expression, eventName.value, additionalParameters);
  }
  syncSignal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    return new SyncFireEvent(this.expression, eventName.value, additionalParameters);
  }
}

export class FireEvent implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `await ${this.expression.value}.Signal(${this.eventName}${additionalParameters});`;
  }
}

export class SyncFireEvent implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `${this.expression.value}.Signal(${this.eventName}${additionalParameters}).Wait();`;
  }
}

export class CallMethod extends Method {
  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.csharp.name}_Call`, dotnet.System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;
    const $this = this;
    // add parameters
    // request, listener, sender
    const reqParameter = this.addParameter(new Parameter('request', dotnet.System.Net.Http.HttpRequestMessage));
    opMethod.callbacks.map(each => this.addParameter(each));
    this.addParameter(opMethod.listenerParameter);
    this.addParameter(opMethod.senderParameter);

    // add statements to this method
    this.add(function* () {
      const eventListener = new EventListener(opMethod.listenerParameter);

      // yield  Using(`var _request = new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${opMethod.operation.method.capitalize()}, "http://wherever/...")`, function* () {
      yield Using(`${reqParameter.use}`, function* () {


        yield `System.Net.Http.HttpResponseMessage _response = null;`;
        yield Try(function* () {
          // try statements
          yield eventListener.signal(ClientRuntime.Events.BeforeCall, reqParameter.use);
          yield `_response = await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use},  ${opMethod.listenerParameter.value});`;
          yield eventListener.signal(ClientRuntime.Events.ResponseCreated, '_response');
          yield `var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();`;

          // add response handlers
          yield Switch({ value: `_response.StatusCode` }, function* () {
            const i = 0;
            for (const { key: responseCode, value: responses } of items(opMethod.operation.responses_new)) {
              if (responseCode !== 'default') {
                yield Case(`(System.Net.HttpStatusCode)${responseCode}`, $this.responsesEmitter($this, opMethod, responses, eventListener));
              } else {
                yield DefaultCase($this.responsesEmitter($this, opMethod, responses, eventListener));
              }
            }

            /*
            for (const eachResponse of opMethod.responseMatrix) {
              if (eachResponse.responseCode !== 'default') {
                // each response
                yield Case(`(System.Net.HttpStatusCode)${eachResponse.responseCode}`, function* () {
                  yield `// on ${eachResponse.responseCode} ... `;

                  for (const variant of eachResponse.responses) {
                    if (eachResponse.responses.length > 1) {
                      yield If({ value: `${variant.mimeType.joinWith(eee => `_contentType == "${eee}"`, " || ")}` }, function* () {
                        // yield `if( ${variant.mimeType.joinWith(eee => `_contentType == "${eee}"`, " || ")} )`
                        // yield '{'
                        yield `${indent(variant.callResponder)}`;
                        // yield '}'
                      });
                    } else {
                      yield variant.callResponder;
                    }
                  }

                  yield EOL;
                });
              } else {
                yield DefaultCase(function* () {
                  yield "// on default ... ";
                  yield EOL;
                });
              }
            }
            */

            // missing default response?
            if (!opMethod.operation.responses_new.default) {
              // if no default, we need one that handles the rest of the stuff.
              yield TerminalDefaultCase(function* () {
                yield `throw new ${ClientRuntime.fullName}.UndeclaredResponseException(_response.StatusCode);`;
              });
            }
          });
        });

        yield Finally(function* () {
          yield '// finally statements';
          yield eventListener.signal(ClientRuntime.Events.Finally, 'request', '_response');
          yield `_response?.Dispose();`;
        });
      });
    });
  }

  private *responsesEmitter($this: CallMethod, opMethod: OperationMethod, responses: Array<NewResponse>, eventListener: EventListener) {
    for (const eachResponse of values(responses)) {
      const mimetype = eachResponse.mimeTypes.length > 0 ? eachResponse.mimeTypes[0] : '';
      const callbackParameter = <CallbackParameter>values(opMethod.callbacks).linq.first(each => each.name === eachResponse.details.csharp.name);
      if (length(responses) > 1) {
        // multiple mimetypes per response code.
        yield `// on ${eachResponse.mimeTypes.join('/')} ... `;
        yield If({ value: `${eachResponse.mimeTypes.joinWith(eee => `_contentType == "${eee}"`, ' || ')}` }, function* () {
          yield eventListener.signal(ClientRuntime.Events.BeforeResponseDispatch, '_response');
          yield $this.responseHandler(mimetype, eachResponse, callbackParameter);
        });
      } else {
        // all mimeTypes per for this response code.
        yield eventListener.signal(ClientRuntime.Events.BeforeResponseDispatch, '_response');
        yield $this.responseHandler(mimetype, eachResponse, callbackParameter);
      }
    }
  }

  private responseHandler(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {
    switch (mimetype) {
      // figure out the deserializor to use for this content type.
      case 'application/json':
      case 'text/json':

        return `await ${eachResponse.details.csharp.name}( ${callbackParameter.responseConstructorForJsonBody}{ RequestMessage = request,ResponseMessage = _response }); `;

      case 'application/xml':
        return `await ${eachResponse.details.csharp.name}( ${callbackParameter.responseConstructorForXmlBody}{ RequestMessage = request,ResponseMessage = _response }); `;

      default:
        // hmm. not a supported serialization type.
        // do we handle this like a stream response?
        return `await ${eachResponse.details.csharp.name}(new ${ClientRuntime.fullName}.Response(){ RequestMessage = request,ResponseMessage = _response }); `;
    }
  }

}

export class ValidationMethod extends Method {

  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.csharp.name}_Validate`, dotnet.System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;

    // add the method parameters
    for (const parameter of opMethod.methodParameters) {
      this.addParameter(parameter);
    }

    if (opMethod.bodyParameter) {
      this.addParameter(opMethod.bodyParameter);
    }

    this.addParameter(opMethod.listenerParameter);

    // add statements to this method
    this.add(function* () {
      for (const parameter of opMethod.methodParameters) {
        // spit out parameter validation
        yield parameter.validatePresenceStatement;
        yield parameter.validationStatement;
      }

      // spit out body parameter validation too
      if (opMethod.bodyParameter) {
        yield opMethod.bodyParameter.validatePresenceStatement;
        yield opMethod.bodyParameter.validationStatement;
      }
    });
  }
}
