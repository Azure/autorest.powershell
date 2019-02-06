/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';
import { processRequest as remodelerProcessRequest } from './plugin-remodeler';
import { tweakModelPlugin } from './plugin-tweak-model'
import { addApiVersionConstant } from './plugin-add-apiversion-constant'
import { tweakModelAzurePlugin } from './plugin-tweak-model-azure'
import { createInlinedPropertiesPlugin } from './plugin-create-inline-properties';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // add remodeler plugin
  pluginHost.Add('remodeler', remodelerProcessRequest);
  pluginHost.Add('add-apiversion-constant', addApiVersionConstant);
  pluginHost.Add('tweakcodemodel', tweakModelPlugin);
  pluginHost.Add('tweakcodemodelazure', tweakModelAzurePlugin);
  pluginHost.Add('create-virtual-properties', createInlinedPropertiesPlugin);

  await pluginHost.Run();
}

main();
