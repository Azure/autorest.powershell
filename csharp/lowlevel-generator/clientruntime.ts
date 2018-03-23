import { TypeDeclaration } from "#csharp/code-dom/type-declaration";
import { LibraryType } from "#csharp/code-dom/mscorlib";
import { Namespace } from "#csharp/code-dom/namespace";
import { Interface } from "#csharp/code-dom/interface";

export const ClientRuntime: Namespace = new Namespace("Microsoft.Rest.ClientRuntime");

export const ISendAsync: Interface = new Interface(ClientRuntime, "ISendAsync");
export const IJsonSerializable: Interface = new Interface(ClientRuntime, "IJsonSerializable");
export const IXmlSerializable: Interface = new Interface(ClientRuntime, "IXmlSerializable");

export const EventListener: TypeDeclaration = new LibraryType(`${ClientRuntime.fullName}.EventListener`);
export const IValidates: Interface = new Interface(ClientRuntime, "IValidates");

export const JsonNode: TypeDeclaration = new LibraryType(`Carbon.Json.JsonNode`);
export const JsonObject: TypeDeclaration = new LibraryType(`Carbon.Json.JsonObject`);

