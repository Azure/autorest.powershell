import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { safeLoad, safeDump, dump, DEFAULT_FULL_SCHEMA, DEFAULT_SAFE_SCHEMA } from "js-yaml"
import * as OpenAPI from "./oai3";
import { dereference, getExtensionProperties, Reference, Dictionary, Refable, Dereferenced, isReference } from "./common";
import { Model as CodeModel, Server, SecurityRequirement, Schema, Discriminator, ExternalDocumentation, XML, PropertyReference } from "./code-model";
import { CodeModelEditor } from "./code-model-editor";

import { inspect } from "util"

const propertyPriority = [
  "schemas",
  "name",
  "type",
  "format",
  "schema",
  "description"
];

function sortWithPriorty(a: any, b: any): number {
  if (a == b) {
    return 0;
  }
  const ia = propertyPriority.indexOf(a);
  const ib = propertyPriority.indexOf(b);
  if (ia != -1) {
    return ib != -1 ? ia - ib : -1;
  }

  return ib != -1 || a > b ? 1 : a < b ? -1 : 0;
}

async function deserialize<T>(text: string, filename: string) {
  return <T>safeLoad(await text, {
    filename: filename,
  });
}

function serialize<T>(model: T): string {
  return dump(model, { sortKeys: sortWithPriorty, schema: DEFAULT_SAFE_SCHEMA, skipInvalid: true });
}

class Remodler {

  private model: CodeModel;
  private editor: CodeModelEditor;

  constructor(private oai: OpenAPI.Model, private service: Host) {
    this.model = new CodeModel(this.oai.info.title, this.oai.info.version);
    this.editor = new CodeModelEditor(this.model);
  }

  private dereference<T>(item: Refable<T>): Dereferenced<T> {
    return dereference(this.oai, item);
  }
  private dereferenceProperty(item: any): Dereferenced<OpenAPI.Schema> {
    return dereference(this.oai, item);
  }

  private error(text: string, details: string) {
    this.service.Message({ Channel: Channel.Error, Text: text, Details: details });
  }

  // "array" | "boolean" | "integer" | "number" | "object" | "string"
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
      name: typeof (original["x-ms-client-name"]) === "string" ? original["x-ms-client-name"] : name,
      description: original.description,
    };
  }
  copySchemaArray(name: string, original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxItems = original.maxItems;
    newSchema.minItems = original.minItems;
    newSchema.uniqueItems = original.uniqueItems;
    if (original.items) {
      console.error()
      newSchema.items = this.refOrAddSchema(`${name}.itemType`, this.dereference(original.items))
    }
  }
  copySchemaString(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxLength = original.maxLength;
    newSchema.minLength = original.minLength;
    newSchema.pattern = original.pattern;
  }

  copySchema(name: string, original: OpenAPI.Schema): Schema {
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
      case "integer":
      case "number":
        this.copySchemaIntegerOrNumber(original, newSchema);
        break;
      case "object":
        this.copySchemaObject(name, original, newSchema);
        break;
      case "array":
        this.copySchemaArray(name, original, newSchema);
        break;
      case "string":
        this.copySchemaString(original, newSchema);
        break;
      case undefined:
        this.copySchemaIntegerOrNumber(original, newSchema);
        this.copySchemaObject(name, original, newSchema);
        this.copySchemaArray(name, original, newSchema);
        this.copySchemaString(original, newSchema);
        break;
      case 'boolean':
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
    if (original.externalDocs && original.externalDocs.url) {
      newSchema.externalDocs = new ExternalDocumentation(original.externalDocs.url, {
        extensions: getExtensionProperties(original.externalDocs),
        description: original.externalDocs.description
      });
    }

    // XML
    if (original.xml) {
      newSchema.xml = new XML({
        extensions: getExtensionProperties(original.externalDocs),
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
        const pschema = this.dereferenceProperty(property);
        const newPropSchema = this.refOrAddSchema(`${name[0] == '.' ? name : "." + name}.${propertyName}`, pschema);
        newSchema.properties[propertyName] = new PropertyReference({
          $ref: newPropSchema.$ref,
          description: property.description || newPropSchema.$ref.description,
          details: {
            description: property.description || newPropSchema.$ref.description,
            name: typeof (pschema.instance["x-ms-client-name"]) === "string" ? pschema.instance["x-ms-client-name"] : propertyName
          }
        })

      }
    }

    return newSchema;
  }

  private refOrAddSchema(nameIfInline: string, ref: Dereferenced<OpenAPI.Schema>) {
    if (!ref.name) {
      // inline schema - extract it out
      return new Reference(this.editor.add(nameIfInline, ref, this.model.components.schemas, (n, o) => this.copySchema(n, o), (i) => new Schema(i)));
    }
    // it's a reference, make sure it's in the model.
    if (this.model.components.schemas[ref.name]) {
      return new Reference(this.model.components.schemas[ref.name].$ref);
    }
    return new Reference(this.editor.add(ref.name, ref, this.model.components.schemas, (n, o) => this.copySchema(n, o), (i) => new Schema(i)))
  }

  remodelSchemas(source: Dictionary<Refable<OpenAPI.Schema>>) {
    for (const name in source) {
      // take each schema and copy it across
      // schema should have name and 
      if (!this.model.components.schemas[name]) {
        // only add if it didn't get done before.
        this.editor.add(name, this.dereference(source[name]), this.model.components.schemas, (n, o) => this.copySchema(n, o), (i) => new Schema(i));
      }
    }
  }

  remodelParameters(source: Dictionary<Refable<OpenAPI.Parameter>>) {
    for (const parameterName in source) {
      const parameter = this.dereference(source[parameterName]);


      // this.editor.add(parameterName, this.dereference(source[parameterName]), this.model.components.parameters, (n, o) => this.copyParameter(n, o), (i) => new Parameter(i));

    }
  }

  remodelPaths(source: Dictionary<Refable<OpenAPI.PathItem>>) {
    for (const name in source) {

    }
  }

  remodelSecuritySchemes(source: Dictionary<Refable<OpenAPI.SecurityScheme>>) {

  }
  remodelLinks(source: Dictionary<Refable<OpenAPI.Link>>) {

  }
  remodelExamples(source: Dictionary<Refable<OpenAPI.Example>>) {

  }
  remodelCallbacks(source: Dictionary<Refable<OpenAPI.Callback>>) {

  }
  remodelResponses(source: Dictionary<Refable<OpenAPI.Response>>) {

  }
  remodelRequestBodies(source: Dictionary<Refable<OpenAPI.RequestBody>>) {

  }
  remodelHeaders(source: Dictionary<Refable<OpenAPI.Header>>) {

  }
  remodelDocs(source: OpenAPI.ExternalDocumentation) {

  }
  remodelTags(arg0: Array<OpenAPI.Tag>) {

  }
  remodelServers(source: Array<OpenAPI.Server>) {

  }
  remodelSecurity(source: Array<Dictionary<string>>) {

  }

  remodel(): CodeModel {
    if (this.oai.components) {
      if (this.oai.components.schemas) {
        this.remodelSchemas(this.oai.components.schemas);
      }
      if (this.oai.components.parameters) {
        this.remodelParameters(this.oai.components.parameters);
      }
      if (this.oai.components.headers) {
        this.remodelHeaders(this.oai.components.headers);
      }
      if (this.oai.components.requestBodies) {
        this.remodelRequestBodies(this.oai.components.requestBodies);
      }
      if (this.oai.components.responses) {
        this.remodelResponses(this.oai.components.responses);
      }
      if (this.oai.components.callbacks) {
        this.remodelCallbacks(this.oai.components.callbacks);
      }
      if (this.oai.components.examples) {
        this.remodelExamples(this.oai.components.examples);
      }
      if (this.oai.components.links) {
        this.remodelLinks(this.oai.components.links);
      }
      if (this.oai.components.securitySchemes) {
        this.remodelSecuritySchemes(this.oai.components.securitySchemes);
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
      this.remodelDocs(this.oai.externalDocs)
    }



    // const a = deReference(this.oai, schema.additionalProperties);
    // const extensions = getExtensionProperties(schema);

    // look for models that are not in the global section
    // move the model to the global section (give it a name if you can), add a ref in its place

    // add additional metadata (ie, things the current modeler would make decisions for)
    // ?? fill in assumptions ??
    return this.model;
  }
}

export async function process(service: Host) {
  // Get the list of files 
  const files = await service.ListInputs();

  // get the openapi document
  if (files.length != 1) {
    throw new Error("Inputs missing.");
  }

  // deserialize
  const remodeler = new Remodler(await deserialize<OpenAPI.Model>(await service.ReadFile(files[0]), files[0]), service);

  // go!
  const codeModel = remodeler.remodel();

  // console.error(require("util").inspect(codeModel));

  // output the model 
  await service.WriteFile("somefile.txt", serialize(codeModel), undefined/*,"code-model-v2"*/);

}