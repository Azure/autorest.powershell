/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension } from '@azure-tools/autorest-extension-base';

import { llcsharp } from './plugin-llcsharp';
import { csnamer } from './plugin-namer';

export async function initializePlugins(pluginHost: AutoRestExtension) {
  // add plugins
  pluginHost.Add('csnamer', csnamer);
  pluginHost.Add('llcsharp', llcsharp);
}
