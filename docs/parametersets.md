# ParameterSets in Autorest Generation

When developing PowerShell commands for a service, you may encounter various command variants related to creating new resources. These variants correspond to different parameter sets and are used in different scenarios, let's take `create` for example:

1. Create: This is the standard Create command that accepts a request body as input and creates a new resource in the service.

2. CreateExpanded: This variant is used when the request body contains nested objects or arrays. It flattens the request body and expands the properties, making it easier to work with in PowerShell.

3. CreateViaIdentity: This variant is used when you want to create a new resource by referencing an existing resource in the service. It accepts an identity object as input (suppoorting Powershell pipeline) and uses it to create the new resource.

4. CreateViaIdentityExpanded: This variant combines the functionality of CreateExpanded and CreateViaIdentity. It accepts an identity object as input and flattens the request body, expanding the properties.

Similar variants may exist for other verbs, such as Update, Get, Remove, etc. 
For New-* cmdlets, ViaIdentity is not required, so CreateViaIdentityExpanded is removed as well.

Whether or not to use these variants in your service depends on the specific requirements and scenarios of your service. In general, you may want to consider using these variants if your service has complex request bodies with nested objects or arrays, or if you want to support creating resources via identity objects.

Documentation on these variants may vary depending on the service and platform you are using. However, you can refer to the example of readme.md in [here](https://eng.ms/docs/cloud-ai-platform/azure-core/azure-management-and-platforms/control-plane-bburns/azure-cli-tools-azure-cli-powershell-and-terraform/azure-cli-tools/onboarding/azurepowershell/dev_guidance_codegen#service-configuration).
