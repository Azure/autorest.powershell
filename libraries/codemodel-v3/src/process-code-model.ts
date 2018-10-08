/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Model } from './code-model/code-model';
import { deserialize, serialize } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';

export async function processCodeModel(processExtension: (input: Model, service: Host) => Promise<Model>, service: Host) {
  // Get the list of files
  const files = await service.ListInputs('code-model-v2');

  // get the openapi document
  if (files.length === 0) {
    throw new Error('Inputs missing.');
  }

  const original = await service.ReadFile(files[0]);

  // deserialize
  let codeModel = await deserialize<Model>(original, files[0]);

  codeModel = await processExtension(codeModel, service);

  // output the model
  await service.WriteFile('code-model-v2.yaml', serialize(codeModel), undefined, 'code-model-v2');
}
