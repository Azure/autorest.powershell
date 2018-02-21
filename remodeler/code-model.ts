import { Dictionary, Reference, NotOptional as Optional } from "./common";
import { hasContent } from "./oai3";


//------------------------------------------------------------------------------------------------------------------ */
// Constructors for Code Model classes
//------------------------------------------------------------------------------------------------------------------ */

function getAllPropertyNames(obj: any) {
  const props = new Array<string>();

  do {
    Object.getOwnPropertyNames(obj).forEach(function (prop) {
      if (props.indexOf(prop) === -1) {
        props.push(prop);
      }
    });
  } while (obj = Object.getPrototypeOf(obj));

  return props;
}


function isReference<T>(item: Reference<T> | T): item is Reference<T> {
  return (<Reference<T>>item).$ref ? true : false;
}


/**
 * class implementation for all CodeModel classes
 * 
 * Initializes the extensions dictionary and implements the Partial Object Initializer.
 */
export class Initializer<T> {
  extensions = new Dictionary<any>();
  constructor(initializer?: Partial<T>) {
    if (initializer) {
      for (const i in (<any>initializer)) {
        if ((<any>initializer)[i]) {
          (<any>this)[i] = (<any>initializer)[i]
        };
      }
      // Object.assign(this, initializer);
    }
  }
}

export class Model extends Initializer<Model> implements Model {
  info: Info;
  openApi = "3.0";

  constructor(title: string, version: string, initializer?: Partial<Model>) {
    super(initializer);
    this.info = new Info(title, version, initializer ? initializer.info : {});
    this.paths = (<any>this).paths || new Dictionary<PathItem>();
    this.components = (<any>this).components || new Components();
    this.tags = (<any>this).tags || new Array<Tag>();
    this.servers = (<any>this).servers || new Array<Server>();
    this.security = (<any>this).security || new Array<SecurityRequirement>();
  }
}

export class Schema extends Initializer<Schema> implements Schema {


  constructor(initializer?: Partial<Schema>) {
    super(initializer);
    this.required = (<any>this).required || new Array<string>();
    this.enum = (<any>this).enum || new Array<any>();
    this.allOf = (<any>this).allOf || new Array<Reference<Schema>>();
    this.oneOf = (<any>this).oneOf || new Array<Reference<Schema>>();
    this.anyOf = (<any>this).anyOf || new Array<Reference<Schema>>();
    this.properties = (<any>this).properties || new Dictionary<PropertyReference<Schema>>();
  }
}

export class Components extends Initializer<Components> implements Components {
  constructor(initializer?: Partial<Schema>) {
    super(initializer);
    this.schemas = (<any>this).schemas || new Dictionary<Reference<Schema>>();
    this.responses = (<any>this).responses || new Dictionary<Reference<Response>>();
    this.parameters = (<any>this).parameters || new Dictionary<Reference<Parameter>>();
    this.examples = (<any>this).examples || new Dictionary<Reference<Example>>();
    this.requestBodies = (<any>this).requestBodies || new Dictionary<Reference<RequestBody>>();
    this.headers = (<any>this).headers || new Dictionary<Reference<Header>>();
    this.securitySchemes = (<any>this).securitySchemes || new Dictionary<Reference<SecurityScheme>>();
    this.links = (<any>this).links || new Dictionary<Reference<Link>>();
    this.callbacks = (<any>this).callbacks || new Dictionary<Reference<Callback>>();
    this.operations = (<any>this).operations || new Dictionary<Reference<Operation>>()
  }
}

export type Operation = HttpOperation; //one day ...  | JsonRPCOperation  ...etc

export interface Components {
  /**
  * Dictionary of Operations in this model.
  * 
  * This is intended to invert the original PathItems in the OAI model, and focus on operations, not endpoints.
  */
  operations: Dictionary<Reference<Operation>>;
}

/** In the CodeModel, Extensions are in a separate dictionary */
export interface Extensions {
  /** additional metadata extensions */
  extensions: Dictionary<any>;
}

export interface Implementation<T extends Details> {
  details: T;
}

export interface Details {
  /** name used in actual implementation */
  name?: string;

  /** the container (ie, class) where this is contained */
  container?: string;

  /** namespace of the implementation of this item */
  namespace?: string;

  /** description text */
  description?: string;

  /** message used to go along with deprecation */
  deprecationMessage?: string;

}


export enum ImplementationLocation {
  Method = "Method",
  Client = "Client",
  /** @internal */
  Alias = "Alias"
}


export interface PropertyDetails extends Details {
}

export interface ParameterDetails extends Details {
  location: ImplementationLocation;
}

export interface SchemaDetails extends Details {
}

export interface HttpOperationDetails extends Details {
}

export interface HttpOperation {
  path: string;
  method: HttpMethod;
  pathDescription?: string;
  pathSummary?: string;
  pathExtensions?: Dictionary<any>;
}

export enum HttpMethod {
  Get = "get",
  Put = "put",
  Post = "post",
  Delete = "delete",
  Options = "options",
  Head = "head",
  Patch = "patch",
  Trace = "trace"
}

/** Properties have additional data when referencing them */
export interface PropertyReference<T> extends Reference<T>, Implementation<PropertyDetails>, Extensions {
  /** description can be on the property reference, so that properties can have a description different from the type description. */
  description?: string;
}

export class PropertyReference<T> extends Initializer<PropertyReference<T>> implements PropertyReference<T>  {
  constructor(initializer?: Partial<PropertyReference<T>>) {
    super(initializer);
  }
}

export class APIKeySecurityScheme extends Initializer<APIKeySecurityScheme> implements APIKeySecurityScheme {
  constructor(public name: string, public inWhere: ParameterLocation, initializer?: Partial<APIKeySecurityScheme>) {
    super(initializer);
    this.in = inWhere;
    this.type = SecurityType.ApiKey;
  }
}
export class AuthorizationCodeOAuthFlow extends Initializer<AuthorizationCodeOAuthFlow> implements AuthorizationCodeOAuthFlow {
  constructor(public authorizationUrl: string, public tokenUrl: string, initializer?: Partial<AuthorizationCodeOAuthFlow>) {
    super(initializer);
    this.scopes = (<any>this).scopes || new Dictionary<string>();
  }
}
export class BearerHTTPSecurityScheme extends Initializer<BearerHTTPSecurityScheme> implements BearerHTTPSecurityScheme {
  constructor(initializer?: Partial<BearerHTTPSecurityScheme>) {
    super(initializer);
    this.scheme = Scheme.Bearer;
    this.type = SecurityType.Http;
  }
}
export class ClientCredentialsFlow extends Initializer<ClientCredentialsFlow> implements ClientCredentialsFlow {
  constructor(public tokenUrl: string, initializer?: Partial<ClientCredentialsFlow>) {
    super(initializer);
    this.scopes = (<any>this).scopes || new Dictionary<string>();
  }
}

export class Callback implements Callback {
  constructor() {
  }
}

export class Contact extends Initializer<Contact> implements Contact {
  constructor(initializer?: Partial<Contact>) {
    super(initializer);
  }
}

export class Discriminator extends Initializer<Discriminator> implements Discriminator {
  constructor(public propertyName: string, initializer?: Partial<Discriminator>) {
    super(initializer);
    this.mapping = (<any>this).mapping || new Dictionary<string>();
  }
}
export class Encoding extends Initializer<Encoding> implements Encoding {
  constructor(initializer?: Partial<Encoding>) {
    super(initializer);
    this.headers = (<any>this).headers || new Dictionary<Header>();
  }
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

export class Header extends Initializer<Header> implements Header {
  constructor(initializer?: Partial<Header>) {
    super(initializer);
    this.content = (<any>this).content || new Dictionary<MediaType>();
  }
}

export class ImplicitOAuthFlow extends Initializer<ImplicitOAuthFlow> implements ImplicitOAuthFlow {
  constructor(public authorizationUrl: string, initializer?: Partial<ImplicitOAuthFlow>) {
    super(initializer);
    this.scopes = (<any>this).scopes || new Dictionary<string>();
  }
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

export class Link extends Initializer<Link> implements Link {
  constructor(initializer?: Partial<Link>) {
    super(initializer);
    this.parameters = (<any>this).parameters || new Dictionary<string>();
  }
}


export class MediaType extends Initializer<MediaType> implements MediaType {
  constructor(initializer?: Partial<MediaType>) {
    super(initializer);
    this.encoding = (<any>this).encoding || new Dictionary<Encoding>();
  }
}

export class NonBearerHTTPSecurityScheme extends Initializer<NonBearerHTTPSecurityScheme> implements NonBearerHTTPSecurityScheme {
  constructor(public scheme: string, initializer?: Partial<NonBearerHTTPSecurityScheme>) {
    super(initializer);
    this.type = SecurityType.Http;
  }
}
export class OAuth2SecurityScheme extends Initializer<OAuth2SecurityScheme> implements OAuth2SecurityScheme {
  constructor(public flows: OAuthFlows, initializer?: Partial<OAuth2SecurityScheme>) {
    super(initializer);
    this.type = SecurityType.OAuth2;
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
    this.type = SecurityType.OpenIDConnect;
  }
}

export class HttpOperation extends Initializer<HttpOperation> implements Operation, Implementation<HttpOperationDetails> {
  details: HttpOperationDetails
  constructor(public path: string, public method: HttpMethod, initializer?: Partial<Operation>) {
    super(initializer);
    this.details = (<any>this).details || {};
    this.tags = (<any>this).tags || new Array<string>();
    this.parameters = (<any>this).parameters || new Array<Reference<Parameter>>();
    this.responses = (<any>this).responses || new Dictionary<Reference<Response>>();
    this.callbacks = (<any>this).callbacks || new Dictionary<Reference<Callback>>();
    this.security = (<any>this).security || new Array<SecurityRequirement>();
    this.servers = (<any>this).servers || new Array<Server>();
  }
}

export class Parameter extends Initializer<Parameter> implements Parameter, Implementation<ParameterDetails> {
  details: ParameterDetails;
  constructor(public name: string, public inWhere: ParameterLocation, implementation: ImplementationLocation, initializer?: Partial<Parameter>) {
    super(initializer);
    this.in = inWhere;
    this.details = (<any>this).details || {};
    this.details.location = implementation;
    if (inWhere === ParameterLocation.Path) {
      this.required = true;
    }
  }
}

export class PasswordOAuthFlow extends Initializer<PasswordOAuthFlow> implements PasswordOAuthFlow {
  constructor(public tokenUrl: string, initializer?: Partial<PasswordOAuthFlow>) {
    super(initializer);
    this.scopes = (<any>this).scopes || new Dictionary<string>();
  }

}
export class PathItem extends Initializer<PathItem> implements PathItem {
  constructor(initializer?: Partial<PathItem>) {
    super(initializer);
    this.parameters = (<any>this).parameters || new Array<Reference<Parameter>>();
    this.servers = (<any>this).servers || new Array<Server>();
  }
  //   $ref?: string | PathItem;
}

export class RequestBody extends Initializer<RequestBody> implements RequestBody {
  constructor(initializer?: Partial<RequestBody>) {
    super(initializer);
    this.content = (<any>this).content || new Dictionary<MediaType>();
  }
}
export class Response extends Initializer<Response> implements Response {
  constructor(public description: string, initializer?: Partial<Response>) {
    super(initializer);
    this.content = (<any>this).content || new Dictionary<MediaType>();
    this.links = (<any>this).links || new Dictionary<Reference<Link>>();
    this.headers = (<any>this).headers || new Dictionary<Reference<Header>>();
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
    this.enum = (<any>this).enum || new Array<string>();
  }
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

export enum ParameterLocation {
  /** @internal */
  Alias = "Alias"
}

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

export interface Callback extends Dictionary<PathItem> {
}
export interface SecurityRequirement extends Dictionary<string> {
}
export type HTTPSecurityScheme = NonBearerHTTPSecurityScheme | BearerHTTPSecurityScheme;

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

export interface Components extends Extensions {
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
  headers: Optional<Dictionary<Reference<Header>>>;
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

export interface Header extends Extensions, Partial<HasContent>, Partial<HasSchema>, Partial<HasExample>, Partial<HasExamples> {
  description?: string;
  required?: boolean;
  deprecated?: boolean;
  allowEmptyValue?: boolean;
  allowReserved?: boolean;
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

export interface Link extends Extensions {
  operationRef?: string; // uriref
  operationId?: string;
  parameters: Optional<Dictionary<string>>;
  requestBody?: any;
  description?: string;
  server?: Server;
}

export interface MediaType extends Extensions, Partial<HasExample>, Partial<HasExamples> {
  encoding: Optional<Dictionary<Encoding>>;
  schema?: Reference<Schema>;
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
export interface HttpOperation extends Extensions, Implementation<HttpOperationDetails> {
  tags: Optional<Array<string>>;
  summary?: string;
  description?: string;
  externalDocs?: ExternalDocumentation;
  operationId?: string;
  parameters: Optional<Array<Reference<Parameter>>>;
  requestBody?: Reference<RequestBody>;
  responses: Dictionary<Reference<Response>>;
  callbacks: Optional<Dictionary<Reference<Callback>>>;
  deprecated?: boolean;
  security: Optional<Array<SecurityRequirement>>;
  servers: Optional<Array<Server>>;
}

export interface HasSchema {
  schema: Reference<Schema>;
  explode?: boolean;
}
export interface HasContent {
  content: Dictionary<MediaType>;
}
export interface HasExample {
  example: any;
}
export interface HasExamples {
  examples: Dictionary<Reference<HasExample>>;
}
export interface InCookie extends HasSchema, Partial<HasExample>, Partial<HasExamples> {
  in: ParameterLocation.Cookie;
  style?: EncodingStyle.Form;
}
export interface InHeader extends HasSchema, Partial<HasExample>, Partial<HasExamples> {
  in: ParameterLocation.Header;
  style?: EncodingStyle.Simple;
}
export interface InPath extends HasSchema, Partial<HasExample>, Partial<HasExamples> {
  in: ParameterLocation.Path;
  style?: PathEncodingStyle;
}
export interface InQuery extends HasSchema, Partial<HasExample>, Partial<HasExamples> {
  in: ParameterLocation.Query;
  allowReserved?: boolean;
  style?: QueryEncodingStyle;
}
export interface Parameter extends Partial<HasSchema>, Partial<HasContent>, Partial<HasExample>, Partial<HasExamples> {
  name: string;
  in: ParameterLocation;

  description?: string;
  allowEmptyValue?: boolean;
  deprecated?: boolean;
  required?: boolean;
  style?: EncodingStyle;

  allowReserved?: boolean;
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
  get?: HttpOperation;
  put?: HttpOperation;
  post?: HttpOperation;
  delete?: HttpOperation;
  options?: HttpOperation;
  head?: HttpOperation;
  patch?: HttpOperation;
  trace?: HttpOperation;
  servers: Optional<Array<Server>>;
  parameters: Optional<Array<Reference<Parameter>>>;
}

export interface RequestBody extends Extensions {
  description?: string;
  content: Dictionary<MediaType>;
  required: Optional<boolean>;
}
export interface Response extends Extensions {
  description: string;
  headers: Optional<Dictionary<Reference<Header>>>;
  content: Optional<Dictionary<MediaType>>;
  links: Optional<Dictionary<Reference<Link>>>;
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
