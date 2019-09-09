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
  await pluginHost.Run();
}

main();
