/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import { suite, test, timeout } from '@testdeck/mocha';
import { execFileSync } from 'child_process';
import { copyFileSync, mkdtempSync, rmSync } from 'fs';
import { tmpdir } from 'os';
import { join, resolve } from 'path';

@suite class TestLroRequestHeaders {

  @test @timeout(300000)
  'generates, compiles, and exercises LRO request header isolation'() {
    const resources = resolve(__dirname, '../../test/resources/runtime');
    const output = mkdtempSync(join(tmpdir(), 'autorest-lro-headers-'));
    try {
      execFileSync(process.execPath, [
        require.resolve('autorest/entrypoints/app.js'),
        `--use:${resolve(__dirname, '../..')}`,
        '--powershell', '--azure-arm:true',
        `--input-file:${join(resources, 'lro-headers.yaml')}`,
        `--output-folder:${output}`,
        '--namespace:Microsoft.Azure.PowerShell.Cmdlets.LroHeaders',
        '--module-name:Az.LroHeaders'
      ], { encoding: 'utf8', timeout: 170000 });
      copyFileSync(join(resources, 'LroRequestHeaders.cs'), join(output, 'LroRequestHeaders.Tests.cs'));
      const result = execFileSync('pwsh', [
        '-NoProfile', '-File', join(resources, 'Test-LroRequestHeaders.ps1'),
        '-ModulePath', output
      ], { encoding: 'utf8', timeout: 120000 });
      const passed: Array<string> = JSON.parse(result);
      assert.deepStrictEqual(passed.sort(), [
        'CaseInsensitiveScopes',
        'ContentRetryPreservesScope',
        'CrossOriginCredentialIsolation',
        'FinalGetExcludesNewPollingScope',
        'GeneratedLroReappliesPipelineWithoutLeakingScopedHeaders',
        'InvalidMetadataFailsExplicitly',
        'OriginalWriteRemainsUnmodified',
        'PaginationRetainsExistingBehavior',
        'PollingGetExcludesScopedHeaders',
        'RelativeSameOriginPreservesAuthorization',
        'RetryPreservesScopedHeaders',
        'SharedHeadersAndContextSurvive',
        'UnmarkedHeadersSurvive'
      ].sort());
    } finally {
      rmSync(output, { recursive: true, force: true });
    }
  }
}
