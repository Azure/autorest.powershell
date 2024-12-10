// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set network profile's IP configuration.</summary>
    public partial class VirtualMachineScaleSetNetworkConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AuxiliaryMode" /> property.</summary>
        private string _auxiliaryMode;

        /// <summary>
        /// Specifies whether the Auxiliary mode is enabled for the Network Interface
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AuxiliaryMode { get => this._auxiliaryMode; set => this._auxiliaryMode = value; }

        /// <summary>Backing field for <see cref="AuxiliarySku" /> property.</summary>
        private string _auxiliarySku;

        /// <summary>
        /// Specifies whether the Auxiliary sku is enabled for the Network Interface
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AuxiliarySku { get => this._auxiliarySku; set => this._auxiliarySku = value; }

        /// <summary>Backing field for <see cref="DeleteOption" /> property.</summary>
        private string _deleteOption;

        /// <summary>Specify what happens to the network interface when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DeleteOption { get => this._deleteOption; set => this._deleteOption = value; }

        /// <summary>Backing field for <see cref="DisableTcpStateTracking" /> property.</summary>
        private bool? _disableTcpStateTracking;

        /// <summary>Specifies whether the network interface is disabled for tcp state tracking.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? DisableTcpStateTracking { get => this._disableTcpStateTracking; set => this._disableTcpStateTracking = value; }

        /// <summary>Backing field for <see cref="DnsSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettings _dnsSetting;

        /// <summary>The dns settings to be applied on the network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSetting { get => (this._dnsSetting = this._dnsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetNetworkConfigurationDnsSettings()); set => this._dnsSetting = value; }

        /// <summary>List of DNS servers IP addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DnsSettingDnsServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettingsInternal)DnsSetting).DnsServer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettingsInternal)DnsSetting).DnsServer = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="EnableAcceleratedNetworking" /> property.</summary>
        private bool? _enableAcceleratedNetworking;

        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworking { get => this._enableAcceleratedNetworking; set => this._enableAcceleratedNetworking = value; }

        /// <summary>Backing field for <see cref="EnableFpga" /> property.</summary>
        private bool? _enableFpga;

        /// <summary>Specifies whether the network interface is FPGA networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableFpga { get => this._enableFpga; set => this._enableFpga = value; }

        /// <summary>Backing field for <see cref="EnableIPForwarding" /> property.</summary>
        private bool? _enableIPForwarding;

        /// <summary>Whether IP forwarding enabled on this NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableIPForwarding { get => this._enableIPForwarding; set => this._enableIPForwarding = value; }

        /// <summary>Backing field for <see cref="IPConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfiguration> _iPConfiguration;

        /// <summary>Specifies the IP configurations of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfiguration> IPConfiguration { get => this._iPConfiguration; set => this._iPConfiguration = value; }

        /// <summary>Internal Acessors for DnsSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationPropertiesInternal.DnsSetting { get => (this._dnsSetting = this._dnsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetNetworkConfigurationDnsSettings()); set { {_dnsSetting = value;} } }

        /// <summary>Internal Acessors for NetworkSecurityGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationPropertiesInternal.NetworkSecurityGroup { get => (this._networkSecurityGroup = this._networkSecurityGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set { {_networkSecurityGroup = value;} } }

        /// <summary>Backing field for <see cref="NetworkSecurityGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource _networkSecurityGroup;

        /// <summary>The network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource NetworkSecurityGroup { get => (this._networkSecurityGroup = this._networkSecurityGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set => this._networkSecurityGroup = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string NetworkSecurityGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)NetworkSecurityGroup).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)NetworkSecurityGroup).Id = value ?? null; }

        /// <summary>Backing field for <see cref="Primary" /> property.</summary>
        private bool? _primary;

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Primary { get => this._primary; set => this._primary = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetNetworkConfigurationProperties" /> instance.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfigurationProperties()
        {

        }
    }
    /// Describes a virtual machine scale set network profile's IP configuration.
    public partial interface IVirtualMachineScaleSetNetworkConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether the Auxiliary mode is enabled for the Network Interface
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the Auxiliary mode is enabled for the Network Interface
        resource.",
        SerializedName = @"auxiliaryMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "AcceleratedConnections", "Floating")]
        string AuxiliaryMode { get; set; }
        /// <summary>
        /// Specifies whether the Auxiliary sku is enabled for the Network Interface
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the Auxiliary sku is enabled for the Network Interface
        resource.",
        SerializedName = @"auxiliarySku",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "A1", "A2", "A4", "A8")]
        string AuxiliarySku { get; set; }
        /// <summary>Specify what happens to the network interface when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify what happens to the network interface when the VM is deleted",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>Specifies whether the network interface is disabled for tcp state tracking.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the network interface is disabled for tcp state tracking.",
        SerializedName = @"disableTcpStateTracking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableTcpStateTracking { get; set; }
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
        System.Collections.Generic.List<string> DnsSettingDnsServer { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the network interface is accelerated networking-enabled.",
        SerializedName = @"enableAcceleratedNetworking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>Specifies whether the network interface is FPGA networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the network interface is FPGA networking-enabled.",
        SerializedName = @"enableFpga",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableFpga { get; set; }
        /// <summary>Whether IP forwarding enabled on this NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether IP forwarding enabled on this NIC.",
        SerializedName = @"enableIPForwarding",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableIPForwarding { get; set; }
        /// <summary>Specifies the IP configurations of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the IP configurations of the network interface.",
        SerializedName = @"ipConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfiguration> IPConfiguration { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityGroupId { get; set; }
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the primary network interface in case the virtual machine has more
        than 1 network interface.",
        SerializedName = @"primary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Primary { get; set; }

    }
    /// Describes a virtual machine scale set network profile's IP configuration.
    internal partial interface IVirtualMachineScaleSetNetworkConfigurationPropertiesInternal

    {
        /// <summary>
        /// Specifies whether the Auxiliary mode is enabled for the Network Interface
        /// resource.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "AcceleratedConnections", "Floating")]
        string AuxiliaryMode { get; set; }
        /// <summary>
        /// Specifies whether the Auxiliary sku is enabled for the Network Interface
        /// resource.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "A1", "A2", "A4", "A8")]
        string AuxiliarySku { get; set; }
        /// <summary>Specify what happens to the network interface when the VM is deleted</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>Specifies whether the network interface is disabled for tcp state tracking.</summary>
        bool? DisableTcpStateTracking { get; set; }
        /// <summary>The dns settings to be applied on the network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSetting { get; set; }
        /// <summary>List of DNS servers IP addresses</summary>
        System.Collections.Generic.List<string> DnsSettingDnsServer { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>Specifies whether the network interface is FPGA networking-enabled.</summary>
        bool? EnableFpga { get; set; }
        /// <summary>Whether IP forwarding enabled on this NIC.</summary>
        bool? EnableIPForwarding { get; set; }
        /// <summary>Specifies the IP configurations of the network interface.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfiguration> IPConfiguration { get; set; }
        /// <summary>The network security group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource NetworkSecurityGroup { get; set; }
        /// <summary>Resource Id</summary>
        string NetworkSecurityGroupId { get; set; }
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        bool? Primary { get; set; }

    }
}