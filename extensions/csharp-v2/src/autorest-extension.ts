/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';

import { llcsharp } from './plugin-llcsharp'
import { csnamer } from './plugin-namer'

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  // add plugins
  pluginHost.Add('csnamer', csnamer);
  pluginHost.Add('llcsharp', llcsharp);

  await pluginHost.Run();
}

main();
