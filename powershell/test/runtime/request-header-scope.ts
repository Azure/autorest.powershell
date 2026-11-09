/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import * as assert from 'assert';
import { suite, test, timeout, params } from '@testdeck/mocha';
import { execFileSync } from 'child_process';
import { copyFileSync, mkdtempSync, rmSync } from 'fs';
import { tmpdir } from 'os';
import { join, resolve } from 'path';

const plugin = resolve(__dirname, '../../..');
const resources = join(plugin, 'test', 'resources', 'runtime');

@suite(timeout(300000)) class TestRequestHeaderScope {

  private static output: string;

  static before() {
    this.output = mkdtempSync(join(tmpdir(), 'autorest-request-header-scope-'));
    this.run(process.execPath, [
      require.resolve('autorest/entrypoints/app.js'),
      `--use:${plugin}`,
      '--powershell', '--azure-arm:true',
      `--input-file:${join(resources, 'lro-request-headers.yaml')}`,
      `--output-folder:${this.output}`,
      '--namespace:Microsoft.Azure.PowerShell.Cmdlets.LroHeaders',
      '--module-name:Az.LroHeaders'
    ], 170000);
    copyFileSync(join(resources, 'RequestHeaderScopeTests.cs'), join(this.output, 'RequestHeaderScopeTests.cs'));
    this.run('dotnet', [
      'build', join(this.output, 'Az.LroHeaders.csproj'),
      '--configuration', 'Debug', '--nologo', '--verbosity', 'quiet'
    ], 120000);
  }

  static after() {
    rmSync(this.output, { recursive: true, force: true });
  }

  @test @timeout(30000)
  @params.naming((name: string) => name)
  @params('PollingGetExcludesScopedHeaders')
  @params('FinalGetExcludesNewPollingScope')
  @params('RetryClonePreservesScopedHeaders')
  @params('ContentRetryClonePreservesScope')
  @params('OriginalWriteRemainsUnmodified')
  @params('CaseInsensitiveScopes')
  @params('MultipleScopedHeadersAreExcluded')
  @params('UnmarkedHeadersSurvive')
  @params('SharedHeadersAndContextSurvive')
  @params('CrossOriginCredentialIsolation')
  @params('RelativeSameOriginPreservesAuthorization')
  @params('OrdinaryGetClonePreservesScope')
  @params('InvalidMetadataFailsExplicitly')
  @params('GeneratedLroExcludesScopedHeadersFromPollingAndFinalGet')
  'request header scope'(name: string) {
    const result = TestRequestHeaderScope.run('pwsh', [
      '-NoProfile', '-File', join(resources, 'Invoke-RequestHeaderScopeTests.ps1'),
      '-ModulePath', TestRequestHeaderScope.output, '-TestName', name
    ], 30000);
    assert.strictEqual(JSON.parse(result), name);
  }

  private static run(command: string, args: Array<string>, timeoutMs: number): string {
    try {
      return execFileSync(command, args, { encoding: 'utf8', timeout: timeoutMs });
    } catch (error) {
      if (error instanceof Error && 'stdout' in error) {
        console.error(String(error.stdout));
      }
      throw error;
    }
  }
}
