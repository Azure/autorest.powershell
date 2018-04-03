import { Host, ArtifactMessage, Channel, Message } from "@microsoft.azure/autorest-extension-base";
import { deserialize, serialize } from "#common/yaml";
import { processCodeModel } from "#common/process-code-model";
import { ModelState } from "#common/model-state";
import { Model, isHttpOperation, HighLevelOperation, Schema } from "#remodeler/code-model";
import { pascalCase } from "#common/text-manipulation";

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

// export function getSchemaFunctions(schema: Schema): Iterable<HighLevelOperation> {
//   const name = schema.details.name;

//   // constructor
//   const hlOp = new HighLevelOperation(`<LL>${name}_ctor`, {
//     deprecated: schema.deprecated,
//     description: `Creates a new ${name}`,
//     parameters: operation.parameters,
//     responses: {
//       result: {

//       }
//     }
//   });
//   yield hlOp;

//   // 
// }