# AutoRest Conformance tests

## Overview
The AutoRest conformance test suite is a collection of swagger files along with 
a webserver that can be used to test generated code against that will supply the 
responses.

> autorest test server: 
>  - repository: https://github.com/Azure/autorest.testserver
>  - npm package @microsoft.azure/autorest.testserver

The test server has two implementations of the server in the package:
 - The legacy version: a manually constructed `express.js` service that has the responses
 - The new version: a `WireMock` based test service that has the responses in mappings files.

The WireMock version is a work-in-progress, so currently, we rely on the legacy testserver, 
converting to the new one at some point in the future will be simply changing the script that 
is used to launch the test server.

The test server also hosts the swagger files at `http://localhost:3000/__files/...`. 

You can see the implementation of the server at https://github.com/Azure/autorest.testserver/blob/master/legacy/routes/*.js



<hr>

## Generating the tests 
To generate the tests in the `AutoRest.PowerShell` repository there is a script that will start 
the test server, and loop thru the files and use autorest to generate the modules (including test files).
This will not overwrite test files that have been written previously (rerunning the script is not dangerous) 

> `.scripts/generate-tests.ps1` [-swaggers ...] [-outputRoot ...] [-autorestVersion ...]

The parameters for the script are:
 - `-swaggers` -- an array of names of the swagger files from the test server to generate. 
 <br>Not specified means all of them.
 - `-outputRoot` -- a target folder to generate into. defaults to the `./tests/` folder in this project.
 - `-autorestVersion` -- a specific version (or autorest source folder to use for autorest core.)

NOTE: The generated modules are not checked in, just the test files. 

### Generate a module with tests.

After generating the test modules, the pester test files can be found in the `./tests/<NAME>/test` folder 

#### Example 
> `./scripts/generate-tests.ps1 body-complex`

``` 
--------------------------------------------------------
Generating [body-complex]
--------------------------------------------------------

AutoRest code generation utility [version: 3.0.6149; node: v10.15.1, max-memory: 8192 gb]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '...\.autorest\@autorest_core@3.0.6179\node_modules\@autorest\core\dist' (3.0.6179)
[11.16 s] Generation Complete
Creating isolated process...
Cleaning build folders...
Compiling module...
Creating exports and docs...
Creating format.ps1xml...
Creating psd1...
Creating test stubs...
Creating example stubs...
-------------Done-------------
To run this module in an isolated PowerShell session, run the 'run-module.ps1' script or provide the '-Run' parameter to this script.

--------------------------------------------------------
SUCCESS [body-complex]
--------------------------------------------------------

body-complex.json
```

Then you can see the test files generated:
> `dir .\tests\body-complex\test\*-*.ps1`

``` powershell
    Directory: C:\work\2019\powershell\tests\body-complex\test

Mode                LastWriteTime         Length Name
----                -------------         ------ ----
-a----       12/11/2019   8:17 AM            464 Get-ArrayEmpty.Tests.ps1
-a----       12/11/2019   8:17 AM            480 Get-ArrayNotProvided.Tests.ps1
-a----       12/11/2019   8:17 AM            664 Get-ArrayValid.Tests.ps1
-a----       12/11/2019   8:17 AM            599 Get-BasicEmpty.Tests.ps1
-a----       12/11/2019   8:17 AM            595 Get-BasicInvalid.Tests.ps1

etc...
```

### Interactively Running the module with the test server
You can start the test server by running the `interactive-testserver.ps1` script in a separate console:

> `.scripts/interactive-testserver.ps1`

```
[TestServer] Shutting down existing Express instance.
[TestServer] Starting Express Server.
[Express] Server started at port 3000
[TestServer] Express is ready.


Press enter to stop testserver
```

It will remain running until you press `[ENTER]` or run another script that starts a new test server.


#### Run the module
In a different console:

> `cd ./tests/body-complex`<br>
> `./run-module.ps1`

``` 
Creating isolated process...
PS C:\work\2019\powershell\tests\body-complex [BodyComplex]>
```

then you can work with the commands in the module:
> `Get-PrimitiveBool` 

```

FieldFalse FieldTrue
---------- ---------
False      True
```

You can examine the internals of what is returned by:

> `$x = Get-PrimitiveBool` <br>
> `$x | fl * `

``` 
FieldFalse : False
FieldTrue  : True
```

or even look at it in json serialized format: 
> `$x.toJsonString()`

```
{
  "field_false": false,
  "field_true": true
}
```

#### Filling in the test
Open one of the tests:

> code test/Get-PrimitiveBool.Tests.ps1

The default implementation should look like this:

``` powershell
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-PrimitiveBool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-PrimitiveBool' {
    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
```

First, enable the test by removing the `-skip` on the `It` line.

``` powershell
    It 'Get' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
```

then replace the contents with pester test code that verifies the output.

You can use powershell's `Invoke-WebRequest` (`iwr`) to do requests to the running testserver instance, and examining the output

> `(iwr http://localhost:3000/complex/primitive/bool ).RawContent`

``` http
HTTP/1.1 200 OK
X-Powered-By: Express
Vary: Origin
Access-Control-Allow-Credentials: true
Access-Control-Expose-Headers: x-ms-request-id,foo-request-id,Content-Type,value,Location,Azure-AsyncOperation,Retry-After
Date: Wed, 18 Dec 2019 19:35:34 GMT
Connection: keep-alive
Content-Length: 39

{"field_true":true,"field_false":false}
```

If you need to examine the implementation, you can look at the test server code for the routes at 
 https://github.com/Azure/autorest.testserver/blob/master/legacy/routes/ 

So, to implemnent the test for this command:

``` powershell
Describe 'Get-PrimitiveBool' {
    It 'Get' {
      {
        # make the call 
        $value = Get-PrimitiveBool 

        # ensure we got back a result
        $value | Should -not -be $null

        # and that the values are as expected
        $value.FieldFalse | Should -be $false
        $value.FieldTrue | Should -be $true

      } | Should -Not -Throw # and this whole test should not throw.
    } 
}
```

## Running the tests interactively

You can run the tests for the module by running the `./test-module.ps1` script. 
It can run in three modes:
- `-Live` - makes the calls to the test service that is running
- `-Record` - makes the calls to the test service and records the contents to use during playback mode
- `-Playback` - skips the call to the serivce, uses the recorded data (see the `*.recording.json` files )

> `.\test-module.ps1 -Live`

``` haskell
Creating isolated process...
    ____            __
   / __ \___  _____/ /____  _____
  / /_/ / _ \/ ___/ __/ _ \/ ___/
 / ____/  __(__  ) /_/  __/ /
/_/    \___/____/\__/\___/_/
Pester v4.9.0
Executing all tests in 'C:\work\2019\autorest.powershell\tests\body-complex\test'

Executing script C:\work\2019\autorest.powershell\tests\body-complex\test\Get-PrimitiveBool.Tests.ps1
Running 'live' mode...

  Describing Get-PrimitiveBool
    [+] Get 58ms

Executing script C:\work\2019\autorest.powershell\tests\body-complex\test\Get-ArrayEmpty.Tests.ps1
Running 'live' mode...

  Describing Get-ArrayEmpty
    [+] Get 232ms
[etc...]
```

At the bottom, you will see the summary:
``` haskell
Tests completed in 12.93s
Tests Passed: 14, Failed: 0, Skipped: 64, Pending: 0, Inconclusive: 0
-------------Done-------------
```

For tests not implemented, they will be skipped, and you will see results like this:

``` haskell
Executing script C:\work\2019\autorest.powershell\tests\body-complex\test\Get-PrimitiveDateTime.Tests.ps1
Running 'live' mode...

  Describing Get-PrimitiveDateTime
    [!] Get, is skipped 0ms
```

#### Checking in the test:

Run the tests in record mode first:

> `.\test-module.ps1 -Record`

look at the changed/added files

> `git status . `

```
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        modified:   test/Get-PrimitiveBool.Tests.ps1

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        test/Get-PrimitiveBool.Recording.json        
```

You can then add the test and recording files, and commit them:

> `git add ./test/Get-PrimitiveBool.Tests.ps1` <br>
> `git add ./test/Get-PrimitiveBool.Recording.json` <br>
> `git commit -m "implemented get-primitivebool test"` 

## Running Tests 

In order to run the tests in a fresh clone of the repository:

Clone and build :
> `git clone https://github.com/azure/autorest.powershell`<br>
> `cd .\autorest.powershell\` <br>
> `rush update` <br>
> `rush rebuild` <br>

Generate the test modules:
> `.\.scripts\generate-tests.ps1`

Run the whole test suite (defaults to `-Playback` mode):
> `.\.scripts\run-tests.ps1`

You will see all the tests run by (skipped tests will be highlighted):

``` haskell
--------------------------------------------------------
Testing Module [azure-resource-x]
--------------------------------------------------------

Creating isolated process...
    ____            __
   / __ \___  _____/ /____  _____
  / /_/ / _ \/ ___/ __/ _ \/ ___/
 / ____/  __(__  ) /_/  __/ /
/_/    \___/____/\__/\___/_/
Pester v4.9.0
Executing all tests in 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test'

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-Array.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-Array.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Get-Array
    [!] Get, is skipped 0ms

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-Dictionary.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-Dictionary.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Get-Dictionary
    [!] Get, is skipped 0ms

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-ResourceCollection.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Get-ResourceCollection.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Get-ResourceCollection
    [!] Get, is skipped 0ms

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-Array.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-Array.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Set-Array
    [!] Put, is skipped 0ms

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-Dictionary.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-Dictionary.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Set-Dictionary
    [!] PutExpanded, is skipped 0ms
    [!] Put, is skipped 0ms

Executing script C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-ResourceCollection.Tests.ps1
Running 'playback' mode...
Recording file 'C:\tmp\ps\autorest.powershell\tests\azure-resource-x\test\Set-ResourceCollection.Recording.json' is not present. Tests expecting recorded responses will fail

  Describing Set-ResourceCollection
    [!] PutExpanded, is skipped 0ms
    [!] Put, is skipped 0ms
Tests completed in 1.45s
Tests Passed: 0, Failed: 0, Skipped: 8, Pending: 0, Inconclusive: 0
-------------Done-------------

[etc...]
```

The script will tell you which modules passed/failed at the end:

``` haskell
Modules passing: 32
--------------------------------------------------------
httpInfrastructure
body-complex
head-exceptions
url
paging
body-datetime
required-optional
azure-special-properties
azure-report
body-date
body-file
body-string
complex-model
head
body-byte
body-dictionary
validation
extensible-enums-swagger
url-multi-collectionFormat
subscriptionId-apiVersion
azure-resource
body-boolean
body-duration
body-datetime-rfc1123
custom-baseUrl-more-options
custom-baseUrl
body-array
body-integer
report
body-number
azure-parameter-grouping
azure-resource-x
```

