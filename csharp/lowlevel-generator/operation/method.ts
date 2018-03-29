import { Class } from "#csharp/code-dom/class";
import * as codemodel from "#remodeler/code-model";
import { Method } from "#csharp/code-dom/method";
import * as mscorlib from "#csharp/code-dom/mscorlib";
import { Parameter } from "#csharp/code-dom/parameter";
import { OperationParameter, OperationBodyParameter, CallbackParameter, undefinedType } from "../operation/parameter";

import { Model } from "#remodeler/code-model";
import * as message from "../messages";
import { all, EOL, camelCase, fixLeadingNumber, deconstruct, map, selectMany } from "#common/text-manipulation";
import { State } from "../generator";
import { Statement, Statements, OneOrMoreStatements } from "#csharp/code-dom/statements/statement";
import { Expression } from "#csharp/code-dom/expression";
import { Using } from "#csharp/code-dom/statements/using";
import { Try } from "#csharp/code-dom/statements/try";
import { Finally } from "#csharp/code-dom/statements/finally";
import { Switch } from "#csharp/code-dom/statements/switch";
import { Case, DefaultCase, TerminalDefaultCase } from "#csharp/code-dom/statements/case";
import { ClientRuntime, EventListener as EventListenr } from "#csharp/lowlevel-generator/clientruntime";
import { Modifier } from "#csharp/code-dom/access-modifier";

export class OperationMethod extends Method {
  constructor(protected parent: Class, protected operation: codemodel.HttpOperation, protected state: State, objectInitializer?: Partial<OperationMethod>) {
    super(operation.details.name, mscorlib.Task);
    this.apply(objectInitializer);
    this.async = Modifier.Async;

    // add parameters
    const methodParameters = this.operation.parameters.map((value, index) => <OperationParameter>this.addParameter(new OperationParameter(this, value, this.state.path('parameters', index))));

    this.description = this.operation.details.description || "";

    // add body paramter
    let bodyParameter: OperationBodyParameter;

    if (this.operation.requestBody) {
      const appjson = this.operation.requestBody.content["application/json"];
      if (appjson && appjson.schema) {

        bodyParameter = new OperationBodyParameter(this, "body", this.operation.requestBody.description || "", appjson.schema, this.operation.requestBody.required, this.state.path('requestBody'));
        this.addParameter(bodyParameter);
      }
    }

    // add response delegate parameters
    const responseMatrix = map(this.operation.responses, (responseCode, response) => {
      const rState = this.state.path('responses', responseCode);
      const content = response.content;

      let mimeTypes = Object.getOwnPropertyNames(content);

      // if content node is empty, then the callback returns no data.
      // but the different codes may represent different possible outcomes.
      if (mimeTypes.length === 0) {
        const name = camelCase(fixLeadingNumber(deconstruct(`on ${responseCode}`)));
        const callback = this.addParameter(new CallbackParameter(this, name, undefined, this.state));
        return {
          responseCode,
          responses: [{
            parameter: callback,
            deserializor: `await ${name}( new ${ClientRuntime.fullName}.Response { requestMessage = _request,responseMessage = _response }); `,
            mimeType: []
          }

          ]
        }
      }

      return {
        responseCode, responses: map(content, (mimeType, mediaType) => {
          const name = (mimeTypes.length === 1 || mimeType === 'application/json') ?
            camelCase(fixLeadingNumber(deconstruct(`on ${responseCode}`))) : // the common type (or the only one.)
            camelCase(fixLeadingNumber(deconstruct(`on ${responseCode} ${mimeType}`)));

          let callback = mediaType.schema ?
            this.addParameter(new CallbackParameter(this, name, mediaType.schema, this.state)) :
            this.addParameter(new CallbackParameter(this, name, undefined, this.state));

          let deserializor: string;

          const ss = mediaType.schema === undefined ? undefinedType : state.project.modelsNamespace.resolveTypeDeclaration(mediaType.schema, true, state);
          const responseType = new mscorlib.LibraryType(`${ClientRuntime.fullName}.Response<${ss.use},${undefinedType.use}>`)

          switch (mimeType) {
            // figure out the deserializor to use for this content type.
            case 'application/json':
            case 'text/json':
              deserializor = // function* () {
                // yield "/* deserialize json */";
                `await ${name}( new ${responseType.use}( async () => ${state.project.supportNamespace.fullName}.JsonSerialization.DeserializeToXXX( Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() ) ) ) { requestMessage = _request,responseMessage = _response }); `
              // };
              break;
            case 'application/xml':
              deserializor = "/* deserialize xml */";

              break;
            default:
              // hmm. not a supported serialization type.
              // do we handle this like a stream response?
              deserializor = "/*todo: other response type */"
          }

          return {
            parameter: callback,
            mimeType: mediaType.accepts,
            deserializor: deserializor
          };
        })
      };
    });

    // add cancellationToken parameter

    const cancellationToken = this.addParameter(new Parameter("cancellationToken", mscorlib.CancellationToken));

    // add eventhandler parameter
    const listener = this.addParameter(new Parameter("listener", EventListenr));

    // add method implementation...
    this.add(function* () {
      const eventListener = new EventListener(listener);

      yield `${listener.value}.cancellationToken = ${cancellationToken.value};`;

      yield `// fire event before validation`;
      yield eventListener.fire("Validation");

      yield EOL;
      yield `// perform parameter validation here`;

      for (const parameter of methodParameters) {
        // spit out parameter validation
        yield parameter.validatePresenceStatement;
        yield parameter.validationStatement;
      }

      // spit out body parameter validation too
      if (bodyParameter) {
        yield bodyParameter.validatePresenceStatement;
        yield bodyParameter.validationStatement;
      }

      yield eventListener.fire("AfterValidation");

      yield EOL;
      yield new Using(listener.value, function* () {
        yield new Using(`var _request = new System.Net.Http.HttpRequestMessage(${ClientRuntime.fullName}.Method.${operation.method.capitalize()}, "http://wherever/...")`, function* () {
          yield eventListener.fire("RequestCreated", '_request');

          yield `System.Net.Http.HttpResponseMessage _response = null;`;
          yield new Try(function* () {
            // try statements
            yield `_response = await this.Sender.SendAsync(_request, ${cancellationToken.value}, ${listener.value});`;
            yield eventListener.fire("ResponseCreated", '_response');
            yield `var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();`

            // add response handlers
            yield new Switch({ value: `_response.StatusCode` }, function* () {
              for (const eachResponse of responseMatrix) {
                if (eachResponse.responseCode !== 'default') {
                  // each response
                  yield new Case(`(System.Net.HttpStatusCode)${eachResponse.responseCode}`, function* () {
                    yield `// on ${eachResponse.responseCode} ... `;

                    for (const eachMime of eachResponse.responses) {
                      if (eachMime.mimeType.length > 0) {
                        yield `if( _contentType == "${eachMime.mimeType[0]}" )`
                        yield '{'
                        yield eachMime.deserializor;
                        yield '}'
                      } else {
                        yield eachMime.deserializor;
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
              /* for (const responseCode in operation.responses) {
                if (responseCode !== 'default') {
                  // each response
                  yield new Case(`(System.Net.HttpStatusCode)${responseCode}`, function* () {
                    yield `// on ${responseCode} ... `;

                    yield EOL;
                  });
                } else {
                  yield new DefaultCase(function* () {
                    yield "// on default ... ";
                    yield EOL;
                  });
                }
              }*/

              if (!operation.responses["default"]) {
                // if no default, we need one that handles the rest of the stuff.
                yield new TerminalDefaultCase(function* () {
                  yield `throw new ${ClientRuntime.fullName}.UndeclaredResponseException(_response.StatusCode);`;
                });
              }
            });
          });

          yield new Finally(function* () {
            yield "// finally statements";
            yield eventListener.fire("Finally", "_request", "_response");
            yield `_response?.Dispose();`
          });

        });

      });

    }
    );


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
