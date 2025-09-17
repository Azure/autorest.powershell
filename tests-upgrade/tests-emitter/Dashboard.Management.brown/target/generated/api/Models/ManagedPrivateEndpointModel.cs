// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The managed private endpoint resource type.</summary>
    public partial class ManagedPrivateEndpointModel :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.TrackedResource();

        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateDescription; }

        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateStatus; }

        /// <summary>The group Ids of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).GroupId = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for ConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.ConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionState = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ConnectionStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.ConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateDescription = value ?? null; }

        /// <summary>Internal Acessors for ConnectionStateStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.ConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ConnectionStateStatus = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServicePrivateIP</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.PrivateLinkServicePrivateIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkServicePrivateIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkServicePrivateIP = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModelProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// The ARM resource ID of the resource for which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string PrivateLinkResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkResourceId = value ?? null; }

        /// <summary>
        /// The region of the resource to which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string PrivateLinkResourceRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkResourceRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkResourceRegion = value ?? null; }

        /// <summary>
        /// The private IP of private endpoint after approval. This property is empty before connection is approved.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string PrivateLinkServicePrivateIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkServicePrivateIP; }

        /// <summary>
        /// The URL of the data store behind the private link service. It would be the URL in the Grafana data source configuration
        /// page without the protocol and port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkServiceUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).PrivateLinkServiceUrl = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointModelProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).ProvisioningState; }

        /// <summary>User input request message of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string RequestMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).RequestMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal)Property).RequestMessage = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="ManagedPrivateEndpointModel" /> instance.</summary>
        public ManagedPrivateEndpointModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The managed private endpoint resource type.
    public partial interface IManagedPrivateEndpointModel :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResource
    {
        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionStateDescription { get;  }
        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The approval/rejection status of managed private endpoint connection.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string ConnectionStateStatus { get;  }
        /// <summary>The group Ids of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The group Ids of the managed private endpoint.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>
        /// The ARM resource ID of the resource for which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ARM resource ID of the resource for which the managed private endpoint is pointing to.",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>
        /// The region of the resource to which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The region of the resource to which the managed private endpoint is pointing to.",
        SerializedName = @"privateLinkResourceRegion",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceRegion { get; set; }
        /// <summary>
        /// The private IP of private endpoint after approval. This property is empty before connection is approved.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The private IP of private endpoint after approval. This property is empty before connection is approved.",
        SerializedName = @"privateLinkServicePrivateIP",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServicePrivateIP { get;  }
        /// <summary>
        /// The URL of the data store behind the private link service. It would be the URL in the Grafana data source configuration
        /// page without the protocol and port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The URL of the data store behind the private link service. It would be the URL in the Grafana data source configuration page without the protocol and port.",
        SerializedName = @"privateLinkServiceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceUrl { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }
        /// <summary>User input request message of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"User input request message of the managed private endpoint.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }

    }
    /// The managed private endpoint resource type.
    internal partial interface IManagedPrivateEndpointModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ITrackedResourceInternal
    {
        /// <summary>The state of managed private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState ConnectionState { get; set; }
        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        string ConnectionStateDescription { get; set; }
        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string ConnectionStateStatus { get; set; }
        /// <summary>The group Ids of the managed private endpoint.</summary>
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>
        /// The ARM resource ID of the resource for which the managed private endpoint is pointing to.
        /// </summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>
        /// The region of the resource to which the managed private endpoint is pointing to.
        /// </summary>
        string PrivateLinkResourceRegion { get; set; }
        /// <summary>
        /// The private IP of private endpoint after approval. This property is empty before connection is approved.
        /// </summary>
        string PrivateLinkServicePrivateIP { get; set; }
        /// <summary>
        /// The URL of the data store behind the private link service. It would be the URL in the Grafana data source configuration
        /// page without the protocol and port.
        /// </summary>
        string PrivateLinkServiceUrl { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }
        /// <summary>User input request message of the managed private endpoint.</summary>
        string RequestMessage { get; set; }

    }
}