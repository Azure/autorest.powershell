// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Extended Properties for Disk Exclusion.</summary>
    public partial class DiskExclusionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskLunList" /> property.</summary>
        private System.Collections.Generic.List<int> _diskLunList;

        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<int> DiskLunList { get => this._diskLunList; set => this._diskLunList = value; }

        /// <summary>Backing field for <see cref="IsInclusionList" /> property.</summary>
        private bool? _isInclusionList;

        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsInclusionList { get => this._isInclusionList; set => this._isInclusionList = value; }

        /// <summary>Creates an new <see cref="DiskExclusionProperties" /> instance.</summary>
        public DiskExclusionProperties()
        {

        }
    }
    /// Extended Properties for Disk Exclusion.
    public partial interface IDiskExclusionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.",
        SerializedName = @"diskLunList",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> DiskLunList { get; set; }
        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to indicate whether DiskLunList is to be included/ excluded from backup.",
        SerializedName = @"isInclusionList",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsInclusionList { get; set; }

    }
    /// Extended Properties for Disk Exclusion.
    internal partial interface IDiskExclusionPropertiesInternal

    {
        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        System.Collections.Generic.List<int> DiskLunList { get; set; }
        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        bool? IsInclusionList { get; set; }

    }
}