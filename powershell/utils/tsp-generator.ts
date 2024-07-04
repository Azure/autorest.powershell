import { PwshModel } from '../utils/PwshModel';
import { createVirtuals } from '../plugins/plugin-create-inline-properties';
import { tweakModelV2 } from '../plugins/plugin-tweak-model';
import { tweakModel as tweakModelAzure } from '../plugins/plugin-tweak-model-azure-v2';
import { Inferrer } from '../plugins/create-commands-v2';
import { nameStuffRight } from '../plugins/cs-namer-v2';
import { tweakModel as psNamer } from '../plugins/ps-namer-v2';
import { llcsharpV2 } from '../plugins/llcsharp-v2';
import { powershellV2 } from '../plugins/powershell-v2';
import { tweakModel } from '../plugins/add-azure-completers-v2';
import { tweakModelForTsp as modifier } from '../plugins/modifiers-v2';
import { tweakModelForTsp as tweakM4Model } from '../plugins/plugin-tweak-m4-model';
import { ModelState } from './model-state';
import { TspHostImpl } from './tsp-host';
import { stat } from 'fs';
import { serialize } from '@azure-tools/codegen';

export async function generatePwshModule(pwshModel: PwshModel, emitterOptions: any) {
  const tspService = new TspHostImpl(emitterOptions);
  const state = await new ModelState<PwshModel>(tspService);
  state.model = pwshModel;
  await tweakM4Model(state);
  await tweakModelV2(state);
  await tweakModelAzure(state);
  await (await new Inferrer(state).init()).createCommands();
  await createVirtuals(state);
  await nameStuffRight(state);
  await psNamer(state);
  await modifier(state);
  await llcsharpV2(tspService, state);
  await powershellV2(tspService, state);
  return;
}