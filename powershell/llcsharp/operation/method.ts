/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { NewResponse, ParameterLocation } from '@azure-tools/codemodel-v3';
import { Operation, SchemaResponse, BinaryResponse, Schema as NewSchema, Response, BinarySchema } from '@azure-tools/codemodel';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import { EOL, DeepPartial } from '@azure-tools/codegen';
import { Access, Modifier } from '@azure-tools/codegen-csharp';
import { Class } from '@azure-tools/codegen-csharp';
import { Binary } from '../schema/binary';

import { Expression, ExpressionOrLiteral, LiteralExpression, StringExpression, toExpression, valueOf } from '@azure-tools/codegen-csharp';
import { Method } from '@azure-tools/codegen-csharp';
import { Parameter } from '@azure-tools/codegen-csharp';
import { Case, DefaultCase, TerminalCase, TerminalDefaultCase } from '@azure-tools/codegen-csharp';
import { Finally } from '@azure-tools/codegen-csharp';
import { If, While } from '@azure-tools/codegen-csharp';
import { Return } from '@azure-tools/codegen-csharp';
import { OneOrMoreStatements, Statement, Statements } from '@azure-tools/codegen-csharp';
import { Switch } from '@azure-tools/codegen-csharp';
import { Try } from '@azure-tools/codegen-csharp';
import { Using } from '@azure-tools/codegen-csharp';
import { Local, LocalVariable, Variable } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { HttpOperation, Schema } from '../code-model';
import { State } from '../generator';
import { CallbackParameter, OperationParameter, OperationBodyParameter } from '../operation/parameter';

import { isMediaTypeJson, isMediaTypeXml, KnownMediaType, knownMediaType, normalizeMediaType, parseMediaType } from '@azure-tools/codemodel-v3';
import { ClassType, dotnet, System } from '@azure-tools/codegen-csharp';
import { Ternery } from '@azure-tools/codegen-csharp';



function removeEncoding(pp: OperationParameter, paramName: string, kmt: KnownMediaType): string {
  const up = pp.typeDeclaration.serializeToNode(kmt, pp, paramName, ClientRuntime.SerializationMode.None).value;
  return pp.param.extensions && pp.param.extensions['x-ms-skip-url-encoding'] ? up.replace(/global::System.Uri.EscapeDataString|System.Uri.EscapeDataString/g, '') : up;
}


export class EventListener {
  constructor(protected expression: Expression, protected emitSignals: boolean) {
  }

  *signalNoCheck(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = length(additionalParameters) > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : '';
      yield `await ${this.expression.value}.Signal(${eventName}${params});`;
    }
  }
  *syncSignalNoCheck(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = length(additionalParameters) > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : '';
      yield `${this.expression.value}.Signal(${eventName}${params}).Wait();`;
    }
  }
  *signal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = length(additionalParameters) > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : '';
      yield `await ${this.expression.value}.Signal(${eventName}${params}); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw ${System.OperationCanceledException.new()}; }`;
    }
  }
  *syncSignal(eventName: Expression, ...additionalParameters: Array<string | Expression>) {
    if (this.emitSignals) {
      const params = length(additionalParameters) > 0 ? `, ${additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : '';
      yield `${this.expression.value}.Signal(${eventName}${params}).Wait(); if( ${this.expression.value}.Token.IsCancellationRequested ) { return; }`;
    } else {
      yield `if( ${this.expression.value}.CancellationToken.IsCancellationRequested ) { throw ${System.OperationCanceledException.new()} }`;
    }

  }
}


export class OperationMethod extends Method {
  public methodParameters: Array<OperationParameter>;
  public bodyParameter?: OperationBodyParameter;
  public serializationMode?: LiteralExpression;
  public contextParameter!: Parameter;
  public senderParameter!: Parameter;
  public serializationModeParameter!: Parameter;
  public resourceUri!: Parameter;
  public callbacks = new Array<CallbackParameter>();

  protected callName: string;

  constructor(public parent: Class, public operation: Operation, public viaIdentity: boolean, protected state: State, objectInitializer?: DeepPartial<OperationMethod>) {
    super(viaIdentity ? `${operation.language.csharp?.name}ViaIdentity` : operation.language.csharp?.name || '', System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.async = Modifier.Async;
    this.returnsDescription = `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the response is completed.`;
    const $this = this;

    this.callName = `${operation.language.csharp?.name}_Call`;
    this.push(Using('NoSynchronizationContext', ''));

    // add parameters
    this.methodParameters = [];

    const identity = new Parameter('viaIdentity', System.String);
    if (this.viaIdentity) {
      this.addParameter(identity);
    }
    let baseUrl = '';
    for (let index = 0; index < length(this.operation.parameters) && this.operation.parameters; index++) {
      const value = this.operation.parameters[index];

      if (value.language.default.name === '$host') {
        baseUrl = value.clientDefaultValue;
        continue;
      }
      const p = new OperationParameter(this, value, this.state.path('parameters', index));

      if (value.language.csharp?.constantValue) {
        const constTd = state.project.modelsNamespace.NewResolveTypeDeclaration(value.schema, true, state);
        p.defaultInitializer = constTd.deserializeFromString(KnownMediaType.UriParameter, new StringExpression(`${value.language.csharp.constantValue}`), toExpression(constTd.defaultOfType));
      }

      // don't add path parameters  when we're in identity mode
      if (!this.viaIdentity || value.protocol.http?.in !== ParameterLocation.Path) {
        this.addParameter(p);
      } else {
        this.add(function* () {
          yield '';
        });
      }
      this.methodParameters.push(p);
    }

    if (baseUrl === '') {
      // Some services will make the host as an input parameter
      baseUrl = this.operation.requests ? this.operation.requests[0].protocol.http?.uri : '';
    }

    this.description = this.operation.language.csharp?.description || '';

    // add body paramter if there should be one.
    if (this.operation.requests && this.operation.requests.length && this.operation.requests[0].parameters && this.operation.requests[0].parameters.length) {
      // this request does have a request body.
      const param = this.operation.requests[0].parameters.find((p) => !p.origin || p.origin.indexOf('modelerfour:synthesized') < 0);
      if (param) {
        this.bodyParameter = new OperationBodyParameter(this, 'body', param.language.default.description, param.schema, param.required ?? false, this.state, {
          // TODO: temp solution. We need a class like NewKnowMediaType
          mediaType: knownMediaType(KnownMediaType.Json),
          contentType: KnownMediaType.Json
        });
        this.addParameter(this.bodyParameter);
      }
    }

    for (const response of [...values(this.operation.responses), ...values(this.operation.exceptions)]) {
      const responseType = (<BinaryResponse>response).binary ? new Binary(new BinarySchema(""), true) : ((<SchemaResponse>response).schema ? state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>((<SchemaResponse>response).schema), true, state) : null);
      const headerType = response.language.default.headerSchema ? state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>response.language.default.headerSchema, true, state) : null;
      const newCallbackParameter = new CallbackParameter(response.language.csharp?.name || '', responseType, headerType, this.state, { description: response.language.csharp?.description });
      this.addParameter(newCallbackParameter);
      this.callbacks.push(newCallbackParameter);


    }

    // add eventhandler parameter
    this.contextParameter = this.addParameter(new Parameter('eventListener', ClientRuntime.IEventListener, { description: `an <see cref="${ClientRuntime.IEventListener}" /> instance that will receive events.` }));

    // add optional parameter for sender
    this.senderParameter = this.addParameter(new Parameter('sender', ClientRuntime.ISendAsync, { description: `an instance of an ${ClientRuntime.ISendAsync} pipeline to use to make the request.` }));

    let rx = this.operation.requests ? this.operation.requests[0].protocol.http?.path : '';
    const path = rx;
    // For post API, Some URI may contain an action string .e.x '/start' at the end
    // of the URI, for such cases, we will drop the action string if identityCorrection
    // is set in the configuration
    if (this.operation.requests && this.operation.requests.length && this.operation.requests[0].protocol.http?.method === 'post' && this.state.project.identityCorrection) {
      const idx = rx.lastIndexOf('/');
      rx = rx.substr(0, idx);
    }

    let url = `/${path.startsWith('/') ? path.substr(1) : path}`;


    const serverParams = this.methodParameters.filter(each => each.param.protocol.http?.in === ParameterLocation.Uri);

    const headerParams = this.methodParameters.filter(each => each.param.protocol.http?.in === ParameterLocation.Header);
    const pathParams = this.methodParameters.filter(each => each.param.protocol.http?.in === ParameterLocation.Path);
    const queryParams = this.methodParameters.filter(each => each.param.protocol.http?.in === ParameterLocation.Query);
    const cookieParams = this.methodParameters.filter(each => each.param.protocol.http?.in === ParameterLocation.Cookie);

    // replace any server params in the uri
    for (const pp of serverParams) {
      url = url.replace(`{${pp.param.language.default.serializedName}}`, `"
        + ${pp.name}
        + "`);
    }

    for (const pp of pathParams) {
      rx = rx.replace(`{${pp.param.language.default.serializedName}}`, `(?<${pp.param.language.default.serializedName}>[^/]+)`);

      if (this.viaIdentity) {
        url = url.replace(`{${pp.param.language.default.serializedName}}`, `"
        + ${pp.name}
        + "`);
      } else {
        url = url.replace(`{${pp.param.language.default.serializedName}}`, `"
        + ${removeEncoding(pp, '', KnownMediaType.UriParameter)}
        + "`);
      }
    }
    rx = `"^${rx}$"`;
    url = url.replace(/\s*\+ ""/gm, '');

    const bp = this.bodyParameter;

    if (bp) {
      this.serializationMode = ClientRuntime.SerializationMode.IncludeCreateOrUpdate;
      if (operation.language.default.name === 'Patch') {
        this.serializationMode = ClientRuntime.SerializationMode.IncludeUpdate;
      }
      // add optional parameter for json serialization mode
      this.serializationModeParameter = this.addParameter(new Parameter('serializationMode', ClientRuntime.SerializationMode, { description: `Allows the caller to choose the depth of the serialization. See <see cref="${ClientRuntime.SerializationMode}"/>.`, defaultInitializer: this.serializationMode }));
    }
    // add method implementation...

    this.add(function* () {
      const eventListener = new EventListener($this.contextParameter, $this.state.project.emitSignals);

      yield EOL;

      if ($this.viaIdentity) {
        yield '// verify that Identity format is an exact match for uri';
        yield EOL;

        const match = Local('_match', `${System.Text.RegularExpressions.Regex.new(rx, "global::System.Text.RegularExpressions.RegexOptions.IgnoreCase").value}.Match(${identity.value})`);
        yield match.declarationStatement;
        yield If(`!${match}.Success`, `throw new global::System.Exception("Invalid identity for URI '${path}'");`);
        yield EOL;
        yield '// replace URI parameters with values from identity';
        for (const pp of pathParams) {
          yield `var ${pp.name} = ${match.value}.Groups["${pp.param.language.default.serializedName}"].Value;`;
        }
      }

      yield '// construct URL';
      const pathAndQueryV = Local('pathAndQuery', `${System.Text.RegularExpressions.Regex.declaration}.Replace(
        "${url}"
        ${queryParams.length > 0 ? '+ "?"' : ''}${queryParams.joinWith(pp => `
        + ${removeEncoding(pp, pp.param.language.default.serializedName, KnownMediaType.QueryParameter)}`, `
        + "&"`
      )}
        ,"\\\\?&*$|&*$|(\\\\?)&+|(&)&+","$1$2")`.replace(/\s*\+ ""/gm, ''));
      yield pathAndQueryV.declarationStatement;

      yield EOL;

      yield eventListener.signal(ClientRuntime.Events.URLCreated, pathAndQueryV.value);
      yield EOL;

      yield '// generate request object ';
      const urlV = new LocalVariable('_url', dotnet.Var, {
        initializer: System.Uri.new(`$"${baseUrl}{${pathAndQueryV.value}}"`)
      });
      yield urlV.declarationStatement;
      const method = $this.operation.requests ? $this.operation.requests[0].protocol.http?.method : '';
      yield `var request =  ${System.Net.Http.HttpRequestMessage.new(`${ClientRuntime.fullName}.Method.${method.capitalize()}, ${urlV.value}`)};`;
      yield eventListener.signal(ClientRuntime.Events.RequestCreated, `request.RequestUri.PathAndQuery`);
      yield EOL;

      if (length(headerParams) > 0) {
        yield '// add headers parameters';
        for (const hp of headerParams) {
          if (hp.param.language.default.name === 'Content-Length') {
            // content length is set when the request body is set
            continue;
          }
          yield hp.serializeToContainerMember(KnownMediaType.Header, new LocalVariable('request.Headers', dotnet.Var), hp.param.language.default.serializedName, ClientRuntime.SerializationMode.None);
        }
        yield EOL;
      }
      yield eventListener.signal(ClientRuntime.Events.HeaderParametersAdded);

      if (bp) {
        yield '// set body content';
        yield `request.Content = ${bp.serializeToContent(bp.mediaType, new LiteralExpression("serializationMode"))};`;
        yield `request.Content.Headers.ContentType = ${System.Net.Http.Headers.MediaTypeHeaderValue.Parse(bp.contentType)};`;
        yield eventListener.signal(ClientRuntime.Events.BodyContentSet);
      }

      yield '// make the call ';
    });
  }

  emitCall(returnFromCall: boolean) {

    // storage will return from the call for download, etc.
    if (returnFromCall) {
      this.returnType = System.Threading.Tasks.Task(System.Net.Http.HttpResponseMessage);
    }

    this.add(`await this.${this.callName}(request,${this.callbacks.joinWith(each => each.use, ',')},${this.contextParameter.use},${this.senderParameter.use});`);

    // remove constant parameters and make them locals instead.
    this.insert('// Constant Parameters');
    for (let i = length(this.parameters); i--; i < 0) {
      const p = this.parameters[i];
      if (p && p.defaultInitializer && p.name !== 'serializationMode') {
        this.parameters.splice(i, 1);
        this.insert(new LocalVariable(p.name, dotnet.Var, { initializer: p.defaultInitializer }));
      }
    }
  }
}
export class CallMethod extends Method {
  public returnNull = false;
  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: DeepPartial<OperationMethod>) {
    super(`${opMethod.name}_Call`, System.Threading.Tasks.Task());
    this.description = `Actual wire call for <see cref="${opMethod.name}" /> method.`;
    this.returnsDescription = opMethod.returnsDescription;

    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;
    this.push(Using('NoSynchronizationContext', ''));

    const $this = this;
    // add parameters
    // request, listener, sender
    const reqParameter = this.addParameter(new Parameter('request', System.Net.Http.HttpRequestMessage, { description: 'the prepared HttpRequestMessage to send.' }));
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
            var responses = [...values(opMethod.operation.responses), ...values(opMethod.operation.exceptions)].sort(function (a, b) { return (<string>(a.protocol.http?.statusCodes[0])).localeCompare(<string>(b.protocol.http?.statusCodes[0]))});
            for (const resp of responses) {
              if (resp.protocol.http?.statusCodes[0] !== 'default') {
                const responseCode = resp.protocol.http?.statusCodes[0];
                var leadNum = parseInt(responseCode[0]);
                // will use enum when it can, fall back to casting int when it can't
                yield Case(System.Net.HttpStatusCode[responseCode] ? System.Net.HttpStatusCode[responseCode].value : `${System.Net.HttpStatusCode.declaration} n when((int)n >= ${leadNum * 100} && (int)n < ${leadNum * 100 + 100})`, $this.responsesEmitter($this, opMethod, [resp], eventListener));
              } else {
                yield DefaultCase($this.responsesEmitter($this, opMethod, [resp], eventListener));
              }
            }

            // missing default response?
            if (!opMethod.operation.exceptions) {
              // if no default, we need one that handles the rest of the stuff.
              yield TerminalDefaultCase(function* () {
                yield `throw new ${ClientRuntime.fullName}.UndeclaredResponseException(_response);`;
              });
            }
          });
        };

        // try statements
        const sendTask = Local(
          'sendTask',
          new LiteralExpression(
            `${opMethod.senderParameter.value}.SendAsync(${reqParameter.use}, ${opMethod.contextParameter.value})`
          )
        );
        yield sendTask;
        // delay sending BeforeCall event until URI has been replaced by HTTP pipeline
        yield eventListener.signal(ClientRuntime.Events.BeforeCall, reqParameter.use);
        yield `${response.value} = await ${sendTask.value};`;
        yield eventListener.signal(ClientRuntime.Events.ResponseCreated, response.value);
        const EOL = 'EOL';
        // LRO processing (if appropriate)
        if ($this.opMethod.operation.language.csharp?.lro) {
          yield '// this operation supports x-ms-long-running-operation';
          const originalUri = Local('_originalUri', new LiteralExpression(`${reqParameter.use}.RequestUri.AbsoluteUri`));
          yield originalUri;

          yield `// declared final-state-via: ${$this.opMethod.operation.language.csharp.lro['final-state-via']}`;
          const fsv = $this.opMethod.operation.language.csharp.lro['final-state-via'];
          let finalUri: LocalVariable;

          switch (fsv) {
            case 'original-uri':
              // perform a final GET on the original URI.
              finalUri = originalUri;
              break;

            case 'location':
              // perform a final GET on the uri in Location header
              finalUri = Local('_finalUri', response.invokeMethod('GetFirstHeader', new StringExpression('Location')));
              yield finalUri;
              break;
            case 'azure-asyncoperation':
            case 'azure-async-operation':
              //depending on the type of request, do the appropriate behavior
              switch ($this.opMethod.operation.requests?.[0].protocol.http?.method.toLowerCase()) {
                case 'post':
                case 'delete':
                  finalUri = Local('_finalUri', response.invokeMethod('GetFirstHeader', new StringExpression('Azure-AsyncOperation')));
                  yield finalUri;
                  break;
                case 'patch':
                case 'put':
                  // perform a final GET on the original URI.
                  finalUri = originalUri;
                  break;
              }
              break;

            default:
              // depending on the type of request, fall back to the appropriate behavior
              if ($this.opMethod.operation.requests) {
                switch ($this.opMethod.operation.requests[0].protocol.http?.method.toLowerCase()) {
                  case 'post':
                  case 'delete':
                    finalUri = Local('_finalUri', response.invokeMethod('GetFirstHeader', new StringExpression('Location')));
                    yield finalUri;
                    break;
                  case 'patch':
                  case 'put':
                    // perform a final GET on the original URI.
                    finalUri = originalUri;
                    break;
                }
              }
              break;

          }

          const asyncOperation = Local('asyncOperation', response.invokeMethod('GetFirstHeader', new StringExpression('Azure-AsyncOperation')));
          yield asyncOperation;
          const location = Local('location', response.invokeMethod('GetFirstHeader', new StringExpression('Location')));
          yield location;

          yield While(new LiteralExpression(`${reqParameter.use}.Method == System.Net.Http.HttpMethod.Put && ${response.value}.StatusCode == ${System.Net.HttpStatusCode[200].value} || ${response.value}.StatusCode == ${System.Net.HttpStatusCode[201].value} || ${response.value}.StatusCode == ${System.Net.HttpStatusCode[202].value} `), function* () {
            yield EOL;
            yield '// get the delay before polling. (default to 30 seconds if not present)';
            yield `int delay = (int)(${response.value}.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);`;
            // yield If(`!int.TryParse( ${response.invokeMethod('GetFirstHeader', new StringExpression(`Retry-After`)).value}, out int delay)`, `delay = 30;`);

            yield eventListener.signal(ClientRuntime.Events.DelayBeforePolling, '$"Delaying {delay} seconds before polling."', response.value);

            yield EOL;
            yield '// start the delay timer (we\'ll await later...)';
            const waiting = Local('waiting', new LiteralExpression(`${System.Threading.Tasks.Task()}.Delay(delay * 1000, ${$this.opMethod.contextParameter}.Token )`));
            yield waiting;

            yield EOL;
            yield '// while we wait, let\'s grab the headers and get ready to poll. ';
            yield 'if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {';
            yield '    ' + asyncOperation.assign(response.invokeMethod('GetFirstHeader', new StringExpression('Azure-AsyncOperation')));
            yield '}';
            yield 'if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {';
            yield '    ' + location.assign(response.invokeMethod('GetFirstHeader', new StringExpression('Location')));
            yield '}';
            const uriLocal = Local('_uri', Ternery(
              System.String.IsNullOrEmpty(asyncOperation),
              Ternery(System.String.IsNullOrEmpty(location),
                originalUri,
                location),
              asyncOperation));
            yield uriLocal;

            yield `${reqParameter.use} = ${reqParameter.use}.CloneAndDispose(${System.Uri.new(uriLocal)}, ${ClientRuntime.Method.Get});`;

            yield EOL;
            yield '// and let\'s look at the current response body and see if we have some information we can give back to the listener';
            const content = Local('content', new LiteralExpression(`await ${response.value}.Content.ReadAsStringAsync()`));
            yield content;

            yield 'await waiting;';

            yield EOL;
            yield '// check for cancellation';
            yield `if( ${$this.opMethod.contextParameter}.Token.IsCancellationRequested ) { return; }`;

            yield EOL;
            yield '// drop the old response';
            yield `${response.value}?.Dispose();`;

            yield EOL;
            yield '// make the polling call';
            yield `${response.value} = await ${opMethod.senderParameter}.SendAsync(${reqParameter.value}, ${opMethod.contextParameter});`;
            yield eventListener.signal(ClientRuntime.Events.Polling, response.value);

            yield EOL;
            yield `
// if we got back an OK, take a peek inside and see if it's done
if( ${response.value}.StatusCode == ${System.Net.HttpStatusCode.OK})
{
    var error = false;
    try {
        if( ${ClientRuntime.JsonNode.Parse(toExpression(`await ${response.value}.Content.ReadAsStringAsync()`))} is ${ClientRuntime.JsonObject} json)
        {
            var state = json.Property("properties")?.PropertyT<${ClientRuntime.JsonString}>("provisioningState") ?? json.PropertyT<${ClientRuntime.JsonString}>("status");
            if( state is null ) 
            {
                // the body doesn't contain any information that has the state of the LRO
                // we're going to just get out, and let the consumer have the result
                break;
            }

            switch( state?.ToString()?.ToLower() )
            {
              case "failed":
                  error = true;
                  break;
              case "succeeded":
              case "canceled":
                // we're done polling.
                break;

              default: 
                // need to keep polling!
                ${response.value}.StatusCode = ${System.Net.HttpStatusCode.Created};
                continue;
            }
        }
    } catch {
        // if we run into a problem peeking into the result, 
        // we really don't want to do anything special.
    }
    if (error) {
        throw new ${ClientRuntime.fullName}.UndeclaredResponseException(${response.value});
    }
}`;

            yield EOL;
            yield '// check for terminal status code';
            yield If(new LiteralExpression(`${response.value}.StatusCode == ${System.Net.HttpStatusCode[201].value} || ${response.value}.StatusCode == ${System.Net.HttpStatusCode[202].value} `), 'continue;');

            yield '// we are done polling, do a request on final target?';

            switch (fsv) {
              case 'original-uri':
              case 'azure-asyncoperation':
              case 'azure-async-operation':
              case 'location':
                // perform a final GET on the specified final URI.
                yield $this.finalGet(finalUri, reqParameter, response);
                break;

              default:
                yield If(`!string.IsNullOrWhiteSpace(${finalUri})`, function* () {
                  yield $this.finalGet(finalUri, reqParameter, response);
                });
                break;
            }
          });

        }
        yield responder();
      });

      yield Finally(function* () {
        yield '// finally statements';
        yield eventListener.signalNoCheck(ClientRuntime.Events.Finally, 'request', '_response');
        yield `${response.value}?.Dispose();`;
        yield `${reqParameter.use}?.Dispose();`;
      });

      if ($this.returnNull) {
        yield Return('result');
        $this.insert(new LocalVariable('result', System.Net.Http.HttpResponseMessage, { initializer: dotnet.Null }));
      }
    });

    this.opMethod.emitCall($this.returnNull);
  }

  private * finalGet(finalLocation: ExpressionOrLiteral, reqParameter: Variable, response: Variable) {
    yield '// create a new request with the final uri';
    yield reqParameter.assign(`${valueOf(reqParameter)}.CloneAndDispose(${System.Uri.new(finalLocation)}, ${ClientRuntime.Method.Get})`);

    yield EOL;
    yield '// drop the old response';
    yield `${response.value}?.Dispose();`;

    yield EOL;
    yield '// make the final call';
    yield response.assign(`await ${this.opMethod.senderParameter}.SendAsync(${valueOf(reqParameter)},  ${this.opMethod.contextParameter})`);

    // make sure we're not polling anymore.
    yield 'break;';
  }

  private * responsesEmitter($this: CallMethod, opMethod: OperationMethod, responses: Array<Response>, eventListener: EventListener) {
    if (length(responses) > 1) {
      yield Switch('_contentType', function* () {
        for (const eachResponse of values(responses)) {
          const mimetype = length(eachResponse.protocol.http?.mediaTypes) > 0 ? eachResponse.protocol.http?.mimeTypes[0] : '';
          const callbackParameter = <CallbackParameter>values(opMethod.callbacks).first(each => each.name === eachResponse.language.csharp?.name);

          let count = length(eachResponse.protocol.http?.mediaTypes);
          for (const mt of values(eachResponse.protocol.http?.mediaTypes)) {
            count--;
            const mediaType = normalizeMediaType(<string>mt);
            if (mediaType) {
              if (count === 0) {
                yield Case(new StringExpression(mediaType).toString(), $this.NewResponseHandler(mimetype, eachResponse, callbackParameter));
              } else {
                yield TerminalCase(new StringExpression(mediaType).toString(), '');
              }
            }
          }
        }
      });
    } else {
      const response = responses[0];
      const callbackParameter = <CallbackParameter>values(opMethod.callbacks).first(each => each.name === response.language.csharp?.name);
      // all mimeTypes per for this response code.
      yield eventListener.signal(ClientRuntime.Events.BeforeResponseDispatch, '_response');
      yield $this.NewResponseHandler(<string>values(response.protocol.http?.mediaTypes).first() || '', response, callbackParameter);
    }
  }

  private * responseHandlerForNormalPipeline(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {
    const callbackParameters = new Array<ExpressionOrLiteral>();

    if (callbackParameter.responseType) {
      // hande the body response
      const r = callbackParameter.responseType.deserializeFromResponse(knownMediaType(mimetype), toExpression('_response'), toExpression('null'));
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
      const r = callbackParameter.headerType.deserializeFromResponse(KnownMediaType.Header, toExpression('_response'), toExpression('null'));
      if (r) {
        callbackParameters.push(r);
      }
    }
    // make the callback with the appropriate parameters
    yield `await ${eachResponse.details.csharp.name}(_response${callbackParameters.length === 0 ? '' : ','}${callbackParameters.joinWith(valueOf)});`;
  }

  private * NewResponseHandlerForNormalPipeline(mimetype: string, eachResponse: Response, callbackParameter: CallbackParameter) {
    const callbackParameters = new Array<ExpressionOrLiteral>();

    if (callbackParameter.responseType) {
      // hande the body response
      const r = callbackParameter.responseType.deserializeFromResponse(knownMediaType(mimetype), toExpression('_response'), toExpression('null'));
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
      const r = callbackParameter.headerType.deserializeFromResponse(KnownMediaType.Header, toExpression('_response'), toExpression('null'));
      if (r) {
        callbackParameters.push(r);
      }
    }
    // make the callback with the appropriate parameters
    yield `await ${eachResponse.language.csharp?.name}(_response${callbackParameters.length === 0 ? '' : ','}${callbackParameters.joinWith(valueOf)});`;
  }

  private responseHandler(mimetype: string, eachResponse: NewResponse, callbackParameter: CallbackParameter) {
    return this.responseHandlerForNormalPipeline(mimetype, eachResponse, callbackParameter);
  }
  private NewResponseHandler(mimetype: string, eachResponse: Response, callbackParameter: CallbackParameter) {
    return this.NewResponseHandlerForNormalPipeline(mimetype, eachResponse, callbackParameter);
  }
}
export class ValidationMethod extends Method {

  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: DeepPartial<OperationMethod>) {
    super(`${opMethod.name}_Validate`, System.Threading.Tasks.Task());
    this.apply(objectInitializer);
    this.description = `Validation method for <see cref="${opMethod.name}" /> method. Call this like the actual call, but you will get validation events back.`;
    this.returnsDescription = opMethod.returnsDescription;
    this.access = Access.Internal;
    this.async = Modifier.Async;
    this.push(Using('NoSynchronizationContext', ''));

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
