import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { safeLoad, safeDump, dump, DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA } from "js-yaml"
import * as OpenAPI from "./oai3";
import * as Interpretations from "./interpretations";
import { dereference, getExtensionProperties, Dictionary, Refable, Dereferenced, isReference, CopyDictionary, clone } from "./common";
import { Model as CodeModel, Server, SecurityRequirement, Schema, Discriminator, ExternalDocumentation, XML, PropertyReference, JsonType, Parameter, ParameterLocation, ImplementationLocation, EncodingStyle, HttpOperation, HttpMethod, RequestBody, MediaType, Encoding, Header, Tag, SecurityScheme, Link, Example, Response, Callback } from "./code-model";
import { CodeModelEditor } from "./code-model-editor";
import { StringFormat } from "./known-format";
import { ModelState } from "#common/model-state";

const todo_unimplemented = undefined;

export class Remodeler {

  private model: CodeModel;
  private editor: CodeModelEditor;

  private get oai(): OpenAPI.Model {
    return this.modelState.model;
  }

  constructor(private modelState: ModelState<OpenAPI.Model>) {
    this.model = new CodeModel(this.oai.info.title, this.oai.info.version);
    this.editor = new CodeModelEditor(this.model);
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
      name: Interpretations.getName(name, original),
      description: Interpretations.getDescription("", original),
      privateData: {}
    };
  }

  copySchemaArray(name: string, original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxItems = original.maxItems;
    newSchema.minItems = original.minItems;
    newSchema.uniqueItems = original.uniqueItems;
    if (original.items) {
      newSchema.items = this.refOrAdd(`${name}.itemType`, this.dereference(original.items), this.model.components.schemas, this.copySchema)
    }
  }

  copySchemaString(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxLength = original.maxLength;
    newSchema.minLength = original.minLength;
    newSchema.pattern = original.pattern;
  }

  copySchema = (name: string, original: OpenAPI.Schema): Schema => {
    // normalize/warn about incorrect usage of binary/stream combinations
    // OAI (https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.1.md#data-types)
    // indicates that format: string, type: binary is "any sequence of octets" (ie, the body should be treated as a stream of bytes)

    // extant autorest has been using format: object, type: file -- which is not standard OAI.
    // there has also been use of type: file -- which is not even remotely standard JSON Schema

    let type = original.type;
    let format = original.format;
    if (<string>type === 'file') {
      type = OpenAPI.JsonType.String;
      format = StringFormat.Binary;
      this.modelState.warning(
        `The schema type 'file' is not a OAI standard type. This has been auto-corrected to 'type:string' and 'format:binary'`,
        [`TypeFileNotValid`],
        /* todo: find source location for this node */
      )
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
        `The schema with an undefined type and decalared properties is a bit ambigious. This has been auto-corrected to 'type:object'`,
        [`UndefinedTypeWithSchema`],
        /* todo: find source location for this node */
      );
    }

    const newSchema = new Schema(name, {
      extensions: getExtensionProperties(original),
      type: type,
      format: format,
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

    newSchema.details.enum = Interpretations.getEnumDefinition(original);

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
      newSchema.not = this.refOrAdd(`.${name}.not`, this.dereference(original.not), this.model.components.schemas, this.copySchema)
    }
    if (original.allOf) {
      for (let index = 0; index < original.allOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.allOf.${index}`, this.dereference(original.allOf[index]), this.model.components.schemas, this.copySchema));
      }
    }
    if (original.anyOf) {
      for (let index = 0; index < original.anyOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.anyOf.${index}`, this.dereference(original.anyOf[index]), this.model.components.schemas, this.copySchema));
      }
    }
    if (original.oneOf) {
      for (let index = 0; index < original.oneOf.length; index++) {
        newSchema.allOf.push(this.refOrAdd(`.${name}.oneOf.${index}`, this.dereference(original.oneOf[index]), this.model.components.schemas, this.copySchema));
      }
    }

    if (original.additionalProperties !== undefined) {
      if (original.additionalProperties === true || original.additionalProperties === false) {
        newSchema.additionalProperties = original.additionalProperties;
      } else {
        newSchema.additionalProperties = this.refOrAdd(`${name}.additionalItemType`, this.dereference(original.additionalProperties), this.model.components.schemas, this.copySchema);
      }
    }

    if (original.properties) {
      for (const propertyName in original.properties) {
        const property = original.properties[propertyName];
        const propertySchema = this.dereference(<Refable<OpenAPI.Schema>>property);
        const newPropSchema = this.refOrAdd(`${name[0] == '.' ? name : "." + name}.${propertyName}`, propertySchema, this.model.components.schemas, this.copySchema);
        newSchema.properties[propertyName] = new PropertyReference(propertyName, {
          schema: newPropSchema,
          description: Interpretations.getDescription(Interpretations.getDescription("", newPropSchema), property),

          details: {
            description: Interpretations.getDescription(Interpretations.getDescription("", newPropSchema), property),
            name: Interpretations.getName(propertyName, propertySchema.instance),
            deprecationMessage: Interpretations.getDeprecationMessage(original),
            privateData: {},
          }
        })
      }
    }
    return newSchema;
  }

  private refOrAdd<TSource, TDestination>(nameIfInline: string, ref: Dereferenced<TSource>, dictionary: Dictionary<TDestination>, copyFunc: (name: string, source: TSource) => TDestination): TDestination {
    if (!ref.name) {
      // inline definition - extract it out
      return this.editor.add(nameIfInline, ref, dictionary, copyFunc);
    }

    // it's a reference, make sure it's in the model.
    if (dictionary[ref.name]) {
      return dictionary[ref.name];
    }

    // it's a global instance that we haven't yet addded, add it and return the ref.
    return this.editor.add(ref.name, ref, dictionary, copyFunc);
  }


  copyParameter(name: string, original: OpenAPI.Parameter, implementationLocation: ImplementationLocation = ImplementationLocation.Client): Parameter {

    const location = Interpretations.getParameterImplementationLocation(implementationLocation, original)

    const style = OpenAPI.isCookieParameter(original) ? EncodingStyle.Form :
      /* Header must be Simple */
      OpenAPI.isHeaderParameter(original) ? EncodingStyle.Simple :
        /* Path must be Matrix|Label|Simple(default) */
        OpenAPI.isPathParameter(original) ? (original.style === EncodingStyle.Matrix || original.style === EncodingStyle.Label ? original.style : EncodingStyle.Simple) :
          /* Query must be DeepObject|PipeDelimited|SpaceDelimited|Form(default) */
          (original.style === EncodingStyle.DeepObject || original.style === EncodingStyle.PipeDelimited || original.style === EncodingStyle.SpaceDelimited ? original.style : EncodingStyle.Form);


    const newParameter = new Parameter(original.name, original.in, location, {
      allowEmptyValue: (OpenAPI.isQueryParameter(original) && original.allowEmptyValue) || false,
      description: Interpretations.getDescription("", original),
      required: original.required || false,
      deprecated: original.deprecated || false,
      style: style,
      explode: original.explode || (style === EncodingStyle.Form ? true : false),
      allowReserved: OpenAPI.isQueryParameter(original) && original.allowReserved ? true : false,
      schema: OpenAPI.hasSchema(original) ? this.refOrAdd(`.Parameter.${name}`, this.dereference(original.schema), this.model.components.schemas, this.copySchema) : undefined,
      extensions: getExtensionProperties(original),
    });

    newParameter.details.name = Interpretations.getName(original.name, original);
    newParameter.details.deprecationMessage = Interpretations.getDeprecationMessage(original);
    newParameter.details.description = Interpretations.getDescription("", original);

    // TODO: not handled: Examples, Example, Content

    return newParameter;
  }

  remodelParameters(source: Dictionary<Refable<OpenAPI.Parameter>>) {
    for (const parameterName in source) {
      this.refOrAdd(parameterName, this.dereference(source[parameterName]), this.model.components.parameters, (n, o) => this.copyParameter(n, o, ImplementationLocation.Client));
    }
  }

  copyOperation = (name: string, original: { method: HttpMethod, path: string, operation: OpenAPI.HttpOperation, pathItem: OpenAPI.PathItem }): HttpOperation => {
    const newOperation = new HttpOperation(name, original.path, original.method, {
      pathDescription: original.pathItem.description,
      pathSummary: original.pathItem.summary,
      pathExtensions: getExtensionProperties(original.pathItem),
      deprecated: original.operation.deprecated || false,
      description: Interpretations.getDescription(original.pathItem.description, original.operation),
      extensions: getExtensionProperties(original.operation),
      operationId: name,
      path: original.path,
      servers: Interpretations.getServers(original.operation.servers, original.pathItem.servers, this.oai.servers),
      externalDocs: Interpretations.getExternalDocs(original.operation.externalDocs),
      tags: original.operation.tags ? [...original.operation.tags] : [],
      summary: original.operation.summary,
      requestBody: original.operation.requestBody ? this.refOrAdd(`.${name}.requestBody`, this.dereference(original.operation.requestBody), this.model.components.requestBodies, this.copyRequestBody) : undefined,
      callbacks: todo_unimplemented,
      security: todo_unimplemented
    });

    if (original.operation.parameters) {
      for (const parameterName of original.operation.parameters) {
        const p = this.dereference(parameterName);
        newOperation.parameters.push(this.refOrAdd(`${name}.${p.instance.name}`, p, this.model.components.parameters, (n, o) => this.copyParameter(n, o, ImplementationLocation.Method)));
      }
    }
    // move responses to global section.
    for (const responseCode in original.operation.responses) {
      newOperation.responses[responseCode] = this.refOrAdd(`.${name}.${responseCode}`, this.dereference(original.operation.responses[responseCode]), this.model.components.responses, this.copyResponse);
    }

    return newOperation;
  }

  copyHeader = (headerName: string, original: OpenAPI.Header): Header => {
    const newHeader = new Header({
      deprecated: original.deprecated || false,
      description: Interpretations.getDescription("", original),
      allowReserved: original.allowReserved ? true : false,
      explode: original.explode || false,
      extensions: getExtensionProperties(original),
      schema: OpenAPI.hasSchema(original) ? this.refOrAdd(`.Header.${headerName}`, this.dereference(original.schema), this.model.components.schemas, this.copySchema) : undefined,
      required: original.required || false,
      content: todo_unimplemented,
      allowEmptyValue: false // REALLY? this seems funny.
    });

    // TODO: not handled: Examples, Example, Content

    return newHeader;
  }

  copyHeaders = (containerName: string, original?: Dictionary<Refable<OpenAPI.Header>>): Dictionary<Header> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.components.headers, this.copyHeader)) : new Dictionary<Header>();
  }

  copyLinks = (containerName: string, original?: Dictionary<Refable<OpenAPI.Link>>): Dictionary<Link> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.components.links, this.copyLink)) : new Dictionary<Link>();
  }

  copyEncoding = (encodingName: string, original: OpenAPI.Encoding): Encoding => {
    return new Encoding({
      contentType: original.contentType,
      headers: this.copyHeaders(encodingName, original.headers),
      style: original.style,
      explode: original.explode || original.style === OpenAPI.EncodingStyle.Form ? true : false,
      allowReserved: original.allowReserved || false
    })
  }

  copyEncodings(original?: Dictionary<OpenAPI.Encoding>): Dictionary<Encoding> {
    return original ? CopyDictionary(original, (v) => this.copyEncoding(v, original[v])) : new Dictionary<Encoding>();
  }

  copyMediaType = (schemaName: string, original: OpenAPI.MediaType): MediaType => {
    return new MediaType({
      schema: original.schema ? this.refOrAdd(schemaName, this.dereference(original.schema), this.model.components.schemas, this.copySchema) : undefined,
      encoding: this.copyEncodings(original.encoding),
      extensions: getExtensionProperties(original),
    });
  }


  remodelPaths(source: Dictionary<Refable<OpenAPI.PathItem>>) {
    for (const path in source) {
      const pathItem = this.dereference(source[path]);
      if (!pathItem.name) {
        for (const method of [HttpMethod.Delete, HttpMethod.Get, HttpMethod.Head, HttpMethod.Options, HttpMethod.Patch, HttpMethod.Post, HttpMethod.Put, HttpMethod.Trace]) {
          const op = <OpenAPI.HttpOperation>pathItem.instance[method];
          if (op) {
            this.editor.add(Interpretations.getOperationId(method, path, op), { instance: { method: method, path, operation: op, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation);
          }
        }
      }
    }
  }


  copyResponse = (name: string, original: OpenAPI.Response): Response => {
    const response = new Response(original.description || "", {
      // content: this.copyMediaTypes(name, original),
      extensions: getExtensionProperties(original),
      headers: this.copyHeaders(name, original.headers),
      links: this.copyLinks(name, original.links),
    });

    if (original.content) {
      for (const mediaType in original.content) {
        response.content[mediaType] = this.copyMediaType(`${name}.${mediaType}`, original.content[mediaType]);
      }
    }

    return response;
  }

  copyRequestBody = (name: string, original: OpenAPI.RequestBody): RequestBody => {
    const requestBody = new RequestBody({
      description: Interpretations.getDescription("", original),
      extensions: getExtensionProperties(original),
      required: original.required ? original.required : false,
    })

    if (original.content) {
      for (const mediaType in original.content) {
        requestBody.content[mediaType] = this.copyMediaType(`${name}.${mediaType}`, original.content[mediaType]);
      }
    }

    return requestBody;
  }

  copyCallback = (name: string, original: OpenAPI.Callback): Callback => {
    const callback = new Callback();
    return callback;
  }
  copyExample = (name: string, original: OpenAPI.Example): Example => {
    const example = new Example();
    return example;
  }
  copyLink = (name: string, original: OpenAPI.Link): Link => {
    const link = new Link({
      description: original.description,
      extensions: getExtensionProperties(original),
      operationId: original.operationId,
      operationRef: original.operationRef,
      parameters: todo_unimplemented,
      requestBody: todo_unimplemented,
      server: original.server ? Interpretations.copyServer(original.server) : undefined
    });
    return link;
  }

  /*
  // todo: unimplementd
  copySecurityScheme = (name: string, original: OpenAPI.SecurityScheme): SecurityScheme => {
    const securityScheme = todo_unimplemented;
    return securityScheme;
  }
*/

  remodelT<TSource, TDestination>(source: Dictionary<Refable<TSource>>, target: Dictionary<TDestination>, copyFunc: (name: string, source: TSource) => TDestination): Dictionary<TDestination> {
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
        this.remodelT(this.oai.components.schemas, this.model.components.schemas, this.copySchema);
      }
      if (this.oai.components.parameters) {
        this.remodelParameters(this.oai.components.parameters);
      }
      if (this.oai.components.headers) {
        this.remodelT(this.oai.components.headers, this.model.components.headers, this.copyHeader);
      }
      if (this.oai.components.requestBodies) {
        this.remodelT(this.oai.components.requestBodies, this.model.components.requestBodies, this.copyRequestBody);
      }
      if (this.oai.components.responses) {
        this.remodelT(this.oai.components.responses, this.model.components.responses, this.copyResponse);
      }
      /* todo: not implemented
      if (this.oai.components.callbacks) {
        this.remodelT(this.oai.components.callbacks, this.model.components.callbacks, this.copyCallback, (i) => new Callback(i));
      }
      */
      if (this.oai.components.examples) {
        this.remodelT(this.oai.components.examples, this.model.components.examples, this.copyExample);
      }
      if (this.oai.components.links) {
        this.remodelT(this.oai.components.links, this.model.components.links, this.copyLink);
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
      this.remodelSecurity(this.oai.security)
    }
    if (this.oai.servers) {
      this.remodelServers(this.oai.servers)
    }
    if (this.oai.tags) {
      this.remodelTags(this.oai.tags)
    }
    if (this.oai.externalDocs) {
      this.model.externalDocs = Interpretations.getExternalDocs(this.oai.externalDocs)
    }

    return this.model;
  }
}


  /*
   remodelSchemas(source: Dictionary<Refable<OpenAPI.Schema>>) {
    for (const name in source) {
      // take each schema and copy it across
      // only add if it didn't get done before.
      this.refOrAdd(name, this.dereference(source[name]), this.model.components.schemas, this.copySchema, (i) => new Schema(i));
    }
  }
   remodelResponses(source: Dictionary<Refable<OpenAPI.Response>>) {
    for (const responseName in source) {
      this.refOrAdd(responseName, this.dereference(source[responseName]), this.model.components.requestBodies, this.copyResponse, (i) => new RequestBody(i));
    }
  }

  remodelRequestBodies(source: Dictionary<Refable<OpenAPI.RequestBody>>) {
    for (const bodyName in source) {
      this.refOrAdd(bodyName, this.dereference(source[bodyName]), this.model.components.requestBodies, this.copyRequestBody, (i) => new RequestBody(i));
    }
  }

  remodelHeaders(source: Dictionary<Refable<OpenAPI.Header>>) {
    for (const headerName in source) {
      this.refOrAdd(headerName, this.dereference(source[headerName]), this.model.components.headers, this.copyHeader, (i) => new Header(i));
    }
  }
  */
