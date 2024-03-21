/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Project } from '../internal/project';
import { PSScriptFile } from '../file-formats/psscript-file';
import { relative } from 'path';


export function getProfileExportScript(exportFolderScript: string, isAzure: boolean): string {
  return `
  # Export proxy cmdlet scripts
  $exportsPath = ${exportFolderScript}
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
    Get-ChildItem -Path $exportsPath -Recurse -Include '*.ps1' -File | ForEach-Object { . $_.FullName }
    $cmdletNames = Get-ScriptCmdlet -ScriptFolder $exportsPath
    Export-ModuleMember -Function $cmdletNames -Alias (Get-ScriptCmdlet -ScriptFolder $exportsPath -AsAlias)
  }
`;
}

export async function generatePsm1(project: Project) {
  const psm1 = new PSScriptFile(await project.state.readFile(project.psm1) || '');
  let azureInitialize = '';
  if (project.azure) {
    const localModulesPath = relative(project.baseFolder, project.dependencyModuleFolder);
    let requestHandler = `
  # Tweaks the pipeline per call
  $instance.OnNewRequest = $VTable.OnNewRequest`;
    if (project.endpointResourceIdKeyName) {
      // for data plane, we should append different functions instead.
      requestHandler = `
  # Tweaks the pipeline per call
  $instance.AddRequestUserAgentHandler = $VTable.AddRequestUserAgentHandler

  # Tweaks the pipeline per call
  $instance.AddPatchRequestUriHandler = $VTable.AddPatchRequestUriHandler

  # Tweaks the pipeline per call
  $instance.AddAuthorizeRequestHandler = $VTable.AddAuthorizeRequestHandler
    `;
    }
    azureInitialize = `
  # ----------------------------------------------------------------------------------
  ${project.pwshCommentHeader}
  # ----------------------------------------------------------------------------------
  # Load required Az.Accounts module
  $accountsName = 'Az.Accounts'
  $accountsModule = Get-Module -Name $accountsName
  if(-not $accountsModule) {
    $localAccountsPath = Join-Path $PSScriptRoot '${localModulesPath}'
    if(Test-Path -Path $localAccountsPath) {
      $localAccounts = Get-ChildItem -Path $localAccountsPath -Recurse -Include 'Az.Accounts.psd1' | Select-Object -Last 1
      if($localAccounts) {
        $accountsModule = Import-Module -Name ($localAccounts.FullName) -Scope Global -PassThru
      }
    }
    if(-not $accountsModule) {
      $hasAdequateVersion = (Get-Module -Name $accountsName -ListAvailable | Where-Object { $_.Version -ge [System.Version]'${project.accountsVersionMinimum}' } | Measure-Object).Count -gt 0
      if($hasAdequateVersion) {
        $accountsModule = Import-Module -Name $accountsName -MinimumVersion ${project.accountsVersionMinimum} -Scope Global -PassThru
      }
    }
  }

  if(-not $accountsModule) {
    Write-Error "\`nThis module requires $accountsName version ${project.accountsVersionMinimum} or greater. For installation instructions, please see: https://learn.microsoft.com/powershell/azure/install-az-ps" -ErrorAction Stop
  } elseif (($accountsModule.Version -lt [System.Version]'${project.accountsVersionMinimum}') -and (-not $localAccounts)) {
    Write-Error "\`nThis module requires $accountsName version ${project.accountsVersionMinimum} or greater. An earlier version of Az.Accounts is imported in the current PowerShell session. If you are running test, please try to add the switch '-RegenerateSupportModule' when executing 'test-module.ps1'. Otherwise please open a new PowerShell session and import this module again.\`nAdditionally, this error could indicate that multiple incompatible versions of Azure PowerShell modules are installed on your system. For troubleshooting information, please see: https://aka.ms/azps-version-error" -ErrorAction Stop
  }
  Write-Information "Loaded Module '$($accountsModule.Name)'"

  # Load the private module dll
  $null = Import-Module -Name (Join-Path $PSScriptRoot '${project.dll}')

  # Get the private module's instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # Ask for the shared functionality table
  $VTable = Register-AzModule
  
  # Tweaks the pipeline on module load
  $instance.OnModuleLoad = $VTable.OnModuleLoad

  # Following two delegates are added for telemetry
  $instance.GetTelemetryId = $VTable.GetTelemetryId
  $instance.Telemetry = $VTable.Telemetry
  
${requestHandler}
  
  # Gets shared parameter values
  $instance.GetParameterValue = $VTable.GetParameterValue
  
  # Allows shared module to listen to events from this module
  $instance.EventListener = $VTable.EventListener
  
  # Gets shared argument completers
  $instance.ArgumentCompleter = $VTable.ArgumentCompleter
  
  # The name of the currently selected Azure profile
  $instance.ProfileName = $VTable.ProfileName
`;
  } else {
    azureInitialize = `
  # Load the private module dll
  $null = Import-Module -Name (Join-Path $PSScriptRoot '${project.dll}')

  # Get the private module's instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance
`;
  }


  psm1.prepend('Generated', `
${azureInitialize}
 
  # Load the custom module
  $customModulePath = Join-Path $PSScriptRoot '${project.psm1Custom}'
  if(Test-Path $customModulePath) {
    $null = Import-Module -Name $customModulePath
  }
  
  # Export nothing to clear implicit exports
  Export-ModuleMember
${getProfileExportScript(`Join-Path $PSScriptRoot '${project.exportsFolder}'`, project.azure)}
  # Finalize initialization of this module
  $instance.Init();
  Write-Information "Loaded Module '$($instance.Name)'"`);
  psm1.trim();
  project.state.writeFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}

