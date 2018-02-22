import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { safeLoad, safeDump, dump, DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA } from "js-yaml"
import * as OpenAPI from "./oai3";
import * as Interpretations from "./interpretations";
import { dereference, getExtensionProperties, Reference, Dictionary, Refable, Dereferenced, isReference, CopyDictionary, clone } from "./common";
import { Model as CodeModel, Server, SecurityRequirement, Schema, Discriminator, ExternalDocumentation, XML, PropertyReference, JsonType, Parameter, ParameterLocation, ImplementationLocation, EncodingStyle, HttpOperation, HttpMethod, RequestBody, MediaType, Encoding, Header, Tag, SecurityScheme, Link, Example, Response, Callback } from "./code-model";
import { CodeModelEditor } from "./code-model-editor";

const todo_unimplemented = undefined;

export class Remodeler {

  private model: CodeModel;
  private editor: CodeModelEditor;

  constructor(private oai: OpenAPI.Model, private service: Host) {
    this.model = new CodeModel(this.oai.info.title, this.oai.info.version);
    this.editor = new CodeModelEditor(this.model);
  }

  private dereference<T>(item: Refable<T>): Dereferenced<T> {
    return dereference(this.oai, item);
  }

  private error(text: string, details: string) {
    this.service.Message({ Channel: Channel.Error, Text: text, Details: details });
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
    };
  }

  copySchemaArray(name: string, original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxItems = original.maxItems;
    newSchema.minItems = original.minItems;
    newSchema.uniqueItems = original.uniqueItems;
    if (original.items) {
      newSchema.items = this.refOrAddSchema(`${name}.itemType`, this.dereference(original.items))
    }
  }

  copySchemaString(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxLength = original.maxLength;
    newSchema.minLength = original.minLength;
    newSchema.pattern = original.pattern;
  }

  copySchema = (name: string, original: OpenAPI.Schema): Schema => {
    const newSchema = new Schema({
      extensions: getExtensionProperties(original),
      type: original.type,
      title: original.title,
      description: original.description,
      format: original.format,
      nullable: original.nullable || false,
      readOnly: original.readOnly || false,
      writeOnly: original.writeOnly || false,
      deprecated: original.deprecated || false,
      required: original.required || [],

      // unbounded properties
      default: original.default,
      example: original.example,
    });

    switch (original.type) {
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
        throw new Error(`Invalid type '${original.type}' in schema`);
    }

    // copy the enum list across if it's specified
    if (original.enum) {
      newSchema.enum = [...original.enum];
    }

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
      newSchema.not = this.refOrAddSchema(`.${name}.not`, this.dereference(original.not))
    }
    if (original.allOf) {
      for (const each in original.allOf) {
        newSchema.allOf.push(this.refOrAddSchema(`.${name}.allOf.${each}`, this.dereference(original.allOf[each])));
      }
    }
    if (original.anyOf) {
      for (const each in original.anyOf) {
        newSchema.allOf.push(this.refOrAddSchema(`.${name}.anyOf.${each}`, this.dereference(original.anyOf[each])));
      }
    }
    if (original.oneOf) {
      for (const each in original.oneOf) {
        newSchema.allOf.push(this.refOrAddSchema(`.${name}.oneOf.${each}`, this.dereference(original.oneOf[each])));
      }
    }

    if (original.additionalProperties !== undefined) {
      if (original.additionalProperties === true || original.additionalProperties === false) {
        newSchema.additionalProperties = original.additionalProperties;
      } else {
        newSchema.additionalProperties = this.refOrAddSchema(`${name}.additionalItemType`, this.dereference(original.additionalProperties))
      }
    }

    if (original.properties) {
      for (const propertyName in original.properties) {
        const property = original.properties[propertyName];
        const propertySchema = this.dereference(<Refable<OpenAPI.Schema>>property);
        const newPropSchema = this.refOrAddSchema(`${name[0] == '.' ? name : "." + name}.${propertyName}`, propertySchema);
        newSchema.properties[propertyName] = new PropertyReference({
          schema: newPropSchema,
          description: Interpretations.getDescription(Interpretations.getDescription("", newPropSchema), property),

          details: {
            description: Interpretations.getDescription(Interpretations.getDescription("", newPropSchema), property),
            name: Interpretations.getName(propertyName, propertySchema.instance),
            deprecationMessage: Interpretations.getDeprecationMessage(original)
          }
        })
      }
    }
    return newSchema;
  }

  private refOrAdd<TSource, TDestination>(nameIfInline: string, ref: Dereferenced<TSource>, dictionary: Dictionary<Reference<TDestination>>, copyFunc: (name: string, source: TSource) => TDestination, newAlias: (a: Partial<TDestination>) => TDestination): Reference<TDestination> {
    if (!ref.name) {
      // inline definition - extract it out
      return this.editor.add(nameIfInline, ref, dictionary, copyFunc, newAlias);
    }

    // it's a reference, make sure it's in the model.
    if (dictionary[ref.name]) {
      return dictionary[ref.name];
    }

    // it's a global instance that we haven't yet addded, add it and return the ref.
    return this.editor.add(ref.name, ref, dictionary, copyFunc, newAlias);
  }

  private refOrAddSchema(nameIfInline: string, ref: Dereferenced<OpenAPI.Schema>) {
    return this.refOrAdd(nameIfInline, ref, this.model.components.schemas, this.copySchema, (i) => new Schema(i));
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
      schema: OpenAPI.hasSchema(original) ? this.refOrAddSchema(`.Parameter.${name}`, this.dereference(original.schema)) : undefined,
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
      this.refOrAdd(parameterName, this.dereference(source[parameterName]), this.model.components.parameters, (n, o) => this.copyParameter(n, o, ImplementationLocation.Client), (i) => new Parameter(parameterName, ParameterLocation.Alias, ImplementationLocation.Alias, i));
    }
  }

  copyOperation = (name: string, original: { method: HttpMethod, path: string, operation: OpenAPI.HttpOperation, pathItem: OpenAPI.PathItem }): HttpOperation => {
    const newOperation = new HttpOperation(original.path, original.method, {
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
      requestBody: original.operation.requestBody ? this.refOrAdd(`.${name}.requestBody`, this.dereference(original.operation.requestBody), this.model.components.requestBodies, this.copyRequestBody, (i) => new RequestBody(i)) : undefined,
      callbacks: todo_unimplemented,
      security: todo_unimplemented
    });

    if (original.operation.parameters) {
      for (const parameterName of original.operation.parameters) {
        const p = this.dereference(parameterName);
        newOperation.parameters.push(this.refOrAdd(`${name}.${p.instance.name}`, p, this.model.components.parameters, (n, o) => this.copyParameter(n, o, ImplementationLocation.Method), (i) => new Parameter(p.instance.name, ParameterLocation.Alias, ImplementationLocation.Alias, i)));
      }
    }
    // move responses to global section.
    for (const responseCode in original.operation.responses) {
      newOperation.responses[responseCode] = this.refOrAdd(`.${name}.${responseCode}`, this.dereference(original.operation.responses[responseCode]), this.model.components.responses, this.copyResponse, (i) => new Response(i.description || "", i));
    }

    return newOperation;
  }

  copyHeader = (headerName: string, original: OpenAPI.Header): Header => {
    const newHeader = new Header({});

    return newHeader;
  }

  copyHeaders = (containerName: string, original?: Dictionary<Refable<OpenAPI.Header>>): Dictionary<Reference<Header>> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.components.headers, this.copyHeader, i => new Header(i))) : new Dictionary<Reference<Header>>();
  }

  copyLinks = (containerName: string, original?: Dictionary<Refable<OpenAPI.Link>>): Dictionary<Reference<Link>> => {
    return original ? CopyDictionary(original, (v) => this.refOrAdd(`.${containerName}.${v}`, this.dereference(original[v]), this.model.components.links, this.copyLink, i => new Link(i))) : new Dictionary<Reference<Link>>();
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
      schema: original.schema ? this.refOrAddSchema(schemaName, this.dereference(original.schema)) : undefined,
      encoding: this.copyEncodings(original.encoding),
      extensions: getExtensionProperties(original),
    });
  }


  remodelPaths(source: Dictionary<Refable<OpenAPI.PathItem>>) {
    for (const path in source) {
      const pathItem = this.dereference(source[path]);
      if (!pathItem.name) {
        // it's not an alias.
        // (we're not handling any aliases to pathItems, since we're not actually implementing paths in the code model. )
        const i = pathItem.instance;
        // handle methods
        if (i.get) {
          this.editor.add(Interpretations.getOperationId("get", path, i.get), { instance: { method: HttpMethod.Get, path, operation: i.get, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.put) {
          this.editor.add(Interpretations.getOperationId("put", path, i.put), { instance: { method: HttpMethod.Put, path, operation: i.put, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.post) {
          this.editor.add(Interpretations.getOperationId("post", path, i.post), { instance: { method: HttpMethod.Post, path, operation: i.post, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.delete) {
          this.editor.add(Interpretations.getOperationId("delete", path, i.delete), { instance: { method: HttpMethod.Delete, path, operation: i.delete, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.options) {
          this.editor.add(Interpretations.getOperationId("options", path, i.options), { instance: { method: HttpMethod.Options, path, operation: i.options, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.head) {
          this.editor.add(Interpretations.getOperationId("head", path, i.head), { instance: { method: HttpMethod.Head, path, operation: i.head, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.patch) {
          this.editor.add(Interpretations.getOperationId("patch", path, i.patch), { instance: { method: HttpMethod.Patch, path, operation: i.patch, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
        }
        if (i.trace) {
          this.editor.add(Interpretations.getOperationId("trace", path, i.trace), { instance: { method: HttpMethod.Trace, path, operation: i.trace, pathItem: pathItem.instance } }, this.model.components.operations, this.copyOperation, () => null);
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

  remodelT<TSource, TDestination>(source: Dictionary<Refable<TSource>>, target: Dictionary<Reference<TDestination>>, copyFunc: (name: string, source: TSource) => TDestination, newAlias: (a: Partial<TDestination>) => TDestination): Dictionary<Reference<TDestination>> {
    const result = new Dictionary<Reference<TDestination>>();

    for (const name in source) {
      result[name] = this.refOrAdd(name, this.dereference(source[name]), target, copyFunc, newAlias);
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
        this.remodelT(this.oai.components.schemas, this.model.components.schemas, this.copySchema, (i) => new Schema(i));
      }
      if (this.oai.components.parameters) {
        this.remodelParameters(this.oai.components.parameters);
      }
      if (this.oai.components.headers) {
        this.remodelT(this.oai.components.headers, this.model.components.headers, this.copyHeader, (i) => new Header(i));
      }
      if (this.oai.components.requestBodies) {
        this.remodelT(this.oai.components.requestBodies, this.model.components.requestBodies, this.copyRequestBody, (i) => new RequestBody(i));
      }
      if (this.oai.components.responses) {
        this.remodelT(this.oai.components.responses, this.model.components.responses, this.copyResponse, (i) => new Response(i.description || "", i));
      }
      /* todo: not implemented
      if (this.oai.components.callbacks) {
        this.remodelT(this.oai.components.callbacks, this.model.components.callbacks, this.copyCallback, (i) => new Callback(i));
      }
      */
      if (this.oai.components.examples) {
        this.remodelT(this.oai.components.examples, this.model.components.examples, this.copyExample, (i) => new Example(i));
      }
      if (this.oai.components.links) {
        this.remodelT(this.oai.components.links, this.model.components.links, this.copyLink, (i) => new Link(i));
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
