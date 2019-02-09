/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';

import { createCommands } from './plugin-create-commands'
import { powershell } from './plugin-powershell';
import { namer } from './plugin-namer'
import { cosmeticModifier } from './cosmetic-modifier'
import { structuralModifier } from './structural-modifier';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // add plugins
  pluginHost.Add('powershell', powershell);
  pluginHost.Add('create-commands', createCommands);
  pluginHost.Add('psnamer', namer);
  pluginHost.Add('cosmetic-modifier', cosmeticModifier);
  pluginHost.Add('structural-modifier', structuralModifier);

  await pluginHost.Run();
}

main();
