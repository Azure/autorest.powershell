/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import { suite, test } from '@testdeck/mocha';

@suite class Testing {

  @test async 'Do tests work'() {
    assert.equal(true, true, 'Sure do!');
  }
}
