// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>BackupResourceEncryptionConfigResource properties</summary>
    public partial class BackupResourceEncryptionConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfig,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupResourceEncryptionConfigInternal
    {

        /// <summary>Backing field for <see cref="EncryptionAtRestType" /> property.</summary>
        private string _encryptionAtRestType;

        /// <summary>Encryption At Rest Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string EncryptionAtRestType { get => this._encryptionAtRestType; set => this._encryptionAtRestType = value; }

        /// <summary>Backing field for <see cref="InfrastructureEncryptionState" /> property.</summary>
        private string _infrastructureEncryptionState;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string InfrastructureEncryptionState { get => this._infrastructureEncryptionState; set => this._infrastructureEncryptionState = value; }

        /// <summary>Backing field for <see cref="KeyUri" /> property.</summary>
        private string _keyUri;

        /// <summary>Key Vault Key URI</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string KeyUri { get => this._keyUri; set => this._keyUri = value; }

        /// <summary>Backing field for <see cref="LastUpdateStatus" /> property.</summary>
        private string _lastUpdateStatus;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string LastUpdateStatus { get => this._lastUpdateStatus; set => this._lastUpdateStatus = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Key Vault Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="BackupResourceEncryptionConfig" /> instance.</summary>
        public BackupResourceEncryptionConfig()
        {

        }
    }
    /// BackupResourceEncryptionConfigResource properties
    public partial interface IBackupResourceEncryptionConfig :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Encryption At Rest Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption At Rest Type",
        SerializedName = @"encryptionAtRestType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "MicrosoftManaged", "CustomerManaged")]
        string EncryptionAtRestType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"infrastructureEncryptionState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Disabled", "Enabled")]
        string InfrastructureEncryptionState { get; set; }
        /// <summary>Key Vault Key URI</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Key Vault Key URI",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyUri { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"lastUpdateStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "NotEnabled", "PartiallySucceeded", "PartiallyFailed", "Failed", "Succeeded", "Initialized", "FirstInitialization")]
        string LastUpdateStatus { get; set; }
        /// <summary>Key Vault Subscription Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Key Vault Subscription Id",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// BackupResourceEncryptionConfigResource properties
    internal partial interface IBackupResourceEncryptionConfigInternal

    {
        /// <summary>Encryption At Rest Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "MicrosoftManaged", "CustomerManaged")]
        string EncryptionAtRestType { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Disabled", "Enabled")]
        string InfrastructureEncryptionState { get; set; }
        /// <summary>Key Vault Key URI</summary>
        string KeyUri { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "NotEnabled", "PartiallySucceeded", "PartiallyFailed", "Failed", "Succeeded", "Initialized", "FirstInitialization")]
        string LastUpdateStatus { get; set; }
        /// <summary>Key Vault Subscription Id</summary>
        string SubscriptionId { get; set; }

    }
}