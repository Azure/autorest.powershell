import { Host, ArtifactMessage, Channel } from "@microsoft.azure/autorest-extension-base";
import { safeLoad, safeDump } from "js-yaml"
import * as OpenAPI from "./oai3";
import { dereference, getExtensionProperties, Reference, Dictionary, Refable, Dereferenced, isReference } from "./common";
import { Model as CodeModel, Server, SecurityRequirement, Schema, Discriminator, ExternalDocumentation, XML } from "./code-model";
import { CodeModelEditor } from "./code-model-editor";

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
  return safeDump(model, { sortKeys: sortWithPriorty });
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

  copySchemaObject(original: OpenAPI.Schema, newSchema: Schema) {
    newSchema.maxProperties = original.maxProperties;
    newSchema.minProperties = original.minProperties;
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

      // enums 
      enum: original.enum || []
    });


    switch (original.type) {
      case "integer":
      case "number":
        this.copySchemaIntegerOrNumber(original, newSchema);
        break;
      case "object":
        this.copySchemaObject(original, newSchema);
        break;
      case "array":
        this.copySchemaArray(name, original, newSchema);
        break;
      case "string":
        this.copySchemaString(original, newSchema);
        break;
      case undefined:
        this.copySchemaIntegerOrNumber(original, newSchema);
        this.copySchemaObject(original, newSchema);
        this.copySchemaArray(name, original, newSchema);
        this.copySchemaString(original, newSchema);
        break;
      default:
        throw new Error(`Invalid type '${original.type}' in schema`);
    }


    // object properties
    // discriminator
    if (original.discriminator && original.discriminator.propertyName) {
      newSchema.discriminator = new Discriminator(original.discriminator.propertyName, {
        extensions: getExtensionProperties(original.discriminator),
        mapping: original.discriminator.mapping
      })
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
      newSchema.not = this.refOrAddSchema(`${name}.not`, this.dereference(original.not))
    }
    if (original.allOf) {
      for (const each in original.allOf) {
        newSchema.allOf.push(this.refOrAddSchema(`${name}.allOf`, this.dereference(original.allOf[each])));
      }
    }
    if (original.anyOf) {
      for (const each in original.anyOf) {
        newSchema.allOf.push(this.refOrAddSchema(`${name}.anyOf`, this.dereference(original.anyOf[each])));
      }
    }
    if (original.oneOf) {
      for (const each in original.oneOf) {
        newSchema.allOf.push(this.refOrAddSchema(`${name}.oneOf`, this.dereference(original.oneOf[each])));
      }
    }

    if (original.additionalProperties !== undefined) {
      if (original.additionalProperties === true || original.additionalProperties === false) {
        newSchema.additionalProperties = original.additionalProperties;
      } else {
        newSchema.additionalProperties = this.refOrAddSchema(`${name}.additionalItemType`, this.dereference(original.additionalProperties))
      }
    }

    return newSchema;
  }

  private refOrAddSchema(nameIfInline: string, ref: Dereferenced<OpenAPI.Schema>) {
    if (!ref.name) {
      // inline schema - extract it out
      return new Reference(this.editor.add(nameIfInline, ref, this.model.components.schemas, this.copySchema, (i) => new Schema(i)));
    }
    // it's a reference, make sure it's in the model.
    return new Reference(this.editor.add(ref.name, ref, this.model.components.schemas, this.copySchema, (i) => new Schema(i)))

  }

  remodelSchemas(source: Dictionary<Refable<OpenAPI.Schema>>) {
    for (const name in source) {
      // take each schema and copy it across
      // schema should have name and 
      this.editor.add(name, this.dereference(source[name]), this.model.components.schemas, this.copySchema, (i) => new Schema(i));
    }
  }

  remodel(): CodeModel {

    // unroll $refs into instances
    // this.unrollReferences();

    if (this.oai.components && this.oai.components.schemas) {
      this.remodelSchemas(this.oai.components.schemas);
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

  // output the model 
  await service.WriteFile("somefile.txt", serialize(codeModel), undefined/*,"code-model-v2"*/);

}