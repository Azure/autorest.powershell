/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codeModelSchema, CredentialSchema, ArraySchema, UnixTimeSchema, CodeModel, Schema as NewSchema, StringSchema, BooleanSchema, NumberSchema, ByteArraySchema, DateTimeSchema, ObjectSchema, GroupSchema, isObjectSchema, SchemaType, GroupProperty, ParameterLocation, Operation, Parameter, VirtualParameter, getAllProperties, ImplementationLocation, OperationGroup, Request, SchemaContext, ConstantSchema, ChoiceSchema, DurationSchema, BinarySchema, DateSchema } from '@azure-tools/codemodel';

import { codemodel, IntegerFormat, NumberFormat, StringFormat, JsonType } from '@azure-tools/codemodel-v3';
import { Schema } from '../code-model';
import * as message from '../messages';
import { ArrayOf } from './array';
import { Binary } from './binary';
import { Boolean } from './boolean';
import { ByteArray } from './byte-array';
import { FixedArrayOf } from './fixed-array';
import { Char } from './char';
import { Date } from './date';
import { DateTime, DateTime1123, UnixTime } from './date-time';
import { Duration } from './duration';
import { EnumImplementation } from './enum';
import { Numeric } from './integer';
import { ObjectImplementation } from './object';
import { String } from './string';
import { Uri } from './uri';
import { Uuid } from './Uuid';
import { EnhancedTypeDeclaration } from './extended-type-declaration';
import { PwshModel } from '../../utils/PwshModel';
import { ModelState } from '../../utils/model-state';
import { Channel, Host, Session, startSession } from '@azure-tools/autorest-extension-base';
import { schemaHasEnum } from '../validations';
import { Password } from './password';

export class SchemaDefinitionResolver {
  private readonly cache = new Map<string, EnhancedTypeDeclaration>();
  private add(schema: NewSchema, value: EnhancedTypeDeclaration): EnhancedTypeDeclaration {
    this.cache.set(schema.language?.csharp?.fullname || '', value);
    return value;
  }

  // isFixedArray is used to determine if we want to use a fixed array or not
  resolveTypeDeclaration(schema: NewSchema | undefined, required: boolean, state: ModelState<CodeModel>, isFixedArray?: boolean): EnhancedTypeDeclaration {
    if (!schema) {
      throw new Error('SCHEMA MISSING?');
    }

    // determine if we need a new model class for the type or just a known type object
    switch (schema.type) {
      case SchemaType.Array: {
        // can be recursive!
        // handle boolean arrays as booleans (powershell will try to turn it into switches!)
        const ar = <ArraySchema>schema;
        const elementType = (ar.elementType.type === SchemaType.Boolean) ? new Boolean(<BooleanSchema>schema, true) : this.resolveTypeDeclaration(ar.elementType, true, state.path('items'));
        if (isFixedArray) {
          return new FixedArrayOf(schema, required, elementType, ar.minItems, ar.maxItems, ar.uniqueItems);
        } else {
          return new ArrayOf(schema, required, elementType, ar.minItems, ar.maxItems, ar.uniqueItems);
        }
      }

      case SchemaType.Any:
      case SchemaType.Dictionary:
      case SchemaType.Object: {
        const result = schema.language.csharp && this.cache.get(schema.language.csharp.fullname || '');
        if (result) {
          return result;
        }
        return this.add(schema, new ObjectImplementation(<ObjectSchema>schema));
      }
      case SchemaType.Time:
      case SchemaType.String: {
        return new String(<StringSchema>schema, required);

      }
      case SchemaType.Credential: {
        return new Password(<CredentialSchema>schema, required);
      }
      case SchemaType.Binary:
        return new Binary(<BinarySchema>schema, required);
      case SchemaType.Duration:
        return new Duration(<DurationSchema>schema, required);
      case SchemaType.Uri:
        return new Uri(<StringSchema>schema, required);
      case SchemaType.Uuid:
        return new Uuid(<StringSchema>schema, required);
      case SchemaType.DateTime:
        if ((<DateTimeSchema>schema).format === StringFormat.DateTimeRfc1123) {
          return new DateTime1123(<DateTimeSchema>schema, required);
        }
        return new DateTime(<DateTimeSchema>schema, required);
      case SchemaType.Date:
        return new Date(<DateSchema>schema, required);
      case SchemaType.ByteArray:
        return new ByteArray(<ByteArraySchema>schema, required);
      case SchemaType.Boolean:
        return new Boolean(<BooleanSchema>schema, required);

      case SchemaType.Integer:
        switch ((<NumberSchema>schema).precision) {
          case 64:
            return new Numeric(<NumberSchema>schema, required, required ? 'long' : 'long?');
          // skip-for-time-being
          // case IntegerFormat.UnixTime:
          //   return new UnixTime(schema, required);
          case 16:
          case 32:
            return new Numeric(<NumberSchema>schema, required, required ? 'int' : 'int?');
        }
        // fallback to int if the format isn't recognized
        return new Numeric(<NumberSchema>schema, required, required ? 'int' : 'int?');

      case SchemaType.UnixTime:
        return new UnixTime(<UnixTimeSchema>schema, required);

      case SchemaType.Number:
        switch ((<NumberSchema>schema).precision) {
          case 64:
            return new Numeric(<NumberSchema>schema, required, required ? 'double' : 'double?');
          case 32:
            return new Numeric(<NumberSchema>schema, required, required ? 'float' : 'float?');
          case 128:
            return new Numeric(<NumberSchema>schema, required, required ? 'decimal' : 'decimal?');
        }
        // fallback to float if the format isn't recognized
        return new Numeric(<NumberSchema>schema, required, required ? 'float' : 'float?');

      case SchemaType.Constant:
        return this.resolveTypeDeclaration((<ConstantSchema>schema).valueType, required, state);

      case SchemaType.Choice:
      case SchemaType.SealedChoice: {
        return this.resolveTypeDeclaration((<ChoiceSchema>schema).choiceType, required, state);
      }
      case undefined:
        if (schema.extensions && schema.extensions['x-ms-enum']) {
          return this.resolveTypeDeclaration((<ChoiceSchema>schema).choiceType, required, state);
        }

        // "any" case
        // this can happen when a model is just an all-of something else. (sub in the other type?)
        break;

    }
    state.error(`Schema '${schema.language.csharp?.name}' is declared with invalid type '${schema.type}'`, message.UnknownJsonType);
    throw new Error('Unknown Model. Fatal.');
  }
}
