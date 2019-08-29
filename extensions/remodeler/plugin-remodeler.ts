/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ModelState } from '@azure/autorest.codemodel-v3';
import { deserialize, serialize } from '@azure/codegen';
import { Host } from '@azure/autorest-extension-base';
import * as OpenAPI from '@azure/openapi';
import { Remodeler } from './remodeler';
type State = ModelState<OpenAPI.Model>;

export async function processRequest(service: Host) {
  try {
    const state = await new ModelState<OpenAPI.Model>(service).init();
    // process
    const remodeler = new Remodeler(state);

    // go!
    const codeModel = remodeler.remodel();

    // output the model to the pipeline
    service.WriteFile('code-model-v3.yaml', serialize(codeModel), undefined, 'code-model-v3');
  } catch (E) {
    console.error(`${__filename} - FAILURE  ${JSON.stringify(E)} ${E.stack}`);
    throw E;
  }
}
