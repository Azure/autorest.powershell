# Migrating from v3 to v4

This documentation is targeted at developers who are currently using autorest.powershell v3 to generate PowerShell modules and are considering transitioning to autorest.powershell v4. The purpose is to provide an overview of all the changes that may cause compatibility issues in v4 and offer appropriate mitigation steps, if necessary.

When the Azure switch (azure: true) is enabled, autorest.powershell generates code specific to Azure services.

Each breaking change will fall into one of three scopes. If not explicitly specified, the default scope will be set to **ALL**.

- Azure
- None-Azure
- All

## Option-in to Option-out configurations

Note: The breaking change is specific to **Azure**.

In v3, the following configurations are set to `false` by default and changed to `true` by default in v4.

| Configuration | Comments    |
| ------------- | ----------- |
| resourcegroup-append | Add the resourcegroup in the result |
| identity-correction-for-post| Remove action from path for ID validation |
| export-properties-for-dict | Export Keys, Values, Count in the object with additional properties |
| nested-object-to-string | Serialize nested object in the result to JSON string |

### How to mitigate the breaking changes

You must explicitly set the configuration to `false` in v4 if you wish to maintain the default v3 configuration.

## Directive breaking changes

### To match variants

More variants will be generated in v4, like (parent pipeline input, via JSON string, Update), directives to match variants need to be more precise while renaming, removing or hiding variants. For example:

**To remove create variants take identity as pipeline input:**

```
- where:
    variant: ^CreateViaIdentity.*$
  remove: true
```

**To remove non-expanded create or update variants:**

```
- where:
    variant: ^(Create|Update)(?!.*?(Expanded|JsonFilePath|JsonString))
  remove: true
```

**To rename verb for variants started with certain name:**

```
- where:
    subject: ^XXX$
    variant: ^Reimage.*$
  set:
    subject: ^XXX$
    verb: Invoke
```

**For Azure service, when there are no PATCH API and Set variants were renamed to Update (because Update variants will now be generated for such cases):**

```
- where:
    subject: ^XXX$
    verb: Update
  remove: true
- where:
    subject: ^XXX$
    verb: Set
  set:
    verb: Update
```

### model cmdlet

#### Breaking change of directive syntax

In v3, we could use the following directive to add a purely client-side cmdlet for creating a model instance:

```
- model-cmdlet
  - xxx
```

In v4, the directive has changed to support setting the name for the model cmdlet:

```
- model-cmdlet:
  - model-name: xxx
    cmdlet-name: cmdlet-name
```

##### How to mitigate the breaking change

You'll need to customize it through a PowerShell script by adding the redundant parameter back to avoid the breaking change

#### Remove redundant parameters mapped to the discriminator

Another breaking change (actually a bug fix) in v4 involves removing a redundant parameter that was mapped to the discriminator when generating the model cmdlet for a child class.

##### How to mitigate the breaking change caused by removing redundant parameters

You'll need to customize it through a PowerShell script by adding the redundant parameter back to avoid the breaking change

## AutoCompleter

In v3, autorest.poweshell defines an enum type for parameter with x-ms-enum. In v4, autorest.powershell keeps the type of parameter as it is, like string, integer and adds an auto completer for this parameter, which means parameter uses primary type as its type to simplify parameter definition and customer still can fill enum values by **Tab**.

### Steps need to be taken for AutoCompleter change

Developers need to change parameter type to its primary type in custom folder and customized codes accordingly. No breaking change is expected from user side.

## API version is dropped from namespace

In v4, we introduced a switch to control whether to include the API version in the generated namespace of C# code. By default, this switch is disabled. In v3, the API version was always included in the namespace.

### Steps need to be taken with API version dropped

Remove API version from files in custom folder

### How to mitigate the breaking changes by adding the version back

Set `add-api-version-in-model-namespace` to `true` in README.md

## Retry policy

In v4, we have implemented retry functionality for 5XX and 429 errors, which was not supported in v3. This may be considered a breaking change if developers did not anticipate the retry behavior.

The default retry policy is defined as follows.

- Default retry time is 3 for 5XX and 429 without retry-after.
- Default retry time is max(int) for 429 with retry-after.

### How to mitigate the breaking changes for retry policy

Set `enable-api-retry` to `false` in README.md

## Commands for private endpoint and private link resource are removed

Note: The breaking change is specific to **Azure**.

In v4, we omit commands for private endpoint and private link resource if flag azure or azure-arm is true because these operations are managed by {}-AzPrivateEndpoint and {}-AzPrivateLinkResource in Az.Network in uniform.

### Recommended way to implement these features

Register service configuration by following [guideline](https://github.com/Azure/azure-powershell/blob/main/documentation/development-docs/examples/private-link-resource-example.md).

### how to mitigate the breaking changes for private endpoint by one configure

Configure `keep-pec-and-plr` as `true` in README.md

```
keep-pec-and-plr: true
```

## None-fixed array

In v3, if a response contained a property with an array type, it was generated as a fixed-size C# array that couldn't support adding new elements through functions like Add. In v4, by default, we generate a list instead of an array to support the Add function in such cases. As a result, from users' perspective, the following modifications should be made in scripts that utilize PowerShell modules generated with v4:

- Use Count instead of Length to retrieve the number of elements
- Use the ToArray function if conversion to a fixed-size array is needed

### How to mitigate the breaking changes of non-fixed array

Configure `fixed-array` as `true` in README.md

```
fixed-array: true
```


## X-ms-mutability support

In v3, x-ms-mutability is ignored and in v4 we have provided support for it. As a result, generated cmdlets will have changes as below.

- If x-ms-mutability of a property is set to something like ['update'] without 'create', we will only add the parameter for update-* cmdlet.
- If x-ms-mutability of a property is set to something like ['create', 'read'] without 'update', we will only add the parameter for new-* cmdlet.
- If x-ms-mutability of a property is set to ['read'], we will not create the parameter for it since it is read-only actually.
For model cmdlet, a parameter is required only if it is marked as required, both 'create' and 'update' are set.

### How to mitigate the breaking changes of x-ms-mutability

There is no mitigation since it is actually a fix for existing issues.

## Managed Identity Best Practice Alignment

In v3, IdentityType and UserAssignedIdentity are generated and totally matches with swagger definition. In v4, we generate them to align our best practice design. As a result, generated cmdlets will have changes as below.

- For IdentityType, it will be changed to EnableSystemAssignedIdentity\<SwitchParameter\> for new-* cmdlet and EnableSystemAssignedIdentity\<bool\> for update-* cmdlet. Please notice that this change in update-* cmdlet will use GET+PUT operation instead of PATCH operation to update object and can't be disabled by `disable-getput: true`.
- For UserAssignedIdentity, it will be changed from UserAssignedIdentity\<HashTable\> to UserAssignedIdentity\<string\[\]\>.


### How to mitigate the breaking changes of Managed Identity Best Practice Alignment

It's recommended to migrate to best practice design for managed identity features. To avoid breaking changes in regular release, 
- For IdentityType, configure `disable-transform-identity-type` as `true` in README.md.
- For UserAssignedIdentity, configure `flatten-userassignedidentity` as `false` in README.md.
