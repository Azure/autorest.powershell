/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { NewResponse, ParameterLocation } from '@microsoft.azure/autorest.codemodel-v3';
import { items, length, values } from '@microsoft.azure/codegen';
import { EOL } from '@microsoft.azure/codegen';
import { Access, Modifier } from '@microsoft.azure/codegen-csharp';
import { Class } from '@microsoft.azure/codegen-csharp';

import { Expression, ExpressionOrLiteral, LiteralExpression, StringExpression, toExpression, valueOf } from '@microsoft.azure/codegen-csharp';
import { Method } from '@microsoft.azure/codegen-csharp';
import { Parameter } from '@microsoft.azure/codegen-csharp';
import { Case, DefaultCase, TerminalCase, TerminalDefaultCase } from '@microsoft.azure/codegen-csharp';
import { Finally } from '@microsoft.azure/codegen-csharp';
import { If, While } from '@microsoft.azure/codegen-csharp';
import { Return } from '@microsoft.azure/codegen-csharp';
import { OneOrMoreStatements, Statement, Statements } from '@microsoft.azure/codegen-csharp';
import { Switch } from '@microsoft.azure/codegen-csharp';
import { Try } from '@microsoft.azure/codegen-csharp';
import { Using } from '@microsoft.azure/codegen-csharp';
import { Local, LocalVariable, Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { HttpOperation, Schema } from '../code-model';
import { State } from '../generator';
import { CallbackParameter, OperationBodyParameter, OperationParameter } from '../operation/parameter';

import { isMediaTypeJson, isMediaTypeXml, KnownMediaType, knownMediaType, normalizeMediaType, parseMediaType } from '@microsoft.azure/autorest.codemodel-v3';
import { ClassType, dotnet, System } from '@microsoft.azure/codegen-csharp';
import { Ternery } from '@microsoft.azure/codegen-csharp';

export class OperationMethod extends Method {
  public methodParameters: Array<OperationParameter>;
  public bodyParameter?: OperationBodyParameter;
  public contextParameter!: Parameter;
  public senderParameter!: Parameter;
  public resourceUri!: Parameter;
  public callbacks = new Array<CallbackParameter>();

  protected callName: string;

  constructor(protected parent: Class, public operation: HttpOperation, public viaIdentity: boolean, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(viaIdentity ? `${operation.details.csharp.name}ViaIdentity` : operation.details.csharp.name, System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.async = Modifier.Async;
    this.returnsDescription = `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the response is completed.`;
    const $this = this;

    this.callName = `${operation.details.csharp.name}_Call`;
    this.push(Using(`NoSynchronizationContext`, ``));

    // add parameters
    this.methodParameters = [];

    const identity = new Parameter('identity', System.String);
    if (this.viaIdentity) {
      this.addParameter(identity);
    }

    for (var index = 0; index < this.operation.parameters.length; index++) {
      const value = this.operation.parameters[index];

      const p = new OperationParameter(this, value, this.state.path('parameters', index));

      if (value.details.csharp.constantValue) {
        const constTd = state.project.modelsNamespace.resolveTypeDeclaration(value.schema, true, state);
        p.defaultInitializer = constTd.deserializeFromString(KnownMediaType.UriParameter, new StringExpression(`${value.details.csharp.constantValue}`), toExpression(constTd.defaultOfType));
      }

      // don't add path parameters  when we're in identity mode
      if (!this.viaIdentity || value.in !== ParameterLocation.Path) {
        this.addParameter(p);
      } else {
        this.add(function* () {
          yield ``;
        })
      }
      this.methodParameters.push(p);
    }

    this.description = this.operation.details.csharp.description;

    // add body paramter if there should be one.
    if (this.operation.requestBody) {
      // this request does have a request body.
      this.bodyParameter = new OperationBodyParameter(this, 'body', this.operation.requestBody.description || '', <Schema>this.operation.requestBody.schema, this.operation.requestBody.required, this.state.path('requestBody'), {
        mediaType: knownMediaType(this.operation.requestBody.contentType),
        contentType: this.operation.requestBody.contentType
      });
      this.addParameter(this.bodyParameter);
    }

    for (const responses of values(this.operation.responses)) {
      for (const response of values(responses)) {
        const responseType = response.schema ? state.project.modelsNamespace.resolveTypeDeclaration(<Schema>response.schema, true, state) : null;
        const headerType = response.headerSchema ? state.project.modelsNamespace.resolveTypeDeclaration(<Schema>response.headerSchema, true, state) : null;

        const newCallbackParameter = new CallbackParameter(response.details.csharp.name, responseType, headerType, this.state, { description: response.details.csharp.description });
        this.addParameter(newCallbackParameter);
        this.callbacks.push(newCallbackParameter);

      }
    }

    // add eventhandler parameter
    this.contextParameter = this.addParameter(new Parameter('eventListener', ClientRuntime.IEventListener, { description: `an <see cref="${ClientRuntime.IEventListener}" /> instance that will receive events.` }));

    // add optional parameter for sender
    this.senderParameter = this.addParameter(new Parameter('sender', ClientRuntime.ISendAsync, { description: `an instance of an ${ClientRuntime.ISendAsync} pipeline to use to make the request.` }));

    let rx = this.operation.path;
    let url = `${this.operation.baseUrl}${this.operation.path.startsWith('/') ? this.operation.path.substr(1) : this.operation.path}`;


    const serverParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Uri);

    const headerParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Header);
    const pathParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Path);
    const queryParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Query);
    const cookieParams = this.methodParameters.filter(each => each.param.in === ParameterLocation.Cookie);

    // replace any server params in the uri
    for (const pp of serverParams) {
      url = url.replace(`{${pp.param.name}}`, `"
        + ${pp.name}
        + "`);
    }

    for (const pp of pathParams) {
      rx = rx.replace(`{${pp.param.name}}`, `(?<${pp.param.name}>[^/]+)`);

      if (this.viaIdentity) {
        url = url.replace(`{${pp.param.name}}`, `"
        + rest_${pp.name}
        + "`);
      } else {
        url = url.replace(`{${pp.param.name}}`, `"
        + ${pp.typeDeclaration.serializeToNode(KnownMediaType.UriParameter, pp, '', ClientRuntime.SerializationMode.None)}
        + "`);
      }
    }
    rx = `"^${rx}$"`;
    url = url.replace(/\s*\+ ""/gm, '');

    const bp = this.bodyParameter;
    // add method implementation...

    this.add(function* () {
      const eventListener = new EventListener($this.contextParameter, $this.state.project.emitSignals);

      yield EOL;

      let urlV: LocalVariable;

      if ($this.viaIdentity) {
        yield `// verify that Identity format is an exact match for uri`;
        yield EOL;

        const match = Local("_match", `${System.Text.RegularExpressions.Regex.new(rx).value}.Match(${identity.value})`);
        yield match.declarationStatement;
        yield If(`!${match}.Success`, `throw new global::System.Exception("Invalid identity for URI '${$this.operation.path}'");`);
        yield EOL;
        yield `// replace URI parameters with values from identity`
        for (const pp of pathParams) {
          yield `var rest_${pp.name} = ${match.value}.Groups["${pp.param.name}"].Value;`
        }
      }

      yield `// construct URL`;
      urlV = new LocalVariable('_url', dotnet.Var, {
        initializer: System.Uri.new(`(
        "${url}"
        ${queryParams.length > 0 ? '+ "?"' : ''}${queryParams.joinWith(pp => `
        + ${pp.serializeToNode(KnownMediaType.QueryParameter, `${pp.param.name}`, ClientRuntime.SerializationMode.None).value}`, `
        + "&"`
        )}
        ).TrimEnd('?','&')`.replace(/\s*\+ ""/gm, ''))
      });
      yield urlV.declarationStatement;

      yield EOL;

      yield eventListener.signal(ClientRuntime.Events.URLCreated, urlV.value);
      yield EOL;

      yield `// generate request object `;
      yield `var request =  ${System.Net.Http.HttpRequestMessage.new(`${ClientRuntime.fullName}.Method.${$this.operation.method.capitalize()}, ${urlV.value}`)};`;
      yield eventListener.signal(ClientRuntime.Events.RequestCreated, urlV.value);
      yield EOL;

      if (headerParams.length > 0) {
        yield `// add headers parameters`;
        for (const hp of headerParams) {
          if (hp.param.name === 'Content-Length') {
            // content length is set when the request body is set
            continue;
          }
          yield hp.serializeToContainerMember(KnownMediaType.Header, new LocalVariable('request.Headers', dotnet.Var), hp.param.name, ClientRuntime.SerializationMode.None);
        }
        yield EOL;
      }
      yield eventListener.signal(ClientRuntime.Events.HeaderParametersAdded, urlV.value);

      if (bp) {
        yield `// set body content`;
        yield `request.Content = ${bp.serializeToContent(bp.mediaType, ClientRuntime.SerializationMode.None)};`;
        yield `request.Content.Headers.ContentType = ${System.Net.Http.Headers.MediaTypeHeaderValue.Parse(bp.contentType)};`;
        yield eventListener.signal(ClientRuntime.Events.BodyContentSet, urlV.value);
      }

      yield `// make the call `;
    });
  }

  emitCall(returnFromCall: boolean) {

    // storage will return from the call for download, etc.
    if (returnFromCall) {
      this.returnType = System.Threading.Tasks.Task(System.Net.Http.HttpResponseMessage);
    }

    this.add(`await this.${this.callName}(request,${this.callbacks.joinWith(each => each.use, ',')},${this.contextParameter.use},${this.senderParameter.use});`);

    // remove constant parameters and make them locals instead.
    this.insert(`// Constant Parameters`);
    for (let i = this.parameters.length; i--; i < 0) {
      const p = this.parameters[i];
      if (p && p.defaultInitializer) {
        this.parameters.splice(i, 1);
        this.insert(new LocalVariable(p.name, p.type, { initializer: p.defaultInitializer }));
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
  *syncSignalNoCheck(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `${this.expression.value}.Signal(${eventName}${params}).Wait();`;
    }
  }
  *signal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `await ${this.expression.value}.Signal(${eventName}${params}); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw ${System.OperationCanceledException.new()}; }`;
    }
  }
  *syncSignal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = additionalParameters.length > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;
      yield `${this.expression.value}.Signal(${eventName}${params}).Wait(); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw ${System.OperationCanceledException.new()} }`;
    }

  }
}

export class CallMethod extends Method {
  public returnNull: boolean = false;
  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.csharp.name}_Call`, System.Threading.Tasks.Task());
    this.description = `Actual wire call for <see cref="${opMethod.operation.details.csharp.name}" /> method.`;
    this.returnsDescription = opMethod.returnsDescription;

    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;
    this.push(Using(`NoSynchronizationContext`, ``));

    const $this = this;
    // add parameters
    // request, listener, sender
    const reqParameter = this.addParameter(new Parameter('request', System.Net.Http.HttpRequestMessage, { description: `the prepared HttpRequestMessage to send.` }));
    opMethod.callbacks.forEach(each => this.addParameter(each));

    this.addParameter(opMethod.contextParameter);
    this.addParameter(opMethod.senderParameter);

    // add statements to this method
    this.add(function* () {
      const eventListener = new EventListener(opMethod.contextParameter, $this.state.project.emitSignals);

      const response = Local('_response', dotnet.Null, System.Net.Http.HttpResponseMessage);
      yield response;
      yield Try(function* () {

        const responder = function* () {
          // TODO: omit generating _contentType var if it will never be used
          // const contentType = new LocalVariable('_contentType', dotnet.Var, { initializer: `_response.Content.Headers.ContentType?.MediaType` });
          const contentType = Local('_contentType', `${response}.Content.Headers.ContentType?.MediaType`);

          yield contentType;

          // add response handlers
          yield Switch(`${response}.StatusCode`, function* () {
            for (const { key: responseCode, value: responses } of items(opMethod.operation.responses)) {
              if (responseCode !== 'default') {
                // will use enum when it can, fall back to casting int when it can't
                yield Case(System.Net.HttpStatusCode[responseCode] ? System.Net.HttpStatusCode[responseCode].value : `(${System.Net.HttpStatusCode.declaration})${responseCode}`, $this.responsesEmitter($this, opMethod, responses, eventListener));
              } else {
                yield DefaultCase($this.responsesEmitter($this, opMethod, responses, eventListener));
              }
            }

            // missing default response?
            if (!opMethod.operation.responses.default) {
              // if no default, we need one that handles the rest of the stuff.
              yield TerminalDefaultCase(function* () {
                yield `throw new ${ClientRuntime.fullName}.UndeclaredResponseException(_response);`;
              });
            }
          });
        };

        // try statements
        yield eventListener.signal(ClientRuntime.Events.BeforeCall, reqParameter.use);
        yield `${response.value} = await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use}, ${opMethod.contextParameter.value});`;

        yield eventListener.signal(ClientRuntime.Events.ResponseCreated, response.value);
        const EOL = 'EOL';
        // LRO processing (if appropriate)
        if ($this.opMethod.operation.details.csharp.lro) {
          yield `// this operation supports x-ms-long-running-operation`;
          const originalUri = Local('_originalUri', new LiteralExpression(`${reqParameter.use}.RequestUri.AbsoluteUri`));
          yield originalUri;
          yield While(new LiteralExpression(`${response.value}.StatusCode == ${System.Net.HttpStatusCode[201].value} || ${response.value}.StatusCode == ${System.Net.HttpStatusCode[202].value} `), function* () {
            yield EOL;
            yield `// get the delay before polling.`;
            yield If(`!int.TryParse( ${response.invokeMethod('GetFirstHeader', new StringExpression(`RetryAfter`)).value}, out int delay)`, `delay = 30;`);

            yield eventListener.signal(ClientRuntime.Events.DelayBeforePolling, `$"Delaying {delay} seconds before polling."`, response.value);

            yield EOL;
            yield `// start the delay timer (we'll await later...)`;
            const waiting = Local('waiting', new LiteralExpression(`${System.Threading.Tasks.Task()}.Delay(delay * 1000, ${$this.opMethod.contextParameter}.Token )`));
            yield waiting;

            yield EOL;
            yield `// while we wait, let's grab the headers and get ready to poll. `;
            const asyncOperation = Local('asyncOperation', response.invokeMethod('GetFirstHeader', new StringExpression(`Azure-AsyncOperation`)));
            yield asyncOperation;
            const location = Local('location', response.invokeMethod('GetFirstHeader', new StringExpression(`Location`)));
            yield location;

            const uriLocal = Local('_uri', Ternery(
              System.String.IsNullOrEmpty(asyncOperation),
              Ternery(System.String.IsNullOrEmpty(location),
                originalUri,
                location),
              asyncOperation));
            yield uriLocal;

            yield `${reqParameter.use} = ${reqParameter.use}.CloneAndDispose(${System.Uri.new(uriLocal)}, ${ClientRuntime.Method.Get});`;

            yield EOL;
            yield `// and let's look at the current response body and see if we have some information we can give back to the listener`;
            const content = Local('content', new LiteralExpression(`${response.value}.Content.ReadAsStringAsync()`));
            yield content;

            yield `await waiting;`;

            yield EOL;
            yield `// check for cancellation`;
            yield `if( ${$this.opMethod.contextParameter}.Token.IsCancellationRequested ) { return; }`;

            yield eventListener.signal(ClientRuntime.Events.Polling, `$"Polling {${uriLocal}}."`, response.value);

            yield EOL;
            yield `// drop the old response`;
            yield `${response.value}?.Dispose();`;

            yield EOL;
            yield `// make the polling call`;
            yield `${response.value} = await ${opMethod.senderParameter}.SendAsync(${reqParameter.value}, ${opMethod.contextParameter});`;

            yield EOL;
            yield `
if( _response.StatusCode == ${System.Net.HttpStatusCode.OK} && ${System.String.IsNullOrEmpty(`asyncOperation`)})
{
    try {
        // we have a 200, and a should have a provisioning state.
        if( ${ClientRuntime.JsonNode.Parse(toExpression(`await _response.Content.ReadAsStringAsync()`))} is ${ClientRuntime.JsonObject} json)
        {
            var state = json.Property("properties")?.PropertyT<${ClientRuntime.JsonString}>("provisioningState");
            await ${$this.opMethod.contextParameter}.Signal(${ClientRuntime.Events.Polling}, $"Polled {${uriLocal}} provisioning state  {state}.", _response); if( ${$this.opMethod.contextParameter}.Token.IsCancellationRequested ) { return; }
            if( state?.ToString() != "Succeeded")
            {
                _response.StatusCode = ${System.Net.HttpStatusCode.Created};
            }
        }
    } catch {
        // um.. whatever.
    }
}`;

            yield EOL;
            yield '// check for terminal status code';
            yield If(new LiteralExpression(`${response.value}.StatusCode != ${System.Net.HttpStatusCode[201].value} && ${response.value}.StatusCode != ${System.Net.HttpStatusCode[202].value} `), function* () {
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
                  const finalLocation = new LocalVariable('finalLocation', dotnet.Var, { initializer: response.invokeMethod('GetFirstHeader', new StringExpression(`Location`)) });
                  switch ($this.opMethod.operation.method.toLowerCase()) {
                    case 'post':
                    case 'delete':
                      // if the location header was passed in, we're going to do a get on that.
                      yield `// final get on the the Location header, if present`;
                      yield finalLocation;
                      If(`string.IsNullOrWhiteSpace(${finalLocation})`, function* () {
                        yield $this.finalGet(finalLocation, reqParameter, response);
                      });
                      break;
                    case 'patch':
                    case 'put':
                      yield `// final get on the original URI`;
                      yield $this.finalGet(originalUri, reqParameter, response);
                      break;
                  }
                  break;
              }
            });
          });
        }
        yield responder();
      });



      yield Finally(function* () {
        yield '// finally statements';
        yield eventListener.signalNoCheck(ClientRuntime.Events.Finally, 'request', '_response');
        yield `_response?.Dispose();`;
        yield `${reqParameter.use}?.Dispose();`;
      });

      if ($this.returnNull) {
        yield Return('result');
        $this.insert(new LocalVariable('result', System.Net.Http.HttpResponseMessage, { initializer: dotnet.Null }));
      }
    });

    this.opMethod.emitCall($this.returnNull);
  }

  private *finalGet(finalLocation: ExpressionOrLiteral, reqParameter: Variable, response: Variable) {
    yield reqParameter.assign(`${valueOf(reqParameter)}.CloneAndDispose(${System.Uri.new(finalLocation)}, ${ClientRuntime.Method.Get})`);

    yield EOL;
    yield `// drop the old response`;
    yield `${response.value}?.Dispose();`;

    yield EOL;
    yield `// make the final call`;
    yield response.assign(`await ${this.opMethod.senderParameter}.SendAsync(${valueOf(reqParameter)},  ${this.opMethod.contextParameter})`);

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
      const callbackParameter = <CallbackParameter>values(opMethod.callbacks).linq.first(each => each.name === response.details.csharp.name);
      // all mimeTypes per for this response code.
      yield eventListener.signal(ClientRuntime.Events.BeforeResponseDispatch, '_response');
      yield $this.responseHandler(response.mimeTypes[0], response, callbackParameter);
    }
  }


  private * responseHandlerForNormalPipeline(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {
    const callbackParameters = new Array<ExpressionOrLiteral>();

    if (callbackParameter.responseType) {
      // hande the body response
      const r = callbackParameter.responseType.deserializeFromResponse(knownMediaType(mimetype), toExpression(`_response`), toExpression('null'));
      if (r) {
        callbackParameters.push(r);
      }

      // if (parseMediaType(mimetype)) {
      // this media type isn't directly supported by deserialization
      // we can return a stream to the consumer instead
      // }
    }

    if (callbackParameter.headerType) {
      // header model deserialization...
      const r = callbackParameter.headerType.deserializeFromResponse(KnownMediaType.Header, toExpression(`_response`), toExpression('null'));
      if (r) {
        callbackParameters.push(r);
      }
    }
    // make the callback with the appropriate parameters
    yield `await ${eachResponse.details.csharp.name}(_response${callbackParameters.length === 0 ? '' : ','}${callbackParameters.joinWith(valueOf)});`;
  }

  private responseHandler(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {
    return this.responseHandlerForNormalPipeline(mimetype, eachResponse, callbackParameter);
  }
}

export class ValidationMethod extends Method {

  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.csharp.name}_Validate`, System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.description = `Validation method for <see cref="${opMethod.operation.details.csharp.name}" /> method. Call this like the actual call, but you will get validation events back.`;
    this.returnsDescription = opMethod.returnsDescription;
    this.access = Access.Internal;
    this.async = Modifier.Async;
    this.push(Using(`NoSynchronizationContext`, ``));

    // add the method parameters
    for (const parameter of opMethod.methodParameters) {
      if (!parameter.defaultInitializer) {
        this.addParameter(parameter);
      }
    }

    if (opMethod.bodyParameter) {
      this.addParameter(opMethod.bodyParameter);
    }

    this.addParameter(opMethod.contextParameter);

    // add statements to this method
    this.add(function* () {
      for (const parameter of opMethod.methodParameters) {
        if (!parameter.defaultInitializer) {
          // spit out parameter validation
          yield parameter.validatePresenceStatement(opMethod.contextParameter);
          yield parameter.validationStatement(opMethod.contextParameter);
        }
      }

      // spit out body parameter validation too
      if (opMethod.bodyParameter) {
        yield opMethod.bodyParameter.validatePresenceStatement(opMethod.contextParameter);
        yield opMethod.bodyParameter.validationStatement(opMethod.contextParameter);
      }
    });
  }
}
