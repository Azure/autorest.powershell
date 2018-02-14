import { Refable as Reference, Dictionary, Optional } from "./common";

// OAI3 variants for the basic model definitions.

/** Nearly all classes can support additional key-value pairs where the key starts with 'x-' */
export interface Extensions {
  [key: string]: any;
}

/** Properties, Parameters, Operations and Schemas require additional support */
export interface Implementation<T> {
}

export interface Details {
}

/** Property References may have additional data that's not in the target reference */
export interface PropertyDetails extends Details, Extensions {
  description?: string;
}

export interface ParameterDetails extends Details {
}

export interface SchemaDetails extends Details {
}

export interface OperationDetails extends Details {
}

export interface WithOperations {

}

/** Properties have additional data when referencing them */
export type PropertyReference<T> = PropertyDetails & (Reference<T>);

// ===================================================================================================================
// code below this point should be identical between oai3.ts and code-model.ts 


/**
 * @description The location of the parameter.
 * 
 * @see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.1.md#user-content-parameterIn
 */
export enum ParameterLocation {
  Query = "query",
  Header = "header",
  Cookie = "cookie",
  Path = "path",
}

/**
 * @description common ways of serializing simple parameters
 * @see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.1.md#style-values
 */
export enum EncodingStyle {
  Matrix = "matrix",
  Label = "label",
  Simple = "simple",
  Form = "form",
  SpaceDelimited = "spaceDelimited",
  PipeDelimited = "pipeDelimited",
  DeepObject = "deepObject"
}

export enum JsonType {
  Array = "array",
  Boolean = "boolean",
  Integer = "integer",
  Number = "number",
  Object = "object",
  String = "string"
}
export enum Scheme {
  Bearer = "bearer"
}
export enum SecurityType {
  ApiKey = "apiKey",
  Http = "http",
  OAuth2 = "oauth2",
  OpenIDConnect = "openIdConnect"
}

export type Callback = Dictionary<string>;
export type SecurityRequirement = Dictionary<string>;
export type HTTPSecurityScheme = NonBearerHTTPSecurityScheme | BearerHTTPSecurityScheme;
export type Header = HeaderWithSchema | HeaderWithContent;
export type HeaderWithSchema = HeaderWithSchemaWithExample | HeaderWithSchemaWithExamples;
export type Link = LinkWithOperationRef | LinkWithOperationId;
export type MediaType = MediaTypeWithExample | MediaTypeWithExamples;

export type Parameter = ParameterWithSchemaWithExample | ParameterWithSchemaWithExamples | ParameterWithContent;
export type ParameterWithSchemaWithExample = ParameterWithSchemaWithExampleInPath | ParameterWithSchemaWithExampleInQuery | ParameterWithSchemaWithExampleInHeader | ParameterWithSchemaWithExampleInCookie;
export type ParameterWithSchemaWithExamples = ParameterWithSchemaWithExamplesInPath | ParameterWithSchemaWithExamplesInQuery | ParameterWithSchemaWithExamplesInHeader | ParameterWithSchemaWithExamplesInCookie;

export type SecurityScheme = APIKeySecurityScheme | HTTPSecurityScheme | OAuth2SecurityScheme | OpenIdConnectSecurityScheme;

export type QueryEncodingStyle = EncodingStyle.Form | EncodingStyle.SpaceDelimited | EncodingStyle.PipeDelimited | EncodingStyle.DeepObject;
export type PathEncodingStyle = EncodingStyle.Matrix | EncodingStyle.Label | EncodingStyle.Simple;

export interface Model extends Extensions {
  paths: Dictionary<PathItem>;
  openApi: string;
  info: Info;
  externalDocs?: ExternalDocumentation;
  servers: Optional<Array<Server>>;
  security: Optional<Array<SecurityRequirement>>;
  tags: Optional<Array<Tag>>;
  components: Optional<Components>;
}

export interface Components extends Extensions, WithOperations {
  schemas: Optional<Dictionary<Reference<Schema>>>;
  responses: Optional<Dictionary<Reference<Response>>>
  parameters: Optional<Dictionary<Reference<Parameter>>>;
  examples: Optional<Dictionary<Reference<Example>>>;
  requestBodies: Optional<Dictionary<Reference<RequestBody>>>;
  headers: Optional<Dictionary<Reference<Header>>>;
  securitySchemes: Optional<Dictionary<Reference<SecurityScheme>>>;
  links: Optional<Dictionary<Reference<Link>>>;
  callbacks: Optional<Dictionary<Reference<Callback>>>;
}

export interface APIKeySecurityScheme extends Extensions {
  type: SecurityType.ApiKey;
  name: string;
  in: ParameterLocation;
  description?: string;
}
export interface AuthorizationCodeOAuthFlow extends Extensions {
  authorizationUrl: string; // uriref
  tokenUrl: string; // uriref
  refreshUrl?: string; // uriref
  scopes: Optional<Dictionary<string>>;
}
export interface BearerHTTPSecurityScheme extends Extensions {
  scheme: Scheme.Bearer;
  bearerFormat?: string;
  type: SecurityType.Http;
  description?: string;
}
export interface ClientCredentialsFlow extends Extensions {
  tokenUrl: string; // uriref
  refreshUrl?: string; // uriref
  scopes: Optional<Dictionary<string>>;
}

export interface Contact extends Extensions {
  name?: string;
  url?: string; // uriref
  email?: string; // email
}
export interface Discriminator extends Extensions {
  propertyName: string;
  mapping: Optional<Dictionary<string>>
}
export interface Encoding extends Extensions {
  contentType?: string;
  headers: Optional<Dictionary<Header>>;
  style?: QueryEncodingStyle;
  explode?: boolean;
  allowReserved?: boolean;
}
export interface Example extends Extensions {
  summary?: string;
  description?: string;
  value?: any;
  externalValue?: string; // uriref
}
export interface ExternalDocumentation extends Extensions {
  description?: string;
  url: string; // uriref
}

export interface HeaderWithContent extends Extensions {
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  content: Dictionary<MediaType>;
}

export interface HeaderWithSchemaWithExample extends Extensions {
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: EncodingStyle.Simple;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  example?: any;
}
export interface HeaderWithSchemaWithExamples extends Extensions {
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: EncodingStyle.Simple;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  examples: Dictionary<Reference<Example>>
}
export interface ImplicitOAuthFlow extends Extensions {
  authorizationUrl: string; // uriref
  refreshUrl?: string; // uriref
  scopes: Dictionary<string>
}
export interface Info extends Extensions {
  title: string;
  description?: string;
  termsOfService?: string; // uriref
  contact?: Contact;
  license?: License;
  version: string;
}
export interface License extends Extensions {
  name: string;
  url?: string; // uriref
}

export interface LinkWithOperationId extends Extensions {
  operationId?: string;
  parameters: Optional<Dictionary<string>>;
  requestBody?: any;
  description?: string;
  server?: Server;
}
export interface LinkWithOperationRef extends Extensions {
  operationRef?: string; // uriref
  parameters: Optional<Dictionary<string>>;
  requestBody?: any;
  description?: string;
  server?: Server;
}

export interface MediaTypeWithExample extends Extensions {
  schema?: Reference<Schema>;
  example?: any;
  encoding: Optional<Dictionary<Encoding>>;
}
export interface MediaTypeWithExamples extends Extensions {
  schema?: Reference<Schema>;
  examples: Dictionary<Reference<Example>>;
  encoding: Optional<Dictionary<Encoding>>;
}
export interface NonBearerHTTPSecurityScheme extends Extensions {
  scheme: string;
  description?: string;
  type: SecurityType.Http;
}
export interface OAuth2SecurityScheme extends Extensions {
  type: SecurityType.OAuth2;
  flows: OAuthFlows;
  description?: string;
}
export interface OAuthFlows extends Extensions {
  implicit?: ImplicitOAuthFlow;
  password?: PasswordOAuthFlow;
  clientCredentials?: ClientCredentialsFlow;
  authorizationCode?: AuthorizationCodeOAuthFlow;
}
export interface OpenIdConnectSecurityScheme extends Extensions {
  type: SecurityType.OpenIDConnect;
  openIdConnectUrl: string; // url
  description?: string;
}
export interface Operation extends Extensions, Implementation<OperationDetails> {
  tags: Optional<Array<string>>;
  summary?: string;
  description?: string;
  externalDocs?: ExternalDocumentation;
  operationId?: string;
  parameters: Optional<Array<Reference<Parameter>>>;
  requestBody?: Reference<RequestBody>;
  responses: Responses;
  callbacks: Optional<Dictionary<Reference<Callback>>>;
  deprecated?: boolean;
  security: Optional<Array<SecurityRequirement>>;
  servers: Optional<Array<Server>>;
}

export interface ParameterCommon extends Implementation<ParameterDetails>, Extensions {
  name: string;
  description?: string;
  allowEmptyValue?: boolean;
  deprecated?: boolean;
  required?: boolean;
}
export interface ParameterWithSchema extends ParameterCommon {
  schema: Reference<Schema>;
  explode?: boolean;
  allowReserved?: boolean;
}
export interface ParameterWithContent extends ParameterCommon {
  in: ParameterLocation;
  content: Dictionary<MediaType>;
}
export interface ParameterWithSchemaWithExampleInCookie extends ParameterWithSchema {
  in: ParameterLocation.Cookie;
  style?: EncodingStyle.Form;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInHeader extends ParameterWithSchema {
  in: ParameterLocation.Header;
  style?: EncodingStyle.Simple;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInPath extends ParameterWithSchema {
  in: ParameterLocation.Path;
  style?: PathEncodingStyle;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInQuery extends ParameterWithSchema {
  in: ParameterLocation.Query;
  style?: QueryEncodingStyle;
  example?: any;
}
export interface ParameterWithSchemaWithExamplesInCookie extends ParameterWithSchema {
  in: ParameterLocation.Cookie;
  style?: EncodingStyle.Form;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInHeader extends ParameterWithSchema {
  in: ParameterLocation.Header;
  style?: EncodingStyle.Simple;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInPath extends ParameterWithSchema {
  in: ParameterLocation.Path;
  style?: PathEncodingStyle;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInQuery extends ParameterWithSchema {
  in: ParameterLocation.Query;
  style?: QueryEncodingStyle;
  examples: Dictionary<Reference<Example>>;
}

export interface PasswordOAuthFlow extends Extensions {
  tokenUrl: string; // uriref
  refreshUrl?: string; // uriref
  scopes: Optional<Dictionary<string>>;
}
export interface PathItem extends Extensions {
  $ref?: string | PathItem;
  summary?: string;
  description?: string;
  get?: Operation;
  put?: Operation;
  post?: Operation;
  delete?: Operation;
  options?: Operation;
  head?: Operation;
  patch?: Operation;
  trace?: Operation;
  servers: Optional<Array<Server>>;
  parameters: Optional<Array<Reference<Parameter>>>;
}

export interface RequestBody extends Extensions {
  description?: string;
  content: Dictionary<MediaType>;
  required?: boolean;
}
export interface Response extends Extensions {
  description: string;
  headers?: any;
  content: Optional<Dictionary<MediaType>>;
  links: Optional<Dictionary<Reference<Link>>>;
}
export interface Responses extends Extensions {
  default?: Reference<Response>;
}
export interface Schema extends Extensions, Implementation<SchemaDetails> {
  /* common properties */
  type?: JsonType;
  title?: string;
  description?: string;
  format?: string;
  nullable: Optional<boolean>;
  readOnly: Optional<boolean>;
  writeOnly: Optional<boolean>;
  deprecated: Optional<boolean>;
  required: Optional<Array<string>>;

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
  enum: Optional<Array<any>>;

  /* properties with potential references */
  not?: Reference<Schema>;
  allOf: Optional<Array<Reference<Schema>>>;
  oneOf: Optional<Array<Reference<Schema>>>;
  anyOf: Optional<Array<Reference<Schema>>>;
  items?: Reference<Schema>;
  properties: Optional<Dictionary<PropertyReference<Schema>>>;
  additionalProperties?: boolean | Reference<Schema>;
}

export interface Server extends Extensions {
  url: string;
  description?: string;
  variables: Optional<Dictionary<ServerVariable>>;
}
export interface ServerVariable extends Extensions {
  enum: Optional<Array<string>>;
  default: string;
  description?: string;
}
export interface Tag extends Extensions {
  name: string;
  description?: string;
  externalDocs?: ExternalDocumentation;
}
export interface XML extends Extensions {
  name?: string;
  namespace?: string; // url
  prefix?: string;
  attribute?: boolean;
  wrapped?: boolean;
}
