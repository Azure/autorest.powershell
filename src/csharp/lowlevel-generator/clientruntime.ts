import { intersect } from '#common/intersect';
import { EnumType, LibraryType, System, dotnet } from '#csharp/code-dom/dotnet';

import { Expression, LiteralExpression, toExpression, ExpressionOrLiteral } from '#csharp/code-dom/expression';
import { Interface } from '#csharp/code-dom/interface';
import { Namespace } from '#csharp/code-dom/namespace';

const clientRuntimeNamespace: Namespace = new Namespace('Microsoft.Rest.ClientRuntime');
const serializationMode = new LibraryType(clientRuntimeNamespace, 'SerializationMode');
const events = new LibraryType(clientRuntimeNamespace, 'Events');
const method = new LibraryType(clientRuntimeNamespace, 'Method');
const carbon = new Namespace('Carbon.Json');
const jsonNode = new LibraryType(carbon, 'JsonNode');
const jsonObject = new LibraryType(carbon, 'JsonObject');

export const ClientRuntime = intersect(clientRuntimeNamespace, {
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
  EventDataConverter: new LibraryType(clientRuntimeNamespace, 'EventDataConverter'),
  ISendAsync: new Interface(clientRuntimeNamespace, 'ISendAsync'),
  Extensions: new LibraryType(clientRuntimeNamespace, 'Extensions'),
  IJsonSerializable: new Interface(clientRuntimeNamespace, 'IJsonSerializable'),
  IXmlSerializable: new Interface(clientRuntimeNamespace, 'IXmlSerializable'),
  IEventListener: new Interface(clientRuntimeNamespace, 'IEventListener'),
  IValidates: new Interface(clientRuntimeNamespace, 'IValidates'),
  SerializationMode: intersect(serializationMode, {
    None: new LiteralExpression(`${serializationMode.declaration}.None`),
    IncludeAll: new LiteralExpression(`${serializationMode.declaration}.IncludeAll`),
    IncludeHeaders: new LiteralExpression(`${serializationMode.declaration}.IncludeHeaders`),
    IncludeReadOnly: new LiteralExpression(`${serializationMode.declaration}.IncludeReadOnly`),
  }),
  HttpPipeline: new LibraryType(clientRuntimeNamespace, 'HttpPipeline'),
  SendAsyncStep: new LibraryType(clientRuntimeNamespace, 'SendAsyncStep[]'),
  EventData: new LibraryType(clientRuntimeNamespace, 'EventData'),
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
  JsonString: new LibraryType(carbon, `JsonString`),
  JsonBoolean: new LibraryType(carbon, `JsonBoolean`),
  JsonNumber: new LibraryType(carbon, `JsonNumber`),
  JsonArray: new LibraryType(carbon, `JsonArray`),
  XNodeArray: new LibraryType(carbon, `XNodeArray`)
});

export const StoragePipeline = {
  Pipeline: new LibraryType('Microsoft.Azure.HttpPipeline', 'Pipeline'),
  CancelContext: new LibraryType('Microsoft.Azure.HttpPipeline', 'CancelContext'),

}
