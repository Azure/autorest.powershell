import {Class} from "#csharp/code-dom/class";
import {Method} from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import {Parameter} from "#csharp/code-dom/parameter";
import {CallbackParameter, OperationBodyParameter, OperationParameter} from "../operation/parameter";
import {camelCase, deconstruct, EOL, fixLeadingNumber, indent, map} from "#common/text-manipulation";
import {State} from "../generator";
import {Statement} from "#csharp/code-dom/statements/statement";
import {Expression} from "#csharp/code-dom/expression";
import {Using} from "#csharp/code-dom/statements/using";
import {Try} from "#csharp/code-dom/statements/try";
import {Finally} from "#csharp/code-dom/statements/finally";
import {Switch} from "#csharp/code-dom/statements/switch";
import {Case, DefaultCase, TerminalDefaultCase} from "#csharp/code-dom/statements/case";
import {ClientRuntime, EventListener as EventListenr, ISendAsync} from "#csharp/lowlevel-generator/clientruntime";
import {Access, Modifier} from "#csharp/code-dom/access-modifier";
import {If} from "#csharp/code-dom/statements/if";
import {HttpOperation, ParameterLocation} from "#common/code-model/http-operation";

export class OperationMethod extends Method {
  public methodParameters: OperationParameter[];
  public bodyParameter?: OperationBodyParameter;
  public listenerParameter: Parameter;
  public senderParameter: Parameter;
  public callbacks = new Array<Parameter>();
  public responseMatrix: {
    responseCode: string;
    responses: {
      parameter: Parameter;
      callResponder: string;
      mimeType: string[];
    }[];
  }[]

  constructor(protected parent: Class, public operation: HttpOperation, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(operation.details.name, mscorlib.Task);
    this.apply(objectInitializer);
    this.async = Modifier.Async;

    // add parameters
    this.methodParameters = this.operation.parameters.map((value, index) => <OperationParameter>this.addParameter(new OperationParameter(this, value, this.state.path('parameters', index))));

    this.description = this.operation.details.description || "";

    // add body paramter
    //let bodyParameter: OperationBodyParameter;

    if (this.operation.requestBody) {
      const appjson = this.operation.requestBody.content["application/json"];
      if (appjson && appjson.schema) {

        this.bodyParameter = new OperationBodyParameter(this, "body", this.operation.requestBody.description || "", appjson.schema, this.operation.requestBody.required, this.state.path('requestBody'));
        this.addParameter(this.bodyParameter);
      }
    }

    // add response delegate parameters
    this.responseMatrix = map(this.operation.responses, (responseCode, response) => {
      const rState = this.state.path('responses', responseCode);

      const content = response.content;
      let mimeTypes = Object.getOwnPropertyNames(content);

      const headers = response.headers;
      let headerKeys = Object.getOwnPropertyNames(headers);

      // regardless how the body response is handled, the headers response is consistent between them all.
      const headerResponseType = state.project.modelsNamespace.resolveHeaderTypeDeclaration(headers, true, state);

      // if content node is empty, then the callback body returns no data.
      // but the different codes may represent different possible outcomes.
      if (mimeTypes.length === 0) {
        const name = camelCase(fixLeadingNumber(deconstruct(`on ${responseCode}`)));
        const callbackParameter = new CallbackParameter(this, name, null, headerResponseType, this.state);
        this.callbacks.push(this.addParameter(callbackParameter));
        return {
          responseCode,
          responses: [{
            parameter: callbackParameter,
            callResponder: `await ${name}( new ${ClientRuntime.fullName}.Response(${callbackParameter.headerDeserializeStatement}) { requestMessage = request,responseMessage = _response });`,
            mimeType: new Array<string>()
          }
          ]
        }
      }


      return {
        responseCode,
        responses: map(content, (mimeType, mediaType) => {
          const name = (mimeTypes.length === 1 || mimeType === 'application/json') ?
            camelCase(fixLeadingNumber(deconstruct(`on ${responseCode}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${responseCode} ${mimeType}`)));

          let bodyResponseType = mediaType.schema ? state.project.modelsNamespace.resolveTypeDeclaration(mediaType.schema, true, state) : null;

          let callbackParameter = new CallbackParameter(this, name, bodyResponseType, headerResponseType, this.state);

          this.callbacks.push(this.addParameter(callbackParameter));

          let callResponder: string;

          switch (mimeType) {
            // figure out the deserializor to use for this content type.
            case 'application/json':
            case 'text/json':
              callResponder = // function* () {
                `await ${name}( ${callbackParameter.responseConstructorForJsonBody}{ requestMessage = request,responseMessage = _response }); `
              break;

            case 'application/xml':
              callResponder = "/* deserialize xml */";

              break;
            default:
              // hmm. not a supported serialization type.
              // do we handle this like a stream response?
              callResponder = "/*todo: other response type */"
          }

          return {
            parameter: callbackParameter,
            mimeType: mediaType.accepts,
            callResponder: callResponder
          };
        })
      };
    });

    // add eventhandler parameter
    this.listenerParameter = this.addParameter(new Parameter("listener", EventListenr));

    // add optional parameter for sender 
    this.senderParameter = this.addParameter(new Parameter("sender", ISendAsync));

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
    this.add(function* () {
      const eventListener = new EventListener(this.listener);
      yield `// should we call validation?`
      yield EOL;

      yield `// construct URL`
      yield `var _url = $"${baseUrl}${path}${queryParams.length > 0 ? '?' : ''}${queryParams.joinWith(pp => `${pp.param.name}={System.Uri.EscapeDataString(${pp.use})}`, "&")}";`;
      yield EOL;

      yield `// generate request object `
      yield `var request =  new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${this.operation.method.capitalize()}, _url);`
      yield EOL;

      if (headerParams.length > 0) {
        yield `// add headers parameters`
        for (const hp of headerParams) {
          yield new If({ value: `null != ${hp.name}` }, `request.Headers.Add( "${hp.param.name}", ${hp.name});`);
        }
        yield EOL;
      }

      if (bp) {
        yield `// set body content`
        yield `request.Content = new System.Net.Http.StringContent( null != ${bp.use} ? ${bp.use}.ToJson(null) : "{}", System.Text.Encoding.UTF8);`
        yield `request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");`
      }

      yield `// make the call `
      yield `await this.${this.name}_Call(request,${cb.joinWith(each => each.use, ",")},${this.listenerParameter.use},${this.senderParameter.use});`

    }.bind(this));

  }

}

export class EventListener {
  constructor(protected expression: Expression) {
  }

  fire(eventName: string, ...additionalParameters: Array<string | Expression>) {
    return new FireEvent(this.expression, eventName, additionalParameters);
  }
}

export class FireEvent implements Statement {
  constructor(protected expression: Expression, protected eventName: string, protected additionalParameters: Array<string | Expression>) {
  }

  get implementation(): string {
    const additionalParameters = this.additionalParameters.length > 0 ? `, ${this.additionalParameters.joinWith(each => typeof each === 'string' ? each : each.value)}` : ``;

    return `await ${this.expression.value}.Signal(${ClientRuntime.fullName}.Events.${this.eventName}${additionalParameters});`;
  }
}


export class CallMethod extends Method {
  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.name}_Call`, mscorlib.Task);
    this.apply(objectInitializer);
    this.access = Access.Internal;
    this.async = Modifier.Async;

    // add parameters
    // request, listener, sender
    const reqParameter = this.addParameter(new Parameter("request", mscorlib.HttpRequestMessage));
    opMethod.callbacks.map(each => this.addParameter(each));
    this.addParameter(opMethod.listenerParameter);
    this.addParameter(opMethod.senderParameter);


    // add statements to this method
    this.add(function* () {
      const eventListener = new EventListener(opMethod.listenerParameter);

      // yield new Using(`var _request = new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${opMethod.operation.method.capitalize()}, "http://wherever/...")`, function* () {
      yield new Using(`${reqParameter.use}`, function* () {
        yield eventListener.fire("RequestCreated", `${reqParameter.use}`);

        yield `System.Net.Http.HttpResponseMessage _response = null;`;
        yield new Try(function* () {
          // try statements
          yield `_response = await ${opMethod.senderParameter.value}.SendAsync(${reqParameter.use},  ${opMethod.listenerParameter.value});`;
          yield eventListener.fire("ResponseCreated", '_response');
          yield `var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();`

          // add response handlers
          yield new Switch({ value: `_response.StatusCode` }, function* () {
            for (const eachResponse of opMethod.responseMatrix) {
              if (eachResponse.responseCode !== 'default') {
                // each response
                yield new Case(`(System.Net.HttpStatusCode)${eachResponse.responseCode}`, function* () {
                  yield `// on ${eachResponse.responseCode} ... `;

                  for (const variant of eachResponse.responses) {
                    if (eachResponse.responses.length > 1) {
                      yield new If({ value: `${variant.mimeType.joinWith(eee => `_contentType == "${eee}"`, " || ")}` }, function* () {
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
                yield new DefaultCase(function* () {
                  yield "// on default ... ";
                  yield EOL;
                });
              }
            }


            if (!opMethod.operation.responses["default"]) {
              // if no default, we need one that handles the rest of the stuff.
              yield new TerminalDefaultCase(function* () {
                yield `throw new ${ClientRuntime.fullName}.UndeclaredResponseException(_response.StatusCode);`;
              });
            }
          });
        });

        yield new Finally(function* () {
          yield "// finally statements";
          yield eventListener.fire("Finally", "request", "_response");
          yield `_response?.Dispose();`
        });

      });

    });
  };

}

export class ValidationMethod extends Method {

  constructor(protected parent: Class, protected opMethod: OperationMethod, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(`${opMethod.operation.details.name}_Validate`, mscorlib.Task);
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