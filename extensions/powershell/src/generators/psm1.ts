import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { PSScriptFile } from '../file-formats/psscript-file';

export async function generatePsm1(service: Host, project: Project) {
  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1) || '');
  psm1.append('Initialization', `
  # Get this module's instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # Load the custom script module
  $scriptModulePath = Join-Path $PSScriptRoot ${project.psm1Custom}
  if(Test-Path $scriptModulePath) {
    $null = Import-Module -Name $scriptModulePath
  }

  # Load the private module dll
  $null = Import-Module -Name (Join-Path $PSScriptRoot ${project.dll})
`);

  if (project.azure) {
    psm1.append('AzureInitialization', `
  # Load required Az.Accounts module
  $sharedModule = Get-Module -Name Az.Accounts
  if ($sharedModule -ne $null -and $sharedModule.Version.ToString().CompareTo('1.2.1') -lt 0) {
    Write-Error 'This module requires Az.Accounts version 1.2.1. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information.' -ErrorAction Stop
  } elseif ($sharedModule -eq $null) {
    $sharedModule = Import-Module -Name Az.Accounts -MinimumVersion 1.2.1 -Scope Global -PassThru
  }
  Write-Host "Loaded Module '$($sharedModule.Name)'"

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
  $instance.ProfileName = $VTable.ProfileName
`);
  }

  psm1.append('LoadExports', `
  # Export proxy cmdlet scripts
  $exportsPath = Join-Path $PSScriptRoot ${project.exportsFolder}
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
    Write-Host "Loaded Azure profile '$($profileDirectory.Name)' for module '$($instance.Name)'"
    $exportsPath = $profileDirectory.FullName
  }

  if($exportsPath) {
    Get-ChildItem -Path $exportsPath -Recurse -Filter '*.ps1' -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Loading script file: $($_.Name)"
      . $_.FullName
      Export-ModuleMember -Function $_.BaseName
    }
  }
`)

  psm1.append('Finalization', `
  # Finalize initialization of this module
  $instance.Init();
  Write-Host "Loaded Module '$($instance.Name)'"
`);

  psm1.trim();
  service.WriteFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}
