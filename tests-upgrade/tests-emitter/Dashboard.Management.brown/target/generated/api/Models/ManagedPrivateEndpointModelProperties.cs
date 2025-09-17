// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Properties specific to the managed private endpoint.</summary>
    public partial class ManagedPrivateEndpointModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState _connectionState;

        /// <summary>The state of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState ConnectionState { get => (this._connectionState = this._connectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointConnectionState()); }

        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Description; }

        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string ConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Status; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private System.Collections.Generic.List<string> _groupId;

        /// <summary>The group Ids of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Internal Acessors for ConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal.ConnectionState { get => (this._connectionState = this._connectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedPrivateEndpointConnectionState()); set { {_connectionState = value;} } }

        /// <summary>Internal Acessors for ConnectionStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal.ConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Description = value ?? null; }

        /// <summary>Internal Acessors for ConnectionStateStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal.ConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal)ConnectionState).Status = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServicePrivateIP</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal.PrivateLinkServicePrivateIP { get => this._privateLinkServicePrivateIP; set { {_privateLinkServicePrivateIP = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkResourceId" /> property.</summary>
        private string _privateLinkResourceId;

        /// <summary>
        /// The ARM resource ID of the resource for which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateLinkResourceId { get => this._privateLinkResourceId; set => this._privateLinkResourceId = value; }

        /// <summary>Backing field for <see cref="PrivateLinkResourceRegion" /> property.</summary>
        private string _privateLinkResourceRegion;

        /// <summary>
        /// The region of the resource to which the managed private endpoint is pointing to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateLinkResourceRegion { get => this._privateLinkResourceRegion; set => this._privateLinkResourceRegion = value; }

        /// <summary>Backing field for <see cref="PrivateLinkServicePrivateIP" /> property.</summary>
        private string _privateLinkServicePrivateIP;

        /// <summary>
        /// The private IP of private endpoint after approval. This property is empty before connection is approved.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateLinkServicePrivateIP { get => this._privateLinkServicePrivateIP; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceUrl" /> property.</summary>
        private string _privateLinkServiceUrl;

        /// <summary>
        /// The URL of the data store behind the private link service. It would be the URL in the Grafana data source configuration
        /// page without the protocol and port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string PrivateLinkServiceUrl { get => this._privateLinkServiceUrl; set => this._privateLinkServiceUrl = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RequestMessage" /> property.</summary>
        private string _requestMessage;

        /// <summary>User input request message of the managed private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string RequestMessage { get => this._requestMessage; set => this._requestMessage = value; }

        /// <summary>Creates an new <see cref="ManagedPrivateEndpointModelProperties" /> instance.</summary>
        public ManagedPrivateEndpointModelProperties()
        {

        }
    }
    /// Properties specific to the managed private endpoint.
    public partial interface IManagedPrivateEndpointModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
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
    /// Properties specific to the managed private endpoint.
    internal partial interface IManagedPrivateEndpointModelPropertiesInternal

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
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }
        /// <summary>User input request message of the managed private endpoint.</summary>
        string RequestMessage { get; set; }

    }
}