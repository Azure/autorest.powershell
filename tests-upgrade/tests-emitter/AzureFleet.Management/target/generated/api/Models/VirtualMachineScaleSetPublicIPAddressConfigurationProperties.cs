// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    /// </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeleteOption" /> property.</summary>
        private string _deleteOption;

        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DeleteOption { get => this._deleteOption; set => this._deleteOption = value; }

        /// <summary>Backing field for <see cref="DnsSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings _dnsSetting;

        /// <summary>The dns settings to be applied on the publicIP addresses .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSetting { get => (this._dnsSetting = this._dnsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()); set => this._dnsSetting = value; }

        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DnsSettingDomainNameLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal)DnsSetting).DomainNameLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal)DnsSetting).DomainNameLabel = value ?? null; }

        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DnsSettingDomainNameLabelScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal)DnsSetting).DomainNameLabelScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal)DnsSetting).DomainNameLabelScope = value ?? null; }

        /// <summary>Backing field for <see cref="IPTag" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> _iPTag;

        /// <summary>The list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get => this._iPTag; set => this._iPTag = value; }

        /// <summary>Backing field for <see cref="IdleTimeoutInMinute" /> property.</summary>
        private int? _idleTimeoutInMinute;

        /// <summary>The idle timeout of the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? IdleTimeoutInMinute { get => this._idleTimeoutInMinute; set => this._idleTimeoutInMinute = value; }

        /// <summary>Internal Acessors for DnsSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationPropertiesInternal.DnsSetting { get => (this._dnsSetting = this._dnsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()); set { {_dnsSetting = value;} } }

        /// <summary>Internal Acessors for PublicIPPrefix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationPropertiesInternal.PublicIPPrefix { get => (this._publicIPPrefix = this._publicIPPrefix ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set { {_publicIPPrefix = value;} } }

        /// <summary>Backing field for <see cref="PublicIPAddressVersion" /> property.</summary>
        private string _publicIPAddressVersion;

        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PublicIPAddressVersion { get => this._publicIPAddressVersion; set => this._publicIPAddressVersion = value; }

        /// <summary>Backing field for <see cref="PublicIPPrefix" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource _publicIPPrefix;

        /// <summary>The PublicIPPrefix from which to allocate publicIP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource PublicIPPrefix { get => (this._publicIPPrefix = this._publicIPPrefix ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set => this._publicIPPrefix = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PublicIPPrefixId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)PublicIPPrefix).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)PublicIPPrefix).Id = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationProperties" /> instance.
        /// </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationProperties()
        {

        }
    }
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    public partial interface IVirtualMachineScaleSetPublicIPAddressConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify what happens to the public IP when the VM is deleted",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Domain name label.The concatenation of the domain name label and vm index
        will be the domain name labels of the PublicIPAddress resources that will be
        created",
        SerializedName = @"domainNameLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DnsSettingDomainNameLabel { get; set; }
        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Domain name label scope.The concatenation of the hashed domain name label
        that generated according to the policy from domain name label scope and vm
        index will be the domain name labels of the PublicIPAddress resources that will
        be created",
        SerializedName = @"domainNameLabelScope",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string DnsSettingDomainNameLabelScope { get; set; }
        /// <summary>The list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of IP tags associated with the public IP address.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get; set; }
        /// <summary>The idle timeout of the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The idle timeout of the public IP address.",
        SerializedName = @"idleTimeoutInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? IdleTimeoutInMinute { get; set; }
        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Available from Api-Version 2019-07-01 onwards, it represents whether the
        specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        values are: 'IPv4' and 'IPv6'.",
        SerializedName = @"publicIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }
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
        string PublicIPPrefixId { get; set; }

    }
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    internal partial interface IVirtualMachineScaleSetPublicIPAddressConfigurationPropertiesInternal

    {
        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>The dns settings to be applied on the publicIP addresses .</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSetting { get; set; }
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        string DnsSettingDomainNameLabel { get; set; }
        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string DnsSettingDomainNameLabelScope { get; set; }
        /// <summary>The list of IP tags associated with the public IP address.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get; set; }
        /// <summary>The idle timeout of the public IP address.</summary>
        int? IdleTimeoutInMinute { get; set; }
        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }
        /// <summary>The PublicIPPrefix from which to allocate publicIP addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource PublicIPPrefix { get; set; }
        /// <summary>Resource Id</summary>
        string PublicIPPrefixId { get; set; }

    }
}