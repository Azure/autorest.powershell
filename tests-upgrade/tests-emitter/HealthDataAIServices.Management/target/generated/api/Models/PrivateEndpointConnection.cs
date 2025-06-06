// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>The private endpoint connection resource</summary>
    public partial class PrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnection,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.Resource();

        /// <summary>The group ids for the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for GroupId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).GroupId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateEndpointConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Name; }

        /// <summary>The resource identifier of the private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; }

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value ?? null; }

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionProperties _property;

        /// <summary>The private endpoint connection properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateEndpointConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnection" /> instance.</summary>
        public PrivateEndpointConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The private endpoint connection resource
    public partial interface IPrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResource
    {
        /// <summary>The group ids for the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The group ids for the private endpoint resource.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> GroupId { get;  }
        /// <summary>The resource identifier of the private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource identifier of the private endpoint",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get;  }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected")]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the private endpoint connection resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get;  }

    }
    /// The private endpoint connection resource
    internal partial interface IPrivateEndpointConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IResourceInternal
    {
        /// <summary>The group ids for the private endpoint resource.</summary>
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>The private endpoint resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource identifier of the private endpoint</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected")]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The private endpoint connection properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionProperties Property { get; set; }
        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get; set; }

    }
}