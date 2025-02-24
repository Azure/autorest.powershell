// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Compute Profile to use for running user's workloads.</summary>
    public partial class ComputeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfileInternal
    {

        /// <summary>Backing field for <see cref="AdditionalVirtualMachineCapability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilities _additionalVirtualMachineCapability;

        /// <summary>
        /// Specifies VMSS and VM API entity models support two additional capabilities as of today: ultraSSDEnabled and hibernationEnabled.
        /// ultraSSDEnabled: Enables UltraSSD_LRS storage account type on the VMSS VMs.
        /// hibernationEnabled: Enables the hibernation capability on the VMSS VMs.
        /// Default value is null if not specified. This property cannot be updated once set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilities AdditionalVirtualMachineCapability { get => (this._additionalVirtualMachineCapability = this._additionalVirtualMachineCapability ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalCapabilities()); set => this._additionalVirtualMachineCapability = value; }

        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AdditionalVirtualMachineCapabilityHibernationEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilitiesInternal)AdditionalVirtualMachineCapability).HibernationEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilitiesInternal)AdditionalVirtualMachineCapability).HibernationEnabled = value ?? default(bool); }

        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AdditionalVirtualMachineCapabilityUltraSsdEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilitiesInternal)AdditionalVirtualMachineCapability).UltraSsdEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilitiesInternal)AdditionalVirtualMachineCapability).UltraSsdEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="BaseVirtualMachineProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile _baseVirtualMachineProfile;

        /// <summary>
        /// Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile BaseVirtualMachineProfile { get => (this._baseVirtualMachineProfile = this._baseVirtualMachineProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.BaseVirtualMachineProfile()); set => this._baseVirtualMachineProfile = value; }

        /// <summary>Backing field for <see cref="ComputeApiVersion" /> property.</summary>
        private string _computeApiVersion;

        /// <summary>
        /// Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.
        /// The default value will be the latest supported computeApiVersion by Compute Fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ComputeApiVersion { get => this._computeApiVersion; set => this._computeApiVersion = value; }

        /// <summary>Internal Acessors for AdditionalVirtualMachineCapability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilities Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfileInternal.AdditionalVirtualMachineCapability { get => (this._additionalVirtualMachineCapability = this._additionalVirtualMachineCapability ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalCapabilities()); set { {_additionalVirtualMachineCapability = value;} } }

        /// <summary>Backing field for <see cref="PlatformFaultDomainCount" /> property.</summary>
        private int? _platformFaultDomainCount;

        /// <summary>
        /// Specifies the number of fault domains to use when creating the underlying VMSS.
        /// A fault domain is a logical group of hardware within an Azure datacenter.
        /// VMs in the same fault domain share a common power source and network switch.
        /// If not specified, defaults to 1, which represents "Max Spreading" (using as many fault domains as possible).
        /// This property cannot be updated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? PlatformFaultDomainCount { get => this._platformFaultDomainCount; set => this._platformFaultDomainCount = value; }

        /// <summary>Creates an new <see cref="ComputeProfile" /> instance.</summary>
        public ComputeProfile()
        {

        }
    }
    /// Compute Profile to use for running user's workloads.
    public partial interface IComputeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The flag that enables or disables hibernation capability on the VM.",
        SerializedName = @"hibernationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AdditionalVirtualMachineCapabilityHibernationEnabled { get; set; }
        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.
        Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.",
        SerializedName = @"ultraSSDEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AdditionalVirtualMachineCapabilityUltraSsdEnabled { get; set; }
        /// <summary>
        /// Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Base Virtual Machine Profile Properties to be specified according to ""specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile""",
        SerializedName = @"baseVirtualMachineProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile BaseVirtualMachineProfile { get; set; }
        /// <summary>
        /// Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.
        /// The default value will be the latest supported computeApiVersion by Compute Fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.
        The default value will be the latest supported computeApiVersion by Compute Fleet.",
        SerializedName = @"computeApiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeApiVersion { get; set; }
        /// <summary>
        /// Specifies the number of fault domains to use when creating the underlying VMSS.
        /// A fault domain is a logical group of hardware within an Azure datacenter.
        /// VMs in the same fault domain share a common power source and network switch.
        /// If not specified, defaults to 1, which represents "Max Spreading" (using as many fault domains as possible).
        /// This property cannot be updated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the number of fault domains to use when creating the underlying VMSS.
        A fault domain is a logical group of hardware within an Azure datacenter.
        VMs in the same fault domain share a common power source and network switch.
        If not specified, defaults to 1, which represents ""Max Spreading"" (using as many fault domains as possible).
        This property cannot be updated.",
        SerializedName = @"platformFaultDomainCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PlatformFaultDomainCount { get; set; }

    }
    /// Compute Profile to use for running user's workloads.
    internal partial interface IComputeProfileInternal

    {
        /// <summary>
        /// Specifies VMSS and VM API entity models support two additional capabilities as of today: ultraSSDEnabled and hibernationEnabled.
        /// ultraSSDEnabled: Enables UltraSSD_LRS storage account type on the VMSS VMs.
        /// hibernationEnabled: Enables the hibernation capability on the VMSS VMs.
        /// Default value is null if not specified. This property cannot be updated once set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilities AdditionalVirtualMachineCapability { get; set; }
        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        bool? AdditionalVirtualMachineCapabilityHibernationEnabled { get; set; }
        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        bool? AdditionalVirtualMachineCapabilityUltraSsdEnabled { get; set; }
        /// <summary>
        /// Base Virtual Machine Profile Properties to be specified according to "specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/{computeApiVersion}/virtualMachineScaleSet.json#/definitions/VirtualMachineScaleSetVMProfile"
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile BaseVirtualMachineProfile { get; set; }
        /// <summary>
        /// Specifies the Microsoft.Compute API version to use when creating underlying Virtual Machine scale sets and Virtual Machines.
        /// The default value will be the latest supported computeApiVersion by Compute Fleet.
        /// </summary>
        string ComputeApiVersion { get; set; }
        /// <summary>
        /// Specifies the number of fault domains to use when creating the underlying VMSS.
        /// A fault domain is a logical group of hardware within an Azure datacenter.
        /// VMs in the same fault domain share a common power source and network switch.
        /// If not specified, defaults to 1, which represents "Max Spreading" (using as many fault domains as possible).
        /// This property cannot be updated.
        /// </summary>
        int? PlatformFaultDomainCount { get; set; }

    }
}