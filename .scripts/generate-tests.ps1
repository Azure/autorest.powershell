[CmdletBinding()]
param (
    [Parameter()]
    [string[]]
    $swaggers
)
# generates the AutoRest tests into separate modules

$root = ( resolve-path "$PSScriptRoot/..").Path
$outputRoot = ( resolve-path "$root/tests").Path

cd $root

# start @autorest/test-server
./powershell/node_modules/.bin/start-autorest-testserver

# source location for swagger files
$swaggerRoot = "http://localhost:3000/swagger/"
 
# AutoRest Choice
$autorest = (get-command autorest-beta).Source 

# use local generator
$powershellGenerator="--use:$(resolve-path $root/powershell)"

# use local remodeler if it's here.
if( test-path $root/../autorest.remodeler/remodeler ) {
  $remodeler="--use:$(resolve-path $root/../autorest.remodeler/remodeler)"
}

$success = @{}
$errors = @{}
$broken = @{}

function run-autorest($src) {
  $name = $src -replace '.json',''
  $outputFolder = "$outputRoot/$name"
  
  $txt = "$autorest $powershellGenerator $remodeler --input-file:$swaggerRoot$src --output-folder:$outputFolder --clear-output-folder --title:$name $args" 
  write-host -fore GREEN "`n--------------------------------------------------------`nGenerating [$name]`n--------------------------------------------------------`n"
  
  & $autorest $powershellGenerator $remodeler "--input-file:$swaggerRoot$src" "--output-folder:$outputFolder" "--clear-output-folder" "--title:$name"  $args
  $rc = $LastExitCode
  if( $rc -gt 0 ) {
    write-host -fore RED "`n--------------------------------------------------------`nFAILED GENERATION [$name]`n--------------------------------------------------------`n"
    $errors[$src] = $txt
  } else {
    & "$outputFolder/build-module.ps1"
    $rc2 = $lastExitCode
    if( $rc2 -gt 0  ){
    write-host -fore RED "`n--------------------------------------------------------`nFAILED COMPILATION [$name]`n--------------------------------------------------------`n"
        $broken[$src] = $txt
    } else {
        write-host -fore GREEN "`n--------------------------------------------------------`nSUCCESS [$name]`n--------------------------------------------------------`n"
        $success[$src] = $txt
    }
  }
}


$inputs = @(
    "extensible-enums-swagger.json",
    "paging.json",
    "subscriptionId-apiVersion.json",
    "url-multi-collectionFormat.json",
    "validation.json"
    "custom-baseUrl-more-options.json", 
    "body-number.json", 
    "body-number.quirks.json",
    "body-boolean.json",
    "body-boolean.quirks.json",
    "body-byte.json",
    "body-date.json",
    "body-datetime.json",
    "body-datetime-rfc1123.json",
    "body-duration.json",
    "body-integer.json",
    "httpInfrastructure.json",
    "httpInfrastructure.quirks.json",
    "required-optional.json",
    "body-string.json",
    "report.json",
    "head.json",
    "head-exceptions.json",
    "url.json",
    "custom-baseUrl.json"
    "body-array.json",
    "body-complex.json",
    "body-file.json",

    "complex-model.json",
    "model-flattening.json",
    "body-string.quirks.json",
    "body-dictionary.json"
) 

$unsupported = @(
    # ERROR Compiling
    
    # P1 Error Generating
    # "body-formdata-urlencoded.json", -- formdata is not currently supported
    # "body-formdata.json",  -- formdata is not currently supported
    # "header.json", -- headers as enum require further development
    # "additionalProperties.json",  -- when there is already a property named additionalProperties in a class with additionalProperties, there is a collision.
    # "storage.json", -- some problems with implementation of virtual properties 
    # "xml-service.json", -- xml not currently supported
    # "xms-error-responses.json" -- xml not currently supported
    # "parameter-flattening.json" -- tags has multiple types when proxies combine. 
    # "lro.json",   -- location property conflicts with Location header property.

    # P1 Error compiling
    
    
)

$azureInputs = @(
   "azure-special-properties.json", # ERROR GENERATING
   "azure-parameter-grouping.json", # ERROR GENERATING

   "azure-report.json", # ERROR COMPILING
   "azure-resource.json", # ERROR COMPILING
   "azure-resource-x.json"# ERROR COMPILING 
)

if( $swaggers -ne $null) {
  $azureInputs = $azureInputs |% { if( $swaggers.indexOf( $_ ) -gt -1 )  { return $_ } }
  $inputs = $inputs |% { if( $swaggers.indexOf( $_ ) -gt -1 )  { return $_ } }
}

$n = 0;

$inputs |% {
 if( $n -le 99 ) {
    run-autorest $_
  }
  $n = $n + 1
}

$azureInputs |% {
  run-autorest $_ --azure 
}

# stop @autorest/test-server
cd $root
./powershell/node_modules/.bin/stop-autorest-testserver


$success.Keys |% {
    write-host -fore GREEN $_  
}
$errors.Keys |% {
    write-host -fore RED $_  
}
$broken.Keys |% {
    write-host -fore YELLOW $_  
}
