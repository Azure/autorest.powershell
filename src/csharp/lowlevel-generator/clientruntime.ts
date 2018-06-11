import { Interface } from '#csharp/code-dom/interface';
import { EnumType, LibraryType } from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { Expression } from '#csharp/code-dom/expression';
import { Class } from '#csharp/code-dom/class';
import { Method } from '#csharp/code-dom/method';
import { Parameter } from '#csharp/code-dom/parameter';

export const ClientRuntime: Namespace = new Namespace('Microsoft.Rest.ClientRuntime');

export const ISendAsync: Interface = new Interface(ClientRuntime, 'ISendAsync');
export const IJsonSerializable: Interface = new Interface(ClientRuntime, 'IJsonSerializable');
export const IXmlSerializable: Interface = new Interface(ClientRuntime, 'IXmlSerializable');

export const EventListener: Interface = new Interface(ClientRuntime, `EventListener`);
export const IEventListener: Interface = new Interface(ClientRuntime, `IEventListener`);
export const IValidates: Interface = new Interface(ClientRuntime, 'IValidates');
export const EventData: Interface = new Interface(ClientRuntime, 'EventData');

export const JsonNode: TypeDeclaration = new LibraryType(`Carbon.Json.JsonNode`);
export const JsonObject: TypeDeclaration = new LibraryType(`Carbon.Json.JsonObject`);


export const JsonMode = new EnumType(ClientRuntime, 'JsonMode').withMembers<{ None: Expression; IncludeAll: Expression }>();

export const KeyValuePairs: TypeDeclaration = new LibraryType(`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>>`);

export const HttpPipeline = new LibraryType("Microsoft.Rest.ClientRuntime.HttpPipeline");

export const SendAsyncStep = new LibraryType('Microsoft.Rest.ClientRuntime.SendAsyncStep[]');