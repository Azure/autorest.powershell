/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import * as fs from 'fs';
import * as path from 'path';
import { suite, test } from '@testdeck/mocha';

@suite class RuntimeHeaderForwarding {

  @test 'Credentials are not forwarded across origins'() {
    const runtimePath = path.resolve(__dirname, '../../resources/runtime/csharp/pipeline/ISendAsync.cs');
    const runtime = fs.readFileSync(runtimePath, 'utf8');

    assert.match(runtime, /original\.RequestUri\.Scheme\.Equals\(requestUri\.Scheme/);
    assert.match(runtime, /original\.RequestUri\.Host\.Equals\(requestUri\.Host/);
    assert.match(runtime, /original\.RequestUri\.Port == requestUri\.Port/);
    assert.match(runtime, /requestUri\.Scheme\.Equals\(System\.Uri\.UriSchemeHttps/);
    assert.match(runtime, /!isSameOrigin && \("Authorization"\.Equals/);
    assert.match(runtime, /"Proxy-Authorization"\.Equals/);
    assert.match(runtime, /"Cookie"\.Equals/);
  }
}