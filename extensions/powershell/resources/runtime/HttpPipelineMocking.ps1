$ErrorActionPreference = "Stop"

# get the recording path
if ($null -eq $global:TestRecordingFile) {
  $script:TestRecordingFile = "$PSScriptRoot/recording.json"
}
else {
  $script:TestRecordingFile = $global:TestRecordingFile
}

# normalize the recording path
$script:TestRecordingFile = resolve-path -ea 0 $script:TestRecordingFile
if ( -not $script:TestRecordingFile) { $script:TestRecordingFile = $Error[0].TargetObject } 

# is the file there? 
if (Test-Path $TestRecordingFile) {
  Write-Debug "Loading responses from $TestRecordingFile"
}
else {
  if ('playback' -eq $TestMode ) {
    Write-Error "Recording file '$TestRecordingFile' is not present. Unable to continue in 'playback' mode."
  }
}

# create the Http Pipeline Recorder  
$script:Mock = new-object -type Microsoft.Rest.ClientRuntime.PipelineMock  $script:TestRecordingFile

# set the recorder to the appropriate mode (default to 'live' )
switch ($global:TestMode ) {
  'record' {
    $script:Mock.SetRecord();
  }
  'playback' {
    $script:Mock.SetPlayback();
  }
  default: {
    $script:Mock.SetLive();
  }
}

# overrides for Pester Describe/Context/It 

function Describe(
  [Parameter(Mandatory = $true, Position = 0)]
  [string] $Name,

  [Alias('Tags')]
  [string[]] $Tag = @(),

  [Parameter(Position = 1)]
  [ValidateNotNull()]
  [ScriptBlock] $Fixture = $(Throw "No test script block is provided. (Have you put the open curly brace on the next line?)")
) {
  $script:Mock.PushDescription($Name)
  try {
    return pester\Describe -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $script:Mock.PopDescription()
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
  $script:Mock.PushContext($Name)
  try {
    return pester\Context -Name $Name -Tag $Tag -Fixture $fixture
  }
  finally {
    $script:Mock.PopContext()
  }
}

function It {
  [CmdletBinding(DefaultParameterSetName = 'Normal')]
  param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$Name,

    [Parameter(Position = 1)]
    [ScriptBlock] $Test = { },

    [System.Collections.IDictionary[]] $TestCases,

    [Parameter(ParameterSetName = 'Pending')]
    [Switch] $Pending,

    [Parameter(ParameterSetName = 'Skip')]
    [Alias('Ignore')]
    [Switch] $Skip
  )
  $script:Mock.PushScenario($Name)

  try {
    if ($skip) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Skip
    }
    if ($pending) {
      return pester\It -Name $Name -Test $Test -TestCases $TestCases -Pending
    }
    return pester\It -Name $Name -Test $Test -TestCases $TestCases
  }
  finally {
    $null = $script:Mock.PopScenario()
  }
}

# set the HttpPipelineAppend for all the cmdlets
$PSDefaultParameterValues["*:HttpPipelineAppend"] = $script:Mock
