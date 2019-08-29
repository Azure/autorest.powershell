/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { AutoRestExtension, } from '@azure/autorest-extension-base';

import { initializePlugins as csharp } from '@azure/autorest.csharp-v2/dist/autorest-extension';
import { initializePlugins as powershell } from '@azure/autorest.powershell/dist/autorest-extension';
import { initializePlugins as remodeler } from '@azure/autorest.remodeler/dist/autorest-extension';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  await csharp(pluginHost);
  await powershell(pluginHost);
  await remodeler(pluginHost);

  await pluginHost.Run();
}

main();
