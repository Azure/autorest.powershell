// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Defines the network configuration type for SAP system infrastructure that is being deployed
    /// </summary>
    public partial class NetworkConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkConfigurationInternal
    {

        /// <summary>Backing field for <see cref="IsSecondaryIPEnabled" /> property.</summary>
        private bool? _isSecondaryIPEnabled;

        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? IsSecondaryIPEnabled { get => this._isSecondaryIPEnabled; set => this._isSecondaryIPEnabled = value; }

        /// <summary>Creates an new <see cref="NetworkConfiguration" /> instance.</summary>
        public NetworkConfiguration()
        {

        }
    }
    /// Defines the network configuration type for SAP system infrastructure that is being deployed
    public partial interface INetworkConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed",
        SerializedName = @"isSecondaryIpEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSecondaryIPEnabled { get; set; }

    }
    /// Defines the network configuration type for SAP system infrastructure that is being deployed
    internal partial interface INetworkConfigurationInternal

    {
        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs of the SAP system being deployed
        /// </summary>
        bool? IsSecondaryIPEnabled { get; set; }

    }
}