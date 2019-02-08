/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codemodel-v3';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  return processCodeModel(tweakCommands, service);
}

async function tweakCommands(model: codemodel.Model, service: Host): Promise<codemodel.Model> {

  // TODO:
  // identify SubscriptionId, resourceGroup, Location parameters, and tweak them for azure-specific behavior.

  // TODO:
  // inject support for Azure Authentication into the commands

  return model;
}
