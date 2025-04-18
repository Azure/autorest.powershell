# ----------------------------------------------------------------------------------
${$project.pwshCommentHeader}
# ----------------------------------------------------------------------------------
param([switch]$NotIsolated)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $NotIsolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -NotIsolated
  return
}

$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
if(-not (Test-Path $exportsFolder)) {
  Write-Error "Exports folder '$exportsFolder' was not found."
}

$directories = Get-ChildItem -Directory -Path $exportsFolder
$hasProfiles = ($directories | Measure-Object).Count -gt 0
if(-not $hasProfiles) {
  $directories = Get-Item -Path $exportsFolder
}

$docsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.docsFolder)}'
if(Test-Path $docsFolder) {
  $null = Get-ChildItem -Path $docsFolder -Recurse -Exclude 'README.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue -Force
}
$null = New-Item -ItemType Directory -Force -Path $docsFolder -ErrorAction SilentlyContinue
$examplesFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.examplesFolder)}'

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

# Load DLL to use build-time cmdlets
Import-Module -Name $modulePath
Import-Module -Name (Join-Path $PSScriptRoot '${$project.dll}')
$instance = [${$project.serviceNamespace.moduleClass.declaration}]::Instance
# Module info is shared per profile
$moduleInfo = Get-Module -Name $moduleName

foreach($directory in $directories)
{
  if($hasProfiles) {
    Select-AzProfile -Name $directory.Name
  }
  # Reload module per profile
  Import-Module -Name $modulePath -Force

  $cmdletNames = Get-ScriptCmdlet -ScriptFolder $directory.FullName
  $cmdletHelpInfo = $cmdletNames | ForEach-Object { Get-Help -Name $_ -Full }
  $cmdletFunctionInfo = Get-ScriptCmdlet -ScriptFolder $directory.FullName -AsFunctionInfo

  $docsPath = Join-Path $docsFolder $directory.Name
  $null = New-Item -ItemType Directory -Force -Path $docsPath -ErrorAction SilentlyContinue
  $examplesPath = Join-Path $examplesFolder $directory.Name
  $addComplexInterfaceInfo = ![System.Convert]::ToBoolean('${$project.azure}')
  Export-HelpMarkdown -ModuleInfo $moduleInfo -FunctionInfo $cmdletFunctionInfo -HelpInfo $cmdletHelpInfo -DocsFolder $docsPath -ExamplesFolder $examplesPath -AddComplexInterfaceInfo:$addComplexInterfaceInfo
  Write-Host -ForegroundColor Green "Created documentation in '$docsPath'"
}

Write-Host -ForegroundColor Green '-------------Done-------------'