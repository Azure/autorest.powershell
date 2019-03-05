import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { setIndentation, indent } from '@microsoft.azure/codegen';
import { PSScriptFile } from '../file-formats/psscript-file';

export async function generatePsm1(service: Host, project: Project) {
  setIndentation(2);
  // write out the psm1 file if it's not there.
  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1) || '');

  psm1.append('Initialization', `
  # this module instance
  $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # load nested script module if it exists
  if(Test-Path "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1") {
    Import-Module "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1"
  }

  # load private module dll
  $null = Import-Module -PassThru "$PSScriptRoot/bin/${project.moduleName}.private.dll"
`);


  if (project.azure) {
    psm1.append('AzureInitialization', `
  # from PSModulePath
  # (this must be the modified version of Az.Accounts)

  $module = Get-Module Az.Accounts
  if ($module -ne $null -and $module.Version.ToString().CompareTo("1.2.1") -lt 0) {
    Write-Error "This module requires Az.Accounts version 1.2.1. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information." -ErrorAction Stop
  }
  elseif ($module -eq $null) {
    $module = Import-Module Az.Accounts -MinimumVersion 1.2.1 -Scope Global -PassThru
  }

  Write-Host "Loaded Common Module '$($module.Name)'"

  # ask for the table of functions we can call in the common module.
  $VTable = Register-AzModule

  # delegate responsibility to the common module for tweaking the pipeline at module load
  $instance.OnModuleLoad = $VTable.OnModuleLoad

  # and a chance to tweak the pipeline when we are about to make a call.
  $instance.OnNewRequest = $VTable.OnNewRequest

  # Need to get parameter values back from the common module
  $instance.GetParameterValue = $VTable.GetParameterValue

  # need to let the common module listen to events from this module
  $instance.EventListener = $VTable.EventListener

  # get argument completers from the common module
  $instance.ArgumentCompleter = $VTable.ArgumentCompleter

  # The name of the currently selected Azure profile
  $instance.ProfileName = $VTable.ProfileName
`);
  }

  psm1.append('LoadExports', `
  $exportsPath = "$PSScriptRoot/exports"
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
    Get-ChildItem -Path $exportsPath -Recurse -Filter "*.ps1" -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Loading script file: $($_.Name)"
      . $_.FullName
      Export-ModuleMember -Function $_.BaseName
    }
  }
`)

  psm1.append('Finalization', `
  # finish initialization of this module
  $instance.Init();
`);

  psm1.trim();
  service.WriteFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}
