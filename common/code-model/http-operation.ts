import { Dictionary } from "#common/dictionary";
import { Schema } from "#common/code-model/schema";
import { SecurityScheme } from "#common/code-model/security-scheme";
import { Extensions } from "#common/code-model/extensions";
import {
  Components,
  Details, Example, ExternalDocumentation, ImplementationLocation,
  IOperation,
  IOperationBase,
  IParameter, Link,
  ParameterDetails, Server, SecurityRequirement
} from "#common/code-model/components";


export interface HttpOperationDetails extends Details {
}

export class Encoding extends Extensions implements Encoding {
  headers = new Dictionary<Header>();

  constructor(initializer?: Partial<Encoding>) {
    super();
    this.apply(initializer);
  }
}

export class Header extends Extensions implements Header {

  content = new Dictionary<MediaType>();

  constructor(initializer?: Partial<Header>) {
    super();
    this.apply(initializer);
  }
}


export class MediaType extends Extensions implements MediaType {

  encoding = new Dictionary<Encoding>();
  accepts = new Array<string>();

  constructor(initializer?: Partial<MediaType>) {
    super();
    this.apply(initializer);
  }
}

export class RequestBody extends Extensions implements RequestBody {

  content = new Dictionary<MediaType>();

  constructor(initializer?: Partial<RequestBody>) {
    super();
    this.apply(initializer);
  }
}

export class Response extends Extensions implements Response {

  content = new Dictionary<MediaType>();
  links = new Dictionary<Link>();
  headers = new Dictionary<Header>();

  constructor(public description: string, initializer?: Partial<Response>) {
    super();
    this.apply(initializer);
  }
}

export enum ParameterLocation {
  Query = "query",
  Header = "header",
  Cookie = "cookie",
  Path = "path",
}

export enum EncodingStyle {
  Matrix = "matrix",
  Label = "label",
  Simple = "simple",
  Form = "form",
  SpaceDelimited = "spaceDelimited",
  PipeDelimited = "pipeDelimited",
  DeepObject = "deepObject"
}

export type QueryEncodingStyle =
  EncodingStyle.Form
  | EncodingStyle.SpaceDelimited
  | EncodingStyle.PipeDelimited
  | EncodingStyle.DeepObject;
export type PathEncodingStyle = EncodingStyle.Matrix | EncodingStyle.Label | EncodingStyle.Simple;

export interface Encoding extends Extensions {
  contentType?: string;
  headers: Dictionary<Header>;
  style?: QueryEncodingStyle;
  explode?: boolean;
  allowReserved?: boolean;
}

export interface Header extends Extensions {

  schema: Schema;
  explode?: boolean;
  examples: Dictionary<Example>;

  description?: string;
  required: boolean;
  deprecated: boolean;
  allowEmptyValue: boolean;
  allowReserved: boolean;
}

export interface MediaType extends Extensions {
  accepts: Array<string>; // equivalent media types for this media type (ie, text/json, application/json)

  examples: Dictionary<Example>;

  encoding: Dictionary<Encoding>;
  schema?: Schema;
}

export interface RequestBody extends Extensions {
  description?: string;
  content: Dictionary<MediaType>;
  required: boolean;
}

export interface Response extends Extensions {
  description: string;
  headers: Dictionary<Header>;
  content: Dictionary<MediaType>;
  links: Dictionary<Link>;
}

export interface HttpParameterDetails extends ParameterDetails {
  location: ImplementationLocation;
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

export class HttpOperation extends Extensions implements HttpOperation {
  details: HttpOperationDetails;
  tags = new Array<string>();
  parameters = new Array<HttpOperationParameter>();
  responses = new Dictionary<Response>();
  callbacks = new Dictionary<Callback>();
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


export interface HttpOperation extends IOperation<HttpOperationParameter>, Extensions {
  details: HttpOperationDetails;

  tags: Array<string>;
  summary?: string;

  externalDocs?: ExternalDocumentation;

  parameters: Array<HttpOperationParameter>;
  requestBody?: RequestBody;
  responses: Dictionary<Response>;
  callbacks: Dictionary<Callback>;
  deprecated: boolean;
  security: Array<SecurityRequirement>;
  servers: Array<Server>;

  path: string;
  method: HttpMethod;
  pathDescription?: string;
  pathSummary?: string;
  pathExtensions?: Dictionary<any>;
}

export interface HttpOperationParameter extends IParameter {

  in: ParameterLocation;
  explode?: boolean;

  encoding?: Dictionary<Encoding>;
  mediaType?: string;
  style: EncodingStyle;
  examples?: Dictionary<any>;
  allowReserved?: boolean;
}


export class HttpOperationParameter extends Extensions implements HttpOperationParameter {

  details: HttpParameterDetails;
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

export function isHttpOperation(operation: IOperationBase): operation is HttpOperation {
  if ((<any>operation).path) {
    return true;
  }
  return false;
}

export class Callback implements Callback {
  constructor() {
  }
}

export interface Callback extends Dictionary<HttpOperation> {
}

export interface HttpComponents extends Components<HttpOperation, HttpOperationParameter> {
  responses: Dictionary<Response>
  examples: Dictionary<Example>;
  requestBodies: Dictionary<RequestBody>;
  headers: Dictionary<Header>;
  securitySchemes: Dictionary<SecurityScheme>;
  links: Dictionary<Link>;
  callbacks: Dictionary<Callback>;
}

export class HttpComponents extends Components<HttpOperation, HttpOperationParameter> implements HttpComponents {
  responses = new Dictionary<Response>();
  examples = new Dictionary<Example>();

  requestBodies = new Dictionary<RequestBody>();
  headers = new Dictionary<Header>();
  securitySchemes = new Dictionary<SecurityScheme>();

  links = new Dictionary<Link>();

  callbacks = new Dictionary<Callback>();

  //operations = new Dictionary<HttpOperation>();
  //
  // parameters = new Dictionary<HttpOperationParameter>();

  constructor(initializer?: Partial<Schema>) {
    super();
    this.apply(initializer);
  }
}
