# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
param(
    [Parameter(Mandatory)]
    [string] $ModulePath,

    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [string] $TestName
)

$ErrorActionPreference = 'Stop'
Import-Module (Join-Path $ModulePath 'bin\Az.LroHeaders.private.dll') -ErrorAction Stop
$method = [RequestHeaderScopeTests].GetMethod($TestName, [Reflection.BindingFlags]'Public,Static,DeclaredOnly')
if ($null -eq $method) {
    throw "Unknown request header scope test '$TestName'."
}

try {
    $null = $method.Invoke($null, @())
}
catch {
    $failure = $_.Exception.GetBaseException()
    throw [InvalidOperationException]::new("Request header scope test '$TestName' failed: $($failure.Message)", $failure)
}

ConvertTo-Json -InputObject $method.Name -Compress
