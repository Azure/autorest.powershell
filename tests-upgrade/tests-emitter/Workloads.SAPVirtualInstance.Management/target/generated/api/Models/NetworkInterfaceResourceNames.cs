// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The resource names object for network interface and related resources.</summary>
    public partial class NetworkInterfaceResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="NetworkInterfaceName" /> property.</summary>
        private string _networkInterfaceName;

        /// <summary>
        /// The full name for network interface. If name is not provided, service uses a default name based on the deployment type.
        /// For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic
        /// with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default
        /// name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string NetworkInterfaceName { get => this._networkInterfaceName; set => this._networkInterfaceName = value; }

        /// <summary>Creates an new <see cref="NetworkInterfaceResourceNames" /> instance.</summary>
        public NetworkInterfaceResourceNames()
        {

        }
    }
    /// The resource names object for network interface and related resources.
    public partial interface INetworkInterfaceResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full name for network interface. If name is not provided, service uses a default name based on the deployment type.
        /// For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic
        /// with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default
        /// name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for network interface. If name is not provided, service uses a default name based on the deployment type. For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer.",
        SerializedName = @"networkInterfaceName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceName { get; set; }

    }
    /// The resource names object for network interface and related resources.
    internal partial interface INetworkInterfaceResourceNamesInternal

    {
        /// <summary>
        /// The full name for network interface. If name is not provided, service uses a default name based on the deployment type.
        /// For SingleServer, default name is {SID}-Nic. In case of HA-AvZone systems, default name will be {SID}-{App/ASCS/DB}-Zone{A/B}-Nic
        /// with an incrementor at the end in case of more than 1 instance per layer. For distributed and HA-AvSet systems, default
        /// name will be {SID}-{App/ASCS/DB}-Nic with an incrementor at the end in case of more than 1 instance per layer.
        /// </summary>
        string NetworkInterfaceName { get; set; }

    }
}