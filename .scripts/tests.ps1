
$inputs = @(
  "extensible-enums-swagger",
  "paging",
  "subscriptionId-apiVersion",
  "url-multi-collectionFormat",
  "validation"
  "custom-baseUrl-more-options", 
  "body-number", 
  "body-number.quirks",
  "body-boolean",
  "body-boolean.quirks",
  "body-byte",
  "body-date",
  "body-datetime",
  "body-datetime-rfc1123",
  "body-duration",
  "body-integer",
  "httpInfrastructure",
  "httpInfrastructure.quirks",
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
  
  "body-string.quirks",
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
  # "parameter-flattening" -- tags has multiple types when proxies combine. 
  # "model-flattening", - needs directive to work around circular reference
  # "lro",   -- location property conflicts with Location header property.

  # P1 Error compiling
  
  
)

$azureInputs = @(
 "azure-special-properties", # ERROR GENERATING
 "azure-parameter-grouping", # ERROR GENERATING

 "azure-report", # ERROR COMPILING
 "azure-resource", # ERROR COMPILING
 "azure-resource-x"# ERROR COMPILING 
)
