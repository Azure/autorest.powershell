/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from '#common/code-model/code-model';
import { processCodeModel } from '#common/process-code-model';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host): Promise<void> {
  return processCodeModel(createCommandOperations, service);
}

/** attempts to create command operations for each http operation */
async function createCommandOperations(model: Model, service: Host): Promise<Model> {
  for (const operation of Object.values(model.http.operations)) {
    // const names = getCommandName(operation.details.name, service.Message);

  }
  return model;
}
