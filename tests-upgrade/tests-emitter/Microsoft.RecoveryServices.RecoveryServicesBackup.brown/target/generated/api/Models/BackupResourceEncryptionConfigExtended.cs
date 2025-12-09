// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>BackupResourceEncryptionConfigExtendedResource properties</summary>
    public partial class BackupResourceEncryptionConfigExtended :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigExtended,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigExtendedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfig"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfig __backupResourceEncryptionConfig = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupResourceEncryptionConfig();

        /// <summary>Encryption At Rest Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EncryptionAtRestType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).EncryptionAtRestType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).EncryptionAtRestType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string InfrastructureEncryptionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).InfrastructureEncryptionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).InfrastructureEncryptionState = value ?? null; }

        /// <summary>Key Vault Key URI</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string KeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).KeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).KeyUri = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string LastUpdateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).LastUpdateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).LastUpdateStatus = value ?? null; }

        /// <summary>Key Vault Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal)__backupResourceEncryptionConfig).SubscriptionId = value ?? null; }

        /// <summary>Backing field for <see cref="UseSystemAssignedIdentity" /> property.</summary>
        private bool? _useSystemAssignedIdentity;

        /// <summary>bool to indicate whether to use system Assigned Identity or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public bool? UseSystemAssignedIdentity { get => this._useSystemAssignedIdentity; set => this._useSystemAssignedIdentity = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private string _userAssignedIdentity;

        /// <summary>User Assigned Identity Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string UserAssignedIdentity { get => this._userAssignedIdentity; set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="BackupResourceEncryptionConfigExtended" /> instance.</summary>
        public BackupResourceEncryptionConfigExtended()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__backupResourceEncryptionConfig), __backupResourceEncryptionConfig);
            await eventListener.AssertObjectIsValid(nameof(__backupResourceEncryptionConfig), __backupResourceEncryptionConfig);
        }
    }
    /// BackupResourceEncryptionConfigExtendedResource properties
    public partial interface IBackupResourceEncryptionConfigExtended :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfig
    {
        /// <summary>bool to indicate whether to use system Assigned Identity or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"bool to indicate whether to use system Assigned Identity or not",
        SerializedName = @"useSystemAssignedIdentity",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseSystemAssignedIdentity { get; set; }
        /// <summary>User Assigned Identity Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Assigned Identity Id",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentity { get; set; }

    }
    /// BackupResourceEncryptionConfigExtendedResource properties
    internal partial interface IBackupResourceEncryptionConfigExtendedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal
    {
        /// <summary>bool to indicate whether to use system Assigned Identity or not</summary>
        bool? UseSystemAssignedIdentity { get; set; }
        /// <summary>User Assigned Identity Id</summary>
        string UserAssignedIdentity { get; set; }

    }
}