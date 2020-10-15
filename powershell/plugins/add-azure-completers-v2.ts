/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { values } from '@azure-tools/linq';
import { Host } from '@azure-tools/autorest-extension-base';
import { PwshModel } from '../utils/PwshModel';
import { ModelState } from '../utils/model-state';
import { serialize } from '@azure-tools/codegen';

type State = ModelState<PwshModel>;

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

async function tweakModel(state: State): Promise<PwshModel> {
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


export async function addCompleterV2(service: Host) {
  const state = await new ModelState<PwshModel>(service).init();
  await service.WriteFile('code-model-v4-add-azure-completers-v2.yaml', serialize(await tweakModel(state)), undefined, 'code-model-v4');
}
