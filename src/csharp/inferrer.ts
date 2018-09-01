/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from '#common/code-model/code-model';
import { processCodeModel } from '#common/process-code-model';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  return processCodeModel(inferStuff, service);
}

async function inferStuff(model: Model, service: Host): Promise<Model> {
  return model;
}
