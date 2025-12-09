// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureWorkload workload-specific backup request.</summary>
    public partial class AzureWorkloadBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadBackupRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadBackupRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest __backupRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupRequest();

        /// <summary>Backing field for <see cref="BackupType" /> property.</summary>
        private string _backupType;

        /// <summary>Type of backup, viz. Full, Differential, Log or CopyOnlyFull</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string BackupType { get => this._backupType; set => this._backupType = value; }

        /// <summary>Backing field for <see cref="EnableCompression" /> property.</summary>
        private bool? _enableCompression;

        /// <summary>Bool for Compression setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? EnableCompression { get => this._enableCompression; set => this._enableCompression = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadBackupRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequestInternal)__backupRequest).ObjectType = "AzureWorkloadBackupRequest"; }

        /// <summary>Backing field for <see cref="RecoveryPointExpiryTimeInUtc" /> property.</summary>
        private global::System.DateTime? _recoveryPointExpiryTimeInUtc;

        /// <summary>Backup copy will expire after the time specified (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? RecoveryPointExpiryTimeInUtc { get => this._recoveryPointExpiryTimeInUtc; set => this._recoveryPointExpiryTimeInUtc = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadBackupRequest" /> instance.</summary>
        public AzureWorkloadBackupRequest()
        {
            this.__backupRequest.ObjectType = "AzureWorkloadBackupRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupRequest), __backupRequest);
            await eventListener.AssertObjectIsValid(nameof(__backupRequest), __backupRequest);
        }
    }
    /// AzureWorkload workload-specific backup request.
    public partial interface IAzureWorkloadBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest
    {
        /// <summary>Type of backup, viz. Full, Differential, Log or CopyOnlyFull</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup, viz. Full, Differential, Log or CopyOnlyFull",
        SerializedName = @"backupType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Differential", "Log", "CopyOnlyFull", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string BackupType { get; set; }
        /// <summary>Bool for Compression setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Bool for Compression setting",
        SerializedName = @"enableCompression",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableCompression { get; set; }
        /// <summary>Backup copy will expire after the time specified (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup copy will expire after the time specified (UTC).",
        SerializedName = @"recoveryPointExpiryTimeInUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecoveryPointExpiryTimeInUtc { get; set; }

    }
    /// AzureWorkload workload-specific backup request.
    internal partial interface IAzureWorkloadBackupRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequestInternal
    {
        /// <summary>Type of backup, viz. Full, Differential, Log or CopyOnlyFull</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Differential", "Log", "CopyOnlyFull", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string BackupType { get; set; }
        /// <summary>Bool for Compression setting</summary>
        bool? EnableCompression { get; set; }
        /// <summary>Backup copy will expire after the time specified (UTC).</summary>
        global::System.DateTime? RecoveryPointExpiryTimeInUtc { get; set; }

    }
}