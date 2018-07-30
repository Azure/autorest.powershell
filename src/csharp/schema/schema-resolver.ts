import { Model } from '#common/code-model/code-model';
import { JsonType } from '#common/code-model/schema';
import { ModelState } from '#common/model-state';
import { hasProperties } from '#common/text-manipulation';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { State } from '#csharp/lowlevel-generator/generator';
import * as message from '#csharp/lowlevel-generator/messages';
import { ArrayOf } from '#csharp/schema/array';
import { Boolean } from '#csharp/schema/boolean';
import { ByteArray } from '#csharp/schema/byte-array';
import { Char } from '#csharp/schema/char';
import { Date } from '#csharp/schema/date';
import { DateTime, DateTime1123, UnixTime } from '#csharp/schema/date-time';
import { Duration } from '#csharp/schema/duration';
import { EnumFeatures } from '#csharp/schema/enum';
import { Numeric } from '#csharp/schema/integer';
import { ObjectFeatures } from '#csharp/schema/object';
import { String } from '#csharp/schema/string';
import { Uuid } from '#csharp/schema/Uuid';
import { UntypedWildcard, Wildcard } from '#csharp/schema/wildcard';
import { IntegerFormat, NumberFormat, StringFormat } from '#remodeler/known-format';
import { Serialization, Validation } from './extended-type-declaration';

export class SchemaDefinitionResolver {
  private cache = new Map<string, Serialization & Validation>();
  private add(schema: Schema, value: Serialization & Validation): Serialization & Validation {
    this.cache.set(schema.details.default.name, value);
    return value;
  }

  resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: ModelState<Model>): Serialization & Validation {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    // check for a type declaration in the this.cache first.


    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case JsonType.Array:
        // can be recursive!
        const aSchema = this.resolveTypeDeclaration(<Schema>schema.items, true, state.path('items'));
        return this.add(schema, new ArrayOf(aSchema, required, schema.minItems, schema.maxItems, schema.uniqueItems));

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
            return this.add(schema, new UntypedWildcard());
          } else {
            // the object is a wildcard for all key/<specific-type>-value pairs
            const wcSchema = this.resolveTypeDeclaration(schema.additionalProperties, false, state.path('additionalProperties'));
            return this.add(schema, new Wildcard(wcSchema));
          }
        }
        // otherwise, if it has additionalProperties
        // it's a regular object, that has a catch-all for unspecified properties.
        // (handled in ModelClass itself)

        return this.add(schema, new ObjectFeatures(schema));

      case JsonType.String:
        switch (schema.format) {
          case StringFormat.Base64Url:
          case StringFormat.Byte:
            // member should be byte array
            // on wire format should be base64url
            return this.add(schema, new ByteArray());

          case StringFormat.Binary:
            // represent as a stream
            // wire format is stream of bytes
            throw new Error('Format \'Binary\' not implemented.');

          case StringFormat.Char:
            // a single character
            return this.add(schema, new Char(required, schema.enum.length > 0 ? schema.enum : undefined));

          case StringFormat.Date:
            return this.add(schema, new Date(required));

          case StringFormat.DateTime:
            return this.add(schema, new DateTime(required));

          case StringFormat.DateTimeRfc1123:
            return this.add(schema, new DateTime1123(required));

          case StringFormat.Duration:
            return this.add(schema, new Duration(required));

          case StringFormat.Uuid:
            return this.add(schema, new Uuid(required));

          case StringFormat.Password:
          case StringFormat.None:
          case undefined:
          case null:
            if (schema.extensions['x-ms-enum']) {
              return this.add(schema, new EnumFeatures(schema));
            }

            // just a regular old string.
            return this.add(schema, new String(required, schema.minLength, schema.maxLength, schema.pattern, schema.enum.length > 0 ? schema.enum : undefined));

          default:
            state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' is not recognized.`, message.DoesNotSupportEnum);
        }

      case JsonType.Boolean:
        return this.add(schema, new Boolean(required));

      case JsonType.Integer:
        switch (schema.format) {
          case IntegerFormat.Int64:
          case IntegerFormat.None:
            return this.add(schema, new Numeric(required ? 'long' : 'long?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));
          case IntegerFormat.UnixTime:
            return this.add(schema, new UnixTime(required));
          case IntegerFormat.Int32:
            return this.add(schema, new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));
        }
        // fallback to int if the format isn't recognized
        return this.add(schema, new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));

      case JsonType.Number:
        switch (schema.format) {
          case NumberFormat.None:
          case NumberFormat.Double:
            return this.add(schema, new Numeric(required ? 'double' : 'double?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));
          case NumberFormat.Float:
            return this.add(schema, new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));
          case NumberFormat.Decimal:
            return this.add(schema, new Numeric(required ? 'decimal' : 'decimal?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));
        }
        // fallback to float if the format isn't recognized
        return this.add(schema, new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf));

      case undefined:
        // console.error(`schema 'undefined': ${schema.details.csharp.name} `);
        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

    }
    state.error(`Schema '${schema.details.csharp.name}' is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
    throw new Error('Unknown Model. Fatal.');
  }
}

