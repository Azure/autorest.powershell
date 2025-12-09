// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Extended Properties for Azure IaasVM Backup.</summary>
    public partial class ExtendedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskExclusionProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties _diskExclusionProperty;

        /// <summary>Extended Properties for Disk Exclusion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties DiskExclusionProperty { get => (this._diskExclusionProperty = this._diskExclusionProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskExclusionProperties()); set => this._diskExclusionProperty = value; }

        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<int> DiskExclusionPropertyDiskLunList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionPropertiesInternal)DiskExclusionProperty).DiskLunList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionPropertiesInternal)DiskExclusionProperty).DiskLunList = value ?? null /* arrayOf */; }

        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? DiskExclusionPropertyIsInclusionList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionPropertiesInternal)DiskExclusionProperty).IsInclusionList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionPropertiesInternal)DiskExclusionProperty).IsInclusionList = value ?? default(bool); }

        /// <summary>Backing field for <see cref="LinuxVMApplicationName" /> property.</summary>
        private string _linuxVMApplicationName;

        /// <summary>Linux VM name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string LinuxVMApplicationName { get => this._linuxVMApplicationName; set => this._linuxVMApplicationName = value; }

        /// <summary>Internal Acessors for DiskExclusionProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedPropertiesInternal.DiskExclusionProperty { get => (this._diskExclusionProperty = this._diskExclusionProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskExclusionProperties()); set { {_diskExclusionProperty = value;} } }

        /// <summary>Creates an new <see cref="ExtendedProperties" /> instance.</summary>
        public ExtendedProperties()
        {

        }
    }
    /// Extended Properties for Azure IaasVM Backup.
    public partial interface IExtendedProperties :
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
        System.Collections.Generic.List<int> DiskExclusionPropertyDiskLunList { get; set; }
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
        bool? DiskExclusionPropertyIsInclusionList { get; set; }
        /// <summary>Linux VM name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Linux VM name",
        SerializedName = @"linuxVmApplicationName",
        PossibleTypes = new [] { typeof(string) })]
        string LinuxVMApplicationName { get; set; }

    }
    /// Extended Properties for Azure IaasVM Backup.
    internal partial interface IExtendedPropertiesInternal

    {
        /// <summary>Extended Properties for Disk Exclusion.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskExclusionProperties DiskExclusionProperty { get; set; }
        /// <summary>List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection.</summary>
        System.Collections.Generic.List<int> DiskExclusionPropertyDiskLunList { get; set; }
        /// <summary>Flag to indicate whether DiskLunList is to be included/ excluded from backup.</summary>
        bool? DiskExclusionPropertyIsInclusionList { get; set; }
        /// <summary>Linux VM name</summary>
        string LinuxVMApplicationName { get; set; }

    }
}