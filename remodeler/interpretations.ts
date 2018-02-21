import * as OpenAPI from "./oai3";
import { ImplementationLocation, Server, ExternalDocumentation, MediaType } from "./code-model";
import { getExtensionProperties, clone, Dictionary } from "./common";
import { Remodeler } from "./remodeler";


export function getName(defaultValue: string, original: OpenAPI.Extensions) {
  return typeof (original["x-ms-client-name"]) === "string" ? original["x-ms-client-name"] : defaultValue;
}

export function getDescription(defaultValue: string | undefined, original: OpenAPI.Extensions & { title?: string, summary?: string, description?: string }) {
  if (original) {
    return original.description || original.title || original.summary || defaultValue;
  }
  return defaultValue;
}

export function getParameterImplementationLocation(defaultValue: ImplementationLocation, original: OpenAPI.Parameter & OpenAPI.Extensions): ImplementationLocation {
  const xloc = original["x-ms-parameter-location"];
  if (typeof (xloc) === "string") {
    switch (xloc.toLowerCase()) {
      case "method":
        return ImplementationLocation.Method;
      case "client":
        return ImplementationLocation.Client;
    }
  }
  return defaultValue;
}
export function getEnumDefinition() {

}

export function getKnownFormatType() {

}

export function getDeprecationMessage(original: OpenAPI.Extensions) {
  // TODO: extract deprecation message
  return undefined;
}

export function getConstantValue() {

}

let counter = 1;
export function getOperationId(method: string, path: string, original: OpenAPI.HttpOperation): string {
  if (original.operationId) {
    return original.operationId;
  }

  // synthesize from tags.
  if (original.tags && original.tags.length > 0) {
    switch (original.tags.length) {
      case 0:
        break;
      case 1:
        return `${original.tags[0]}`;
    }
    return `${original.tags[0]}_${original.tags[2]}`;
  }

  return `${method}_method${counter}`;
}

export function copyServer(server: OpenAPI.Server): Server {
  return new Server(server.url, {
    description: server.description,
    extensions: getExtensionProperties(server),
    variables: clone(server.variables)
  });
}

export function getServers(method?: Array<OpenAPI.Server>, path?: Array<OpenAPI.Server>, model?: Array<OpenAPI.Server>): Array<Server> {
  if (method && method.length > 0) {
    return method.map(copyServer);
  }
  if (path && path.length > 0) {
    return path.map(copyServer);
  }
  if (model && model.length > 0) {
    return model.map(copyServer);
  }
  return [];
}

export function getExternalDocs(externalDocs?: OpenAPI.ExternalDocumentation): ExternalDocumentation | undefined {
  return externalDocs && externalDocs.url ? new ExternalDocumentation(externalDocs.url, {
    extensions: getExtensionProperties(externalDocs),
    description: getDescription("", externalDocs)
  }) : undefined
}

