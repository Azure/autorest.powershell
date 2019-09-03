# AutoRest PowerShell Generator - Simple Usage (XKCD)

### Example: XKCD 

Download the [XKCD swagger](https://raw.githubusercontent.com/Azure/autorest.powershell/v3/samples/Xkcd/xkcd.yaml) file.

``` 
> autorest --powershell --input-file:./xkcd.yaml 

AutoRest code generation utility [version: 3.0.5135; node: v10.15.0]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      'C:\Users\garretts.NTDEV\.autorest\@azure_autorest-core@3.0.5330\node_modules\@azure\autorest-core\dist' (3.0.5330)
   Installing AutoRest extension '@autorest/powershell' (beta)
   Installing AutoRest extension '@autorest/remodeler' (beta)

> 
```

The generator will create a `./generated` folder where the files will be

Inside that, you'll find a `build-module.ps1` script that will compile up the module.

If you add `-test` to the `build-module` script, it will launch a new instance of `pwsh` and load the module so you can test it.

``` powershell
> ./generated/build-module.ps1 -test

Spawning in isolated process.
Cleaning folders...
Compiling private module code
Private Module loaded (C:\...\generated\bin\XKCD.private.dll).
Processing cmdlet variants
Generating unified cmdlet proxies
Done.
-------------------------------
PS C:\...\generated [ testing XKCD ] >

```

Now you can try out the cmdlets that have been generated:

List the commands from the module:

``` powershell
> get-command -module XKCD


CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Function        Get-XkcdComic                                      1.0        XKCD
Function        Get-XkcdComicForToday                              1.0        XKCD
```

Try out a command
``` powershell
> Get-XkcdComicForToday | fl 


Alt        : Theres one person in Missouri who says "carbo bev" who the entire rest of the country HATES.
Day        : 6
Img        : https://imgs.xkcd.com/comics/carbonated_beverage_language_map.png
Link       :
Month      : 2
News       :
Num        : 2108
SafeTitle  : Carbonated Beverage Language Map
Title      : Carbonated Beverage Language Map
Transcript :
Year       : 2019
```

Nifty!

A bit of fun:

``` powershell

> invoke-webrequest (Get-XkcdComicForToday).url -outfile image.png ; & ./image.png 

```

![Today's Comic](./pic.png)

