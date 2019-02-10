/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { ModelState, codemodel } from '@microsoft.azure/autorest.codemodel-v3';
import { deserialize, serialize } from '@microsoft.azure/codegen';
import { Host } from '@microsoft.azure/autorest-extension-base';
import * as OpenAPI from '@microsoft.azure/openapi';
import { Transformer, visit, Node } from "@microsoft.azure/datastore";
import { clone } from '@microsoft.azure/linq';

class Remodeler extends Transformer<OpenAPI.Model, codemodel.Model> {
  async process(target: codemodel.Model, nodes: Iterable<Node>) {

  }
}

export class Source {
  constructor(public key: string, private content: string) {
  }
  ReadObject<T>() {
    return deserialize<T>(this.key, this.content);
  }
}

export async function processRequest(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs();

    // get the openapi document
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }
    const original = await service.ReadFile(files[0]);

    const source = new Source(files[0], original);

    // deserialize
    const remodeler = new Remodeler(source);

    // output the model
    service.WriteFile('code-model-v3.yaml', serialize(await remodeler.getOutput()), undefined /* await remodeler.getSourceMappings() */, 'code-model-v3');

  } catch (E) {
    console.error(`${__filename} - FAILURE ${JSON.stringify(E)}`);
    throw E;

  }
}
