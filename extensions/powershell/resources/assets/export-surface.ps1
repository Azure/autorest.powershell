param([switch]$Isolated, [switch]$IncludeGeneralParameters, [switch]$UseExpandedFormat)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$dll = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dll)}'
if(-not (Test-Path $dll)) {
  Write-Error "Unable to find output assembly in '$binFolder'."
}
$null = Import-Module -Name $dll

$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
$resourcesFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.resourcesFolder)}'

Export-CmdletSurface -CmdletFolder $exportsFolder -OutputFolder $resourcesFolder -IncludeGeneralParameters $IncludeGeneralParameters.IsPresent -UseExpandedFormat $UseExpandedFormat.IsPresent
Write-Host -ForegroundColor Green "CmdletSurface file(s) created in '$resourcesFolder'"

Export-ModelSurface -OutputFolder $resourcesFolder
Write-Host -ForegroundColor Green "ModelSurface file created in '$resourcesFolder'"

Write-Host -ForegroundColor Green '-------------Done-------------'