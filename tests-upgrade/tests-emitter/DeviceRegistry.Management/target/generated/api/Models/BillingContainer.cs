// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>
    /// billingContainer Model as Azure resource whose sole purpose is to keep track of billables resources under a subscription.
    /// </summary>
    public partial class BillingContainer :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainer,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ProxyResource();

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>Resource ETag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.BillingContainerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.BillingContainerProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="BillingContainer" /> instance.</summary>
        public BillingContainer()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// billingContainer Model as Azure resource whose sole purpose is to keep track of billables resources under a subscription.
    public partial interface IBillingContainer :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IProxyResource
    {
        /// <summary>Resource ETag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource ETag",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get;  }

    }
    /// billingContainer Model as Azure resource whose sole purpose is to keep track of billables resources under a subscription.
    internal partial interface IBillingContainerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IProxyResourceInternal
    {
        /// <summary>Resource ETag</summary>
        string Etag { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get; set; }

    }
}