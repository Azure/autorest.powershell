/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { EnumDetails, ModelState, components } from '@microsoft.azure/autorest.codemodel-v3';

import { clone, getExtensionProperties } from './common';
import * as OpenAPI from '@microsoft.azure/openapi';
import { getPascalIdentifier } from '@microsoft.azure/codegen';

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

export function getParameterImplementationLocation(defaultValue: components.ImplementationLocation, original: OpenAPI.Parameter & OpenAPI.Extensions): components.ImplementationLocation {
  const xloc = original['x-ms-parameter-location'];

  if (typeof (xloc) === 'string') {
    switch (xloc.toLowerCase()) {
      case 'method':
        return components.ImplementationLocation.Method;
      case 'client':
        return components.ImplementationLocation.Client;
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
            name: (each.name !== undefined) ? getValidEnumValueName(each.name) : `${getValidEnumValueName(each.value)}`,
            value: each.value
          };
        }) :
        original.enum.map(each => {
          return {
            description: '',
            name: getValidEnumValueName(each),
            value: each
          };
        }),
      modelAsString: xmse.modelAsString ? true : false
    };
  }
  return undefined;
}

export function getValidEnumValueName(originalString: string): string {
  return !originalString.match(/[A-Za-z0-9]/g) ?
    getPascalIdentifier(originalString.split('').map(x => specialCharacterMapping[x]).join(' '))
    : originalString;
}

// ref: https://www.w3schools.com/charsets/ref_html_ascii.asp
const specialCharacterMapping: { [character: string]: string } = {
  '!': 'exclamation mark',
  '"': 'quotation mark',
  '#': 'number sign',
  '$': 'dollar sign',
  '%': 'percent sign',
  '&': 'ampersand',
  '\'': 'apostrophe',
  '(': 'left parenthesis',
  ')': 'right parenthesis',
  '*': 'asterisk',
  '+': 'plus sign',
  ',': 'comma',
  '-': 'hyphen',
  '.': 'period',
  '/': 'slash',
  ':': 'colon',
  ';': 'semicolon',
  '<': 'less-than',
  '=': 'equals-to',
  '>': 'greater-than',
  '?': 'question mark',
  '@': 'at sign',
  '[': 'left square bracket',
  '\\': 'backslash',
  ']': 'right square bracket',
  '^': 'caret',
  '_': 'underscore',
  '`': 'grave accent',
  '{': 'left curly brace',
  '|': 'vertical bar',
  '}': 'right curly brace',
  '~': 'tilde'
}

export function getKnownFormatType() {

}

export function getDeprecationMessage(original: OpenAPI.Extensions) {
  // TODO: extract deprecation message
  return undefined;
}

export function getConstantValue() {

}

let counter = 0;
export function getOperationId(method: string, path: string, original: OpenAPI.HttpOperation, serviceTitle: string, state: ModelState<OpenAPI.Model>): string {
  if (original.operationId) {
    return original.operationId;
  }


  // synthesize from tags.
  if (original.tags && original.tags.length > 0) {

    switch (original.tags.length) {
      case 0:
        break;
      case 1:
        state.path('components', 'paths', path, method).warning(`Generating 'operationId' for '${method}' operation on path '${path}' `, ['Interpretations']);
        return `${original.tags[0]}`;
    }
    state.path('components', 'paths', path, method).warning(`Generating 'operationId' for '${method}' operation on path '${path}' `, ['Interpretations']);
    return `${original.tags[0]}_${original.tags[1]}`;
  }
  state.path('components', 'paths', path, method).error(`NEED 'operationId' for '${method}' operation on path '${path}' `, ['Interpretations']);

  return ``;
}

export function copyServer(server: OpenAPI.Server): components.Server {
  return new components.Server(server.url, {
    description: server.description,
    extensions: getExtensionProperties(server),
    variables: clone(server.variables)
  });
}

export function getServers(method?: Array<OpenAPI.Server>, path?: Array<OpenAPI.Server>, model?: Array<OpenAPI.Server>): Array<components.Server> {
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

export function getExternalDocs(externalDocs?: OpenAPI.ExternalDocumentation): components.ExternalDocumentation | undefined {
  return externalDocs && externalDocs.url ? new components.ExternalDocumentation(externalDocs.url, {
    extensions: getExtensionProperties(externalDocs),
    description: getDescription('', externalDocs)
  }) : undefined;
}
