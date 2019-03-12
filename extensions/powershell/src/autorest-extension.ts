/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { AutoRestExtension, } from '@microsoft.azure/autorest-extension-base';

import { cosmeticModifier } from './cosmetic-modifier';
import { createCommands } from './plugin-create-commands';
import { namer } from './plugin-namer';
import { powershell } from './plugin-powershell';
import { structuralModifier } from './structural-modifier';
import { addCompleter } from './plugin-add-azure-completers'

export async function initializePlugins(pluginHost: AutoRestExtension) {
  // add plugins
  pluginHost.Add('powershell', powershell);
  pluginHost.Add('create-commands', createCommands);
  pluginHost.Add('psnamer', namer);
  pluginHost.Add('cosmetic-modifier', cosmeticModifier);
  pluginHost.Add('structural-modifier', structuralModifier);
  pluginHost.Add('add-azure-completers', addCompleter);
}
