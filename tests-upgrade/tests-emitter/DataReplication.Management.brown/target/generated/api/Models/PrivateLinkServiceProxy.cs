// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Represents NRP private link service proxy.</summary>
    public partial class PrivateLinkServiceProxy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxyInternal
    {

        /// <summary>Backing field for <see cref="GroupConnectivityInformation" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IGroupConnectivityInformation> _groupConnectivityInformation;

        /// <summary>Gets or sets group connectivity information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IGroupConnectivityInformation> GroupConnectivityInformation { get => this._groupConnectivityInformation; set => this._groupConnectivityInformation = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Gets or sets private link service proxy id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for RemotePrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnection Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxyInternal.RemotePrivateEndpointConnection { get => (this._remotePrivateEndpointConnection = this._remotePrivateEndpointConnection ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RemotePrivateEndpointConnection()); set { {_remotePrivateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for RemotePrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxyInternal.RemotePrivateLinkServiceConnectionState { get => (this._remotePrivateLinkServiceConnectionState = this._remotePrivateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnectionState()); set { {_remotePrivateLinkServiceConnectionState = value;} } }

        /// <summary>Backing field for <see cref="RemotePrivateEndpointConnection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnection _remotePrivateEndpointConnection;

        /// <summary>Represent remote private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnection RemotePrivateEndpointConnection { get => (this._remotePrivateEndpointConnection = this._remotePrivateEndpointConnection ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RemotePrivateEndpointConnection()); set => this._remotePrivateEndpointConnection = value; }

        /// <summary>Gets or sets the remote private endpoint connection id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointConnectionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnectionInternal)RemotePrivateEndpointConnection).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnectionInternal)RemotePrivateEndpointConnection).Id = value ?? null; }

        /// <summary>
        /// Backing field for <see cref="RemotePrivateLinkServiceConnectionState" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState _remotePrivateLinkServiceConnectionState;

        /// <summary>Represents Private link service connection state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get => (this._remotePrivateLinkServiceConnectionState = this._remotePrivateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PrivateLinkServiceConnectionState()); set => this._remotePrivateLinkServiceConnectionState = value; }

        /// <summary>Gets or sets actions required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string RemotePrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).ActionsRequired = value ?? null; }

        /// <summary>Gets or sets description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string RemotePrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>Gets or sets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string RemotePrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionStateInternal)RemotePrivateLinkServiceConnectionState).Status = value ?? null; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceProxy" /> instance.</summary>
        public PrivateLinkServiceProxy()
        {

        }
    }
    /// Represents NRP private link service proxy.
    public partial interface IPrivateLinkServiceProxy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets group connectivity information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets group connectivity information.",
        SerializedName = @"groupConnectivityInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IGroupConnectivityInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IGroupConnectivityInformation> GroupConnectivityInformation { get; set; }
        /// <summary>Gets or sets private link service proxy id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets private link service proxy id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Gets or sets the remote private endpoint connection id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the remote private endpoint connection id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePrivateEndpointConnectionId { get; set; }
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
        string RemotePrivateLinkServiceConnectionStateActionsRequired { get; set; }
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
        string RemotePrivateLinkServiceConnectionStateDescription { get; set; }
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
        string RemotePrivateLinkServiceConnectionStateStatus { get; set; }

    }
    /// Represents NRP private link service proxy.
    internal partial interface IPrivateLinkServiceProxyInternal

    {
        /// <summary>Gets or sets group connectivity information.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IGroupConnectivityInformation> GroupConnectivityInformation { get; set; }
        /// <summary>Gets or sets private link service proxy id.</summary>
        string Id { get; set; }
        /// <summary>Represent remote private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointConnection RemotePrivateEndpointConnection { get; set; }
        /// <summary>Gets or sets the remote private endpoint connection id.</summary>
        string RemotePrivateEndpointConnectionId { get; set; }
        /// <summary>Represents Private link service connection state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get; set; }
        /// <summary>Gets or sets actions required.</summary>
        string RemotePrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>Gets or sets description.</summary>
        string RemotePrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>Gets or sets the status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Approved", "Disconnected", "Pending", "Rejected")]
        string RemotePrivateLinkServiceConnectionStateStatus { get; set; }

    }
}