/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { processCodeModel, codemodel } from '@microsoft.azure/autorest.codemodel-v3';

import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host): Promise<void> {
  return processCodeModel(createCommandOperations, service);
}

/** attempts to create command operations for each http operation */
async function createCommandOperations(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  for (const operation of Object.values(model.http.operations)) {
    // not implemented here.
  }
  return model;
}
