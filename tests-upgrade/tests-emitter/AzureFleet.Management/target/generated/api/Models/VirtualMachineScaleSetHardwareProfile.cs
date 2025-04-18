// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies the hardware settings for the virtual machine scale set.</summary>
    public partial class VirtualMachineScaleSetHardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetHardwareProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetHardwareProfileInternal
    {

        /// <summary>Internal Acessors for VMSizeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetHardwareProfileInternal.VMSizeProperty { get => (this._vMSizeProperty = this._vMSizeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMSizeProperties()); set { {_vMSizeProperty = value;} } }

        /// <summary>Backing field for <see cref="VMSizeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProperties _vMSizeProperty;

        /// <summary>
        /// Specifies the properties for customizing the size of the virtual machine.
        /// Minimum api-version: 2021-11-01. Please follow the instructions in [VM
        /// Customization](https://aka.ms/vmcustomization) for more details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProperties VMSizeProperty { get => (this._vMSizeProperty = this._vMSizeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMSizeProperties()); set => this._vMSizeProperty = value; }

        /// <summary>
        /// Specifies the number of vCPUs available for the VM. When this property is not
        /// specified in the request body the default behavior is to set it to the value of
        /// vCPUs available for that VM size exposed in api response of [List all available
        /// virtual machine sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? VMSizePropertyVcpUsAvailable { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizePropertiesInternal)VMSizeProperty).VCpUsAvailable; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizePropertiesInternal)VMSizeProperty).VCpUsAvailable = value ?? default(int); }

        /// <summary>
        /// Specifies the vCPU to physical core ratio. When this property is not specified
        /// in the request body the default behavior is set to the value of vCPUsPerCore
        /// for the VM Size exposed in api response of [List all available virtual machine
        /// sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// **Setting this property to 1 also means that hyper-threading is disabled.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? VMSizePropertyVcpUsPerCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizePropertiesInternal)VMSizeProperty).VCpUsPerCore; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizePropertiesInternal)VMSizeProperty).VCpUsPerCore = value ?? default(int); }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetHardwareProfile" /> instance.</summary>
        public VirtualMachineScaleSetHardwareProfile()
        {

        }
    }
    /// Specifies the hardware settings for the virtual machine scale set.
    public partial interface IVirtualMachineScaleSetHardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the number of vCPUs available for the VM. When this property is not
        /// specified in the request body the default behavior is to set it to the value of
        /// vCPUs available for that VM size exposed in api response of [List all available
        /// virtual machine sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the number of vCPUs available for the VM. When this property is not
        specified in the request body the default behavior is to set it to the value of
        vCPUs available for that VM size exposed in api response of [List all available
        virtual machine sizes in a
        region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).",
        SerializedName = @"vCPUsAvailable",
        PossibleTypes = new [] { typeof(int) })]
        int? VMSizePropertyVcpUsAvailable { get; set; }
        /// <summary>
        /// Specifies the vCPU to physical core ratio. When this property is not specified
        /// in the request body the default behavior is set to the value of vCPUsPerCore
        /// for the VM Size exposed in api response of [List all available virtual machine
        /// sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// **Setting this property to 1 also means that hyper-threading is disabled.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the vCPU to physical core ratio. When this property is not specified
        in the request body the default behavior is set to the value of vCPUsPerCore
        for the VM Size exposed in api response of [List all available virtual machine
        sizes in a
        region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        **Setting this property to 1 also means that hyper-threading is disabled.**",
        SerializedName = @"vCPUsPerCore",
        PossibleTypes = new [] { typeof(int) })]
        int? VMSizePropertyVcpUsPerCore { get; set; }

    }
    /// Specifies the hardware settings for the virtual machine scale set.
    internal partial interface IVirtualMachineScaleSetHardwareProfileInternal

    {
        /// <summary>
        /// Specifies the properties for customizing the size of the virtual machine.
        /// Minimum api-version: 2021-11-01. Please follow the instructions in [VM
        /// Customization](https://aka.ms/vmcustomization) for more details.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProperties VMSizeProperty { get; set; }
        /// <summary>
        /// Specifies the number of vCPUs available for the VM. When this property is not
        /// specified in the request body the default behavior is to set it to the value of
        /// vCPUs available for that VM size exposed in api response of [List all available
        /// virtual machine sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// </summary>
        int? VMSizePropertyVcpUsAvailable { get; set; }
        /// <summary>
        /// Specifies the vCPU to physical core ratio. When this property is not specified
        /// in the request body the default behavior is set to the value of vCPUsPerCore
        /// for the VM Size exposed in api response of [List all available virtual machine
        /// sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// **Setting this property to 1 also means that hyper-threading is disabled.**
        /// </summary>
        int? VMSizePropertyVcpUsPerCore { get; set; }

    }
}