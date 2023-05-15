// /*---------------------------------------------------------------------------------------------
//  *  Copyright (c) Microsoft Corporation. All rights reserved.
//  *  Licensed under the MIT License. See License.txt in the project root for license information.
//  *--------------------------------------------------------------------------------------------*/

// import { Components, Example, ExternalDocumentation, ImplementationDetails, ImplementationLocation, IOperation, IOperationBase, IParameter, LanguageDetails, Link, ParameterDetails, ResponseDetails, SecurityRequirement, Server } from './components';
// import { Extensions } from './extensions';
// import { Schema } from './schema';
// import { SecurityScheme } from './security-scheme';
// import { DeepPartial } from '@azure-tools/codegen';
// import { Dictionary } from '@azure-tools/linq';
// import { uid } from './uid';
import { Operation, Parameter as NewHttpOperationParameter } from "@azure-tools/codemodel";

// export interface HttpOperationDetails extends ImplementationDetails {
// }

// /**
//  * An encoding attribute is introduced to give you control over the serialization of parts of multipart request bodies.
//  * This attribute is only applicable to multipart and application/x-www-form-urlencoded request bodies.
// */
// export class Encoding extends Extensions implements Encoding {
//   public headers = new Array<Header>();

//   constructor(public key: string, initializer?: DeepPartial<Encoding>) {
//     super();
//     this.apply(initializer);
//   }
// }

// export class Header extends Extensions implements Header {

//   public content = new Array<MediaType>();

//   constructor(initializer?: DeepPartial<Header>) {
//     super();
//     this.apply(initializer);
//   }
// }

// export class MediaType extends Extensions implements MediaType {
//   public encoding = new Array<Encoding>();
//   public accepts = new Array<string>();

//   constructor(public key: string, initializer?: DeepPartial<MediaType>) {
//     super();
//     this.apply(initializer);
//   }
// }

// export class RequestBody extends Extensions implements RequestBody {

//   constructor(initializer?: DeepPartial<RequestBody>) {
//     super();
//     this.apply(initializer);
//   }
// }

// export class Response extends Extensions implements Response {

//   public content = new Dictionary<MediaType>();
//   public links = new Dictionary<Link>();
//   public headers = new Array<Header>();

//   constructor(public description: string, initializer?: DeepPartial<Response>) {
//     super();
//     this.apply(initializer);
//   }
// }

export enum ParameterLocation {
  Uri = 'uri',
  Query = 'query',
  Header = 'header',
  Cookie = 'cookie',
  Path = 'path',
}

// export enum EncodingStyle {
//   Matrix = 'matrix',
//   Label = 'label',
//   Simple = 'simple',
//   Form = 'form',
//   SpaceDelimited = 'spaceDelimited',
//   PipeDelimited = 'pipeDelimited',
//   DeepObject = 'deepObject'
// }

// export type QueryEncodingStyle =
//   EncodingStyle.Form
//   | EncodingStyle.SpaceDelimited
//   | EncodingStyle.PipeDelimited
//   | EncodingStyle.DeepObject;
// export type PathEncodingStyle = EncodingStyle.Matrix | EncodingStyle.Label | EncodingStyle.Simple;

// export interface Encoding extends Extensions {
//   key: string;
//   contentType?: string;
//   headers: Array<Header>;
//   style?: QueryEncodingStyle;
//   explode?: boolean;
//   allowReserved?: boolean;
// }

// export interface Header extends Extensions {
//   key: string;
//   schema: Schema;
//   explode?: boolean;
//   examples: Dictionary<Example>;

//   description?: string;
//   required: boolean;
//   deprecated: boolean;
//   allowEmptyValue: boolean;
//   allowReserved: boolean;
// }

// export interface MediaType extends Extensions {
//   key: string;
//   accepts: Array<string>; // equivalent media types for this media type (ie, text/json, application/json)
//   examples: Array<Example>;
//   encoding: Array<Encoding>;
//   schema?: Schema;
// }

// export interface RequestBody extends Extensions {
//   description?: string;
//   contentType: string;
//   schema: Schema;
//   required: boolean;
// }

// export interface Response extends Extensions {
//   description: string;
//   headers: Array<Header>;
//   content: Dictionary<MediaType>;
//   links: Dictionary<Link>;
// }

// export interface HttpParameterDetails extends ParameterDetails {
//   location: ImplementationLocation;
// }

// export enum HttpMethod {
//   Get = 'get',
//   Put = 'put',
//   Post = 'post',
//   Delete = 'delete',
//   Options = 'options',
//   Head = 'head',
//   Patch = 'patch',
//   Trace = 'trace'
// }

// export interface NewResponse {
//   details: LanguageDetails<ResponseDetails>;
//   responseCode: string;
//   description: string;
//   headers: Array<Header>;
//   headerSchema?: Schema;
//   mimeTypes: Array<string>; // accepted equivalent media types for this media type (ie, text/json, application/json)
//   schema?: Schema;
// }

// export class NewResponse extends Extensions implements NewResponse {
//   public details: LanguageDetails<ResponseDetails>;

//   constructor(public responseCode: string, public description: string, public mimeTypes: Array<string>, objectInitializer?: DeepPartial<NewResponse>) {
//     super();
//     this.details = {
//       default: {
//         uid: `response:${uid()}`,
//         isErrorResponse: false,
//         description: description || objectInitializer?.description || '',
//         name: `${responseCode} ${mimeTypes.join(' ')}`,
//       }
//     };
//     this.headers = new Array<Header>();
//     this.apply(objectInitializer);
//   }
// }

// export class HttpOperation extends Extensions implements HttpOperation {
//   public details: LanguageDetails<HttpOperationDetails>;
//   public tags = new Array<string>();
//   public parameters = new Array<HttpOperationParameter>();
//   public responses = new Dictionary<Array<NewResponse>>();
//   public callbacks = new Dictionary<Callback>();
//   public security = new Array<SecurityRequirement>();
//   public servers = new Array<Server>();
//   public deprecated = false;

//   constructor(operationId: string, public baseUrl: string, public path: string, public method: HttpMethod, initializer?: DeepPartial<HttpOperation>) {
//     super();
//     this.details = {
//       default: {
//         uid: `http-operation:${uid()}`,
//         description: initializer?.description || '',
//         name: operationId,
//       }
//     };

//     this.apply(initializer);
//   }
// }

// export interface HttpOperation extends IOperation<HttpOperationParameter>, Extensions {
//   details: LanguageDetails<HttpOperationDetails>;

//   tags: Array<string>;
//   summary?: string;

//   externalDocs?: ExternalDocumentation;

//   parameters: Array<HttpOperationParameter>;
//   requestBody?: RequestBody;
//   responses: Dictionary<Array<NewResponse>>;

//   callbacks: Dictionary<Callback>;
//   deprecated: boolean;
//   security: Array<SecurityRequirement>;
//   servers: Array<Server>;

//   path: string;
//   baseUrl: string;
//   method: HttpMethod;
//   pathDescription?: string;
//   pathSummary?: string;
//   pathExtensions?: Dictionary<any>;
// }

// export interface HttpOperationParameter extends IParameter {

//   in: ParameterLocation;
//   explode?: boolean;

//   encoding?: Array<Encoding>;
//   mediaType?: string;
//   style: EncodingStyle;
//   examples?: Dictionary<any>;
//   allowReserved?: boolean;
// }

// export class HttpOperationParameter extends Extensions implements HttpOperationParameter {

//   public details: LanguageDetails<HttpParameterDetails>;
//   public deprecated = false;
//   public required = false;
//   public allowEmptyValue = false;

//   constructor(public name: string, inWhere: ParameterLocation, implementation: ImplementationLocation, initializer?: DeepPartial<HttpOperationParameter>) {
//     super();
//     this.in = inWhere;
//     this.details = {
//       default: {
//         uid: `http-parameter:${uid()}`,
//         description: initializer?.description || '',
//         location: implementation,
//         name,
//       }
//     };
//     this.required = inWhere === ParameterLocation.Path;
//     this.apply(initializer);
//   }
// }

// export function isHttpOperation(operation: IOperationBase): operation is HttpOperation {
//   if ((<any>operation).path) {
//     return true;
//   }
//   return false;
// }

// export class Callback implements Callback {
//   constructor() {
//     // unimplemented.
//   }
// }

// export interface Callback extends Dictionary<HttpOperation> {
// }

// export interface HttpComponents extends Components<HttpOperation, HttpOperationParameter> {

//   examples: Dictionary<Example>;
//   securitySchemes: Dictionary<SecurityScheme>;
//   links: Dictionary<Link>;
//   callbacks: Dictionary<Callback>;
// }

// export class HttpComponents extends Components<HttpOperation, HttpOperationParameter> implements HttpComponents {
//   public examples = new Dictionary<Example>();
//   public securitySchemes = new Dictionary<SecurityScheme>();
//   public links = new Dictionary<Link>();
//   public callbacks = new Dictionary<Callback>();

//   constructor(initializer?: DeepPartial<HttpComponents>) {
//     super();
//     this.apply(initializer);
//   }
// }

export function hasValidBodyParameters(
  operation: Operation
): NewHttpOperationParameter | undefined {
  if (
    operation.requests &&
    operation.requests.length > 0 &&
    operation.requests[0].parameters &&
    operation.requests[0].parameters.length > 0
  ) {
    const param = operation.requests[0].parameters.find(
      (p) => !p.origin || p.origin.indexOf("modelerfour:synthesized") < 0
    );
    return param;
  }
  return undefined;
}
