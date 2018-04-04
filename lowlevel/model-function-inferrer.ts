import { Host, ArtifactMessage, Channel, Message } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model, isHttpOperation, HighLevelOperation, Schema, JsonType } from "#remodeler/code-model";
import { pascalCase } from "#common/text-manipulation";
import { Dictionary } from "#remodeler/common";

export async function process(service: Host) {
  return await processCodeModel(inferSignatures, service);
}

async function inferSignatures(model: Model, service: Host): Promise<Model> {
  for (const schema of Object.values(model.components.schemas)) {
    for (const op of getSchemaFunctions(schema)) {
      model.components.operations[op.details.name] = op;
    }
  }
  return model;
}

export function* getSchemaFunctions(schema: Schema): Iterable<HighLevelOperation> {
  const name = schema.details.name;

  // potentially an object?
  if (schema.type === undefined || schema.type === JsonType.Object) {

    // constructor
    const parameters = new Dictionary<{ schema: Schema, required: boolean }>();
    for (const [propertyName, property] of Object.entries(schema.properties)) {
      parameters[propertyName] = { schema: property.schema, required: property.details.required };
    }
    const hlOp = new HighLevelOperation(`<LL>${name}_ctor`, schema.deprecated, {
      description: `Creates a new '${name}'`,
      parameters: parameters,
      responses: {
        result: { result: schema }
      }
    });
    yield hlOp;

    // getters
    for (const [propertyName, property] of Object.entries(schema.properties)) {
      const hlOp = new HighLevelOperation(`<LL>${name}_get_${propertyName}`, schema.deprecated || property.details.deprecationMessage !== undefined, {
        description: `Gets '${propertyName}' from '${name}'`,
        parameters: {
          obj: { schema: schema, required: true }
        },
        responses: {
          result: { result: property.schema },
          undefined: {}
        }
      });
      yield hlOp;
    }

  }
}