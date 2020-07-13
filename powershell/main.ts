/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@azure-tools/autorest-extension-base';
import { applyModifiers } from './plugins/modifiers';
import { createCommands } from './plugins/create-commands';
import { namer } from './plugins/ps-namer';
import { powershell } from './plugins/powershell';
import { addCompleter } from './plugins/add-azure-completers';
import { csnamer } from './plugins/cs-namer';
import { llcsharp } from './plugins/llcsharp';
import { createInlinedPropertiesPlugin } from './plugins/plugin-create-inline-properties';
import { tweakModelPlugin } from './plugins/plugin-tweak-model';
import { tweakModelAzurePluginV2 } from './plugins/plugin-tweak-model-azure-v2';
import { createCommandsV2 } from './plugins/create-commands-v2';
import { csnamerV2 } from './plugins/cs-namer-v2';
import { namerV2 } from './plugins/ps-namer-v2';
import { llcsharpV2 } from './plugins/llcsharp-v2';
import { powershellV2 } from './plugins/powershell-v2';

require('source-map-support').install();

export async function main() {
  const pluginHost = new AutoRestExtension();
  pluginHost.Add('powershell', powershell);
  pluginHost.Add('create-commands', createCommands);
  pluginHost.Add('psnamer', namer);
  pluginHost.Add('modifiers', applyModifiers);
  pluginHost.Add('add-azure-completers', addCompleter);
  pluginHost.Add('csnamer', csnamer);
  pluginHost.Add('llcsharp', llcsharp);
  // Following are plugins moved from remodeler
  pluginHost.Add('tweakcodemodel-v2', tweakModelPlugin);
  pluginHost.Add('tweakcodemodelazure-v2', tweakModelAzurePluginV2);
  pluginHost.Add('create-virtual-properties-v2', createInlinedPropertiesPlugin);
  pluginHost.Add('create-commands-v2', createCommandsV2);
  pluginHost.Add('csnamer-v2', csnamerV2);
  pluginHost.Add('psnamer-v2', namerV2);
  pluginHost.Add('llcsharp-v2', llcsharpV2);
  pluginHost.Add('powershell-v2', powershellV2);

  await pluginHost.Run();
}

main();
