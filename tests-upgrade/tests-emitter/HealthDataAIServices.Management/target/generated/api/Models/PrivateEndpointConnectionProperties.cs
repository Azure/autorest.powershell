// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>Properties of the private endpoint connection.</summary>
    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private System.Collections.Generic.List<string> _groupId;

        /// <summary>The group ids for the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> GroupId { get => this._groupId; }

        /// <summary>Internal Acessors for GroupId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateEndpoint()); set { {_privateEndpoint = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointInternal)PrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointInternal)PrivateEndpoint).Id = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateLinkServiceConnectionState()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpoint _privateEndpoint;

        /// <summary>The private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpoint PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateEndpoint()); set => this._privateEndpoint = value; }

        /// <summary>The resource identifier of the private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateEndpointInternal)PrivateEndpoint).Id; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState _privateLinkServiceConnectionState;

        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.PrivateLinkServiceConnectionState()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired = value ?? null; }

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
        {

        }
    }
    /// Properties of the private endpoint connection.
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
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
    /// Properties of the private endpoint connection.
    internal partial interface IPrivateEndpointConnectionPropertiesInternal

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
        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get; set; }

    }
}