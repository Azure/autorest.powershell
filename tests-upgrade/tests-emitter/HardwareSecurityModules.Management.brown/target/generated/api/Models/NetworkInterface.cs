// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>The network interface definition.</summary>
    public partial class NetworkInterface :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterface,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterfaceInternal
    {

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.INetworkInterfaceInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>Private Ip address of the interface</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; set => this._privateIPAddress = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Creates an new <see cref="NetworkInterface" /> instance.</summary>
        public NetworkInterface()
        {

        }
    }
    /// The network interface definition.
    public partial interface INetworkInterface :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>Private Ip address of the interface</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private Ip address of the interface",
        SerializedName = @"privateIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }

    }
    /// The network interface definition.
    internal partial interface INetworkInterfaceInternal

    {
        /// <summary>Private Ip address of the interface</summary>
        string PrivateIPAddress { get; set; }
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string ResourceId { get; set; }

    }
}