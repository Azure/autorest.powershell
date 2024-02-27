import { Program, EmitContext, listServices, emitFile, resolvePath } from "@typespec/compiler";
import { serialize } from '@azure-tools/codegen';
import { createSdkContext } from "@azure-tools/typespec-client-generator-core";
// Following files finally should be imported from @autorest/powershell
// import { ModelState } from "./powershell/utils/model-state.js";
// import { PwshModel } from "./powershell/utils/PwshModel.js";
import { getClients } from "./utils/clientUtils.js";
import { transformPwshModel } from "./convertor/convertor.js";


export async function $onEmit(context: EmitContext) {
  const program: Program = context.program;
  // Emitter options from tspconfig.json
  // ToDo: need to implement a configuration class for AzPS
  const emitterOptions = context.options;
  const PsContext = createSdkContext(
    context,
    "@azure-tools/typespec-powershell"
  );

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
      const model = await transformPwshModel(client, PsContext);
      await emitFile(context.program, {
        path: resolvePath(context.emitterOutputDir, `${client.name}.ps1`),
        content: serialize(model),
      });
    }

  }
}
