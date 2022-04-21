/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { command, getAllProperties, JsonType, http, getAllPublicVirtualProperties, getVirtualPropertyFromPropertyName, ParameterLocation, getAllVirtualProperties, VirtualParameter, VirtualProperty } from '@azure-tools/codemodel-v3';
import { escapeString, docComment, serialize, pascalCase, DeepPartial } from '@azure-tools/codegen';
import { items, values, Dictionary, length } from '@azure-tools/linq';
import {
  Access, Attribute, BackedProperty, Catch, Class, ClassType, Constructor, dotnet, Else, Expression, Finally, ForEach, If, LambdaProperty, LiteralExpression, LocalVariable, Method, Modifier, Namespace, OneOrMoreStatements, Parameter, Property, Return, Statements, BlockStatement, StringExpression,
  Switch, System, TerminalCase, toExpression, Try, Using, valueOf, Field, IsNull, Or, ExpressionOrLiteral, TerminalDefaultCase, xmlize, TypeDeclaration, And, IsNotNull, PartialMethod, Case, While
} from '@azure-tools/codegen-csharp';
import { ClientRuntime, EventListener, Schema, ArrayOf, EnumImplementation } from '../llcsharp/exports';
import { Alias, ArgumentCompleterAttribute, AsyncCommandRuntime, AsyncJob, CmdletAttribute, ErrorCategory, ErrorRecord, Events, InvocationInfo, OutputTypeAttribute, ParameterAttribute, PSCmdlet, PSCredential, SwitchParameter, ValidateNotNull, verbEnum, GeneratedAttribute, DescriptionAttribute, CategoryAttribute, ParameterCategory, ProfileAttribute, PSObject, InternalExportAttribute, ExportAsAttribute, DefaultRunspace, RunspaceFactory, AllowEmptyCollectionAttribute } from '../internal/powershell-declarations';
import { State } from '../internal/state';
import { Channel } from '@azure-tools/autorest-extension-base';
import { IParameter } from '@azure-tools/codemodel-v3/dist/code-model/components';
import { Variable, Local, ParameterModifier } from '@azure-tools/codegen-csharp';
import { getVirtualPropertyName } from '../llcsharp/model/model-class';
const PropertiesRequiringNew = new Set(['Host', 'Events']);


const Verbs = {
  Common: 'global::System.Management.Automation.VerbsCommon',
  Data: 'global::System.Management.Automation.VerbsData',
  Lifecycle: 'global::System.Management.Automation.VerbsLifecycle',
  Diagnostic: 'global::System.Management.Automation.VerbsDiagnostic',
  Communications: 'global::System.Management.Automation.VerbsCommunications',
  Security: 'global::System.Management.Automation.VerbsSecurity',
  Other: 'global::System.Management.Automation.VerbsOther'
};

const category: { [verb: string]: string } = {
  'Add': Verbs.Common,
  'Clear': Verbs.Common,
  'Close': Verbs.Common,
  'Copy': Verbs.Common,
  'Enter': Verbs.Common,
  'Exit': Verbs.Common,
  'Find': Verbs.Common,
  'Format': Verbs.Common,
  'Get': Verbs.Common,
  'Hide': Verbs.Common,
  'Join': Verbs.Common,
  'Lock': Verbs.Common,
  'Move': Verbs.Common,
  'New': Verbs.Common,
  'Open': Verbs.Common,
  'Optimize': Verbs.Common,
  'Pop': Verbs.Common,
  'Push': Verbs.Common,
  'Redo': Verbs.Common,
  'Remove': Verbs.Common,
  'Rename': Verbs.Common,
  'Reset': Verbs.Common,
  'Resize': Verbs.Common,
  'Search': Verbs.Common,
  'Select': Verbs.Common,
  'Set': Verbs.Common,
  'Show': Verbs.Common,
  'Skip': Verbs.Common,
  'Split': Verbs.Common,
  'Step': Verbs.Common,
  'Switch': Verbs.Common,
  'Undo': Verbs.Common,
  'Unlock': Verbs.Common,
  'Watch': Verbs.Common,
  'Backup': Verbs.Data,
  'Checkpoint': Verbs.Data,
  'Compare': Verbs.Data,
  'Compress': Verbs.Data,
  'Convert': Verbs.Data,
  'ConvertFrom': Verbs.Data,
  'ConvertTo': Verbs.Data,
  'Dismount': Verbs.Data,
  'Edit': Verbs.Data,
  'Expand': Verbs.Data,
  'Export': Verbs.Data,
  'Group': Verbs.Data,
  'Import': Verbs.Data,
  'Initialize': Verbs.Data,
  'Limit': Verbs.Data,
  'Merge': Verbs.Data,
  'Mount': Verbs.Data,
  'Out': Verbs.Data,
  'Publish': Verbs.Data,
  'Restore': Verbs.Data,
  'Save': Verbs.Data,
  'Sync': Verbs.Data,
  'Unpublish': Verbs.Data,
  'Update': Verbs.Data,
  'Approve': Verbs.Lifecycle,
  'Assert': Verbs.Lifecycle,
  'Complete': Verbs.Lifecycle,
  'Confirm': Verbs.Lifecycle,
  'Deny': Verbs.Lifecycle,
  'Disable': Verbs.Lifecycle,
  'Enable': Verbs.Lifecycle,
  'Install': Verbs.Lifecycle,
  'Invoke': Verbs.Lifecycle,
  'Register': Verbs.Lifecycle,
  'Request': Verbs.Lifecycle,
  'Restart': Verbs.Lifecycle,
  'Resume': Verbs.Lifecycle,
  'Start': Verbs.Lifecycle,
  'Stop': Verbs.Lifecycle,
  'Submit': Verbs.Lifecycle,
  'Suspend': Verbs.Lifecycle,
  'Uninstall': Verbs.Lifecycle,
  'Unregister': Verbs.Lifecycle,
  'Wait': Verbs.Lifecycle,
  'Debug': Verbs.Diagnostic,
  'Measure': Verbs.Diagnostic,
  'Ping': Verbs.Diagnostic,
  'Repair': Verbs.Diagnostic,
  'Resolve': Verbs.Diagnostic,
  'Test': Verbs.Diagnostic,
  'Trace': Verbs.Diagnostic,
  'Connect': Verbs.Communications,
  'Disconnect': Verbs.Communications,
  'Read': Verbs.Communications,
  'Receive': Verbs.Communications,
  'Send': Verbs.Communications,
  'Write': Verbs.Communications,
  'Block': Verbs.Security,
  'Grant': Verbs.Security,
  'Protect': Verbs.Security,
  'Revoke': Verbs.Security,
  'Unblock': Verbs.Security,
  'Unprotect': Verbs.Security,
  'Use': Verbs.Other,
};


export function createStepper(p: Expression) {
  return toExpression(`${System.Linq.Enumerable.declaration}.Select<${ClientRuntime.SendAsyncStep.declaration},${ClientRuntime.SendAsyncStep.declaration}>(${p.value}, step =>
    (r, c, n) => {
      ${DefaultRunspace.value} = ${DefaultRunspace.value} ?? ${RunspaceFactory.declaration}.CreateRunspace();
      return step(r, c, n);
    })`);
}

export function addCompleterInfo(targetProperty: Property, parameter: VirtualParameter) {
  if (parameter.completerInfo && parameter.completerInfo.script) {
    targetProperty.add(new Attribute(ClientRuntime.CompleterInfoAttribute, {
      parameters: [
        new LiteralExpression(`\nName = ${new StringExpression(parameter.completerInfo.name || '').value}`),
        new LiteralExpression(`\nDescription =${new StringExpression(parameter.completerInfo.description || '').value}`),
        new LiteralExpression(`\nScript = ${new StringExpression(parameter.completerInfo.script).value}`)
      ]
    }));
  }
}


export function addDefaultInfo(targetProperty: Property, parameter: any) {
  if (parameter.defaultInfo && parameter.defaultInfo.script) {
    targetProperty.add(new Attribute(ClientRuntime.DefaultInfoAttribute, {
      parameters: [
        new LiteralExpression(`\nName = ${new StringExpression(parameter.defaultInfo.name || '').value}`),
        new LiteralExpression(`\nDescription =${new StringExpression(parameter.defaultInfo.description || '').value}`),
        new LiteralExpression(`\nScript = ${new StringExpression(parameter.defaultInfo.script).value}`)
      ]
    }));
  }
}

export function addInfoAttribute(targetProperty: Property, pType: TypeDeclaration, isRequired: boolean, isReadOnly: boolean, description: string, serializedName: string) {

  let pt = <any>pType;
  while (pt.elementType) {
    switch (pt.elementType.schema.type) {
      case JsonType.Object:
        if (pt.elementType.schema.details.csharp.interfaceImplementation) {
          pt = {
            declaration: pt.elementType.schema.details.csharp.interfaceImplementation.declaration,
            schema: pt.elementType.schema,
          };
        } else {
          // arg! it's not done yet. Hope it's not polymorphic itself. 
          pt = {
            declaration: `${pt.elementType.schema.details.csharp.namespace}.${pt.elementType.schema.details.csharp.interfaceName}`,
            schema: pt.elementType.schema,
          };
        }
        break;

      case JsonType.Array:
        pt = pt.elementType;
        break;

      default:
        pt = pt.elementType;
        break;
    }
  }
  const ptypes = new Array<string>();
  if (pt.schema && pt.schema && pt.schema.details.csharp.byReference) {
    ptypes.push(`typeof(${pt.schema.details.csharp.namespace}.${pt.schema.details.csharp.interfaceName}_Reference)`);
    // do we need polymorphic types for by-resource ? Don't think so.
  } else {
    ptypes.push(`typeof(${pt.declaration})`);
    if (pt.schema && pt.schema.details.csharp.classImplementation && pt.schema.details.csharp.classImplementation.discriminators) {
      ptypes.push(...[...pt.schema.details.csharp.classImplementation.discriminators.values()].map(each => `typeof(${each.modelInterface.fullName})`));
    }
  }

  targetProperty.add(new Attribute(ClientRuntime.InfoAttribute, {
    parameters: [
      new LiteralExpression(`\nRequired = ${isRequired}`),
      new LiteralExpression(`\nReadOnly = ${isReadOnly}`),
      new LiteralExpression(`\nDescription = ${new StringExpression(description).value}`),
      new LiteralExpression(`\nSerializedName = ${new StringExpression(serializedName).value}`),
      new LiteralExpression(`\nPossibleTypes = new [] { ${ptypes.join(',').replace(/\?/g, '').replace(/undefined\./g, '')} }`),
    ]
  }));


}

export class CmdletClass extends Class {
  private cancellationToken!: Expression;
  public state: State;
  private readonly eventListener: EventListener;
  private readonly dropBodyParameter: boolean;
  private invocationInfo!: Property;
  correlationId!: Field;
  processRecordId!: Field;
  defaultProfile!: Property;
  private readonly thingsToSerialize: Array<Variable>;
  private bodyParameter?: Variable;
  private bodyParameterInfo?: { type: TypeDeclaration; valueType: TypeDeclaration };
  private apProp?: Property;
  private operation: command.CommandOperation;
  private debugMode?: boolean;
  private variantName: string;
  private isViaIdentity: boolean;
  private hasStreamOutput: boolean;
  private outFileParameter?: Property;

  constructor(namespace: Namespace, operation: command.CommandOperation, state: State, objectInitializer?: DeepPartial<CmdletClass>) {
    // generate the 'variant'  part of the name
    const noun = `${state.project.prefix}${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}`;
    const variantName = `${noun}${operation.details.csharp.name ? `_${operation.details.csharp.name}` : ''}`;

    const name = `${operation.details.csharp.verb}${variantName}`;
    super(namespace, name, PSCmdlet);
    this.dropBodyParameter = operation.details.csharp.dropBodyParameter ? true : false;
    this.apply(objectInitializer);
    this.operation = operation;
    this.state = state;
    this.thingsToSerialize = [];
    this.variantName = variantName;
    this.hasStreamOutput = false;

    this.interfaces.push(ClientRuntime.IEventListener);
    this.eventListener = new EventListener(new LiteralExpression(`((${ClientRuntime.IEventListener})this)`), true);

    this.isViaIdentity = variantName.indexOf('ViaIdentity') > 0;

  }

  async init() {

    // basic stuff
    this.addCommonStuff();

    this.description = escapeString(this.operation.details.csharp.description);
    const $this = this;

    this.add(new Method('BeginProcessing', dotnet.Void, {
      override: Modifier.Override,
      access: Access.Protected,
      description: `(overrides the default BeginProcessing method in ${PSCmdlet})`,
      *body() {
        yield 'Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);';
        yield If($this.$<Property>('Break'), `${ClientRuntime.AttachDebugger}.Break();`);

        yield $this.eventListener.syncSignal(Events.CmdletBeginProcessing);
      }
    }));

    // construct the class
    this.addClassAttributes(this.operation, this.variantName);
    if (this.hasStreamOutput) {
      this.outFileParameter = this.add(new Property('OutFile', System.String, { attributes: [], description: 'Path to write output file to.' }));
      this.outFileParameter.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = true', 'HelpMessage = "Path to write output file to"'] }));
      this.outFileParameter.add(new Attribute(ValidateNotNull));
      this.outFileParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Body`] }));
    }

    this.addPowershellParameters(this.operation);

    // implement IEventListener
    this.implementIEventListener();

    // add constructors
    this.implementConstructors();

    // processRecord
    this.implementProcessRecord(this.operation);

    this.implementProcessRecordAsync(this.operation);
    this.debugMode = await this.state.getValue('debug', false);

    // json serialization
    this.implementSerialization(this.operation);

    for (const prop of this.properties) {
      if (prop.name === 'Host') {
        prop['new'] = Modifier.New;
      }
    }

    return this;
  }

  public get headerComment(): string {
    const header = super.headerComment;
    let ops = '';

    for (const httpOperation of values(this.operation.callGraph)) {
      ops = `${ops}\n[OpenAPI] ${httpOperation.operationId}=>${httpOperation.method.toUpperCase()}:"${httpOperation.path}"`;
      if (this.debugMode) {
        const m = (httpOperation.extensions && httpOperation.extensions['x-ms-metadata']) || (httpOperation.pathExtensions ? httpOperation.pathExtensions['x-ms-metadata'] : undefined);
        if (m) {
          ops = `${ops}\n [METADATA]\n${serialize(m)}`;
        }

        ops = `${ops}\n [DETAILS]`;
        ops = `${ops}\n verb: ${this.operation.details.csharp.verb}`;
        ops = `${ops}\n subjectPrefix: ${this.operation.details.csharp.subjectPrefix}`;
        ops = `${ops}\n subject: ${this.operation.details.csharp.subject}`;
        ops = `${ops}\n variant: ${this.operation.details.csharp.name}`;
      }
    }

    return ops ? `${header}\n${docComment(xmlize('remarks', ops))}` : header;
  }

  private addCommonStuff() {

    // add a private copy of invocation information for our own uses.
    const privateInvocationInfo = this.add(new Field('__invocationInfo', InvocationInfo, { description: 'A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)', access: Access.Private }));
    this.invocationInfo = new Property('InvocationInformation', InvocationInfo, { description: 'Accessor for our copy of the InvocationInfo.' });
    this.invocationInfo.get = toExpression(`${privateInvocationInfo.value} = ${privateInvocationInfo.value} ?? this.MyInvocation `);
    this.invocationInfo.set = new Statements(privateInvocationInfo.assign('value'));
    this.add(this.invocationInfo);

    if (this.state.project.azure) {
      this.correlationId = this.add(new Field('__correlationId', dotnet.String, { initialValue: 'System.Guid.NewGuid().ToString()', description: 'A unique id generatd for the this cmdlet when it is instantiated.', access: Access.Private }));
      this.processRecordId = this.add(new Field('__processRecordId', dotnet.String, { description: 'A unique id generatd for the this cmdlet when ProcessRecord() is called.', access: Access.Private }));
    }

    // pipeline property
    this.add(new Property('Pipeline', ClientRuntime.HttpPipeline, { getAccess: Access.Private, setAccess: Access.Private, description: `The instance of the <see cref="${ClientRuntime.HttpPipeline}" /> that the remote call will use.` }));

    // client API property (gs01: fill this in correctly)
    const clientAPI = new ClassType(this.state.model.details.csharp.namespace, this.state.model.details.csharp.name);
    this.add(new LambdaProperty('Client', clientAPI, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.ClientAPI`), { description: 'The reference to the client API class.' }));

    this.add(new Method('StopProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: 'Interrupts currently running code within the command.' })).add(function* () {
      yield `((${ClientRuntime.IEventListener})this).Cancel();`;
      yield 'base.StopProcessing();';
    });

    const $this = this;
    this.add(new Method('EndProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: 'Performs clean-up after the command execution' })).add(function* () {
      // gs01: remember what you were doing here to make it so these can be parallelized...
      yield '';
      yield $this.eventListener.syncSignal(Events.CmdletEndProcessing);
    });

    // debugging
    const brk = this.add(new Property('Break', SwitchParameter, { attributes: [], description: 'Wait for .NET debugger to attach' }));
    brk.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "Wait for .NET debugger to attach"'] }));
    brk.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    // Cmdlet Parameters for pipeline manipulations.
    const prepend = this.add(new Property('HttpPipelinePrepend', ClientRuntime.SendAsyncSteps, { attributes: [], description: 'SendAsync Pipeline Steps to be prepended to the front of the pipeline' }));
    prepend.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline"'] }));
    prepend.add(new Attribute(ValidateNotNull));
    prepend.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    const append = this.add(new Property('HttpPipelineAppend', ClientRuntime.SendAsyncSteps, { attributes: [], description: 'SendAsync Pipeline Steps to be appended to the front of the pipeline' }));
    append.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline"'] }));
    append.add(new Attribute(ValidateNotNull));
    append.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    const proxyCredential = this.add(new Property('ProxyCredential', PSCredential, { attributes: [], description: 'Credentials for a proxy server to use for the remote call' }));
    proxyCredential.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "Credentials for a proxy server to use for the remote call"'] }));
    proxyCredential.add(new Attribute(ValidateNotNull));
    proxyCredential.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    const useDefaultCreds = this.add(new Property('ProxyUseDefaultCredentials ', SwitchParameter, { attributes: [], description: 'Use the default credentials for the proxy' }));
    useDefaultCreds.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "Use the default credentials for the proxy"'] }));
    useDefaultCreds.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    const proxyUri = this.add(new Property('Proxy', System.Uri, { attributes: [], description: 'The URI for the proxy server to use' }));
    proxyUri.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'DontShow = true', 'HelpMessage = "The URI for the proxy server to use"'] }));
    proxyUri.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

    if (this.state.project.azure) {
      this.defaultProfile = this.add(new Property('DefaultProfile', PSObject, { description: 'The credentials, account, tenant, and subscription used for communication with Azure' }));
      this.defaultProfile.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure."'] }));
      this.defaultProfile.add(new Attribute(ValidateNotNull));
      this.defaultProfile.add(new Attribute(Alias, { parameters: ['"AzureRMContext"', '"AzureCredential"'] }));
      this.defaultProfile.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Azure`] }));
    }
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

    this.add(new Method('ProcessRecord', undefined, { access: Access.Protected, override: Modifier.Override, description: 'Performs execution of the command.' })).add(function* () {
      yield $this.eventListener.syncSignal(Events.CmdletProcessRecordStart);
      if ($this.state.project.azure) {
        yield $this.processRecordId.assign('System.Guid.NewGuid().ToString()');
      }
      yield Try(function* () {
        yield '// work';
        const normal = new Statements(function* () {
          const acr = new LocalVariable('asyncCommandRuntime', dotnet.Var, { initializer: AsyncCommandRuntime.new(dotnet.This, $this.cancellationToken) });
          yield Using(acr.declarationExpression, function* () {
            yield `${acr}.Wait( ProcessRecordAsync(),${$this.cancellationToken});`;
          });
        });

        if (operation.asjob) {
          const asjob = $this.add(new Property('AsJob', SwitchParameter, { description: 'when specified, runs this cmdlet as a PowerShell job' }));
          asjob.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "Run the command as a job"'] }));
          asjob.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

          const nowait = $this.add(new Property('NoWait', SwitchParameter, { description: 'when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue asynchronously.' }));
          nowait.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "Run the command asynchronously"'] }));
          nowait.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));

        }

        const work: OneOrMoreStatements = operation.asjob ? function* () {
          yield If('true == MyInvocation?.BoundParameters?.ContainsKey("AsJob")', function* () {
            // clone the cmdlet instance, since the instance can be reused and overwrite data.
            const instance = new LocalVariable('instance', dotnet.Var, { initializer: 'this.Clone()' });
            yield instance.declarationStatement;

            // create the job (which will set the CommandRuntime of the clone to the AsyncJob itself)
            const job = new LocalVariable('job', dotnet.Var, { initializer: AsyncJob.new(instance, 'this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token', 'this._cancellationTokenSource.Cancel') });
            yield job.declarationStatement;

            // add the job to the repository
            yield `JobRepository.Add(${job});`;

            // invoke the cmdlet's PRA
            const task = new LocalVariable('task', dotnet.Var, { initializer: `${instance}.ProcessRecordAsync()` });
            yield task.declarationStatement;

            // have the AsyncJob monitor the lifetime of the Task
            yield `${job}.Monitor(${task});`;

            // return the job to the user now.
            yield `WriteObject(${job});`;

          });
          yield Else(normal);
        } : normal;

        if (writable) {
          yield If(`ShouldProcess($"Call remote '${operation.callGraph[0].details.csharp.name}' operation")`, work);
        } else {
          yield work;
        }
      });
      const aggregateException = new Parameter('aggregateException', System.AggregateException);
      yield Catch(aggregateException, function* () {
        yield '// unroll the inner exceptions to get the root cause';
        yield ForEach('innerException', new LiteralExpression(`${aggregateException.use}.Flatten().InnerExceptions`), function* () {
          yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression('$"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}"'));
          yield '// Write exception out to error channel.';
          yield `WriteError( new ${ErrorRecord}(innerException,string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
        });
      });
      const exception = new Parameter('exception', System.Exception);
      yield Catch(exception, function* () {
        yield $this.eventListener.syncSignal(Events.CmdletException, new LiteralExpression(`$"{${exception.use}.GetType().Name} - {${exception.use}.Message} : {${exception.use}.StackTrace}"`));
        yield '// Write exception out to error channel.';
        yield `WriteError( new ${ErrorRecord}(${exception.use},string.Empty, ${ErrorCategory('NotSpecified')}, null) );`;
      }, { when: new LiteralExpression('(exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null') });

      yield Finally(function* () {
        yield $this.eventListener.syncSignalNoCheck(Events.CmdletProcessRecordEnd);
      });
    });

  }

  private implementProcessRecordAsync(operation: command.CommandOperation) {
    const $this = this;
    const PAR = this.add(new Method('ProcessRecordAsync', System.Threading.Tasks.Task(), {
      access: Access.Protected, async: Modifier.Async,
      description: 'Performs execution of the command, working asynchronously if required.',
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
    }));

    // we don't want to use SynchContext here.
    PAR.push(Using('NoSynchronizationContext', ''));

    PAR.add(function* () {
      if ($this.apProp && $this.bodyParameter && $this.bodyParameterInfo) {
        // yield `${ClientRuntime}.DictionaryExtensions.HashTableToDictionary<${$this.bodyParameterInfo.type.declaration},${$this.bodyParameterInfo.valueType.declaration}>(${$this.apProp.value},${$this.bodyParameter.Cast($this.bodyParameterInfo.type)});`;
        let vt = $this.bodyParameterInfo.valueType.declaration;
        if (vt.endsWith('SwitchParameter')) {
          vt = 'bool';
        }
        yield `${ClientRuntime}.DictionaryExtensions.HashTableToDictionary<${vt}>(${$this.apProp.value},${$this.bodyParameter}.AdditionalProperties);`;
      }

      // construct the call to the operation
      yield $this.eventListener.signal(Events.CmdletProcessRecordAsyncStart);

      yield $this.eventListener.signal(Events.CmdletGetPipeline);

      const pipeline = $this.$<Property>('Pipeline');

      if ($this.state.project.azure) {
        yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(${$this.invocationInfo}, ${$this.correlationId}, ${$this.processRecordId}, this.ParameterSetName)`));
      } else {
        yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(${$this.invocationInfo}, this.ParameterSetName)`));
      }

      yield If(IsNotNull($this.$<Property>('HttpPipelinePrepend')), pipeline.invokeMethod('Prepend', toExpression(`(this.CommandRuntime as Microsoft.Rest.ClientRuntime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(${$this.$<Property>('HttpPipelinePrepend')}) ?? ${$this.$<Property>('HttpPipelinePrepend')}`)));
      yield If(IsNotNull($this.$<Property>('HttpPipelineAppend')), pipeline.invokeMethod('Append', toExpression(`(this.CommandRuntime as Microsoft.Rest.ClientRuntime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(${$this.$<Property>('HttpPipelineAppend')}) ?? ${$this.$<Property>('HttpPipelineAppend')}`)));

      yield '// get the client instance';
      const apiCall = operation.callGraph[0];

      // find each parameter to the method, and find out where the value is going to come from.
      const operationParameters =
        values(apiCall.parameters).
          // filter out constants and path parameters when using piping for identity
          where(each => !(each.details.csharp.constantValue) /* && (!$this.isViaIdentity || each.in !== ParameterLocation.Path) */).

          select(p => {
            return {
              name: p.details.csharp.name,
              param: values($this.properties).
                where(each => each.metadata.parameterDefinition).
                first(each => each.metadata.parameterDefinition.details.csharp.uid === p.details.csharp.uid),
              isPathParam: $this.isViaIdentity && p.in === ParameterLocation.Path
            };

          }).
          select(each => {
            if (each.param) {

              const httpParam = (<http.HttpOperationParameter>(each.param.metadata.parameterDefinition));
              if (httpParam.required) {
                return {
                  name: each.param,
                  expression: each.param,
                  isPathParam: each.isPathParam
                };
              }

              const httpParamTD = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration((<Schema>httpParam.schema), httpParam.required, $this.state);
              return {
                name: each.param,
                expression: toExpression(`this.InvocationInformation.BoundParameters.ContainsKey("${each.param.value}") ? ${each.param.value} : ${httpParamTD.defaultOfType}`),
                isPathParam: each.isPathParam
              };

            }

            return { name: each.name, expression: dotnet.Null, isPathParam: each.isPathParam };
          }).toArray();

      // is there a body parameter we should include?
      if ($this.bodyParameter) {
        operationParameters.push({ name: 'body', expression: $this.bodyParameter, isPathParam: false });
      }

      // create the response handlers
      const responses = [...values(apiCall.responses).selectMany(each => each)];

      const callbackMethods = values(responses).toArray().map(each => new LiteralExpression(each.details.csharp.name));

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

        const override = `override${pascalCase(each.details.csharp.name)}`;
        const returnNow = new Parameter('returnNow', System.Threading.Tasks.Task(dotnet.Bool), { modifier: ParameterModifier.Ref, description: `/// Determines if the rest of the ${each.details.csharp.name} method should be processed, or if the method should return immediately (set to true to skip further processing )` });
        const overrideResponseMethod = new PartialMethod(override, dotnet.Void, {
          parameters: [...parameters, returnNow],
          description: `<c>${override}</c> will be called before the regular ${each.details.csharp.name} has been processed, allowing customization of what happens on that response. Implement this method in a partial class to enable this behavior`,
          returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
        });
        $this.add(overrideResponseMethod);

        const responseMethod = new Method(`${each.details.csharp.name}`, System.Threading.Tasks.Task(), {
          access: Access.Private,
          parameters,
          async: Modifier.Async,
          description: each.details.csharp.description,
          returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
        });
        responseMethod.push(Using('NoSynchronizationContext', ''));


        responseMethod.add(function* () {
          const skip = Local('_returnNow', `${System.Threading.Tasks.Task(dotnet.Bool).declaration}.FromResult(${dotnet.False})`);
          yield skip.declarationStatement;
          yield `${overrideResponseMethod.invoke(...parameters, `ref ${skip.value}`)};`;
          yield `// if ${override} has returned true, then return right away.`;
          yield If(And(IsNotNull(skip), `await ${skip}`), Return());

          if (each.details.csharp.isErrorResponse) {
            // this should write an error to the error channel.
            yield `// Error Response : ${each.responseCode}`;


            const unexpected = function* () {
              yield '// Unrecognized Response. Create an error record based on what we have.';
              const ex = (each.details.csharp.responseType) ?
                Local('ex', `new ${ClientRuntime.name}.RestException<${each.details.csharp.responseType}>(responseMessage, await response)`) :
                Local('ex', `new ${ClientRuntime.name}.RestException(responseMessage)`);

              yield ex.declarationStatement;

              yield `WriteError( new global::System.Management.Automation.ErrorRecord(${ex.value}, ${ex.value}.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e.expression) !== 'null').map(each => `${each.name}=${each.expression}`).join(', ')} }) 
{ 
  ErrorDetails = new global::System.Management.Automation.ErrorDetails(${ex.value}.Message) { RecommendedAction = ${ex.value}.Action }
});`;
            };
            if (each.schema) {
              // the schema should be the error information.
              // this supports both { error { message, code} } and { message, code} 

              let props = getAllPublicVirtualProperties(each.schema.details.csharp.virtualProperties);
              const errorProperty = values(props).first(p => p.property.details.csharp.name === 'error');
              let ep = '';
              if (errorProperty) {
                props = getAllPublicVirtualProperties(errorProperty.property.schema.details.csharp.virtualProperties);
                ep = `${errorProperty.name}?.`;
              }

              const codeProp = props.find(p => p.name.toLowerCase().indexOf('code') > -1); // first property with 'code'
              const messageProp = props.find(p => p.name.toLowerCase().indexOf('message') > -1); // first property with 'message'
              const actionProp = props.find(p => p.name.toLowerCase().indexOf('action') > -1); // first property with 'action'

              if (codeProp && messageProp) {
                const lcode = new LocalVariable('code', dotnet.Var, { initializer: `(await response)?.${ep}${codeProp.name}` });
                const lmessage = new LocalVariable('message', dotnet.Var, { initializer: `(await response)?.${ep}${messageProp.name}` });
                const laction = actionProp ? new LocalVariable('action', dotnet.Var, { initializer: `(await response)?.${ep}${actionProp.name} ?? ${System.String.Empty}` }) : undefined;
                yield lcode;
                yield lmessage;
                yield laction;

                yield If(Or(IsNull(lcode), (IsNull(lmessage))), unexpected);
                yield Else(`WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{${lcode}}] : {${lmessage}}"), ${lcode}?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e.expression) !== 'null').map(each => `${each.name}=${each.expression}`).join(', ')} })
{
  ErrorDetails = new global::System.Management.Automation.ErrorDetails(${lmessage}) { RecommendedAction = ${laction || System.String.Empty} }
});`

                );
                return;
              } else {
                yield unexpected;
                return;
              }
            } else {
              yield unexpected;
              return;
            }
          }

          yield `// ${each.details.csharp.name} - response for ${each.responseCode} / ${values(each.mimeTypes).join('/')}`;
          if (each.schema) {
            const schema = each.schema;

            if (apiCall.details.csharp.pageable) {
              const pageable = apiCall.details.csharp.pageable;
              yield '// response should be returning an array of some kind. +Pageable';
              yield `// ${pageable.responseType} / ${pageable.itemName || '<none>'} / ${pageable.nextLinkName || '<none>'}`;
              switch (pageable.responseType) {
                // the result is (or works like a x-ms-pageable)
                case 'pageable':
                case 'nested-array': {
                  const valueProperty = schema.properties[pageable.itemName];
                  const nextLinkProperty = schema.properties[pageable.nextLinkName];
                  if (valueProperty && nextLinkProperty) {
                    // it's pageable!
                    const result = new LocalVariable('result', dotnet.Var, { initializer: new LiteralExpression('await response') });
                    yield result.declarationStatement;
                    // write out the current contents
                    const vp = getVirtualPropertyFromPropertyName(each.schema.details.csharp.virtualProperties, valueProperty.serializedName);
                    if (vp) {
                      yield `WriteObject(${result.value}.${vp.name},true);`;
                    }
                    const nl = getVirtualPropertyFromPropertyName(each.schema.details.csharp.virtualProperties, nextLinkProperty.serializedName);
                    if (nl) {
                      $this.add(new Field('_isFirst', dotnet.Bool, {
                        access: Access.Private,
                        initialValue: new LiteralExpression(`true`),
                        description: `A flag to tell whether it is the first onOK call.`
                      }));
                      $this.add(new Field('_nextLink', dotnet.String, {
                        access: Access.Private,
                        description: `Link to retrieve next page.`
                      }));
                      const nextLinkName = `${result.value}.${nl.name}`;
                      yield `_nextLink = ${nextLinkName};`
                      yield (If(`_isFirst`, function* () {
                        yield `_isFirst = false;`
                        yield (While(`_nextLink != null`,
                          If('responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage ', function* () {
                            yield `requestMessage = requestMessage.Clone(new global::System.Uri( ${nextLinkName} ),${ClientRuntime.Method.Get} );`;
                            yield $this.eventListener.signal(Events.FollowingNextLink);
                            yield `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.details.csharp.name}_Call`, ...[toExpression('requestMessage'), ...callbackMethods, dotnet.This, pipeline]).implementation}`;
                          })
                        ))
                      }));
                    }
                    return;
                  } else if (valueProperty) {
                    // it's just a nested array
                    const p = getVirtualPropertyFromPropertyName(each.schema.details.csharp.virtualProperties, valueProperty.serializedName);
                    if (p) {
                      yield `WriteObject((await response).${p.name}, true);`;
                    }
                    return;
                  }
                }
                  break;

                // it's just an array,
                case 'array':
                  // just write-object(enumerate) with the output
                  yield 'WriteObject(await response, true);';
                  return;
              }
              // ok, let's see if the response type
            }
            const props = getAllPublicVirtualProperties(schema.details.csharp.virtualProperties);
            const outValue = (length(props) === 1) ? `(await response).${props[0].name}` : '(await response)';


            // we expect to get back some data from this call.

            const rType = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>schema, true, $this.state);
            yield `// (await response) // should be ${rType.declaration}`;
            if ($this.hasStreamOutput && $this.outFileParameter) {
              const outfile = $this.outFileParameter;
              const provider = Local('provider');
              provider.initializer = undefined;
              const paths = Local('paths', `this.SessionState.Path.GetResolvedProviderPathFromPSPath(${outfile.value}, out ${provider.declarationExpression})`);
              yield paths.declarationStatement;
              yield If(`${provider.value}.Name != "FileSystem" || ${paths.value}.Count == 0`, `ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("Invalid output path."),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ${outfile.value}) );`);
              yield If(`${paths.value}.Count > 1`, `ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("Multiple output paths not allowed."),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ${outfile.value}) );`);

              if (rType.declaration === System.IO.Stream.declaration) {
                // this is a stream output. write to outfile
                const stream = Local('stream', 'await response');
                yield Using(stream.declarationExpression, function* () {
                  const fileStream = Local('fileStream', `global::System.IO.File.OpenWrite(${paths.value}[0])`);
                  yield Using(fileStream.declarationExpression, `await ${stream.value}.CopyToAsync(${fileStream.value});`);
                });
              } else {
                // assuming byte array output (via outValue)
                yield `global::System.IO.File.WriteAllBytes(${paths.value}[0],${outValue});`;
              }

              yield If('true == MyInvocation?.BoundParameters?.ContainsKey("PassThru")', function* () {
                // no return type. Let's just return ... true?
                yield 'WriteObject(true);';
              });
              return;
            }

            //  let's just return the result object (or unwrapped result object)
            yield `WriteObject(${outValue});`;
            return;
          }

          yield If('true == MyInvocation?.BoundParameters?.ContainsKey("PassThru")', function* () {
            // no return type. Let's just return ... true?
            yield 'WriteObject(true);';
          });
        });
        $this.add(responseMethod);
      }

      yield Try(function* () {
        // make the call.

        const actualCall = function* () {
          yield $this.eventListener.signal(Events.CmdletBeforeAPICall);
          const idOpParams = operationParameters.filter(each => !each.isPathParam);
          const idschema = values($this.state.project.model.schemas).first(each => each.details.default.uid === 'universal-parameter-type');


          if ($this.isViaIdentity) {
            const identityFromPathParams = function* () {
              yield '// try to call with PATH parameters from Input Object';

              if (idschema) {
                const allVPs = getAllPublicVirtualProperties(idschema.details.csharp.virtualProperties);
                const props = [...values(idschema.properties)];

                const idOpParams = operationParameters.map(each => {
                  const pascalName = pascalCase(`${each.name}`);

                  if (!each.isPathParam) {
                    return {
                      name: undefined,
                      value: valueOf(each.expression)
                    };
                  }
                  const match = props.find(p => pascalCase(p.serializedName) === pascalName);
                  if (match) {

                    const defaultOfType = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>match.schema, true, $this.state).defaultOfType;
                    // match up vp name
                    const vp = allVPs.find(pp => pascalCase(pp.property.serializedName) === pascalName);
                    if (vp) {
                      return {
                        name: `InputObject.${vp.name}`,
                        value: `InputObject.${vp.name} ?? ${defaultOfType}`
                      };
                    }
                    // fall back!

                    console.error(`Unable to match identity parameter '${each.name}' member to appropriate virtual parameter. (Guessing '${pascalCase(match.details.csharp.name)}').`);
                    return {
                      name: `InputObject.${pascalCase(match.details.csharp.name)}`,
                      value: `InputObject.${pascalCase(match.details.csharp.name)} ?? ${defaultOfType}`
                    };
                  }
                  console.error(`Unable to match idenity parameter '${each.name}' member to appropriate virtual parameter. (Guessing '${pascalName}')`);
                  return {
                    name: `InputObject.${pascalName}`,
                    value: `InputObject.${pascalName}`
                  };
                });
                for (const opParam of idOpParams) {
                  if (opParam.name) {
                    yield If(IsNull(opParam.name), `ThrowTerminatingError( new ${ErrorRecord}(new global::System.Exception("InputObject has null value for ${opParam.name}"),string.Empty, ${ErrorCategory('InvalidArgument')}, InputObject) );`);
                  }
                }
                yield `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.details.csharp.name}`, ...[...idOpParams.map(each => toExpression(each.value)), ...callbackMethods, dotnet.This, pipeline]).implementation}`;

              }
            };

            if (idschema && values(idschema.properties).first(each => each.details.csharp.uid === 'universal-parameter:resource identity')) {
              yield If('InputObject?.Id != null', `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.details.csharp.name}ViaIdentity`, ...[toExpression('InputObject.Id'), ...idOpParams.map(each => each.expression), ...callbackMethods, dotnet.This, pipeline]).implementation}`);
              yield Else(identityFromPathParams);
            } else {
              yield identityFromPathParams;
            }
          } else {
            yield `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.details.csharp.name}`, ...[...operationParameters.map(each => each.expression), ...callbackMethods, dotnet.This, pipeline]).implementation}`;
          }
          yield $this.eventListener.signal(Events.CmdletAfterAPICall);
        };

        if ($this.state.project.azure && operationParameters.find(each => each.expression && each.expression.value === 'SubscriptionId') && $this.operation.details.csharp.verb.toLowerCase() === 'get') {
          yield 'foreach( var SubscriptionId in this.SubscriptionId )';
          yield BlockStatement(actualCall);
        } else {
          yield actualCall;
        }
      });
      const ure = new Parameter('urexception', { declaration: `${ClientRuntime.fullName}.UndeclaredResponseException` });
      yield Catch(ure, function* () {
        yield `WriteError(new global::System.Management.Automation.ErrorRecord(${ure.value}, ${ure.value}.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  ${operationParameters.filter(e => valueOf(e.expression) !== 'null').map(each => `${each.name}=${each.expression}`).join(',')}})
{
  ErrorDetails = new global::System.Management.Automation.ErrorDetails(${ure.value}.Message) { RecommendedAction = ${ure.value}.Action }
});`;
      });
      yield Finally(function* () {
        yield $this.eventListener.signalNoCheck(Events.CmdletProcessRecordAsyncEnd);
      });
    });
  }

  private implementSerialization(operation: command.CommandOperation) {
    const $this = this;
    // clone
    if (operation.asjob) {
      const clone = this.add(new Method('Clone', this, {
        description: 'Creates a duplicate instance of this cmdlet (via JSON serialization).',
        returnsDescription: `a duplicate instance of ${this.name}`,
      }));

      clone.add(function* () {
        const i = new LocalVariable('clone', dotnet.Var, {
          initializer: $this.new()
        });
        yield i.declarationStatement;

        if ($this.state.project.azure) {
          for (const f of [$this.correlationId, $this.processRecordId, $this.defaultProfile]) {
            yield `${i.value}.${f} = this.${f};`;
          }
        }
        for (const f of [$this.invocationInfo, 'Proxy', 'Pipeline', 'AsJob', 'Break', 'ProxyCredential', 'ProxyUseDefaultCredentials', 'HttpPipelinePrepend', 'HttpPipelineAppend',]) {
          yield `${i.value}.${f} = this.${f};`;
        }

        for (const f of $this.thingsToSerialize) {
          yield `${i.value}.${f} = this.${f};`;
        }

        // _name = this._name,
        //_parametersBody = this._parametersBody,
        //_resourceGroupName = this._resourceGroupName,
        //_subscriptionId = this._subscriptionId,

        yield Return(i);
      });
    }
  }

  private implementConstructors() {
    // default constructor
    this.add(new Constructor(this, { description: `Intializes a new instance of the <see cref="${this.name}" /> cmdlet class.` }));
  }

  private implementIEventListener() {
    const $this = this;
    const cts = this.add(new Field('_cancellationTokenSource', System.Threading.CancellationTokenSource, {
      access: Access.Private,
      initialValue: new LiteralExpression(`new ${System.Threading.CancellationTokenSource.declaration}()`),
      description: `The <see cref="${System.Threading.CancellationTokenSource}" /> for this operation.`
    }));
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Token`, System.Threading.CancellationToken, new LiteralExpression(`${cts.value}.Token`), { getAccess: Access.Default, setAccess: Access.Default, description: '<see cref="IEventListener" /> cancellation token.' }));
    this.cancellationToken = toExpression(`((${ClientRuntime.IEventListener})this).Token`);
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Cancel`, System.Action(), new LiteralExpression(`${cts.value}.Cancel`), { getAccess: Access.Default, setAccess: Access.Default, description: '<see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.' }));

    const id = new Parameter('id', dotnet.String, { description: 'The message id' });
    const token = new Parameter('token', System.Threading.CancellationToken, { description: 'The message cancellation token. When this call is cancelled, this should be <c>true</c>' });
    const messageData = new Parameter('messageData', System.Func(ClientRuntime.EventData), { description: 'Detailed message data for the message event.' });
    const signalMethod = this.add(new Method(`${ClientRuntime.IEventListener}.Signal`, System.Threading.Tasks.Task(), {
      async: Modifier.Async,
      parameters: [id, token, messageData],
      access: Access.Default,
      description: 'Handles/Dispatches events during the call to the REST service.',
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the message is completed.`
    }));
    signalMethod.push(Using('NoSynchronizationContext', ''));

    signalMethod.add(function* () {
      yield If(`${token.value}.IsCancellationRequested`, Return());

      // if the 

      const sw = Switch(id, [
        TerminalCase(Events.Verbose.value, function* () {
          yield `WriteVerbose($"{(messageData().Message ?? ${System.String.Empty})}");`;
          yield Return();
        }),

        TerminalCase(Events.Warning.value, function* () {
          yield `WriteWarning($"{(messageData().Message ?? ${System.String.Empty})}");`;
          yield Return();
        }),
        TerminalCase(Events.Information.value, function* () {
          if ($this.operation.asjob) {
            yield '// When an operation supports asjob, Information messages must go thru verbose.';
            yield `WriteVerbose($"INFORMATION: {(messageData().Message ?? ${System.String.Empty})}");`;
          }
          else {
            const data = new LocalVariable('data', dotnet.Var, { initializer: new LiteralExpression(`${messageData.use}()`) });
            yield data.declarationStatement;
            yield 'WriteInformation(data, new[] { data.Message });';
          }
          yield Return();

        }),
        TerminalCase(Events.Debug.value, function* () {
          yield `WriteDebug($"{(messageData().Message ?? ${System.String.Empty})}");`;
          yield Return();
        }),
        TerminalCase(Events.Error.value, function* () {
          yield 'WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );';
          yield Return();
        }),
      ]);

      if ($this.operation.asjob) {
        // if we support -AsJob, we support -NoWait
        sw.add(Case(Events.DelayBeforePolling.value, function* () {
          yield If('true == MyInvocation?.BoundParameters?.ContainsKey("NoWait")', function* () {
            yield 'var data = messageData();';
            yield 'if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)';
            yield '{';
            yield '    var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");';
            yield '    var location = response.GetFirstHeader(@"Location");';
            yield '    var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;';
            yield `    WriteObject(new ${ClientRuntime}.PowerShell.AsyncOperationResponse { Target = uri });`;

            yield '    // do nothing more. ';
            yield '    data.Cancel();';
            yield '    return;';
            yield '}';
          });
        }));
      }

      // the whole switch statement
      yield sw;

      if ($this.state.project.azure) {
        // in azure mode, we signal the AzAccount module with every event that makes it here.
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i,t,m) => ((${ClientRuntime.IEventListener})this).Signal(i,t,()=> ${ClientRuntime.EventDataConverter}.ConvertFrom( m() ) as ${ClientRuntime.EventData} ), ${$this.invocationInfo.value}, this.ParameterSetName, ${$this.correlationId.value}, ${$this.processRecordId.value}, null );`;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      } else {
        // In Non-Azure Modes, emit the Signal method without coorelation and processrecordid
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i,t,m) => ((${ClientRuntime.IEventListener})this).Signal(i,t,()=> ${ClientRuntime.EventDataConverter}.ConvertFrom( m() ) as ${ClientRuntime.EventData} ), ${$this.invocationInfo.value}, this.ParameterSetName, null );`;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      }
      yield `WriteDebug($"{id}: {(messageData().Message ?? ${System.String.Empty})}");`;
      // any handling of the signal on our side...
    });
  }

  private addPowershellParameters(operation: command.CommandOperation) {
    const vps = operation.details.csharp.virtualParameters || {
      body: [],
      operation: [],
    };

    for (const parameter of values(operation.parameters)) {
      // these are the parameters that this command expects
      const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema, true, this.state);

      if (parameter.details.csharp.constantValue) {
        // this parameter has a constant value -- SKIP IT
        continue;
      }

      if (parameter.details.csharp.fromHost) {
        // the parameter is expected to be gotten from the host.(ie, Az.Accounts)

        const hostParameter = this.add(new BackedProperty(parameter.details.csharp.name, td, {
          metadata: {
            parameterDefinition: parameter.details.csharp.httpParameter
          },
          description: parameter.details.csharp.description,
        }));
        this.thingsToSerialize.push(hostParameter);
        // in the BeginProcessing, we should tell it to go get the value for this property from the common module
        this.$<Method>('BeginProcessing').add(hostParameter.assignPrivate(new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.GetParameter(this.MyInvocation, ${this.correlationId.value}, "${parameter.name}") as string`)));
        continue;
      }
      const $this = this;

      if (parameter.details.csharp.apiversion) {
        // Api-version parameters for azure are a custom implementation
        this.add(new Property(parameter.details.csharp.name, td, {
          getAccess: Access.Internal,
          setAccess: Access.Private,
          metadata: {
            parameterDefinition: parameter.details.csharp.httpParameter
          },
          description: parameter.details.csharp.description,
          *get() {
            const metadata = operation.extensions['x-ms-metadata'];
            const profiles = <Dictionary<string>>metadata.profiles || new Dictionary<string>();

            yield Switch(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Profile`, function* () {
              for (const { key: profileName, value: apiVersion } of items(profiles)) {
                yield TerminalCase(`"${profileName}"`, Return(`"${apiVersion}"`));
              }
              yield TerminalDefaultCase(Return(`"${metadata.apiVersions[0]}"`));
            });
          }
        }));
        continue;
      }

      if (this.dropBodyParameter && parameter.details.csharp.isBodyParameter) {
        // we're supposed to use parameters for the body parameter instead of a big object
        const expandedBodyParameter = this.add(new BackedProperty(parameter.details.csharp.name, td, {
          description: parameter.details.csharp.description,

          initializer: (parameter.schema.type === JsonType.Array) ? 'null' : `new ${parameter.schema.details.csharp.fullname}()`,
          setAccess: Access.Private,
          getAccess: Access.Private,
        }));
        this.thingsToSerialize.push(expandedBodyParameter);

        for (const vParam of vps.body) {
          const vSchema = vParam.schema;
          const propertyType = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>vSchema, true, this.state);

          // we need to know if the actual underlying property is actually nullable.
          const nullable = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>vSchema, (<VirtualProperty>vParam.origin).property.details.csharp.required, this.state).isNullable;

          const cmdletParameter = new Property(vParam.name, propertyType, {
            get: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name}${!nullable ? '' : ` ?? ${propertyType.defaultOfType}`}`), // /* ${inspect(vParam.origin)} */
            // get: toExpression(`null == ${expandedBodyParameter.value}.${vParam.origin.name} ? ${propertyType.defaultOfType} : (${propertyType.declaration}) ${expandedBodyParameter.value}.${vParam.origin.name}`),
            set: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name} = value`),
            new: PropertiesRequiringNew.has(vParam.name) ? Modifier.New : Modifier.None
          });

          if (vParam.schema.details.csharp.byReference) {
            // this parameter's schema is marked as 'by-reference' which means we should 
            // tag it with an ExportAs attribute for the I*Reference type.
            cmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${vParam.schema.details.csharp.referenceInterface})`] }));
          }

          if (vParam.schema.type === JsonType.Array) {
            if (vParam.schema.items && vParam.schema.items.details.csharp.byReference) {
              cmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${vParam.schema.items.details.csharp.referenceInterface}[])`] }));
            }
            cmdletParameter.add(new Attribute(AllowEmptyCollectionAttribute));
          }

          if (vSchema.additionalProperties) {
            // we have to figure out if this is a standalone dictionary or a hybrid object/dictionary.
            // if it's a hybrid, we have to create another parameter like -<XXX>AdditionalProperties and have that dump the contents into the dictionary
            // if it's a standalone dictionary, we can just use hashtable instead
            if (length(vSchema.properties) === 0) {
              // it's a pure dictionary
              // add an attribute for changing the exported type.
              cmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${System.Collections.Hashtable})`] }));
            } else {
              // it's a hybrid. We need to add an additional property that puts its items into the target container

            }

          }

          const desc = (vParam.description || '.').replace(/[\r?\n]/gm, '');
          cmdletParameter.description = desc;

          // check if this parameter is a byte array, which would indicate that it should really be a file input
          if (cmdletParameter.type.declaration === dotnet.Binary.declaration) {
            // set the generated parameter to internal
            cmdletParameter.setAccess = Access.Internal;
            cmdletParameter.getAccess = Access.Internal;

            // create a InputFileXXX for the parameter
            const ifname = vParam.name.toLowerCase() === 'value' ? 'InputFile' : pascalCase([vParam.name, 'Input', 'File']);

            const inputFileParameter = new Property(ifname, dotnet.String, {
              // get: toExpression(`${expandedBodyParameter.value}.${vParam.origin.name}${vParam.required ? '' : ` ?? ${propertyType.defaultOfType}`}`),
              set: function* () {
                const provider = Local('provider');
                provider.initializer = undefined;
                const paths = Local('paths', `this.SessionState.Path.GetResolvedProviderPathFromPSPath(value, out ${provider.declarationExpression})`);
                yield paths.declarationStatement;
                yield If(`${provider.value}.Name != "FileSystem" || ${paths.value}.Count == 0`, 'ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("Invalid input path."),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, value) );');
                yield If(`${paths.value}.Count > 1`, 'ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("Multiple input paths not allowed."),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, value) );');
                yield cmdletParameter.assign(`global::System.IO.File.ReadAllBytes(${paths.value}[0])`);
              },
              description: `Input File for ${cmdletParameter.name} (${escapeString(desc)})`
            });

            inputFileParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression(`Mandatory = ${vParam.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "Input File for ${cmdletParameter.name} (${escapeString(desc || '.')})"`)] }));
            inputFileParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Body`] }));

            $this.add(inputFileParameter);
          } else {
            cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression(`Mandatory = ${vParam.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(desc || '.')}"`)] }));
            cmdletParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Body`] }));
            addInfoAttribute(cmdletParameter, propertyType, !!vParam.required, false, desc, (<VirtualProperty>vParam.origin).property.serializedName);
            addCompleterInfo(cmdletParameter, vParam);
            addDefaultInfo(cmdletParameter, vParam);
          }

          const isEnum = propertyType.schema.details.csharp.enum !== undefined;
          const hasEnum = propertyType instanceof ArrayOf && propertyType.elementType instanceof EnumImplementation;
          if (isEnum || hasEnum) {
            cmdletParameter.add(new Attribute(ArgumentCompleterAttribute, { parameters: [`typeof(${hasEnum ? (<ArrayOf>propertyType).elementType.declaration : propertyType.declaration})`] }));
          }
          // add aliases if there is any
          if (length(vParam.alias) > 0) {
            cmdletParameter.add(new Attribute(Alias, { parameters: vParam.alias.map(x => '"' + x + '"') }));
          }

          this.add(cmdletParameter);
        }

        if (parameter.schema.additionalProperties) {
          // if there is an additional properties on this type
          // add a hashtable parameter for additionalProperties
          let apPropName = '';
          const options = ['AdditionalProperties', 'MoreProperties', 'ExtendedProperties', 'Properties'];
          for (const n of options) {
            if (this.properties.find(each => each.name === n)) {
              continue;
            }
            apPropName = n;
            break;
          }

          this.apProp = this.add(new Property(apPropName, System.Collections.Hashtable));
          this.apProp.add(new Attribute(ParameterAttribute, {
            parameters: ['Mandatory = false', 'HelpMessage = "Additional Parameters"']
          }));
          this.bodyParameterInfo = {
            type: {
              declaration: parameter.schema.details.csharp.fullname
            },
            valueType: parameter.schema.additionalProperties === true ? System.Object : this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>parameter.schema.additionalProperties, true, this.state)
          };
        }

        this.bodyParameter = expandedBodyParameter;
        continue;
      }
    }

    if (this.isViaIdentity) {
      // add in the pipeline parameter for the identity

      const idschema = values(this.state.project.model.schemas).first(each => each.details.default.uid === 'universal-parameter-type');
      const idtd = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>idschema, true, this.state);
      const idParam = this.add(new BackedProperty('InputObject', idtd, {
        description: 'Identity Parameter'
      }));
      const parameters = [new LiteralExpression('Mandatory = true'), new LiteralExpression('HelpMessage = "Identity Parameter"'), new LiteralExpression('ValueFromPipeline = true')];
      idParam.add(new Attribute(ParameterAttribute, { parameters }));
      idParam.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Path`] }));
    }
    for (const vParam of values(vps.operation)) {
      const vSchema = vParam.schema;
      const propertyType = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<Schema>vSchema, true, this.state);


      const origin = <IParameter>vParam.origin;

      const regularCmdletParameter = (this.state.project.azure && vParam.name === 'SubscriptionId' && operation.details.csharp.verb.toLowerCase() === 'get') ?

        // special case for subscription id
        this.add(new BackedProperty(vParam.name, dotnet.StringArray, {
          metadata: {
            parameterDefinition: origin.details.csharp.httpParameter
          },
          description: vParam.description
        })) :

        // everything else
        this.add(new BackedProperty(vParam.name, propertyType, {
          metadata: {
            parameterDefinition: origin.details.csharp.httpParameter
          },
          description: vParam.description
        }));

      if (vSchema.additionalProperties) {
        // we have to figure out if this is a standalone dictionary or a hybrid object/dictionary.
        // if it's a hybrid, we have to create another parameter like -<XXX>AdditionalProperties and have that dump the contents into the dictionary
        // if it's a standalone dictionary, we can just use hashtable instead
        if (length(vSchema.properties) === 0) {
          // it's a pure dictionary
          // change the property type to hashtable.
          // add an attribute to change the exported type.
          regularCmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${System.Collections.Hashtable})`] }));
        } else {
          // it's a hybrid. We need to add an additional property that puts its items into the target container

        }

      }

      this.thingsToSerialize.push(regularCmdletParameter);

      const parameters = [new LiteralExpression(`Mandatory = ${vParam.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(vParam.description) || '.'}"`)];
      if (origin.details.csharp.isBodyParameter) {
        parameters.push(new LiteralExpression('ValueFromPipeline = true'));
        this.bodyParameter = regularCmdletParameter;
      }
      regularCmdletParameter.add(new Attribute(ParameterAttribute, { parameters }));
      if (vParam.schema.type === JsonType.Array) {
        regularCmdletParameter.add(new Attribute(AllowEmptyCollectionAttribute));
      }

      addInfoAttribute(regularCmdletParameter, propertyType, vParam.required, false, vParam.description, vParam.origin.name);
      addCompleterInfo(regularCmdletParameter, vParam);
      addDefaultInfo(regularCmdletParameter, vParam);

      // add aliases if there is any
      if (length(vParam.alias) > 0) {
        regularCmdletParameter.add(new Attribute(Alias, { parameters: vParam.alias.map(x => '"' + x + '"') }));
      }

      const httpParam = origin.details.csharp.httpParameter;
      const uid = httpParam ? httpParam.details.csharp.uid : 'no-parameter';

      const cat = values(operation.callGraph[0].parameters).
        where(each => !(each.details.csharp.constantValue)).
        first(each => each.details.csharp.uid === uid);

      if (cat) {
        regularCmdletParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.${pascalCase(cat.in)}`] }));
      }


      if (origin.details.csharp.completer) {
        // add the completer to this class and tag this parameter with the completer.
        // regularCmdletParameter.add(new Attribute(ArgumentCompleterAttribute, { parameters: [`typeof(${this.declaration})`] }));
      }

      const isEnum = propertyType.schema.details.csharp.enum !== undefined;
      const hasEnum = propertyType instanceof ArrayOf && propertyType.elementType instanceof EnumImplementation;
      if (isEnum || hasEnum) {
        regularCmdletParameter.add(new Attribute(ArgumentCompleterAttribute, { parameters: [`typeof(${hasEnum ? (<ArrayOf>propertyType).elementType.declaration : propertyType.declaration})`] }));
      }
    }
    const ifmatch = this.properties.find((v) => v.name.toLowerCase() === 'ifmatch');
    if (ifmatch) {
    }

  }

  private addClassAttributes(operation: command.CommandOperation, variantName: string) {
    const cmdletAttribParams: Array<ExpressionOrLiteral> = [
      category[operation.details.csharp.verb] ? verbEnum(category[operation.details.csharp.verb], operation.details.csharp.verb) : `"${operation.details.csharp.verb}"`,
      new StringExpression(variantName)
    ];

    if (this.isWritableCmdlet(operation)) {
      cmdletAttribParams.push('SupportsShouldProcess = true');
    }

    if (operation.details.csharp.hidden) {
      this.add(new Attribute(InternalExportAttribute));
      const noun = `${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}`;
      const cmdletName = `${operation.details.csharp.verb}-${noun}${operation.details.csharp.name ? `_${operation.details.csharp.name}` : ''}`;
      this.state.message({ Channel: Channel.Debug, Text: `[DIRECTIVE] Applied 'hidden' directive to ${cmdletName}. Added attribute ${InternalExportAttribute.declaration} to cmdlet.` });
    }

    this.add(new Attribute(CmdletAttribute, { parameters: cmdletAttribParams }));

    // add alias attribute if there is any aliases for this cmdlet
    if (length(operation.details.csharp.alias) > 0) {
      this.add(new Attribute(Alias, { parameters: operation.details.csharp.alias.map((x: string) => '"' + x + '"') }));
    }

    let shouldAddPassThru = false;
    // set to hold the output types
    const outputTypes = new Set<string>();
    for (const httpOperation of values(operation.callGraph)) {
      const pageableInfo = httpOperation.details.csharp.pageable;
      for (const item of items(httpOperation.responses).where(each => each.key !== 'default')) {
        for (const schema of values(item.value).selectNonNullable(each => each.schema)) {
          const props = getAllProperties(schema);

          // does the target type just wrap a single output?
          const resultSchema = length(props) !== 1 ? <Schema>schema : <Schema>props[0].schema;

          // make sure return type for boolean stays boolean!
          if (resultSchema.type === JsonType.Boolean) {
            outputTypes.add(`typeof(${dotnet.Bool})`);
          } else {
            const typeDeclaration = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(resultSchema, true, this.state);

            if (typeDeclaration.declaration === System.IO.Stream.declaration || typeDeclaration.declaration === dotnet.Binary.declaration) {
              // if this is a stream, skip the output type.
              this.hasStreamOutput = true;
              shouldAddPassThru = true;
              outputTypes.add(`typeof(${dotnet.Bool})`);
            } else {

              let type = '';
              if (typeDeclaration instanceof ArrayOf) {
                type = typeDeclaration.elementTypeDeclaration;
              } else if (pageableInfo && pageableInfo.responseType === 'pageable') {
                if (typeDeclaration === undefined || typeDeclaration.schema.properties[pageableInfo.itemName] === undefined) {
                  throw new Error(`\n\nOn operation:\n  '${httpOperation.operationId}' at '${httpOperation.path}'\n  -- you have used 'x-ms-pageable' and there is no property name '${pageableInfo.itemName}' that is an array.\n\n`);
                }
                const nestedSchema = typeDeclaration.schema.properties[pageableInfo.itemName].schema;
                const nestedTypeDeclaration = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(nestedSchema, true, this.state);
                type = (<ArrayOf>nestedTypeDeclaration).elementTypeDeclaration;
              } else {
                type = typeDeclaration.declaration;
              }
              // check if this is a stream output
              if (type) {
                outputTypes.add(`typeof(${type})`);
              }
            }
          }
        }
      }
    }

    // if any response does not return,
    // the cmdlet should have a PassThru parameter
    shouldAddPassThru = shouldAddPassThru || values(operation.callGraph)
      .selectMany(httpOperation => items(httpOperation.responses))
      .selectMany(responsesItem => responsesItem.value)
      .any(value => value.schema === undefined);
    if (outputTypes.size === 0) {
      outputTypes.add(`typeof(${dotnet.Bool})`);
    }

    this.add(new Attribute(OutputTypeAttribute, { parameters: [...outputTypes] }));
    if (shouldAddPassThru) {
      const passThru = this.add(new Property('PassThru', SwitchParameter, { description: 'When specified, forces the cmdlet return a \'bool\' given that there isn\'t a return type by default.' }));
      passThru.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "Returns true when the command succeeds"'] }));
      passThru.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));
    }

    this.add(new Attribute(DescriptionAttribute, { parameters: [new StringExpression(this.description)] }));
    this.add(new Attribute(GeneratedAttribute));
    if (operation.extensions && operation.extensions['x-ms-metadata'] && operation.extensions['x-ms-metadata'].profiles) {
      const profileNames = Object.keys(operation.extensions && operation.extensions['x-ms-metadata'].profiles);
      // wrap profile names
      profileNames.forEach((element, index) => {
        profileNames[index] = `"${element}"`;
      });

      this.add(new Attribute(ProfileAttribute, { parameters: [...profileNames] }));
    }
  }
}
