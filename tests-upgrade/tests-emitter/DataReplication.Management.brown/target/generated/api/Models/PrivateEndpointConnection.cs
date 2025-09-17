// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Represents private endpoint connection.</summary>
    public partial class PrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnection,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateEndpoint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionState = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponseProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Gets or sets the id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateEndpointId = value ?? null; }

        /// <summary>Gets or sets actions required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value ?? null; }

        /// <summary>Gets or sets description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>Gets or sets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponseProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PrivateEndpointConnectionResponseProperties()); set => this._property = value; }

        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponsePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnection" /> instance.</summary>
        public PrivateEndpointConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Represents private endpoint connection.
    public partial interface IPrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource
    {
        /// <summary>Gets or sets the id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get; set; }
        /// <summary>Gets or sets actions required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets actions required.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>Gets or sets description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>Gets or sets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Approved", "Disconnected", "Pending", "Rejected")]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets provisioning state of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }

    }
    /// Represents private endpoint connection.
    internal partial interface IPrivateEndpointConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResourceInternal
    {
        /// <summary>
        /// Represent private Endpoint network resource that is linked to the Private Endpoint connection.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>Gets or sets the id.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Represents Private link service connection state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Gets or sets actions required.</summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>Gets or sets description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>Gets or sets the status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Approved", "Disconnected", "Pending", "Rejected")]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionResponseProperties Property { get; set; }
        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }

    }
}