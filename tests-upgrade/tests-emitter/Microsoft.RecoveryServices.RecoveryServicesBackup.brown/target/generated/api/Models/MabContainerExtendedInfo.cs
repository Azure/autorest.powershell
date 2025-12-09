// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Additional information of the container.</summary>
    public partial class MabContainerExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal
    {

        /// <summary>Backing field for <see cref="BackupItem" /> property.</summary>
        private System.Collections.Generic.List<string> _backupItem;

        /// <summary>List of backup items associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> BackupItem { get => this._backupItem; set => this._backupItem = value; }

        /// <summary>Backing field for <see cref="BackupItemType" /> property.</summary>
        private string _backupItemType;

        /// <summary>Type of backup items associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string BackupItemType { get => this._backupItemType; set => this._backupItemType = value; }

        /// <summary>Backing field for <see cref="LastBackupStatus" /> property.</summary>
        private string _lastBackupStatus;

        /// <summary>Latest backup status of this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string LastBackupStatus { get => this._lastBackupStatus; set => this._lastBackupStatus = value; }

        /// <summary>Backing field for <see cref="LastRefreshedAt" /> property.</summary>
        private global::System.DateTime? _lastRefreshedAt;

        /// <summary>Time stamp when this container was refreshed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRefreshedAt { get => this._lastRefreshedAt; set => this._lastRefreshedAt = value; }

        /// <summary>Backing field for <see cref="PolicyName" /> property.</summary>
        private string _policyName;

        /// <summary>Backup policy associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string PolicyName { get => this._policyName; set => this._policyName = value; }

        /// <summary>Creates an new <see cref="MabContainerExtendedInfo" /> instance.</summary>
        public MabContainerExtendedInfo()
        {

        }
    }
    /// Additional information of the container.
    public partial interface IMabContainerExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of backup items associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of backup items associated with this container.",
        SerializedName = @"backupItems",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BackupItem { get; set; }
        /// <summary>Type of backup items associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup items associated with this container.",
        SerializedName = @"backupItemType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string BackupItemType { get; set; }
        /// <summary>Latest backup status of this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Latest backup status of this container.",
        SerializedName = @"lastBackupStatus",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupStatus { get; set; }
        /// <summary>Time stamp when this container was refreshed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time stamp when this container was refreshed.",
        SerializedName = @"lastRefreshedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRefreshedAt { get; set; }
        /// <summary>Backup policy associated with this container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup policy associated with this container.",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get; set; }

    }
    /// Additional information of the container.
    internal partial interface IMabContainerExtendedInfoInternal

    {
        /// <summary>List of backup items associated with this container.</summary>
        System.Collections.Generic.List<string> BackupItem { get; set; }
        /// <summary>Type of backup items associated with this container.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string BackupItemType { get; set; }
        /// <summary>Latest backup status of this container.</summary>
        string LastBackupStatus { get; set; }
        /// <summary>Time stamp when this container was refreshed.</summary>
        global::System.DateTime? LastRefreshedAt { get; set; }
        /// <summary>Backup policy associated with this container.</summary>
        string PolicyName { get; set; }

    }
}