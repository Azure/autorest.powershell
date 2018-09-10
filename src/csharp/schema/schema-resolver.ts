/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from '#common/code-model/code-model';
import { JsonType } from '#common/code-model/schema';
import { ModelState } from '#common/model-state';
import { hasProperties } from '#common/text-manipulation';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import * as message from '#csharp/lowlevel-generator/messages';
import { ArrayOf } from '#csharp/schema/array';
import { Binary } from '#csharp/schema/binary';
import { Boolean } from '#csharp/schema/boolean';
import { ByteArray } from '#csharp/schema/byte-array';
import { Char } from '#csharp/schema/char';
import { Date } from '#csharp/schema/date';
import { DateTime, DateTime1123, UnixTime } from '#csharp/schema/date-time';
import { Duration } from '#csharp/schema/duration';
import { EnumImplementation } from '#csharp/schema/enum';
import { Numeric } from '#csharp/schema/integer';
import { ObjectImplementation } from '#csharp/schema/object';
import { String } from '#csharp/schema/string';
import { Uuid } from '#csharp/schema/Uuid';
import { UntypedWildcard, Wildcard } from '#csharp/schema/wildcard';
import { IntegerFormat, NumberFormat, StringFormat } from '#remodeler/known-format';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class SchemaDefinitionResolver {
  private cache = new Map<string, EnhancedTypeDeclaration>();
  private add(schema: Schema, value: EnhancedTypeDeclaration): EnhancedTypeDeclaration {
    this.cache.set(schema.details.default.name, value);
    return value;
  }

  resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: ModelState<Model>): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case JsonType.Array:
        // can be recursive!
        const elementType = this.resolveTypeDeclaration(<Schema>schema.items, true, state.path('items'));
        return new ArrayOf(schema, required, elementType, schema.minItems, schema.maxItems, schema.uniqueItems);

      case JsonType.Object:
        const result = this.cache.get(schema.details.default.name);
        if (result) {
          return result;
        }

        // can be recursive!
        // for certain, this should be a class of some sort.
        if (schema.additionalProperties && !hasProperties(schema.properties)) {
          if (schema.additionalProperties === true) {
            // the object is a wildcard for all key/object-value pairs
            return new UntypedWildcard(schema);
          } else {
            // the object is a wildcard for all key/<specific-type>-value pairs
            const wcSchema = this.resolveTypeDeclaration(schema.additionalProperties, false, state.path('additionalProperties'));
            return new Wildcard(schema, wcSchema);
          }
        }
        // otherwise, if it has additionalProperties
        // it's a regular object, that has a catch-all for unspecified properties.
        // (handled in ModelClass itself)

        return this.add(schema, new ObjectImplementation(schema));

      case JsonType.String:
        switch (schema.format) {
          case StringFormat.Base64Url:
          case StringFormat.Byte:
            // member should be byte array
            // on wire format should be base64url
            return new ByteArray(schema, required);

          case StringFormat.Binary:
            // represent as a stream
            // wire format is stream of bytes
            return new Binary(schema, required);

          case StringFormat.Char:
            // a single character
            return new Char(schema, required);

          case StringFormat.Date:
            return new Date(schema, required);

          case StringFormat.DateTime:
            return new DateTime(schema, required);

          case StringFormat.DateTimeRfc1123:
            return new DateTime1123(schema, required);

          case StringFormat.Duration:
            return new Duration(schema, required);

          case StringFormat.Uuid:
            return new Uuid(schema, required);

          case StringFormat.Url:
          case StringFormat.Password:
          case StringFormat.None:
          case undefined:
          case null:
            if (schema.extensions['x-ms-enum']) {
              return new EnumImplementation(schema, required);
            }
            if (schema.extensions['x-ms-header-collection-prefix']) {
              return new Wildcard(schema, new String(<any>{}, required));
            }
            // just a regular old string.
            return new String(schema, required);

          default:
            state.warning(`Schema with type:'${schema.type} and 'format:'${schema.format}' is not recognized.`, message.DoesNotSupportEnum);
            return new String(schema, required);
        }

      case JsonType.Boolean:
        return new Boolean(schema, required);

      case JsonType.Integer:
        switch (schema.format) {
          case IntegerFormat.Int64:
          case IntegerFormat.None:
            return new Numeric(schema, required, required ? 'long' : 'long?');
          case IntegerFormat.UnixTime:
            return new UnixTime(schema, required);
          case IntegerFormat.Int32:
            return new Numeric(schema, required, required ? 'int' : 'int?');
        }
        // fallback to int if the format isn't recognized
        return new Numeric(schema, required, required ? 'int' : 'int?');

      case JsonType.Number:
        switch (schema.format) {
          case NumberFormat.None:
          case NumberFormat.Double:
            return new Numeric(schema, required, required ? 'double' : 'double?');
          case NumberFormat.Float:
            return new Numeric(schema, required, required ? 'float' : 'float?');
          case NumberFormat.Decimal:
            return new Numeric(schema, required, required ? 'decimal' : 'decimal?');
        }
        // fallback to float if the format isn't recognized
        return new Numeric(schema, required, required ? 'float' : 'float?');

      case undefined:
        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

    }
    state.error(`Schema '${schema.details.csharp.name}' is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
    throw new Error('Unknown Model. Fatal.');
  }
}
