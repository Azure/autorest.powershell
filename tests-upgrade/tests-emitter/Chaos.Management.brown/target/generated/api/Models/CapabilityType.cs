// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a Capability Type resource.</summary>
    public partial class CapabilityType :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityType,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ProxyResource();

        /// <summary>Control plane actions necessary to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureRbacAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacAction; }

        /// <summary>Data plane actions necessary to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureRbacDataAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacDataAction; }

        /// <summary>Localized string of the description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Description; }

        /// <summary>Localized string of the display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).DisplayName; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>String of the kind of this Capability Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Kind; }

        /// <summary>Internal Acessors for AzureRbacAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.AzureRbacAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AzureRbacDataAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.AzureRbacDataAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacDataAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).AzureRbacDataAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Kind = value ?? null; }

        /// <summary>Internal Acessors for ParametersSchema</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.ParametersSchema { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).ParametersSchema; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).ParametersSchema = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeProperties Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.CapabilityTypeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Publisher</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Publisher = value ?? null; }

        /// <summary>Internal Acessors for RequiredAzureRoleDefinitionId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.RequiredAzureRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RequiredAzureRoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RequiredAzureRoleDefinitionId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for RuntimeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesRuntimeProperties Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.RuntimeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RuntimeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RuntimeProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RuntimePropertyKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.RuntimePropertyKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RuntimePropertyKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RuntimePropertyKind = value ?? null; }

        /// <summary>Internal Acessors for TargetType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.TargetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).TargetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).TargetType = value ?? null; }

        /// <summary>Internal Acessors for Urn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeInternal.Urn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Urn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Urn = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>URL to retrieve JSON schema of the Capability Type parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string ParametersSchema { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).ParametersSchema; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeProperties _property;

        /// <summary>The properties of the capability type resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.CapabilityTypeProperties()); set => this._property = value; }

        /// <summary>String of the Publisher that this Capability Type extends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Publisher; }

        /// <summary>Required Azure Role Definition Ids to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RequiredAzureRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RequiredAzureRoleDefinitionId; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>String of the kind of the resource's action type (continuous or discrete).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string RuntimePropertyKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).RuntimePropertyKind; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>String of the Target Type that this Capability Type extends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string TargetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).TargetType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>String of the URN for this Capability Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public string Urn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesInternal)Property).Urn; }

        /// <summary>Creates an new <see cref="CapabilityType" /> instance.</summary>
        public CapabilityType()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Model that represents a Capability Type resource.
    public partial interface ICapabilityType :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IProxyResource
    {
        /// <summary>Control plane actions necessary to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Control plane actions necessary to execute capability type.",
        SerializedName = @"azureRbacActions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AzureRbacAction { get;  }
        /// <summary>Data plane actions necessary to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Data plane actions necessary to execute capability type.",
        SerializedName = @"azureRbacDataActions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AzureRbacDataAction { get;  }
        /// <summary>Localized string of the description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Localized string of the description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Localized string of the display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Localized string of the display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>String of the kind of this Capability Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the kind of this Capability Type.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }
        /// <summary>URL to retrieve JSON schema of the Capability Type parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL to retrieve JSON schema of the Capability Type parameters.",
        SerializedName = @"parametersSchema",
        PossibleTypes = new [] { typeof(string) })]
        string ParametersSchema { get;  }
        /// <summary>String of the Publisher that this Capability Type extends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the Publisher that this Capability Type extends.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get;  }
        /// <summary>Required Azure Role Definition Ids to execute capability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Required Azure Role Definition Ids to execute capability type.",
        SerializedName = @"requiredAzureRoleDefinitionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredAzureRoleDefinitionId { get;  }
        /// <summary>String of the kind of the resource's action type (continuous or discrete).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the kind of the resource's action type (continuous or discrete).",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimePropertyKind { get;  }
        /// <summary>String of the Target Type that this Capability Type extends.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the Target Type that this Capability Type extends.",
        SerializedName = @"targetType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetType { get;  }
        /// <summary>String of the URN for this Capability Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String of the URN for this Capability Type.",
        SerializedName = @"urn",
        PossibleTypes = new [] { typeof(string) })]
        string Urn { get;  }

    }
    /// Model that represents a Capability Type resource.
    internal partial interface ICapabilityTypeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IProxyResourceInternal
    {
        /// <summary>Control plane actions necessary to execute capability type.</summary>
        System.Collections.Generic.List<string> AzureRbacAction { get; set; }
        /// <summary>Data plane actions necessary to execute capability type.</summary>
        System.Collections.Generic.List<string> AzureRbacDataAction { get; set; }
        /// <summary>Localized string of the description.</summary>
        string Description { get; set; }
        /// <summary>Localized string of the display name.</summary>
        string DisplayName { get; set; }
        /// <summary>String of the kind of this Capability Type.</summary>
        string Kind { get; set; }
        /// <summary>URL to retrieve JSON schema of the Capability Type parameters.</summary>
        string ParametersSchema { get; set; }
        /// <summary>The properties of the capability type resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypeProperties Property { get; set; }
        /// <summary>String of the Publisher that this Capability Type extends.</summary>
        string Publisher { get; set; }
        /// <summary>Required Azure Role Definition Ids to execute capability type.</summary>
        System.Collections.Generic.List<string> RequiredAzureRoleDefinitionId { get; set; }
        /// <summary>Runtime properties of this Capability Type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ICapabilityTypePropertiesRuntimeProperties RuntimeProperty { get; set; }
        /// <summary>String of the kind of the resource's action type (continuous or discrete).</summary>
        string RuntimePropertyKind { get; set; }
        /// <summary>String of the Target Type that this Capability Type extends.</summary>
        string TargetType { get; set; }
        /// <summary>String of the URN for this Capability Type.</summary>
        string Urn { get; set; }

    }
}