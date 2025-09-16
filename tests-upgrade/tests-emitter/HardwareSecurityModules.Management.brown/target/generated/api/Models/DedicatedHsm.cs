// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Resource information with extended details.</summary>
    public partial class DedicatedHsm :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsm,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.TrackedResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileNetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileNetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string ManagementNetworkProfileSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileSubnetResourceId = value ?? null; }

        /// <summary>Internal Acessors for ManagementNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.ManagementNetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ManagementNetworkProfileSubnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.ManagementNetworkProfileSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileSubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ManagementNetworkProfileSubnet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.NetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for NetworkProfileSubnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.NetworkProfileSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileSubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileSubnet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for StatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmInternal.StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).StatusMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).StatusMessage = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileNetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileNetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string NetworkProfileSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).NetworkProfileSubnetResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties _property;

        /// <summary>Properties of the dedicated HSM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.DedicatedHsmProperties()); set => this._property = value; }

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku _sku;

        /// <summary>SKU details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.Sku()); set => this._sku = value; }

        /// <summary>SKU of the dedicated HSM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string StampId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).StampId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).StampId = value ?? null; }

        /// <summary>Resource Status Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal)Property).StatusMessage; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>The availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="DedicatedHsm" /> instance.</summary>
        public DedicatedHsm()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Resource information with extended details.
    public partial interface IDedicatedHsm :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResource
    {
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementNetworkProfileSubnetResourceId { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileSubnetResourceId { get; set; }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("Succeeded", "Provisioning", "Allocating", "Connecting", "Failed", "CheckingQuota", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>SKU of the dedicated HSM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SKU of the dedicated HSM",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("SafeNet Luna Network HSM A790", "payShield10K_LMK1_CPS60", "payShield10K_LMK1_CPS250", "payShield10K_LMK1_CPS2500", "payShield10K_LMK2_CPS60", "payShield10K_LMK2_CPS250", "payShield10K_LMK2_CPS2500")]
        string SkuName { get; set; }
        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This field will be used when RP does not support Availability zones.",
        SerializedName = @"stampId",
        PossibleTypes = new [] { typeof(string) })]
        string StampId { get; set; }
        /// <summary>Resource Status Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Status Message.",
        SerializedName = @"statusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get;  }
        /// <summary>The availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The availability zones.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }

    }
    /// Resource information with extended details.
    internal partial interface IDedicatedHsmInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ITrackedResourceInternal
    {
        /// <summary>Specifies the management network interfaces of the dedicated hsm.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile ManagementNetworkProfile { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference ManagementNetworkProfileSubnet { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string ManagementNetworkProfileSubnetResourceId { get; set; }
        /// <summary>Specifies the network interfaces of the dedicated hsm.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile NetworkProfile { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference NetworkProfileSubnet { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string NetworkProfileSubnetResourceId { get; set; }
        /// <summary>Properties of the dedicated HSM</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties Property { get; set; }
        /// <summary>Provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("Succeeded", "Provisioning", "Allocating", "Connecting", "Failed", "CheckingQuota", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>SKU details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ISku Sku { get; set; }
        /// <summary>SKU of the dedicated HSM</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("SafeNet Luna Network HSM A790", "payShield10K_LMK1_CPS60", "payShield10K_LMK1_CPS250", "payShield10K_LMK1_CPS2500", "payShield10K_LMK2_CPS60", "payShield10K_LMK2_CPS250", "payShield10K_LMK2_CPS2500")]
        string SkuName { get; set; }
        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        string StampId { get; set; }
        /// <summary>Resource Status Message.</summary>
        string StatusMessage { get; set; }
        /// <summary>The availability zones.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }

    }
}