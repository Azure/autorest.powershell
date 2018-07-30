import {
  Example,
  ExternalDocumentation,
  ImplementationLocation,
  Link,
  SecurityRequirement,
  Server,
  Tag
} from '#common/code-model/components';
import {
  Callback, Encoding,
  EncodingStyle,
  Header,
  HttpMethod,
  HttpOperation,
  HttpOperationParameter, MediaType, NewResponse, ParameterLocation, RequestBody, Response
} from '#common/code-model/http-operation';
import { Discriminator, JsonType, Property, Schema, XML } from '#common/code-model/schema';
import { SecurityScheme } from '#common/code-model/security-scheme';
import { CopyDictionary, Dictionary, items, length, values, keys } from '#common/dictionary';
import { ModelState } from '#common/model-state';
import { ArtifactMessage, Channel, Host } from '@microsoft.azure/autorest-extension-base';
import { DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA, dump, safeDump, safeLoad } from 'js-yaml'
import { Model as CodeModel } from '../common/code-model/code-model';
import { clone, dereference, Dereferenced, getExtensionProperties, isReference, Refable } from './common';
import * as Interpretations from './interpretations';
import { StringFormat } from './known-format';
import * as OpenAPI from './oai3';

const todo_unimplemented = undefined;

export class Remodeler {

  private model: CodeModel;

  private get oai(): OpenAPI.Model {
    return this.modelState.model;
  }

  constructor(private modelState: ModelState<OpenAPI.Model>) {
    console.error(JSON.stringify(this.oai.info));
    this.model = new CodeModel(this.oai.info.title, this.oai.info.version);
  }

  private dereference<T>(item: Refable<T>): Dereferenced<T> {
    return dereference(this.oai, item);
  }

  copySchemaIntegerOrNumber(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.multipleOf = original.multipleOf;
    newSchema.maximum = original.maximum;
    newSchema.exclusiveMaximum = original.exclusiveMaximum;
    newSchema.minimum = original.minimum;
    newSchema.exclusiveMinimum = original.exclusiveMinimum;
  }

  copySchemaObject(name: string, original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxProperties = original.maxProperties;
    newSchema.minProperties = original.minProperties;

    newSchema.details = {
      default: {
        description: Interpretations.getDescription('', original),
        name: Interpretations.getName(name, original),
      }

    };
  }

  copySchemaArray(name: string, original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxItems = original.maxItems;
    newSchema.minItems = original.minItems;
    newSchema.uniqueItems = original.uniqueItems;
    if (original.items) {
      newSchema.items = this.refOrAdd(`${name}.itemType`, this.dereference(original.items), this.model.schemas, this.copySchema);
    }
  }

  copySchemaString(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxLength = original.maxLength;
    newSchema.minLength = original.minLength;
    newSchema.pattern = original.pattern;
  }

  copySchema = (name: string, original: OpenAPI.Schema, targetDictionary: Dictionary<Schema>): Schema => {
    // normalize/warn about incorrect usage of binary/stream combinations
    // OAI (https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.1.md#data-types)
    // indicates that format: string, type: binary is "any sequence of octets" (ie, the body should be treated as a stream of bytes)

    // extant autorest has been using format: object, type: file -- which is not standard OAI.
    // there has also been use of type: file -- which is not even remotely standard JSON Schema
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    let type = original.type;
    let format = original.format;
    if (<string>type === 'file') {
      type = OpenAPI.JsonType.String;
      format = StringFormat.Binary;
      this.modelState.warning(
        `The schema type 'file' is not a OAI standard type. This has been auto-corrected to 'type:string' and 'format:binary'`,
        [`TypeFileNotValid`],
        /* todo: find source location for this node */
      );
    }

    if (type === JsonType.Object && format === 'file') {
      type = OpenAPI.JsonType.String;
      format = StringFormat.Binary;
      this.modelState.warning(
        `The schema type 'object' with format 'file' is not a standard OAI representation. This has been auto-corrected to 'type:string' and 'format:binary'`,
        [`TypeObjectFormatFileNotValid`],
        /* todo: find source location for this node */
      );
    }

    if (type === undefined && original.properties) {
      // they have a properties, but didn't say type: object.
      type = OpenAPI.JsonType.Object;
      this.modelState.warning(
        `The schema '${name}' with an undefined type and decalared properties is a bit ambigious. This has been auto-corrected to 'type:object'`,
        [`UndefinedTypeWithSchema`],
        /* todo: find source location for this node */
      );
    }


    if (type === undefined && original.allOf) {
      type = OpenAPI.JsonType.Object;
      this.modelState.warning(
        `The schema '${name}' with a undefined type and using allOf is a bit ambigious. This has been auto-corrected to 'type:object'`,
        [`UndefinedTypeWithSchema`],
        /* todo: find source location for this node */
      );
    }

    const newSchema = new Schema(name, {
      extensions: getExtensionProperties(original),
      type,
      format,
      title: original.title,
      description: original.description,

      nullable: original.nullable || false,
      readOnly: original.readOnly || false,
      writeOnly: original.writeOnly || false,
      deprecated: original.deprecated || false,
      required: original.required || [],

      // unbounded properties
      default: original.default,
      example: original.example,
    });

    this.addOrThrow(targetDictionary, name, newSchema);

    switch (type) {
      case JsonType.Integer:
      case JsonType.Number:
        this.copySchemaIntegerOrNumber(original, newSchema);
        break;
      case JsonType.Object:
        this.copySchemaObject(name, original, newSchema);
        break;
      case JsonType.Array:
        this.copySchemaArray(name, original, newSchema);
        break;
      case JsonType.String:
        this.copySchemaString(original, newSchema);
        break;
      case undefined:
        this.copySchemaIntegerOrNumber(original, newSchema);
        this.copySchemaObject(name, original, newSchema);
        this.copySchemaArray(name, original, newSchema);
        this.copySchemaString(original, newSchema);
        break;
      case JsonType.Boolean:
        break;
      default:
        throw new Error(`Invalid type '${type}' in schema`);
    }

    // copy the enum list across if it's specified
    if (original.enum) {
      newSchema.enum = [...original.enum];
    }

    newSchema.details.default.enum = Interpretations.getEnumDefinition(original);

    // object properties
    // discriminator
    if (original.discriminator && original.discriminator.propertyName) {
      newSchema.discriminator = new Discriminator(original.discriminator.propertyName, {
        extensions: getExtensionProperties(original.discriminator),
        mapping: original.discriminator.mapping
      });
    }

    // externalDocs
    newSchema.externalDocs = Interpretations.getExternalDocs(original.externalDocs);

    // XML
    if (original.xml) {
      newSchema.xml = new XML({
        extensions: getExtensionProperties(original.xml),
        attribute: original.xml.attribute,
        namespace: original.xml.namespace,
        name: original.xml.name,
        prefix: original.xml.prefix,
        wrapped: original.xml.wrapped,
      });
    }
    if (original.not) {
      // ensure that the original schema is copied over already.
      newSchema.not = this.refOrAdd(`.${name}.not`, this.dereference(original.not), this.model.schemas, this.copySchema);
    }
    if (original.allOf) {
      for (let index = 0; index < original.allOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.allOf.${index}`, this.dereference(original.allOf[index]), this.model.schemas, this.copySchema));
      }
    }
    if (original.anyOf) {
      for (let index = 0; index < original.anyOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.anyOf.${index}`, this.dereference(original.anyOf[index]), this.model.schemas, this.copySchema));
      }
    }
    if (original.oneOf) {
      for (let index = 0; index < original.oneOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.oneOf.${index}`, this.dereference(original.oneOf[index]), this.model.schemas, this.copySchema));
      }
    }

    if (original.additionalProperties !== undefined) {
      if (original.additionalProperties === true || original.additionalProperties === false) {
        newSchema.additionalProperties = original.additionalProperties;
      } else {
        newSchema.additionalProperties = this.refOrAdd(`${name}.additionalItemType`, this.dereference(original.additionalProperties), this.model.schemas, this.copySchema);
      }
    }

    if (original.properties) {
      for (const { key: propertyName, value: property } of items(original.properties)) {
        const propertySchema = this.dereference(<Refable<OpenAPI.Schema>>property);
        const newPropSchema = this.refOrAdd(`${name[0] == '.' ? name : '.' + name}.${propertyName}`, propertySchema, this.model.schemas, this.copySchema);
        newSchema.properties[propertyName] = new Property(propertyName, {
          description: Interpretations.getDescription(Interpretations.getDescription('', newPropSchema), property),
          schema: newPropSchema,

          details: {
            default: {
              deprecationMessage: Interpretations.getDeprecationMessage(original),
              description: Interpretations.getDescription(Interpretations.getDescription('', newPropSchema), property),
              name: Interpretations.getName(propertyName, propertySchema.instance),
              required: original.required ? original.required.indexOf(propertyName) > -1 : false,
            }
          }
        });
      }
    }
    return newSchema;
  }

  add<TSource, TDestination>(name: string, original: Dereferenced<TSource>, target: Dictionary<TDestination>, copyFunc: (name: string, source: TSource, destinationDictionary: Dictionary<TDestination>) => TDestination): TDestination {
    // is this an alias to another model?
    if (original.name) {
      // console.error(`adding something with a name: ${name},${original.name}`);
      // Yes, ensure the target is in the new model
      // (the assumption being that the target is the right instance if it is there with the expected name.)

      if (target[original.name]) {
        // the target model is already added to this return it as the instance.
        return this.safeAdd(target, name, target[original.name]);
      }

      // otherwise, create the referenced type, and then add it again with our name,
      const actual = this.add(original.name, { instance: original.instance }, target, copyFunc);
      return this.safeAdd(target, name, actual);
    }

    // copy it over and add it to the model
    const newValue = copyFunc(name, original.instance, target);

    return newValue;
    // return this.safeAdd(target, name, copyFunc(name, original.instance, target));
  }

  private addOrThrow<T>(target: Dictionary<T>, name: string, item: T): T {
    if (target) {
      if (target[name]) {
        throw new Error(`Duplicate Item! ${name}`);
      }
      // add it.
      target[name] = item;
    }
    return item;
  }

  private safeAdd<T>(target: Dictionary<T>, name: string, item: T): T {
    if (target[name] && target[name] !== item) {
      // if the <T> is already in the collection of <T>, and it's not this instance...
      //   throw new Error(`${name} exists in model.`);
      console.error(`${name} exists in model.`);
      // console.error(target[name]);
      // console.error(item);
      item = target[name];
      return item;
    }

    // add it.
    target[name] = item;
    return item;
  }

  private refOrAdd<TSource, TDestination>(nameIfInline: string, ref: Dereferenced<TSource>, dictionary: Dictionary<TDestination>, copyFunc: (name: string, source: TSource, destinationDictionary: Dictionary<TDestination>) => TDestination): TDestination {
    if (!ref.name) {
      // inline definition - extract it out
      return this.add(nameIfInline, ref, dictionary, copyFunc);
    }

    // it's a reference, make sure it's in the model.
    if (dictionary[ref.name]) {
      return dictionary[ref.name];
    }

    // it's a global instance that we haven't yet addded, add it and return the ref.
    return this.add(ref.name, ref, dictionary, copyFunc);
  }

  copyParameter(name: string, original: OpenAPI.Parameter, implementationLocation: ImplementationLocation = ImplementationLocation.Client, targetDictionary: Dictionary<HttpOperationParameter>): HttpOperationParameter {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }
    const location = Interpretations.getParameterImplementationLocation(implementationLocation, original);

    const style = OpenAPI.isCookieParameter(original) ? EncodingStyle.Form :
      /* Header must be Simple */
      OpenAPI.isHeaderParameter(original) ? EncodingStyle.Simple :
        /* Path must be Matrix|Label|Simple(default) */
        OpenAPI.isPathParameter(original) ? (original.style === EncodingStyle.Matrix || original.style === EncodingStyle.Label ? original.style : EncodingStyle.Simple) :
          /* Query must be DeepObject|PipeDelimited|SpaceDelimited|Form(default) */
          (original.style === EncodingStyle.DeepObject || original.style === EncodingStyle.PipeDelimited || original.style === EncodingStyle.SpaceDelimited ? original.style : EncodingStyle.Form);

    const newParameter = new HttpOperationParameter(original.name, original.in, location, {
      allowEmptyValue: (OpenAPI.isQueryParameter(original) && original.allowEmptyValue) || false,
      description: Interpretations.getDescription('', original),
      required: original.required || false,
      deprecated: original.deprecated || false,
      style,
      explode: original.explode || (style === EncodingStyle.Form ? true : false),
      allowReserved: OpenAPI.isQueryParameter(original) && original.allowReserved ? true : false,
      schema: OpenAPI.hasSchema(original) ? this.refOrAdd(`.Parameter.${name}`, this.dereference(original.schema), this.model.schemas, this.copySchema) : undefined,
      extensions: getExtensionProperties(original),
    });
    this.addOrThrow(targetDictionary, name, newParameter);

    newParameter.details.default.name = Interpretations.getName(original.name, original);
    newParameter.details.default.deprecationMessage = Interpretations.getDeprecationMessage(original);
    newParameter.details.default.description = Interpretations.getDescription(``, original);

    // TODO: not handled: Examples, Example, Content

    return newParameter;
  }

  remodelParameters(source: Dictionary<Refable<OpenAPI.Parameter>>) {
    for (const parameterName in source) {
      this.refOrAdd(parameterName, this.dereference(source[parameterName]), this.model.http.parameters, (n, o, d) => this.copyParameter(n, o, ImplementationLocation.Client, this.model.http.parameters));
    }
  }

  copyOperation = (name: string, original: { method: HttpMethod, path: string, operation: OpenAPI.HttpOperation, pathItem: OpenAPI.PathItem }, targetDictionary: Dictionary<HttpOperation>): HttpOperation => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }
    const newOperation = new HttpOperation(name, original.path, original.method, {
      pathDescription: original.pathItem.description,
      pathSummary: original.pathItem.summary,
      pathExtensions: getExtensionProperties(original.pathItem),
      deprecated: original.operation.deprecated || false,
      description: Interpretations.getDescription(original.pathItem.description || '', original.operation),
      extensions: getExtensionProperties(original.operation),
      operationId: name,
      path: original.path,
      servers: Interpretations.getServers(original.operation.servers, original.pathItem.servers, this.oai.servers),
      externalDocs: Interpretations.getExternalDocs(original.operation.externalDocs),
      tags: original.operation.tags ? [...original.operation.tags] : [],
      summary: original.operation.summary,
      requestBody: original.operation.requestBody ? this.refOrAdd(`.${name}.requestBody`, this.dereference(original.operation.requestBody), this.model.http.requestBodies, this.copyRequestBody) : undefined,
      callbacks: todo_unimplemented,
      security: todo_unimplemented
    });

    this.addOrThrow(targetDictionary, name, newOperation);

    if (original.operation.parameters) {
      for (const parameterName of original.operation.parameters) {
        const p = this.dereference(parameterName);
        newOperation.parameters.push(this.refOrAdd(`${name}.${p.instance.name}`, p, this.model.http.parameters, (n, o, t) => this.copyParameter(n, o, ImplementationLocation.Method, this.model.http.parameters)));
      }
    }

    // flatten response options into usable graph
    for (const { key: responseCode, value: ref } of items(original.operation.responses)) {
      newOperation.responses_new[responseCode] = new Array<NewResponse>();

      const originalResponse = this.dereference(ref);
      const responseObject = originalResponse.instance;

      if (!responseObject.content || length(responseObject.content) === 0) {
        // the response doesn't have any body content expected
        newOperation.responses_new[responseCode].push(new NewResponse(responseCode, responseObject.description, [], {
          extensions: getExtensionProperties(responseObject),
          headers: this.copyHeaders(name, responseObject.headers)
        }));
      } else {
        // if an operation response has a application/json and text/json, remove the text/json and add that mime type to the list of 'mimetypes'
        const both = (responseObject.content['application/json'] && responseObject.content['text/json']) ? true : false;

        for (const { key: mimeType, value: responseType } of items(responseObject.content)) {
          if (both && (mimeType === 'text/json')) {
            continue; // skip it here. let app/json take both
          }
          const mimeTypes = both && (mimeType === 'application/json') ? [mimeType, 'text/json'] : [mimeType];
          newOperation.responses_new[responseCode].push(new NewResponse(responseCode, responseObject.description, mimeTypes, {
            extensions: getExtensionProperties(responseObject),
            headers: this.copyHeaders(name, responseObject.headers),
            schema: responseType.schema ? this.refOrAdd(`.${name}.${responseCode}.${mimeType}`, this.dereference(responseType.schema), this.model.schemas, this.copySchema) : undefined
          }));
        }
      }
    }

    // move responses to global section.
    for (const responseCode of keys(original.operation.responses)) {
      newOperation.responses[responseCode] = this.refOrAdd(`.${name}.${responseCode}`, this.dereference(original.operation.responses[responseCode]), this.model.http.responses, this.copyResponse);
    }

    return newOperation;
  }

  copyHeader = (headerName: string, original: OpenAPI.Header, targetDictionary: Dictionary<Header>): Header => {
    if (targetDictionary && targetDictionary[headerName]) {
      return targetDictionary[headerName];
    }

    const newHeader = new Header({
      deprecated: original.deprecated || false,
      description: Interpretations.getDescription('', original),
      allowReserved: original.allowReserved ? true : false,
      explode: original.explode || false,
      extensions: getExtensionProperties(original),
      schema: OpenAPI.hasSchema(original) ? this.refOrAdd(`.Header.${headerName}`, this.dereference(original.schema), this.model.schemas, this.copySchema) : undefined,
      required: original.required || false,
      content: todo_unimplemented,
      allowEmptyValue: false // REALLY? this seems funny.
    });
    this.addOrThrow(targetDictionary, headerName, newHeader);

    // TODO: not handled: Examples, Example, Content

    return newHeader;
  }

  copyHeaders = (containerName: string, original?: Dictionary<Refable<OpenAPI.Header>>): Dictionary<Header> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.http.headers, this.copyHeader)) : new Dictionary<Header>();
  }

  copyLinks = (containerName: string, original?: Dictionary<Refable<OpenAPI.Link>>): Dictionary<Link> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.http.links, this.copyLink)) : new Dictionary<Link>();
  }

  copyEncoding = (encodingName: string, original: OpenAPI.Encoding): Encoding => {
    return new Encoding({
      contentType: original.contentType,
      headers: this.copyHeaders(encodingName, original.headers),
      style: original.style,
      explode: original.explode || original.style === OpenAPI.EncodingStyle.Form ? true : false,
      allowReserved: original.allowReserved || false
    });
  }

  copyEncodings(original?: Dictionary<OpenAPI.Encoding>): Dictionary<Encoding> {
    return original ? CopyDictionary(original, (v) => this.copyEncoding(v, original[v])) : new Dictionary<Encoding>();
  }

  copyMediaType = (mimeType: string, key: string, original: OpenAPI.MediaType): MediaType => {
    return new MediaType({
      schema: original.schema ? this.refOrAdd(key, this.dereference(original.schema), this.model.schemas, this.copySchema) : undefined,
      encoding: this.copyEncodings(original.encoding),
      extensions: getExtensionProperties(original),
      accepts: [mimeType]
    });
  }

  remodelPaths(source: Dictionary<Refable<OpenAPI.PathItem>>) {
    for (const path in source) {
      const pathItem = this.dereference(source[path]);
      if (!pathItem.name) {
        for (const method of [HttpMethod.Delete, HttpMethod.Get, HttpMethod.Head, HttpMethod.Options, HttpMethod.Patch, HttpMethod.Post, HttpMethod.Put, HttpMethod.Trace]) {
          const op = <OpenAPI.HttpOperation>pathItem.instance[method];
          if (op) {
            this.add(Interpretations.getOperationId(method, path, op), { instance: { method, path, operation: op, pathItem: pathItem.instance } }, this.model.http.operations, this.copyOperation);
          }
        }
      }
    }
  }

  copyResponse = (name: string, original: OpenAPI.Response, targetDictionary: Dictionary<Response>): Response => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const response = new Response(original.description || '', {
      // content: this.copyMediaTypes(name, original),
      extensions: getExtensionProperties(original),
      headers: this.copyHeaders(name, original.headers),
      links: this.copyLinks(name, original.links),
    });
    this.addOrThrow(targetDictionary, name, response);

    if (original.content) {
      for (const mediaType in original.content) {
        response.content[mediaType] = this.copyMediaType(mediaType, `${name}.${mediaType}`, original.content[mediaType]);
      }
    }

    return response;
  }

  copyRequestBody = (name: string, original: OpenAPI.RequestBody, targetDictionary: Dictionary<RequestBody>): RequestBody => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const requestBody = new RequestBody({
      description: Interpretations.getDescription('', original),
      extensions: getExtensionProperties(original),
      required: original.required ? original.required : false,
    });

    this.addOrThrow(targetDictionary, name, requestBody);

    if (original.content) {
      for (const mediaType in original.content) {
        requestBody.content[mediaType] = this.copyMediaType(mediaType, `${name}.${mediaType}`, original.content[mediaType]);
      }
    }

    return requestBody;
  }

  copyCallback = (name: string, original: OpenAPI.Callback, targetDictionary: Dictionary<Callback>): Callback => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const callback = new Callback();
    this.addOrThrow(targetDictionary, name, callback);
    return callback;
  }
  copyExample = (name: string, original: OpenAPI.Example, targetDictionary: Dictionary<Example>): Example => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const example = new Example();
    this.addOrThrow(targetDictionary, name, example);
    return example;
  }
  copyLink = (name: string, original: OpenAPI.Link, targetDictionary: Dictionary<Link>): Link => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const link = new Link({
      description: original.description,
      extensions: getExtensionProperties(original),
      operationId: original.operationId,
      operationRef: original.operationRef,
      parameters: todo_unimplemented,
      requestBody: todo_unimplemented,
      server: original.server ? Interpretations.copyServer(original.server) : undefined
    });
    this.addOrThrow(targetDictionary, name, link);
    return link;
  }

  /*
  // todo: unimplementd
  copySecurityScheme = (name: string, original: OpenAPI.SecurityScheme): SecurityScheme => {
    const securityScheme = todo_unimplemented;
    return securityScheme;
  }
*/

  remodelT<TSource, TDestination>(source: Dictionary<Refable<TSource>>, target: Dictionary<TDestination>, copyFunc: (name: string, source: TSource, targetDictionary: Dictionary<TDestination>) => TDestination): Dictionary<TDestination> {
    const result = new Dictionary<TDestination>();

    for (const name in source) {
      result[name] = this.refOrAdd(name, this.dereference(source[name]), target, copyFunc);
    }
    // if we need the set of references that we just added
    return result;
  }

  remodelTags(source: Array<OpenAPI.Tag>) {
    for (const each of source) {
      this.model.tags.push(new Tag(each.name, {
        description: each.description,
        extensions: getExtensionProperties(each),
        externalDocs: Interpretations.getExternalDocs(each.externalDocs),
      }));
    }
  }
  remodelServers(source: Array<OpenAPI.Server>) {
    for (const each of source) {
      this.model.servers.push(Interpretations.copyServer(each));
    }
  }
  remodelSecurity(source: Array<Dictionary<string>>) {
    for (const each of source) {
      this.model.security.push(CopyDictionary(each, index => each[index]));
    }
  }

  remodel(): CodeModel {
    if (this.oai.components) {
      if (this.oai.components.schemas) {
        this.remodelT(this.oai.components.schemas, this.model.schemas, this.copySchema);
      }
      if (this.oai.components.parameters) {
        this.remodelParameters(this.oai.components.parameters);
      }
      if (this.oai.components.headers) {
        this.remodelT(this.oai.components.headers, this.model.http.headers, this.copyHeader);
      }
      if (this.oai.components.requestBodies) {
        this.remodelT(this.oai.components.requestBodies, this.model.http.requestBodies, this.copyRequestBody);
      }
      if (this.oai.components.responses) {
        this.remodelT(this.oai.components.responses, this.model.http.responses, this.copyResponse);
      }
      /* todo: not implemented
      if (this.oai.components.callbacks) {
        this.remodelT(this.oai.components.callbacks, this.model.components.callbacks, this.copyCallback, (i) => new Callback(i));
      }
      */
      if (this.oai.components.examples) {
        this.remodelT(this.oai.components.examples, this.model.http.examples, this.copyExample);
      }
      if (this.oai.components.links) {
        this.remodelT(this.oai.components.links, this.model.http.links, this.copyLink);
      }
      if (this.oai.components.securitySchemes) {
        // todo: unimplemented
        // this.remodelT(this.oai.components.securitySchemes, this.model.components.securitySchemes, this.copySecurityScheme);
      }
    }
    if (this.oai.paths) {
      this.remodelPaths(this.oai.paths);
    }
    if (this.oai.security) {
      this.remodelSecurity(this.oai.security);
    }
    if (this.oai.servers) {
      this.remodelServers(this.oai.servers);
    }
    if (this.oai.tags) {
      this.remodelTags(this.oai.tags);
    }
    if (this.oai.externalDocs) {
      this.model.externalDocs = Interpretations.getExternalDocs(this.oai.externalDocs);
    }
    return this.model;
  }
}
