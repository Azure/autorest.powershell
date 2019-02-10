/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';
import { initializePlugins } from './autorest-extension';

require('source-map-support').install();

export async function main() {
  const pluginHost = new AutoRestExtension();
  await initializePlugins(pluginHost);
  await pluginHost.Run();
}

main();
