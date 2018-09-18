# Incubator Release Notes [9/16/2018]

# Prerequisites

- AutoRest 
    - see https://github.com/Azure/autorest/blob/master/README.md#installing-autorest

- powershell-core
    - required for building (don't worry -- the cmdlets should run on both powershell and powershell-core)
    - see https://github.com/powershell/powershell#get-powershell 
    

- .NET Core SDK (2.0+) :
    - is required to build cmdlets 
    - see https://www.microsoft.com/net/download 
    - OR
    - install via npm:
    - `npm install -g dotnet-sdk-2.1`

- AutoRest incubator project (where the generator is)

_use this to install and/or update to the latest version as updates come_

``` powershell
    # force npm to remove old stuff
    > npm cache clean --force

    # remove old autorest extensions
    > autorest --reset 

    # install the lates version of hte incubator (you still have to 
    # say --use=@microsoft.azure/autorest.incubator@preview when you use it! )
    > autorest --use=@microsoft.azure/autorest.incubator@preview

```


# Usage

### When Using an autorest literate configuration file

```
autorest --use=@microsoft.azure/autorest.incubator@preview --powershell --output-folder=./output path/to/autorest-cfg-file/readme.md
```

### When building with just an OpenAPI2/Swagger file

```
autorest --use=@microsoft.azure/autorest.incubator@preview --powershell --output-folder=./output --input-file=./path/to/swagger.json
```


# Examples

## Simple No-Auth example (xkcd)


``` powershell

# try out the Xkcd example
cd ./Examples/Xkcd

autorest --use=@microsoft.azure/autorest.incubator@preview --powershell --input-file=xkcd.yaml --namespace=Xkcd --output-folder=./generated --clear-output-folder

./generated/build-module -test 

Get-ComicForToday

$comic = Get-Comic -comicId 1234

$comic.


```


