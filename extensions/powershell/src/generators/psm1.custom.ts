import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { PSScriptFile } from '../file-formats/psscript-file';
import { relative } from 'path';

export async function generatePsm1Custom(service: Host, project: Project) {
  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1Custom) || '');
  const dllPath = relative(project.customFolder, project.dll);
  psm1.append('Initialization', `
  # Load the private module dll
  $null = Import-Module -PassThru -Name (Join-Path $PSScriptRoot ${dllPath})
`);
  psm1.append('LoadScripts', `
  # Export custom scripts
  Get-ChildItem -Path $PSScriptRoot -Recurse -Filter '*.ps1' -File | Sort-Object Name | ForEach-Object {
    Write-Verbose "Loading script file: $($_.Name)"
    . $_.FullName
    Export-ModuleMember -Function $_.BaseName
  }
`)
  psm1.trim();
  service.WriteFile(project.psm1Custom, `${psm1}`, undefined, 'source-file-powershell');
}