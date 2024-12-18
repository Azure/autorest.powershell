// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The data disk of the VMSS.</summary>
    public partial class DataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDiskInternal
    {

        /// <summary>Backing field for <see cref="Caching" /> property.</summary>
        private string _caching;

        /// <summary>
        /// The type of caching to be enabled for the data disks. The default value for caching is readwrite. For information about
        /// the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Caching { get => this._caching; set => this._caching = value; }

        /// <summary>Backing field for <see cref="DiskSizeGiB" /> property.</summary>
        private int? _diskSizeGiB;

        /// <summary>The initial disk size in gigabytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public int? DiskSizeGiB { get => this._diskSizeGiB; set => this._diskSizeGiB = value; }

        /// <summary>Backing field for <see cref="DriveLetter" /> property.</summary>
        private string _driveLetter;

        /// <summary>
        /// The drive letter for the empty data disk. If not specified, it will be the first available letter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string DriveLetter { get => this._driveLetter; set => this._driveLetter = value; }

        /// <summary>Backing field for <see cref="StorageAccountType" /> property.</summary>
        private string _storageAccountType;

        /// <summary>
        /// The storage Account type to be used for the data disk. If omitted, the default is "standard_lrs".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string StorageAccountType { get => this._storageAccountType; set => this._storageAccountType = value; }

        /// <summary>Creates an new <see cref="DataDisk" /> instance.</summary>
        public DataDisk()
        {

        }
    }
    /// The data disk of the VMSS.
    public partial interface IDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The type of caching to be enabled for the data disks. The default value for caching is readwrite. For information about
        /// the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of caching to be enabled for the data disks. The default value for caching is readwrite. For information about the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.",
        SerializedName = @"caching",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string Caching { get; set; }
        /// <summary>The initial disk size in gigabytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The initial disk size in gigabytes.",
        SerializedName = @"diskSizeGiB",
        PossibleTypes = new [] { typeof(int) })]
        int? DiskSizeGiB { get; set; }
        /// <summary>
        /// The drive letter for the empty data disk. If not specified, it will be the first available letter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The drive letter for the empty data disk. If not specified, it will be the first available letter.",
        SerializedName = @"driveLetter",
        PossibleTypes = new [] { typeof(string) })]
        string DriveLetter { get; set; }
        /// <summary>
        /// The storage Account type to be used for the data disk. If omitted, the default is "standard_lrs".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The storage Account type to be used for the data disk. If omitted, the default is ""standard_lrs"".",
        SerializedName = @"storageAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS")]
        string StorageAccountType { get; set; }

    }
    /// The data disk of the VMSS.
    internal partial interface IDataDiskInternal

    {
        /// <summary>
        /// The type of caching to be enabled for the data disks. The default value for caching is readwrite. For information about
        /// the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string Caching { get; set; }
        /// <summary>The initial disk size in gigabytes.</summary>
        int? DiskSizeGiB { get; set; }
        /// <summary>
        /// The drive letter for the empty data disk. If not specified, it will be the first available letter.
        /// </summary>
        string DriveLetter { get; set; }
        /// <summary>
        /// The storage Account type to be used for the data disk. If omitted, the default is "standard_lrs".
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS")]
        string StorageAccountType { get; set; }

    }
}