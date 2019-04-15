
# generates the AutoRest tests into separate modules


$root = $PSScriptRoot
$outputRoot = "$root/output"

# source location for swagger files
$swaggerRoot = "https://raw.githubusercontent.com/Azure/autorest.testserver/master/swagger/"
 
# AutoRest Choice
$autorest = (get-command autorest).Source 
 
# PowerShell Generator Choice.
# $powershell-generator= '--powershell'
$powershellGenerator="--use:$(resolve-path $root/..)"

$success = @{}
$errors = @{}
$broken = @{}

function run-autorest($src) {
  $name = $src -replace '.json',''
  $outputFolder = "$outputRoot/$name"
  
  $txt = "$autorest $powershellGenerator --input-file:$swaggerRoot$src --output-folder:$outputFolder --clear-output-folder --title:$name $args"
  write-host -fore GREEN "`n--------------------------------------------------------`nGenerating [$name]`n--------------------------------------------------------`n"
  
  & $autorest $powershellGenerator "--input-file:$swaggerRoot$src" "--output-folder:$outputFolder" "--clear-output-folder" "--title:$name" $args
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

$working = @(
    "extensible-enums-swagger.json",
    "head.json",
    "head-exceptions.json",
    "lro.json",  
    "paging.json",
    "parameter-flattening.json",
    "subscriptionId-apiVersion.json",
    "url-multi-collectionFormat.json",
    "validation.json"
    "additionalProperties.json",  
    "custom-baseUrl-more-options.json", 
    "custom-baseUrl.json",
    "body-array.json",
    "body-number.json", 
    "body-number.quirks.json",
    "body-boolean.json",
    "body-boolean.quirks.json",
    "body-byte.json",
    "body-complex.json",
    "body-date.json",
    "body-datetime.json",
    "body-datetime-rfc1123.json",
    "body-duration.json",
    "body-integer.json",
    "httpInfrastructure.json",
    "httpInfrastructure.quirks.json",
    "url.json",
    "header.json",
    "required-optional.json"
) 

$inputs = @(
    # ERROR Compiling
    
      # P1 Error Generating
    "body-dictionary.json",
    "body-formdata-urlencoded.json",
    "report.json",
    "complex-model.json"
    
    "model-flattening.json",
    "storage.json",
    
    "body-file.json",
    "body-formdata.json",
    "body-string.json",
    "body-string.quirks.json",
    
    # P1 Error Generating
    "body-dictionary.json",
    "body-formdata-urlencoded.json",
    "report.json",
    "complex-model.json"
    
#    "xml-service.json",
#    "xms-error-responses.json "
)

$azureInputs = @(
    "azure-report.json", # ERROR GENERATING
    
   "azure-parameter-grouping.json", # ERROR COMPILING 
   "azure-resource.json", # ERROR COMPILING
   "azure-resource-x.json",# ERROR COMPILING 
   "azure-special-properties.json"# ERROR COMPILING
)
$n = 0;

$inputs |% {
 if( $n -le 90 ) {
    run-autorest $_
  }
  $n = $n + 1
}

$azureInputs |% {
 # run-autorest $_ --azure
}

$success.Keys |% {
    $each = $errors[$_]
    write-host -fore GREEN $_  # : $each
}
$errors.Keys |% {
    $each = $errors[$_]
    write-host -fore RED $_  # : $each
}
$broken.Keys |% {
    $each = $broken[$_]
    write-host -fore YELLOW $_  # : $each
}
