// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The disk configuration required for the selected volume.</summary>
    public partial class DiskVolumeConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private long? _count;

        /// <summary>The total number of disks required for the concerned volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? Count { get => this._count; set => this._count = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private long? _sizeGb;

        /// <summary>The disk size in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku _sku;

        /// <summary>The disk SKU details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSku()); set => this._sku = value; }

        /// <summary>Defines the disk sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Creates an new <see cref="DiskVolumeConfiguration" /> instance.</summary>
        public DiskVolumeConfiguration()
        {

        }
    }
    /// The disk configuration required for the selected volume.
    public partial interface IDiskVolumeConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The total number of disks required for the concerned volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The total number of disks required for the concerned volume.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? Count { get; set; }
        /// <summary>The disk size in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk size in GB.",
        SerializedName = @"sizeGB",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeGb { get; set; }
        /// <summary>Defines the disk sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the disk sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string SkuName { get; set; }

    }
    /// The disk configuration required for the selected volume.
    internal partial interface IDiskVolumeConfigurationInternal

    {
        /// <summary>The total number of disks required for the concerned volume.</summary>
        long? Count { get; set; }
        /// <summary>The disk size in GB.</summary>
        long? SizeGb { get; set; }
        /// <summary>The disk SKU details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Sku { get; set; }
        /// <summary>Defines the disk sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string SkuName { get; set; }

    }
}