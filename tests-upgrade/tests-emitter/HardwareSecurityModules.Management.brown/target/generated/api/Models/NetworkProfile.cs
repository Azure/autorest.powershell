// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>The network profile definition.</summary>
    public partial class NetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal
    {

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkProfileInternal.Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReference()); set { {_subnet = value;} } }

        /// <summary>Backing field for <see cref="NetworkInterface" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> _networkInterface;

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkInterface { get => this._networkInterface; set => this._networkInterface = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference _subnet;

        /// <summary>Specifies the identifier of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.ApiEntityReference()); set => this._subnet = value; }

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string SubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReferenceInternal)Subnet).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReferenceInternal)Subnet).ResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="NetworkProfile" /> instance.</summary>
        public NetworkProfile()
        {

        }
    }
    /// The network profile definition.
    public partial interface INetworkProfile :
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkInterface { get; set; }
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
        string SubnetResourceId { get; set; }

    }
    /// The network profile definition.
    internal partial interface INetworkProfileInternal

    {
        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the dedicated HSM.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface> NetworkInterface { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference Subnet { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string SubnetResourceId { get; set; }

    }
}