/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { AutoRestExtension, } from '@azure-tools/autorest-extension-base';

import { initializePlugins as powershell } from '@autorest/powershell/dist/autorest-extension';
import { initializePlugins as remodeler } from '@autorest/remodeler/dist/autorest-extension';

require('source-map-support').install();

async function main() {
  const pluginHost = new AutoRestExtension();

  await powershell(pluginHost);
  await remodeler(pluginHost);

  await pluginHost.Run();
}

main();
