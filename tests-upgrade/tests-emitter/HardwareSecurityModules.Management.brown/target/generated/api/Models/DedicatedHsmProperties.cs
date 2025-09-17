// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Properties of the dedicated hsm</summary>
    public partial class DedicatedHsmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ManagementNetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile _managementNetworkProfile;

        /// <summary>Specifies the management network interfaces of the dedicated hsm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile ManagementNetworkProfile { get => (this._managementNetworkProfile = this._managementNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfile()); set => this._managementNetworkProfile = value; }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).NetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string ManagementNetworkProfileSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).SubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).SubnetResourceId = value ?? null; }

        /// <summary>Internal Acessors for ManagementNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.ManagementNetworkProfile { get => (this._managementNetworkProfile = this._managementNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfile()); set { {_managementNetworkProfile = value;} } }

        /// <summary>Internal Acessors for ManagementNetworkProfileSubnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.ManagementNetworkProfileSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)ManagementNetworkProfile).Subnet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfile()); set { {_networkProfile = value;} } }

        /// <summary>Internal Acessors for NetworkProfileSubnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.NetworkProfileSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).Subnet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IDedicatedHsmPropertiesInternal.StatusMessage { get => this._statusMessage; set { {_statusMessage = value;} } }

        /// <summary>Backing field for <see cref="NetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile _networkProfile;

        /// <summary>Specifies the network interfaces of the dedicated hsm.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.NetworkProfile()); set => this._networkProfile = value; }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).NetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string NetworkProfileSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).SubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal)NetworkProfile).SubnetResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="StampId" /> property.</summary>
        private string _stampId;

        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string StampId { get => this._stampId; set => this._stampId = value; }

        /// <summary>Backing field for <see cref="StatusMessage" /> property.</summary>
        private string _statusMessage;

        /// <summary>Resource Status Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string StatusMessage { get => this._statusMessage; }

        /// <summary>Creates an new <see cref="DedicatedHsmProperties" /> instance.</summary>
        public DedicatedHsmProperties()
        {

        }
    }
    /// Properties of the dedicated hsm
    public partial interface IDedicatedHsmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementNetworkProfileSubnetResourceId { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileSubnetResourceId { get; set; }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("Succeeded", "Provisioning", "Allocating", "Connecting", "Failed", "CheckingQuota", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This field will be used when RP does not support Availability zones.",
        SerializedName = @"stampId",
        PossibleTypes = new [] { typeof(string) })]
        string StampId { get; set; }
        /// <summary>Resource Status Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Status Message.",
        SerializedName = @"statusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get;  }

    }
    /// Properties of the dedicated hsm
    internal partial interface IDedicatedHsmPropertiesInternal

    {
        /// <summary>Specifies the management network interfaces of the dedicated hsm.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile ManagementNetworkProfile { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> ManagementNetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference ManagementNetworkProfileSubnet { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string ManagementNetworkProfileSubnetResourceId { get; set; }
        /// <summary>Specifies the network interfaces of the dedicated hsm.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile NetworkProfile { get; set; }
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference NetworkProfileSubnet { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string NetworkProfileSubnetResourceId { get; set; }
        /// <summary>Provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("Succeeded", "Provisioning", "Allocating", "Connecting", "Failed", "CheckingQuota", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>This field will be used when RP does not support Availability zones.</summary>
        string StampId { get; set; }
        /// <summary>Resource Status Message.</summary>
        string StatusMessage { get; set; }

    }
}