import { Dictionary, NotOptional as Optional } from "./common";
import { hasContent } from "./oai3";
import { Initializer } from "#common/initializer";


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

export type Reference<T> = T;

/**
 * class implementation for all CodeModel classes
 * 
 * Initializes the extensions dictionary and implements the Partial Object Initializer.
 */
export class WithExtensions extends Initializer {
  extensions = new Dictionary<any>();
}

export class Model extends WithExtensions implements Model, Implementation<ClientDetails> {
  info: Info;
  openApi = "3.0";
  details: ClientDetails;
  paths = new Dictionary<PathItem>();
  components = new Components();
  tags = new Array<Tag>();
  servers = new Array<Server>();
  security = new Array<SecurityRequirement>();

  constructor(title: string, version: string, initializer?: Partial<Model>) {
    super();
    this.details = { name: title };
    this.info = new Info(title, version, initializer ? initializer.info : {});
    this.apply(initializer);
  }
}

export class Schema extends WithExtensions implements Schema {
  details: SchemaDetails;
  required = new Array<string>();
  enum = new Array<any>();
  allOf = new Array<Reference<Schema>>();
  oneOf = new Array<Reference<Schema>>();
  anyOf = new Array<Reference<Schema>>();
  properties = new Dictionary<PropertyReference<Schema>>();

  constructor(name: string, initializer?: Partial<Schema>) {
    super();
    this.details = { name: name };
    this.apply(initializer);
  }
}

export class Components extends WithExtensions implements Components {
  schemas = new Dictionary<Reference<Schema>>();
  responses = new Dictionary<Reference<Response>>();
  parameters = new Dictionary<Reference<HttpOperationParameter>>();
  examples = new Dictionary<Reference<Example>>();
  requestBodies = new Dictionary<Reference<RequestBody>>();
  headers = new Dictionary<Reference<Header>>();
  securitySchemes = new Dictionary<Reference<SecurityScheme>>();
  links = new Dictionary<Reference<Link>>();
  callbacks = new Dictionary<Reference<Callback>>();
  operations = new Dictionary<Reference<Operation>>()

  constructor(initializer?: Partial<Schema>) {
    super();
    this.apply(initializer);
  }
}

export function isHttpOperation(operation: Operation): operation is HttpOperation {
  if ((<any>operation).path) {
    return true;
  }
  return false;
}

export function isHighLevelOperation(operation: Operation): operation is HighLevelOperation {
  if ((<any>operation).operationType && (<any>operation).operationType === 'HighLevelOperation') {
    return true;
  }
  return false;
}

export function isIntrinsicOperation(operation: Operation): operation is IntrinsicOperation {
  if ((<any>operation).operationType && (<any>operation).operationType === 'IntrinsicOperation') {
    return true;
  }
  return false;
}

export interface IParameter {
  name: string;
  schema: Schema;
  description: string;
  allowEmptyValue: boolean;
  deprecated: boolean;
  required: boolean;
  details: ParameterDetails;
}

export interface ProgrammaticOperation {
  summary?: string;
  description?: string;
  parameters: Dictionary<IParameter>;
  responses: Dictionary<Dictionary<Schema>>;
  deprecated: boolean;
  pure: boolean; // side-effect free? May be helpful for deciding how to generate code.
}

export interface HighLevelOperation extends ProgrammaticOperation {
  operationType: "HighLevelOperation";
  verb: string;
  noun: string;
  variant: string;
  asjob: boolean;
  "call-graph": Array<string>;
  /*
    name: {
      noun: string,
      verb: string
    }
    */
}

export class HighLevelOperation extends WithExtensions implements HighLevelOperation, Implementation<ProgramaticOperationDetails> {
  details: ProgramaticOperationDetails;
  parameters = new Dictionary<IParameter>();
  responses = new Dictionary<Reference<Dictionary<Schema>>>();
  operationType: "HighLevelOperation" = "HighLevelOperation";

  constructor(name: string, deprecated: boolean, pure: boolean, initializer?: Partial<HighLevelOperation>) {
    super();
    this.details = {
      name: name,
    };
    this.deprecated = deprecated;
    this.pure = pure;

    this.apply(initializer);
  }
}

export interface IntrinsicOperation extends ProgrammaticOperation {
  operationType: "IntrinsicOperation";
}

export class IntrinsicOperation extends WithExtensions implements IntrinsicOperation, Implementation<ProgramaticOperationDetails> {
  details: ProgramaticOperationDetails;
  parameters = new Dictionary<IParameter>();
  responses = new Dictionary<Reference<Dictionary<Schema>>>();
  operationType: "IntrinsicOperation" = "IntrinsicOperation";

  constructor(name: string, deprecated: boolean, pure: boolean, initializer?: Partial<IntrinsicOperation>) {
    super();
    this.details = {
      name: name,
    };
    this.deprecated = deprecated;
    this.pure = pure;

    this.apply(initializer);
  }
}


export type Operation = HttpOperation | HighLevelOperation | IntrinsicOperation; //one day ...  | JsonRPCOperation  ...etc

export interface Model extends Implementation<ClientDetails> {

}

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

export interface Details extends Dictionary<any> {
  /** name used in actual implementation */
  name: string;

  /** namespace of the implementation of this item */
  namespace?: string;

  /** description text */
  description?: string;

  /** message used to go along with deprecation */
  deprecationMessage?: string;

  /** object to store any additional private data during code generation */
  // privateData: Dictionary<any>;
}


export enum ImplementationLocation {
  Method = "Method",
  Client = "Client",
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

export interface ClientDetails extends Details {

}

export interface PropertyDetails extends Details {
  required: boolean;
}

export interface ParameterDetails extends Details {
  location: ImplementationLocation;
}

export interface SchemaDetails extends Details {
  enum?: EnumDetails;
}

export interface HttpOperationDetails extends Details {
}

export interface ProgramaticOperationDetails extends Details {
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
export interface PropertyReference<T> extends Implementation<PropertyDetails>, Extensions {
  /** description can be on the property reference, so that properties can have a description different from the type description. */
  description?: string;
  schema: Schema;
}

export class PropertyReference<T> extends WithExtensions implements PropertyReference<T>  {
  details: PropertyDetails;

  constructor(name: string, initializer?: Partial<PropertyReference<T>>) {
    super();
    this.details = {
      name: name,
      required: false
    }
    this.apply(initializer);
  }
}

export class APIKeySecurityScheme extends WithExtensions implements APIKeySecurityScheme {
  constructor(public name: string, inWhere: ParameterLocation, initializer?: Partial<APIKeySecurityScheme>) {
    super();
    this.in = inWhere;
    this.type = SecurityType.ApiKey;
    this.apply(initializer);
  }
}
export class AuthorizationCodeOAuthFlow extends WithExtensions implements AuthorizationCodeOAuthFlow {
  scopes = new Dictionary<string>();
  constructor(public authorizationUrl: string, tokenUrl: string, initializer?: Partial<AuthorizationCodeOAuthFlow>) {
    super();
    this.apply(initializer);
  }
}
export class BearerHTTPSecurityScheme extends WithExtensions implements BearerHTTPSecurityScheme {
  scheme = Scheme.Bearer;

  constructor(initializer?: Partial<BearerHTTPSecurityScheme>) {
    super();
    this.type = SecurityType.Http;
    this.apply(initializer);
  }
}
export class ClientCredentialsFlow extends WithExtensions implements ClientCredentialsFlow {
  scopes = new Dictionary<string>();
  constructor(public tokenUrl: string, initializer?: Partial<ClientCredentialsFlow>) {
    super();
    this.apply(initializer);
  }
}

export class Callback implements Callback {
  constructor() {
  }
}

export class Contact extends WithExtensions implements Contact {
  constructor(initializer?: Partial<Contact>) {
    super();
    this.apply(initializer);
  }
}

export class Discriminator extends WithExtensions implements Discriminator {
  mapping = new Dictionary<string>();

  constructor(public propertyName: string, initializer?: Partial<Discriminator>) {
    super();
    this.apply(initializer);
  }
}
export class Encoding extends WithExtensions implements Encoding {
  headers = new Dictionary<Header>();
  constructor(initializer?: Partial<Encoding>) {
    super();
    this.apply(initializer);
  }
}

export class Example extends WithExtensions implements Example {
  constructor(initializer?: Partial<Example>) {
    super();
    this.apply(initializer);
  }
}
export class ExternalDocumentation extends WithExtensions implements ExternalDocumentation {
  constructor(public url: string, initializer?: Partial<ExternalDocumentation>) {
    super();
    this.apply(initializer);
  }
}

export class Header extends WithExtensions implements Header {
  content = new Dictionary<MediaType>();
  constructor(initializer?: Partial<Header>) {
    super();
    this.apply(initializer);
  }
}

export class ImplicitOAuthFlow extends WithExtensions implements ImplicitOAuthFlow {
  scopes = new Dictionary<string>();
  constructor(public authorizationUrl: string, initializer?: Partial<ImplicitOAuthFlow>) {
    super();
    this.apply(initializer);
  }
}
export class Info extends WithExtensions implements Info {
  constructor(public title: string, public version: string, initializer?: Partial<Info>) {
    super();
    this.apply(initializer);
  }
}
export class License extends WithExtensions implements License {
  constructor(public name: string, initializer?: Partial<License>) {
    super();
    this.apply(initializer);
  }
}

export class Link extends WithExtensions implements Link {
  parameters = new Dictionary<string>();
  constructor(initializer?: Partial<Link>) {
    super();
    this.apply(initializer);
  }
}

export interface MediaType {
  accepts: Array<string>;
}

export class MediaType extends WithExtensions implements MediaType {
  encoding = new Dictionary<Encoding>();
  accepts = new Array<string>();
  constructor(initializer?: Partial<MediaType>) {
    super();
    this.apply(initializer);
  }
}

export class NonBearerHTTPSecurityScheme extends WithExtensions implements NonBearerHTTPSecurityScheme {
  constructor(public scheme: string, initializer?: Partial<NonBearerHTTPSecurityScheme>) {
    super();
    this.apply(initializer);
    this.type = SecurityType.Http;
  }
}
export class OAuth2SecurityScheme extends WithExtensions implements OAuth2SecurityScheme {
  constructor(public flows: OAuthFlows, initializer?: Partial<OAuth2SecurityScheme>) {
    super();
    this.type = SecurityType.OAuth2;
    this.apply(initializer);
  }

}
export class OAuthFlows extends WithExtensions implements OAuthFlows {
  constructor(initializer?: Partial<OAuthFlows>) {
    super();
    this.apply(initializer);
  }
}
export class OpenIdConnectSecurityScheme extends WithExtensions implements OpenIdConnectSecurityScheme {
  constructor(public openIdConnectUrl: string, initializer?: Partial<OpenIdConnectSecurityScheme>) {
    super();
    this.type = SecurityType.OpenIDConnect;
    this.apply(initializer);
  }
}

export class HttpOperation extends WithExtensions implements HttpOperation, Implementation<HttpOperationDetails> {
  details: HttpOperationDetails;
  tags = new Array<string>();
  parameters = new Array<Reference<HttpOperationParameter>>();
  responses = new Dictionary<Reference<Response>>();
  callbacks = new Dictionary<Reference<Callback>>();
  security = new Array<SecurityRequirement>();
  servers = new Array<Server>();
  deprecated = false;

  constructor(operationId: string, public path: string, public method: HttpMethod, initializer?: Partial<HttpOperation>) {
    super();
    this.details = {
      name: operationId,
    };

    this.apply(initializer);
  }
}

export class HttpOperationParameter extends WithExtensions implements HttpOperationParameter, Implementation<ParameterDetails> {
  details: ParameterDetails;
  deprecated = false;
  required = false;
  allowEmptyValue = false;

  constructor(public name: string, inWhere: ParameterLocation, implementation: ImplementationLocation, initializer?: Partial<HttpOperationParameter>) {
    super();
    this.in = inWhere;
    this.details = {
      name: name,
      location: implementation,
    };
    this.required = inWhere === ParameterLocation.Path;
    this.apply(initializer);
  }
}

export class PasswordOAuthFlow extends WithExtensions implements PasswordOAuthFlow {
  scopes = new Dictionary<string>();
  constructor(public tokenUrl: string, initializer?: Partial<PasswordOAuthFlow>) {
    super();
    this.apply(initializer);
  }
}
export class PathItem extends WithExtensions implements PathItem {
  parameters = new Array<Reference<HttpOperationParameter>>();
  servers = new Array<Server>();
  constructor(initializer?: Partial<PathItem>) {
    super();
    this.apply(initializer);
  }
  //   $ref?: string | PathItem;
}

export class RequestBody extends WithExtensions implements RequestBody {
  content = new Dictionary<MediaType>();
  constructor(initializer?: Partial<RequestBody>) {
    super();
    this.apply(initializer);
  }
}
export class Response extends WithExtensions implements Response {
  content = new Dictionary<MediaType>();
  links = new Dictionary<Reference<Link>>();
  headers = new Dictionary<Reference<Header>>();
  constructor(public description: string, initializer?: Partial<Response>) {
    super();
    this.apply(initializer);
  }
}

export class Server extends WithExtensions implements Server {
  variables = new Dictionary<ServerVariable>();
  constructor(public url: string, initializer?: Partial<Server>) {
    super();
    this.apply(initializer);
  }
}
export class ServerVariable extends WithExtensions implements ServerVariable {
  enum = new Array<string>();
  constructor(defaultValue: string, initializer?: Partial<ServerVariable>) {
    super();
    this.default = defaultValue;
    this.apply(initializer);
  }
}
export class Tag extends WithExtensions implements Tag {
  constructor(public name: string, initializer?: Partial<Tag>) {
    super();
    this.apply(initializer);
  }
}
export class XML extends WithExtensions implements XML {
  attribute = false;
  wrapped = false;

  constructor(initializer?: Partial<XML>) {
    super();
    this.apply(initializer);
  }
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
  parameters: Optional<Dictionary<Reference<HttpOperationParameter>>>;
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
  required: Optional<boolean>;
  deprecated: Optional<boolean>;
  allowEmptyValue: Optional<boolean>;
  allowReserved: Optional<boolean>;
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
  parameters: Optional<Array<Reference<HttpOperationParameter>>>;
  requestBody?: Reference<RequestBody>;
  responses: Dictionary<Reference<Response>>;
  callbacks: Optional<Dictionary<Reference<Callback>>>;
  deprecated: Optional<boolean>;
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
export interface HttpOperationParameter extends Partial<HasSchema>, Partial<HasContent>, Partial<HasExample>, Partial<HasExamples> {
  name: string;
  in: ParameterLocation;

  description?: string;
  allowEmptyValue: Optional<boolean>;
  deprecated: Optional<boolean>;
  required: Optional<boolean>;
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
  parameters: Optional<Array<Reference<HttpOperationParameter>>>;
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
  attribute: boolean;
  wrapped: boolean;
}
