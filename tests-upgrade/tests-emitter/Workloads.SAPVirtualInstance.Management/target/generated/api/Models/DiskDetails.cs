// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The supported disk size details for a disk type.</summary>
    public partial class DiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskTier" /> property.</summary>
        private string _diskTier;

        /// <summary>The disk tier, e.g. P10, E10.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DiskTier { get => this._diskTier; set => this._diskTier = value; }

        /// <summary>Backing field for <see cref="IopsReadWrite" /> property.</summary>
        private long? _iopsReadWrite;

        /// <summary>The disk Iops.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? IopsReadWrite { get => this._iopsReadWrite; set => this._iopsReadWrite = value; }

        /// <summary>Backing field for <see cref="MaximumSupportedDiskCount" /> property.</summary>
        private long? _maximumSupportedDiskCount;

        /// <summary>The maximum supported disk count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? MaximumSupportedDiskCount { get => this._maximumSupportedDiskCount; set => this._maximumSupportedDiskCount = value; }

        /// <summary>Backing field for <see cref="MbpsReadWrite" /> property.</summary>
        private long? _mbpsReadWrite;

        /// <summary>The disk provisioned throughput in MBps.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? MbpsReadWrite { get => this._mbpsReadWrite; set => this._mbpsReadWrite = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="MinimumSupportedDiskCount" /> property.</summary>
        private long? _minimumSupportedDiskCount;

        /// <summary>The minimum supported disk count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? MinimumSupportedDiskCount { get => this._minimumSupportedDiskCount; set => this._minimumSupportedDiskCount = value; }

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private long? _sizeGb;

        /// <summary>The disk size in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku _sku;

        /// <summary>
        /// The type of disk sku. For example, Standard_LRS, Standard_ZRS, Premium_LRS, Premium_ZRS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSku()); set => this._sku = value; }

        /// <summary>Defines the disk sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Creates an new <see cref="DiskDetails" /> instance.</summary>
        public DiskDetails()
        {

        }
    }
    /// The supported disk size details for a disk type.
    public partial interface IDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The disk tier, e.g. P10, E10.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk tier, e.g. P10, E10.",
        SerializedName = @"diskTier",
        PossibleTypes = new [] { typeof(string) })]
        string DiskTier { get; set; }
        /// <summary>The disk Iops.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk Iops.",
        SerializedName = @"iopsReadWrite",
        PossibleTypes = new [] { typeof(long) })]
        long? IopsReadWrite { get; set; }
        /// <summary>The maximum supported disk count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum supported disk count.",
        SerializedName = @"maximumSupportedDiskCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MaximumSupportedDiskCount { get; set; }
        /// <summary>The disk provisioned throughput in MBps.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk provisioned throughput in MBps.",
        SerializedName = @"mbpsReadWrite",
        PossibleTypes = new [] { typeof(long) })]
        long? MbpsReadWrite { get; set; }
        /// <summary>The minimum supported disk count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The minimum supported disk count.",
        SerializedName = @"minimumSupportedDiskCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MinimumSupportedDiskCount { get; set; }
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
    /// The supported disk size details for a disk type.
    internal partial interface IDiskDetailsInternal

    {
        /// <summary>The disk tier, e.g. P10, E10.</summary>
        string DiskTier { get; set; }
        /// <summary>The disk Iops.</summary>
        long? IopsReadWrite { get; set; }
        /// <summary>The maximum supported disk count.</summary>
        long? MaximumSupportedDiskCount { get; set; }
        /// <summary>The disk provisioned throughput in MBps.</summary>
        long? MbpsReadWrite { get; set; }
        /// <summary>The minimum supported disk count.</summary>
        long? MinimumSupportedDiskCount { get; set; }
        /// <summary>The disk size in GB.</summary>
        long? SizeGb { get; set; }
        /// <summary>
        /// The type of disk sku. For example, Standard_LRS, Standard_ZRS, Premium_LRS, Premium_ZRS.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Sku { get; set; }
        /// <summary>Defines the disk sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string SkuName { get; set; }

    }
}