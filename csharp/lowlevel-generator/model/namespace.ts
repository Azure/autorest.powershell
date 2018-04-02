import { hasProperties } from "#common/text-manipulation";
import { Namespace } from "#csharp/code-dom/namespace";
import { ModelInterface } from "#csharp/lowlevel-generator/model/interface";
import { CSharpData } from "#csharp/lowlevel-generator/private-data";
import { JsonType, Schema } from "#remodeler/code-model";
import { Dictionary } from "#remodeler/common";
import { IntegerFormat, NumberFormat, StringFormat } from "#remodeler/known-format";
import { State } from "../generator";
import * as message from "../messages";
import { Uuid } from "../primitives/Uuid";
import { ArrayOf } from "../primitives/array";
import { Boolean } from "../primitives/boolean";
import { ByteArray } from "../primitives/byte-array";
import { Char } from "../primitives/char";
import { Date } from "../primitives/date";
import { DateTime, DateTime1123, UnixTime } from "../primitives/date-time";
import { Duration } from "../primitives/duration";
import { Numeric } from "../primitives/integer";
import { String } from "../primitives/string";
import { UntypedWildcard, Wildcard } from "../primitives/wildcard";
import { EnumClass } from "../support/enum";
import { TypeDeclaration } from "../type-declaration";
import * as validation from "../validations";
import { ModelClass } from "./class";



export class ModelsNamespace extends Namespace {

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelsNamespace>) {
    super("Models", parent);
    this.apply(objectInitializer);

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    for (const schemaName in schemas) {
      const schema = this.schemas[schemaName];
      const state = this.state.path(schemaName);

      // verify that the model isn't in a bad state
      if (validation.objectWithFormat(schema, state)) {
        continue;
      }
      this.resolveTypeDeclaration(schema, true, state);
    }
  }

  private static INVALID = <any>null;

  public resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: State): TypeDeclaration {
    if (!schema) {
      throw new Error("SCHEMA MISSING?")
    }
    const implData: CSharpData = (schema.details.csharp = schema.details.csharp || {});

    // have we done this object already?
    if (implData.typeDeclaration) {
      return implData.typeDeclaration;
    }

    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case JsonType.Object:
        // for certain, this should be a class of some sort.
        if (schema.additionalProperties && !hasProperties(schema.properties)) {
          if (schema.additionalProperties === true) {
            // the object is a wildcard for all key/object-value pairs
            return implData.typeDeclaration = new UntypedWildcard();
          } else {
            // the object is a wildcard for all key/<specific-type>-value pairs
            const wcSchema = this.resolveTypeDeclaration(schema.additionalProperties, false, state.path("additionalProperties"));
            return implData.typeDeclaration = new Wildcard(wcSchema);
          }
        }

        // otherwise, if it has additionalProperties
        // it's a regular object, that has a catch-all for unspecified properties.
        // (handled in ModelClass itself)
        const mc = implData.classImplementation || new ModelClass(this, schema, this.state);
        return implData.typeDeclaration = <ModelInterface>implData.interfaceImplementation;

      case JsonType.String:
        switch (schema.format) {
          case StringFormat.Base64Url:
          case StringFormat.Byte:
            // member should be byte array
            // on wire format should be base64url
            return implData.typeDeclaration = new ByteArray();

          case StringFormat.Binary:
            // represent as a stream
            // wire format is stream of bytes
            throw new Error("Method not implemented.");

          case StringFormat.Char:
            // a single character
            return implData.typeDeclaration = new Char(required, schema.enum.length > 0 ? schema.enum : undefined);

          case StringFormat.Date:
            return implData.typeDeclaration = new Date(required);

          case StringFormat.DateTime:
            return implData.typeDeclaration = new DateTime(required);

          case StringFormat.DateTimeRfc1123:
            return implData.typeDeclaration = new DateTime1123(required);

          case StringFormat.Duration:
            return implData.typeDeclaration = new Duration(required);

          case StringFormat.Uuid:
            return implData.typeDeclaration = new Uuid(required);

          case StringFormat.Password:
          case StringFormat.None:
          case undefined:
          case null:
            if (schema.extensions["x-ms-enum"]) {
              // this value is an enum type instead of a plain string.
              const ec = state.project.supportNamespace.findClassByName(schema.extensions["x-ms-enum"].name);
              if (ec.length > 0) {
                return implData.typeDeclaration = <EnumClass>ec[0];
              }
              return implData.typeDeclaration = new EnumClass(schema, state);
            }

            // just a regular old string.
            return implData.typeDeclaration = new String(required, schema.minLength, schema.maxLength, schema.pattern, schema.enum.length > 0 ? schema.enum : undefined);

          default:
            state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' is not recognized.`, message.DoesNotSupportEnum);
        }
        break;

      case JsonType.Boolean:
        return implData.typeDeclaration = new Boolean(required);

      case JsonType.Integer:
        switch (schema.format) {
          case IntegerFormat.Int64:
          case IntegerFormat.None:
            return implData.typeDeclaration = new Numeric(required ? 'long' : 'long?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
          case IntegerFormat.UnixTime:
            return implData.typeDeclaration = new UnixTime(required);
          case IntegerFormat.Int32:
            return implData.typeDeclaration = new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
        }
        // fallback to int if the format isn't recognized
        return implData.typeDeclaration = new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);


      case JsonType.Number:
        switch (schema.format) {
          case NumberFormat.None:
          case NumberFormat.Double:
            return implData.typeDeclaration = new Numeric(required ? 'double' : 'double?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
          case NumberFormat.Float:
            return implData.typeDeclaration = new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
          case NumberFormat.Decimal:
            return implData.typeDeclaration = new Numeric(required ? 'decimal' : 'decimal?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
        }
        // fallback to float if the format isn't recognized
        return implData.typeDeclaration = new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);

      case JsonType.Array:

        const aSchema = this.resolveTypeDeclaration(<Schema>schema.items, true, state.path("items"));
        return implData.typeDeclaration = new ArrayOf(aSchema, required, schema.minItems, schema.maxItems, schema.uniqueItems);


      case undefined:
        console.error(`schema 'undefined': ${schema.details.name} `);
        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

      default:
        this.state.error(`Schema is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
        return ModelsNamespace.INVALID;
    }
    return ModelsNamespace.INVALID;
  }
}

/*
 Note: removed validation from above -- the validation should be in a separate step before we get into the cs* extensions.

public resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: State): TypeDeclaration {
    if (!schema) {
      throw new Error("SCHEMA MISSING?")
    }
    // have we done this object already?
    if (privateData.typeDeclaration) {
      return privateData.typeDeclaration;
    }

    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case JsonType.Object:
        // for certain, this should be a class of some sort.
        if (schema.additionalProperties && !hasProperties(schema.properties)) {
          if (schema.additionalProperties === true) {
            // the object is a wildcard for all key/object-value pairs
            return privateData.typeDeclaration = new UntypedWildcard();
          } else {
            // the object is a wildcard for all key/<specific-type>-value pairs
            const wcSchema = this.resolveTypeDeclaration(schema.additionalProperties, false, state.path("additionalProperties"));

            return privateData.typeDeclaration = new Wildcard(wcSchema);
          }
        }

        // otherwise, if it has additionalProperties
        // it's a regular object, that has a catch-all for unspecified properties.
        // (handled in ModelClass itself)

        const mc = privateData.classImplementation || new ModelClass(this, schema, this.state);
        privateData.typeDeclaration = privateData.interfaceInplementation;
        return privateData.typeDeclaration;

      case JsonType.String:
        switch (schema.format) {
          case StringFormat.Base64Url:
          case StringFormat.Byte:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            // member should be byte array
            // on wire format should be base64url
            return privateData.typeDeclaration = new ByteArray();

          case StringFormat.Binary:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            // represent as a stream
            // wire format is stream of bytes
            throw new Error("Method not implemented.");

          case StringFormat.Char:
            // a single character
            if (validation.hasXmsEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            return privateData.typeDeclaration = new Char(schema.enum.length > 0 ? schema.enum : undefined);

          case StringFormat.Date:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }

            return privateData.typeDeclaration = new Date();

          case StringFormat.DateTime:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            return privateData.typeDeclaration = new DateTime();

          case StringFormat.DateTimeRfc1123:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            return privateData.typeDeclaration = new DateTime1123();

          case StringFormat.Duration:
            if (validation.schemaHasEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            return privateData.typeDeclaration = new Duration();

          case StringFormat.Uuid:
            if (validation.hasXmsEnum(schema, state)) {
              return ModelsNamespace.INVALID;
            }
            return privateData.typeDeclaration = new Uuid();

          case StringFormat.Password:
          case StringFormat.None:
          case undefined:
          case null:
            if (schema.extensions["x-ms-enum"]) {
              // this value is an enum type instead of a plain string.
              const ec = state.project.supportNamespace.findClassByName(schema.extensions["x-ms-enum"].name);
              if (ec.length > 0) {
                return privateData.typeDeclaration = <EnumClass>ec[0];
              }
              return privateData.typeDeclaration = new EnumClass(schema, state);
            }
            // just a regular old string.
            return privateData.typeDeclaration = new String(schema.minLength, schema.maxLength, schema.pattern, schema.enum.length > 0 ? schema.enum : undefined);

          default:
            state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' is not recognized.`, message.DoesNotSupportEnum);
        }
        break;

      case JsonType.Boolean:
        if (validation.hasXmsEnum(schema, state)) {
          return ModelsNamespace.INVALID;
        }
        return privateData.typeDeclaration = required ? new Boolean() : new NullableBoolean();

      case JsonType.Integer:
        if (validation.hasXmsEnum(schema, state)) {
          return ModelsNamespace.INVALID;
        }
        return privateData.typeDeclaration = new Integer();

      case JsonType.Number:
        if (validation.hasXmsEnum(schema, state)) {
          return ModelsNamespace.INVALID;
        }
        return privateData.typeDeclaration = new Float();

      case JsonType.Array:
        if (validation.hasXmsEnum(schema, state)) {
          return ModelsNamespace.INVALID;
        }
        if (validation.arrayMissingItems(schema, state)) {
          return ModelsNamespace.INVALID;
        }
        const aSchema = this.resolveTypeDeclaration(<Schema>schema.items, true, state.path("items"));
        return privateData.typeDeclaration = new ArrayOf(aSchema);

      case undefined:
        console.error(`schema 'undefined': ${schema.details.name} `);
        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

      default:
        this.state.error(`Schema is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
        return ModelsNamespace.INVALID;
    }
    return ModelsNamespace.INVALID;
  }








}




 */

