/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { length } from '@microsoft.azure/codegen';
import { ModelState, codemodel, IntegerFormat, NumberFormat, StringFormat, JsonType } from '@microsoft.azure/autorest.codemodel-v3';
import { Schema } from '../code-model';
import * as message from '../messages';
import { ArrayOf } from './array';
import { Binary } from './binary';
import { Boolean } from './boolean';
import { ByteArray } from './byte-array';
import { Char } from './char';
import { Date } from './date';
import { DateTime, DateTime1123, UnixTime } from './date-time';
import { Duration } from './duration';
import { EnumImplementation } from './enum';
import { Numeric } from './integer';
import { ObjectImplementation } from './object';
import { String } from './string';
import { Uuid } from './Uuid';
import { UntypedWildcard, Wildcard } from './wildcard';
import { EnhancedTypeDeclaration } from './extended-type-declaration';

export class SchemaDefinitionResolver {
  private readonly cache = new Map<string, EnhancedTypeDeclaration>();
  private add(schema: Schema, value: EnhancedTypeDeclaration): EnhancedTypeDeclaration {
    this.cache.set(schema.details.csharp.fullname || '', value);
    return value;
  }

  resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: ModelState<codemodel.Model>): EnhancedTypeDeclaration {
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
        const result = this.cache.get(schema.details.csharp.fullname || '');
        if (result) {
          return result;
        }

        const propertyCount = length(schema.properties);

        if (propertyCount === 0) {
          // *this* object has no properties.
          // so, if it has additionalProperties set, we should return some kind of a wildcard/dictionary.

          switch (typeof (schema.additionalProperties)) {
            case 'boolean':
              if (schema.additionalProperties === true) {
                // this should be a dictionary<string, any>
                return new UntypedWildcard(schema);
              }
              // additionalProperties = false. No action necessary.
              break;
            case 'object':
              const addlSchema = <Schema>schema.additionalProperties;
              switch (addlSchema.type) {
                case JsonType.Object:
                  // it's some kind of object.
                  if (length(addlSchema.properties) === 0) {
                    // it's an untyped wildcard again.

                    // we should not create a class for the nested object type
                    addlSchema.details.csharp.skip = true;
                    return new UntypedWildcard(schema);
                  }
                  // it has properties.
                  // it's a specific kind of dictionary<string, addlSchema>
                  return new Wildcard(schema, this.resolveTypeDeclaration(addlSchema, false, state.path('additionalProperties')));

                case JsonType.String:
                case JsonType.Boolean:
                case JsonType.Number:
                  // it's a primitive type (string/boolean/number)
                  // it should be a simple dictionary<string, t>
                  return new Wildcard(schema, this.resolveTypeDeclaration(addlSchema, false, state.path('additionalProperties')));

                default:
                  // what? What kind of a monster are you?
                  console.error(`NOT SUPPORTED: Object with additionalProperties that's not an object/string.boolean.number : { type: ${addlSchema.type} } --  ${schema.details.csharp.name}`);
                  throw new Error('Not Supported Yet. ');
              }
            case 'undefined':
              break;

            default:
              console.error(`NOT SUPPORTED: Object with additionalProperties: '${schema.additionalProperties}' --  ${schema.details.chsarp.name}`);
              throw new Error('What does that even mean?');
          }
          // object with no properties?
        }

        if (schema.additionalProperties) {
          // this object *does* have properties.
          // *AND* additionalProperties is set.
          // Which means that this object should implement a dictionary too.
          // (handled in model-class itself...)
          console.error(`FYI : Has ADDITIONALPROPERTIES ${schema.details.csharp.name} : ${length(schema.properties)}`);
        }

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
