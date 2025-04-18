// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes the parameters of ephemeral disk settings that can be specified for
    /// operating system disk. **Note:** The ephemeral disk settings can only be
    /// specified for managed disk.
    /// </summary>
    public partial class DiffDiskSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettingsInternal
    {

        /// <summary>Backing field for <see cref="Option" /> property.</summary>
        private string _option;

        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Option { get => this._option; set => this._option = value; }

        /// <summary>Backing field for <see cref="Placement" /> property.</summary>
        private string _placement;

        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Placement { get => this._placement; set => this._placement = value; }

        /// <summary>Creates an new <see cref="DiffDiskSettings" /> instance.</summary>
        public DiffDiskSettings()
        {

        }
    }
    /// Describes the parameters of ephemeral disk settings that can be specified for
    /// operating system disk. **Note:** The ephemeral disk settings can only be
    /// specified for managed disk.
    public partial interface IDiffDiskSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ephemeral disk settings for operating system disk.",
        SerializedName = @"option",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Local")]
        string Option { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ephemeral disk placement for operating system disk. Possible
        values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        is used. Refer to the VM size documentation for Windows VM at
        https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        sizes exposes a cache disk.",
        SerializedName = @"placement",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("CacheDisk", "ResourceDisk", "NvmeDisk")]
        string Placement { get; set; }

    }
    /// Describes the parameters of ephemeral disk settings that can be specified for
    /// operating system disk. **Note:** The ephemeral disk settings can only be
    /// specified for managed disk.
    internal partial interface IDiffDiskSettingsInternal

    {
        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Local")]
        string Option { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("CacheDisk", "ResourceDisk", "NvmeDisk")]
        string Placement { get; set; }

    }
}