# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
param(
    [Parameter(Mandatory)]
    [string] $ModulePath
)

$ErrorActionPreference = 'Stop'
$project = Join-Path $ModulePath 'Az.LroHeaders.csproj'
$buildOutput = & dotnet build $project --configuration Debug --nologo --verbosity quiet 2>&1
if ($LASTEXITCODE -ne 0) {
    throw "Generated module compilation failed:`n$($buildOutput -join [Environment]::NewLine)"
}

Import-Module (Join-Path $ModulePath 'bin\Az.LroHeaders.private.dll') -ErrorAction Stop
$passed = foreach ($method in [LroRequestHeaderTests].GetMethods([Reflection.BindingFlags]'Public,Static,DeclaredOnly')) {
    $null = $method.Invoke($null, @())
    $method.Name
}
ConvertTo-Json -InputObject @($passed) -Compress
