/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { suite, test } from 'mocha-typescript';
import * as assert from 'assert';
import * as aio from '@azure/async-io';
import { items, values, keys, Dictionary, length } from '@azure/linq';
import { titleToAzureServiceName } from '../plugin-create-commands';

@suite class TestServiceName {

  @test async 'output service names'() {
    const titlesFile = await aio.readFile(`${__dirname}/../../test/resources/titles.txt`);
    const serviceNamesFile = await aio.readFile(`${__dirname}/../../test/resources/service-names.txt`);

    assert(titlesFile != null);
    assert(serviceNamesFile != null);

    const serviceNames = TestServiceName.normalizeEndlines(titlesFile, tl => `${tl} => ${titleToAzureServiceName(tl)}`);

    //console.log(serviceNames);
    const normalizedServiceNamesFile = TestServiceName.normalizeEndlines(serviceNamesFile, tl => tl);
    // assert.strictEqual(serviceNames, normalizedServiceNamesFile);
  }

  private static normalizeEndlines(text: string, selector: (each: string) => string) {
    return values(text.split(/\r\n|\r|\n/))
      .linq.select(tl => `${selector(tl)}\r\n`)
      .linq.toArray().join('');
  }
}