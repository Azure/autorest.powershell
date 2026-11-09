/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import { execFileSync } from 'child_process';
import { mkdtempSync, readFileSync, readdirSync, rmSync } from 'fs';
import { tmpdir } from 'os';
import { join, resolve } from 'path';

describe('LRO request header isolation runtime', function () {
  this.timeout(60000);

  it('preserves retry and shared headers while isolating polling and final GETs', function () {
    const output = execFileSync('pwsh', [
      '-NoProfile', '-File', resolve(__dirname, '../../test/resources/runtime/Test-LroRequestHeaders.ps1'),
      '-RuntimePath', resolve(__dirname, '../../resources/runtime/csharp/pipeline/ISendAsync.cs')
    ], { encoding: 'utf8', timeout: 55000 });
    const passed: Array<string> = JSON.parse(output);
    assert.deepStrictEqual(passed.sort(), [
      'CaseInsensitiveScopes',
      'ContentRetryPreservesScope',
      'CrossOriginCredentialIsolation',
      'FinalGetExcludesNewPollingScope',
      'InvalidMetadataFailsExplicitly',
      'OriginalWriteRemainsUnmodified',
      'PaginationRetainsExistingBehavior',
      'PollingGetExcludesScopedHeaders',
      'RelativeSameOriginPreservesAuthorization',
      'RetryPreservesScopedHeaders',
      'SharedHeadersAndContextSurvive',
      'UnmarkedHeadersSurvive'
    ].sort());
  });

  it('emits the scoped helper for both polling and final GETs', function () {
    this.timeout(180000);
    const output = mkdtempSync(join(tmpdir(), 'autorest-lro-headers-'));
    try {
      execFileSync(process.execPath, [
        require.resolve('autorest/entrypoints/app.js'),
        `--use:${resolve(__dirname, '../..')}`,
        '--powershell', '--azure-arm:true',
        `--input-file:${resolve(__dirname, '../../test/resources/runtime/lro-headers.yaml')}`,
        `--output-folder:${output}`,
        '--namespace:Microsoft.Azure.PowerShell.Cmdlets.LroHeaders',
        '--module-name:Az.LroHeaders'
      ], { encoding: 'utf8', timeout: 170000 });
      const apiFolder = join(output, 'generated', 'api');
      const apis = readdirSync(apiFolder).filter(name => name.endsWith('.cs'))
        .map(name => readFileSync(join(apiFolder, name), 'utf8')).join('\n');
      assert.ok(apis.includes('Events.DelayBeforePolling'), 'Fixture must generate an LRO polling loop.');
      const helperCalls = apis.match(/request = request\.CloneForFollowUpGetAndDispose\(/g) || [];
      assert.ok(helperCalls.length >= 2, 'Both polling and final GET must use the helper.');
      assert.ok(!apis.includes('.CloneAndDispose('), 'LRO fixture must not use ordinary GET cloning.');
      const runtime = readFileSync(join(output, 'generated', 'runtime', 'ISendAsync.cs'), 'utf8');
      assert.ok(runtime.includes('includeRequestScopedHeaders: false'), 'Generated runtime must include scoped copying.');
    } finally {
      rmSync(output, { recursive: true, force: true });
    }
  });
});
