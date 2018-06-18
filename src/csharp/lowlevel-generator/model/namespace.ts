import { Header } from '#common/code-model/http-operation';
import { Dictionary, items } from '#common/dictionary';
import { Import } from '#csharp/code-dom/import';
import { Namespace } from '#csharp/code-dom/namespace';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { ModelInterface } from '#csharp/lowlevel-generator/model/interface';
import { EnumFeatures } from '#csharp/schema/enum';
import { ObjectFeatures } from '#csharp/schema/object';
import { SchemaDefinitionResolver } from '#csharp/schema/schema-resolver';
import { Serialization, Validation } from '../../schema/extended-type-declaration';
import { State } from '../generator';
import { EnumClass } from '../support/enum';
import * as validation from '../validations';
import { ModelClass } from './model-class';

export class ModelsNamespace extends Namespace {

  resolver = new SchemaDefinitionResolver();

  constructor(parent: Namespace, private schemas: Dictionary<Schema>, private state: State, objectInitializer?: Partial<ModelsNamespace>) {
    super('Models', parent);
    this.apply(objectInitializer);
    this.addUsing(new Import('static Microsoft.Rest.ClientRuntime.IEventListenerExtensions'));

    // special case... hook this up before we get anywhere.
    state.project.modelsNamespace = this;

    for (const { key: schemaName, value: schema } of items(schemas)) {
      const state = this.state.path(schemaName);

      // verify that the model isn't in a bad state
      if (validation.objectWithFormat(schema, state)) {
        continue;
      }
      this.resolveTypeDeclaration(schema, true, state);
    }
  }

  private static INVALID = <any>null;

  public resolveHeaderTypeDeclaration(headers: Dictionary<Header>, required: boolean, state: State): Serialization & Validation | null {
    return null;
  }

  public resolveTypeDeclaration(schema: Schema | undefined, required: boolean, state: State): Serialization & Validation {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    const td = this.resolver.resolveTypeDeclaration(schema, required, state);
    if (td instanceof ObjectFeatures) {
      // it's a class object.
      // create it if necessary
      const mc = schema.details.csharp.classImplementation || new ModelClass(this, td, this.state);

      // this gets implicity created during class creation:
      return <ModelInterface>schema.details.csharp.interfaceImplementation;
    }

    if (td instanceof EnumFeatures) {
      const ec = state.project.supportNamespace.findClassByName(schema.extensions['x-ms-enum'].name);
      if (ec.length > 0) {
        return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
      }
      return schema.details.csharp.typeDeclaration = new EnumClass(td, state);
    }

    return td;
  }

  /*
  // const implData: CSharpSchemaDetails = (schema.details.csharp = schema.details.csharp || {});

  // have we done this object already?
  if (schema.details.csharp.typeDeclaration) {
    return schema.details.csharp.typeDeclaration;
  }

  // determine if we need a new model class for the type or just a known type object
  switch (schema.type) {
    case JsonType.Object:
      // for certain, this should be a class of some sort.
      if (schema.additionalProperties && !hasProperties(schema.properties)) {
        if (schema.additionalProperties === true) {
          // the object is a wildcard for all key/object-value pairs
          return schema.details.csharp.typeDeclaration = new UntypedWildcard();
        } else {
          // the object is a wildcard for all key/<specific-type>-value pairs
          const wcSchema = this.resolveTypeDeclaration(schema.additionalProperties, false, state.path("additionalProperties"));
          return schema.details.csharp.typeDeclaration = new Wildcard(wcSchema);
        }
      }

      // otherwise, if it has additionalProperties
      // it's a regular object, that has a catch-all for unspecified properties.
      // (handled in ModelClass itself)
      const mc = schema.details.csharp.classImplementation || new ModelClass(this, new SchemaObject(schema), this.state);
      return schema.details.csharp.typeDeclaration = <ModelInterface>schema.details.csharp.interfaceImplementation;

    case JsonType.String:
      switch (schema.format) {
        case StringFormat.Base64Url:
        case StringFormat.Byte:
          // member should be byte array
          // on wire format should be base64url
          return schema.details.csharp.typeDeclaration = new ByteArray();

        case StringFormat.Binary:
          // represent as a stream
          // wire format is stream of bytes
          throw new Error("Method not implemented.");

        case StringFormat.Char:
          // a single character
          return schema.details.csharp.typeDeclaration = new Char(required, schema.enum.length > 0 ? schema.enum : undefined);

        case StringFormat.Date:
          return schema.details.csharp.typeDeclaration = new Date(required);

        case StringFormat.DateTime:
          return schema.details.csharp.typeDeclaration = new DateTime(required);

        case StringFormat.DateTimeRfc1123:
          return schema.details.csharp.typeDeclaration = new DateTime1123(required);

        case StringFormat.Duration:
          return schema.details.csharp.typeDeclaration = new Duration(required);

        case StringFormat.Uuid:
          return schema.details.csharp.typeDeclaration = new Uuid(required);

        case StringFormat.Password:
        case StringFormat.None:
        case undefined:
        case null:
          if (schema.extensions["x-ms-enum"]) {
            // this value is an enum type instead of a plain string.
            const ec = state.project.supportNamespace.findClassByName(schema.extensions["x-ms-enum"].name);
            if (ec.length > 0) {
              return schema.details.csharp.typeDeclaration = <EnumClass>ec[0];
            }
            return schema.details.csharp.typeDeclaration = new EnumClass(schema, state);
          }

          // just a regular old string.
          return schema.details.csharp.typeDeclaration = new String(required, schema.minLength, schema.maxLength, schema.pattern, schema.enum.length > 0 ? schema.enum : undefined);

        default:
          state.error(`Schema with type:'${schema.type} and 'format:'${schema.format}' is not recognized.`, message.DoesNotSupportEnum);
      }
      break;

    case JsonType.Boolean:
      return schema.details.csharp.typeDeclaration = new Boolean(required);

    case JsonType.Integer:
      switch (schema.format) {
        case IntegerFormat.Int64:
        case IntegerFormat.None:
          return schema.details.csharp.typeDeclaration = new Numeric(required ? 'long' : 'long?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
        case IntegerFormat.UnixTime:
          return schema.details.csharp.typeDeclaration = new UnixTime(required);
        case IntegerFormat.Int32:
          return schema.details.csharp.typeDeclaration = new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
      }
      // fallback to int if the format isn't recognized
      return schema.details.csharp.typeDeclaration = new Numeric(required ? 'int' : 'int?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);

    case JsonType.Number:
      switch (schema.format) {
        case NumberFormat.None:
        case NumberFormat.Double:
          return schema.details.csharp.typeDeclaration = new Numeric(required ? 'double' : 'double?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
        case NumberFormat.Float:
          return schema.details.csharp.typeDeclaration = new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
        case NumberFormat.Decimal:
          return schema.details.csharp.typeDeclaration = new Numeric(required ? 'decimal' : 'decimal?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);
      }
      // fallback to float if the format isn't recognized
      return schema.details.csharp.typeDeclaration = new Numeric(required ? 'float' : 'float?', schema.minimum, schema.exclusiveMinimum, schema.maximum, schema.exclusiveMaximum, schema.multipleOf);

    case JsonType.Array:

      const aSchema = this.resolveTypeDeclaration(<Schema>schema.items, true, state.path("items"));
      return schema.details.csharp.typeDeclaration = new ArrayOf(aSchema, required, schema.minItems, schema.maxItems, schema.uniqueItems);

    case undefined:
      console.error(`schema 'undefined': ${schema.details.csharp.name} `);
      // "any" case
      // this can happen when a model is just an all-of something else. (sub in the other type?)
      break;

    default:
      this.state.error(`Schema is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
      return ModelsNamespace.INVALID;
  }
  return ModelsNamespace.INVALID;
}
*/
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
        console.error(`schema 'undefined': ${schema.details.csharp.name} `);
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

