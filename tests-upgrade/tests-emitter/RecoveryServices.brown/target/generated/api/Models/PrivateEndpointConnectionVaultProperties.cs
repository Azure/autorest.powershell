// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>
    /// Information to be stored in Vault properties as an element of privateEndpointConnections List.
    /// </summary>
    public partial class PrivateEndpointConnectionVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal
    {

        /// <summary>Group Ids for the Private Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).GroupId; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>
        /// Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the private Endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for GroupId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).GroupId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateEndpoint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateEndpointId = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionState = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateActionsRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnection()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the private Endpoint Connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Gets or sets id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateEndpointId; }

        /// <summary>Gets or sets actions required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; }

        /// <summary>Gets or sets description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateDescription; }

        /// <summary>Gets or sets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).PrivateLinkServiceConnectionStateStatus; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection _property;

        /// <summary>Private Endpoint Connection Response Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnection()); }

        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The type, which will be of the format, Microsoft.RecoveryServices/vaults/privateEndpointConnections
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>
        /// Creates an new <see cref="PrivateEndpointConnectionVaultProperties" /> instance.
        /// </summary>
        public PrivateEndpointConnectionVaultProperties()
        {

        }
    }
    /// Information to be stored in Vault properties as an element of privateEndpointConnections List.
    public partial interface IPrivateEndpointConnectionVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Group Ids for the Private Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Group Ids for the Private Endpoint",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("AzureBackup", "AzureBackup_secondary", "AzureSiteRecovery")]
        System.Collections.Generic.List<string> GroupId { get;  }
        /// <summary>
        /// Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The location of the private Endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The location of the private Endpoint connection",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>The name of the private Endpoint Connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the private Endpoint Connection",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Gets or sets id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get;  }
        /// <summary>Gets or sets actions required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets actions required.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get;  }
        /// <summary>Gets or sets description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get;  }
        /// <summary>Gets or sets the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string PrivateLinkServiceConnectionStateStatus { get;  }
        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets provisioning state of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Succeeded", "Deleting", "Failed", "Pending")]
        string ProvisioningState { get;  }
        /// <summary>
        /// The type, which will be of the format, Microsoft.RecoveryServices/vaults/privateEndpointConnections
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type, which will be of the format, Microsoft.RecoveryServices/vaults/privateEndpointConnections",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Information to be stored in Vault properties as an element of privateEndpointConnections List.
    internal partial interface IPrivateEndpointConnectionVaultPropertiesInternal

    {
        /// <summary>Group Ids for the Private Endpoint</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("AzureBackup", "AzureBackup_secondary", "AzureSiteRecovery")]
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>
        /// Format of id subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        /// </summary>
        string Id { get; set; }
        /// <summary>The location of the private Endpoint connection</summary>
        string Location { get; set; }
        /// <summary>The name of the private Endpoint Connection</summary>
        string Name { get; set; }
        /// <summary>
        /// The Private Endpoint network resource that is linked to the Private Endpoint connection.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>Gets or sets id.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Gets or sets private link service connection state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Gets or sets actions required.</summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>Gets or sets description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>Gets or sets the status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Private Endpoint Connection Response Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection Property { get; set; }
        /// <summary>Gets or sets provisioning state of the private endpoint connection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Succeeded", "Deleting", "Failed", "Pending")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The type, which will be of the format, Microsoft.RecoveryServices/vaults/privateEndpointConnections
        /// </summary>
        string Type { get; set; }

    }
}