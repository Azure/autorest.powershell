// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies VM Size Property settings on the virtual machine.</summary>
    public partial class VMSizeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizePropertiesInternal
    {

        /// <summary>Backing field for <see cref="VCpUsAvailable" /> property.</summary>
        private int? _vCpUsAvailable;

        /// <summary>
        /// Specifies the number of vCPUs available for the VM. When this property is not
        /// specified in the request body the default behavior is to set it to the value of
        /// vCPUs available for that VM size exposed in api response of [List all available
        /// virtual machine sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? VCpUsAvailable { get => this._vCpUsAvailable; set => this._vCpUsAvailable = value; }

        /// <summary>Backing field for <see cref="VCpUsPerCore" /> property.</summary>
        private int? _vCpUsPerCore;

        /// <summary>
        /// Specifies the vCPU to physical core ratio. When this property is not specified
        /// in the request body the default behavior is set to the value of vCPUsPerCore
        /// for the VM Size exposed in api response of [List all available virtual machine
        /// sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// **Setting this property to 1 also means that hyper-threading is disabled.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? VCpUsPerCore { get => this._vCpUsPerCore; set => this._vCpUsPerCore = value; }

        /// <summary>Creates an new <see cref="VMSizeProperties" /> instance.</summary>
        public VMSizeProperties()
        {

        }
    }
    /// Specifies VM Size Property settings on the virtual machine.
    public partial interface IVMSizeProperties :
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
        int? VCpUsAvailable { get; set; }
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
        int? VCpUsPerCore { get; set; }

    }
    /// Specifies VM Size Property settings on the virtual machine.
    internal partial interface IVMSizePropertiesInternal

    {
        /// <summary>
        /// Specifies the number of vCPUs available for the VM. When this property is not
        /// specified in the request body the default behavior is to set it to the value of
        /// vCPUs available for that VM size exposed in api response of [List all available
        /// virtual machine sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// </summary>
        int? VCpUsAvailable { get; set; }
        /// <summary>
        /// Specifies the vCPU to physical core ratio. When this property is not specified
        /// in the request body the default behavior is set to the value of vCPUsPerCore
        /// for the VM Size exposed in api response of [List all available virtual machine
        /// sizes in a
        /// region](https://learn.microsoft.com/en-us/rest/api/compute/resource-skus/list).
        /// **Setting this property to 1 also means that hyper-threading is disabled.**
        /// </summary>
        int? VCpUsPerCore { get; set; }

    }
}