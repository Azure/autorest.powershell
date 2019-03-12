/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { PSScriptFile } from '../file-formats/psscript-file';
import { relative } from 'path';

export async function generatePsm1Custom(service: Host, project: Project) {
  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1Custom) || '');
  const dllPath = relative(project.customFolder, project.dll);
  psm1.append('Initialization', `
  # Load the private module dll
  $null = Import-Module -PassThru -Name (Join-Path $PSScriptRoot '${dllPath}')
  # Export nothing to clear implicit exports
  Export-ModuleMember
`);
  psm1.append('LoadScripts', `
  # https://stackoverflow.com/a/40969712/294804
  $currentFunctions = Get-ChildItem function:
  Get-ChildItem -Path $PSScriptRoot -Recurse -Filter '*.ps1' -File | ForEach-Object { . $_.FullName }
  $scriptFunctions = Get-ChildItem function: | Where-Object { $currentFunctions -notcontains $_ }

  # Export custom scripts
  if(($scriptFunctions | Measure-Object).Count -gt 0) {
    $scriptFunctions | ForEach-Object { Export-ModuleMember -Function $_.Name }
  }
`)
  psm1.trim();
  service.WriteFile(project.psm1Custom, `${psm1}`, undefined, 'source-file-powershell');
}