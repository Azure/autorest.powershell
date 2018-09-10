/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ExternalDocumentation, ImplementationLocation } from '#common/code-model/components';
import { EnumDetails } from '#common/code-model/schema';
import { Server } from '../common/code-model/components';
import { clone, getExtensionProperties } from './common';
import * as OpenAPI from './oai3';

interface XMSEnum {
  modelAsString?: boolean;
  values: [{ value: any; description?: string; name?: string }];
  name: string;
}

export function getName(defaultValue: string, original: OpenAPI.Extensions) {
  return typeof (original['x-ms-client-name']) === 'string' ? original['x-ms-client-name'] : defaultValue;
}

export function getDescription(defaultValue: string, original: OpenAPI.Extensions & { title?: string; summary?: string; description?: string }): string {
  if (original) {
    return original.description || original.title || original.summary || defaultValue;
  }
  return defaultValue;
}

export function getParameterImplementationLocation(defaultValue: ImplementationLocation, original: OpenAPI.Parameter & OpenAPI.Extensions): ImplementationLocation {
  const xloc = original['x-ms-parameter-location'];
  if (typeof (xloc) === 'string') {
    switch (xloc.toLowerCase()) {
      case 'method':
        return ImplementationLocation.Method;
      case 'client':
        return ImplementationLocation.Client;
    }
  }
  return defaultValue;
}
export function getEnumDefinition(original: OpenAPI.Schema): EnumDetails | undefined {
  const xmse = <XMSEnum>original['x-ms-enum'];
  if (xmse && original.enum) {
    return {
      name: xmse.name,
      values: xmse.values ?
        xmse.values.map((each) => {
          return {
            description: each.description || '',
            name: each.name || `${each.value}`,
            value: each.value
          };
        }) :
        original.enum.map(each => {
          return {
            description: '',
            name: each,
            value: each
          };
        }),
      modelAsString: xmse.modelAsString ? true : false
    };
  }
  return undefined;
}

export function getKnownFormatType() {

}

export function getDeprecationMessage(original: OpenAPI.Extensions) {
  // TODO: extract deprecation message
  return undefined;
}

export function getConstantValue() {

}

const counter = 1;
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
    description: getDescription('', externalDocs)
  }) : undefined;
}
