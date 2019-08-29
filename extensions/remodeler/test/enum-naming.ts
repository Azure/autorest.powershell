/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { suite, test } from 'mocha-typescript';
import * as assert from 'assert';
import { getValidEnumValueName } from '../interpretations';

@suite class TestEnumNameInterpretation {

  @test async 'get a valid enum name'() {
    const originalName1 = '*';
    const expectedName1 = 'Asterisk';

    const actual1 = getValidEnumValueName(originalName1);
    assert.strictEqual(actual1, expectedName1);

    const originalName2 = '^=+';
    const expectedName2 = 'CaretEqualsToPlusSign';

    const actual2 = getValidEnumValueName(originalName2);
    assert.strictEqual(actual2, expectedName2);

    const originalName3 = 'asd*';
    const expectedName3 = 'asd*';

    const actual3 = getValidEnumValueName(originalName3);
    assert.strictEqual(actual3, expectedName3);

    const originalName4 = '^=+asd';
    const expectedName4 = '^=+asd';

    const actual4 = getValidEnumValueName(originalName4);
    assert.strictEqual(actual4, expectedName4);

    const originalName5 = 'hello';
    const expectedName5 = 'hello';

    const actual5 = getValidEnumValueName(originalName5);
    assert.strictEqual(actual5, expectedName5);

  }
}