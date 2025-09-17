// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>
    /// Represent remote private endpoint information for the private endpoint connection proxy.
    /// </summary>
    public partial class RemotePrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal
    {

        /// <summary>Backing field for <see cref="ConnectionDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> _connectionDetail;

        /// <summary>
        /// Gets or sets the list of Connection Details. This is the connection details for private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> ConnectionDetail { get => this._connectionDetail; set => this._connectionDetail = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Gets or sets private link service proxy id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ManualPrivateLinkServiceConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> _manualPrivateLinkServiceConnection;

        /// <summary>
        /// Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> ManualPrivateLinkServiceConnection { get => this._manualPrivateLinkServiceConnection; set => this._manualPrivateLinkServiceConnection = value; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> _privateLinkServiceConnection;

        /// <summary>
        /// Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> PrivateLinkServiceConnection { get => this._privateLinkServiceConnection; set => this._privateLinkServiceConnection = value; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceProxy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> _privateLinkServiceProxy;

        /// <summary>Gets or sets the list of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> PrivateLinkServiceProxy { get => this._privateLinkServiceProxy; set => this._privateLinkServiceProxy = value; }

        /// <summary>Creates an new <see cref="RemotePrivateEndpoint" /> instance.</summary>
        public RemotePrivateEndpoint()
        {

        }
    }
    /// Represent remote private endpoint information for the private endpoint connection proxy.
    public partial interface IRemotePrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the list of Connection Details. This is the connection details for private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of Connection Details. This is the connection details for private endpoint.",
        SerializedName = @"connectionDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> ConnectionDetail { get; set; }
        /// <summary>Gets or sets private link service proxy id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets private link service proxy id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>
        /// Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.",
        SerializedName = @"manualPrivateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.",
        SerializedName = @"privateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> PrivateLinkServiceConnection { get; set; }
        /// <summary>Gets or sets the list of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of private link service proxies.",
        SerializedName = @"privateLinkServiceProxies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> PrivateLinkServiceProxy { get; set; }

    }
    /// Represent remote private endpoint information for the private endpoint connection proxy.
    internal partial interface IRemotePrivateEndpointInternal

    {
        /// <summary>
        /// Gets or sets the list of Connection Details. This is the connection details for private endpoint.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> ConnectionDetail { get; set; }
        /// <summary>Gets or sets private link service proxy id.</summary>
        string Id { get; set; }
        /// <summary>
        /// Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> PrivateLinkServiceConnection { get; set; }
        /// <summary>Gets or sets the list of private link service proxies.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> PrivateLinkServiceProxy { get; set; }

    }
}