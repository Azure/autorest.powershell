// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Specifies the disk information fo the Azure Large Instance</summary>
    public partial class Disk :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDiskInternal
    {

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int? _lun;

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public int? Lun { get => this._lun; }

        /// <summary>Internal Acessors for Lun</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDiskInternal.Lun { get => this._lun; set { {_lun = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private int? _sizeGb;

        /// <summary>Specifies the size of an empty data disk in gigabytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public int? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Creates an new <see cref="Disk" /> instance.</summary>
        public Disk()
        {

        }
    }
    /// Specifies the disk information fo the Azure Large Instance
    public partial interface IDisk :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the logical unit number of the data disk. This value is used to
        identify data disks within the VM and therefore must be unique for each data
        disk attached to a VM.",
        SerializedName = @"lun",
        PossibleTypes = new [] { typeof(int) })]
        int? Lun { get;  }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Specifies the size of an empty data disk in gigabytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the size of an empty data disk in gigabytes.",
        SerializedName = @"diskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeGb { get; set; }

    }
    /// Specifies the disk information fo the Azure Large Instance
    internal partial interface IDiskInternal

    {
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        int? Lun { get; set; }
        /// <summary>The disk name.</summary>
        string Name { get; set; }
        /// <summary>Specifies the size of an empty data disk in gigabytes.</summary>
        int? SizeGb { get; set; }

    }
}