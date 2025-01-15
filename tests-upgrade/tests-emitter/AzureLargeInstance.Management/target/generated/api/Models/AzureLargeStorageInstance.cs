// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>
    /// AzureLargeStorageInstance info on Azure (ARM properties and
    /// AzureLargeStorageInstance properties)
    /// </summary>
    public partial class AzureLargeStorageInstance :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstance,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.TrackedResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for StorageProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.StorageProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageProperty = value; }

        /// <summary>Internal Acessors for StoragePropertyStorageBillingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceInternal.StoragePropertyStorageBillingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyStorageBillingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyStorageBillingProperty = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertyBillingMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageBillingPropertyBillingMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageBillingPropertyBillingMode = value ?? null; }

        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageBillingPropertySku { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageBillingPropertySku; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StorageBillingPropertySku = value ?? null; }

        /// <summary>the kind of storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyGeneration { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyGeneration; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyGeneration = value ?? null; }

        /// <summary>the hardware type of the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyHardwareType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyHardwareType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyHardwareType = value ?? null; }

        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyOfferingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyOfferingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyOfferingType = value ?? null; }

        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyProvisioningState = value ?? null; }

        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyStorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyStorageType = value ?? null; }

        /// <summary>the workload for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StoragePropertyWorkloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyWorkloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).StoragePropertyWorkloadType = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string UniqueIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).AzureLargeStorageInstanceUniqueIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)Property).AzureLargeStorageInstanceUniqueIdentifier = value ?? null; }

        /// <summary>Creates an new <see cref="AzureLargeStorageInstance" /> instance.</summary>
        public AzureLargeStorageInstance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// AzureLargeStorageInstance info on Azure (ARM properties and
    /// AzureLargeStorageInstance properties)
    public partial interface IAzureLargeStorageInstance :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource
    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>the billing mode for the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the billing mode for the storage instance",
        SerializedName = @"billingMode",
        PossibleTypes = new [] { typeof(string) })]
        string StorageBillingPropertyBillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the SKU type that is provisioned",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string StorageBillingPropertySku { get; set; }
        /// <summary>the kind of storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the kind of storage instance",
        SerializedName = @"generation",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePropertyGeneration { get; set; }
        /// <summary>the hardware type of the storage instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the hardware type of the storage instance",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string StoragePropertyHardwareType { get; set; }
        /// <summary>the offering type for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the offering type for which the resource is getting provisioned",
        SerializedName = @"offeringType",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePropertyOfferingType { get; set; }
        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of provisioning of the AzureLargeStorageInstance",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        string StoragePropertyProvisioningState { get; set; }
        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the storage protocol for which the resource is getting provisioned",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePropertyStorageType { get; set; }
        /// <summary>the workload for which the resource is getting provisioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the workload for which the resource is getting provisioned",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePropertyWorkloadType { get; set; }
        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the AzureLargeStorageInstance unique ID.",
        SerializedName = @"azureLargeStorageInstanceUniqueIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string UniqueIdentifier { get; set; }

    }
    /// AzureLargeStorageInstance info on Azure (ARM properties and
    /// AzureLargeStorageInstance properties)
    internal partial interface IAzureLargeStorageInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal
    {
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties Property { get; set; }
        /// <summary>the billing mode for the storage instance</summary>
        string StorageBillingPropertyBillingMode { get; set; }
        /// <summary>the SKU type that is provisioned</summary>
        string StorageBillingPropertySku { get; set; }
        /// <summary>Specifies the storage properties for the AzureLargeStorage instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties StorageProperty { get; set; }
        /// <summary>the kind of storage instance</summary>
        string StoragePropertyGeneration { get; set; }
        /// <summary>the hardware type of the storage instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string StoragePropertyHardwareType { get; set; }
        /// <summary>the offering type for which the resource is getting provisioned</summary>
        string StoragePropertyOfferingType { get; set; }
        /// <summary>State of provisioning of the AzureLargeStorageInstance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Canceled", "Migrating")]
        string StoragePropertyProvisioningState { get; set; }
        /// <summary>the billing related information for the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties StoragePropertyStorageBillingProperty { get; set; }
        /// <summary>the storage protocol for which the resource is getting provisioned</summary>
        string StoragePropertyStorageType { get; set; }
        /// <summary>the workload for which the resource is getting provisioned</summary>
        string StoragePropertyWorkloadType { get; set; }
        /// <summary>Specifies the AzureLargeStorageInstance unique ID.</summary>
        string UniqueIdentifier { get; set; }

    }
}