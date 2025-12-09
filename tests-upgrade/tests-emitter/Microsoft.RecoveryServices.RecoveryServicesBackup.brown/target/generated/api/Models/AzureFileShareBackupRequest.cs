// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureFileShare workload-specific backup request.</summary>
    public partial class AzureFileShareBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareBackupRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureFileShareBackupRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest __backupRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupRequest();

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureFileShareBackupRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequestInternal)__backupRequest).ObjectType = "AzureFileShareBackupRequest"; }

        /// <summary>Backing field for <see cref="RecoveryPointExpiryTimeInUtc" /> property.</summary>
        private global::System.DateTime? _recoveryPointExpiryTimeInUtc;

        /// <summary>Backup copy will expire after the time specified (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? RecoveryPointExpiryTimeInUtc { get => this._recoveryPointExpiryTimeInUtc; set => this._recoveryPointExpiryTimeInUtc = value; }

        /// <summary>Creates an new <see cref="AzureFileShareBackupRequest" /> instance.</summary>
        public AzureFileShareBackupRequest()
        {
            this.__backupRequest.ObjectType = "AzureFileShareBackupRequest";
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
    /// AzureFileShare workload-specific backup request.
    public partial interface IAzureFileShareBackupRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequest
    {
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
    /// AzureFileShare workload-specific backup request.
    internal partial interface IAzureFileShareBackupRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupRequestInternal
    {
        /// <summary>Backup copy will expire after the time specified (UTC).</summary>
        global::System.DateTime? RecoveryPointExpiryTimeInUtc { get; set; }

    }
}