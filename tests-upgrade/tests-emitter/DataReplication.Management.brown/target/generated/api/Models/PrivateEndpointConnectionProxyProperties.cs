// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Represents private endpoint connection proxy request.</summary>
    public partial class PrivateEndpointConnectionProxyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionProxyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionProxyPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionProxyPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RemotePrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointConnectionProxyPropertiesInternal.RemotePrivateEndpoint { get => (this._remotePrivateEndpoint = this._remotePrivateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint()); set { {_remotePrivateEndpoint = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the private endpoint connection proxy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RemotePrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpoint _remotePrivateEndpoint;

        /// <summary>
        /// Represent remote private endpoint information for the private endpoint connection proxy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpoint RemotePrivateEndpoint { get => (this._remotePrivateEndpoint = this._remotePrivateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RemotePrivateEndpoint()); set => this._remotePrivateEndpoint = value; }

        /// <summary>
        /// Gets or sets the list of Connection Details. This is the connection details for private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> RemotePrivateEndpointConnectionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ConnectionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ConnectionDetail = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets private link service proxy id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string RemotePrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).Id = value ?? null; }

        /// <summary>
        /// Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointManualPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ManualPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).ManualPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>
        /// Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the list of private link service proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> RemotePrivateEndpointPrivateLinkServiceProxy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceProxy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpointInternal)RemotePrivateEndpoint).PrivateLinkServiceProxy = value ?? null /* arrayOf */; }

        /// <summary>
        /// Creates an new <see cref="PrivateEndpointConnectionProxyProperties" /> instance.
        /// </summary>
        public PrivateEndpointConnectionProxyProperties()
        {

        }
    }
    /// Represents private endpoint connection proxy request.
    public partial interface IPrivateEndpointConnectionProxyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the provisioning state of the private endpoint connection proxy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the private endpoint connection proxy.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> RemotePrivateEndpointConnectionDetail { get; set; }
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
        string RemotePrivateEndpointId { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointManualPrivateLinkServiceConnection { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointPrivateLinkServiceConnection { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> RemotePrivateEndpointPrivateLinkServiceProxy { get; set; }

    }
    /// Represents private endpoint connection proxy request.
    internal partial interface IPrivateEndpointConnectionProxyPropertiesInternal

    {
        /// <summary>Gets or sets the provisioning state of the private endpoint connection proxy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Represent remote private endpoint information for the private endpoint connection proxy.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRemotePrivateEndpoint RemotePrivateEndpoint { get; set; }
        /// <summary>
        /// Gets or sets the list of Connection Details. This is the connection details for private endpoint.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IConnectionDetails> RemotePrivateEndpointConnectionDetail { get; set; }
        /// <summary>Gets or sets private link service proxy id.</summary>
        string RemotePrivateEndpointId { get; set; }
        /// <summary>
        /// Gets or sets the list of Manual Private Link Service Connections and gets populated for Manual approval flow.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// Gets or sets the list of Private Link Service Connections and gets populated for Auto approval flow.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceConnection> RemotePrivateEndpointPrivateLinkServiceConnection { get; set; }
        /// <summary>Gets or sets the list of private link service proxies.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkServiceProxy> RemotePrivateEndpointPrivateLinkServiceProxy { get; set; }

    }
}