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
import { clearFolder, resolveUri, createFolderUri } from '@azure-tools/uri';
import { join, resolve as currentDirectory, isAbsolute } from 'path';

async function clearOutputFiles(state: ModelState<PwshModel>) {
  if (await state.getValue('clear-output-folder', false)) {
    const outputFolderConfig = await state.getValue('output-folder', './generated');
    const outputFolder = createFolderUri(isAbsolute(outputFolderConfig) ? outputFolderConfig : join(currentDirectory(), outputFolderConfig));
    const psd1: string = await state.getValue('psd1');
    const customFolder: string = await state.getValue('custom-cmdlet-folder');
    const testFolder: string = await state.getValue('test-folder');
    const docsFolder: string = await state.getValue('docs-folder');
    const examplesFolder: string = await state.getValue('examples-folder');
    const resourcesFolder: string = await state.getValue('resources-folder');
    const uxFolder: string = await state.getValue('ux-folder');
    const readme = './README.md';
    const tempTypeSpecFiles = './TempTypeSpecFiles';
    const tspLocation = './tsp-location.yaml';

    const protectFiles = new Set<string>();
    protectFiles.add(psd1);
    protectFiles.add(customFolder);
    protectFiles.add(testFolder);
    protectFiles.add(docsFolder);
    protectFiles.add(examplesFolder);
    protectFiles.add(resourcesFolder);
    protectFiles.add(uxFolder);
    protectFiles.add(readme);
    protectFiles.add(tempTypeSpecFiles);
    protectFiles.add(tspLocation);
    await clearFolder(outputFolder, [...protectFiles].map((each) => resolveUri(outputFolder, each)));
  }
  return;

}
export async function generatePwshModule(pwshModel: PwshModel, emitterOptions: any) {
  const tspService = new TspHostImpl(emitterOptions);
  const state = await new ModelState<PwshModel>(tspService);
  // clear output folder if set, but protect certain files
  await clearOutputFiles(state);
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
