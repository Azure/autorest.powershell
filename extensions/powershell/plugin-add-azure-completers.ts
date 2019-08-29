/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel, ModelState } from '@azure/autorest.codemodel-v3';
import { values } from '@azure/linq';
import { Host } from '@azure/autorest-extension-base';

type State = ModelState<codemodel.Model>;

const resourceGroupNames = new Set<string>([
  'resourcegroupname',
  'resourcegroup',
]);
const subscriptionIdNames = new Set<string>([
  'subscriptionid',
]);
const locationNames = new Set<string>([
  'location',
]);

async function tweakModel(state: State): Promise<codemodel.Model> {
  const model = state.model;
  for (const operation of values(model.commands.operations)) {
    for (const parameter of values(operation.parameters)) {
      const parameterName = parameter.details.csharp.name.toLowerCase();
      if (resourceGroupNames.has(parameterName)) {
        parameter.details.csharp.completer = 'ResourceGroup';
      }
      if (subscriptionIdNames.has(parameterName)) {
        parameter.details.csharp.completer = 'SubscriptionId';
      }
      if (locationNames.has(parameterName)) {
        parameter.details.csharp.completer = 'Location';
      }
      // 'Resource'
      // 'ResourceId' 
    }
  }
  return model;
}


export async function addCompleter(service: Host) {
  return processCodeModel(tweakModel, service, 'add-azure-completers');
}
