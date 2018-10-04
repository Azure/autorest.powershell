/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import {process as llcsharp} from '#csharp/lowlevel-generator/main';
import {process as csnamer} from '#csharp/namer';
import {process as createcommands} from '#powershell/create-commands';
import {processRequest as powershell} from '#powershell/powershell-generator';
import {process as psnamer} from '#powershell/psnamer';
import {process as remodeler} from '#remodeler/main';
import {process as tweakCodeModel} from '#remodeler/tweak-model';
import {process as tweakCodeModelAzure} from '#remodeler/tweak-model-azure';
import {AutoRestExtension,} from '@microsoft.azure/autorest-extension-base';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // remodeler extensions
  pluginHost.Add('remodeler', remodeler);

  pluginHost.Add('tweakcodemodel', tweakCodeModel);
  pluginHost.Add('tweakcodemodelazure', tweakCodeModelAzure);

  pluginHost.Add('csnamer', csnamer);

  pluginHost.Add('llcsharp', llcsharp);
  pluginHost.Add('psnamer', psnamer);
  pluginHost.Add('powershell', powershell);

  // powershell extensions
  pluginHost.Add('create-commands', createcommands);

  await pluginHost.Run();
}

main();
