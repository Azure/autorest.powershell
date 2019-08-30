# powershell Release Notes [9/27/2018] (powershell version `1.0.123`)

## What's New
- All runtime code is now generated in the same namespace as the project itself (no more `Carbon.Json` and `Microsoft.Rest.ClientRuntime` namespaces) -- this will make it so you can have multiple generated code sets in the same project if necessary. 
- runtime code is a marked lot more `internal` than it was; `public` is  only used where it must.
- `additionalProperties` in models should generate far better code that it was. (still one outstanding case where it's not good.)
-  you can use npm to install powershell cross platform: `npm install -g get-powershell`, then you can just run `pwsh` !

## Upgrading 

- If you've been using the `PowerShell` Generator, you can upgrade pretty easily:

``` powershell
    >
    # force npm to remove old stuff
    > npm cache clean --force

    # remove old autorest extensions
    > autorest --reset 

    # install the lates version of hte generator (you still have to 
    # say --use=@azure/autorest.powershell@beta when you use it! )
    > autorest --powershell --help
    
    # verify the version you have
    > autorest --info 
```

You should see something like:
``` text
AutoRest code generation utility [version: 2.0.4283; node: v8.12.0]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest


Showing All Installed Extensions

 Type       Extension Name                           Version      Location
 core       @azure/autorest-core           2.0.4289     C:\Users\garretts\.autorest\@azure_autorest-core@2.0.4289
 extension  @azure/autorest.powershell      1.0.123      C:\Users\garretts\.autorest\@azure_autorest.powershell@1.0.123
```

# Prerequisites

- AutoRest 
    - see https://github.com/Azure/autorest/blob/master/README.md#installing-autorest

- powershell-core
    - required for building (don't worry -- the cmdlets should run on both powershell and powershell-core)
    - NEW! you can use npm to install powershell cross platform: `npm install -g get-powershell`, then you can just run `pwsh` !
    - or, see https://github.com/powershell/powershell#get-powershell to do it the hard way.

- .NET Core SDK (2.0+) :
    - is required to build cmdlets 
    - see https://www.microsoft.com/net/download 
    - OR
    - install via npm:
    - `npm install -g dotnet-sdk-2.1`

- AutoRest powershell project (where the generator is)

_use this to install and/or update to the latest version as updates come_

``` powershell
    # force npm to remove old stuff
    > npm cache clean --force

    # remove old autorest extensions
    > autorest --reset 


```
# CAVEATS, AND KNOWN ISSUES:

- BE KIND! This is a first release of a really large amount of code! It was designed to handle APIs crafted for azure services (where we have pretty consistent standards). If it breaks, we'll see what we can do!

- Does not yet support file streams from the cmdlets (soooooon!) so, no `type: object format: binary` etc...
- operations must have unique `operationId` values.
  <br>they should be in the form `Noun_Action` (not a powershell noun-verb, but something meaningful)
  <br>like 
  <br>&nbsp;&nbsp;`operationId: MyResource_Get` or 
  <br>&nbsp;&nbsp;`operationId: SomeAPI_List`
  <br>if there are tags, we try to guess something useful, but no guarantees.
- If something doesn't work, try to trim down the OpenAPI file to narrow down what it doesn't like, and post an issue back to https://github.com/azure/autorest.powershell with a clear example.
- Http testing/mocking support works, see the second example below, however, it has primitive scrubbing, so be careful with storing API keys, etc.
- Documentation/Deep Knowledge is coming as soon as I can get around to it. 

- Feel Free to poke around, and help out!

# Usage

### When Using an autorest literate configuration file

```
autorest --use=@azure/autorest.ubator@preview --powershell --output-folder=./output path/to/autorest-cfg-file/readme.md
```

### When building with just an OpenAPI2/Swagger file

```
autorest --use=@azure/autorest.powershell@preview --powershell --output-folder=./output --input-file=./path/to/swagger.json
```

# Examples

## Simple No-Auth example (xkcd)


``` powershell
# try out the Xkcd example
cd ./Examples/Xkcd

autorest --use=@azure/autorest.powershell@preview --powershell --input-file=xkcd.yaml --namespace=Xkcd --output-folder=./generated --clear-output-folder
```
Output:
```
AutoRest code generation utility [version: 2.0.4283; node: v8.11.2]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '/home/garretts/.autorest/@azure_autorest-core@2.0.4286/node_modules/@azure/autorest-core/dist' (2.0.4286)
   Loading AutoRest extension '@azure/autorest.powershell' (1.0.105->1.0.105)
>
```

Now, we can build the module :

``` powershell
# you must be running powershell-core for this script!
./generated/build-module.ps1 -test 
```

Output:

``` 
Spawning in isolated process.
Cleaning folders...
Compiling private module code
Private Module loaded (/autorest.powershell/Examples/Xkcd/generated/bin/XKCD.private.dll).
Processing cmdlet variants
Generating unified cmdlet proxies
Done.
-------------------------------
PS /work/autorest.powershell/Examples/Xkcd/generated [ testing XKCD ] >
```

Note that the prompt has changed, and contains `[ testing XKCD ]` at the end, telling us that the module is loaded.

``` powershell
# let's see what we got:
get-command -module XKCD
``` 

Output:

``` haskell
CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Function        Get-XkcdComic                                      1.0        XKCD
Function        Get-XkcdComicForToday                              1.0        XKCD

```
Try out some cmdlets:

``` powershell
# gets today's comic 
Get-XkcdComicForToday
```

Output:
``` yaml
Alt        : If I wait a while, it's not so bad, because then it's just shaped like me, plus some pipes and tanks and probably eventually all of Earth's oceans.
Day        : 17
Img        : https://imgs.xkcd.com/comics/beverages.png
Link       :
Month      : 9
News       :
Num        : 2047
SafeTitle  : Beverages
Title      : Beverages
Transcript :
Year       : 2018
```

``` powershell
$comic = Get-XkcdComic -comicId 323

invoke-webrequest -uri $comic.Img -outfile ./ballmer_peak.png

```

![Result](https://imgs.xkcd.com/comics/ballmer_peak.png "Ballmer Peak")


## Example Adding in some authentication:

In this example, we're going to use an AutoRest literate configuration file (it's a readme.md file with some code blocks):


```  powershell
cd ./Examples/TimesWire

# if you're in a folder with an autorest configuration file (readme.md)
# you can just run autorest and it will find it.

autorest

```

Output:

``` haskell
AutoRest code generation utility [version: 2.0.4283; node: v8.11.2]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '/home/garretts/.autorest/@azure_autorest-core@2.0.4286/node_modules/@azure/autorest-core/dist' (2.0.4286)
   Loading AutoRest extension '@azure/autorest.powershell' (preview->1.0.105)

PS /autorest.powershell/Examples/TimesWire>
```

Authentication varies so much between services, you'll have to add support to add authentication to the requests.

Luckily, it's not too hard. 

First, this service requires an API key you can get from http://developer.nytimes.com/.

Next we have to add a `Module.cs` that can patch into the http pipeline.

The place to do that is by creating a `./custom` folder in the `output-folder`.

This example already has a  [`Module.cs`](./Examples/TimesWire/generated/custom/Module.cs) folder has one created for you.

``` powershell
# lets' build the module (complete with the custom file)
./generated/build-module.ps1 -test 

# and now we can test it out:

# set your API key
$env:TimesApiKey='<YOUR API KEY>'

# make the call
$articles = get-article -source 'nyt' -section 'sports' 

# see the results
$articles.Results 

# WHOA!
# .......
```

### Writing some unit tests!

The generated cmdlets come with a simple facility to do unit testing with pester that include mocking of the HTTP request for purposes of automating tests.


First, make sure you have pester installed:
``` powershell
install-module -scope currentuser pester -force

```


Next, you will find an [template test file](./Examples/TimesWire/generated/tests/Example.tests.ps1) in the `tests` folder of the generated module.

We've [already written one test](./Examples/TimesWire/generated/tests/get-article.tests.ps1) in for this api:

In order to support mocking, you just have to dot-source the `HttpPipelineMocking.ps1` file and make sure you use `-HttpPipelineAppend $mock` on all cmdlet calls.

See:

``` powershell
# Pull In Mocking Support 
. "$PSScriptRoot/HttpPipelineMocking.ps1"

# Run Some tests
Describe 'Get-Article Tests' {
    It "gets sports articles" {
       (get-article -section sports -source nyt -HttpPipelineAppend $mock).Results.length | Should -be 20 
    }
}
```

Then you can record the API calls:

``` powershell
PS /autorest.powershell/Examples/TimesWire/generated [ testing TimesNewswire ] > $TestMode = 'record' ; invoke-pester
Executing all tests in '.'

# example test file, it's empty
Executing script /autorest.powershell/Examples/TimesWire/generated/tests/Example.Tests.ps1

# test file for this api!
Executing script /autorest.powershell/Examples/TimesWire/generated/tests/get-article.tests.ps1

  Describing Get-Article Tests
    [+] gets sports articles 504ms
Tests completed in 504ms
Tests Passed: 1, Failed: 0, Skipped: 0, Pending: 0, Inconclusive: 0
PS /autorest.powershell/Examples/TimesWire/generated [ testing TimesNewswire ] >
```

and then play them back without making actual remote calls: 

``` powershell
PS /autorest.powershell/Examples/TimesWire/generated [ testing TimesNewswire ] > $TestMode = 'playback' ; invoke-pester
Executing all tests in '.'

Executing script /autorest.powershell/Examples/TimesWire/generated/tests/Example.Tests.ps1

Executing script /autorest.powershell/Examples/TimesWire/generated/tests/get-article.tests.ps1

  Describing Get-Article Tests
    [+] gets sports articles 147ms
Tests completed in 147ms # MUCH FASTER!
Tests Passed: 1, Failed: 0, Skipped: 0, Pending: 0, Inconclusive: 0
PS /autorest.powershell/Examples/TimesWire/generated [ testing TimesNewswire ] >
```


