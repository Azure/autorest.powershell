// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>The resource storage details.</summary>
    public partial class BackupResourceConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceConfig,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceConfigInternal
    {

        /// <summary>Backing field for <see cref="CrossRegionRestoreFlag" /> property.</summary>
        private bool? _crossRegionRestoreFlag;

        /// <summary>Opt in details of Cross Region Restore feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? CrossRegionRestoreFlag { get => this._crossRegionRestoreFlag; set => this._crossRegionRestoreFlag = value; }

        /// <summary>Backing field for <see cref="DedupState" /> property.</summary>
        private string _dedupState;

        /// <summary>Vault Dedup state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string DedupState { get => this._dedupState; set => this._dedupState = value; }

        /// <summary>Backing field for <see cref="StorageModelType" /> property.</summary>
        private string _storageModelType;

        /// <summary>Storage type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string StorageModelType { get => this._storageModelType; set => this._storageModelType = value; }

        /// <summary>Backing field for <see cref="StorageType" /> property.</summary>
        private string _storageType;

        /// <summary>Storage type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string StorageType { get => this._storageType; set => this._storageType = value; }

        /// <summary>Backing field for <see cref="StorageTypeState" /> property.</summary>
        private string _storageTypeState;

        /// <summary>
        /// Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string StorageTypeState { get => this._storageTypeState; set => this._storageTypeState = value; }

        /// <summary>Backing field for <see cref="XcoolState" /> property.</summary>
        private string _xcoolState;

        /// <summary>Vault x-cool state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string XcoolState { get => this._xcoolState; set => this._xcoolState = value; }

        /// <summary>Creates an new <see cref="BackupResourceConfig" /> instance.</summary>
        public BackupResourceConfig()
        {

        }
    }
    /// The resource storage details.
    public partial interface IBackupResourceConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Opt in details of Cross Region Restore feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Opt in details of Cross Region Restore feature.",
        SerializedName = @"crossRegionRestoreFlag",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CrossRegionRestoreFlag { get; set; }
        /// <summary>Vault Dedup state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Vault Dedup state",
        SerializedName = @"dedupState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string DedupState { get; set; }
        /// <summary>Storage type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage type",
        SerializedName = @"storageModelType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "GeoRedundant", "LocallyRedundant", "ZoneRedundant", "ReadAccessGeoZoneRedundant")]
        string StorageModelType { get; set; }
        /// <summary>Storage type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage type.",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "GeoRedundant", "LocallyRedundant", "ZoneRedundant", "ReadAccessGeoZoneRedundant")]
        string StorageType { get; set; }
        /// <summary>
        /// Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked.",
        SerializedName = @"storageTypeState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Locked", "Unlocked")]
        string StorageTypeState { get; set; }
        /// <summary>Vault x-cool state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Vault x-cool state",
        SerializedName = @"xcoolState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string XcoolState { get; set; }

    }
    /// The resource storage details.
    internal partial interface IBackupResourceConfigInternal

    {
        /// <summary>Opt in details of Cross Region Restore feature.</summary>
        bool? CrossRegionRestoreFlag { get; set; }
        /// <summary>Vault Dedup state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string DedupState { get; set; }
        /// <summary>Storage type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "GeoRedundant", "LocallyRedundant", "ZoneRedundant", "ReadAccessGeoZoneRedundant")]
        string StorageModelType { get; set; }
        /// <summary>Storage type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "GeoRedundant", "LocallyRedundant", "ZoneRedundant", "ReadAccessGeoZoneRedundant")]
        string StorageType { get; set; }
        /// <summary>
        /// Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Locked", "Unlocked")]
        string StorageTypeState { get; set; }
        /// <summary>Vault x-cool state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string XcoolState { get; set; }

    }
}