import { NewResponse, ParameterLocation } from '#common/code-model/http-operation';
import { items, length, values } from '#common/dictionary';
import { camelCase, deconstruct, EOL } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Expression, ExpressionOrLiteral, LiteralExpression, StringExpression, toExpression, valueOf } from '#csharp/code-dom/expression';
import { Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Parameter } from '#csharp/code-dom/parameter';
import { Case, DefaultCase, TerminalCase, TerminalDefaultCase } from '#csharp/code-dom/statements/case';
import { Finally } from '#csharp/code-dom/statements/finally';
import { If, While } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { OneOrMoreStatements, Statement, Statements } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Try } from '#csharp/code-dom/statements/try';
import { Using } from '#csharp/code-dom/statements/using';
import { LocalVariable, Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { HttpOperation, Schema } from '#csharp/lowlevel-generator/code-model';
import { State } from '../generator';
import { CallbackParameter, OperationBodyParameter, OperationParameter } from '../operation/parameter';

import { isMediaTypeJson, isMediaTypeXml, normalizeMediaType, parseMediaType, KnownMediaType, knownMediaType } from '#common/media-types';

export class OperationMethod extends Method {
  public methodParameters: Array<OperationParameter>;
  public bodyParameter?: OperationBodyParameter;
  public contextParameter!: Parameter;
  public senderParameter!: Parameter;
  public resourceUri!: Parameter;
  public callbacks = new Array<CallbackParameter>();

  constructor(protected parent: Class, public operation: HttpOperation, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(operation.details.csharp.name, dotnet.System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.async = Modifier.Async;

    if (this.state.project.storagePipeline) {
      // add resourceUri parameter
      this.resourceUri = this.addParameter(new Parameter('resourceUri', dotnet.System.Uri));

      // add optional parameter for sender
      this.senderParameter = this.addParameter(new Parameter('pipeline', new dotnet.LibraryType('Microsoft.Azure.HttpPipeline', 'Pipeline')));

      // add context parameter
      this.contextParameter = this.addParameter(new Parameter('context', new dotnet.LibraryType('Microsoft.Azure.HttpPipeline', 'CancelContext')));
    }

    // add parameters
    // const [constants, params] = values(this.operation.parameters).linq.bifurcate(each => each.details.csharp.constantValue)
    this.methodParameters = this.operation.parameters.map((value, index) => {
      const p = <OperationParameter>this.addParameter(new OperationParameter(this, value, this.state.path('parameters', index)));
      if (value.details.csharp.constantValue) {
        p.defaultInitializer = `${value.details.csharp.constantValue}`;
      }
      return p;
    });

    this.description = this.operation.details.csharp.description;

    // add body paramter if there should be one.
    if (this.operation.requestBody) {
      // this request does have a request body.
      this.bodyParameter = new OperationBodyParameter(this, 'body', this.operation.requestBody.description || '', <Schema>this.operation.requestBody.schema, this.operation.requestBody.required, this.state.path('requestBody'), {
        mediaType: knownMediaType(this.operation.requestBody.contentType)
      });
      this.addParameter(this.bodyParameter);
    }

    for (const { key: responseCode, value: responses } of items(this.operation.responses_new)) {
      for (const response of values(responses)) {
        const responseType = response.schema ? state.project.modelsNamespace.resolveTypeDeclaration(<Schema>response.schema, true, state) : null;
        const headerType = response.headerSchema ? state.project.modelsNamespace.resolveTypeDeclaration(<Schema>response.headerSchema, true, state) : null;

        if (responseType || headerType) {
          const newCallbackParameter = new CallbackParameter(response.details.csharp.name, responseType, headerType, this.state);
          this.addParameter(newCallbackParameter);
          this.callbacks.push(newCallbackParameter);
        } else {
          // there isn't a response type for the this call. 
          // stream?
        }
      }
    }

    if (!this.state.project.storagePipeline) {
      // add eventhandler parameter
      this.contextParameter = this.addParameter(new Parameter('listener', ClientRuntime.IEventListener));

      // add optional parameter for sender
      this.senderParameter = this.addParameter(new Parameter('sender', ClientRuntime.ISendAsync));
    }
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
      const eventListener = new EventListener($this.contextParameter, $this.state.project.emitSignals);
      // yield `// should we call validation?`;
      yield EOL;

      yield `// construct URL`;
      if (queryParams.length > 0) {
        yield `var queryParameters = new System.Collections.Generic.List<string>();`;
      }
      // yield `var _url = new System.Uri($"${baseUrl}${path}${queryParams.length > 0 ? '?' : ''}${queryParams.joinWith(pp => `${pp.param.name}={System.Uri.EscapeDataString(null == ${pp.use} ? "" : ${pp.use}.ToString() )}`, '&')}");`;
      if ($this.state.project.storagePipeline) {
        if (queryParams.length > 0) {
          for (const qp of queryParams) {
            yield `${qp.serializeToNode(KnownMediaType.QueryParameter, qp.param.name)}`;
          }
          yield `var _tempUrl = ${$this.resourceUri}.AbsoluteUri;`;
          yield If(`queryParameters.Count > 0`, `_tempUrl = $"{_tempUrl}{((_tempUrl.Contains("?") && !_tempUrl.EndsWith("?")) ? "&" : "?")}{string.Join("&", queryParameters)}";`);
          yield `var _url = new System.Uri(_tempUrl);`;
        } else {
          yield `var _url = new System.Uri(${$this.resourceUri}.AbsoluteUri);`;
        }
      } else {
        yield `var _url = new System.Uri("${baseUrl}${path}${queryParams.length > 0 ? '?' : ''}"${queryParams.joinWith(pp => `
        + ${pp.serializeToNode(KnownMediaType.Header, pp.param.name).value}`, '+"&"')});`;
      }
      yield eventListener.signal(ClientRuntime.Events.URLCreated, `_url`);
      yield EOL;

      yield `// generate request object `;
      yield `var request =  new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${$this.operation.method.capitalize()}, _url);`;
      yield eventListener.signal(ClientRuntime.Events.RequestCreated, `_url`);
      yield EOL;

      if (headerParams.length > 0) {
        yield `// add headers parameters`;
        for (const hp of headerParams) {
          yield hp.serializeToContainerMember(KnownMediaType.Header, new LocalVariable('request.Headers', dotnet.Var), hp.param.name);
        }
        yield EOL;
      }
      yield eventListener.signal(ClientRuntime.Events.HeaderParametersAdded, `_url`);

      if (bp) {
        yield `// set body content`;
        yield `request.Content = ${bp.serializeToContent(bp.mediaType)};`;
        yield `request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("${bp.mediaType}");`;
        yield eventListener.signal(ClientRuntime.Events.BodyContentSet, `_url`);
      }

      yield `// make the call `;

      // yield `await this.${$this.name}_Call(request,${cb.joinWith(each => each.use, ',')},${$this.listenerParameter.use},${$this.senderParameter.use});`;

    });
  }

  emitCall(returnFromCall: boolean) {

    // storage will return from the call for download, etc.
    if (returnFromCall) {
      this.returnType = dotnet.System.Threading.Tasks.Task(dotnet.System.Net.Http.HttpResponseMessage);
    }

    if (this.state.project.storagePipeline) {
      if (returnFromCall) {
        this.add(`return await this.${this.name}_Call(${this.senderParameter.use},${this.contextParameter.use},request,${this.callbacks.joinWith(each => each.use, ',')});`);
      } else {
        this.add(`await this.${this.name}_Call(${this.senderParameter.use},${this.contextParameter.use},request,${this.callbacks.joinWith(each => each.use, ',')});`);
      }

    } else {
      this.add(`await this.${this.name}_Call(request,${this.callbacks.joinWith(each => each.use, ',')},${this.contextParameter.use},${this.senderParameter.use});`);
    }


    // remove constant parameters and make them locals instead.
    this.insert(`// Constant Parameters`);
    for (let i = this.parameters.length; i--; i < 0) {
      const p = this.parameters[i];
      if (p && p.defaultInitializer) {
        this.parameters.splice(i, 1);
        this.insert(new LocalVariable(p.name, p.type, { initializer: new StringExpression(p.defaultInitializer) }));
      }
    }
  }
}

export class EventListener {
  constructor(protected expression: Expression, protected emitSignals: boolean) {
  }

  *signalNoCheck(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `await ${this.expression.value}.Signal(${eventName}${params});`;
    }
  }
  *signal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `await ${this.expression.value}.Signal(${eventName}${params}); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw new System.OperationCanceledException(); }`;
    }
  }
  *syncSignal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `${this.expression.value}.Signal(${eventName}${params}).Wait(); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw new System.OperationCanceledException(); }`;
    }

  }
}

export class CallMethod extends Method {
  public returnNull: boolean = false;
  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.csharp.name}_Call`, dotnet.System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;
    const $this = this;
    // add parameters
    // request, listener, sender
    if (this.state.project.storagePipeline) {
      this.addParameter(opMethod.senderParameter);
      this.addParameter(opMethod.contextParameter);
    }
    const reqParameter = this.addParameter(new Parameter('request', dotnet.System.Net.Http.HttpRequestMessage));
    opMethod.callbacks.map(each => this.addParameter(each));
    if (!this.state.project.storagePipeline) {
      this.addParameter(opMethod.contextParameter);
      this.addParameter(opMethod.senderParameter);
    }
    // add statements to this method
    this.add(function* () {
      const eventListener = new EventListener(opMethod.contextParameter, $this.state.project.emitSignals);

      const response = new LocalVariable('_response', dotnet.System.Net.Http.HttpResponseMessage, { initializer: dotnet.Null });
      yield response;
      yield Try(function* () {

        const responder = function* () {
          if ($this.state.project.storagePipeline) {
            // set the response object in the responder.
            yield `_response = response;`;
          }
          // TODO: omit generating _contentType var if it will never be used
          const contentType = new LocalVariable("_contentType", dotnet.Var, { initializer: `_response.Content.Headers.ContentType?.MediaType` });
          yield contentType;


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
        }

        // try statements
        yield eventListener.signal(ClientRuntime.Events.BeforeCall, reqParameter.use);
        if ($this.state.project.storagePipeline) {
          yield `await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use},  ${opMethod.contextParameter.value}.CancellationToken, new Microsoft.Azure.Storage.Shared.DeserializerPolicyFactory(async response =>{
${new Statements(responder()).implementation}
}));`;
        } else {
          yield `${response.value} = await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use},  ${opMethod.contextParameter.value});`;
        }

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
if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
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

        if (!$this.state.project.storagePipeline) {
          yield responder();
        }



      });


      yield Finally(function* () {
        yield '// finally statements';
        yield eventListener.signalNoCheck(ClientRuntime.Events.Finally, 'request', '_response');
        yield `_response?.Dispose();`;
        yield `${reqParameter.use}?.Dispose();`;
      });

      if ($this.returnNull) {
        yield Return('result');
        $this.insert(new LocalVariable('result', dotnet.System.Net.Http.HttpResponseMessage, { initializer: dotnet.Null }));
      }
    });

    this.opMethod.emitCall($this.returnNull);
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
    if (length(responses) > 1) {
      yield Switch(`_contentType`, function* () {
        for (const eachResponse of values(responses)) {
          const mimetype = eachResponse.mimeTypes.length > 0 ? eachResponse.mimeTypes[0] : '';
          const callbackParameter = <CallbackParameter>values(opMethod.callbacks).linq.first(each => each.name === eachResponse.details.csharp.name);

          let count = length(eachResponse.mimeTypes);
          for (const mt of values(eachResponse.mimeTypes)) {
            count--;
            const mediaType = normalizeMediaType(mt);
            if (mediaType) {
              if (count === 0) {
                yield Case(new StringExpression(mediaType).toString(), $this.responseHandler(mimetype, eachResponse, callbackParameter));
              } else {
                yield TerminalCase(new StringExpression(mediaType).toString(), ``);
              }
            }
          }
        }
      });
    } else {
      const response = responses[0];
      const callbackParameter = <CallbackParameter>values(opMethod.callbacks).linq.first(each => each.name === response.details.csharp.name)
      // all mimeTypes per for this response code.
      yield eventListener.signal(ClientRuntime.Events.BeforeResponseDispatch, '_response');
      yield $this.responseHandler(response.mimeTypes[0], response, callbackParameter);
    }
  }

  private *responseHandler(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {

    if (callbackParameter) {
      const headerClassType = callbackParameter.headerType && callbackParameter.headerType.schema.details.csharp.classImplementation ? callbackParameter.headerType.schema.details.csharp.classImplementation.fullName : "";
      const contentDeserialize = callbackParameter.responseType ?
        callbackParameter.responseType.deserializeFromString(knownMediaType(mimetype), toExpression(`await _response.Content.ReadAsStringAsync()`), toExpression('null')) :
        null;

      if (contentDeserialize) {
        // we have a content deserializer
        if (this.state.project.storagePipeline) {
          if (callbackParameter.headerType) {
            yield `${eachResponse.details.csharp.name}(_response, (${contentDeserialize}), new ${headerClassType}().ReadHeaders(_response.Headers));`;
          } else {
            yield `${eachResponse.details.csharp.name}(_response, (${contentDeserialize}));`;
          }
          return;
        } else {
          yield `await ${eachResponse.details.csharp.name}( request, _response, ${contentDeserialize});`;
          return;
        }
      }

      if (parseMediaType(mimetype)) {
        // this media type isn't directly supported by deserialization
        // we can return a stream to the consumer instead
        if (this.state.project.storagePipeline) {
          // when we're using the storage pipeline model
          // we're going to return the response.

          if (callbackParameter.headerType) {
            yield `// call back with the deserialized header object before we give the whole response back`
            yield `${eachResponse.details.csharp.name}(_response, new ${headerClassType}().ReadHeaders(_response.Headers));`;
          }


          // switch the response type.
          this.returnType = dotnet.System.Threading.Tasks.Task(dotnet.System.Net.Http.HttpResponseMessage);
          // const result = new LocalVariable('result', dotnet.Var, { initializer: '_response' });
          yield `result = _response;`;
          yield `_response = null; // ensure that it's not disposed in finally`;
          // yield Return(result);

          // make sure this method returns null at the end
          this.returnNull = true;
          /*
                    // oh, and let's remove the parameter that we would have used
                    for (const ppp of [this.parameters, this.opMethod.parameters, this.opMethod.callbacks]) {
                      ppp.find((p, i, a) => {
                        if (p && p.name === eachResponse.details.csharp.name) {
                          a.splice(i, 1);
                        }
                        return false;
                      });
                    }
          */

          return;
        }

        yield `/* not deserializing ${mimetype} */`;
        return;

      } else {
        // oh, we don't actually have a body response at all. 
        // header content should be deserialized into the appropriate type if possible. 

        if (callbackParameter.headerType) {
          yield `// call back with the deserialized header object`
          yield `${eachResponse.details.csharp.name}(_response, new ${headerClassType}().ReadHeaders(_response.Headers));`;
        } else {
          yield `/* no body or header response */`;
        }
        return;
      }
    }
    // hmm. not a supported serialization type.
    // do we handle this like a stream response?
    //return `await ${eachResponse.details.csharp.name}(new ${ClientRuntime.fullName}.Response(){ RequestMessage = request,ResponseMessage = _response }); `;
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

    this.addParameter(opMethod.contextParameter);

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
