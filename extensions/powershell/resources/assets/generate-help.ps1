param([switch]$Isolated)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path -Isolated
  return
}

. (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts:$${$project.azure} -PlatyPS

$localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
if(Test-Path -Path $localModulesPath) {
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$WarningPreference = 'SilentlyContinue'
$docsPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.docsFolder)}'
$null = New-Item -ItemType Directory -Force -Path $docsPath -ErrorAction SilentlyContinue

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name platyPS
Import-Module -Name $modulePath

# Generate markdowns
if((Get-Item -Path (Join-Path $docsPath '*.md') -Exclude readme.md | Measure-Object).Count -eq 0) {
  New-MarkdownHelp -Module $moduleName -OutputFolder $docsPath -WithModulePage -AlphabeticParamsOrder -UseFullTypeName -ErrorAction SilentlyContinue -WarningAction SilentlyContinue #-ExcludeDontShow
}
Update-MarkdownHelpModule -Path $docsPath -RefreshModulePage -AlphabeticParamsOrder -UseFullTypeName -Force -ErrorAction SilentlyContinue -WarningAction SilentlyContinue #-ExcludeDontShow

# Update module page markdown
$modulePage = Join-Path $docsPath "$moduleName.md"
$mpContent = Get-Content -Path $modulePage
$moduleNameLower = "$($moduleName.ToLower())"
$mpContent = $mpContent -replace 'Download Help Link: {{Please enter FwLink manually}}.*', "Download Help Link: https://docs.microsoft.com/en-us/powershell/module/$moduleNameLower"
$mpContent = $mpContent -replace 'Help Version: {{Please enter version of help manually \(X\.X\.X\.X\) format}}.*', "Help Version: 1.0.0.0"
$mpContent = $mpContent -replace '{{Manually Enter Description Here}}.*', "$((Get-Module $moduleName).Description)"
Set-Content -Path $modulePage -Value $mpContent -Force

Write-Host -ForegroundColor Green '-------------Done-------------'