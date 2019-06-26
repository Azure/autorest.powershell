/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { intersect } from '@microsoft.azure/codegen';
import { ClassType, dotnet, System } from '@microsoft.azure/codegen-csharp';

import { Expression, ExpressionOrLiteral, LiteralExpression, toExpression } from '@microsoft.azure/codegen-csharp';
import { Interface } from '@microsoft.azure/codegen-csharp';
import { Namespace } from '@microsoft.azure/codegen-csharp';

const clientRuntimeNamespace: Namespace = new Namespace('Microsoft.Rest.ClientRuntime');
const serializationMode = new ClassType(clientRuntimeNamespace, 'SerializationMode');
const events = new ClassType(clientRuntimeNamespace, 'Events');
const method = new ClassType(clientRuntimeNamespace, 'Method');
const carbon = new Namespace('Carbon.Json');
const jsonNode = new ClassType(carbon, 'JsonNode');
const jsonArray = new ClassType(carbon, 'JsonArray');
const jsonObject = new ClassType(carbon, 'JsonObject');
const jsonType = new ClassType(carbon, 'JsonType');

export const ClientRuntime = intersect(clientRuntimeNamespace, {
  AttachDebugger: new ClassType(clientRuntimeNamespace, 'AttachDebugger'),
  Method: intersect(method, {
    Get: new LiteralExpression(`${method.declaration}.Get`),
    Put: new LiteralExpression(`${method.declaration}.Put`),
    Post: new LiteralExpression(`${method.declaration}.Post`),
    Delete: new LiteralExpression(`${method.declaration}.Delete`),
    Options: new LiteralExpression(`${method.declaration}.Options`),
    Head: new LiteralExpression(`${method.declaration}.Head`),
    Trace: new LiteralExpression(`${method.declaration}.Trace`),
    Patch: new LiteralExpression(`${method.declaration}.Patch`)
  }),
  InfoAttribute: new ClassType(clientRuntimeNamespace, `Info`),
  EventDataConverter: new ClassType(clientRuntimeNamespace, 'EventDataConverter'),
  ISendAsync: new Interface(clientRuntimeNamespace, 'ISendAsync'),
  Extensions: new ClassType(clientRuntimeNamespace, 'Extensions'),
  IJsonSerializable: new Interface(clientRuntimeNamespace, 'IJsonSerializable'),
  JsonSerializable: new Interface(clientRuntimeNamespace, 'JsonSerializable'),
  IXmlSerializable: new Interface(clientRuntimeNamespace, 'IXmlSerializable'),
  IEventListener: new Interface(clientRuntimeNamespace, 'IEventListener'),
  IValidates: new Interface(clientRuntimeNamespace, 'IValidates'),
  IHeaderSerializable: new Interface(clientRuntimeNamespace, 'IHeaderSerializable'),
  SerializationMode: intersect(serializationMode, {
    None: new LiteralExpression(`${serializationMode.declaration}.None`),
    IncludeAll: new LiteralExpression(`${serializationMode.declaration}.IncludeAll`),
    IncludeHeaders: new LiteralExpression(`${serializationMode.declaration}.IncludeHeaders`),
    IncludeReadOnly: new LiteralExpression(`${serializationMode.declaration}.IncludeReadOnly`),
  }),
  HttpPipeline: new ClassType(clientRuntimeNamespace, 'HttpPipeline'),
  HttpClientFactory: new ClassType(clientRuntimeNamespace, 'HttpClientFactory'),
  SendAsyncStep: new ClassType(clientRuntimeNamespace, 'SendAsyncStep[]'),
  EventData: new ClassType(clientRuntimeNamespace, 'EventData'),
  EventListener: new ClassType(clientRuntimeNamespace, 'EventListener'),
  Events: intersect(events, {
    BodyContentSet: new LiteralExpression(`${events.declaration}.BodyContentSet`),
    BeforeCall: new LiteralExpression(`${events.declaration}.BeforeCall`),
    BeforeResponseDispatch: new LiteralExpression(`${events.declaration}.BeforeResponseDispatch`),
    Log: new LiteralExpression(`${events.declaration}.Log`),
    Validation: new LiteralExpression(`${events.declaration}.Validation`),
    VaidationWarning: new LiteralExpression(`${events.declaration}.VaidationWarning`),
    AfterValidation: new LiteralExpression(`${events.declaration}.AfterValidation`),
    RequestCreated: new LiteralExpression(`${events.declaration}.RequestCreated`),
    ResponseCreated: new LiteralExpression(`${events.declaration}.ResponseCreated`),
    HeaderParametersAdded: new LiteralExpression(`${events.declaration}.HeaderParametersAdded`),
    URLCreated: new LiteralExpression(`${events.declaration}.URLCreated`),
    Finally: new LiteralExpression(`${events.declaration}.Finally`),
    Polling: new LiteralExpression(`${events.declaration}.Polling`),
    DelayBeforePolling: new LiteralExpression(`${events.declaration}.DelayBeforePolling`),
  }),
  KeyValuePairs: System.Collections.Generic.IEnumerable(System.Collections.Generic.KeyValuePair(dotnet.String, System.Collections.Generic.IEnumerable(dotnet.String))),
  JsonNode: intersect(jsonNode, {
    Parse: (expression: ExpressionOrLiteral) => toExpression(`${jsonNode}.Parse(${toExpression(expression)})`)
  }),
  JsonObject: intersect(jsonObject, {
    Parse: (expression: Expression) => toExpression(`${jsonObject}.Parse(${expression})`)
  }),
  JsonString: new ClassType(carbon, `JsonString`),
  JsonBoolean: new ClassType(carbon, `JsonBoolean`),
  JsonNumber: new ClassType(carbon, `JsonNumber`),
  JsonArray: intersect(jsonArray, {
    Parse: (expression: ExpressionOrLiteral) => toExpression(`${jsonArray}.Parse(${toExpression(expression)})`)
  }),
  JsonType: intersect(jsonType, {
    Null: new LiteralExpression(`${jsonType.declaration}.Null`),
    Object: new LiteralExpression(`${jsonType.declaration}.Object`),
    Array: new LiteralExpression(`${jsonType.declaration}.Array`),
    Binary: new LiteralExpression(`${jsonType.declaration}.Binary`),
    Boolean: new LiteralExpression(`${jsonType.declaration}.Boolean`),
    Date: new LiteralExpression(`${jsonType.declaration}.Date`),
    Number: new LiteralExpression(`${jsonType.declaration}.Number`),
    String: new LiteralExpression(`${jsonType.declaration}.String`)
  }),
  XNodeArray: new ClassType(carbon, `XNodeArray`)
});

