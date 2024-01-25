/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

const ejs = require('ejs');
import { Schema as NewSchema, SchemaType, ArraySchema, SchemaResponse, HttpParameter, ObjectSchema, BinaryResponse, DictionarySchema, ChoiceSchema, SealedChoiceSchema, Response, Operation } from '@autorest/codemodel';
import { command, getAllProperties, JsonType, http, getAllPublicVirtualProperties, getVirtualPropertyFromPropertyName, ParameterLocation, getAllVirtualProperties, VirtualParameter, VirtualProperty } from '@azure-tools/codemodel-v3';
import { CommandOperation, isWritableCmdlet, OperationType, VirtualParameter as NewVirtualParameter, CommandType } from '../utils/command-operation';
import { getAllProperties as NewGetAllProperties, getAllPublicVirtualProperties as NewGetAllPublicVirtualProperties, getVirtualPropertyFromPropertyName as NewGetVirtualPropertyFromPropertyName, VirtualProperty as NewVirtualProperty } from '../utils/schema';
import { escapeString, docComment, serialize, pascalCase, DeepPartial, camelCase } from '@azure-tools/codegen';
import { items, values, Dictionary, length } from '@azure-tools/linq';
import {
  Access, Attribute, BackedProperty, Catch, Class, ClassType, Constructor, dotnet, Else, Expression, Finally, ForEach, If, LambdaProperty, LiteralExpression, LocalVariable, Method, Modifier, Namespace, OneOrMoreStatements, Parameter, Property, Return, Statements, BlockStatement, StringExpression,
  Switch, System, TerminalCase, toExpression, Try, Using, valueOf, Field, IsNull, Or, ExpressionOrLiteral, TerminalDefaultCase, xmlize, TypeDeclaration, And, IsNotNull, PartialMethod, Case, While, LiteralStatement, Not, ElseIf
} from '@azure-tools/codegen-csharp';
import { ClientRuntime, EventListener, Schema, ArrayOf, EnumImplementation } from '../llcsharp/exports';
import { Alias, ArgumentCompleterAttribute, PSArgumentCompleterAttribute, AsyncCommandRuntime, AsyncJob, CmdletAttribute, ErrorCategory, ErrorRecord, Events, InvocationInfo, OutputTypeAttribute, ParameterAttribute, PSCmdlet, PSCredential, SwitchParameter, ValidateNotNull, verbEnum, GeneratedAttribute, DescriptionAttribute, ExternalDocsAttribute, CategoryAttribute, ParameterCategory, ProfileAttribute, PSObject, InternalExportAttribute, ExportAsAttribute, DefaultRunspace, RunspaceFactory, AllowEmptyCollectionAttribute, DoNotExportAttribute, HttpPathAttribute, NotSuggestDefaultParameterSetAttribute } from '../internal/powershell-declarations';
import { State } from '../internal/state';
import { Channel } from '@autorest/extension-base';
import { IParameter } from '@azure-tools/codemodel-v3/dist/code-model/components';
import { IParameter as NewIParameter } from '../utils/components';
import { Variable, Local, ParameterModifier } from '@azure-tools/codegen-csharp';
import { getVirtualPropertyName } from '../llcsharp/model/model-class';
import { HandlerDirective } from '../plugins/modifiers-v2';
import { getChildResourceNameFromPath, getResourceNameFromPath } from '../utils/resourceName';
import { OperationParameter } from '../llcsharp/operation/parameter';
import { get } from 'http';
import { hasValidBodyParameters } from '../utils/http-operation';
import { assert } from 'console';
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

export function NewAddCompleterInfo(targetProperty: Property, parameter: NewVirtualParameter) {
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

export function isEnumImplementation(schema: NewSchema | undefined): boolean {
  return (schema?.type === SchemaType.SealedChoice && !schema.language.default.skip) ||
    (schema?.extensions && schema.extensions['x-ms-enum']);
}

export function addPSArgumentCompleterAttribute(targetProperty: Property, parameterSchema: any) {
  const enumValues = values(parameterSchema.language.csharp.enum.values).select(v => `"${(<string>(<any>v).value)}"`).toArray().join(', ');
  targetProperty.add(new Attribute(PSArgumentCompleterAttribute, { parameters: [`${enumValues}`] }));
}

export function addParameterBreakingChange(targetProperty: Property, parameter: any) {
  if (parameter.breakingChange) {
    const parameters = [];
    parameters.push(`"${parameter.breakingChange.parameterName}"`);
    if (!parameter.breakingChange.deprecateByVersion || !parameter.breakingChange.deprecateByAzVersion) {
      throw new Error(`breakingChange.deprecateByVersion and breakingChange.deprecateByAzVersion must be set for ${parameter.name}`);
    }
    parameters.push(`"${parameter.breakingChange.deprecateByAzVersion}"`);
    parameters.push(`"${parameter.breakingChange.deprecateByVersion}"`);
    if (parameter.breakingChange.changeInEfectByDate) parameters.push(`"${parameter.breakingChange.changeInEfectByDate}"`);
    if (parameter.breakingChange.replacement) parameters.push(`ReplaceMentCmdletParameterName="${parameter.breakingChange.replacement}"`);
    if (parameter.breakingChange.isBecomingMandatory) parameters.push(`IsBecomingMandatory=${parameter.breakingChange.isBecomingMandatory}`);
    if (parameter.breakingChange.changeDescription) parameters.push(`ChangeDescription="${parameter.breakingChange.changeDescription}"`);
    if (parameter.breakingChange.newParameterType) {
      // If old type is set in directive, use it, otherwise try to get the type from the schema
      if (parameter.breakingChange.oldParamaterType) {
        parameters.push(`OldParamaterType="${parameter.breakingChange.oldParamaterType}"`);
      } else {
        // for primitive types, should use name, otherwise use fullname which contains namespace
        parameters.push(`OldParamaterType="${parameter.schema.language.csharp.fullname.startsWith('<') ? parameter.schema.language.csharp.name : parameter.schema.language.csharp.fullname}"`);
      }
      parameters.push(`NewParameterType="${parameter.breakingChange.newParameterType}"`);
    }
    targetProperty.add(new Attribute(ClientRuntime.ParameterBreakingChangeAttribute, {
      parameters: parameters
    }));
  }
}

export function addParameterPreviewMessage(targetProperty: Property, parameter: any) {
  if (parameter.previewAnnouncement) {
    const parameters = [];
    parameters.push(`"${parameter.previewAnnouncement.previewMessage}"`);
    if (parameter.previewAnnouncement.estimatedGaDate) parameters.push(`"${parameter.previewAnnouncement.estimatedGaDate}"`);
    targetProperty.add(new Attribute(ClientRuntime.PreviewMessageAttribute, { parameters: parameters }));
  }
}

export function addDefaultInfo(targetProperty: Property, parameter: any) {
  if (parameter.defaultInfo && parameter.defaultInfo.script) {
    targetProperty.add(new Attribute(ClientRuntime.DefaultInfoAttribute, {
      parameters: [
        new LiteralExpression(`\nName = ${new StringExpression(parameter.defaultInfo.name || '').value}`),
        new LiteralExpression(`\nDescription =${new StringExpression(parameter.defaultInfo.description || '').value}`),
        new LiteralExpression(`\nScript = ${new StringExpression(parameter.defaultInfo.script).value}`),
        new LiteralExpression(`\nSetCondition = ${new StringExpression(parameter.defaultInfo['set-condition'] || '').value}`)
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


export function NewAddInfoAttribute(targetProperty: Property, pType: TypeDeclaration, isRequired: boolean, isReadOnly: boolean, description: string, serializedName: string) {

  let pt = <any>pType;
  while (pt.elementType) {
    switch (pt.elementType.schema.type) {
      case JsonType.Object:
        if (pt.elementType.schema.language.csharp.interfaceImplementation) {
          pt = {
            declaration: pt.elementType.schema.language.csharp.interfaceImplementation.declaration,
            schema: pt.elementType.schema,
          };
        } else {
          // arg! it's not done yet. Hope it's not polymorphic itself.
          pt = {
            declaration: `${pt.elementType.schema.language.csharp.namespace}.${pt.elementType.schema.language.csharp.interfaceName}`,
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
  if (pt.schema && pt.schema && pt.schema.language.csharp.byReference) {
    ptypes.push(`typeof(${pt.schema.language.csharp.namespace}.${pt.schema.language.csharp.interfaceName}_Reference)`);
    // do we need polymorphic types for by-resource ? Don't think so.
  } else {
    ptypes.push(`typeof(${pt.declaration})`);
    if (pt.schema && pt.schema.language.csharp.classImplementation && pt.schema.language.csharp.classImplementation.discriminators) {
      ptypes.push(...[...pt.schema.language.csharp.classImplementation.discriminators.values()].map(each => `typeof(${each.modelInterface.fullName})`));
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

type operationParameter = {
  name: Property;
  expression: Property;
  parameterLocation: ParameterLocation;
} | {
  name: Property;
  expression: Expression;
  parameterLocation: ParameterLocation;
} | {
  name: string | undefined;
  expression: LiteralExpression;
  parameterLocation: ParameterLocation;
};

type PreProcess = ((cmdlet: CmdletClass, pathParameters: Array<Expression>, nonPathParameters: Array<Expression | Property>, viaIdentity: boolean) => Statements) | undefined;
type ProcessGetResponse = ((cmdlet: CmdletClass) => Statements) | undefined;
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
  private operation: CommandOperation;
  private debugMode?: boolean;
  private variantName: string;
  private isViaIdentity: boolean;
  private hasStreamOutput: boolean;
  private outFileParameter?: Property;
  private clientsidePagination?: boolean;
  private inputObjectParameterName: string;
  private apiCall: Operation;
  private operationParameters: Array<operationParameter>;
  private responses: Array<Response>;
  private callbackMethods: Array<LiteralExpression>;
  private serializationMode: LiteralExpression | undefined;

  constructor(namespace: Namespace, operation: CommandOperation, state: State, objectInitializer?: DeepPartial<CmdletClass>) {
    // generate the 'variant'  part of the name
    const noun = `${state.project.prefix}${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}`;
    const variantName = `${noun}${operation.details.csharp.name ? `_${operation.details.csharp.name}` : ''}`;

    const name = `${operation.details.csharp.verb}${variantName}`;
    super(namespace, name, PSCmdlet);
    this.dropBodyParameter = operation.details.csharp.dropBodyParameter ? true : false;
    this.apply(objectInitializer);
    this.operation = operation;
    this.apiCall = this.operation.callGraph[this.operation.callGraph.length - 1];
    // create the response handlers
    this.responses = [...values(this.apiCall.responses), ...values(this.apiCall.exceptions)];
    this.callbackMethods = values(this.responses).toArray().map(each => new LiteralExpression(each.language.csharp?.name || ''));
    this.operationParameters = [];
    this.state = state;
    this.thingsToSerialize = [];
    this.variantName = variantName;
    this.hasStreamOutput = false;

    this.interfaces.push(ClientRuntime.IEventListener);
    this.interfaces.push(ClientRuntime.IContext);
    this.eventListener = new EventListener(new LiteralExpression(`((${ClientRuntime.IEventListener})this)`), true);

    this.isViaIdentity = variantName.indexOf('ViaIdentity') > 0;
    this.clientsidePagination = !!operation.details.csharp.clientsidePagination && !!this.apiCall.language.csharp?.pageable;
    this.inputObjectParameterName = 'InputObject';

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
        if ($this.state.project.azure) {
          yield `var telemetryId = ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.GetTelemetryId.Invoke();`;
          yield If('telemetryId != "" && telemetryId != "internal"', '__correlationId = telemetryId;');
        }
        yield 'Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);';
        yield If($this.$<Property>('Break'), `${ClientRuntime.AttachDebugger}.Break();`);

        yield $this.eventListener.syncSignal(Events.CmdletBeginProcessing);
      }
    }));

    // construct the class
    this.NewAddClassAttributes(this.operation, this.variantName);
    if (this.hasStreamOutput) {
      this.outFileParameter = this.add(new Property('OutFile', System.String, { attributes: [], description: 'Path to write output file to.' }));
      this.outFileParameter.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = true', 'HelpMessage = "Path to write output file to"'] }));
      this.outFileParameter.add(new Attribute(ValidateNotNull));
      this.outFileParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Body`] }));
    }

    this.NewAddPowershellParameters(this.operation);

    // implement IEventListener
    this.implementIEventListener();

    // implement part of the IContext
    this.implementIContext();

    // add constructors
    this.implementConstructors();

    // add callback methods
    this.NewImplementResponseMethod();

    // processRecord
    this.NewImplementProcessRecord();

    // find each parameter to the method, and find out where the value is going to come from.
    this.operationParameters =
      values(this.apiCall.parameters).
        // filter out constants and path parameters when using piping for identity
        where(each => !(each.language.csharp?.constantValue) && each.language.default?.name !== '$host'/* && (!$this.isViaIdentity || each.in !== ParameterLocation.Path) */).
        select(p => {
          return {
            name: p.language.csharp?.name,
            param: values(this.properties).
              where(each => each.metadata.parameterDefinition).
              first(each => each.metadata.parameterDefinition.language.csharp?.serializedName === p.language.csharp?.serializedName), // xichen: Is it safe enough to use serializedName?
            parameterLocation: p.protocol?.http?.in
          };

        }).
        select(each => {
          if (each.param) {

            const httpParam = (<HttpParameter>(each.param.metadata.parameterDefinition));
            if (httpParam.required) {
              return {
                name: each.param,
                expression: each.param,
                parameterLocation: each.parameterLocation
              };
            }

            const httpParamTD = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration((<NewSchema>httpParam.schema), httpParam.required, this.state);
            return {
              name: each.param,
              expression: toExpression(`this.InvocationInformation.BoundParameters.ContainsKey("${each.param.value}") ? ${each.param.value} : ${httpParamTD.defaultOfType}`),
              parameterLocation: each.parameterLocation
            };

          }
          return { name: each.name, expression: dotnet.Null, parameterLocation: each.parameterLocation };
        }).toArray();

    this.NewImplementProcessRecordAsync();
    this.debugMode = await this.state.getValue('debug', false);

    // json serialization
    this.NewImplementSerialization(this.operation);

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
      const request = httpOperation.requests?.[0];
      if (!request) {
        continue;
      }
      const httpMethod = request.protocol.http?.method ?? '';
      const httpPath = request.protocol.http?.path ?? '';
      ops = `${ops}\n[OpenAPI] ${httpOperation.language.default.name}=>${httpMethod.toUpperCase()}:"${httpPath}"`;
      if (this.debugMode) {
        // x-ms-metadata seems no longer exists
        // const m = (httpOperation.extensions && httpOperation.extensions['x-ms-metadata']) || (httpOperation.pathExtensions ? httpOperation.pathExtensions['x-ms-metadata'] : undefined);
        // if (m) {
        //   ops = `${ops}\n [METADATA]\n${serialize(m)}`;
        // }

        ops = `${ops}\n [DETAILS]`;
        ops = `${ops}\n verb: ${this.operation.details.csharp.verb}`;
        ops = `${ops}\n subjectPrefix: ${this.operation.details.csharp.subjectPrefix}`;
        ops = `${ops}\n subject: ${this.operation.details.csharp.subject}`;
        ops = `${ops}\n variant: ${this.operation.details.csharp.name}`;
      }
    }

    return ops ? `${header}\n${docComment(xmlize('remarks', ops))}` : header;
  }

  private AddSwitchViewProperty(responseType: TypeDeclaration = dotnet.Object) {
    const fieldNames = this.fields.map(f => f.name);
    if (!fieldNames.includes('_responseSize')) {
      this.add(new Field('_responseSize', dotnet.Int, {
        initialValue: '0', description: 'A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object. Two means multiple returned objects in response.', access: Access.Private
      }));
    }
    if (!fieldNames.includes('_firstResponse')) {
      this.add(new Field('_firstResponse', responseType, {
        initialValue: dotnet.Null, description: 'A buffer to record first returned object in response.', access: Access.Private
      }));
    }
  }

  private FlushResponse(singleFlush = true) {
    const fieldNames = this.fields.map(f => f.name);
    return fieldNames.includes('_responseSize') ?
      If('1 ==_responseSize', function* () {
        yield '// Flush buffer';
        if (singleFlush) {
          yield 'WriteObject(_firstResponse);';
        } else {
          yield 'WriteObject(_firstResponse.AddMultipleTypeNameIntoPSObject());';
        }
      }) : '';
  }

  private WriteObjectWithViewControl(valueName: string, isEnumerable = false) {
    const $this = this;
    if ($this.state.project.autoSwitchView) {
      if (isEnumerable) {
        return function* () {
          yield If(`null != ${valueName}`, function* () {
            yield If(`0 == _responseSize && 1 == ${valueName}.Count`, function* () {
              yield `_firstResponse = ${valueName}[0];`;
              yield '_responseSize = 1;';
            });
            yield Else(function* () {
              yield $this.FlushResponse(false);
              yield 'var values = new System.Collections.Generic.List<System.Management.Automation.PSObject>();';
              yield ForEach('value', valueName, function* () {
                yield 'values.Add(value.AddMultipleTypeNameIntoPSObject());';
              });
              yield 'WriteObject(values, true); ';
              yield '_responseSize = 2;';
            });
          });
        };
      } else {
        return function* () {
          yield If(`null != ${valueName}`, function* () {
            yield If('0 == _responseSize', function* () {
              yield `_firstResponse = ${valueName};`;
              yield '_responseSize = 1;';
            });
            yield Else(function* () {
              yield $this.FlushResponse(false);
              yield `WriteObject(${valueName}.AddMultipleTypeNameIntoPSObject());`;
              yield '_responseSize = 2;';
            });
          });
        };
      }
    } else {
      return `WriteObject(${valueName}, ${isEnumerable});`;
    }
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

    // switch view property
    if (this.state.project.autoSwitchView) {
      this.AddSwitchViewProperty(dotnet.Object);
    }

    // pipeline property
    this.add(new Property('Pipeline', ClientRuntime.HttpPipeline, { getAccess: Access.Public, setAccess: Access.Public, description: `The instance of the <see cref="${ClientRuntime.HttpPipeline}" /> that the remote call will use.` }));

    // client API property (gs01: fill this in correctly)
    const clientAPI = new ClassType(this.state.model.language.csharp?.namespace, this.state.model.language.csharp?.name || '');
    this.add(new LambdaProperty('Client', clientAPI, new LiteralExpression(`${this.state.project.serviceNamespace.moduleClass.declaration}.Instance.ClientAPI`), { description: 'The reference to the client API class.' }));

    this.add(new Method('StopProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: 'Interrupts currently running code within the command.' })).add(function* () {
      yield `((${ClientRuntime.IEventListener})this).Cancel();`;
      yield 'base.StopProcessing();';
    });

    const $this = this;
    this.add(new Method('EndProcessing', dotnet.Void, { access: Access.Protected, override: Modifier.Override, description: 'Performs clean-up after the command execution' })).add(
      function* () {
        // gs01: remember what you were doing here to make it so these can be parallelized...
        if ($this.state.project.autoSwitchView) {
          yield $this.FlushResponse();
        }
        if (!$this.state.project.azure) {
          yield $this.eventListener.syncSignal(Events.CmdletEndProcessing);
        }
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
      this.defaultProfile = this.add(new Property('DefaultProfile', PSObject, { description: 'The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription' }));
      this.defaultProfile.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription."'] }));
      this.defaultProfile.add(new Attribute(ValidateNotNull));
      this.defaultProfile.add(new Attribute(Alias, { parameters: ['"AzureRMContext"', '"AzureCredential"'] }));
      this.defaultProfile.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Azure`] }));
    }
  }

  private NewImplementProcessRecord() {
    const $this = this;
    const operation: CommandOperation = $this.operation;
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

        if (isWritableCmdlet(operation) && !operation.details.csharp.supportShouldProcess) {
          yield If(`ShouldProcess($"Call remote '${$this.apiCall.language.csharp?.name}' operation")`, work);
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

  private NewImplementProcessRecordAsync() {
    const $this = this;
    const operationParameters = $this.operationParameters;
    const pipeline = $this.$<Property>('Pipeline');
    this.serializationMode = this.bodyParameter ? (this.operation.operationType === OperationType.Create ? ClientRuntime.SerializationMode.IncludeCreate : (this.operation.operationType === OperationType.Update ? ClientRuntime.SerializationMode.IncludeUpdate : undefined)) : undefined;

    const PRA = this.add(new Method('ProcessRecordAsync', System.Threading.Tasks.Task(), {
      access: Access.Protected, async: Modifier.Async,
      description: 'Performs execution of the command, working asynchronously if required.',
      returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
    }));

    // we don't want to use SynchContext here.
    PRA.push(Using('NoSynchronizationContext', ''));
    PRA.add(function* () {
      if ($this.apProp && $this.bodyParameter && $this.bodyParameterInfo) {
        // yield `${ClientRuntime}.DictionaryExtensions.HashTableToDictionary<${$this.bodyParameterInfo.type.declaration},${$this.bodyParameterInfo.valueType.declaration}>(${$this.apProp.value},${$this.bodyParameter.Cast($this.bodyParameterInfo.type)});`;
        let vt = $this.bodyParameterInfo.valueType.declaration;
        if (vt.endsWith('SwitchParameter')) {
          vt = 'bool';
        }
        yield `${ClientRuntime}.DictionaryExtensions.HashTableToDictionary<${vt}>(${$this.apProp.value},${$this.bodyParameter}.AdditionalProperties);`;
      }

      // construct the call to the operation
      if (!$this.state.project.azure) {
        yield $this.eventListener.signal(Events.CmdletProcessRecordAsyncStart);
      }

      yield $this.eventListener.signal(Events.CmdletGetPipeline);

      if ($this.state.project.azure) {
        yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(${$this.invocationInfo}, ${$this.correlationId}, ${$this.processRecordId}, this.ParameterSetName, this.ExtensibleParameters)`));
      } else {
        yield pipeline.assign(new LiteralExpression(`${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.CreatePipeline(${$this.invocationInfo}, this.ParameterSetName, this.ExtensibleParameters)`));
      }

      yield If(IsNotNull($this.$<Property>('HttpPipelinePrepend')), pipeline.invokeMethod('Prepend', toExpression(`(this.CommandRuntime as Microsoft.Rest.ClientRuntime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(${$this.$<Property>('HttpPipelinePrepend')}) ?? ${$this.$<Property>('HttpPipelinePrepend')}`)));
      yield If(IsNotNull($this.$<Property>('HttpPipelineAppend')), pipeline.invokeMethod('Append', toExpression(`(this.CommandRuntime as Microsoft.Rest.ClientRuntime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(${$this.$<Property>('HttpPipelineAppend')}) ?? ${$this.$<Property>('HttpPipelineAppend')}`)));

      yield '// get the client instance';
      // Add input pipeline if it is configured by developers.
      if ($this.operation.extensions.inputPipe) {
        const handlers = <Array<HandlerDirective>>$this.operation.extensions.inputPipe;
        // default priority is 100
        handlers.sort((a, b) => { return (a.priority || 100) - (b.priority || 100); });
        for (const { index, handler } of handlers.map((handler, index) => ({ index, handler }))) {
          yield `var handler_${index} = new ${handler.name}();`;
          if (index > 0) {
            yield `handler_${index - 1}.SetNextHandler(handler_${index});`;
          }
        }
        yield 'handler_0.Process(this);';
      }
      const vps = $this.operation.details.csharp.virtualParameters || {
        body: [],
        operation: [],
      };
      for (const vParam of [...vps.body, ...vps.operation]) {
        if (vParam.hidden) {
          const td = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<NewSchema>vParam.schema, true, $this.state, true);
          yield If(`true == this.MyInvocation?.BoundParameters?.ContainsKey("${vParam.name}")`, `${vParam.name} = (${td.declaration})this.MyInvocation.BoundParameters["${vParam.name}"];`);
        }
      }

      // is there a body parameter we should include?
      // if ($this.bodyParameter) {
      //   operationParameters.push({ name: 'body', expression: $this.bodyParameter, isPathParam: false });
      // }

      yield Try(function* () {
        // make the call.
        let preProcess: PreProcess;
        switch ($this.operation.commandType) {
          case CommandType.ManagedIdentityUpdate:
            preProcess = $this.ManagedIdentityUpdateCmdletPreProcess;
            break;
          case CommandType.GetPut:
            preProcess = $this.GetPutPreProcess;
            break;
          case CommandType.Atomic:
          default:
            if (!$this.state.project.keepIdentityType &&
              $this.operation.details.csharp.verb.toLowerCase() === 'new' &&
              $this.ContainsIdentityTypeParameter() &&
              $this.ContainsUserAssignedIdentityParameter()) {
              preProcess = $this.ManagedIdentityPreProcessForNewVerbCmdlet;
            }
            preProcess = undefined;
            break;
        }
        const actualCall = function* () {
          yield $this.eventListener.signal(Events.CmdletBeforeAPICall);
          yield $this.ImplementCall(preProcess);
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
        yield `WriteError(new global::System.Management.Automation.ErrorRecord(${ure.value}, ${ure.value}.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e.expression) !== 'null').map(each => `${each.name}=${each.expression}`).join(',')}})
{
  ErrorDetails = new global::System.Management.Automation.ErrorDetails(${ure.value}.Message) { RecommendedAction = ${ure.value}.Action }
});`;
      });
      yield Finally(function* () {
        yield $this.eventListener.signalNoCheck(Events.CmdletProcessRecordAsyncEnd);
      });
    });
  }

  private * ImplementCall(preProcess: PreProcess) {
    const $this = this;
    const operation = $this.operation;
    const apiCall = $this.apiCall;
    const operationParameters: Array<operationParameter> = $this.operationParameters;
    const callbackMethods = $this.callbackMethods;
    const pipeline = $this.$<Property>('Pipeline');
    const serializationMode = $this.serializationMode;
    const bodyParameter = this.bodyParameter ? { name: 'body', value: valueOf(this.bodyParameter) } : undefined;
    const pathParamsNotInIdentity: Array<{ name: string | undefined; value: string; }> = [];
    const pathParamsInIdentity: Array<{ name: string; value: string; }> = [];
    const pathParamsInIdentitySerializedName: Array<string> = [];
    const headerParams: Array<{ name: string | undefined; value: string; }> = [];
    const queryParams: Array<{ name: string | undefined; value: string; }> = [];
    const otherParams: Array<{ name: string | undefined; value: string; }> = [];
    const idschema = values($this.state.project.model.schemas.objects).first(each => each.language.default.uid === 'universal-parameter-type');
    let httpOperationName = `${apiCall.language.csharp?.name}`;

    if (idschema) {
      const allVPs = NewGetAllPublicVirtualProperties(idschema.language.csharp?.virtualProperties);
      const props = [...values(idschema.properties)];
      operationParameters.forEach(each => {
        const pascalName = pascalCase(`${each.name}`);
        //push parameters that is not path parameters into allParams and idOpParamsNotFromIdentity
        if (each.parameterLocation !== ParameterLocation.Path) {
          const param = {
            name: undefined,
            value: valueOf(each.expression)
          };
          switch (each.parameterLocation) {
            case ParameterLocation.Header:
              headerParams.push(param);
              break;
            case ParameterLocation.Query:
              queryParams.push(param);
              break;
            default:
              otherParams.push(param);
              break;
          }
          return;
        } else {
          const match = props.find(p => pascalCase(p.serializedName) === pascalName);
          if (match) {

            const defaultOfType = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(match.schema, true, $this.state).defaultOfType;
            // match up vp name
            const vp = allVPs.find(pp => pascalCase(pp.property.serializedName) === pascalName);
            //push path parameters that form current identity into allParams, idOpParamsFromIdentity and idOpParamsFromIdentityserializedName
            if (vp && each.expression === dotnet.Null) {
              const param = {
                name: `${$this.inputObjectParameterName}.${vp.name}`,
                value: `${$this.inputObjectParameterName}.${vp.name} ?? ${defaultOfType}`
              };
              pathParamsInIdentity.push(param);
              pathParamsInIdentitySerializedName.push(match.serializedName);
              return;
            }
            // fall back!

            this.state.debug(`Unable to match identity parameter '${each.name}' member to appropriate virtual parameter. (Guessing '${pascalCase(match.language.csharp?.name ?? '')}').`, {});
            //push path parameters that current identity does not contain into allParams and idOpParamsNotFromIdentity
            const param = {
              name: `${pascalCase(match.language.csharp?.name ?? '')}`,
              value: `${pascalCase(match.language.csharp?.name ?? '')}`
            };
            pathParamsNotInIdentity.push(param);
          } else {
            this.state.debug(`Unable to match identity parameter '${each.name}' member to appropriate virtual parameter. (Guessing '${pascalName}')`, {});
            /*
              push path parameters do not match the name in identity schema into allParams and idOpParamsNotFromIdentity
              for example, module 'Service' has only one GET API:
                /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Service/resource1/{resource1Name}/resource2/{resource2Name}/resource3/{resource3Name}
                the identity schema 'ServiceIdentity.cs' will have properties: {subscriptionId, resourceGroupName, resource1Name, resource2Name, resource3Name}
              for variant which has (identity of resource2 + resource3Name) combined as parameters, the parameter name for 'resource3Name' is called 'Name' which do not match 'resource3Name' in 'ServiceIdentity.cs'
            */
            const param = {
              name: `${pascalName}`,
              value: `${pascalName}`
            };
            pathParamsNotInIdentity.push(param);
          }
        }
      });
    }

    if ($this.isViaIdentity) {
      //when identity does not contain property: 'Id'
      const identityFromPathParams = function* () {
        yield '// try to call with PATH parameters from Input Object';
        if (idschema) {
          for (const opParam of pathParamsInIdentity) {
            if (opParam && opParam.name) {
              yield If(IsNull(opParam.name), `ThrowTerminatingError( new ${ErrorRecord}(new global::System.Exception("${$this.inputObjectParameterName} has null value for ${opParam.name}"),string.Empty, ${ErrorCategory('InvalidArgument')}, ${$this.inputObjectParameterName}) );`);
            }
          }
          const pathParameters = [...pathParamsInIdentity.map(each => toExpression(each.value)), ...pathParamsNotInIdentity.map(each => toExpression(each.value))];
          const nonPathParameters = [...headerParams.map(each => toExpression(each.value)), ...queryParams.map(each => toExpression(each.value)), ...otherParams.map(each => toExpression(each.value))];
          const parameters = bodyParameter ? [...pathParameters, ...nonPathParameters, toExpression(bodyParameter.value), ...callbackMethods, dotnet.This, pipeline] : [...pathParameters, ...nonPathParameters, ...callbackMethods, dotnet.This, pipeline];
          if (serializationMode) {
            parameters.push(serializationMode);
          }

          if (preProcess) {
            yield preProcess($this, pathParameters, [...otherParams.map(each => toExpression(each.value)), dotnet.This, pipeline], false);
          }
          yield `await this.${$this.$<Property>('Client').invokeMethod(httpOperationName, ...parameters).implementation}`;
        }
      };

      //when identity does contain property: 'Id'
      const identityParams = function* () {
        const path = apiCall.requests?.[0].protocol.http?.path;
        let pathParams = '';
        //append path parameters which are not part of current identity
        pathParamsNotInIdentity.forEach(each => {
          const serializedName = values($this.properties)
            .where(p => p.metadata.parameterDefinition)
            .first(p => p.name === each.name)?.metadata.parameterDefinition.language.csharp.serializedName;
          if (each.name && serializedName) {
            if (!pathParams) {
              pathParams += '$"';
            }
            const resourceName = getResourceNameFromPath(path, serializedName);
            if (resourceName) {
              pathParams += `/${resourceName}/{(global::System.Uri.EscapeDataString(this.${each.name}.ToString()))}`;
            }
          }
        });
        //add child resource to path for list operation
        if ($this.operation.variant.startsWith('List') && $this.operation.callGraph[0].requests?.[0].protocol.http?.method.toLowerCase() !== 'post' && pathParamsInIdentitySerializedName?.[pathParamsInIdentitySerializedName.length - 1]) {
          const childResourceName = getChildResourceNameFromPath(path, pathParamsInIdentitySerializedName?.[pathParamsInIdentitySerializedName.length - 1]);
          if (pathParams && pathParams.length > 0) {
            pathParams += `/${childResourceName}`;
          } else {
            pathParams += `"/${childResourceName}`;
          }
        }
        if (pathParams && pathParams.length > 0) {
          pathParams += '";';
          yield `this.${$this.inputObjectParameterName}.Id += ${pathParams}`;
        }
        const pathParameters = [toExpression(`${$this.inputObjectParameterName}.Id`)];
        const nonPathParameters = [...headerParams.map(each => toExpression(each.value)), ...queryParams.map(each => toExpression(each.value)), ...otherParams.map(each => toExpression(each.value))];
        const parameters = bodyParameter ? [...pathParameters, ...nonPathParameters, toExpression(bodyParameter.value), ...callbackMethods, dotnet.This, pipeline] : [...pathParameters, ...nonPathParameters, ...callbackMethods, dotnet.This, pipeline];
        if (serializationMode) {
          parameters.push(serializationMode);
        }

        if (preProcess) {
          yield preProcess($this, pathParameters, [...otherParams.map(each => toExpression(each.value)), dotnet.This, pipeline], true);
        }
        yield `await this.${$this.$<Property>('Client').invokeMethod(`${httpOperationName}ViaIdentity`, ...parameters).implementation}`;
      };

      if (idschema && values(idschema.properties).first(each => each.language.csharp?.uid === 'universal-parameter:resource identity')) {
        yield If(`${$this.inputObjectParameterName}?.Id != null`, identityParams);
        yield Else(identityFromPathParams);
      } else {
        yield identityFromPathParams;
      }
    } else {
      const pathParameters = [...pathParamsInIdentity.map(each => toExpression(each.value)), ...pathParamsNotInIdentity.map(each => toExpression(each.value))];
      const nonPathParameters = [...headerParams.map(each => toExpression(each.value)), ...queryParams.map(each => toExpression(each.value)), ...otherParams.map(each => toExpression(each.value))];
      let parameters = bodyParameter ? [...pathParameters, ...nonPathParameters, toExpression(bodyParameter.value), ...callbackMethods, dotnet.This, pipeline] : [...pathParameters, ...nonPathParameters, ...callbackMethods, dotnet.This, pipeline];
      if (serializationMode) {
        parameters.push(serializationMode);
      }
      if (operation.variant.includes('ViaJsonString') || operation.variant.includes('ViaJsonFilePath')) {
        httpOperationName = `${httpOperationName}ViaJsonString`;
        const jsonParameter = new Field('_jsonString', System.String);
        parameters = [...pathParameters, ...nonPathParameters, jsonParameter, ...callbackMethods, dotnet.This, pipeline];
      }
      if (preProcess) {
        yield preProcess($this, pathParameters, [...otherParams.map(each => toExpression(each.value)), dotnet.This, pipeline], false);
      }
      yield `await this.${$this.$<Property>('Client').invokeMethod(httpOperationName, ...parameters).implementation}`;
    }
  }

  private GetSpecifiedParameter(parameterName: string): boolean {
    return this.operation.details.csharp.virtualParameters?.body?.map(p => p.name)?.includes(parameterName) ?? false;
  }

  private ContainsIdentityTypeParameter(): boolean {
    return this.GetSpecifiedParameter('IdentityType');
  }

  private ContainsUserAssignedIdentityParameter(): boolean {
    return this.GetSpecifiedParameter('UserAssignedIdentity');
  }

  private GetUserAssignedIdentityTypeDeclaration(cmdlet: CmdletClass): string {
    const $this = cmdlet;
    const userAssignedIdentityParameter = $this.properties.filter(each => {
      for (const attribute of each.attributes) {
        for (const parameter of attribute.parameters) {
          if ('global::Microsoft.Rest.ParameterCategory.Body' === valueOf(parameter)
            && 'UserAssignedIdentity' === each.name) {
            return true;
          }
        }
      }
      return false;
    });
    return userAssignedIdentityParameter?.[0]?.type?.declaration ?? undefined;
  }

  private ManagedIdentityPreProcessForNewVerbCmdlet(cmdlet: CmdletClass, pathParams: Array<Expression>, nonPathParams: Array<Expression>, viaIdentity: boolean): Statements {
    const $this = cmdlet;
    const preProcessManagedIdentityParametersMethod = new Method('PreProcessManagedIdentityParameters', dotnet.Void, {
      access: Access.Private
    });

    const preProcessManagedIdentityType = function* () {
      yield If('this.UserAssignedIdentity?.Count > 0',
        function* () {
          yield If('"SystemAssigned".Equals(this.IdentityType, StringComparison.InvariantCultureIgnoreCase)', 'this.IdentityType = "SystemAssigned,UserAssigned";');
          yield Else('this.IdentityType = "UserAssigned";');
        });
    };

    if (!$this.hasMethodWithSameDeclaration(preProcessManagedIdentityParametersMethod)) {
      preProcessManagedIdentityParametersMethod.add(preProcessManagedIdentityType);
      $this.add(preProcessManagedIdentityParametersMethod);
    }

    return new Statements(function* () {
      yield `this.${preProcessManagedIdentityParametersMethod.name}();`;
    });
  }

  private ProcessGetResponseForManagedIdentityUpdateCmdlet(cmdlet: CmdletClass): Statements {
    const $this = cmdlet;
    const containsUserAssignedIdentity = $this.ContainsUserAssignedIdentityParameter();
    const doesSupportSystemAssignedIdentityMethod = new Method('DoesSupportSystemAssignedIdentityMethod', dotnet.Bool, {
      access: Access.Private,
      parameters: [new Parameter('identityType', dotnet.String)]
    });
    if (!$this.hasMethodWithSameDeclaration(doesSupportSystemAssignedIdentityMethod)) {
      doesSupportSystemAssignedIdentityMethod.add(Return('new System.Collections.Generic.List<string> { "SystemAssigned", "SystemAssigned,UserAssigned", "SystemAssigned, UserAssigned"}.Contains(identityType)'));
      $this.add(doesSupportSystemAssignedIdentityMethod);
    }
    if (containsUserAssignedIdentity) {
      const doesSupportUserAssignedIdentityMethod = new Method('DoesSupportUserAssignedIdentity', dotnet.Bool, {
        access: Access.Private,
        parameters: [new Parameter('identityType', dotnet.String)]
      });
      if (!$this.hasMethodWithSameDeclaration(doesSupportUserAssignedIdentityMethod)) {
        doesSupportUserAssignedIdentityMethod.add(Return('new System.Collections.Generic.List<string> { "UserAssigned", "SystemAssigned,UserAssigned", "SystemAssigned, UserAssigned"}.Contains(identityType)'));
        $this.add(doesSupportUserAssignedIdentityMethod);
      }
    }
    const preProcessManagedIdentity = function* () {
      const supportsUserAssignedIdentity = new LocalVariable('supportsUserAssignedIdentity', dotnet.Var, { initializer: `${dotnet.False}` });
      const supportsSystemAssignedIdentity = new LocalVariable('supportsSystemAssignedIdentity', dotnet.Var, { initializer: `${dotnet.False}` });
      yield supportsUserAssignedIdentity;
      yield supportsSystemAssignedIdentity;
      if (containsUserAssignedIdentity) {
        yield If(Or(
          And('(bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("UserAssignedIdentity"))',
            `((${$this.GetUserAssignedIdentityTypeDeclaration(cmdlet)})this.MyInvocation?.BoundParameters["UserAssignedIdentity"])?.Count > 0`),
          And('!(bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("UserAssignedIdentity"))',
            `DoesSupportUserAssignedIdentity(${$this.bodyParameter?.value}.IdentityType)`)), 'supportsUserAssignedIdentity = true;');
      }
      yield If(Or(
        And('(bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IdentityType"))',
          '"SystemAssigned".Equals((string)this.MyInvocation?.BoundParameters["IdentityType"])'),
        And(And('(bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IdentityType"))',
          '"None".Equals((string)this.MyInvocation?.BoundParameters["IdentityType"])'),
          `DoesSupportSystemAssignedIdentityMethod(${$this.bodyParameter?.value}.IdentityType)`)), 'supportsSystemAssignedIdentity = true;');
      yield 'this.MyInvocation?.BoundParameters.Remove("IdentityType");';
      yield If(And('supportsUserAssignedIdentity', 'supportsSystemAssignedIdentity'), 'this.MyInvocation?.BoundParameters.Add("IdentityType", "SystemAssigned,UserAssigned");');
      yield ElseIf(And('supportsUserAssignedIdentity', '!supportsSystemAssignedIdentity'), 'this.MyInvocation?.BoundParameters.Add("IdentityType", "UserAssigned");');
      yield ElseIf(And('!supportsUserAssignedIdentity', 'supportsSystemAssignedIdentity'),
        function* () {
          yield 'this.MyInvocation?.BoundParameters.Add("IdentityType", "SystemAssigned");';
          if (containsUserAssignedIdentity) {
            yield 'this.MyInvocation?.BoundParameters.Remove("UserAssignedIdentity");';
            yield 'this.MyInvocation?.BoundParameters.Add("UserAssignedIdentity", null);';
          }
        });
      yield Else(function* () {
        yield 'this.MyInvocation?.BoundParameters.Add("IdentityType", "None");';
        if (containsUserAssignedIdentity) {
          yield 'this.MyInvocation?.BoundParameters.Remove("UserAssignedIdentity"); ';
          yield 'this.MyInvocation?.BoundParameters.Add("UserAssignedIdentity", null);';
        }
      });
    };

    const preProcessManagedIdentityMethod = new Method('PreProcessManagedIdentityParametersWithGetResult', dotnet.Void, {
      access: Access.Private
    });

    if (!$this.hasMethodWithSameDeclaration(preProcessManagedIdentityMethod)) {
      preProcessManagedIdentityMethod.add(preProcessManagedIdentity);
      $this.add(preProcessManagedIdentityMethod);
    }
    return new Statements(function* () {
      yield `this.${preProcessManagedIdentityMethod.name}();`;
    });
  }

  private ManagedIdentityUpdateCmdletPreProcess(cmdlet: CmdletClass, pathParams: Array<Expression>, nonPathParams: Array<Expression>, viaIdentity: boolean): Statements {
    return cmdlet.GetPutPreProcess(cmdlet, pathParams, nonPathParams, viaIdentity, cmdlet.ProcessGetResponseForManagedIdentityUpdateCmdlet);
  }

  private GetPutPreProcess(cmdlet: CmdletClass, pathParams: Array<Expression>, nonPathParams: Array<Expression>, viaIdentity: boolean, processGetResponse: ProcessGetResponse = undefined): Statements {
    const $this = cmdlet;
    const updateBodyMethod = new Method(`Update${$this.bodyParameter?.value}`, dotnet.Void, {
      access: Access.Private
    });
    const httpOperationName = `${$this.operation.callGraph[0].language.csharp?.name}${viaIdentity ? 'ViaIdentity' : ''}WithResult`;
    if (!$this.hasMethodWithSameDeclaration(updateBodyMethod)) {
      updateBodyMethod.add(function* () {
        const bodyParameters = $this.properties.filter(each => {
          for (const attribute of each.attributes) {
            for (const parameter of attribute.parameters) {
              if ('global::Microsoft.Rest.ParameterCategory.Body' === valueOf(parameter)) {
                return true;
              }
            }
          }
          return false;
        });
        for (const param of bodyParameters) {
          yield If(`(bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("${param.name}"))`, `this.${param.name} = (${param.type.declaration})(this.MyInvocation?.BoundParameters["${param.name}"]);`);
        }
      });
      $this.add(updateBodyMethod);
    }

    const getPut = function* () {
      yield `${$this.bodyParameter?.value} = await this.${$this.$<Property>('Client').invokeMethod(httpOperationName, ...[...pathParams, ...nonPathParams]).implementation} `;
      // PreProcess body parameter
      if (processGetResponse) {
        yield processGetResponse($this);
      }
      yield `this.${updateBodyMethod.name}();`;
      /** Instance:
       * _requestBodyParametersBody = await this.Client.GrafanaGetWithResult(SubscriptionId, ResourceGroupName, Name, this, Pipeline);
       * this.Update_requestBodyParametersBody();
       *  */

    };
    return new Statements(getPut);
  }

  private NewImplementResponseMethod() {
    const $this = this;
    const apiCall = $this.apiCall;
    const operationParameters: Array<operationParameter> = $this.operationParameters;
    const callbackMethods = $this.callbackMethods;
    const pipeline = $this.$<Property>('Pipeline');

    // make callback methods
    for (const each of values($this.responses)) {
      const parameters = new Array<Parameter>();
      const isBinary = (<BinaryResponse>each).binary;
      parameters.push(new Parameter('responseMessage', System.Net.Http.HttpResponseMessage, { description: `the raw response message as an ${System.Net.Http.HttpResponseMessage}.` }));

      if (each.language.csharp?.responseType) {
        parameters.push(new Parameter('response', System.Threading.Tasks.Task({ declaration: each.language.csharp?.responseType }), {
          description: `the body result as a <see cref="${each.language.csharp?.responseType.replace(/\[|\]|\?/g, '')}">${each.language.csharp?.responseType}</see> from the remote call`
        }));
      }
      if (each.language.csharp?.headerType) {
        parameters.push(new Parameter('headers', System.Threading.Tasks.Task({ declaration: each.language.csharp.headerType }), { description: `the header result as a <see cref="${each.language.csharp.headerType}" /> from the remote call` }));
      }

      if (isBinary) {
        parameters.push(new Parameter('response', System.Threading.Tasks.Task({ declaration: 'global::System.IO.Stream' }), { description: 'the body result as a <see cref="global::System.IO.Stream" /> from the remote call' }));
      }

      const override = `override${pascalCase(each.language.csharp?.name || '')}`;
      const returnNow = new Parameter('returnNow', System.Threading.Tasks.Task(dotnet.Bool), { modifier: ParameterModifier.Ref, description: `/// Determines if the rest of the ${each.language.csharp?.name} method should be processed, or if the method should return immediately (set to true to skip further processing )` });
      const overrideResponseMethod = new PartialMethod(override, dotnet.Void, {
        parameters: [...parameters, returnNow],
        description: `<c>${override}</c> will be called before the regular ${each.language.csharp?.name} has been processed, allowing customization of what happens on that response. Implement this method in a partial class to enable this behavior`,
        returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
      });
      $this.add(overrideResponseMethod);

      const responseMethod = new Method(`${each.language.csharp?.name}`, System.Threading.Tasks.Task(), {
        access: Access.Private,
        parameters,
        async: Modifier.Async,
        description: each.language.csharp?.description,
        returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when handling of the method is completed.`
      });
      responseMethod.push(Using('NoSynchronizationContext', ''));


      responseMethod.add(function* () {
        const skip = Local('_returnNow', `${System.Threading.Tasks.Task(dotnet.Bool).declaration}.FromResult(${dotnet.False})`);
        yield skip.declarationStatement;
        yield `${overrideResponseMethod.invoke(...parameters, `ref ${skip.value}`)};`;
        yield `// if ${override} has returned true, then return right away.`;
        yield If(And(IsNotNull(skip), `await ${skip}`), Return());

        if (each.language.csharp?.isErrorResponse) {
          // this should write an error to the error channel.
          yield `// Error Response : ${each.protocol.http?.statusCodes[0]}`;


          const unexpected = function* () {
            yield '// Unrecognized Response. Create an error record based on what we have.';
            const ex = (each.language.csharp?.responseType) ?
              Local('ex', `new ${ClientRuntime.name}.RestException<${each.language.csharp.responseType}>(responseMessage, await response)`) :
              Local('ex', `new ${ClientRuntime.name}.RestException(responseMessage)`);

            yield ex.declarationStatement;

            yield `WriteError( new global::System.Management.Automation.ErrorRecord(${ex.value}, ${ex.value}.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ${operationParameters.filter(e => valueOf(e.expression) !== 'null').map(each => `${each.name}=${each.expression}`).join(', ')} })
{
  ErrorDetails = new global::System.Management.Automation.ErrorDetails(${ex.value}.Message) { RecommendedAction = ${ex.value}.Action }
});`;
          };
          if ((<SchemaResponse>each).schema !== undefined) {
            // the schema should be the error information.
            // this supports both { error { message, code} } and { message, code}

            let props = NewGetAllPublicVirtualProperties((<SchemaResponse>each).schema.language.csharp?.virtualProperties);
            const errorProperty = values(props).first(p => p.property.serializedName === 'error');
            let ep = '';
            if (errorProperty) {
              props = NewGetAllPublicVirtualProperties(errorProperty.property.schema.language.csharp?.virtualProperties);
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

        yield `// ${each.language.csharp?.name} - response for ${each.protocol.http?.statusCodes[0]} / ${values(each.protocol.http?.mediaTypes).join('/')}`;

        if ('schema' in each) {
          const schema = (<SchemaResponse>each).schema;
          const props = NewGetAllPublicVirtualProperties(schema.language.csharp?.virtualProperties);
          const rType = $this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<NewSchema>schema, true, $this.state);

          const result = new LocalVariable('result', dotnet.Var, { initializer: new LiteralExpression('(await response)') });
          yield `// (await response) // should be ${rType.declaration}`;
          yield result.declarationStatement;

          if (apiCall.language.csharp?.pageable) {
            const pageable = apiCall.language.csharp.pageable;
            if ($this.clientsidePagination) {
              yield '// clientside pagination enabled';
            }
            yield '// response should be returning an array of some kind. +Pageable';
            yield `// ${pageable.responseType} / ${pageable.itemName || '<none>'} / ${pageable.nextLinkName || '<none>'}`;
            switch (pageable.responseType) {
              // the result is (or works like a x-ms-pageable)
              case 'pageable':
              case 'nested-array': {
                const valueProperty = (<ObjectSchema>schema).properties?.find(p => p.serializedName === pageable.itemName);
                const nextLinkProperty = (<ObjectSchema>schema)?.properties?.find(p => p.serializedName === pageable.nextLinkName);
                if (valueProperty && nextLinkProperty) {
                  // it's pageable!
                  // write out the current contents
                  const vp = NewGetVirtualPropertyFromPropertyName(schema.language.csharp?.virtualProperties, valueProperty.serializedName);
                  if (vp) {
                    if ($this.clientsidePagination) {
                      yield (If('(ulong)result.Value.Count <= this.PagingParameters.Skip', function* () {
                        yield ('this.PagingParameters.Skip = this.PagingParameters.Skip - (ulong)result.Value.Count;');
                      }));
                      yield Else(function* () {
                        yield ('ulong toRead = Math.Min(this.PagingParameters.First, (ulong)result.Value.Count - this.PagingParameters.Skip);');
                        yield ('var requiredResult = result.Value.GetRange((int)this.PagingParameters.Skip, (int)toRead);');
                        yield $this.WriteObjectWithViewControl('requiredResult', true);
                        yield ('this.PagingParameters.Skip = 0;');
                        yield ('this.PagingParameters.First = this.PagingParameters.First <= toRead ? 0 : this.PagingParameters.First - toRead;');
                      });
                    } else {
                      yield $this.WriteObjectWithViewControl(`${result.value}.${vp.name}`, true);
                    }
                  }
                  const nl = NewGetVirtualPropertyFromPropertyName(schema.language.csharp?.virtualProperties, nextLinkProperty.serializedName);
                  if (nl) {
                    $this.add(new Field('_isFirst', dotnet.Bool, {
                      access: Access.Private,
                      initialValue: new LiteralExpression('true'),
                      description: 'A flag to tell whether it is the first onOK call.'
                    }));
                    $this.add(new Field('_nextLink', dotnet.String, {
                      access: Access.Private,
                      description: 'Link to retrieve next page.'
                    }));
                    const nextLinkName = `${result.value}.${nl.name}`;
                    yield `_nextLink = ${nextLinkName};`;
                    const nextLinkCondition = $this.clientsidePagination ? '!String.IsNullOrEmpty(_nextLink) && this.PagingParameters.First > 0' : '!String.IsNullOrEmpty(_nextLink)';
                    yield (If('_isFirst', function* () {
                      yield '_isFirst = false;';
                      yield (While(nextLinkCondition,
                        If('responseMessage.RequestMessage is System.Net.Http.HttpRequestMessage requestMessage ', function* () {
                          yield `requestMessage = requestMessage.Clone(new global::System.Uri( _nextLink ),${ClientRuntime.Method.Get} );`;
                          yield $this.eventListener.signal(Events.FollowingNextLink);
                          yield `await this.${$this.$<Property>('Client').invokeMethod(`${apiCall.language.csharp?.name}_Call`, ...[toExpression('requestMessage'), ...callbackMethods, dotnet.This, pipeline]).implementation}`;
                        })
                      ));
                    }));
                  }
                  return;
                } else if (valueProperty) {
                  // it's just a nested array
                  const p = getVirtualPropertyFromPropertyName(schema.language.csharp?.virtualProperties, valueProperty.serializedName);
                  if (p) {
                    yield $this.WriteObjectWithViewControl(`${result.value}.${p.name}`, true);
                  }
                  return;
                }
              }
                break;

              // it's just an array,
              case 'array':
                // just write-object(enumerate) with the output
                yield $this.WriteObjectWithViewControl(result.value, true);
                return;
            }
            // ok, let's see if the response type
          }

          // we expect to get back some data from this call.
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
              const stream = Local('stream', result.value);
              yield Using(stream.declarationExpression, function* () {
                const fileStream = Local('fileStream', `global::System.IO.File.OpenWrite(${paths.value}[0])`);
                yield Using(fileStream.declarationExpression, `await ${stream.value}.CopyToAsync(${fileStream.value});`);
              });
            } else {
              // assuming byte array output (via result)
              yield `global::System.IO.File.WriteAllBytes(${paths.value}[0],${result.value});`;
            }

            yield If('true == MyInvocation?.BoundParameters?.ContainsKey("PassThru")', function* () {
              // no return type. Let's just return ... true?
              yield 'WriteObject(true);';
            });
            return;
          }

          //  let's just return the result object (or unwrapped result object)
          yield $this.WriteObjectWithViewControl(result.value);
          return;
        }

        // in m4, there will be no schema deinfed for the binary response, instead, we will have a field called binary with value true.
        if ('binary' in each) {
          yield '// (await response) // should be global::System.IO.Stream';
          if ($this.hasStreamOutput && $this.outFileParameter) {
            const outfile = $this.outFileParameter;
            const provider = Local('provider');
            provider.initializer = undefined;
            const paths = Local('paths', 'new global::System.Collections.ObjectModel.Collection<global::System.String>()');
            yield paths.declarationStatement;
            yield Try(function* () {
              yield `${paths.value} = this.SessionState.Path.GetResolvedProviderPathFromPSPath(${outfile.value}, out ${provider.declarationExpression});`;
              yield If(`${provider.value}.Name != "FileSystem" || ${paths.value}.Count == 0`, `ThrowTerminatingError(new System.Management.Automation.ErrorRecord(new global::System.Exception("Invalid output path."), string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ${outfile.value}));`);
              yield If(`${paths.value}.Count > 1`, `ThrowTerminatingError(new System.Management.Automation.ErrorRecord(new global::System.Exception("Multiple output paths not allowed."), string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, ${outfile.value}));`);
            });
            const notfound = new Parameter('', { declaration: 'global::System.Management.Automation.ItemNotFoundException' });
            yield Catch(notfound, function* () {
              yield '// If the file does not exist, we will try to create it';
              yield `${paths.value}.Add(${outfile.value});`;
            });

            // this is a stream output. write to outfile
            const stream = Local('stream', 'await response');
            yield Using(stream.declarationExpression, function* () {
              const fileStream = Local('fileStream', `global::System.IO.File.OpenWrite(${paths.value}[0])`);
              yield Using(fileStream.declarationExpression, `await ${stream.value}.CopyToAsync(${fileStream.value});`);
            });


            yield If('true == MyInvocation?.BoundParameters?.ContainsKey("PassThru")', function* () {
              // no return type. Let's just return ... true?
              yield 'WriteObject(true);';
            });
            return;
          }
        }
        yield If('true == MyInvocation?.BoundParameters?.ContainsKey("PassThru")', function* () {
          // no return type. Let's just return ... true?
          yield 'WriteObject(true);';
        });
      });
      $this.add(responseMethod);
    }
  }

  private NewImplementSerialization(operation: CommandOperation) {
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
    this.add(new Constructor(this, { description: `Initializes a new instance of the <see cref="${this.name}" /> cmdlet class.` }));
  }

  private implementIContext() {
    const extensibleParameters = this.add(new Field('_extensibleParameters', System.Collections.Generic.Dictionary(System.String, System.Object), {
      access: Access.Private,
      initialValue: new LiteralExpression('new System.Collections.Generic.Dictionary<string, object>()'),
      description: 'A dictionary to carry over additional data for pipeline.'
    }));
    const extensibleParametersProp = new Property('ExtensibleParameters', System.Collections.Generic.IDictionary(System.String, System.Object), { description: 'Accessor for extensibleParameters.' });
    extensibleParametersProp.get = toExpression(`${extensibleParameters.value} `);
    this.add(extensibleParametersProp);
  }
  private implementIEventListener() {
    const $this = this;
    const cts = this.add(new Field('_cancellationTokenSource', System.Threading.CancellationTokenSource, {
      access: Access.Private,
      initialValue: new LiteralExpression(`new ${System.Threading.CancellationTokenSource.declaration}()`),
      description: `The <see cref="${System.Threading.CancellationTokenSource}" /> for this operation.`
    }));
    const cancellationTokenSource = new Property('CancellationTokenSource', System.Threading.CancellationTokenSource, { description: 'Accessor for cancellationTokenSource.' });
    cancellationTokenSource.get = toExpression(`${cts.value} `);
    cancellationTokenSource.set = new Statements(cts.assign('value'));
    this.add(cancellationTokenSource);
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Token`, System.Threading.CancellationToken, new LiteralExpression(`${cts.value}.Token`), { getAccess: Access.Default, setAccess: Access.Default, description: `<see cref="${ClientRuntime}.IEventListener" /> cancellation token.` }));
    this.cancellationToken = toExpression(`((${ClientRuntime.IEventListener})this).Token`);
    this.add(new LambdaProperty(`${ClientRuntime.IEventListener}.Cancel`, System.Action(), new LiteralExpression(`${cts.value}.Cancel`), { getAccess: Access.Default, setAccess: Access.Default, description: `<see cref="${ClientRuntime}.IEventListener" /> cancellation delegate. Stops the cmdlet when called.` }));

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
            yield 'WriteInformation(data.Message, new string[]{});';
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
        TerminalCase(Events.Progress.value, function* () {
          yield 'var data = messageData();';
          yield 'int progress = (int)data.Value;';
          yield 'string activityMessage, statusDescription;';
          yield 'global::System.Management.Automation.ProgressRecordType recordType;';

          yield 'if (progress < 100)';
          yield '{';
          yield '    activityMessage = "In progress";';
          yield '    statusDescription = "Checking operation status";';
          yield '    recordType = System.Management.Automation.ProgressRecordType.Processing;';
          yield '}';
          yield 'else';
          yield '{';
          yield '    activityMessage = "Completed";';
          yield '    statusDescription = "Completed";';
          yield '    recordType = System.Management.Automation.ProgressRecordType.Completed;';
          yield '}';

          // hardcode id = 1 because there is no need for nested progress bar
          yield 'WriteProgress(new global::System.Management.Automation.ProgressRecord(1, activityMessage, statusDescription)';
          yield '{';
          yield '    PercentComplete = progress,';
          yield 'RecordType = recordType';
          yield '});';
          yield Return();
        }),
      ]);

      if ($this.operation.asjob) {
        // if we support -AsJob, we support -NoWait
        sw.add(Case(Events.DelayBeforePolling.value, function* () {
          yield 'var data = messageData();';
          yield If('true == MyInvocation?.BoundParameters?.ContainsKey("NoWait")', function* () {
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
          yield Else(function* () {
            yield 'if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)';
            yield '{';
            yield '    int delay = (int)(response.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);';
            yield '    WriteDebug($"Delaying {delay} seconds before polling.");';
            yield '    for (var now = 0; now < delay; ++now)';
            yield '    {';
            // hardcode id = 1 because there is no need for nested progress bar
            yield '        WriteProgress(new global::System.Management.Automation.ProgressRecord(1, "In progress", "Checking operation status")';
            yield '        {';
            yield '            PercentComplete = now * 100 / delay';
            yield '        });';
            yield `        await global::System.Threading.Tasks.Task.Delay(1000, ${token.use});`;
            yield '    }';
            yield '}';
          });
        }));
      }

      // the whole switch statement
      yield sw;

      if ($this.state.project.azure) {
        // in azure mode, we signal the AzAccount module with every event that makes it here.
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i, t, m) => ((${ClientRuntime.IEventListener})this).Signal(i, t, () => ${ClientRuntime.EventDataConverter}.ConvertFrom(m()) as ${ClientRuntime.EventData}), ${$this.invocationInfo.value}, this.ParameterSetName, ${$this.correlationId.value}, ${$this.processRecordId.value}, null );`;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      } else {
        // In Non-Azure Modes, emit the Signal method without coorelation and processrecordid
        yield `await ${$this.state.project.serviceNamespace.moduleClass.declaration}.Instance.Signal(${id.value}, ${token.value}, ${messageData.value}, (i, t, m) => ((${ClientRuntime.IEventListener})this).Signal(i, t, () => ${ClientRuntime.EventDataConverter}.ConvertFrom(m()) as ${ClientRuntime.EventData}), ${$this.invocationInfo.value}, this.ParameterSetName, null ); `;
        yield If(`${token.value}.IsCancellationRequested`, Return());
      }
      yield `WriteDebug($"{id}: {(messageData().Message ?? ${System.String.Empty})}");`;
      // any handling of the signal on our side...
    });
  }

  private NewAddPowershellParameters(operation: CommandOperation) {
    const vps = operation.details.csharp.virtualParameters || {
      body: [],
      operation: [],
    };

    for (const parameter of values(operation.parameters)) {
      // these are the parameters that this command expects
      parameter.schema;
      const td = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(<NewSchema>parameter.schema, true, this.state);

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
        const expandedBodyParameter = this.add(new Field('_' + camelCase(parameter.details.csharp.name), td, {
          description: parameter.details.csharp.description,
          initialValue: (parameter.schema.type === SchemaType.Array) ? dotnet.Null : `new ${parameter.schema.language.csharp?.fullname}()`,
          access: Access.Private
        }));
        this.thingsToSerialize.push(expandedBodyParameter);

        for (const vParam of vps.body) {
          const vSchema = vParam.schema;
          vParam.origin;
          const propertyType = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(vSchema, true, this.state);

          // we need to know if the actual underlying property is actually nullable.
          const nullable = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(vSchema, !!(<NewVirtualProperty>vParam.origin).required, this.state).isNullable;
          let cmdletParameter: Property;
          if (propertyType.schema.type !== SchemaType.Array) {
            // if (vParam.name === 'IdentityType') {
            //   cmdletParameter = new Property('EnableSystemAssignedIdentity', SwitchParameter, {
            //     set: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name} = value`),
            //     new: PropertiesRequiringNew.has(vParam.name) ? Modifier.New : Modifier.None
            //   });
            // }
            cmdletParameter = new Property(vParam.name, propertyType, {
              get: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name}${!nullable ? '' : ` ?? ${propertyType.defaultOfType}`}`), // /* ${inspect(vParam.origin)} */
              // get: toExpression(`null == ${expandedBodyParameter.value}.${vParam.origin.name} ? ${propertyType.defaultOfType} : (${propertyType.declaration}) ${expandedBodyParameter.value}.${vParam.origin.name}`),
              set: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name} = value`),
              new: PropertiesRequiringNew.has(vParam.name) ? Modifier.New : Modifier.None
            });
          } else {
            const fixedArrayPropertyType = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(vSchema, true, this.state, true);
            cmdletParameter = new Property(vParam.name, fixedArrayPropertyType, {
              get: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name}?.ToArray()${` ?? ${fixedArrayPropertyType.defaultOfType}`}`),
              set: toExpression(`${expandedBodyParameter.value}.${getVirtualPropertyName((<any>vParam.origin)) || vParam.origin.name} = (value != null ? new ${propertyType.declaration}(value) : null)`),
              new: PropertiesRequiringNew.has(vParam.name) ? Modifier.New : Modifier.None
            });
          }
          if (vParam.schema.language.csharp?.byReference) {
            // this parameter's schema is marked as 'by-reference' which means we should
            // tag it with an ExportAs attribute for the I*Reference type.
            cmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${vParam.schema.language.csharp.referenceInterface})`] }));
          }

          if (vParam.schema.type === SchemaType.Array) {
            //skip-for-time-being
            // if ((<ArraySchema>vParam.schema). && vParam.schema.items.details.csharp.byReference) {
            //   cmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${vParam.schema.items.details.csharp.referenceInterface}[])`] }));
            // }
            cmdletParameter.add(new Attribute(AllowEmptyCollectionAttribute));
          }
          const dictSchema = vSchema.type === SchemaType.Dictionary ? vSchema :
            vSchema.type === SchemaType.Object ? (<ObjectSchema>vSchema).parents?.immediate?.find((s) => s.type === SchemaType.Dictionary) :
              undefined;
          if (dictSchema) {
            // we have to figure out if this is a standalone dictionary or a hybrid object/dictionary.
            // if it's a hybrid, we have to create another parameter like -<XXX>AdditionalProperties and have that dump the contents into the dictionary
            // if it's a standalone dictionary, we can just use hashtable instead
            if (length((<ObjectSchema>vSchema).properties) === 0) {
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
            if (length(vParam.alias) > 0) {
              inputFileParameter.add(new Attribute(Alias, { parameters: vParam.alias.map(x => '"' + x + '"') }));
            }
            $this.add(inputFileParameter);
          } else {
            cmdletParameter.add(new Attribute(ParameterAttribute, { parameters: [new LiteralExpression(`Mandatory = ${vParam.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(desc || '.')}"`)] }));
            cmdletParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Body`] }));
            NewAddInfoAttribute(cmdletParameter, propertyType, !!vParam.required, false, desc, (<NewVirtualProperty>vParam.origin).property.serializedName);
            NewAddCompleterInfo(cmdletParameter, vParam);
            addParameterBreakingChange(cmdletParameter, vParam);
            addParameterPreviewMessage(cmdletParameter, vParam);
            addDefaultInfo(cmdletParameter, vParam);
            this.addDoNotExport(cmdletParameter, vParam);
          }

          const addArgumentCompleter = isEnumImplementation(vParam.schema) || propertyType instanceof ArrayOf && isEnumImplementation(propertyType.elementType.schema);
          if (addArgumentCompleter) {
            addPSArgumentCompleterAttribute(cmdletParameter, vParam.schema);
          }

          // add aliases if there is any
          if (length(vParam.alias) > 0) {
            cmdletParameter.add(new Attribute(Alias, { parameters: vParam.alias.map(x => '"' + x + '"') }));
          }

          this.add(cmdletParameter);
        }
        const paramDictSchema = parameter.schema.type === SchemaType.Dictionary ? parameter.schema :
          parameter.schema.type === SchemaType.Object ? (<ObjectSchema>parameter.schema).parents?.immediate?.find((s) => s.type === SchemaType.Dictionary) :
            undefined;
        if (paramDictSchema) {
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
              declaration: parameter.schema.language.csharp?.fullname
            },
            valueType: (<DictionarySchema>paramDictSchema).elementType.type === SchemaType.Any ? System.Object :
              this.state.project.schemaDefinitionResolver.resolveTypeDeclaration((<DictionarySchema>paramDictSchema).elementType, true, this.state)
          };
        }

        this.bodyParameter = expandedBodyParameter;
        continue;
      }
    }

    if (this.isViaIdentity) {
      const viaIdentityRegex = /ViaIdentity\d?/g;
      this.inputObjectParameterName = `${this.name.split(viaIdentityRegex)[1].split('Expanded')[0]}InputObject`;
      // add in the pipeline parameter for the identity
      const idschema = values(this.state.project.model.schemas.objects).first(each => each.language.default.uid === 'universal-parameter-type');
      const idtd = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(idschema, true, this.state);
      const idParam = this.add(new BackedProperty(this.inputObjectParameterName, idtd, {
        description: 'Identity Parameter'
      }));
      const parameters = [new LiteralExpression('Mandatory = true'), new LiteralExpression('HelpMessage = "Identity Parameter"'), new LiteralExpression('ValueFromPipeline = true')];
      idParam.add(new Attribute(ParameterAttribute, { parameters }));
      idParam.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Path`] }));
    }
    for (const vParam of values(vps.operation)) {
      if (vParam.name === 'Host') {
        // skip 'Host'
        continue;
      }
      let regularCmdletParameter: BackedProperty;
      let origin = null;
      let propertyType = null;
      if (vParam.type) {
        // Handle parameters added through directives
        regularCmdletParameter = this.add(new BackedProperty(vParam.name, new ClassType('', vParam.type), {
          description: vParam.description
        }));
      } else {
        const vSchema = vParam.schema;
        propertyType = this.state.project.schemaDefinitionResolver.resolveTypeDeclaration(vSchema, true, this.state);


        origin = <NewIParameter>vParam.origin;

        regularCmdletParameter = (this.state.project.azure && vParam.name === 'SubscriptionId' && operation.details.csharp.verb.toLowerCase() === 'get') ?

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

        const dictSchema = vSchema.type === SchemaType.Dictionary ? vSchema :
          vSchema.type === SchemaType.Object ? (<ObjectSchema>vSchema).parents?.immediate?.find((s) => s.type === SchemaType.Dictionary) :
            undefined;
        if (dictSchema) {
          // we have to figure out if this is a standalone dictionary or a hybrid object/dictionary.
          // if it's a hybrid, we have to create another parameter like -<XXX>AdditionalProperties and have that dump the contents into the dictionary
          // if it's a standalone dictionary, we can just use hashtable instead
          if (length((<ObjectSchema>vSchema).properties) === 0) {
            // it's a pure dictionary
            // change the property type to hashtable.
            // add an attribute to change the exported type.
            regularCmdletParameter.add(new Attribute(ExportAsAttribute, { parameters: [`typeof(${System.Collections.Hashtable})`] }));
          } else {
            // it's a hybrid. We need to add an additional property that puts its items into the target container

          }

        }
      }
      this.thingsToSerialize.push(regularCmdletParameter);

      const parameters = [new LiteralExpression(`Mandatory = ${vParam.required ? 'true' : 'false'}`), new LiteralExpression(`HelpMessage = "${escapeString(vParam.description) || '.'}"`)];
      if (!!origin && origin.details.csharp.isBodyParameter) {
        parameters.push(new LiteralExpression('ValueFromPipeline = true'));
        this.bodyParameter = regularCmdletParameter;
      }
      regularCmdletParameter.add(new Attribute(ParameterAttribute, { parameters }));
      if (!vParam.type && vParam.schema.type === SchemaType.Array) {
        regularCmdletParameter.add(new Attribute(AllowEmptyCollectionAttribute));
      }
      if (!!origin && !!propertyType) {
        NewAddInfoAttribute(regularCmdletParameter, propertyType, vParam.required ?? false, false, vParam.description, origin.name);
      }
      NewAddCompleterInfo(regularCmdletParameter, vParam);
      addParameterBreakingChange(regularCmdletParameter, vParam);
      addParameterPreviewMessage(regularCmdletParameter, vParam);
      addDefaultInfo(regularCmdletParameter, vParam);
      this.addDoNotExport(regularCmdletParameter, vParam);

      // add aliases if there is any
      if (length(vParam.alias) > 0) {
        regularCmdletParameter.add(new Attribute(Alias, { parameters: vParam.alias.map(x => '"' + x + '"') }));
      }

      const httpParam = origin ? origin.details.csharp.httpParameter : null;
      //const uid = httpParam ? httpParam.details.csharp.uid : 'no-parameter';

      if (httpParam) {
        // xichen: Is it safe to compare by csharp serializedName? Because we no longer have uid
        const cat = this.apiCall.parameters?.find((param) => !param.language.csharp?.constantValue && param.language.csharp?.serializedName === httpParam.language.csharp?.serializedName);

        if (cat) {
          regularCmdletParameter.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.${pascalCase((cat.protocol.http?.in))}`] }));
        }
      } else {
        const isBodyParameter = origin ? origin.details.csharp.isBodyParameter : false;
        if (isBodyParameter) {
          regularCmdletParameter.add(
            new Attribute(CategoryAttribute, {
              parameters: [`${ParameterCategory}.Body`],
            })
          );
        }
      }

      const addArgumentCompleter = isEnumImplementation(vParam.schema) || propertyType instanceof ArrayOf && isEnumImplementation(propertyType.elementType.schema);
      if (addArgumentCompleter) {
        addPSArgumentCompleterAttribute(regularCmdletParameter, vParam.schema);
      }

    }
    const ifmatch = this.properties.find((v) => v.name.toLowerCase() === 'ifmatch');
    if (ifmatch) {
      //no sure why there is an empty block
    }

  }

  /**
   * Add `DoNotExportAttribute` to parameters that should be hidden.
   * @param cmdletParameter parameter in the variant.
   * @param vParam parameter in the code model.
   * @see DoNotExportAttribute
   */
  private addDoNotExport(cmdletParameter: Property, vParam: NewVirtualParameter) {
    if (vParam.hidden) {
      this.state.message({
        Channel: Channel.Debug,
        Text: `[DIRECTIVE] Applied 'hide' directive to parameter ${cmdletParameter.name}. Added attribute ${DoNotExportAttribute.declaration} to parameter.`,
      });
      cmdletParameter.add(new Attribute(DoNotExportAttribute));
    }
  }

  private NewAddClassAttributes(operation: CommandOperation, variantName: string) {
    const cmdletAttribParams: Array<ExpressionOrLiteral> = [
      category[operation.details.csharp.verb] ? verbEnum(category[operation.details.csharp.verb], operation.details.csharp.verb) : `"${operation.details.csharp.verb}"`,
      new StringExpression(variantName)
    ];

    if (isWritableCmdlet(operation) && !operation.details.csharp.supportShouldProcess) {
      cmdletAttribParams.push('SupportsShouldProcess = true');
    }

    if (this.clientsidePagination) {
      cmdletAttribParams.push('SupportsPaging = true');
    }

    if (operation.details.csharp.hidden) {
      this.add(new Attribute(InternalExportAttribute));
      const noun = `${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}`;
      const cmdletName = `${operation.details.csharp.verb}-${noun}${operation.details.csharp.name ? `_${operation.details.csharp.name}` : ''}`;
      this.state.message({ Channel: Channel.Debug, Text: `[DIRECTIVE] Applied 'hide' directive to ${cmdletName}. Added attribute ${InternalExportAttribute.declaration} to cmdlet.` });
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
      const pageableInfo = httpOperation.language.csharp?.pageable;
      const v = httpOperation.responses && httpOperation.responses.length > 0 && httpOperation.responses[0] instanceof SchemaResponse;
      // Add this for binary response in m4
      for (const binary of values(httpOperation.responses).selectNonNullable(each => (<BinaryResponse>each).binary)) {
        if (binary) {
          // if this is a stream, skip the output type.
          this.hasStreamOutput = true;
          shouldAddPassThru = true;
          outputTypes.add(`typeof(${dotnet.Bool})`);
        }
      }
      for (const schema of values(httpOperation.responses).selectNonNullable(each => (<SchemaResponse>each).schema)) {

        const props = NewGetAllProperties(schema);

        // does the target type just wrap a single output?
        const resultSchema = <NewSchema>schema;

        // make sure return type for boolean stays boolean!
        if (resultSchema.type === SchemaType.Boolean ||
          (resultSchema.type === SchemaType.Choice && (<any>resultSchema).choiceType.type === SchemaType.Boolean && (<ChoiceSchema>resultSchema).choices.length === 1) ||
          (resultSchema.type === SchemaType.SealedChoice && (<any>resultSchema).choiceType.type === SchemaType.Boolean && (<SealedChoiceSchema>resultSchema).choices.length === 1)) {
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
              if (typeDeclaration === undefined || (<ObjectSchema>typeDeclaration.schema).properties?.find(p => p.serializedName === pageableInfo.itemName) === undefined) {
                //skip-for-time-being, since operationId does not support in m4 any more
                //throw new Error(`\n\nOn operation:\n  '${httpOperation.operationId}' at '${httpOperation.path}'\n  -- you have used 'x-ms-pageable' and there is no property name '${pageableInfo.itemName}' that is an array.\n\n`);
                throw new Error('An error needs to be more specific');
              }
              const nestedSchema = (<ObjectSchema>typeDeclaration.schema).properties?.find(p => p.serializedName === pageableInfo.itemName)?.schema;
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

    // if any response does not return,
    // the cmdlet should have a PassThru parameter
    shouldAddPassThru = shouldAddPassThru || values(operation.callGraph)
      .selectMany(httpOperation => values((httpOperation.responses || []).concat(httpOperation.exceptions || [])))
      //.selectMany(responsesItem => responsesItem.value)
      .any(value => (<SchemaResponse>value).schema === undefined);
    if (outputTypes.size === 0) {
      outputTypes.add(`typeof(${dotnet.Bool})`);
    }

    //add breaking change attributes for cmdlet, variant, output type
    if (operation.details.csharp.breakingChange) {
      const breakingChange = operation.details.csharp.breakingChange;
      if (breakingChange.cmdlet) {
        const parameters = [];
        if (!breakingChange.cmdlet.deprecateByVersion || !breakingChange.cmdlet.deprecateByAzVersion) {
          throw new Error('Cmdlet breaking change requires both \'deprecateByVersion\' and \'deprecateByAzVersion\', please refer to https://github.com/Azure/azure-powershell/blob/main/documentation/development-docs/breakingchange-for-autogen-module.md for more details.');
        }
        parameters.push(`"${breakingChange.cmdlet.deprecateByAzVersion}"`);
        parameters.push(`"${breakingChange.cmdlet.deprecateByVersion}"`);
        if (breakingChange.cmdlet.changeInEfectByDate) parameters.push(`"${breakingChange.cmdlet.changeInEfectByDate}"`);
        if (breakingChange.cmdlet.replacement) parameters.push(`ReplacementCmdletName = "${breakingChange.cmdlet.replacement}"`);
        if (breakingChange.cmdlet.changeDescription) parameters.push(`ChangeDescription = "${breakingChange.cmdlet.changeDescription}"`);

        this.add(new Attribute(ClientRuntime.CmdletBreakingChangeAttribute, { parameters: parameters }));
      }
      if (breakingChange.variant) {
        const parameters = [];
        parameters.push(`new string[] {"${breakingChange.variant.name}"}`);
        if (!breakingChange.variant.deprecateByVersion || !breakingChange.variant.deprecateByAzVersion) {
          throw new Error('Cmdlet breaking change requires both \'deprecateByVersion\' and \'deprecateByAzVersion\', please refer to https://github.com/Azure/azure-powershell/blob/main/documentation/development-docs/breakingchange-for-autogen-module.md for more details.');
        }
        parameters.push(`"${breakingChange.variant.deprecateByAzVersion}"`);
        parameters.push(`"${breakingChange.variant.deprecateByVersion}"`);
        if (breakingChange.variant.changeInEfectByDate) parameters.push(`"${breakingChange.variant.changeInEfectByDate}"`);
        if (breakingChange.variant.changeDescription) parameters.push(`ChangeDescription = "${breakingChange.variant.changeDescription}"`);

        this.add(new Attribute(ClientRuntime.ParameterSetBreakingChangeAttribute, { parameters: parameters }));
      }
      if (breakingChange.output) {
        const parameters = [];
        // if deprecated output types are set in directive, use it
        if (breakingChange.output.deprecatedCmdLetOutputType) {
          parameters.push(`"${breakingChange.output.deprecatedCmdLetOutputType}"`);
        } else {
          parameters.push(`"${outputTypes.values().next().value.replace(/typeof\((.*)\)/, '$1')}"`);
        }
        if (!breakingChange.output.deprecateByVersion || !breakingChange.output.deprecateByAzVersion) {
          throw new Error('Cmdlet breaking change requires both \'deprecateByVersion\' and \'deprecateByAzVersion\', please refer to https://github.com/Azure/azure-powershell/blob/main/documentation/development-docs/breakingchange-for-autogen-module.md for more details.');
        }
        parameters.push(`"${breakingChange.output.deprecateByAzVersion}"`);
        parameters.push(`"${breakingChange.output.deprecateByVersion}"`);
        if (breakingChange.output.changeInEfectByDate) parameters.push(`"${breakingChange.output.changeInEfectByDate}"`);
        if (breakingChange.output.replacement) parameters.push(`ReplacementCmdletOutputType = "${breakingChange.output.replacement}"`);
        if (breakingChange.output.deprecatedOutputProperties) {
          const properties: Array<string> = Object.assign([], breakingChange.output.deprecatedOutputProperties);
          properties.forEach((element, index) => properties[index] = '"' + element + '"');
          parameters.push(`DeprecatedOutputProperties = new string[] {${properties.join(',')}}`);
        }
        if (breakingChange.output.newOutputProperties) {
          const properties: Array<string> = Object.assign([], breakingChange.output.newOutputProperties);
          properties.forEach((element, index) => properties[index] = '"' + element + '"');
          parameters.push(`NewOutputProperties = new string[] {${properties.join(',')} } `);
        }
        if (breakingChange.output.changeDescription) parameters.push(`ChangeDescription = "${breakingChange.output.changeDescription}"`);

        this.add(new Attribute(ClientRuntime.OutputBreakingChangeAttribute, { parameters: parameters }));
      }
    }

    //add preview message attribute for cmdlet
    if (operation.details.csharp.previewAnnouncement) {
      const parameters = [];
      parameters.push(`"${operation.details.csharp.previewAnnouncement.previewMessage}"`);
      if (operation.details.csharp.previewAnnouncement.estimatedGaDate) parameters.push(`"${operation.details.csharp.previewAnnouncement.estimatedGaDate}"`);
      this.add(new Attribute(ClientRuntime.PreviewMessageAttribute, { parameters: parameters }));
    }

    this.add(new Attribute(OutputTypeAttribute, { parameters: [...outputTypes] }));
    if (shouldAddPassThru) {
      const passThru = this.add(new Property('PassThru', SwitchParameter, { description: 'When specified, forces the cmdlet return a \'bool\' given that there isn\'t a return type by default.' }));
      passThru.add(new Attribute(ParameterAttribute, { parameters: ['Mandatory = false', 'HelpMessage = "Returns true when the command succeeds"'] }));
      passThru.add(new Attribute(CategoryAttribute, { parameters: [`${ParameterCategory}.Runtime`] }));
    }

    this.add(new Attribute(DescriptionAttribute, { parameters: [new StringExpression(this.description)] }));

    // If defines externalDocs for operation
    if (operation.details.default.externalDocs) {
      this.add(new Attribute(ExternalDocsAttribute, {
        parameters: [`${new StringExpression(this.operation.details.default.externalDocs?.url ?? '')}`,
        `${new StringExpression(this.operation.details.default.externalDocs?.description ?? '')}`]
      }));
    }

    this.add(new Attribute(GeneratedAttribute));
    if (operation.extensions && operation.extensions['x-ms-metadata'] && operation.extensions['x-ms-metadata'].profiles) {
      const profileNames = Object.keys(operation.extensions && operation.extensions['x-ms-metadata'].profiles);
      // wrap profile names
      profileNames.forEach((element, index) => {
        profileNames[index] = `"${element}"`;
      });

      this.add(new Attribute(ProfileAttribute, { parameters: [...profileNames] }));
    }
    if (this.operation.callGraph.length === 1) {
      this.add(new Attribute(HttpPathAttribute, { parameters: [`Path = "${this.apiCall.requests?.[0].protocol?.http?.path}"`, `ApiVersion = "${this.apiCall.apiVersions?.[0].version}"`] }));
    }
    if (variantName.includes('ViaJsonString') || variantName.includes('ViaJsonFilePath')) {
      this.add(new Attribute(NotSuggestDefaultParameterSetAttribute));
    }
  }
}