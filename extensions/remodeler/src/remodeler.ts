/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { components } from '@microsoft.azure/autorest.codemodel-v3';
import { Discriminator, JsonType, Property, Schema, XML, StatusCodes } from '@microsoft.azure/autorest.codemodel-v3';
import { CopyDictionary, Dictionary, items, keys, length, ToDictionary, values } from '@microsoft.azure/codegen';
import { isMediaTypeJson, isMediaTypeXml } from '@microsoft.azure/autorest.codemodel-v3';
import { ModelState } from '@microsoft.azure/autorest.codemodel-v3';
import { Callback, Encoding, EncodingStyle, Header, HttpMethod, HttpOperation, HttpOperationParameter, MediaType, NewResponse, RequestBody } from '@microsoft.azure/autorest.codemodel-v3';
import { codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { StringFormat } from '@microsoft.azure/autorest.codemodel-v3';
import { dereference, Dereferenced, getExtensionProperties, Refable } from './common';
import * as Interpretations from './interpretations';
import * as OpenAPI from '@microsoft.azure/openapi';

const TODO_UNIMPLEMENTED = undefined;

export class Remodeler {

  private model: codemodel.Model;

  private get oai(): OpenAPI.Model {
    return this.modelState.model;
  }

  constructor(private modelState: ModelState<OpenAPI.Model>) {
    this.model = new codemodel.Model(this.oai.info.title, this.oai.info.version);
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
    if (type === undefined && original.additionalProperties && !original.properties) {
      // they have a properties, but didn't say type: object.
      type = OpenAPI.JsonType.Object;
      this.modelState.warning(
        `The schema '${name}' with an undefined type and additionalProperties is a bit ambigious. This has been auto-corrected to 'type:object'`,
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
        const nested = this.refOrAdd(`${name}.Items`, this.dereference(original.additionalProperties), this.model.schemas, this.copySchema);
        newSchema.additionalProperties = nested;
      }
    }

    if (original.properties) {
      for (const { key: propertyName, value: property } of items(original.properties)) {
        const propertySchema = this.dereference(<Refable<OpenAPI.Schema>>property);
        const newPropSchema = this.refOrAdd(`${name[0] === '.' ? name : `.${name}`}.${propertyName}`, propertySchema, this.model.schemas, this.copySchema);
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
    return copyFunc(name, original.instance, target);
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

  copyParameter(name: string, original: OpenAPI.Parameter, implementationLocation: components.ImplementationLocation = components.ImplementationLocation.Client, targetDictionary: Dictionary<HttpOperationParameter>): HttpOperationParameter {
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

    // #HACK: the swagger2oai translator doesn't preserve this data.
    const paramSchema = this.dereference(original.schema);
    if (paramSchema.instance) {
      for (const p of items(<any>original)) {
        const k = p.key.toString();
        if (k.startsWith('x-')) {
          paramSchema.instance[k] = p.value;
        }
      }
    }

    const newParameter = new HttpOperationParameter(original.name, original.in, location, {
      allowEmptyValue: (OpenAPI.isQueryParameter(original) && original.allowEmptyValue) || false,
      description: Interpretations.getDescription('', original),
      required: original.required || false,
      deprecated: original.deprecated || false,
      style,
      explode: original.explode || (style === EncodingStyle.Form ? true : false),
      allowReserved: OpenAPI.isQueryParameter(original) && original.allowReserved ? true : false,
      schema: OpenAPI.hasSchema(original) ? this.refOrAdd(`.Parameter.${name}`, <any>paramSchema, this.model.schemas, this.copySchema) : undefined,
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
    for (const parameterName of keys(source)) {
      this.refOrAdd(parameterName, this.dereference(source[parameterName]), this.model.http.parameters, (n, o) => this.copyParameter(n, o, components.ImplementationLocation.Client, this.model.http.parameters));
    }
  }

  copyOperation = (name: string, original: { method: HttpMethod; path: string; operation: OpenAPI.HttpOperation; pathItem: OpenAPI.PathItem }, targetDictionary: Dictionary<HttpOperation>): HttpOperation => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }
    const query = original.path.indexOf('?');
    if (query > -1) {
      original.path = original.path.substring(0, query);
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
      callbacks: TODO_UNIMPLEMENTED,
      security: TODO_UNIMPLEMENTED,
      details: {
        default: {
          description: Interpretations.getDescription(original.pathItem.description || '', original.operation),
        }
      }
    });

    this.addOrThrow(targetDictionary, name, newOperation);

    if (original.operation.parameters) {
      for (const parameterName of original.operation.parameters) {
        const p = this.dereference(parameterName);
        newOperation.parameters.push(this.refOrAdd(`${name}.${p.instance.name}`, p, this.model.http.parameters, (n, o) => this.copyParameter(n, o, components.ImplementationLocation.Method, this.model.http.parameters)));
      }
    }
    if (original.pathItem.parameters) {
      for (const parameterName of original.pathItem.parameters) {
        const p = this.dereference(parameterName);
        newOperation.parameters.push(this.refOrAdd(`${name}.${p.instance.name}`, p, this.model.http.parameters, (n, o) => this.copyParameter(n, o, components.ImplementationLocation.Method, this.model.http.parameters)));
      }
    }

    // flatten response options into usable graph
    for (const { key: responseCode, value: ref } of items(original.operation.responses)) {
      // for a given http response code, we can have a variety of responses
      newOperation.responses[responseCode] = new Array<NewResponse>();

      const originalResponse = this.dereference(ref);
      const responseObject = originalResponse.instance;

      if (!responseObject.content || length(responseObject.content) === 0) {
        // the response doesn't have any body content expected
        newOperation.responses[responseCode].push(new NewResponse(responseCode, responseObject.description, [], {
          extensions: getExtensionProperties(responseObject),
          headers: this.copyHeaders(name, responseObject.headers),
          headerSchema: this.createHeaderSchema(name, responseCode, responseObject.headers)
        }));
      } else {
        // Interpretation:
        // glob all the json responses and xml responses into categories.
        // todo: make consolodation configurable.

        const [jsons, more] = items(responseObject.content).linq.bifurcate(each => isMediaTypeJson(each.key));
        const [xmls, rest] = values(more).linq.bifurcate(each => isMediaTypeXml(each.key));

        if (jsons.length > 0) {
          const schema = jsons[0].value.schema;
          const mediaType = jsons[0].key;

          newOperation.responses[responseCode].push(new NewResponse(responseCode, responseObject.description, jsons.map(v => v.key), {
            extensions: getExtensionProperties(responseObject),
            headers: this.copyHeaders(name, responseObject.headers),
            headerSchema: this.createHeaderSchema(name, responseCode, responseObject.headers),
            schema: schema ? this.refOrAdd(`.${name}.${responseCode}.${mediaType}`, this.dereference(schema), this.model.schemas, this.copySchema) : undefined
          }));
        }

        if (xmls.length > 0) {
          const schema = xmls[0].value.schema;
          const mediaType = xmls[0].key;

          newOperation.responses[responseCode].push(new NewResponse(responseCode, responseObject.description, xmls.map(v => v.key), {
            extensions: getExtensionProperties(responseObject),
            headers: this.copyHeaders(name, responseObject.headers),
            headerSchema: this.createHeaderSchema(name, responseCode, responseObject.headers),
            schema: schema ? this.refOrAdd(`.${name}.${responseCode}.${mediaType}`, this.dereference(schema), this.model.schemas, this.copySchema) : undefined
          }));
        }

        if (rest.length > 0) {
          for (const { key: mediaType, value: responseType } of rest) {
            const schema = responseType.schema;
            newOperation.responses[responseCode].push(new NewResponse(responseCode, responseObject.description, rest.map(v => v.key), {
              extensions: getExtensionProperties(responseObject),
              headers: this.copyHeaders(name, responseObject.headers),
              headerSchema: this.createHeaderSchema(name, responseCode, responseObject.headers),
              schema: schema ? this.refOrAdd(`.${name}.${responseCode}.${mediaType}`, this.dereference(schema), this.model.schemas, this.copySchema) : undefined
            }));
          }
        }
      }
    }

    /*
    old responses handling
    // move responses to global section.
    for (const responseCode of keys(original.operation.responses)) {
      newOperation.responses[responseCode] = this.refOrAdd(`.${name}.${responseCode}`, this.dereference(original.operation.responses[responseCode]), this.model.http.responses, this.copyResponse);
    }
    */

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
      content: TODO_UNIMPLEMENTED,
      allowEmptyValue: false // REALLY? this seems funny.
    });
    this.addOrThrow(targetDictionary, headerName, newHeader);

    // TODO: not handled: Examples, Example, Content

    return newHeader;
  }

  createHeaderSchema = (containerName: string, responseCode: string, original?: Dictionary<Refable<OpenAPI.Header>>): Schema | undefined => {
    if (original) {
      const code = ((<any>StatusCodes)[responseCode] || '') || responseCode;

      const schemaName = `${containerName} ${code} ResponseHeaders`;
      const newSchema = this.model.schemas[schemaName] || new Schema(schemaName, {
        type: JsonType.Object,
        details: {
          default: {
            isHeaderModel: true
          }
        }
      });

      for (const each of keys(original)) {
        const header = this.dereference(original[each]);
        const propertyName = Interpretations.getName(header.name || `${each}`, header.instance);

        const propertySchema = this.dereference(<Refable<OpenAPI.Schema>>header.instance.schema);
        const newPropSchema = this.refOrAdd(`${containerName[0] === '.' ? containerName : `.${containerName}`}.${propertyName}`, propertySchema, this.model.schemas, this.copySchema);

        newPropSchema.extensions = getExtensionProperties(header.instance);

        newSchema.properties[propertyName] = new Property(propertyName, {
          serializedName: header.name || `${each}`,
          description: Interpretations.getDescription(Interpretations.getDescription('', newPropSchema), header.instance),
          schema: newPropSchema,
          extensions: getExtensionProperties(header.instance),
          details: {
            default: {
              deprecationMessage: Interpretations.getDeprecationMessage(original),
              description: Interpretations.getDescription(Interpretations.getDescription('', newPropSchema), header.instance),
              name: Interpretations.getName(propertyName, propertySchema.instance),
              required: false,
              HeaderProperty: 'Header',
            }
          }
        });

      }

      this.model.schemas[schemaName] = newSchema;
      return newSchema;
    }
    return undefined;
  }
  copyHeaders = (containerName: string, original?: Dictionary<Refable<OpenAPI.Header>>): Dictionary<Header> => {
    return original ? ToDictionary(Object.keys(original), (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.http.headers, this.copyHeader)) : new Dictionary<Header>();
  }

  copyLinks = (containerName: string, original?: Dictionary<Refable<OpenAPI.Link>>): Dictionary<components.Link> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.http.links, this.copyLink)) : new Dictionary<components.Link>();
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
    for (const path of keys(source)) {
      const pathItem = this.dereference(source[path]);
      if (!pathItem.name) {
        for (const method of [HttpMethod.Delete, HttpMethod.Get, HttpMethod.Head, HttpMethod.Options, HttpMethod.Patch, HttpMethod.Post, HttpMethod.Put, HttpMethod.Trace]) {
          const op = <OpenAPI.HttpOperation>pathItem.instance[method];
          if (op) {
            this.add(Interpretations.getOperationId(method, path, op, this.oai.info.title, this.modelState), { instance: { method, path, operation: op, pathItem: pathItem.instance } }, this.model.http.operations, this.copyOperation);
          }
        }
      }
    }
  }

  /*
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
      for (const mediaType of keys(original.content)) {
        response.content[mediaType] = this.copyMediaType(mediaType, `${name}.${mediaType}`, original.content[mediaType]);
      }
    }

    return response;
  }
  */

  copyRequestBody = (name: string, original: OpenAPI.RequestBody, targetDictionary: Dictionary<RequestBody>): RequestBody => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    let rq = items(original.content).linq.first();

    if (length(original.content) > 1) {

      // check to see if there are multiple possible content types (that aren't really just variations of themselves)
      const [jsons, more] = items(original.content).linq.bifurcate(each => isMediaTypeJson(each.key));
      const [xmls, rest] = values(more).linq.bifurcate(each => isMediaTypeXml(each.key));

      if (((jsons.length > 0 ? 1 : 0) + (xmls.length > 0 ? 1 : 0) + rest.length) > 1) {
        // there are mulitple possible request bodies here.
        // autorest does not currently support generating code that can target different request content types
        // we're going to pick one based on an aribitrary priority:
        // json, xml, or the first one in the list

        rq = jsons[0] || xmls[0] || rest[0];

        this.modelState.warning(
          `The request body '${name}' has more than one possible content type specified (${keys(original.content).linq.toArray().join()}) - using '${rq.key}'`,
          [`MultipleRequestTypesFound`],
          /* todo: find source location for this node */
        );
      }
    }
    if (rq) {
      const requestBody = new RequestBody({
        description: Interpretations.getDescription('', original),
        extensions: getExtensionProperties(original),
        required: original.required ? original.required : false,
        schema: rq.value.schema ? this.refOrAdd(`.BodyParameter.${name}`, this.dereference(rq.value.schema), this.model.schemas, this.copySchema) : undefined,
        contentType: rq.key
      });

      this.addOrThrow(targetDictionary, name, requestBody);
      return requestBody;
    }
    throw new Error('RequestBody without schema?');
  }

  copyCallback = (name: string, targetDictionary: Dictionary<Callback>): Callback => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const callback = new Callback();
    this.addOrThrow(targetDictionary, name, callback);
    return callback;
  }
  copyExample = (name: string, targetDictionary: Dictionary<components.Example>): components.Example => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const example = new components.Example();
    this.addOrThrow(targetDictionary, name, example);
    return example;
  }
  copyLink = (name: string, original: OpenAPI.Link, targetDictionary: Dictionary<components.Link>): components.Link => {
    if (targetDictionary && targetDictionary[name]) {
      return targetDictionary[name];
    }

    const link = new components.Link({
      description: original.description,
      extensions: getExtensionProperties(original),
      operationId: original.operationId,
      operationRef: original.operationRef,
      parameters: TODO_UNIMPLEMENTED,
      requestBody: TODO_UNIMPLEMENTED,
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

    for (const name of keys(source)) {
      result[name] = this.refOrAdd(name, this.dereference(source[name]), target, copyFunc);
    }
    // if we need the set of references that we just added
    return result;
  }

  remodelTags(source: Array<OpenAPI.Tag>) {
    for (const each of source) {
      this.model.tags.push(new components.Tag(each.name, {
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

  remodel(): codemodel.Model {
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
      /*
      REMOVE THIS -- response definitions are created for each operation. We don't share those.

      if (this.oai.components.responses) {
        this.remodelT(this.oai.components.responses, this.model.http.responses, this.copyResponse);
      }
      */
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
      if (this.oai['x-ms-paths']) {
        this.remodelPaths(this.oai['x-ms-paths']);
      }
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
