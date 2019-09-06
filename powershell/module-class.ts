/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Access, Alias, Class, ClassType, Constructor, dotnet, Field, LambdaMethod, LambdaProperty, LazyProperty, LiteralExpression, LocalVariable, MemberVariable, Method, Modifier, Namespace, Parameter, ParameterModifier, PartialMethod, Property, Return, Statements, StringExpression, System, TypeDeclaration, Using, valueOf, Variable } from '@azure-tools/codegen-csharp';

import { InvocationInfo, PSCredential, IArgumentCompleter, CompletionResult, CommandAst, CompletionResultType, } from './powershell-declarations';
import { State } from './state';
import { ClientRuntime } from './llcsharp/exports';

export class ModuleClass extends Class {

  // get the name of the client API class
  TaskOfHttpResponseMessage = System.Threading.Tasks.Task(System.Net.Http.HttpResponseMessage);

  // lets the common code call the signal again (recursive! careful!)
  incomingSignalFunc = System.Func(
    dotnet.String,
    System.Threading.CancellationToken,
    System.Func(System.EventArgs),
    /* returns */ System.Threading.Tasks.Task());

  eventListenerFunc = System.Func(
    dotnet.String,
    System.Threading.CancellationToken,
    System.Func(System.EventArgs),
    this.incomingSignalFunc,
    InvocationInfo,
    dotnet.String,
    dotnet.String,
    dotnet.String,
    System.Exception,
    /* returns */ System.Threading.Tasks.Task());

  IEventListenerExpanded = [
    System.Threading.CancellationToken, /* token */
    System.Action(),                    /* Cancel() */
    this.incomingSignalFunc,
  ];

  nextStep = System.Func(
    System.Net.Http.HttpRequestMessage,
    ...this.IEventListenerExpanded,
    /* returns */ this.TaskOfHttpResponseMessage);

  initMethod = this.add(new Method('Init', dotnet.Void, { description: 'Initialization steps performed after the module is loaded.' }));
  createPipelineMethod!: Method;

  pInvocationInfo = new Parameter('invocationInfo', InvocationInfo, { description: 'The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet' });
  pPipeline = new Parameter('pipeline', ClientRuntime.HttpPipeline, { modifier: ParameterModifier.Ref, description: 'The HttpPipeline for the request' });
  pProxy = new Parameter('proxy', System.Uri, { description: 'The HTTP Proxy to use.' });
  pProxyCredential = new Parameter('proxyCredential', PSCredential, { description: 'The HTTP Proxy Credentials' });
  pUseDefaultCredentials = new Parameter('proxyUseDefaultCredentials', dotnet.Bool, { description: 'True if the proxy should use default credentials' });

  pCorrelationId = new Parameter('correlationId', dotnet.String, { description: 'the cmdlet\'s correlation id.' });
  pParameterName = new Parameter('parameterName', dotnet.String, { description: 'The name of the parameter to get the value for.' });

  pId = new Parameter('id', dotnet.String, { description: 'The ID of the event ' });
  pToken = new Parameter('token', System.Threading.CancellationToken, { description: 'The cancellation token for the event ' });
  pGetEventData = new Parameter('getEventData', System.Func(System.EventArgs), { description: 'A delegate to get the detailed event data' });

  pParameterSetName = new Parameter('parameterSetName', dotnet.String, { description: 'the cmdlet\'s parameterset name.' });
  pProcessRecordId = new Parameter('processRecordId', dotnet.String, { description: 'the cmdlet\'s process record correlation id.' });
  pException = new Parameter('exception', System.Exception, { description: 'the exception that is being thrown (if available)' });

  fPipeline = this.add(new Field('_pipeline', ClientRuntime.HttpPipeline, { access: Access.Private, description: 'the ISendAsync pipeline instance' }));
  fPipelineWithProxy = this.add(new Field('_pipelineWithProxy', ClientRuntime.HttpPipeline, { access: Access.Private, description: 'the ISendAsync pipeline instance (when proxy is enabled)' }));
  fHandler = this.add(new Field('_handler', System.Net.Http.HttpClientHandler, { initialValue: System.Net.Http.HttpClientHandler.new() }));
  fWebProxy = this.add(new Field('_webProxy', System.Net.WebProxy, { initialValue: System.Net.WebProxy.new() }));

  constructor(namespace: Namespace, private readonly state: State, objectInitializer?: Partial<ModuleClass>) {
    super(namespace, 'Module');
    this.apply(objectInitializer);
    this.partial = true;
    this.description = 'A class that contains the module-common code and data.';

    const $this = this;

    // static instance property
    this.add(new LazyProperty('Instance', this, new LiteralExpression(`new ${this.declaration}()`), {
      instanceAccess: this.declaration,
      static: Modifier.Static,
      description: 'the singleton of this module class'
    }));

    const clientAPI = new ClassType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);
    const clientProperty = this.add(new Property('ClientAPI', clientAPI, { description: 'The instance of the Client API' }));

    if (this.state.project.azure) {
      this.createAzureInitAndPipeline(namespace);
    } else {
      this.createInitAndPipeline(namespace);
    }

    this.add(new Constructor(this, {
      access: Access.Private,
      description: 'Creates the module instance.',
      body: function* () {
        yield '/// constructor';
        yield clientProperty.assignPrivate(clientAPI.new());
        yield `${$this.fHandler}.Proxy = ${$this.fWebProxy};`;

        yield $this.fPipeline.assignPrivate(ClientRuntime.HttpPipeline.new(ClientRuntime.HttpClientFactory.new(System.Net.Http.HttpClient.new())));
        yield $this.fPipelineWithProxy.assignPrivate(ClientRuntime.HttpPipeline.new(ClientRuntime.HttpClientFactory.new(System.Net.Http.HttpClient.new($this.fHandler))));
      }
    }));

    /* extensibility points */
    this.add(new PartialMethod('BeforeCreatePipeline', dotnet.Void, { parameters: [this.pInvocationInfo, this.pPipeline] }));
    this.add(new PartialMethod('AfterCreatePipeline', dotnet.Void, { parameters: [this.pInvocationInfo, this.pPipeline] }));
    this.add(new PartialMethod('CustomInit', dotnet.Void));

    /* Setting the Proxy */
    this.add(new Method('SetProxyConfiguration', dotnet.Void, {
      parameters: [this.pProxy, this.pProxyCredential, this.pUseDefaultCredentials],
      *body() {
        yield '// set the proxy configuration';
        yield `${$this.fWebProxy}.Address = proxy;`;
        yield `${$this.fWebProxy}.BypassProxyOnLocal = false;`;
        yield `${$this.fWebProxy}.Credentials = proxyCredential ?.GetNetworkCredential();`;
        yield `${$this.fWebProxy}.UseDefaultCredentials = proxyUseDefaultCredentials;`;
        yield `${$this.fHandler}.UseProxy = proxy != null;`;
      }
    }));
  }

  createInitAndPipeline(namespace: Namespace) {
    const $this = this;
    // non-azure init method
    this.initMethod.add(function* () {
      yield '// called at module init time...';
      yield 'CustomInit();';
    });

    this.createPipelineMethod = this.add(new Method('CreatePipeline', ClientRuntime.HttpPipeline, {
      parameters: [this.pInvocationInfo],
      description: 'Creates an instance of the HttpPipeline for each call.',
      returnsDescription: `An instance of ${ClientRuntime.HttpPipeline} for the remote call.`
    }));

    // non-azure createPipeline method
    this.createPipelineMethod.add(function* () {
      const pip = new LocalVariable('pipeline', ClientRuntime.HttpPipeline, { initializer: 'null' });
      yield pip.declarationStatement;
      yield `BeforeCreatePipeline(${$this.pInvocationInfo.use}, ref ${pip});`;
      yield pip.assign(`(${pip} ?? (${$this.fHandler}.UseProxy ? ${$this.fPipelineWithProxy} : ${$this.fPipeline})).Clone()`);
      yield `AfterCreatePipeline(${$this.pInvocationInfo.use}, ref ${pip});`;
      yield Return(pip);
    });

    this.add(new LambdaProperty('Name', dotnet.String, new StringExpression(this.state.project.moduleName), { description: 'The Name of this module ' }));
  }

  createAzureInitAndPipeline(namespace: Namespace) {
    const $this = this;

    const sendAsyncStep = namespace.add(new Alias('SendAsyncStepDelegate',
      System.Func(
        System.Net.Http.HttpRequestMessage,
        ...this.IEventListenerExpanded,
        this.nextStep,                                  /* Next( ...) */
        /* returns */ this.TaskOfHttpResponseMessage)));

    const pipelineChangeDelegate = namespace.add(new Alias('PipelineChangeDelegate', System.Action(sendAsyncStep.fullDefinition)));

    const getParameterDelegate = namespace.add(new Alias('GetParameterDelegate', System.Func(
      dotnet.String, /* resourceId */
      dotnet.String, /* moduleName */
      InvocationInfo, /* invocationInfo */
      dotnet.String, /* correlationId */
      dotnet.String, /* parameterName */
      /* returns */ dotnet.Object)));

    const moduleLoadPipelineDelegate = namespace.add(new Alias('ModuleLoadPipelineDelegate', System.Action(
      dotnet.String, /* resourceId */
      dotnet.String, /* moduleName */
      pipelineChangeDelegate.fullDefinition, /* prependStep */
      pipelineChangeDelegate.fullDefinition))); /* appendStep */

    const newRequestPipelineDelegate = namespace.add(new Alias('NewRequestPipelineDelegate', System.Action(
      InvocationInfo,  /* invocationInfo */
      dotnet.String,   /* correlationId */
      dotnet.String,  /* processRecordId */
      pipelineChangeDelegate.fullDefinition,    /* prependStep */
      pipelineChangeDelegate.fullDefinition))); /* appendStep */

    const argumentCompleterDelegate = namespace.add(new Alias('ArgumentCompleterDelegate', System.Func(
      dotnet.String, /* completerName */
      InvocationInfo, /* invocationInfo */
      dotnet.String, /* correlationId */
      dotnet.StringArray, /* resourceTypes */
      dotnet.StringArray, /* parentResourceParameterNames */
      /* returns */ dotnet.StringArray,
    )));

    const incomingSignalDelegate = namespace.add(new Alias('SignalDelegate', this.incomingSignalFunc));
    const eventListenerDelegate = namespace.add(new Alias('EventListenerDelegate', this.eventListenerFunc));

    namespace.add(new Alias('NextDelegate', this.nextStep));

    /* AzAccounts VTable properties  */
    const OnModuleLoad = this.add(new Property('OnModuleLoad', moduleLoadPipelineDelegate, { description: 'The delegate to call when this module is loaded (supporting a commmon module).' }));
    const OnNewRequest = this.add(new Property('OnNewRequest', newRequestPipelineDelegate, { description: 'The delegate to call before each new request (supporting a commmon module).' }));
    const GetParameterValue = this.add(new Property('GetParameterValue', getParameterDelegate, { description: 'The delegate to call to get parameter data from a common module.' }));
    const EventListener = this.add(new Property('EventListener', eventListenerDelegate, { description: 'A delegate that gets called for each signalled event' }));
    const ArgumentCompleter = this.add(new Property('ArgumentCompleter', argumentCompleterDelegate, { description: 'Gets completion data for azure specific fields' }));
    const ProfileName = this.add(new Property('ProfileName', System.String, { description: 'The name of the currently selected Azure profile' }));

    const moduleIdentity = this.add(new LambdaProperty('Name', dotnet.String, new StringExpression(this.state.project.moduleName), { description: 'The Name of this module ' }));
    const currentProfile = this.add(new Field('Profile', dotnet.String, { initialValue: System.String.Empty, description: 'The currently selected profile.' }));
    const moduleResourceId = this.add(new LambdaProperty('ResourceId', dotnet.String, new StringExpression(this.state.project.moduleName), { description: 'The ResourceID for this module (azure arm).' }));

    /* get parameter method (calls azAccounts) */
    this.add(new LambdaMethod('GetParameter', dotnet.Object, new LiteralExpression(`${GetParameterValue.value}?.Invoke( ${moduleResourceId.value}, ${moduleIdentity.value}, ${$this.pInvocationInfo.value}, ${$this.pCorrelationId.value},${$this.pParameterName.value} )`), {
      parameters: [this.pInvocationInfo, this.pCorrelationId, this.pParameterName],
      description: 'Gets parameters from a common module.',
      returnsDescription: 'The parameter value from the common module. (Note: this should be type converted on the way back)'
    }));

    /* signal method (calls azAccounts) */
    const pSignal = new Parameter('signal', incomingSignalDelegate, { description: 'The callback for the event dispatcher ' });
    const signalImpl = this.add(new Method('Signal', System.Threading.Tasks.Task(), {
      parameters: [this.pId, this.pToken, this.pGetEventData, pSignal, this.pInvocationInfo, this.pParameterSetName, this.pCorrelationId, this.pProcessRecordId, this.pException], async: Modifier.Async,
      description: 'Called to dispatch events to the common module listener',
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the event is completed.`
    }));

    signalImpl.push(Using('NoSynchronizationContext', ''));
    signalImpl.add(function* () {
      yield `await ${EventListener.value}?.Invoke(${$this.pId.value},${$this.pToken.value},${$this.pGetEventData.value}, ${pSignal.value}, ${$this.pInvocationInfo}, ${$this.pParameterSetName}, ${$this.pCorrelationId},${$this.pProcessRecordId},${$this.pException});`;
    });

    /* init method */
    this.initMethod.add(function* () {
      yield `${OnModuleLoad.value}?.Invoke( ${moduleResourceId.value}, ${moduleIdentity.value} ,(step)=> { ${$this.fPipeline.value}.Prepend(step); } , (step)=> { ${$this.fPipeline.value}.Append(step); } );`;
      yield `${OnModuleLoad.value}?.Invoke( ${moduleResourceId.value}, ${moduleIdentity.value} ,(step)=> { ${$this.fPipelineWithProxy.value}.Prepend(step); } , (step)=> { ${$this.fPipelineWithProxy.value}.Append(step); } );`;
      yield 'CustomInit();';
    });

    this.createPipelineMethod = this.add(new Method('CreatePipeline', ClientRuntime.HttpPipeline, {
      parameters: [this.pInvocationInfo, this.pCorrelationId, this.pProcessRecordId,],
      description: 'Creates an instance of the HttpPipeline for each call.',
      returnsDescription: `An instance of ${ClientRuntime.HttpPipeline} for the remote call.`
    }));

    /* pipeline create method */
    this.createPipelineMethod.add(function* () {
      const pip = new LocalVariable('pipeline', ClientRuntime.HttpPipeline, { initializer: 'null' });
      yield pip.declarationStatement;
      yield `BeforeCreatePipeline(${$this.pInvocationInfo.use}, ref ${pip});`;
      yield pip.assign(`(${pip} ?? (${$this.fHandler}.UseProxy ? ${$this.fPipelineWithProxy} : ${$this.fPipeline})).Clone()`);
      yield `AfterCreatePipeline(${$this.pInvocationInfo.use}, ref ${pip});`;
      yield `${OnNewRequest.value}?.Invoke( ${$this.pInvocationInfo.use}, ${$this.pCorrelationId},${$this.pProcessRecordId}, (step)=> { ${pip}.Prepend(step); } , (step)=> { ${pip}.Append(step); } );`;
      yield Return(pip);
    });
  }
}
