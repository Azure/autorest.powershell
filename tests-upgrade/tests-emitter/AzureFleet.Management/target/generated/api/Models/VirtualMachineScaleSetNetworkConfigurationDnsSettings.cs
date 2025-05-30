// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    public partial class VirtualMachineScaleSetNetworkConfigurationDnsSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettingsInternal
    {

        /// <summary>Backing field for <see cref="DnsServer" /> property.</summary>
        private System.Collections.Generic.List<string> _dnsServer;

        /// <summary>List of DNS servers IP addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DnsServer { get => this._dnsServer; set => this._dnsServer = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetNetworkConfigurationDnsSettings" /> instance.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings()
        {

        }
    }
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    public partial interface IVirtualMachineScaleSetNetworkConfigurationDnsSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>List of DNS servers IP addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of DNS servers IP addresses",
        SerializedName = @"dnsServers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DnsServer { get; set; }

    }
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    internal partial interface IVirtualMachineScaleSetNetworkConfigurationDnsSettingsInternal

    {
        /// <summary>List of DNS servers IP addresses</summary>
        System.Collections.Generic.List<string> DnsServer { get; set; }

    }
}