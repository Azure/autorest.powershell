/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { suite, test } from 'mocha-typescript';
import * as assert from 'assert';
import { getDeduplicatedNoun } from '../plugins/ps-namer';

@suite class TestNounCleaning {

  @test async 'deduplicate information from the cmdlet noun'() {
    const subjectPrefix1 = 'AppConfiguration';
    const subject1 = 'ConfigurationStore';
    const expectedNounParts1 = { subject: 'ConfigurationStore', subjectPrefix: 'App' };
    const actual1 = getDeduplicatedNoun(subjectPrefix1, subject1);
    assert.deepStrictEqual(actual1, expectedNounParts1);


    const subjectPrefix2 = 'AppConfiguration';
    const subject2 = 'ConfigurationStoreKey';
    const expectedNounParts2 = { subject: 'ConfigurationStoreKey', subjectPrefix: 'App' };
    const actual2 = getDeduplicatedNoun(subjectPrefix2, subject2);
    assert.deepStrictEqual(actual2, expectedNounParts2);

    const subjectPrefix3 = 'ContainerService';
    const subject3 = 'ContainerService';
    const expectedNounParts3 = { subject: 'ContainerService', subjectPrefix: '' };
    const actual3 = getDeduplicatedNoun(subjectPrefix3, subject3);
    assert.deepStrictEqual(actual3, expectedNounParts3);

    const subjectPrefix4 = 'ContainerService';
    const subject4 = 'ContainerServiceSomething';
    const expectedNounParts4 = { subject: 'ContainerServiceSomething', subjectPrefix: '' };
    const actual4 = getDeduplicatedNoun(subjectPrefix4, subject4);
    assert.deepStrictEqual(actual4, expectedNounParts4);

    const subjectPrefix5 = 'WebFoo';
    const subject5 = 'BarFooBarBlah';
    const expectedNounParts5 = { subject: 'FooBarBlah', subjectPrefix: 'Web' };
    const actual5 = getDeduplicatedNoun(subjectPrefix5, subject5);
    assert.deepStrictEqual(actual5, expectedNounParts5);

    const subjectPrefix6 = 'Hi';
    const subject6 = 'HelloHiHolaHallo';
    const expectedNounParts6 = { subject: 'HelloHiHolaHallo', subjectPrefix: 'Hi' };
    const actual6 = getDeduplicatedNoun(subjectPrefix6, subject6);
    assert.deepStrictEqual(actual6, expectedNounParts6);
  }
}