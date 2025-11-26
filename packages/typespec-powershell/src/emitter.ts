import { Program, EmitContext, listServices, emitFile, resolvePath } from "@typespec/compiler";
import { serialize, deserialize } from '@azure-tools/codegen';
import { createSdkContext } from "@azure-tools/typespec-client-generator-core";
// Following files finally should be imported from @autorest/powershell
// import { ModelState } from "./powershell/utils/model-state.js";
// import { PwshModel } from "./powershell/utils/PwshModel.js";
import { getClients } from "./utils/clientUtils.js";
import { transformPwshModel } from "./convertor/convertor.js";
import { PSOptions } from "./types/interfaces.js";
import { generatePwshModule } from "@autorest/powershell";
import { readFileSync } from "fs";
import path from "path";
import { fileURLToPath } from "url";

// Function to recursively interpolate placeholders in an object
function interpolatePlaceholders(obj: any, values: any) {
  for (const key in obj) {
    if (typeof obj[key] === 'string') {
      obj[key] = obj[key].replace(/{([^}]+)}/g, (match: string, placeholder: string) => values[placeholder]);
    } else if (typeof obj[key] === 'object') {
      interpolatePlaceholders(obj[key], values);
    }
  }
}

//load configuration from configuration.md
function loadConfiguration(emitterOptions: Record<string, any>): Record<string, any> {
  const __filename = fileURLToPath(import.meta.url);
  const __dirname = path.dirname(__filename);
  const configPath = path.join(__dirname, '../../configuration.yaml');
  const configuration = deserialize<Record<string, any>>(readFileSync(configPath, 'utf8'), configPath);
  // Define the values for interpolation
  const interpolationValues = {
    'module-name': emitterOptions['module-name'] ?? configuration['module-name'],
    'service-name': emitterOptions['service-name'] ?? configuration['service-name']
  };
  interpolatePlaceholders(configuration, interpolationValues);
  // If there is overlap between the configuration and the emitter options, the emitter options will take precedence
  return { ...configuration, ...emitterOptions };
}

export async function $onEmit(context: EmitContext) {
  const program: Program = context.program;
  // Emitter options from tspconfig.json
  // ToDo: need to implement a configuration class for AzPS
  const emitterOptions: PSOptions = context.options;

  const PsContext = await createSdkContext(
    context,
    "@azure-tools/typespec-powershell",
  );
  PsContext.enableLegacyHierarchyBuilding = true;
  // const pwshModel = new PwshModel("");
  // const services = listServices(program);
  // if (!context.program.compilerOptions.noEmit) {
  //   await emitFile(context.program, {
  //     path: resolvePath(context.emitterOutputDir, "output.txt"),
  //     content: "Hello world\n" + serialize(program.stateMap(Symbol("typescript-models-" + services[0].type.name + "Client"))),
  //   });
  // }
  await generatePwshModel();
  async function generatePwshModel() {
    const clients = getClients(PsContext);
    for (const client of clients) {
      const configurations = loadConfiguration(emitterOptions);
      const model = await transformPwshModel(client, PsContext, configurations);
      if (configurations['emit-modeler-output']) {
        await emitFile(context.program, {
          path: resolvePath(context.emitterOutputDir, `${client.name}.yaml`),
          content: serialize(model),
        });
      }
      await generatePwshModule(model, configurations);
    }

  }
}
