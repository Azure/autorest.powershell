/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import { suite, test } from 'mocha-typescript';

import * as pp from '../plugin-create-commands';
import { ModelState, JsonType, processCodeModel, codemodel, components, command, http, getAllProperties, } from '@azure-tools/codemodel-v3';
import { Channel, JsonPath, Mapping, RawSourceMap, Message } from '@azure-tools/autorest-extension-base';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
require('source-map-support').install();

class Host {
  inputs = ['model'];

  constructor(public input: string, public config: Dictionary<any>) {
    // test 
  }

  async ReadFile(filename: string): Promise<string> {
    return this.input;
  }
  async GetValue(key: string): Promise<any> {
    if (!key) {
      return this.config;
    }
    return this.config[key];
  }
  async ListInputs(artifactType?: string): Promise<Array<string>> {
    return this.inputs;
  }

  async ProtectFiles(path: string): Promise<void> {
    // test 
  }
  WriteFile(filename: string, content: string, sourceMap?: Array<Mapping> | RawSourceMap, artifactType?: string): void {
    // test 
  }
  Message(message: Message): void {
    // test 
  }
  UpdateConfigurationFile(filename: string, content: string): void {
    // test 
  }
  async GetConfigurationFile(filename: string): Promise<string> {
    return '';
  }
}

@suite class Testing {
  /*
    @test async 'Do tests work'() {
      const ids = (await aio.readFile(`${__dirname}/../../test/resources/operations/operation-ids.txt`)).split(/\r\n|\r|\n/);
      const config = deserialize(await aio.readFile(`${__dirname}/../../test/resources/operations/config.yaml`), 'config.yaml');
      const input = (await aio.readFile(`${__dirname}/../../test/resources/operations/model.yaml`));
  
      const results = new Dictionary<Array<string>>();
  
      const model = await new ModelState<codemodel.Model>(new Host(input, config)).init();
  
      const inferrer = await new pp.Inferrer(model).init();
  
      /*
      for (const id of ids) {
        const q = await inferrer.inferCommandNames(id, model);
  
        results[id] = q.map(each => {
          return each.variant ?
            `${each.verb}-${each.subject}_${each.variant}` :
            `${each.verb}-${each.subject}`
        });
      }
  * /
      // aio.writeFile("c:/tmp/output.yaml", serialize(results));
  
      //const names = await aio.readFile(`${__dirname}/../../test/resources/inferred-names.txt`);
  
      assert.equal(true, true, 'Sure do!');
    }
    */
}
