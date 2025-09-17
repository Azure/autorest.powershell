// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Managed data disk description.</summary>
    public partial class VmssDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDiskInternal
    {

        /// <summary>Backing field for <see cref="DiskLetter" /> property.</summary>
        private string _diskLetter;

        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DiskLetter { get => this._diskLetter; set => this._diskLetter = value; }

        /// <summary>Backing field for <see cref="DiskSizeGb" /> property.</summary>
        private int _diskSizeGb;

        /// <summary>Disk size for each vm in the node type in GBs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int DiskSizeGb { get => this._diskSizeGb; set => this._diskSizeGb = value; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private string _diskType;

        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int _lun;

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore
        /// must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int Lun { get => this._lun; set => this._lun = value; }

        /// <summary>Creates an new <see cref="VmssDataDisk" /> instance.</summary>
        public VmssDataDisk()
        {

        }
    }
    /// Managed data disk description.
    public partial interface IVmssDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.",
        SerializedName = @"diskLetter",
        PossibleTypes = new [] { typeof(string) })]
        string DiskLetter { get; set; }
        /// <summary>Disk size for each vm in the node type in GBs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Disk size for each vm in the node type in GBs.",
        SerializedName = @"diskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int DiskSizeGb { get; set; }
        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed data disk type. Specifies the storage account type for the managed disk",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard_LRS", "StandardSSD_LRS", "Premium_LRS", "PremiumV2_LRS", "StandardSSD_ZRS", "Premium_ZRS")]
        string DiskType { get; set; }
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore
        /// must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk.",
        SerializedName = @"lun",
        PossibleTypes = new [] { typeof(int) })]
        int Lun { get; set; }

    }
    /// Managed data disk description.
    internal partial interface IVmssDataDiskInternal

    {
        /// <summary>
        /// Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
        /// </summary>
        string DiskLetter { get; set; }
        /// <summary>Disk size for each vm in the node type in GBs.</summary>
        int DiskSizeGb { get; set; }
        /// <summary>Managed data disk type. Specifies the storage account type for the managed disk</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Standard_LRS", "StandardSSD_LRS", "Premium_LRS", "PremiumV2_LRS", "StandardSSD_ZRS", "Premium_ZRS")]
        string DiskType { get; set; }
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore
        /// must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk.
        /// </summary>
        int Lun { get; set; }

    }
}