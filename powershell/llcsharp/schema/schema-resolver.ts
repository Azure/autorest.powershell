/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, ArraySchema, UnixTimeSchema, CodeModel, Schema as NewSchema, StringSchema, BooleanSchema, NumberSchema, ByteArraySchema, DateTimeSchema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, ConstantSchema, ChoiceSchema, DurationSchema, BinarySchema, DateSchema } from '@azure-tools/codemodel';

import { codemodel, IntegerFormat, NumberFormat, StringFormat, JsonType } from '@azure-tools/codemodel-v3';
import { Schema } from '../code-model';
import * as message from '../messages';
import { ArrayOf, NewArrayOf } from './array';
import { Binary, NewBinary } from './binary';
import { Boolean, NewBoolean } from './boolean';
import { ByteArray, NewByteArray } from './byte-array';
import { Char, NewChar } from './char';
import { Date, NewDate } from './date';
import { DateTime, DateTime1123, UnixTime, NewDateTime, NewDateTime1123, NewUnixTime } from './date-time';
import { Duration, NewDuration } from './duration';
import { EnumImplementation, NewEnumImplementation } from './enum';
import { Numeric, NewNumeric } from './integer';
import { ObjectImplementation, NewObjectImplementation } from './object';
import { String, NewString } from './string';
import { Uuid, NewUuid } from './Uuid';
import { EnhancedTypeDeclaration, NewEnhancedTypeDeclaration } from './extended-type-declaration';
import { PwshModel } from '../../utils/PwshModel';
import { ModelState } from '../../utils/model-state';
import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { schemaHasEnum } from '../validations';

export class NewSchemaDefinitionResolver {
  private readonly cache = new Map<string, NewEnhancedTypeDeclaration>();
  private add(schema: NewSchema, value: NewEnhancedTypeDeclaration): NewEnhancedTypeDeclaration {
    this.cache.set(schema.language?.csharp?.fullname || '', value);
    return value;
  }

  resolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: ModelState<PwshModel>): NewEnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case SchemaType.Array: {
        // can be recursive!
        // handle boolean arrays as booleans (powershell will try to turn it into switches!)
        const ar = <ArraySchema>schema;
        const elementType = (ar.elementType.type === SchemaType.Boolean) ? new NewBoolean(<BooleanSchema>schema, true) : this.resolveTypeDeclaration(ar.elementType, true, state.path('items'));
        return new NewArrayOf(schema, required, elementType, ar.minItems, ar.maxItems, ar.uniqueItems);
      }

      case SchemaType.Any:
      case SchemaType.Dictionary:
      case SchemaType.Object: {
        const result = schema.language.csharp && this.cache.get(schema.language.csharp.fullname || '');
        if (result) {
          return result;
        }
        return this.add(schema, new NewObjectImplementation(<ObjectSchema>schema));
      }
      case SchemaType.Time:
      case SchemaType.Credential:
      case SchemaType.String: {
        return new NewString(<StringSchema>schema, required);

      }
      case SchemaType.Binary:
        return new NewBinary(<BinarySchema>schema, required);
      case SchemaType.Duration:
        return new NewDuration(<DurationSchema>schema, required);
      case SchemaType.Uuid:
        return new NewUuid(<StringSchema>schema, required);
      case SchemaType.DateTime:
        if ((<DateTimeSchema>schema).format === StringFormat.DateTimeRfc1123) {
          return new NewDateTime1123(<DateTimeSchema>schema, required);
        }
        return new NewDateTime(<DateTimeSchema>schema, required);
      case SchemaType.Date:
        return new NewDate(<DateSchema>schema, required);
      case SchemaType.ByteArray:
        return new NewByteArray(<ByteArraySchema>schema, required);
      case SchemaType.Boolean:
        return new NewBoolean(<BooleanSchema>schema, required);

      case SchemaType.Integer:
        switch ((<NumberSchema>schema).precision) {
          case 64:
            return new NewNumeric(<NumberSchema>schema, required, required ? 'long' : 'long?');
          // skip-for-time-being
          // case IntegerFormat.UnixTime:
          //   return new UnixTime(schema, required);
          case 16:
          case 32:
            return new NewNumeric(<NumberSchema>schema, required, required ? 'int' : 'int?');
        }
        // fallback to int if the format isn't recognized
        return new NewNumeric(<NumberSchema>schema, required, required ? 'int' : 'int?');

      case SchemaType.UnixTime:
        return new NewUnixTime(<UnixTimeSchema>schema, required);

      case SchemaType.Number:
        switch ((<NumberSchema>schema).precision) {
          case 64:
            return new NewNumeric(<NumberSchema>schema, required, required ? 'double' : 'double?');
          case 32:
            return new NewNumeric(<NumberSchema>schema, required, required ? 'float' : 'float?');
          case 128:
            return new NewNumeric(<NumberSchema>schema, required, required ? 'decimal' : 'decimal?');
        }
        // fallback to float if the format isn't recognized
        return new NewNumeric(<NumberSchema>schema, required, required ? 'float' : 'float?');

      case SchemaType.Constant:
        return this.resolveTypeDeclaration((<ConstantSchema>schema).valueType, required, state);

      case SchemaType.Choice: {
        return this.resolveTypeDeclaration((<ChoiceSchema>schema).choiceType, required, state);
      }
      case SchemaType.SealedChoice:
        if (schema.language.default.skip === true) {
          return new NewString(schema, required);
        }
        return new NewEnumImplementation(schema, required);
      case undefined:
        if (schema.extensions && schema.extensions['x-ms-enum']) {
          return new NewEnumImplementation(<StringSchema>schema, required);
        }

        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

    }
    state.error(`Schema '${schema.language.csharp?.name}' is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
    throw new Error('Unknown Model. Fatal.');
  }
}
