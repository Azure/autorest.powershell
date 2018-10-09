/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';

import { llcsharp } from '@microsoft.azure/autorest.csharp-v2/dist/plugin-llcsharp'
import { csnamer } from '@microsoft.azure/autorest.csharp-v2/dist/plugin-namer'

import { createCommands } from '@microsoft.azure/autorest.powershell/dist/plugin-create-commands'
import { powershell } from '@microsoft.azure/autorest.powershell/dist/plugin-powershell';
import { namer } from '@microsoft.azure/autorest.powershell/dist/plugin-namer'

import { processRequest as remodelerProcessRequest } from '@microsoft.azure/autorest.remodeler/dist/plugin-remodeler';
import { tweakModelPlugin } from '@microsoft.azure/autorest.remodeler/dist/plugin-tweak-model'
import { tweakModelAzurePlugin } from '@microsoft.azure/autorest.remodeler/dist/plugin-tweak-model-azure'

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // add plugins
  pluginHost.Add('remodeler', remodelerProcessRequest);
  pluginHost.Add('tweakcodemodel', tweakModelPlugin);
  pluginHost.Add('tweakcodemodelazure', tweakModelAzurePlugin);

  pluginHost.Add('csnamer', csnamer);
  pluginHost.Add('llcsharp', llcsharp);

  pluginHost.Add('powershell', powershell);
  pluginHost.Add('create-commands', createCommands);
  pluginHost.Add('psnamer', namer);

  await pluginHost.Run();
}

main();
