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
  protected currentInputFilename: string;

  protected async runProcess(): Promise<void> {
    if (!this.final) {
      await this.init();
      await this.process(this.generated, visit(this.current));
      await this.finish();
    }
    this.final = clone(this.generated);  // should we be freezing this?
  }

  constructor(inputFilename: string, inputModel: OpenAPI.Model) {
    super();
    this.currentInputFilename = inputFilename;
    this.current = inputModel;
  }

  async process(target: codemodel.Model, nodes: Iterable<Node>) {

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

    // deserialize
    const remodeler = new Remodeler(files[0], await deserialize<OpenAPI.Model>(await service.ReadFile(files[0]), files[0]));

    // output the model
    service.WriteFile('code-model-v3.yaml', serialize(await remodeler.getOutput()), undefined /* await remodeler.getSourceMappings() */, 'code-model-v3');

  } catch (E) {
    console.error(E);
  }
}
