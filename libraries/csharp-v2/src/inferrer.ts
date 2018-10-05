/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { codemodel, processCodeModel } from '@microsoft.azure/autorest.codegen';

import { Host } from '@microsoft.azure/autorest-extension-base';

export async function process(service: Host) {
  return processCodeModel(inferStuff, service);
}

async function inferStuff(model: codemodel.Model, service: Host): Promise<codemodel.Model> {
  return model;
}
