import { CommandOperation } from '#common/code-model/command-operation';
import { MediaType } from '#common/code-model/http-operation';
import { getAllProperties } from '#common/code-model/schema';
import { Dictionary, items, values } from '#common/dictionary';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Attribute } from '#csharp/code-dom/attribute';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { IsDeclaration, LambdaExpression, LiteralExpression, StringExpression, Expression, valueOf } from '#csharp/code-dom/expression';
import { Field, InitializedField } from '#csharp/code-dom/field';
import { LambdaMethod, Method } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Var } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { BackedProperty, LambdaProperty, Property } from '#csharp/code-dom/property';
import { Case, TerminalCase } from '#csharp/code-dom/statements/case';
import { Catch } from '#csharp/code-dom/statements/catch';
import { ForEach, ForEachStatement } from '#csharp/code-dom/statements/for';
import { Else, If } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { Statements, OneOrMoreStatements } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Try } from '#csharp/code-dom/statements/try';
import { Using } from '#csharp/code-dom/statements/using';
import { Ternery } from '#csharp/code-dom/ternery';
import { LocalVariable, Variable } from '#csharp/code-dom/variable';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { EventListener } from '#csharp/lowlevel-generator/operation/method';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { CmdletParameter } from './cmdlet-parameter';
import { Alias, AsyncCommandRuntime, AsyncJob, CmdletAttribute, ErrorCategory, ErrorRecord, Events, OutputTypeAttribute, ParameterAttribute, ValidateNotNull, verbEnum, SwitchParameter } from './powershell-declarations';
import { State } from './state';
import { addPowershellParameters } from '#powershell/model-cmdlet';
import { escapeString } from '#common/text-manipulation';

export const PSCmdlet = new Class(new Namespace('System.Management.Automation'), 'PSCmdlet');

export class CmdletClass extends Class {
  private cancellationToken!: Property;
  public state: State;
  private eventListener: EventListener;
  private dropBodyParameter: boolean;

  constructor(namespace: Namespace, operation: CommandOperation, state: State, dropBodyParameter?: boolean, objectInitializer?: Partial<CmdletClass>) {

    const variantName = `${operation.noun}_${operation.details.powershell.name}${dropBodyParameter ? 'Expanded' : ''}`;
    const name = `${operation.verb}${variantName}`;
    super(namespace, name, PSCmdlet);
    this.dropBodyParameter = dropBodyParameter ? true : false;
    this.apply(objectInitializer);
    this.interfaces.push(ClientRuntime.IEventListener);
    this.state = state;
    this.eventListener = new EventListener(new LiteralExpression('this'));
    // basic stuff
    this.addCommonStuff();

    this.add(new Method('BeginProcessing', dotnet.Void, {
      override: Modifier.Override,
      access: Access.Protected,
    }));

    // construct the class
    this.addClassAttributes(operation, variantName);
    this.addPowershellParameters(operation);

    // implement IEventListener
    this.implementIEventListener();

    // add constructors
    this.implementConstructors(operation);

    // json serialization
    this.implementSerialization(operation);

    // processRecord
    this.implementProcessRecord(operation);

    this.implementProcessRecordAsync(operation);
  }

  private addCommonStuff() {

    // pipeline property
    this.add(new Property('Pipeline', ClientRuntime.HttpPipeline, { getAccess: Access.Private, setAccess: Access.Private }));

    // client API property (todo: fill this in correctly)
    const clientAPI = new dotnet.LibraryType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);
    this.add(new LambdaProperty('Client', clientAPI, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.ClientAPI`)));

    // Cmdlet Parameters for pipeline manipulations.
    const prepend = this.add(new Property('HttpPipelinePrepend', ClientRuntime.SendAsyncStep, { attributes: [] }));
    prepend.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline"`] }));
    prepend.add(new Attribute(ValidateNotNull));

    const append = this.add(new Property('HttpPipelineAppend', ClientRuntime.SendAsyncStep, { attributes: [] }));
    append.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline"`] }));
    append.add(new Attribute(ValidateNotNull));

    const asjob = this.add(new Property('AsJob', SwitchParameter));
    asjob.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow=true`, `HelpMessage = "Run the command as a job"`] }));

    const proxyCredential = this.add(new Property('ProxyCredential', new dotnet.LibraryType('System.Management.Automation', 'PSCredential'), { attributes: [] }));
    proxyCredential.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "Credentials for a proxy server to use for the remote call"`] }));
    proxyCredential.add(new Attribute(ValidateNotNull));

    const useDefaultCreds = this.add(new Property('ProxyUseDefaultCredentials ', new dotnet.LibraryType('System.Management.Automation', 'SwitchParameter'), { attributes: [] }));
    useDefaultCreds.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "Use the default credentials for the proxy"`] }));

    const proxyUri = this.add(new Property('Proxy ', dotnet.System.Uri, { attributes: [] }));
    proxyUri.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "The URI for the proxy server to use"`] }));

    if (this.state.project.azure) {
      const defaultProfile = this.add(new Property('DefaultProfile', dotnet.Object));
      defaultProfile.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure."`] }));
      defaultProfile.add(new Attribute(ValidateNotNull));
      defaultProfile.add(new Attribute(Alias, { parameters: ['"AzureRMContext"', '"AzureCredential"'] }));
    }

    this.add(new Method('StopProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override })).add(function* () {
      yield `Cancel();`;
      yield `base.StopProcessing();`;
    });

    this.add(new Method('EndProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override })).add(function* () {
      // todo: remember what you were doing here to make it so these can be parallelized...
      yield '';
    });
  }

  private isWritableCmdlet(operation: CommandOperation): boolean {
    switch (operation.callGraph[0].method.toLowerCase()) {
      case "put":
      case "post":
      case "delete":
      case "patch":
        return true;
    }
    return false;
  }

  private implementProcessRecord(operation: CommandOperation) {
    const $this = this;
    const writable = this.isWritableCmdlet(operation);

    this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override })).add(function* () {
      yield $this.eventListener.syncSignal(Events.CmdletProcessRecordStart);
      yield Try(function* () {
        yield `// work`;
        const normal = new Statements(function* () {
          const acr = new LocalVariable('asyncCommandRuntime', dotnet.Var, { initializer: AsyncCommandRuntime.newInstance(dotnet.This, $this.cancellationToken) });
          yield Using(acr.declarationExpression, function* () {
            yield `${acr}.Wait( ProcessRecordAsync(),${$this.cancellationToken});`;
          });
        });

        const work: OneOrMoreStatements = operation.asjob ? function* () {
          yield If(`true == MyInvocation?.BoundParameters?.ContainsKey("AsJob")`, function* () {
            // clone the cmdlet instance, since the instance can be reused and overwrite data.
            const instance = new LocalVariable(`instance`, dotnet.Var, { initializer: `this.Clone()` });
            yield instance.declarationStatement;

            // create the job (which will set the CommandRuntime of the clone to the AsyncJob itself)
            const job = new LocalVariable('job', dotnet.Var, { initializer: AsyncJob.newInstance(instance, 'this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token', 'this._cancellationTokenSource.Cancel') });
            yield job.declarationStatement;

            // add the job to the repository
            yield `JobRepository.Add(${job});`;

            // invoke the cmdlet's PRA
            const task = new LocalVariable(`task`, dotnet.Var, { initializer: `${instance}.ProcessRecordAsync()` });
            yield task.declarationStatement;

            // have the AsyncJob monitor the lifetime of the Task
            yield `${job}.Monitor(${task});`;

            // return the job to the user now.
            yield `WriteObject(${job});`;


          });
          yield Else(normal);
        } : normal;

        if (writable) {
          yield If(`ShouldProcess($"Call remote '${operation.callGraph[0].details.default.name}' operation")`, work);
        } else {
          yield work;
        }
      });
      const aggregateException = new Parameter('aggregateException', dotnet.System.AggregateException);
      yield Catch(aggregateException, function* () {
        yield `// unroll the inner exceptions to get the root cause`;
        yield ForEach('innerException', new LiteralExpression(`${aggregateException.use}.Flatten().InnerExceptions`), function* () {
          yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression(`$"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}"`));
          yield `// Write exception out to error channel.`;
          yield `WriteError( new ${ErrorRecord}(innerException,string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
        });
      });

      const exception = new Parameter('exception', dotnet.System.Exception);
      yield Catch(exception, function* () {
        yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression(`$"{${exception.use}.GetType().Name} - {${exception.use}.Message} : {${exception.use}.StackTrace}"`));
        yield `// Write exception out to error channel.`;
        yield `WriteError( new ${ErrorRecord}(${exception.use},string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
      });
    });

  }

  private implementProcessRecordAsync(operation: CommandOperation) {
    const $this = this;
    this.add(new Method('ProcessRecordAsync', dotnet.System.Threading.Tasks.Task(), { access: Access.Protected, async: Modifier.Async })).add(function* () {
      // construct the call to the operation

      yield $this.eventListener.signal(Events.CmdletGetPipeline);
      // const pipeline = new LocalVariable('pipeline', dotnet.Var, { initializer: new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(this.MyInvocation.BoundParameters)`) });
      const pipeline = $this.$<Property>('Pipeline');

      yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(this.MyInvocation.BoundParameters)`));

      yield pipeline.invokeMethod('Prepend', $this.$<Property>('HttpPipelinePrepend'));
      yield pipeline.invokeMethod('Append', $this.$<Property>('HttpPipelineAppend'));

      yield `// get the client instance`;
      const apiCall = operation.callGraph[0];

      // find each parameter to the method, and find out where the value is going to come from.
      const operationParameters: Array<Expression> = values(apiCall.parameters).linq.select(p => {
        return values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition === p);
      }).linq.select(each => each ? each : new LiteralExpression('null')).linq.toArray();

      // is there a body parameter we should include?
      const requestBody = apiCall.requestBody;
      if (requestBody && requestBody.content['application/json'] && requestBody.content['application/json'].schema) {
        // we have a body parameter.
        const bodyParameter = values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition.schema === requestBody.content['application/json'].schema);
        if (bodyParameter) {
          operationParameters.push(bodyParameter);
        }
      }

      // how many inputs is the api expecting
      const inputParameters = operationParameters.length;

      // create the response handlers
      const responses = [...values(apiCall.responses_new).linq.selectMany(each => each)];

      const callbackMethods = values(responses).linq.toArray().map(each => new LiteralExpression(each.details.csharp.name));

      // make callback methods
      for (const each of values(responses)) {
        const responseParameter = new Parameter('response', new dotnet.LibraryType(ClientRuntime, each.details.csharp.type));
        const responseMethod = new Method(`${each.details.csharp.name}`, dotnet.System.Threading.Tasks.Task(), { access: Access.Private, parameters: [responseParameter], async: Modifier.Async });
        responseMethod.add(function* () {
          if (each.details.csharp.isErrorResponse) {
            // this should write an error to the error channel.
            yield `// Error Response : ${each.responseCode} `;
            if (each.schema) {
              // the schema should be the error information.
              const props = getAllProperties(each.schema);
              const codeProp = values(props).linq.first(p => p.details.csharp.name === 'Code');
              const messageProp = values(props).linq.first(p => p.details.csharp.name === 'Message');
              if (codeProp && messageProp) {
                yield `var code = (await response.Result).${codeProp.details.csharp.name};`;
                yield `var message = (await response.Result).${messageProp.details.csharp.name};`;
                yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"[{code}] : {message}"), code.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.join(',')}}));`;
                return;
              } else {
                yield new LocalVariable("responseMessage", dotnet.Var, { initializer: `response.ResponseMessage as System.Net.Http.HttpResponseMessage` });
                // what do we do with the response object?
                yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {responseMessage.StatusCode}"), responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e) !== 'null').join(',')}}));`;
                return;
              }
            } else {
              yield new LocalVariable("responseMessage", dotnet.Var, { initializer: `response.ResponseMessage as System.Net.Http.HttpResponseMessage` });
              // all we know is that this was an error, and we can't proceed.
              yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {responseMessage.StatusCode}"), responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e) !== 'null').join(',')}}));`;
              return;
            }
          }

          yield `// ${each.details.csharp.name} - response for ${each.responseCode} / ${each.mimeTypes.join('/')}`;
          if (each.schema) {
            const schema = each.schema;

            if (apiCall.details.csharp.pageable) {
              const pageable = apiCall.details.csharp.pageable;
              yield `// response should be returning an array of some kind. +Pageable`;
              yield `// ${pageable.responseType} / ${pageable.itemName || '<none>'} / ${pageable.nextLinkName || '<none>'}`;
              switch (pageable.responseType) {
                // the result is (or works like a x-ms-pageable)
                case `pageable`:
                case `nested-array`:
                  const valueProperty = schema.properties[pageable.itemName];
                  const nextLinkProperty = schema.properties[pageable.nextLinkName];
                  if (valueProperty && nextLinkProperty) {
                    // it's pageable!
                    const result = new LocalVariable('result', dotnet.Var, { initializer: new LiteralExpression(`await response.Result`) });
                    yield result.declarationStatement;
                    // write out the current contents
                    yield `WriteObject(${result.value}.${valueProperty.details.csharp.name},true);`;
                    const nextLinkName = `${result.value}.${nextLinkProperty.details.csharp.name}`;
                    yield (If(`${nextLinkName} != null`,
                      If(`response.RequestMessage is System.Net.Http.HttpRequestMessage req `, function* () {
                        yield `req = req.Clone(new System.Uri( ${nextLinkName} ),Microsoft.Rest.ClientRuntime.Method.Get );`;
                        yield $this.eventListener.signal(Events.FollowingNextLink);
                        yield `await this.${$this.$<Property>('Client').invokeMethod(apiCall.details.csharp.name, ...[...operationParameters, ...callbackMethods, dotnet.This, pipeline]).implementation}`;
                      })
                    ));
                    return;
                  } else if (valueProperty) {
                    // it's just a nested array
                    yield `WriteObject((await response.Result).${valueProperty.details.csharp.name}, true);`;
                    return;
                  }
                  break;

                // it's just an array,
                case `array`:
                  // just write-object(enumerate) with the output
                  yield `WriteObject(await response.Result, true);`;
                  return;
              }
              // ok, let's see if the response type
            }
            // we expect to get back some data from this call.

            yield `// (await response.Result) // should be ${$this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, $this.state).declaration}`;

            const props = getAllProperties(schema);
            if (props.length === 1) {
              // let's unroll this and write out the single property
              yield `WriteObject((await response.Result).${props[0].details.csharp.name});`;
              return;
            }

            // more than one property, let's just return the result object
            yield `WriteObject(await response.Result);`;
            return;
          }

          // no return type. Let's just return ... true?
          yield `WriteObject(true);`;
        });
        $this.add(responseMethod);
      }

      // make the call.
      yield $this.eventListener.signal(Events.CmdletBeforeAPICall);
      yield `await this.${$this.$<Property>('Client').invokeMethod(apiCall.details.csharp.name, ...[...operationParameters, ...callbackMethods, dotnet.This, pipeline]).implementation}`;
      yield $this.eventListener.signal(Events.CmdletAfterAPICall);
    });
  }



  private implementSerialization(operation: CommandOperation) {
    const $this = this;
    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject);
    const mode = new Parameter('serializationMode', ClientRuntime.JsonMode);

    const toJsonMethod = this.add(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
    }));
    toJsonMethod.add(function* () {
      yield `// serialization method`;
      yield `container = ${container.use} ?? new ${ClientRuntime.JsonObject.declaration}();`;

      for (const parameter of values(operation.parameters)) {
        const td = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, $this.state);
        if (!(parameter.details.default.constantValue)) {
          yield td.jsonSerializationImplementation(container.use, parameter.details.powershell.name, parameter.details.powershell.name);
        }
      }

      // yield `bool returnNow = false;`;
      // yield `${$this.btj.name}(ref result, ref returnNow);`;

      //      yield If({ value: `returnNow` }, `return result;`);

      // yield `${$this.atj.name}(ref result);`;
      yield `return container;`;
    });

    // create the FromJson method
    const node = new Parameter('node', ClientRuntime.JsonNode);
    const fromJson = this.addMethod(new Method('FromJson', this, { parameters: [node], static: Modifier.Static }));
    fromJson.add(function* () {
      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');
      yield Return(Ternery(json.check, $this.newInstance(json), dotnet.Null));
    });

    // from/to json-string
    const strJson = new Parameter('jsonText', dotnet.String);
    this.add(new LambdaMethod('FromJsonString', this, new LiteralExpression(`string.IsNullOrEmpty(${strJson.value}) ? null : ${fromJson.invoke(new LiteralExpression(`Carbon.Json.JsonObject.Parse(${strJson.value})`)).value}`), { parameters: [strJson], static: Modifier.Static }));

    // clone
    const clone = this.add(new Method('Clone', this));
    clone.add(function* () {
      const i = new LocalVariable('clone', Var, {
        initializer: fromJson.invoke(new LiteralExpression(`this.${toJsonMethod.invoke(dotnet.Null, ClientRuntime.JsonMode.IncludeAll).value}`))
      });
      yield i.declarationStatement;
      yield `${i.value}.HttpPipelinePrepend = this.HttpPipelinePrepend;`;
      yield `${i.value}.HttpPipelineAppend = this.HttpPipelineAppend;`;
      // yield `i.Pipeline = this.Pipeline`; //todo: pass thru these
      // yield `i.Client = this.Client`;

      yield Return(i);
    });
  }

  private implementConstructors(operation: CommandOperation) {
    const $this = this;
    // default constructor
    this.add(new Constructor(this));

    // deserialization constructor
    const deserializerConstructor = this.add(new Constructor(this, { parameters: [new Parameter('json', ClientRuntime.JsonObject)], access: Access.Internal }));
    deserializerConstructor.add(function* () {
      yield `// deserialize the contents`;
      for (const parameter of values(operation.parameters)) {
        const td = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, $this.state);
        const bp = <BackedProperty>$this.$<Property>(parameter.details.powershell.name);
        if (!(parameter.details.default.constantValue)) {
          // dont' serialize if it's a constant or host parameter.
          yield td.jsonDeserializationImplementationOnProperty('json', bp.backingName, parameter.details.powershell.name);
        }

      }
    });
  }

  private implementIEventListener() {
    const $this = this;
    const _cts = this.add(new InitializedField('_cancellationTokenSource', dotnet.System.Threading.CancellationTokenSource, new LiteralExpression(`new ${dotnet.System.Threading.CancellationTokenSource.declaration}()`), { access: Access.Private }));
    this.cancellationToken = this.add(new LambdaProperty('Token', dotnet.System.Threading.CancellationToken, new LiteralExpression(`${_cts.value}.Token`)));
    this.add(new LambdaProperty('Cancel', dotnet.System.Action(), new LiteralExpression(`${_cts.value}.Cancel`)));


    const id = new Parameter('id', dotnet.String);
    const token = new Parameter('token', dotnet.System.Threading.CancellationToken);
    const messageData = new Parameter('messageData', dotnet.System.Func(ClientRuntime.EventData));
    this.add(new Method('Signal', dotnet.System.Threading.Tasks.Task(), { async: Modifier.Async, parameters: [id, token, messageData] })).add(function* () {
      yield If(`${token.value}.IsCancellationRequested`, Return());

      yield Switch(id, [
        TerminalCase(Events.Verbose.value, function* () {
          yield `WriteVerbose($"{messageData().Message ?? ""}");`;
          yield Return();
        }),
        TerminalCase(Events.Warning.value, function* () {
          yield `WriteWarning($"{messageData().Message ?? ""}");`;
          yield Return();
        }),
        TerminalCase(Events.Information.value, function* () {
          const data = new LocalVariable('data', dotnet.Var, { initializer: new LiteralExpression(`${messageData.use}()`) });
          yield data.declarationStatement;
          yield `WriteInformation(data, new[] { data.Message });`;
          yield Return();
        }),
        TerminalCase(Events.Debug.value, function* () {
          yield `WriteDebug($"{messageData().Message ?? ""}");`;
          yield Return();
        }),
        TerminalCase(Events.Error.value, function* () {
          yield `WriteError(new System.Management.Automation.ErrorRecord( new System.Exception(messageData().Message), string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null ) );`;
          yield Return();
        }),
      ]);

      if ($this.state.project.azure) {
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i,t,m)=> Signal(i,t,()=> Microsoft.Rest.ClientRuntime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Rest.ClientRuntime.EventData ) );`;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      }
      yield `WriteDebug($"{id}: {messageData().Message ?? ""}");`;
      // any handling of the signal on our side...
    });
  }

  private addPowershellParameters(operation: CommandOperation) {
    for (const parameter of values(operation.parameters)) {
      // these are the parameters that this command expects
      // create a single

      const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, parameter.required, this.state);

      if (parameter.details.default.constantValue) {
        // this parameter has a constant value
        // don't give it a parameter attribute
        const cmdletParameter = this.add(new LambdaProperty(parameter.details.powershell.name, td, new StringExpression(parameter.details.default.constantValue), {
          metadata: {
            parameterDefinition: parameter
          },
        }));
      } else if (parameter.details.default.fromHost) {
        // the parameter is expected to be gotten from the host.
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter.details.default.originalParam
          },
        }));
        this.$<Method>('BeginProcessing').add(cmdletParameter.assignPrivate(new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.GetParameter(this.MyInvocation.BoundParameters, "${parameter.name}") as string`)));
        // in the BeginProcessing, we should tell it to go get the value for this property from the common module

      } else if (this.dropBodyParameter && parameter.details.powershell.isBodyParameter) {
        // we're supposed to use parameters for the body parameter instead of a big object
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter
          },
          initializer: `new ${parameter.schema.details.csharp.fullname}()`
        }));

        addPowershellParameters(this, <Schema>parameter.schema, cmdletParameter);

      } else {
        // regular cmdlet parameter
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter
          }
        }));
        if (!parameter.details.powershell.isBodyParameter) {
          cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression('Mandatory = true'), new LiteralExpression(`HelpMessage = "${escapeString(parameter.details.powershell.description) || 'HELP MESSAGE MISSING'}"`)] }));
        } else {
          cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression('Mandatory = true'), new LiteralExpression(`HelpMessage = "${escapeString(parameter.details.powershell.description) || 'HELP MESSAGE MISSING'}"`), new LiteralExpression('ValueFromPipeline = true')] }));
        }
      }
    }
  }

  private addClassAttributes(operation: CommandOperation, variantName: string) {

    if (this.isWritableCmdlet(operation)) {
      // add should process
      this.add(new Attribute(CmdletAttribute, { parameters: [verbEnum(operation.category, operation.verb), new StringExpression(variantName), `SupportsShouldProcess = true`] }));
    } else {
      this.add(new Attribute(CmdletAttribute, { parameters: [verbEnum(operation.category, operation.verb), new StringExpression(variantName)] }));
    }

    const rt = new Dictionary<boolean>();
    for (const op of values(operation.callGraph)) {

      /* testing
      for (const schema of
        values(operation.callGraph).linq
          .selectMany(httpOperation => items(httpOperation.responses)).linq
          .where(each => each.key !== 'default').linq
          .select(each => each.value).linq
          .selectMany(response => values(response.content)).linq
          .distinct(mediaType => mediaType.schema).linq
          .selectNonNullable(mediaType => mediaType.schema)) {
        console.error(`it is ${schema.details.csharp.name}`);
      }
      */

      for (const item of items(op.responses_new).linq.where(each => each.key !== 'default')) {

        for (const schema of values(item.value).linq.selectNonNullable(each => each.schema)) {
          const props = getAllProperties(schema);

          // does the target type just wrap a single output?
          const td = props.length !== 1 ?
            this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, this.state) :
            this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>props[0].schema, true, this.state);

          if (td) {
            if (!rt[td.declaration]) {
              rt[td.declaration] = true;
              this.add(new Attribute(OutputTypeAttribute, { parameters: [{ value: `typeof(${td.declaration})` }] }));
            }
          }
        }
      }
    }
  }
}
