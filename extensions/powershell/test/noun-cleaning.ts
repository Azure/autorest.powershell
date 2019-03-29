/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { suite, test } from "mocha-typescript";
import * as assert from "assert";
import { getDeduplicatedSubjectPrefix } from "../plugin-namer";

@suite class TestNounCleaning {

  @test async "deduplicate information from the cmdlet noun"() {
    const subjectPrefix1 = 'AppConfiguration';
    const subject1 = 'ConfigurationStore';
    const expectedPrefix1 = 'App';

    const actual1 = getDeduplicatedSubjectPrefix(subjectPrefix1, subject1);
    assert.strictEqual(actual1, expectedPrefix1);

    const subjectPrefix2 = 'AppConfiguration';
    const subject2 = 'ConfigurationStoreKey';
    const expectedPrefix2 = 'App';

    const actual2 = getDeduplicatedSubjectPrefix(subjectPrefix2, subject2);
    assert.strictEqual(actual2, expectedPrefix2);


    const subjectPrefix3 = 'ContainerService';
    const subject3 = 'ContainerService';
    const expectedPrefix3 = '';

    const actual3 = getDeduplicatedSubjectPrefix(subjectPrefix3, subject3);
    assert.strictEqual(actual3, expectedPrefix3);


    const subjectPrefix4 = 'ContainerService';
    const subject4 = 'ContainerServiceSomething';
    const expectedPrefix4 = '';

    const actual4 = getDeduplicatedSubjectPrefix(subjectPrefix4, subject4);
    assert.strictEqual(actual4, expectedPrefix4);


    const subjectPrefix5 = 'MySomeBarSomethingFoo';
    const subject5 = 'SomeBarSomethingFoo';
    const expectedPrefix5 = 'My';

    const actual5 = getDeduplicatedSubjectPrefix(subjectPrefix5, subject5);
    assert.strictEqual(actual5, expectedPrefix5);

    const subjectPrefix6 = 'Hi';
    const subject6 = 'HelloHiHolaHallo';
    const expectedPrefix6 = 'Hi';

    const actual6 = getDeduplicatedSubjectPrefix(subjectPrefix6, subject6);
    assert.strictEqual(actual6, expectedPrefix6);
  }
}