import { Refable as Reference, Dictionary, Optional } from "./common";

// OAI3 variants for the basic model definitions.

/** Nearly all classes can support additional key-value pairs where the key starts with 'x-' */
export interface Extensions {

}

/** Properties, Parameters, Operations and Schemas require additional support */
export interface ImplementationDetails {
}

/** Property References may have additional data that's not in the target reference */
export interface ExtraPropertyDetails {
  description?: string;
}

export interface WithOperations {

}

/** Properties have additional data when referencing them */
export type PropertyReference<T> = ExtraPropertyDetails & (Reference<T>);


// ===================================================================================================================
// code below this point should be identical between oai3.ts and code-model.ts 

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

export type Callback = Dictionary<string>;
export type SecurityRequirement = Dictionary<string>;
export type HTTPSecurityScheme = NonBearerHTTPSecurityScheme | BearerHTTPSecurityScheme;
export type Header = HeaderWithSchema | HeaderWithContent;
export type HeaderWithSchema = HeaderWithSchemaWithExample | HeaderWithSchemaWithExamples;
export type Link = LinkWithOperationRef | LinkWithOperationId;
export type MediaType = MediaTypeWithExample | MediaTypeWithExamples;
export type Parameter = ParameterWithSchema | ParameterWithContent;
export type ParameterWithContent = ParameterWithContentInPath | ParameterWithContentNotInPath;
export type ParameterWithSchema = ParameterWithSchemaWithExample | ParameterWithSchemaWithExamples;
export type ParameterWithSchemaWithExample = ParameterWithSchemaWithExampleInPath | ParameterWithSchemaWithExampleInQuery | ParameterWithSchemaWithExampleInHeader | ParameterWithSchemaWithExampleInCookie;
export type ParameterWithSchemaWithExamples = ParameterWithSchemaWithExamplesInPath | ParameterWithSchemaWithExamplesInQuery | ParameterWithSchemaWithExamplesInHeader | ParameterWithSchemaWithExamplesInCookie;
export type SecurityScheme = APIKeySecurityScheme | HTTPSecurityScheme | OAuth2SecurityScheme | OpenIdConnectSecurityScheme;

export type ParameterLocation = "query" | "header" | "cookie";
export type EncodingStyle = "form" | "spaceDelimited" | "pipeDelimited" | "deepObject";
export type MatrixLabelSimple = "matrix" | "label" | "simple"
export type JsonType = "array" | "boolean" | "integer" | "number" | "object" | "string";

export interface APIKeySecurityScheme extends Extensions {
  type: "apiKey";
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
  scheme: "bearer";
  bearerFormat?: string;
  type: "http";
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
  style?: EncodingStyle;
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
  style?: "simple";
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
  style?: "simple";
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
  type: "http";
}
export interface OAuth2SecurityScheme extends Extensions {
  type: "oauth2";
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
  type: "openIdConnect";
  openIdConnectUrl: string; // url
  description?: string;
}
export interface Operation extends Extensions, ImplementationDetails {
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

export interface ParameterWithContentInPath extends Extensions, ImplementationDetails {
  name: string;
  in: "path";
  description?: string;
  required?: true;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  content: Dictionary<MediaType>;
}
export interface ParameterWithContentNotInPath extends Extensions, ImplementationDetails {
  name: string;
  in: ParameterLocation;
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  content: Dictionary<MediaType>;
}
export interface ParameterWithSchemaWithExampleInCookie extends Extensions, ImplementationDetails {
  name: string;
  in: "cookie";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: "form";
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInHeader extends Extensions, ImplementationDetails {
  name: string;
  in: "header";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: "simple";
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInPath extends Extensions, ImplementationDetails {
  name: string;
  in: "path";
  description?: string;
  required: true;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: MatrixLabelSimple;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  example?: any;
}
export interface ParameterWithSchemaWithExampleInQuery extends Extensions, ImplementationDetails {
  name: string;
  in: "query";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: EncodingStyle;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  example?: any;
}

export interface ParameterWithSchemaWithExamplesInCookie extends Extensions, ImplementationDetails {
  name: string;
  in: "cookie";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: "form";
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInHeader extends Extensions, ImplementationDetails {
  name: string;
  in: "header";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: "simple";
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInPath extends Extensions, ImplementationDetails {
  name: string;
  in: "path";
  description?: string;
  required: true;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: MatrixLabelSimple;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
  examples: Dictionary<Reference<Example>>;
}
export interface ParameterWithSchemaWithExamplesInQuery extends Extensions, ImplementationDetails {
  name: string;
  in: "query";
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  style?: EncodingStyle;
  explode?: boolean;
  allowReserved?: boolean;
  schema: Reference<Schema>;
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
export interface Schema extends Extensions, ImplementationDetails {
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
