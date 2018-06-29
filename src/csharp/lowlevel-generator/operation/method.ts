import { NewResponse, ParameterLocation } from '#common/code-model/http-operation';
import { items, length, values } from '#common/dictionary';
import { camelCase, deconstruct, EOL } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Expression, LiteralExpression, valueOf, ExpressionOrLiteral, StringExpression } from '#csharp/code-dom/expression';
import { Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Parameter } from '#csharp/code-dom/parameter';
import { Case, DefaultCase, TerminalDefaultCase } from '#csharp/code-dom/statements/case';
import { Finally } from '#csharp/code-dom/statements/finally';
import { If, While } from '#csharp/code-dom/statements/if';
import { Statement } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Try } from '#csharp/code-dom/statements/try';
import { Using } from '#csharp/code-dom/statements/using';
import { LocalVariable, Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { HttpOperation, Schema } from '#csharp/lowlevel-generator/code-model';
import { State } from '../generator';
import { CallbackParameter, OperationBodyParameter, OperationParameter } from '../operation/parameter';
import { isStringLiteral } from 'typescript';

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
      path = path.replace(`{${pp.param.name}}`, `{System.Uri.EscapeDataString(null == ${pp.use} ? "" : ${pp.use}.ToString() )}`);
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
      yield `var _url = $"${baseUrl}${path}${queryParams.length > 0 ? '?' : ''}${queryParams.joinWith(pp => `${pp.param.name}={System.Uri.EscapeDataString(null == ${pp.use} ? "" : ${pp.use}.ToString() )}`, '&')}";`;
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

  signalNoCheck(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    return new FireEventNoCheck(this.expression, eventName.value, additionalParameters);
  }
  signal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    return new FireEvent(this.expression, eventName.value, additionalParameters);
  }
  syncSignal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    return new SyncFireEvent(this.expression, eventName.value, additionalParameters);
  }
}

export class FireEventNoCheck implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `await ${this.expression.value}.Signal(${this.eventName}${additionalParameters});`;
  }
}

export class FireEvent implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `await ${this.expression.value}.Signal(${this.eventName}${additionalParameters}); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
  }
}

export class SyncFireEvent implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `${this.expression.value}.Signal(${this.eventName}${additionalParameters}).Wait(); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
  }
}

function GetHeaderValue(header: string, defaultValue?: string): string {
  const v = `_${camelCase([...deconstruct(header), 'values'])}`;
  return `(_response.Headers.TryGetValues("${header}", out var ${v}) ? System.Linq.Enumerable.FirstOrDefault(${v}) : "${defaultValue || ''}")`;
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

      const response = new LocalVariable('_response', dotnet.System.Net.Http.HttpResponseMessage, { initializer: dotnet.Null });
      yield response;
      yield Try(function* () {
        // try statements
        yield eventListener.signal(ClientRuntime.Events.BeforeCall, reqParameter.use);
        yield `${response.value} = await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use},  ${opMethod.listenerParameter.value});`;
        yield eventListener.signal(ClientRuntime.Events.ResponseCreated, response.value);
        const EOL = 'EOL';
        // LRO processing (if appropriate)
        if ($this.opMethod.operation.details.csharp.lro) {
          yield `// this operation supports x-ms-long-running-operation`;
          const originalUri = new LocalVariable('_originalUri', dotnet.Var, { initializer: new LiteralExpression(`${reqParameter.use}.RequestUri.AbsoluteUri`) });
          yield originalUri;
          yield While(new LiteralExpression(`${response.value}.StatusCode == ${dotnet.System.Net.HttpStatusCode[201].value} || ${response.value}.StatusCode == ${dotnet.System.Net.HttpStatusCode[202].value} `), function* () {
            yield EOL;
            yield `// get the delay before polling.`;
            yield If(`!int.TryParse( ${response.invokeMethod('GetFirstHeader', new StringExpression(`RetryAfter`)).value}, out int delay)`, `delay = 30;`);

            yield eventListener.signal(ClientRuntime.Events.DelayBeforePolling, `$"Delaying {delay} seconds before polling."`, response.value);

            yield EOL;
            yield `// start the delay timer (we'll await later...)`;
            const waiting = new LocalVariable('waiting', dotnet.Var, { initializer: new LiteralExpression(`${dotnet.System.Threading.Tasks.Task()}.Delay(delay * 1000, listener.Token )`) });
            yield waiting;

            yield EOL;
            yield `// while we wait, let's grab the headers and get ready to poll. `;
            const asyncOperation = new LocalVariable('asyncOperation', dotnet.Var, { initializer: response.invokeMethod('GetFirstHeader', new StringExpression(`Azure-AsyncOperation`)) });
            yield asyncOperation;
            const location = new LocalVariable('location', dotnet.Var, { initializer: response.invokeMethod('GetFirstHeader', new StringExpression(`Location`)) });
            yield location;

            yield `var _uri = string.IsNullOrEmpty(${asyncOperation.value}) ? string.IsNullOrEmpty(${location.value}) ? ${originalUri.value} : ${location.value} : ${asyncOperation.value};`;

            yield `${reqParameter.use} = ${reqParameter.use}.CloneAndDispose(new System.Uri(_uri), Microsoft.Rest.ClientRuntime.Method.Get);`;

            yield EOL;
            yield `// and let's look at the current response body and see if we have some information we can give back to the listener`;
            const content = new LocalVariable('content', dotnet.Var, { initializer: new LiteralExpression(`${response.value}.Content.ReadAsStringAsync()`) });
            yield content;

            yield `await waiting;`;

            yield EOL;
            yield `// check for cancellation`;
            yield `if( listener.Token.IsCancellationRequested ) { return; }`;

            yield eventListener.signal(ClientRuntime.Events.Polling, `$"Polling {_uri}."`, response.value);

            yield EOL;
            yield `// drop the old response`;
            yield `${response.value}?.Dispose();`;

            yield EOL;
            yield `// make the polling call`;
            yield `${response.value} = await sender.SendAsync(${reqParameter.value},  listener);`;

            yield EOL;
            yield `
if( _response.StatusCode != System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
{
    try {
        // we have a 200, and a should have a provisioning state.
        if( Carbon.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Carbon.Json.JsonObject json)
        {
            var state = json.Property("properties")?.PropertyT<Carbon.Json.JsonString>("provisioningState");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( listener.Token.IsCancellationRequested ) { return; }
            if( state?.ToString() != "Succeeded")
            {
                _response.StatusCode = System.Net.HttpStatusCode.Created;
            }
        }
    } catch {
        // um.. whatever.
    }
}`;

            yield EOL;
            yield '// check for terminal status code'
            yield If(new LiteralExpression(`${response.value}.StatusCode != ${dotnet.System.Net.HttpStatusCode[201].value} && ${response.value}.StatusCode != ${dotnet.System.Net.HttpStatusCode[202].value} `), function* () {
              yield `// we're done polling, do a request on final target?`;
              yield `// declared final-state-via: ${$this.opMethod.operation.details.csharp.lro['final-state-via']}`;
              const fsv = $this.opMethod.operation.details.csharp.lro['final-state-via'];

              switch (fsv) {
                case 'original-uri':
                  // perform a final GET on the original URI.
                  yield $this.finalGet(originalUri, reqParameter, response);
                  break;

                case 'location':
                  // perform a final GET on the uri in Location header
                  yield $this.finalGet(response.invokeMethod('GetFirstHeader', new StringExpression(`Location`)), reqParameter, response);
                  break;

                case 'azure-asyncoperation':
                case 'azure-async-operation':
                  // perform a final GET on the uri in Azure-AsyncOperation header
                  yield $this.finalGet(response.invokeMethod('GetFirstHeader', new StringExpression(`Azure-AsyncOperation`)), reqParameter, response);
                  break;

                default:
                  // depending on the type of request, fall back to the appropriate behavior
                  const finalLocation = new LocalVariable("finalLocation", dotnet.Var, { initializer: response.invokeMethod('GetFirstHeader', new StringExpression(`Location`)) });
                  switch ($this.opMethod.operation.method.toLowerCase()) {
                    case 'post':
                    case 'delete':
                      // if the location header was passed in, we're going to do a get on that.
                      yield `// final get on the the Location header, if present`
                      yield finalLocation;
                      If(`string.IsNullOrWhiteSpace(${finalLocation})`, function* () {
                        yield $this.finalGet(finalLocation, reqParameter, response);
                      });
                      break;
                    case 'patch':
                    case 'put':
                      yield `// final get on the original URI`
                      yield $this.finalGet(originalUri, reqParameter, response);
                      break;
                  }
                  break;
              }
            });
          });
        }

        const contentType = new LocalVariable("_contentType", dotnet.Var, { initializer: `${valueOf(response.invokeMethod('GetFirstHeader', new StringExpression(`Content-Type`)))}.ToLowerInvariant()` });
        yield contentType;
        // yield `var _contentType = (${response.value}.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();`;

        // add response handlers
        yield Switch({ value: `${response.value}.StatusCode` }, function* () {
          const i = 0;
          for (const { key: responseCode, value: responses } of items(opMethod.operation.responses_new)) {
            if (responseCode !== 'default') {
              // will use enum when it can, fall back to casting int when it can't
              yield Case(dotnet.System.Net.HttpStatusCode[responseCode].value || `(${dotnet.System.Net.HttpStatusCode.declaration})${responseCode}`, $this.responsesEmitter($this, opMethod, responses, eventListener));
            } else {
              yield DefaultCase($this.responsesEmitter($this, opMethod, responses, eventListener));
            }
          }

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
        yield eventListener.signalNoCheck(ClientRuntime.Events.Finally, 'request', '_response');
        yield `_response?.Dispose();`;
        yield `${reqParameter.use}?.Dispose();`;
      });
    });
  }

  private *finalGet(finalLocation: ExpressionOrLiteral, reqParameter: Variable, response: Variable) {
    yield reqParameter.assign(`${valueOf(reqParameter)}.CloneAndDispose(new System.Uri(${valueOf(finalLocation)}), Microsoft.Rest.ClientRuntime.Method.Get)`);

    yield EOL;
    yield `// drop the old response`;
    yield `${response.value}?.Dispose();`;

    yield EOL;
    yield `// make the final call`;
    yield response.assign(`await sender.SendAsync(${valueOf(reqParameter)},  listener);`);

    // make sure we're not polling anymore.
    yield 'break;';
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
