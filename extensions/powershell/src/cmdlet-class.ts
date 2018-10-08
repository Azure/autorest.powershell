/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { escapeString, Dictionary, items, values } from '@microsoft.azure/codegen';
import { KnownMediaType, getAllProperties, JsonType, command } from '@microsoft.azure/autorest.codemodel-v3';

import { TerminalCase, Catch, ForEach, Else, If, Return, Switch, Try, Using, Ternery, LocalVariable, OneOrMoreStatements, Statements, BackedProperty, LambdaProperty, Property, Parameter, Namespace, LambdaMethod, Method, InitializedField, Expression, IsDeclaration, LiteralExpression, StringExpression, toExpression, valueOf, ClassType, dotnet, System, Constructor, Class, Attribute, Access, Modifier } from '@microsoft.azure/codegen-csharp';


import { ClientRuntime, Schema, EventListener } from '@microsoft.azure/autorest.csharp-v2';

import { addPowershellParameters } from './model-cmdlet';
import { Alias, AsyncCommandRuntime, AsyncJob, CmdletAttribute, ErrorCategory, ErrorRecord, Events, OutputTypeAttribute, ParameterAttribute, PSCmdlet, PSCredential, SwitchParameter, ValidateNotNull, verbEnum } from './powershell-declarations';
import { State } from './state';

export class CmdletClass extends Class {
  private cancellationToken!: Expression;
  public state: State;
  private eventListener: EventListener;
  private dropBodyParameter: boolean;

  constructor(namespace: Namespace, operation: command.CommandOperation, state: State, objectInitializer?: Partial<CmdletClass>) {
    // generate the 'variant'  part of the name
    const operationDetails = operation.details.powershell.name; // `${operation.details.powershell.name}${dropBodyParameter ? 'Expanded' : ''}`;
    const variantName = `${state.project.nounPrefix}${operationDetails ? `${operation.noun}_${operationDetails}` : operation.noun}`;

    const name = `${operation.verb}${variantName}`;
    super(namespace, name, PSCmdlet);
    this.dropBodyParameter = operation.details.powershell.dropBodyParameter ? true : false;
    this.apply(objectInitializer);
    this.interfaces.push(ClientRuntime.IEventListener);
    this.state = state;
    this.eventListener = new EventListener(new LiteralExpression(`((${ClientRuntime.IEventListener})this)`), true);
    // basic stuff
    this.addCommonStuff();

    this.description = `Implement a variant of the cmdlet ${operation.verb}-${operation.noun}.`;

    this.add(new Method('BeginProcessing', dotnet.Void, {
      override: Modifier.Override,
      access: Access.Protected,
      description: `(overrides the default BeginProcessing method in ${PSCmdlet})`,
      body: `Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);`
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
    this.add(new Property('Pipeline', ClientRuntime.HttpPipeline, { getAccess: Access.Private, setAccess: Access.Private, description: `The instance of the <see cref="${ClientRuntime.HttpPipeline}" /> that the remote call will use.` }));

    // client API property (gs01: fill this in correctly)
    const clientAPI = new ClassType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);
    this.add(new LambdaProperty('Client', clientAPI, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.ClientAPI`), { description: `The reference to the client API class.` }));

    // Cmdlet Parameters for pipeline manipulations.
    const prepend = this.add(new Property('HttpPipelinePrepend', ClientRuntime.SendAsyncStep, { attributes: [], description: `SendAsync Pipeline Steps to be prepended to the front of the pipeline` }));
    prepend.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline"`] }));
    prepend.add(new Attribute(ValidateNotNull));

    const append = this.add(new Property('HttpPipelineAppend', ClientRuntime.SendAsyncStep, { attributes: [], description: `SendAsync Pipeline Steps to be appended to the front of the pipeline` }));
    append.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline"`] }));
    append.add(new Attribute(ValidateNotNull));

    const proxyCredential = this.add(new Property('ProxyCredential', PSCredential, { attributes: [], description: `Credentials for a proxy server to use for the remote call` }));
    proxyCredential.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "Credentials for a proxy server to use for the remote call"`] }));
    proxyCredential.add(new Attribute(ValidateNotNull));

    const useDefaultCreds = this.add(new Property('ProxyUseDefaultCredentials ', SwitchParameter, { attributes: [], description: `Use the default credentials for the proxy` }));
    useDefaultCreds.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "Use the default credentials for the proxy"`] }));

    const proxyUri = this.add(new Property('Proxy', System.Uri, { attributes: [], description: `The URI for the proxy server to use` }));
    proxyUri.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow= true`, `HelpMessage = "The URI for the proxy server to use"`] }));

    if (this.state.project.azure) {
      const defaultProfile = this.add(new Property('DefaultProfile', dotnet.Object, { description: `The credentials, account, tenant, and subscription used for communication with Azure` }));
      defaultProfile.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure."`] }));
      defaultProfile.add(new Attribute(ValidateNotNull));
      defaultProfile.add(new Attribute(Alias, { parameters: ['"AzureRMContext"', '"AzureCredential"'] }));
    }

    this.add(new Method('StopProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: `Interrupts currently running code within the command.` })).add(function* () {
      yield `((${ClientRuntime.IEventListener})this).Cancel();`;
      yield `base.StopProcessing();`;
    });

    this.add(new Method('EndProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: `Performs clean-up after the command execution` })).add(function* () {
      // gs01: remember what you were doing here to make it so these can be parallelized...
      yield '';
    });
  }

  private isWritableCmdlet(operation: command.CommandOperation): boolean {
    switch (operation.callGraph[0].method.toLowerCase()) {
      case 'put':
      case 'post':
      case 'delete':
      case 'patch':
        return true;
    }
    return false;
  }

  private implementProcessRecord(operation: command.CommandOperation) {
    const $this = this;
    const writable = this.isWritableCmdlet(operation);

    this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override, description: `Performs execution of the command.` })).add(function* () {
      yield $this.eventListener.syncSignal(Events.CmdletProcessRecordStart);
      yield Try(function* () {
        yield `// work`;
        const normal = new Statements(function* () {
          const acr = new LocalVariable('asyncCommandRuntime', dotnet.Var, { initializer: AsyncCommandRuntime.new(dotnet.This, $this.cancellationToken) });
          yield Using(acr.declarationExpression, function* () {
            yield `${acr}.Wait( ProcessRecordAsync(),${$this.cancellationToken});`;
          });
        });

        if (operation.asjob) {
          const asjob = $this.add(new Property('AsJob', SwitchParameter, { description: `when specified, runs this cmdlet as a PowerShell job` }));
          asjob.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', `DontShow=true`, `HelpMessage = "Run the command as a job"`] }));
        }

        const work: OneOrMoreStatements = operation.asjob ? function* () {
          yield If(`true == MyInvocation?.BoundParameters?.ContainsKey("AsJob")`, function* () {
            // clone the cmdlet instance, since the instance can be reused and overwrite data.
            const instance = new LocalVariable(`instance`, dotnet.Var, { initializer: `this.Clone()` });
            yield instance.declarationStatement;

            // create the job (which will set the CommandRuntime of the clone to the AsyncJob itself)
            const job = new LocalVariable('job', dotnet.Var, { initializer: AsyncJob.new(instance, 'this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token', 'this._cancellationTokenSource.Cancel') });
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
      const aggregateException = new Parameter('aggregateException', System.AggregateException);
      yield Catch(aggregateException, function* () {
        yield `// unroll the inner exceptions to get the root cause`;
        yield ForEach('innerException', new LiteralExpression(`${aggregateException.use}.Flatten().InnerExceptions`), function* () {
          yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression(`$"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}"`));
          yield `// Write exception out to error channel.`;
          yield `WriteError( new ${ErrorRecord}(innerException,string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
        });
      });

      const exception = new Parameter('exception', System.Exception);
      yield Catch(exception, function* () {
        yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression(`$"{${exception.use}.GetType().Name} - {${exception.use}.Message} : {${exception.use}.StackTrace}"`));
        yield `// Write exception out to error channel.`;
        yield `WriteError( new ${ErrorRecord}(${exception.use},string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
      });
    });

  }

  private implementProcessRecordAsync(operation: command.CommandOperation) {
    const $this = this;
    const PAR = this.add(new Method('ProcessRecordAsync', System.Threading.Tasks.Task(), {
      access: Access.Protected, async: Modifier.Async,
      description: `Performs execution of the command, working asynchronously if required.`,
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
    }));

    // we don't want to use SynchContext here.
    PAR.push(Using(`NoSynchronizationContext`, ``));

    PAR.add(function* () {
      // construct the call to the operation

      yield $this.eventListener.signal(Events.CmdletGetPipeline);

      const pipeline = $this.$<Property>('Pipeline');

      yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(this.MyInvocation.BoundParameters)`));

      yield pipeline.invokeMethod('Prepend', $this.$<Property>('HttpPipelinePrepend'));
      yield pipeline.invokeMethod('Append', $this.$<Property>('HttpPipelineAppend'));

      yield `// get the client instance`;
      const apiCall = operation.callGraph[0];

      // find each parameter to the method, and find out where the value is going to come from.
      const operationParameters: Array<Expression> = values(apiCall.parameters).linq.where(each => !(each.details.default.constantValue)).linq.select(p => {
        return values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition === p);
      }).linq.select(each => each ? each : new LiteralExpression('null')).linq.toArray();

      // is there a body parameter we should include?
      const requestBody = apiCall.requestBody;
      if (requestBody) {
        // we have a body parameter.
        const bodyParameter = values($this.properties).linq.where(each => each.metadata.parameterDefinition).linq.first(each => each.metadata.parameterDefinition.schema === requestBody.schema);
        if (bodyParameter) {
          operationParameters.push(bodyParameter);
        }
      }

      // create the response handlers
      const responses = [...values(apiCall.responses).linq.selectMany(each => each)];

      const callbackMethods = values(responses).linq.toArray().map(each => new LiteralExpression(each.details.csharp.name));

      // make callback methods
      for (const each of values(responses)) {

        const parameters = new Array<Parameter>();
        parameters.push(new Parameter('responseMessage', System.Net.Http.HttpResponseMessage, { description: `the raw response message as an ${System.Net.Http.HttpResponseMessage}.` }));

        if (each.details.csharp.responseType) {
          parameters.push(new Parameter('response', System.Threading.Tasks.Task({ declaration: each.details.csharp.responseType }), { description: `the body result as a <see cref="${each.details.csharp.responseType}" /> from the remote call` }));
        }
        if (each.details.csharp.headerType) {
          parameters.push(new Parameter('headers', System.Threading.Tasks.Task({ declaration: each.details.csharp.headerType }), { description: `the header result as a <see cref="${each.details.csharp.headerType}" /> from the remote call` }));
        }

        const responseMethod = new Method(`${each.details.csharp.name}`, System.Threading.Tasks.Task(), {
          access: Access.Private,
          parameters,
          async: Modifier.Async,
          description: each.details.csharp.description,
          returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
        });
        responseMethod.push(Using(`NoSynchronizationContext`, ``));

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
                yield `var code = (await response).${codeProp.details.csharp.name};`;
                yield `var message = (await response).${messageProp.details.csharp.name};`;
                yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"[{code}] : {message}"), code.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.join(',')}}));`;
                return;
              } else {
                // yield new LocalVariable('responseMessage', dotnet.Var, { initializer: `response.ResponseMessage as System.Net.Http.HttpResponseMessage` });
                // what do we do with the response object?
                yield `WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {responseMessage.StatusCode}"), responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e) !== 'null').join(',')}}));`;
                return;
              }
            } else {
              // yield new LocalVariable('responseMessage', dotnet.Var, { initializer: `response.ResponseMessage as System.Net.Http.HttpResponseMessage` });
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
                    const result = new LocalVariable('result', dotnet.Var, { initializer: new LiteralExpression(`await response`) });
                    yield result.declarationStatement;
                    // write out the current contents
                    yield `WriteObject(${result.value}.${valueProperty.details.csharp.name},true);`;
                    const nextLinkName = `${result.value}.${nextLinkProperty.details.csharp.name}`;
                    yield (If(`${nextLinkName} != null`,
                      If(`responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage `, function* () {
                        yield `requestMessage = requestMessage.Clone(new System.Uri( ${nextLinkName} ),${ClientRuntime.Method.Get} );`;
                        yield $this.eventListener.signal(Events.FollowingNextLink);
                        yield `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.details.csharp.name}_Call`, ...[toExpression('requestMessage'), ...callbackMethods, dotnet.This, pipeline]).implementation}`;
                      })
                    ));
                    return;
                  } else if (valueProperty) {
                    // it's just a nested array
                    yield `WriteObject((await response).${valueProperty.details.csharp.name}, true);`;
                    return;
                  }
                  break;

                // it's just an array,
                case `array`:
                  // just write-object(enumerate) with the output
                  yield `WriteObject(await response, true);`;
                  return;
              }
              // ok, let's see if the response type
            }
            // we expect to get back some data from this call.

            yield `// (await response) // should be ${$this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, $this.state).declaration}`;

            const props = getAllProperties(schema);
            if (props.length === 1) {
              // let's unroll this and write out the single property
              yield `WriteObject((await response).${props[0].details.csharp.name});`;
              return;
            }

            // more than one property, let's just return the result object
            yield `WriteObject(await response);`;
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

  private implementSerialization(operation: command.CommandOperation) {
    const $this = this;
    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject, { description: `The <see cref="${ClientRuntime.JsonObject}"/> container to serialize this object into. If the caller passes in <c>null</c>, a new instance will be created and returned to the caller.` });
    const mode = new Parameter('serializationMode', ClientRuntime.SerializationMode, { description: `Allows the caller to choose the depth of the serialization. See <see cref="${ClientRuntime.SerializationMode}"/>.` });

    const toJsonMethod = this.add(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
      description: `Serializes the state of this cmdlet to a <see cref="${ClientRuntime.JsonNode}" /> object.`,
      returnsDescription: `a serialized instance of <see cref="${this.name}" /> as a <see cref="${ClientRuntime.JsonNode}" />.`
    }));
    toJsonMethod.add(function* () {
      yield `// serialization method`;
      yield `container = ${container.use} ?? new ${ClientRuntime.JsonObject.declaration}();`;

      for (const parameter of values(operation.parameters)) {
        const td = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, true /*parameter.required*/, $this.state);
        if (!(parameter.details.default.constantValue)) {
          yield td.serializeToContainerMember(KnownMediaType.Json, parameter.details.powershell.name, container, parameter.details.powershell.name);
        }
      }

      yield `return container;`;
    });

    // create the FromJson method
    const node = new Parameter('node', ClientRuntime.JsonNode, { description: `a <see cref="${ClientRuntime.JsonNode}" /> to deserialize from.` });
    const fromJson = this.addMethod(new Method('FromJson', this, {
      parameters: [node],
      static: Modifier.Static,
      description: `Deserializes a <see cref="${ClientRuntime.JsonNode}" /> into a new instance of this class.`,
      returnsDescription: `an instance of ${this.name}.`
    }));
    fromJson.add(function* () {
      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');
      yield Return(Ternery(json.check, $this.new(json), dotnet.Null));
    });

    // from/to json-string
    const strJson = new Parameter('jsonText', dotnet.String, { description: 'a string containing a JSON serialized instance of this cmdlet.' });
    this.add(new LambdaMethod('FromJsonString', this, new LiteralExpression(`string.IsNullOrEmpty(${strJson.value}) ? null : ${fromJson.invoke(ClientRuntime.JsonObject.Parse(strJson)).toString()}`), {
      parameters: [strJson],
      static: Modifier.Static,
      description: `Creates a new instance of this cmdlet, deserializing the content from a json string.`,
      returnsDescription: `returns a new instance of the <see cref="${this.name}" /> cmdlet`
    }));

    // clone
    const clone = this.add(new Method('Clone', this, {
      description: `Creates a duplicate instance of this cmdlet (via JSON serialization).`,
      returnsDescription: `a duplicate instance of ${this.name}`,
    }));
    clone.add(function* () {
      const i = new LocalVariable('clone', dotnet.Var, {
        initializer: fromJson.invoke(new LiteralExpression(`this.${toJsonMethod.invoke(dotnet.Null, ClientRuntime.SerializationMode.IncludeAll).value}`))
      });
      yield i.declarationStatement;
      yield `${i.value}.HttpPipelinePrepend = this.HttpPipelinePrepend;`;
      yield `${i.value}.HttpPipelineAppend = this.HttpPipelineAppend;`;

      yield Return(i);
    });
  }

  private implementConstructors(operation: command.CommandOperation) {
    const $this = this;
    // default constructor
    this.add(new Constructor(this, { description: `Intializes a new instance of the <see cref="${this.name}" /> cmdlet class.` }));

    // deserialization constructor
    const deserializerConstructor = this.add(new Constructor(this, {
      parameters: [new Parameter('json', ClientRuntime.JsonObject, { description: `a <see cref="${ClientRuntime.JsonObject}" /> to deserialize from.` })],
      access: Access.Internal,
      description: `Constructor for deserialization.`

    }));
    deserializerConstructor.add(function* () {
      yield `// deserialize the contents`;
      for (const parameter of values(operation.parameters)) {
        const td = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, true /*parameter.required*/, $this.state);

        if (!(parameter.details.default.constantValue)) {
          const bp = <BackedProperty>$this.$<Property>(parameter.details.powershell.name);

          // dont' serialize if it's a constant or host parameter.
          // yield td.getDeserializePropertyStatement(KnownMediaType.Json, 'json', bp.backingName, parameter.details.powershell.name);
          yield bp.assignPrivate(td.deserializeFromContainerMember(KnownMediaType.Json, 'json', parameter.details.powershell.name, bp));

        }

      }
    });
  }

  private implementIEventListener() {
    const $this = this;
    const cts = this.add(new InitializedField('_cancellationTokenSource', System.Threading.CancellationTokenSource, new LiteralExpression(`new ${System.Threading.CancellationTokenSource.declaration}()`), {
      access: Access.Private,
      description: `The <see cref="${System.Threading.CancellationTokenSource}" /> for this operation.`
    }));
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Token`, System.Threading.CancellationToken, new LiteralExpression(`${cts.value}.Token`), { getAccess: Access.Default, setAccess: Access.Default, description: `<see cref="IEventListener" /> cancellation token.` }));
    this.cancellationToken = toExpression(`((${ClientRuntime.IEventListener})this).Token`);
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Cancel`, System.Action(), new LiteralExpression(`${cts.value}.Cancel`), { getAccess: Access.Default, setAccess: Access.Default, description: `<see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.` }));

    const id = new Parameter('id', dotnet.String, { description: `The message id` });
    const token = new Parameter('token', System.Threading.CancellationToken, { description: `The message cancellation token. When this call is cancelled, this should be <c>true</c>` });
    const messageData = new Parameter('messageData', System.Func(ClientRuntime.EventData), { description: `Detailed message data for the message event.` });
    const signalMethod = this.add(new Method(`${ClientRuntime.IEventListener}.Signal`, System.Threading.Tasks.Task(), {
      async: Modifier.Async,
      parameters: [id, token, messageData],
      access: Access.Default,
      description: `Handles/Dispatches events during the call to the REST service.`,
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the message is completed.`
    }));
    signalMethod.push(Using(`NoSynchronizationContext`, ``));

    signalMethod.add(function* () {
      yield If(`${token.value}.IsCancellationRequested`, Return());

      yield Switch(id, [
        TerminalCase(Events.Verbose.value, function* () {
          yield `WriteVerbose($"{messageData().Message ?? ${System.String.Empty}}");`;
          yield Return();
        }),
        TerminalCase(Events.Warning.value, function* () {
          yield `WriteWarning($"{messageData().Message ?? ${System.String.Empty}}");`;
          yield Return();
        }),
        TerminalCase(Events.Information.value, function* () {
          const data = new LocalVariable('data', dotnet.Var, { initializer: new LiteralExpression(`${messageData.use}()`) });
          yield data.declarationStatement;
          yield `WriteInformation(data, new[] { data.Message });`;
          yield Return();
        }),
        TerminalCase(Events.Debug.value, function* () {
          yield `WriteDebug($"{messageData().Message ?? ${System.String.Empty}}");`;
          yield Return();
        }),
        TerminalCase(Events.Error.value, function* () {
          yield `WriteError(new System.Management.Automation.ErrorRecord( new System.Exception(messageData().Message), string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null ) );`;
          yield Return();
        }),
      ]);

      if ($this.state.project.azure) {
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i,t,m) => ((${ClientRuntime.IEventListener})this).Signal(i,t,()=> ${ClientRuntime.EventDataConverter}.ConvertFrom( m() ) as ${ClientRuntime.EventData} ) );`;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      }
      yield `WriteDebug($"{id}: {messageData().Message ?? ${System.String.Empty}}");`;
      // any handling of the signal on our side...
    });
  }

  private addPowershellParameters(operation: command.CommandOperation) {
    for (const parameter of values(operation.parameters)) {
      // these are the parameters that this command expects
      // create a single

      const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, /*parameter.required*/ true, this.state);

      if (parameter.details.default.constantValue) {
        // this parameter has a constant value -- SKIP IT
        /*
        // don't give it a parameter attribute
        const cmdletParameter = this.add(new LambdaProperty(parameter.details.powershell.name, td, new StringExpression(parameter.details.default.constantValue), {
          metadata: {
            parameterDefinition: parameter
          },
        }));
        */
      } else if (parameter.details.default.fromHost) {
        // the parameter is expected to be gotten from the host.
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter.details.default.originalParam
          },
          description: parameter.details.powershell.description,
        }));
        this.$<Method>('BeginProcessing').add(cmdletParameter.assignPrivate(new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.GetParameter(this.MyInvocation.BoundParameters, "${parameter.name}") as string`)));
        // in the BeginProcessing, we should tell it to go get the value for this property from the common module

      } else if (this.dropBodyParameter && parameter.details.powershell.isBodyParameter) {
        // we're supposed to use parameters for the body parameter instead of a big object
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter
          },
          description: parameter.details.powershell.description,
          initializer: (parameter.schema.type === JsonType.Array) ? `null` : `new ${parameter.schema.details.csharp.fullname}()`,
          setAccess: Access.Private,
          getAccess: Access.Private,

        }));

        addPowershellParameters(this, <Schema>parameter.schema, cmdletParameter);

      } else {
        // regular cmdlet parameter
        const cmdletParameter = this.add(new BackedProperty(parameter.details.powershell.name, td, {
          metadata: {
            parameterDefinition: parameter
          },
          description: parameter.details.powershell.description
        }));
        if (!parameter.details.powershell.isBodyParameter) {
          cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression('Mandatory = true'), new LiteralExpression(`HelpMessage = "${escapeString(parameter.details.powershell.description) || 'HELP MESSAGE MISSING'}"`)] }));
        } else {
          cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression('Mandatory = true'), new LiteralExpression(`HelpMessage = "${escapeString(parameter.details.powershell.description) || 'HELP MESSAGE MISSING'}"`), new LiteralExpression('ValueFromPipeline = true')] }));
        }
      }
    }
  }

  private addClassAttributes(operation: command.CommandOperation, variantName: string) {

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

      for (const item of items(op.responses).linq.where(each => each.key !== 'default')) {

        for (const schema of values(item.value).linq.selectNonNullable(each => each.schema)) {
          const props = getAllProperties(schema);

          // does the target type just wrap a single output?
          const td = props.length !== 1 ?
            this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, this.state) :
            this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>props[0].schema, true, this.state);

          if (td) {
            if (!rt[td.declaration]) {
              rt[td.declaration] = true;
              this.add(new Attribute(OutputTypeAttribute, { parameters: [`typeof(${td.declaration})`] }));
            }
          }
        }
      }
    }
  }
}
