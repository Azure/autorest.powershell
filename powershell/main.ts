/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@azure-tools/autorest-extension-base';
import { createInlinedPropertiesPlugin } from './plugins/plugin-create-inline-properties';
import { tweakModelPlugin } from './plugins/plugin-tweak-model';
import { tweakModelAzurePluginV2 } from './plugins/plugin-tweak-model-azure-v2';
import { createCommandsV2 } from './plugins/create-commands-v2';
import { csnamerV2 } from './plugins/cs-namer-v2';
import { namerV2 } from './plugins/ps-namer-v2';
import { llcsharpV2 } from './plugins/llcsharp-v2';
import { powershellV2 } from './plugins/powershell-v2';
import { addCompleterV2 } from './plugins/add-azure-completers-v2';
import { applyModifiersV2 } from './plugins/modifiers-v2';
import { tweakM4ModelPlugin } from './plugins/plugin-tweak-m4-model';
import { generate } from './plugins/sdk-generate';
import { tweakSdkModelPlugin } from './plugins/sdk-tweak-model';
import { simplifierPlugin } from './plugins/sdk-cs-simplifier';
import { csnamerSdk } from './plugins/sdk-cs-namer';
import { createSdkInlinedPropertiesPlugin } from './plugins/sdk-create-inline-properties';

require('source-map-support').install();

export async function main() {
  const pluginHost = new AutoRestExtension();
  // Following are plugins moved from remodeler
  pluginHost.Add('tweakm4codemodel', tweakM4ModelPlugin);
  pluginHost.Add('tweakcodemodel-v2', tweakModelPlugin);
  pluginHost.Add('tweakcodemodelazure-v2', tweakModelAzurePluginV2);
  pluginHost.Add('create-virtual-properties-v2', createInlinedPropertiesPlugin);
  pluginHost.Add('create-commands-v2', createCommandsV2);
  pluginHost.Add('csnamer-v2', csnamerV2);
  pluginHost.Add('psnamer-v2', namerV2);
  pluginHost.Add('modifiers-v2', applyModifiersV2);
  pluginHost.Add('add-azure-completers-v2', addCompleterV2);
  pluginHost.Add('llcsharp-v2', llcsharpV2);
  pluginHost.Add('powershell-v2', powershellV2);
  pluginHost.Add('generate', generate);
  pluginHost.Add('tweakSdkModelPlugin', tweakSdkModelPlugin);
  pluginHost.Add('simplifierPlugin', simplifierPlugin);
  pluginHost.Add('csnamerSdk', csnamerSdk);
  pluginHost.Add('createSdkInlinedPropertiesPlugin', createSdkInlinedPropertiesPlugin);

  await pluginHost.Run();
}

main();
