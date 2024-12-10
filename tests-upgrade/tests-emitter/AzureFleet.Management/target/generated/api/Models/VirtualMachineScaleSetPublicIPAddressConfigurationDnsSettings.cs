// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal
    {

        /// <summary>Backing field for <see cref="DomainNameLabel" /> property.</summary>
        private string _domainNameLabel;

        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DomainNameLabel { get => this._domainNameLabel; set => this._domainNameLabel = value; }

        /// <summary>Backing field for <see cref="DomainNameLabelScope" /> property.</summary>
        private string _domainNameLabelScope;

        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DomainNameLabelScope { get => this._domainNameLabelScope; set => this._domainNameLabelScope = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings" /> instance.
        /// </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()
        {

        }
    }
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    public partial interface IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Domain name label.The concatenation of the domain name label and vm index
        will be the domain name labels of the PublicIPAddress resources that will be
        created",
        SerializedName = @"domainNameLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DomainNameLabel { get; set; }
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
        string DomainNameLabelScope { get; set; }

    }
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    internal partial interface IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsInternal

    {
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        string DomainNameLabel { get; set; }
        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string DomainNameLabelScope { get; set; }

    }
}