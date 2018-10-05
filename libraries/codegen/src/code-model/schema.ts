/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ExternalDocumentation, ImplementationDetails, LanguageDetails } from './components';
import { Extensions } from './extensions';
import { DeepPartial } from '../initializer';
import { Dictionary, values } from '../linq';

export interface PropertyDetails extends ImplementationDetails {
  required: boolean;
}

export interface EnumValue {
  value: any;
  description: string;
  name: string;
}

export interface EnumDetails {
  modelAsString: boolean;
  values: Array<EnumValue>;
  name: string;
}

export enum Purpose {
  Header = 'Header',
}

export interface SchemaDetails extends ImplementationDetails {
  /** namespace of the implementation of this item */
  namespace?: string;

  enum?: EnumDetails;
  purpose?: Purpose;
}

export class Schema extends Extensions implements Schema {
  public details: LanguageDetails<SchemaDetails>;
  public required = new Array<string>();
  public enum = new Array<any>();
  public allOf = new Array<Schema>();
  public oneOf = new Array<Schema>();
  public anyOf = new Array<Schema>();
  public properties = new Dictionary<Property>();
  public extensions = new Dictionary<any>();

  constructor(name: string, initializer?: DeepPartial<Schema>) {
    super();
    this.details = {
      default: {
        description: '',
        name
      }
    };
    this.apply(initializer);
  }
}

export function getPolymorphicBases(schema: Schema): Array<Schema> {
  // are any of my parents polymorphic directly, or any of their parents?
  return [...values(schema.allOf).linq.where(parent => parent.discriminator ? true : false), ...values(schema.allOf).linq.selectMany(getPolymorphicBases)];
}

export function getAllProperties(schema: Schema): Array<Property> {
  return [...values(schema.allOf).linq.selectMany(getAllProperties), ...values(schema.properties)];
}

export interface Property extends Extensions {
  details: LanguageDetails<PropertyDetails>;

  /** description can be on the property reference, so that properties can have a description different from the type description. */
  description?: string;

  schema: Schema;
}

export class Property extends Extensions implements Property {
  public serializedName: string;
  public details: LanguageDetails<PropertyDetails>;
  public extensions = new Dictionary<any>();

  constructor(name: string, initializer?: Partial<Property>) {
    super();
    this.serializedName = name;
    this.details = {
      default: {
        description: 'MISSING DESCRIPTION 03',
        name,
        required: false
      }
    };
    this.apply(initializer);
  }
}

export class Discriminator extends Extensions implements Discriminator {
  public extensions = new Dictionary<any>();
  public mapping = new Dictionary<string>();

  constructor(public propertyName: string, initializer?: Partial<Discriminator>) {
    super();
    this.apply(initializer);
  }
}

export interface Discriminator extends Extensions {
  propertyName: string;
  mapping: Dictionary<string>;
}

export enum JsonType {
  Array = 'array',
  Boolean = 'boolean',
  Integer = 'integer',
  Number = 'number',
  Object = 'object',
  String = 'string'
}

export function isJsonType(type: JsonType, schema?: Schema): schema is Schema {
  return schema ? schema.type === type : false;
}

export function isSchemaObject(schema?: Schema): schema is Schema {
  return isJsonType(JsonType.Object, schema);
}

export class XML extends Extensions implements XML {
  public extensions = new Dictionary<any>();
  public attribute = false;
  public wrapped = false;

  constructor(initializer?: Partial<XML>) {
    super();
    this.apply(initializer);
  }
}

export interface XML extends Extensions {
  name?: string;
  namespace?: string; // url
  prefix?: string;
  attribute: boolean;
  wrapped: boolean;
}

export interface Schema extends Extensions {

  details: LanguageDetails<SchemaDetails>;

  /* common properties */
  type?: JsonType;
  title?: string;
  description?: string;
  format?: string;
  nullable: boolean;
  readOnly: boolean;
  writeOnly: boolean;
  deprecated: boolean;
  required: Array<string>;

  /* number restrictions */
  multipleOf?: number;
  maximum?: number;
  exclusiveMaximum?: boolean;
  minimum?: number;
  exclusiveMinimum?: boolean;

  /* string restrictions */
  maxLength?: number;
  minLength?: number;
  pattern?: string; // regex

  /* array restrictions */
  maxItems?: number;
  minItems?: number;
  uniqueItems?: boolean;

  /* object restrictions */
  maxProperties?: number;
  minProperties?: number;

  /* unbounded properties */
  example?: any;
  default?: any;

  /* Properties that are objects */
  discriminator?: Discriminator;
  externalDocs?: ExternalDocumentation;
  xml?: XML;

  /* Properties that are collections of things that are not references */
  enum: Array<any>;

  /* properties with potential references */
  not?: Schema;
  allOf: Array<Schema>;
  oneOf: Array<Schema>;
  anyOf: Array<Schema>;
  items?: Schema;
  properties: Dictionary<Property>;
  additionalProperties?: boolean | Schema;
}
