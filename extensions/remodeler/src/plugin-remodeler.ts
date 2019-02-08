/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ModelState } from '@microsoft.azure/autorest.codemodel-v3';
import { deserialize, serialize } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import * as OpenAPI from '@microsoft.azure/openapi';
import { Remodeler } from './remodeler';

export async function processRequest(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }

    const original = await service.ReadFile(files[0]);

    // TODO: don't use a hard-coded path
    // writeFileSync("C:/work/2018/autorest.powershell/generated/original.yaml", serialize(JSON.parse(original)));

    // deserialize
    const remodeler = new Remodeler(new ModelState(service, await deserialize<OpenAPI.Model>(await service.ReadFile(files[0]), files[0]), files[0]));

    // go!
    const codeModel = remodeler.remodel();

    // output the model
    service.WriteFile('code-model-v3.yaml', serialize(codeModel), undefined, 'code-model-v3');
    service.WriteFile('oai.yaml', original, undefined, 'source-file-other');

  } catch (E) {
    console.error(E);
  }
}
