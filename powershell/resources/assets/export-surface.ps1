# ----------------------------------------------------------------------------------
${$project.pwshCommentHeader}
# ----------------------------------------------------------------------------------
param([switch]$NotIsolated, [switch]$IncludeGeneralParameters, [switch]$UseExpandedFormat)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $NotIsolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -NotIsolated
  return
}

$dll = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dll)}'
if(-not (Test-Path $dll)) {
  Write-Error "Unable to find output assembly in '$binFolder'."
}
$null = Import-Module -Name $dll

$moduleName = '${$project.moduleName}'
$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
$resourcesFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.resourcesFolder)}'

Export-CmdletSurface -ModuleName $moduleName -CmdletFolder $exportsFolder -OutputFolder $resourcesFolder -IncludeGeneralParameters $IncludeGeneralParameters.IsPresent -UseExpandedFormat $UseExpandedFormat.IsPresent
Write-Host -ForegroundColor Green "CmdletSurface file(s) created in '$resourcesFolder'"

Export-ModelSurface -OutputFolder $resourcesFolder -UseExpandedFormat $UseExpandedFormat.IsPresent
Write-Host -ForegroundColor Green "ModelSurface file created in '$resourcesFolder'"

Write-Host -ForegroundColor Green '-------------Done-------------'