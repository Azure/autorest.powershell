param([switch]$Isolated)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path -Isolated
  return
}

$exportsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.exportsFolder)}'
if(-not (Test-Path $exportsFolder)) {
  Write-Error "Exports folder '$exportsFolder' was not found."
}

$directories = Get-ChildItem -Directory -Path $exportsFolder
$hasProfiles = ($directories | Measure-Object).Count -gt 0
if(-not $hasProfiles) {
  $directories = $exportsFolder
}

$docsFolder = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.docsFolder)}'
$null = New-Item -ItemType Directory -Force -Path $docsFolder -ErrorAction SilentlyContinue

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name (Join-Path $PSScriptRoot '${$project.dll}')
Import-Module -Name $modulePath
$instance = [${$project.serviceNamespace.moduleClass.declaration}]::Instance
# $moduleDescription = (Get-Module -Name $moduleName).Description
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

  Export-HelpMarkdown -ModuleInfo $moduleInfo -FunctionInfo $cmdletFunctionInfo -HelpInfo $cmdletHelpInfo -DocsFolder $docsPath
}








# $ProgressPreference = 'SilentlyContinue'
# . (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts:$${$project.azure} -PlatyPS

# $localModulesPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.dependencyModuleFolder)}'
# if(Test-Path -Path $localModulesPath) {
#   $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
# }

# $WarningPreference = 'SilentlyContinue'
# $docsPath = Join-Path $PSScriptRoot '${$lib.path.relative($project.baseFolder, $project.docsFolder)}'
# $null = New-Item -ItemType Directory -Force -Path $docsPath -ErrorAction SilentlyContinue

# $modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot '${$project.psd1}')
# $modulePath = $modulePsd1.FullName
# $moduleName = $modulePsd1.BaseName

# Import-Module -Name platyPS
# Import-Module -Name $modulePath

# # Generate markdowns
# if((Get-Item -Path (Join-Path $docsPath '*.md') -Exclude readme.md | Measure-Object).Count -eq 0) {
#   New-MarkdownHelp -Module $moduleName -OutputFolder $docsPath -WithModulePage -AlphabeticParamsOrder -UseFullTypeName -ErrorAction SilentlyContinue -WarningAction SilentlyContinue -ExcludeDontShow
# }
# Update-MarkdownHelpModule -Path $docsPath -RefreshModulePage -AlphabeticParamsOrder -UseFullTypeName -Force -ErrorAction SilentlyContinue -WarningAction SilentlyContinue -ExcludeDontShow

# # Update module page markdown
# $modulePage = Join-Path $docsPath "$moduleName.md"
# $mpContent = Get-Content -Path $modulePage
# $moduleNameLower = "$($moduleName.ToLower())"
# $mpContent = $mpContent -replace 'Download Help Link: {{ Update Download Link }}.*', "Download Help Link: https://docs.microsoft.com/en-us/powershell/module/$moduleNameLower"
# $mpContent = $mpContent -replace 'Help Version: {{ Please enter version of help manually \(X\.X\.X\.X\) format }}.*', "Help Version: 1.0.0.0"
# $mpContent = $mpContent -replace '{{ Fill in the Description }}.*', "$((Get-Module $moduleName).Description)"
# Set-Content -Path $modulePage -Value $mpContent -Force

# Write-Host -ForegroundColor Green '-------------Done-------------'