# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
param(
    [Parameter(Mandatory)]
    [string] $RuntimePath
)

$ErrorActionPreference = 'Stop'
$source = Get-Content -LiteralPath $RuntimePath -Raw
$start = $source.IndexOf('    internal static partial class Extensions', [StringComparison]::Ordinal)
$end = $source.LastIndexOf('}', [StringComparison]::Ordinal)
if ($start -lt 0 -or $end -le $start) {
    throw 'Cannot extract the runtime Extensions class.'
}
$extensions = $source.Substring($start, $end - $start)
$tests = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'LroRequestHeaders.cs') -Raw
$code = @"
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace LroRequestHeaders {
$extensions
$tests
}
"@
Add-Type -TypeDefinition $code -CompilerOptions '/nowarn:0618'
$passed = foreach ($method in [LroRequestHeaders.Tests].GetMethods([Reflection.BindingFlags]'Public,Static,DeclaredOnly')) {
    $null = $method.Invoke($null, @())
    $method.Name
}
ConvertTo-Json -InputObject @($passed) -Compress
