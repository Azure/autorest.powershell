// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The SAP Disk Configuration contains 'recommended disk' details and list of supported disks detail for a volume type.
    /// </summary>
    public partial class SapDiskConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationInternal
    {

        /// <summary>Internal Acessors for RecommendedConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationInternal.RecommendedConfiguration { get => (this._recommendedConfiguration = this._recommendedConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfiguration()); set { {_recommendedConfiguration = value;} } }

        /// <summary>Internal Acessors for RecommendedConfigurationSku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationInternal.RecommendedConfigurationSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).Sku = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="RecommendedConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration _recommendedConfiguration;

        /// <summary>The recommended disk details for a given VM Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration RecommendedConfiguration { get => (this._recommendedConfiguration = this._recommendedConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfiguration()); set => this._recommendedConfiguration = value; }

        /// <summary>The total number of disks required for the concerned volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? RecommendedConfigurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).Count; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).Count = value ?? default(long); }

        /// <summary>The disk size in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public long? RecommendedConfigurationSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).SizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).SizeGb = value ?? default(long); }

        /// <summary>Defines the disk sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfigurationInternal)RecommendedConfiguration).SkuName = value ?? null; }

        /// <summary>Backing field for <see cref="SupportedConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails> _supportedConfiguration;

        /// <summary>The list of supported disks for a given VM Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails> SupportedConfiguration { get => this._supportedConfiguration; set => this._supportedConfiguration = value; }

        /// <summary>Creates an new <see cref="SapDiskConfiguration" /> instance.</summary>
        public SapDiskConfiguration()
        {

        }
    }
    /// The SAP Disk Configuration contains 'recommended disk' details and list of supported disks detail for a volume type.
    public partial interface ISapDiskConfiguration :
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
        long? RecommendedConfigurationCount { get; set; }
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
        long? RecommendedConfigurationSizeGb { get; set; }
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
        /// <summary>The list of supported disks for a given VM Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of supported disks for a given VM Sku.",
        SerializedName = @"supportedConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails> SupportedConfiguration { get; set; }

    }
    /// The SAP Disk Configuration contains 'recommended disk' details and list of supported disks detail for a volume type.
    internal partial interface ISapDiskConfigurationInternal

    {
        /// <summary>The recommended disk details for a given VM Sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration RecommendedConfiguration { get; set; }
        /// <summary>The total number of disks required for the concerned volume.</summary>
        long? RecommendedConfigurationCount { get; set; }
        /// <summary>The disk size in GB.</summary>
        long? RecommendedConfigurationSizeGb { get; set; }
        /// <summary>The disk SKU details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku RecommendedConfigurationSku { get; set; }
        /// <summary>Defines the disk sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string SkuName { get; set; }
        /// <summary>The list of supported disks for a given VM Sku.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails> SupportedConfiguration { get; set; }

    }
}