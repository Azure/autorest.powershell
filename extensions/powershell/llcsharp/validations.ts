/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { JsonType, Schema } from '@azure/autorest.codemodel-v3';
import { State } from './generator';
import * as message from './messages';

export function objectWithFormat(schema: Schema, state: State): boolean {
  if (schema.type === JsonType.Object && schema.format) {
    state.error(`Schema is declared 'object' but has a format: '${schema.format}'`, message.ObjectShouldNotHaveFormat);
    return true;
  }
  return false;
}

export function schemaHasEnum(schema: Schema, state: State): boolean {
  if (schema.enum.length > 0) {
    state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' does not support 'enum' value restrictions.`, message.DoesNotSupportEnum);
    return true;
  }
  return false;
}

export function hasXmsEnum(schema: Schema, state: State): boolean {
  if (schema.enum.length > 0) {
    if (schema.extensions['x-ms-enum']) {
      state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' does not support 'x-ms-enum' generation `, message.SchemaDoeNotSupportXMSEnum);
      return true;
    }
  }
  return false;
}

export function arrayMissingItems(schema: Schema, state: State): boolean {
  if (schema.type === JsonType.Array && !schema.items) {
    state.error('Array schema missing items type', message.ArrayMissingItems);
    return true;
  }
  return false;
}
