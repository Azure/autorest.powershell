// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Backup resource vault config details.</summary>
    public partial class BackupResourceVaultConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceVaultConfig,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceVaultConfigInternal
    {

        /// <summary>Backing field for <see cref="EnhancedSecurityState" /> property.</summary>
        private string _enhancedSecurityState;

        /// <summary>Enabled or Disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string EnhancedSecurityState { get => this._enhancedSecurityState; set => this._enhancedSecurityState = value; }

        /// <summary>Backing field for <see cref="IsSoftDeleteFeatureStateEditable" /> property.</summary>
        private bool? _isSoftDeleteFeatureStateEditable;

        /// <summary>
        /// This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? IsSoftDeleteFeatureStateEditable { get => this._isSoftDeleteFeatureStateEditable; set => this._isSoftDeleteFeatureStateEditable = value; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="SoftDeleteFeatureState" /> property.</summary>
        private string _softDeleteFeatureState;

        /// <summary>Soft Delete feature state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SoftDeleteFeatureState { get => this._softDeleteFeatureState; set => this._softDeleteFeatureState = value; }

        /// <summary>Backing field for <see cref="SoftDeleteRetentionPeriodInDay" /> property.</summary>
        private int? _softDeleteRetentionPeriodInDay;

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? SoftDeleteRetentionPeriodInDay { get => this._softDeleteRetentionPeriodInDay; set => this._softDeleteRetentionPeriodInDay = value; }

        /// <summary>Backing field for <see cref="StorageModelType" /> property.</summary>
        private string _storageModelType;

        /// <summary>Storage type.</summary>
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

        /// <summary>Creates an new <see cref="BackupResourceVaultConfig" /> instance.</summary>
        public BackupResourceVaultConfig()
        {

        }
    }
    /// Backup resource vault config details.
    public partial interface IBackupResourceVaultConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Enabled or Disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabled or Disabled.",
        SerializedName = @"enhancedSecurityState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string EnhancedSecurityState { get; set; }
        /// <summary>
        /// This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault",
        SerializedName = @"isSoftDeleteFeatureStateEditable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSoftDeleteFeatureStateEditable { get; set; }
        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuard Operation Requests",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Soft Delete feature state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft Delete feature state",
        SerializedName = @"softDeleteFeatureState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteFeatureState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SoftDeleteRetentionPeriodInDay { get; set; }
        /// <summary>Storage type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage type.",
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

    }
    /// Backup resource vault config details.
    internal partial interface IBackupResourceVaultConfigInternal

    {
        /// <summary>Enabled or Disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string EnhancedSecurityState { get; set; }
        /// <summary>
        /// This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault
        /// </summary>
        bool? IsSoftDeleteFeatureStateEditable { get; set; }
        /// <summary>ResourceGuard Operation Requests</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Soft Delete feature state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteFeatureState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        int? SoftDeleteRetentionPeriodInDay { get; set; }
        /// <summary>Storage type.</summary>
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

    }
}