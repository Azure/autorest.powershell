/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { PSScriptFile } from '../file-formats/psscript-file';
import { join, relative } from 'path';

export async function generatePsm1(service: Host, project: Project) {
  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1) || '');
  psm1.append('Initialization', `
  # Get this module's instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # Load the custom script module
  $scriptModulePath = Join-Path $PSScriptRoot '${project.psm1Custom}'
  if(Test-Path $scriptModulePath) {
    $null = Import-Module -Name $scriptModulePath
  }

  # Load the private module dll
  $null = Import-Module -Name (Join-Path $PSScriptRoot '${project.dll}')

  # Export nothing to clear implicit exports
  Export-ModuleMember`);

  if (project.azure) {
    const localModulesPath = relative(project.baseFolder, project.dependencyModuleFolder);
    psm1.append('AzureInitialization', `
  # Load required Az.Accounts module
  $sharedModule = Get-Module -Name Az.Accounts
  if (-not $sharedModule) {
    $accountsName = 'Az.Accounts'
    $localAccounts = Get-ChildItem -Path (Join-Path $PSScriptRoot '${localModulesPath}') -Recurse -Include 'Az.Accounts.psd1' | Select-Object -Last 1
    if($localAccounts -and (Test-Path -Path $localAccounts)) {
      $accountsName = $localAccounts.FullName
    }
    $sharedModule = Import-Module -Name $accountsName -MinimumVersion ${project.accountsVersionMinimum} -Scope Global -PassThru
  } elseif ($sharedModule.Version -lt [System.Version]'${project.accountsVersionMinimum}') {
    Write-Error 'This module requires Az.Accounts version ${project.accountsVersionMinimum} or greater. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information.' -ErrorAction Stop
  }
  Write-Information "Loaded Module '$($sharedModule.Name)'"

  # Ask for the shared functionality table
  $VTable = Register-AzModule

  # Tweaks the pipeline on module load
  $instance.OnModuleLoad = $VTable.OnModuleLoad

  # Tweaks the pipeline per call
  $instance.OnNewRequest = $VTable.OnNewRequest

  # Gets shared parameter values
  $instance.GetParameterValue = $VTable.GetParameterValue

  # Allows shared module to listen to events from this module
  $instance.EventListener = $VTable.EventListener

  # Gets shared argument completers
  $instance.ArgumentCompleter = $VTable.ArgumentCompleter

  # The name of the currently selected Azure profile
  $instance.ProfileName = $VTable.ProfileName`);
  }

  psm1.append('LoadExports', `
  # Export proxy cmdlet scripts
  $exportsPath = Join-Path $PSScriptRoot '${project.exportsFolder}'
  $directories = Get-ChildItem -Directory -Path $exportsPath
  $profileDirectory = $null
  if($instance.ProfileName) {
    if(($directories | ForEach-Object { $_.Name }) -contains $instance.ProfileName) {
      $profileDirectory = $directories | Where-Object { $_.Name -eq $instance.ProfileName }
    } else {
      # Don't export anything if the profile doesn't exist for the module
      $exportsPath = $null
      Write-Warning "Selected Azure profile '$($instance.ProfileName)' does not exist for module '$($instance.Name)'. No cmdlets were loaded."
    }
  } elseif(($directories | Measure-Object).Count -gt 0) {
    # Load the last folder if no profile is selected
    $profileDirectory = $directories | Select-Object -Last 1
  }

  if($profileDirectory) {
    Write-Information "Loaded Azure profile '$($profileDirectory.Name)' for module '$($instance.Name)'"
    $exportsPath = $profileDirectory.FullName
  }

  if($exportsPath) {
    Get-ChildItem -Path $exportsPath -Recurse -Filter '*.ps1' -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Loading script file: $($_.Name)"
      . $_.FullName
      Export-ModuleMember -Function $_.BaseName
    }
  }`);

  psm1.append('Finalization', `
  # Finalize initialization of this module
  $instance.Init();
  Write-Information "Loaded Module '$($instance.Name)'"`);

  psm1.trim();
  service.WriteFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}
