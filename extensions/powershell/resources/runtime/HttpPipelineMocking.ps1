$ErrorActionPreference = "Stop"

$script:description = New-Object -Type System.Collections.Stack
$script:context = New-Object -Type System.Collections.Stack
$script:operation = New-Object -Type System.Collections.Stack
$script:count = 0

function mock-http($request, $callback, $next) {
  $script:count = $script:count +1

  # DESCRIPTION+OPERATION+URI + COUNT:RESULT
  $rqkey = "$script:description+$script:context+$script:operation+$($request.RequestUri)+$script:count"

  switch($TestMode) {
    'live' {
      return $next.SendAsync($request,$callback);
    }

    'record' {
      # make the call
      $responseTask = $next.SendAsync($request,$callback);
      $response = $responseTask.Result

      # duplicate the response 
      $responseJson = serialize-response $response
      $responseCopy = deserialize-response $responseJson
  
      # save the call 
      $script:recording[$rqkey]  = $responseJson
      Set-Content $script:TestRecordingFile -Value (ConvertTo-Json $script:recording)

      # throw away the original.
      $response.Dispose();

      # return our synthetic result, should be as good as the original.
      return [System.Threading.Tasks.Task]::FromResult($responseCopy)      
    }

    'playback' {
      # pick the response up from
      $lookup = $script:recording[$rqkey]
      if( $lookup -eq $null ) {
        write-error "`n`nMissing recording for test`n  $script:description => $script:operation`n  [$script:count]$($request.RequestUri)"
      }
      $response = deserialize-response $lookup

      return [System.Threading.Tasks.Task]::FromResult($response)
    }
  }
}

function serialize-response($response) {
  return @{
    RequestMessage = @{
      RequestUri = $response.RequestMessage.RequestUri;
      Method = $response.RequestMessage.Method;
      Headers = $response.RequestMessage.Headers
    };
    Content = $response.Content.ReadByteArrayAsnyc().Result
    Headers = $response.Headers
  }
}

function ConvertJson-ToHashtable($InputObject) {
  return ConvertPSObject-ToHashtable( ConvertFrom-Json $InputObject )
}

function ConvertPSObject-ToHashtable($InputObject) {
  if ($null -eq $InputObject) { return $null }

  if ($InputObject -is [System.Collections.IEnumerable] -and $InputObject -isnot [string])
  {
    $collection = @(
      foreach ($object in $InputObject) { ConvertPSObject-ToHashtable $object }
    )
    Write-Output -NoEnumerate $collection
  }
  elseif ($InputObject -is [psobject])
  {
    $hash = @{}
    foreach ($property in $InputObject.PSObject.Properties)
    {
      $hash[$property.Name] = ConvertPSObject-ToHashtable $property.Value
    }
    $hash
  }
  else
  {
    $InputObject
  }
}

function deserialize-response($json) {
  $data = ConvertJson-ToHashtable $json

  $global:data = $data

  $response = New-Object -Type System.Net.Http.HttpResponseMessage

  $response.RequestMessage = New-Object -Type System.Net.Http.HttpRequestMessage
  $response.RequestMessage.RequestUri = $data.RequestMessage.RequestUri
  $shh = $data.RequestMessage.Headers.Keys |% { $response.RequestMessage.Headers.TryAddWithoutValidation($_, $data.RequestMessage.Headers[$_]) }

  $response.StatusCode = $data.StatusCode
  $response.Content =  New-Object -Type System.Net.Http.ByteArrayContent -ArgumentList @(,([System.Convert]::FromBase64String($data.Content)))
  $shh = $data.Headers.Keys |% { $response.Headers.TryAddWithoutValidation($_, $data.Headers[$_]) }
  $shh = $data.ContentHeaders.Keys |% { $response.Content.Headers.TryAddWithoutValidation($_, $data.ContentHeaders[$_]) }
  return $response
}

function serialize-headers($headers) {
  $result = @{}
  if($headers -ne $null) {
    $headers|% {
      if( $_.Key -eq "Authorization" ) {
        $result[$_.Key] = "AUTH_HEADER_REMOVED"
      } else {
        $result[$_.Key] = $_.Value
      }
    }
  }
  return $result;
}

function serialize-request($request) {
  return @{
    RequestUri = $request.RequestUri;
    Method = $request.Method;
    Headers = (serialize-headers $request.Headers)
  }
}

function serialize-response($response) {
  $obj = @{
    RequestMessage = (serialize-request $response.RequestMessage);
    Content = [System.Convert]::ToBase64String( $response.Content.ReadAsByteArrayAsync().Result )
    Headers = (serialize-headers $response.Headers )
    ContentHeaders = (serialize-headers $response.Content.Headers )
    StatusCode = $response.StatusCode
  }
  return (ConvertTo-Json $obj)
}
function Describe(
  [Parameter(Mandatory = $true, Position = 0)]
  [string] $Name,

  [Alias('Tags')]
  [string[]] $Tag = @(),

  [Parameter(Position = 1)]
  [ValidateNotNull()]
  [ScriptBlock] $Fixture = $(Throw "No test script block is provided. (Have you put the open curly brace on the next line?)")
) {
  $script:description.Push($Name)
  try {
    return pester\Describe -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $script:description.Pop()
  }
}

function Context(
  [Parameter(Mandatory = $true, Position = 0)]
  [string] $Name,

  [Alias('Tags')]
  [string[]] $Tag = @(),

  [Parameter(Position = 1)]
  [ValidateNotNull()]
  [ScriptBlock] $Fixture = $(Throw "No test script block is provided. (Have you put the open curly brace on the next line?)")
) {
  $script:context.Push($Name)
  try {
    return pester\Context -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $script:context.Pop()
  }
}

function It {
  [CmdletBinding(DefaultParameterSetName = 'Normal')]
  param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$Name,

    [Parameter(Position = 1)]
    [ScriptBlock] $Test = {},

    [System.Collections.IDictionary[]] $TestCases,

    [Parameter(ParameterSetName = 'Pending')]
    [Switch] $Pending,

    [Parameter(ParameterSetName = 'Skip')]
    [Alias('Ignore')]
    [Switch] $Skip
  )
  $script:operation.Push($Name)

  # reset the count for each 'it'
  $script:count = 0

  try {
    if($skip) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Skip
    }
    if($pending) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Pending
    }
    return pester\It -Name $Name -Test $Test -TestCases $TestCases
  }
  finally {
    $null = $script:operation.Pop()
  }
}

if($global:TestMode -eq $null) {
  $TestMode= 'live'
} else {
  $TestMode = $global:TestMode

  if($global:TestRecordingFile -eq $null) {
    $script:TestRecordingFile = "$PSScriptRoot/recording.json"
  } else {
    $script:TestRecordingFile = $global:TestRecordingFile
  }

  if(Test-Path $TestRecordingFile) {
    Write-Debug "Loading responses from $TestRecordingFile"
    $script:recording  = ConvertPSObject-ToHashtable(ConvertFrom-Json (Get-Content -Raw $TestRecordingFile))
  } else {
    if($TestMode -eq 'playback') {
      Write-Error "Recording file '$TestRecordingFile' is not present. Unable to continue."
    }
    $script:recording = @{}
  }
}

$PSDefaultParameterValues["*:HttpPipelineAppend"] = ${function:mock-http}