import { Expression, LiteralExpression } from '#csharp/code-dom/expression';
import { Interface } from '#csharp/code-dom/interface';
import { EnumType, LibraryType } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { intersect } from '#common/intersect';
import * as dotnet from "#csharp/code-dom/mscorlib";

const clientRuntimeNamespace: Namespace = new Namespace('Microsoft.Rest.ClientRuntime');
const serializationMode = new LibraryType(clientRuntimeNamespace, "SerializationMode");
const events = new LibraryType(clientRuntimeNamespace, "Events");
const carbon = new Namespace('Carbon.Json');

export const ClientRuntime = intersect(clientRuntimeNamespace, {
  ISendAsync: new Interface(clientRuntimeNamespace, 'ISendAsync'),
  IJsonSerializable: new Interface(clientRuntimeNamespace, 'IJsonSerializable'),
  IXmlSerializable: new Interface(clientRuntimeNamespace, 'IXmlSerializable'),
  IEventListener: new Interface(clientRuntimeNamespace, 'IEventListener'),
  IValidates: new Interface(clientRuntimeNamespace, 'IValidates'),
  SerializationMode: intersect(serializationMode, {
    None: new LiteralExpression(`${serializationMode.declaration}.None`),
    IncludeAll: new LiteralExpression(`${serializationMode.declaration}.IncludeAll`),
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
  KeyValuePairs: dotnet.System.Collections.Generic.IEnumerable(dotnet.System.Collections.Generic.KeyValuePair(dotnet.String, dotnet.System.Collections.Generic.IEnumerable(dotnet.String))),
  JsonNode: new LibraryType(carbon, `JsonNode`),
  JsonString: new LibraryType(carbon, `JsonString`),
  JsonBoolean: new LibraryType(carbon, `JsonBoolean`),
  JsonNumber: new LibraryType(carbon, `JsonNumber`),
  JsonObject: new LibraryType(carbon, `JsonObject`),
  JsonArray: new LibraryType(carbon, `JsonArray`),
  XNodeArray: new LibraryType(carbon, `XNodeArray`)
});