import { Dictionary, Reference, NotOptional as Optional } from "./common";


//------------------------------------------------------------------------------------------------------------------ */
// Constructors for Code Model classes
//------------------------------------------------------------------------------------------------------------------ */

/**
 * class implementation for all CodeModel classes
 * 
 * Initializes the extensions dictionary and implements the Partial Object Initializer.
 */
export class Initializer<T> {
  extensions = new Dictionary<any>();
  constructor(initializer?: Partial<T>) {
    Object.assign(this, initializer);
  }
}

export class Model extends Initializer<Model> implements Model {
  info: Info;
  openApi = "3.0";
  paths = new Dictionary<PathItem>();
  components = new Components();
  tags = new Array<Tag>();
  servers = new Array<Server>();
  security = new Array<SecurityRequirement>();
  constructor(title: string, version: string, initializer?: Partial<Model>) {
    super(initializer);
    this.info = new Info(title, version, initializer ? initializer.info : {})
  }
}


export class Schema extends Initializer<Schema> implements Schema {
  required = new Array<string>();
  enum = new Array<any>();
  allOf = new Array<Reference<Schema>>();
  oneOf = new Array<Reference<Schema>>();
  anyOf = new Array<Reference<Schema>>();
  properties = new Dictionary<PropertyReference<Schema>>();

  constructor(initializer?: Partial<Schema>) {
    super(initializer);
  }
}

export class Components extends Initializer<Components> implements Components {
  schemas = new Dictionary<Reference<Schema>>();
  responses = new Dictionary<Reference<Response>>();
  parameters = new Dictionary<Reference<Parameter>>();
  examples = new Dictionary<Reference<Example>>();
  requestBodies = new Dictionary<Reference<RequestBody>>();
  headers = new Dictionary<Reference<Header>>();
  securitySchemes = new Dictionary<Reference<SecurityScheme>>();
  links = new Dictionary<Reference<Link>>();
  callbacks = new Dictionary<Reference<Callback>>();
  operations = new Dictionary<Reference<Operation>>()

  constructor(initializer?: Partial<Schema>) {
    super(initializer);
  }
}


export interface WithOperations {
  /**
  * Dictionary of Operations in this model.
  * 
  * This is intended to invert the original PathItems in the OAI model, and focus on operations, not endpoints.
  */
  operations: Dictionary<Reference<Operation>>;
}

export interface Extensions {
  /** additional metadata extensions */
  extensions: Dictionary<any>;
}

export interface ImplementationDetails {
  details: Details;
}

export interface Details {
  /** name used in actual implementation */
  name: string;

  /** the container (ie, class) where this is contained */
  container: string;

  /** namespace of the implementation of this item */
  namespace: string;

  /** description text */
  description: string;

  /** message used to go along with deprecation */
  deprecationMessage: string;
}

/** Properties have additional data when referencing them */
export interface PropertyReference<T> extends Reference<T>, ImplementationDetails {
  /** description can be on the property reference, so that properties can have a description different from the type description. */
  description?: string;
}

function isReference<T>(item: Reference<T> | T): item is Reference<T> {
  return (<Reference<T>>item).$ref ? true : false;
}
export class APIKeySecurityScheme extends Initializer<APIKeySecurityScheme> implements APIKeySecurityScheme {
  constructor(public name: string, public inWhere: ParameterLocation, initializer?: Partial<APIKeySecurityScheme>) {
    super(initializer);
    this.in = inWhere;
    this.type = "apiKey";
  }
}
export class AuthorizationCodeOAuthFlow extends Initializer<AuthorizationCodeOAuthFlow> implements AuthorizationCodeOAuthFlow {
  constructor(public authorizationUrl: string, public tokenUrl: string, initializer?: Partial<AuthorizationCodeOAuthFlow>) {
    super(initializer);
  }
  scopes = new Dictionary<string>();
}
export class BearerHTTPSecurityScheme extends Initializer<BearerHTTPSecurityScheme> implements BearerHTTPSecurityScheme {
  constructor(initializer?: Partial<BearerHTTPSecurityScheme>) {
    super(initializer);
    this.scheme = "bearer";
    this.type = "http";
  }


}
export class ClientCredentialsFlow extends Initializer<ClientCredentialsFlow> implements ClientCredentialsFlow {
  constructor(public tokenUrl: string, initializer?: Partial<ClientCredentialsFlow>) {
    super(initializer);
  }
  scopes = new Dictionary<string>();
}

export class Contact extends Initializer<Contact> implements Contact {
  constructor(initializer?: Partial<Contact>) {
    super(initializer);
  }
}

export class Discriminator extends Initializer<Discriminator> implements Discriminator {
  constructor(public propertyName: string, initializer?: Partial<Discriminator>) {
    super(initializer);
  }
  mapping = new Dictionary<string>();
}
export class Encoding extends Initializer<Encoding> implements Encoding {
  constructor(initializer?: Partial<Encoding>) {
    super(initializer);
  }
  headers = new Dictionary<Header>();
}

export class Example extends Initializer<Example> implements Example {
  constructor(initializer?: Partial<Example>) {
    super(initializer);
  }
}
export class ExternalDocumentation extends Initializer<ExternalDocumentation> implements ExternalDocumentation {
  constructor(public url: string, initializer?: Partial<ExternalDocumentation>) {
    super(initializer);
  }
}

export class HeaderWithContent extends Initializer<HeaderWithContent> implements HeaderWithContent {
  constructor(initializer?: Partial<HeaderWithContent>) {
    super(initializer);
  }
  content = new Dictionary<MediaType>();
}

export class HeaderWithSchemaWithExample extends Initializer<HeaderWithSchemaWithExample> implements HeaderWithSchemaWithExample {
  constructor(schema: Schema | Reference<Schema>, initializer?: Partial<HeaderWithSchemaWithExample>) {
    super(initializer);
  }
}
export class HeaderWithSchemaWithExamples extends Initializer<HeaderWithSchemaWithExamples> implements HeaderWithSchemaWithExamples {
  constructor(schema: Schema | Reference<Schema>, initializer?: Partial<HeaderWithSchemaWithExamples>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
  }
}
export class ImplicitOAuthFlow extends Initializer<ImplicitOAuthFlow> implements ImplicitOAuthFlow {
  constructor(public authorizationUrl: string, initializer?: Partial<ImplicitOAuthFlow>) {
    super(initializer);
  }
  scopes = new Dictionary<string>();
}
export class Info extends Initializer<Info> implements Info {
  constructor(public title: string, public version: string, initializer?: Partial<Info>) {
    super(initializer);
  }
}
export class License extends Initializer<License> implements License {
  constructor(public name: string, initializer?: Partial<License>) {
    super(initializer);
  }
}

export class LinkWithOperationId extends Initializer<LinkWithOperationId> implements LinkWithOperationId {
  constructor(initializer?: Partial<LinkWithOperationId>) {
    super(initializer);
  }
  parameters = new Dictionary<string>();
}
export class LinkWithOperationRef extends Initializer<LinkWithOperationRef> implements LinkWithOperationRef {
  constructor(initializer?: Partial<LinkWithOperationRef>) {
    super(initializer);
  }
  parameters = new Dictionary<string>();
}

export class MediaTypeWithExample extends Initializer<MediaTypeWithExample> implements MediaTypeWithExample {
  constructor(initializer?: Partial<MediaTypeWithExample>) {
    super(initializer);
  }
  encoding = new Dictionary<Encoding>();
}
export class MediaTypeWithExamples extends Initializer<MediaTypeWithExamples> implements MediaTypeWithExamples {
  constructor(initializer?: Partial<MediaTypeWithExamples>) {
    super(initializer);
  }
  examples = new Dictionary<Reference<Example>>();
  encoding = new Dictionary<Encoding>();
}
export class NonBearerHTTPSecurityScheme extends Initializer<NonBearerHTTPSecurityScheme> implements NonBearerHTTPSecurityScheme {
  constructor(public scheme: string, initializer?: Partial<NonBearerHTTPSecurityScheme>) {
    super(initializer);
    this.type = "http";
  }
}
export class OAuth2SecurityScheme extends Initializer<OAuth2SecurityScheme> implements OAuth2SecurityScheme {
  constructor(public flows: OAuthFlows, initializer?: Partial<OAuth2SecurityScheme>) {
    super(initializer);
    this.type = "oauth2";
  }

}
export class OAuthFlows extends Initializer<OAuthFlows> implements OAuthFlows {
  constructor(initializer?: Partial<OAuthFlows>) {
    super(initializer);
  }
}
export class OpenIdConnectSecurityScheme extends Initializer<OpenIdConnectSecurityScheme> implements OpenIdConnectSecurityScheme {
  constructor(public openIdConnectUrl: string, initializer?: Partial<OpenIdConnectSecurityScheme>) {
    super(initializer);
    this.type = "openIdConnect";
  }
}
export class Operation extends Initializer<Operation> implements Operation {
  constructor(initializer?: Partial<Operation>) {
    super(initializer);
  }
  tags = new Array<string>();
  parameters = new Array<Reference<Parameter>>();
  responses = new Responses();
  callbacks = new Dictionary<Reference<Callback>>();
  security = new Array<SecurityRequirement>();
  servers = new Array<Server>();
}

export class ParameterWithContentInPath extends Initializer<ParameterWithContentInPath> implements ParameterWithContentInPath {
  constructor(public name: string, initializer?: Partial<ParameterWithContentInPath>) {
    super(initializer);
    this.in = "path";
  }
  content = new Dictionary<MediaType>();
}
export class ParameterWithContentNotInPath extends Initializer<ParameterWithContentNotInPath> implements ParameterWithContentNotInPath {
  constructor(public name: string, inWhere: ParameterLocation, initializer?: Partial<ParameterWithContentNotInPath>) {
    super(initializer);
    this.in = inWhere;
  }
  content = new Dictionary<MediaType>();
}
export class ParameterWithSchemaWithExampleInCookie extends Initializer<ParameterWithSchemaWithExampleInCookie> implements ParameterWithSchemaWithExampleInCookie {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExampleInCookie>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "cookie";
  }
}
export class ParameterWithSchemaWithExampleInHeader extends Initializer<ParameterWithSchemaWithExampleInHeader> implements ParameterWithSchemaWithExampleInHeader {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExampleInHeader>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "header";
  }
}
export class ParameterWithSchemaWithExampleInPath extends Initializer<ParameterWithSchemaWithExampleInPath> implements ParameterWithSchemaWithExampleInPath {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExampleInPath>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "path";
    this.required = true;
  }
}
export class ParameterWithSchemaWithExampleInQuery extends Initializer<ParameterWithSchemaWithExampleInQuery> implements ParameterWithSchemaWithExampleInQuery {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExampleInQuery>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "query";
  }
}

export class ParameterWithSchemaWithExamplesInCookie extends Initializer<ParameterWithSchemaWithExamplesInCookie> implements ParameterWithSchemaWithExamplesInCookie {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExamplesInCookie>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "cookie";
  }
  examples = new Dictionary<Reference<Example>>();
}
export class ParameterWithSchemaWithExamplesInHeader extends Initializer<ParameterWithSchemaWithExamplesInHeader> implements ParameterWithSchemaWithExamplesInHeader {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExamplesInHeader>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "header";
  }

  examples = new Dictionary<Reference<Example>>();
}
export class ParameterWithSchemaWithExamplesInPath extends Initializer<ParameterWithSchemaWithExamplesInPath> implements ParameterWithSchemaWithExamplesInPath {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExamplesInPath>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "path";
    this.required = true;
  }
  examples = new Dictionary<Reference<Example>>();
}
export class ParameterWithSchemaWithExamplesInQuery extends Initializer<ParameterWithSchemaWithExamplesInQuery> implements ParameterWithSchemaWithExamplesInQuery {
  constructor(public name: string, schema: Schema | Reference<Schema>, initializer?: Partial<ParameterWithSchemaWithExamplesInQuery>) {
    super(initializer);
    this.schema = isReference(schema) ? schema : new Reference(schema);
    this.in = "query";
  }
  examples = new Dictionary<Reference<Example>>();
}
export class PasswordOAuthFlow extends Initializer<PasswordOAuthFlow> implements PasswordOAuthFlow {
  constructor(public tokenUrl: string, initializer?: Partial<PasswordOAuthFlow>) {
    super(initializer);
  }
  scopes = new Dictionary<string>();
}
export class PathItem extends Initializer<PathItem> implements PathItem {
  constructor(initializer?: Partial<PathItem>) {
    super(initializer);
  }
  //   $ref?: string | PathItem;

  servers = new Array<Server>();
  parameters = new Array<Reference<Parameter>>();
}

export class RequestBody extends Initializer<RequestBody> implements RequestBody {
  constructor(initializer?: Partial<RequestBody>) {
    super(initializer);
  }
  content = new Dictionary<MediaType>();
}
export class Response extends Initializer<Response> implements Response {
  constructor(public description: string, initializer?: Partial<Response>) {
    super(initializer);
  }
  content = new Dictionary<MediaType>();
  links = new Dictionary<Reference<Link>>();
}
export class Responses extends Initializer<Responses> implements Responses {
  constructor(initializer?: Partial<Responses>) {
    super(initializer);
  }
}

export class Server extends Initializer<Server> implements Server {
  constructor(public url: string, initializer?: Partial<Server>) {
    super(initializer);
  }
  variables = new Dictionary<ServerVariable>();
}
export class ServerVariable extends Initializer<ServerVariable> implements ServerVariable {
  constructor(defaultValue: string, initializer?: Partial<ServerVariable>) {
    super(initializer);
    this.default = defaultValue;
  }
  enum = new Array<string>();
}
export class Tag extends Initializer<Tag> implements Tag {
  constructor(public name: string, initializer?: Partial<Tag>) {
    super(initializer);
  }
}
export class XML extends Initializer<XML> implements XML {
  constructor(initializer?: Partial<XML>) {
    super(initializer);
  }
}

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
