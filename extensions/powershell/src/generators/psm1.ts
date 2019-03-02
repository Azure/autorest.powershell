import { Host } from '@microsoft.azure/autorest-extension-base';
import { Project } from '../project';
import { setIndentation, indent } from '@microsoft.azure/codegen';
import { PSScriptFile } from '../file-formats/psscript-file';

export async function generatePsm1(service: Host, project: Project) {
  setIndentation(2);
  // write out the psm1 file if it's not there.

  const psm1 = new PSScriptFile(await service.ReadFile(project.psm1) || '');

  if (project.azure) {
    psm1.prepend('AzureInitialization', `
    # from PSModulePath
    # (this must be the modified version of Az.Accounts)

    $module = Get-Module Az.Accounts
    if ($module -ne $null -and $module.Version.ToString().CompareTo("0.4.0") -lt 0) {
      Write-Error "This module requires Az.Accounts version 0.4.0. An earlier version of Az.Accounts is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information." -ErrorAction Stop
    }
    elseif ($module -eq $null) {
      $module = Import-Module Az.Accounts -MinimumVersion 0.4.0 -Scope Global -PassThru
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
`);
  }

  psm1.prepend('Initialization', `
    # this module instance
    $instance = [${project.serviceNamespace.moduleClass.declaration}]::Instance

    # load nested script module if it exists
    if(Test-Path "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1") {
      Import-Module "$PSScriptRoot/bin/${project.moduleName}.scripts.psm1"
    }

    # load private module dll
    $null = Import-Module -PassThru "$PSScriptRoot/bin/${project.moduleName}.private.dll"

    # export the cmdlets
    $exports = "$PSScriptRoot/exports"
    $directories = Get-ChildItem -Directory -Path $exports
    if(($directories | Measure-Object).Count -gt 0) {
      # TODO: Change to load selected profile if it exists for the module
      $profile = $directories | Select-Object -Last 1
      Write-Host "Loaded Profile '$($profile.Name)'"
      $exports = $profile.FullName
    }
    Get-ChildItem -Path $exports -Recurse -Filter "*.ps1" -File | Sort-Object Name | ForEach-Object {
      Write-Verbose "Dot sourcing private script file: $($_.Name)"
      . $_.FullName
      # Explicity export the member
      Export-ModuleMember -Function $_.BaseName
    }`);

  psm1.append('Finalization', `
    # finish initialization of this module
    $instance.Init();
  Write-Host "Loaded Module '$($instance.Name)'"
`);

  psm1.trim();

  service.WriteFile(project.psm1, `${psm1}`, undefined, 'source-file-powershell');
}
