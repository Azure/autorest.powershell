# Autorest.PowerShell v4 new features

This document offers a summary of the latest functionalities introduced in autorest.powershell v4 and provides instructions on their utilization.

## Support for piping parent object

**This feature is unique to Azure as it relies on specific design elements within Azure services.**

With configuration `enable-parent-pipeline-input: true`, additional parameter sets for pipeline input will be generated.
For resource /A1/A2/.../An-1/An, generate parameter sets that take

    ViaIdentity: An as identity
    ViaIdentity{An-1}: An-1 as identity + An Name
    ...
    ViaIdentity{A1}: A1 as identity + [A2 + A3 + ... + An-1 + An] Names

For example, `Update-AzSpringCloudAppDeployment` now supports:

```
Get-AzSpringCloud -ResourceGroupName $rgName -Name $serviceName | Update-AzSpringCloudAppDeployment -AppName $appName -Name $deploymentName
Get-AzSpringCloudApp -ResourceGroupName $rgName -ServiceName $serviceName -Name $appName | Update-AzSpringCloudAppDeployment -Name $deploymentName
```

**Notice: There are parameter sets conflicts between GET and LIST for certain resources, LIST operations wouldn't accept pipeline input by default. Please consider using configuration `enable-parent-pipeline-input-for-list: true` to disable pipeline input for GET and enable pipeline input for LIST.**

## Progress bar for long running operation

In autorest.powershell v4 all the cmdlets based on long running operations will display a progress bar during execution. The purpose is to provide a visual effect indicating that the cmdlet is still running. You can preview it [here](https://github.com/Azure/autorest.powershell/pull/1013).

The progress bar is purely visual. It doesn't impact the input or output of the cmdlet, so it is not a breaking change, and there is no switch to turn it on or off.

Implementation-wise, the progress bar is tied to polling requests. The cmdlet sends out the first request (usually a PUT) and waits for the next polling. While waiting, the bar gets displayed, and its progress goes from 0 to 100. Then a polling request is sent, cmdlet waits again, progress bar shows up, and so on...

## Auto completer for parameters with x-ms-enum extension

In v3, autorest.poweshell defines an enum type for parameter with x-ms-enum. In v4, autorest.powershell keeps the type of parameter as it is, like string, integer and adds an auto completer for this parameter, which means parameter uses primary type as its type to simplify parameter definition and customer still can fill enum values by **Tab**.

## Switch between table view and list view based on result number

In v4, autorest.powershell determines the format of results based on their quantity. When a single result is returned, autorest.powershell utilizes a list view to present more detailed information for that specific result. However, when multiple results are returned, autorest.powershell switches to a table view to display concise information, similar to how it was done in v3.

To maintain consistency with v3 in v4, developers have the option to disable the automatic view switching by using the `auto-switch-view: false` configuration.

## Add ExternalDocs info to command help documentation

This feature values the information defined by metadata ExternalDocs in swagger, add the link to command help documentation.

## Non-fixed size array in model classes

In v4, autorest.powershell generates lists instead of fixed-size arrays for array members in model classes. This change simplifies the addition of new elements using the Add function.

## New functionalities supported by directives

### Customizing command description

Developers can define a description for each command. Otherwise, autorest.powershell uses operation description defined by swagger.

```
- where:
    verb: Get
    subject: Databricks
  set:
    command-description: 'Get or list data brick(s)'
```

### Suppressing shouldprocess

autorest.powershell generates `-confirm` and `-whatIf` parameters for writable operations (post/put/delete/patch) by default. However, in certain scenarios, this default behavior may be incorrect. For example, post APIs like ListKey/CheckNameAvailability do not alter any data, so supporting **shouldprocess** is unnecessary. To address this, we offer a directive like the following examples that allows the suppression of **shouldprocess** specifically for such cases.

```
- where:
    verb: Get
  set:
    suppress-should-process: true
```

### Creating a model cmdlet with a customized name

By utilizing this directive, we can generate a cmdlet that facilitates the creation of a model instance.

Here's an illustration showcasing the creation of a model cmdlet named New-AzWorkspaceObject for the Workspace model class.

```
- model-cmdlet:
  - model-name: Workspace
    cmdlet-name: New-AzWorkspaceObject
```

### Adding a parameter

By employing this directive, we can incorporate a customized parameter for specific cmdlets.

Here's an example demonstrating the addition of a mandatory parameter, ResourceId, to the Get-AzWorkspace cmdlet.

```
- where:
    subject: Workspace
    verb: Get
  add:
    parameters:
      - name: ResourceId
        type: string
        required: true
        description: "Add a new parameter"
```

### Adding input handler

By utilizing this directive, we have the ability to include multiple handlers that will execute with the Get-AzWorkspace cmdlet prior to sending the request to the backend service.

Here's an example illustrating the addition of two handlers for the mentioned cmdlet.

```
- where:
    verb: Get
    subject: Workspace
  add:
    pipelines:
      input-pipeline:
      # default priority is 100, smaller ones will be executed first
      - name: handler0
        priority: 200
      - name: handler1
        priority: 100
```

## Removal of API version from the namespace

In autorest.powershell v4, we have made a change where the generated C# code will no longer include the version in the namespace. For example, in v3, the namespace would be something like `namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201`, but in v4, it will be `namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models`.

However, it's important to note that this feature can be disabled by setting the `add-api-version-in-model-namespace` configuration to `true`.

## Importing JSON files for resource creation

In autorest.powershell v4, we add a new switch: `support-json-input`. This switch is default open in Azure and default close in Non-Azure. When this switch is opened. Two new variant *ViaJsonString and *ViaJsonFilePath will be added to all the cmdlets who has a http body. You can remove them via directive.

*ViaJsonString will create a new parameter set that accepts a parameter named as JsonString for request body. The value of the JsonString will be sent to service as the http request body directly.

*ViaJsonFilePath will create a new parameter set that accepts a parameter named as JsonFilePath for request body. The content contained in the JsonFilePath will be directly sent to the service as the HTTP request body.

## Support for x-ms-mutability

In autorest.powershell v4, the x-ms-mutability extension is not taken into account, but we have introduced support for it in v4.

For more information about x-ms-mutability and its details, please refer to the documentation at [here](https://github.com/Azure/autorest/blob/main/docs/extensions/readme.md#x-ms-mutability).

To determine whether a cmdlet is intended for creation or update, we follow the following criteria:

- If a cmdlet is associated with a PUT API and its verb is "New," it will be identified as a cmdlet for creation.
- If a cmdlet is associated with a PATCH API and its verb is "Update," it will be identified as a cmdlet for update.

## Managed Identity Best Practice Alignment

In autorest.powershell v4, IdentityType and UserAssignedIdentity are generated to align our best practice design. As a result, generated cmdlets will have changes as below.

- For IdentityType, it will be changed to EnableSystemAssignedIdentity\<SwitchParameter\> for new-* cmdlet and EnableSystemAssignedIdentity\<bool\> for update-* cmdlet.
- For UserAssignedIdentity, it will be changed from UserAssignedIdentity\<HashTable\> to UserAssignedIdentity\<string\[\]\>.

## Implemented retry policy

We have introduced two retry policies with the following details:

- Retry on 5XX and 429 errors (without retry-after header):
  - The default retry time is set to 3 attempts.
  - It is possible to override the default retry time by using the environment variables PS_HTTP_MAX_RETRIES or AZURE_PS_HTTP_MAX_RETRIES. If both variables are set, AZURE_PS_HTTP_MAX_RETRIES takes precedence.
- Retry specifically on 429 errors that include a retry-after header:
  - The default retry time is set to the maximum integer value
  - It is possible to customize the retry time by using the environment variables PS_HTTP_MAX_RETRIES_FOR_429 or AZURE_PS_HTTP_MAX_RETRIES_FOR_429

Last, this feature could be turned off by setting `enable-api-retry` to `false`.

## Support update resource by Get and PUT operation for resource without PATCH API

Update cmdlets will be generated to performs GET then PUT when a resource has

- no PATCH operation
- both PUT and GET operations with same path
- there is one GET operation has only one response defined, and the schema matches the request of PUT operation

**Please notice it would conflict with customized Update cmdlets if above conditions fulfilled. Please consider using flag `disable-getput: true`.**

## Change some opt-in configurations to opt-out

**Note: Azure means `azure: true` is set in README.md.**

| Configuration | Applied Scope    | Comments    |
| ------------- | ----------- | ----------- |
| resourcegroup-append | Azure only | Add the resourcegroup in the result |
| identity-correction-for-post | Azure only | Remove action from path for Id validation |
| export-properties-for-dict | All, but disabled by default for non-Azure service | Export Keys, Values, Count in the object with additional properties |
| nested-object-to-string | All, but disabled by default for non-Azure service | Serialize nested object in the result to JSON string |

## Hide value of discriminator parameter in auxiliary cmdlets

This feature is to remove the redundant parameter that was mapped to the discriminator when generating the model cmdlet for a child class.
Let's say we have a schema defined as below.

```
"definitions": {
 "SqlDefinition": {
     "x-ms-discriminator-value": "USql",
     "allOf": [
       {
         "$ref": "#/definitions/SqlProperties"
       }
     ],
     "properties": {}
  }
  "SqlProperties": {
     "properties": {
         "kind": {"type": "string"}
     }
    "discriminator": "kind"
  }
}
```

By using the following directive, autorest.powershell generates a cmdlet that assists users in creating an instance of SqlDefinition. The issue in v3 is the generation of a redundant parameter called "-kind" with a constant value of "USql". However, in v4, we have addressed this problem by eliminating the redundant parameter.

```
- model-cmdlet
    - model-name: SqlDefinition
```

## Customization through input handler pipeline

We offer support for adding customized input handlers through the use of an input handler pipeline. Here's an example use case where we hide the original "ResourceGroupName" parameter and introduce a new parameter called "ResourceId." Developers are required to implement the process function, which is generated in the custom/input-handlers/IdToName.cs file, to convert the ResourceGroupName to the desired ResourceId.

```
# Add a new parameter 
- where:
     subject: Workspace
     variant: ^Get$|^GetViaIdentity$|^List$
     verb: Get
   add:
     parameters:
       - name: ResourceId
         type: string
         required: true
         description: "Add a new parameter"
# Hide the parameter, which will be calculated from the new added one
 - where:
     subject: Workspace
     verb: Get
     parameter-name: ResourceGroupName
   hide: true
 - where:
     verb: Get
     subject: Workspace
   add:
     pipelines:
       input-pipeline:
         - name: IdToName
```

As a result, a file named IdToName.cs will be generated in the custom/input-handlers directory. Developers are then expected to implement it according to their specific requirements. Here is an example implementation for your reference.

```
namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Cmdlets
{
    public class IdToName : InputHandler
    {
        private string ConvertIdToName(string id)
        {
            return id.Substring(id.LastIndexOf('/') + 1);
        }
        public override void Process(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IContext context)
        {
            // ToDO: Add the custom code here
            context.InvocationInformation.BoundParameters["ResourceGroupName"] = this.ConvertIdToName(context.InvocationInformation.BoundParameters["ResourceId"].ToString());
            NextHandler?.Process(context);
        }
    }
}
```

Moreover, you have the opportunity to utilize the context and incorporate any customized logic you desire prior to making the service call.
