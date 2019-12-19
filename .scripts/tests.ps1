
$inputs = @(
  "extensible-enums-swagger",
  "paging",
  "subscriptionId-apiVersion",
  "url-multi-collectionFormat",
  "validation"
  "custom-baseUrl-more-options", 
  "body-number", 
  "body-boolean",
  "body-byte",
  "body-date",
  "body-datetime",
  "body-datetime-rfc1123",
  "body-duration",
  "body-integer",
  "httpInfrastructure",
  "required-optional",
  "body-string",
  "report",
  "head",
  "head-exceptions",
  "url",
  "custom-baseUrl"
  "body-array",
  "body-complex",
  "body-file",
  "complex-model",
  "body-dictionary"
) 

$unsupported = @(
  # ERROR Compiling
  
  # P1 Error Generating
  # "body-formdata-urlencoded", -- formdata is not currently supported
  # "body-formdata",  -- formdata is not currently supported
  # "header", -- headers as enum require further development
  # "additionalProperties",  -- when there is already a property named additionalProperties in a class with additionalProperties, there is a collision.
  # "storage", -- some problems with implementation of virtual properties 
  # "xml-service", -- xml not currently supported
  # "xms-error-responses" -- xml not currently supported
  # "parameter-flattening" -- parameter flattening isn't used in powershell
  # "model-flattening", - model flattening isn't used in powershell.
  # "lro",   -- location property conflicts with Location header property.

)

$azureInputs = @(
 "azure-special-properties", 
 "azure-parameter-grouping", 

 "azure-report", 
 "azure-resource", 
 "azure-resource-x"
)
