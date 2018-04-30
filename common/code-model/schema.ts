import { Dictionary } from "#common/dictionary";
import { Details, ExternalDocumentation } from "#common/code-model/components";
import { Extensions } from "#common/code-model/extensions";

export interface PropertyDetails extends Details {
  required: boolean;
}

export interface EnumValue {
  value: any,
  description: string,
  name: string
}

export interface EnumDetails {
  modelAsString: boolean;
  values: Array<EnumValue>;
  name: string
}

export interface SchemaDetails extends Details {
  enum?: EnumDetails;
}

export class Schema extends Extensions implements Schema {
  details: SchemaDetails;
  required = new Array<string>();
  enum = new Array<any>();
  allOf = new Array<Schema>();
  oneOf = new Array<Schema>();
  anyOf = new Array<Schema>();
  properties = new Dictionary<Property<Schema>>();
  extensions = new Dictionary<any>();

  constructor(name: string, initializer?: Partial<Schema>) {
    super();
    this.details = { name: name };
    this.apply(initializer);
  }
}

export interface Property<T> extends Extensions {
  details: PropertyDetails;

  /** description can be on the property reference, so that properties can have a description different from the type description. */
  description?: string;

  schema: Schema;
}

export class Property<T> extends Extensions implements Property<T> {
  details: PropertyDetails;
  extensions = new Dictionary<any>();

  constructor(name: string, initializer?: Partial<Property<T>>) {
    super();
    this.details = {
      name: name,
      required: false
    }
    this.apply(initializer);
  }
}

export class Discriminator extends Extensions implements Discriminator {
  extensions = new Dictionary<any>();
  mapping = new Dictionary<string>();

  constructor(public propertyName: string, initializer?: Partial<Discriminator>) {
    super();
    this.apply(initializer);
  }
}

export interface Discriminator extends Extensions {
  propertyName: string;
  mapping: Dictionary<string>
}

export enum JsonType {
  Array = "array",
  Boolean = "boolean",
  Integer = "integer",
  Number = "number",
  Object = "object",
  String = "string"
}

export class XML extends Extensions implements XML {
  extensions = new Dictionary<any>();
  attribute = false;
  wrapped = false;

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

  details: SchemaDetails;

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
  properties: Dictionary<Property<Schema>>;
  additionalProperties?: boolean | Schema;
}