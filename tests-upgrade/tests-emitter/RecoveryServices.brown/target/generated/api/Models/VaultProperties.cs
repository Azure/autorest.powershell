// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Properties of the vault.</summary>
    public partial class VaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllFailoverIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllFailoverIssue = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllReplicationIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllReplicationIssue = value ?? null; }

        /// <summary>Backing field for <see cref="BackupStorageVersion" /> property.</summary>
        private string _backupStorageVersion;

        /// <summary>Backup storage version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string BackupStorageVersion { get => this._backupStorageVersion; }

        /// <summary>Backing field for <see cref="BcdrSecurityLevel" /> property.</summary>
        private string _bcdrSecurityLevel;

        /// <summary>
        /// Security levels of Recovery Services Vault for business continuity and disaster recovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string BcdrSecurityLevel { get => this._bcdrSecurityLevel; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingAlertsForCriticalOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSettingAlertsForCriticalOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSettingAlertsForCriticalOperation = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingEmailNotificationsForSiteRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSettingEmailNotificationsForSiteRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSettingEmailNotificationsForSiteRecovery = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal)RestoreSetting).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal)RestoreSetting).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState = value ?? null; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption _encryption;

        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesEncryption()); set => this._encryption = value; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string EncryptionInfrastructureEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).InfrastructureEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).InfrastructureEncryption = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySettingState = value ?? null; }

        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public bool? KekIdentityUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentityUseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentityUseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KekIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyUri = value ?? null; }

        /// <summary>Internal Acessors for BackupStorageVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.BackupStorageVersion { get => this._backupStorageVersion; set { {_backupStorageVersion = value;} } }

        /// <summary>Internal Acessors for BcdrSecurityLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.BcdrSecurityLevel { get => this._bcdrSecurityLevel; set { {_bcdrSecurityLevel = value;} } }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesEncryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.EncryptionKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.EncryptionKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal)Encryption).KeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings()); set { {_monitoringSetting = value;} } }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSettingClassicAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MonitoringSettingClassicAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)MonitoringSetting).ClassicAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetail { get => (this._moveDetail = this._moveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesMoveDetails()); set { {_moveDetail = value;} } }

        /// <summary>Internal Acessors for MoveDetailCompletionTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).CompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).CompletionTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MoveDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).OperationId = value ?? null; }

        /// <summary>Internal Acessors for MoveDetailSourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetailSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).SourceResourceId = value ?? null; }

        /// <summary>Internal Acessors for MoveDetailStartTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).StartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).StartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MoveDetailTargetResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveDetailTargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).TargetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).TargetResourceId = value ?? null; }

        /// <summary>Internal Acessors for MoveState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.MoveState { get => this._moveState; set { {_moveState = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.PrivateEndpointConnection { get => this._privateEndpointConnection; set { {_privateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointStateForBackup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.PrivateEndpointStateForBackup { get => this._privateEndpointStateForBackup; set { {_privateEndpointStateForBackup = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointStateForSiteRecovery</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.PrivateEndpointStateForSiteRecovery { get => this._privateEndpointStateForSiteRecovery; set { {_privateEndpointStateForSiteRecovery = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RedundancySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.RedundancySetting { get => (this._redundancySetting = this._redundancySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesRedundancySettings()); set { {_redundancySetting = value;} } }

        /// <summary>Internal Acessors for RestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.RestoreSetting { get => (this._restoreSetting = this._restoreSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RestoreSettings()); set { {_restoreSetting = value;} } }

        /// <summary>Internal Acessors for RestoreSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.RestoreSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal)RestoreSetting).CrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal)RestoreSetting).CrossSubscriptionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecureScore</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecureScore { get => this._secureScore; set { {_secureScore = value;} } }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings()); set { {_securitySetting = value;} } }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingMultiUserAuthorization</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecuritySettingMultiUserAuthorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).MultiUserAuthorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).MultiUserAuthorization = value ?? null; }

        /// <summary>Internal Acessors for SecuritySettingSoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecuritySettingSoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingSourceScanConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SecuritySettingSourceScanConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SourceScanConfigurationSourceScanIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.SourceScanConfigurationSourceScanIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfigurationSourceScanIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfigurationSourceScanIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetail { get => (this._upgradeDetail = this._upgradeDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails()); set { {_upgradeDetail = value;} } }

        /// <summary>Internal Acessors for UpgradeDetailEndTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).EndTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).EndTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailLastUpdatedTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailLastUpdatedTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).LastUpdatedTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).LastUpdatedTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Message = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).OperationId = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailPreviousResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailPreviousResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).PreviousResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).PreviousResourceId = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailStartTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).StartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).StartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Status = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailTriggerType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).TriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).TriggerType = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailUpgradedResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal.UpgradeDetailUpgradedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).UpgradedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).UpgradedResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="MonitoringSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings _monitoringSetting;

        /// <summary>Monitoring Settings of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings()); set => this._monitoringSetting = value; }

        /// <summary>Backing field for <see cref="MoveDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails _moveDetail;

        /// <summary>The details of the latest move operation performed on the Azure Resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails MoveDetail { get => (this._moveDetail = this._moveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesMoveDetails()); set => this._moveDetail = value; }

        /// <summary>End Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? MoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).CompletionTimeUtc; }

        /// <summary>OperationId of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).OperationId; }

        /// <summary>Source Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).SourceResourceId; }

        /// <summary>Start Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? MoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).StartTimeUtc; }

        /// <summary>Target Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailTargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetailsInternal)MoveDetail).TargetResourceId; }

        /// <summary>Backing field for <see cref="MoveState" /> property.</summary>
        private string _moveState;

        /// <summary>The State of the Resource after the move operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string MoveState { get => this._moveState; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> _privateEndpointConnection;

        /// <summary>List of private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> PrivateEndpointConnection { get => this._privateEndpointConnection; }

        /// <summary>Backing field for <see cref="PrivateEndpointStateForBackup" /> property.</summary>
        private string _privateEndpointStateForBackup;

        /// <summary>Private endpoint state for backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string PrivateEndpointStateForBackup { get => this._privateEndpointStateForBackup; }

        /// <summary>Backing field for <see cref="PrivateEndpointStateForSiteRecovery" /> property.</summary>
        private string _privateEndpointStateForSiteRecovery;

        /// <summary>Private endpoint state for site recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string PrivateEndpointStateForSiteRecovery { get => this._privateEndpointStateForSiteRecovery; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning State.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>
        /// property to enable or disable resource provider inbound network traffic from public clients
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="RedundancySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings _redundancySetting;

        /// <summary>The redundancy Settings of a Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings RedundancySetting { get => (this._redundancySetting = this._redundancySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesRedundancySettings()); set => this._redundancySetting = value; }

        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string RedundancySettingCrossRegionRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettingsInternal)RedundancySetting).CrossRegionRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettingsInternal)RedundancySetting).CrossRegionRestore = value ?? null; }

        /// <summary>The storage redundancy setting of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string RedundancySettingStandardTierStorageRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettingsInternal)RedundancySetting).StandardTierStorageRedundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettingsInternal)RedundancySetting).StandardTierStorageRedundancy = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="RestoreSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings _restoreSetting;

        /// <summary>Restore Settings of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings RestoreSetting { get => (this._restoreSetting = this._restoreSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RestoreSettings()); set => this._restoreSetting = value; }

        /// <summary>Backing field for <see cref="SecureScore" /> property.</summary>
        private string _secureScore;

        /// <summary>Secure Score of Recovery Services Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string SecureScore { get => this._secureScore; }

        /// <summary>Backing field for <see cref="SecuritySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings _securitySetting;

        /// <summary>Security Settings of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings()); set => this._securitySetting = value; }

        /// <summary>MUA Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SecuritySettingMultiUserAuthorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).MultiUserAuthorization; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingEnhancedSecurityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingEnhancedSecurityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingEnhancedSecurityState = value ?? null; }

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingSoftDeleteRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingSoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingSoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingSoftDeleteState = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanConfigurationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfigurationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanConfigurationState = value ?? null; }

        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityOperationIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanIdentityOperationIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanIdentityOperationIdentityType = value ?? null; }

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)SecuritySetting).SourceScanIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Backing field for <see cref="UpgradeDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails _upgradeDetail;

        /// <summary>Details for upgrading vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails UpgradeDetail { get => (this._upgradeDetail = this._upgradeDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails()); set => this._upgradeDetail = value; }

        /// <summary>UTC time at which the upgrade operation has ended.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).EndTimeUtc; }

        /// <summary>UTC time at which the upgrade operation status was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailLastUpdatedTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).LastUpdatedTimeUtc; }

        /// <summary>Message to the user containing information about the upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Message; }

        /// <summary>ID of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).OperationId; }

        /// <summary>Resource ID of the vault before the upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailPreviousResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).PreviousResourceId; }

        /// <summary>UTC time at which the upgrade operation has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).StartTimeUtc; }

        /// <summary>Status of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).Status; }

        /// <summary>The way the vault upgrade was triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).TriggerType; }

        /// <summary>Resource ID of the upgraded vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailUpgradedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)UpgradeDetail).UpgradedResourceId; }

        /// <summary>Creates an new <see cref="VaultProperties" /> instance.</summary>
        public VaultProperties()
        {

        }
    }
    /// Properties of the vault.
    public partial interface IVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllFailoverIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllReplicationIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get; set; }
        /// <summary>Backup storage version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Backup storage version",
        SerializedName = @"backupStorageVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("V1", "V2", "Unassigned")]
        string BackupStorageVersion { get;  }
        /// <summary>
        /// Security levels of Recovery Services Vault for business continuity and disaster recovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Security levels of Recovery Services Vault for business continuity and disaster recovery",
        SerializedName = @"bcdrSecurityLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Poor", "Fair", "Good", "Excellent")]
        string BcdrSecurityLevel { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForCriticalOperations",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingAlertsForCriticalOperation { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"emailNotificationsForSiteRecovery",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingEmailNotificationsForSiteRecovery { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"crossSubscriptionRestoreState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get; set; }
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabling/Disabling the Double Encryption state",
        SerializedName = @"infrastructureEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionInfrastructureEncryption { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field",
        SerializedName = @"useSystemAssignedIdentity",
        PossibleTypes = new [] { typeof(bool) })]
        bool? KekIdentityUseSystemAssignedIdentity { get; set; }
        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string KekIdentityUserAssignedIdentity { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key uri of the Customer Managed Key",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>End Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"End Time of the Resource Move Operation",
        SerializedName = @"completionTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MoveDetailCompletionTimeUtc { get;  }
        /// <summary>OperationId of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"OperationId of the Resource Move Operation",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string MoveDetailOperationId { get;  }
        /// <summary>Source Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Source Resource of the Resource Move Operation",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string MoveDetailSourceResourceId { get;  }
        /// <summary>Start Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Start Time of the Resource Move Operation",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MoveDetailStartTimeUtc { get;  }
        /// <summary>Target Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Target Resource of the Resource Move Operation",
        SerializedName = @"targetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string MoveDetailTargetResourceId { get;  }
        /// <summary>The State of the Resource after the move operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The State of the Resource after the move operation",
        SerializedName = @"moveState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Unknown", "InProgress", "PrepareFailed", "CommitFailed", "PrepareTimedout", "CommitTimedout", "MoveSucceeded", "Failure", "CriticalFailure", "PartialSuccess")]
        string MoveState { get;  }
        /// <summary>List of private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of private endpoint connection.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> PrivateEndpointConnection { get;  }
        /// <summary>Private endpoint state for backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Private endpoint state for backup.",
        SerializedName = @"privateEndpointStateForBackup",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Enabled")]
        string PrivateEndpointStateForBackup { get;  }
        /// <summary>Private endpoint state for site recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Private endpoint state for site recovery.",
        SerializedName = @"privateEndpointStateForSiteRecovery",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Enabled")]
        string PrivateEndpointStateForSiteRecovery { get;  }
        /// <summary>Provisioning State.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>
        /// property to enable or disable resource provider inbound network traffic from public clients
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"property to enable or disable resource provider inbound network traffic from public clients",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to show if Cross Region Restore is enabled on the Vault or not",
        SerializedName = @"crossRegionRestore",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string RedundancySettingCrossRegionRestore { get; set; }
        /// <summary>The storage redundancy setting of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The storage redundancy setting of a vault",
        SerializedName = @"standardTierStorageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "LocallyRedundant", "GeoRedundant", "ZoneRedundant")]
        string RedundancySettingStandardTierStorageRedundancy { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Secure Score of Recovery Services Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Secure Score of Recovery Services Vault",
        SerializedName = @"secureScore",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Minimum", "Adequate", "Maximum")]
        string SecureScore { get;  }
        /// <summary>MUA Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"MUA Settings of a vault",
        SerializedName = @"multiUserAuthorization",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SecuritySettingMultiUserAuthorization { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"enhancedSecurityState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingEnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"softDeleteState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingSoftDeleteState { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SourceScanConfigurationState { get; set; }
        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type that should be used for an operation.",
        SerializedName = @"operationIdentityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity to be used for an operation if operationIdentityType is UserAssigned.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string SourceScanIdentityUserAssignedIdentity { get; set; }
        /// <summary>UTC time at which the upgrade operation has ended.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"UTC time at which the upgrade operation has ended.",
        SerializedName = @"endTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpgradeDetailEndTimeUtc { get;  }
        /// <summary>UTC time at which the upgrade operation status was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"UTC time at which the upgrade operation status was last updated.",
        SerializedName = @"lastUpdatedTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpgradeDetailLastUpdatedTimeUtc { get;  }
        /// <summary>Message to the user containing information about the upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Message to the user containing information about the upgrade operation.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDetailMessage { get;  }
        /// <summary>ID of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ID of the vault upgrade operation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDetailOperationId { get;  }
        /// <summary>Resource ID of the vault before the upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource ID of the vault before the upgrade.",
        SerializedName = @"previousResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDetailPreviousResourceId { get;  }
        /// <summary>UTC time at which the upgrade operation has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"UTC time at which the upgrade operation has started.",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpgradeDetailStartTimeUtc { get;  }
        /// <summary>Status of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the vault upgrade operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Unknown", "InProgress", "Upgraded", "Failed")]
        string UpgradeDetailStatus { get;  }
        /// <summary>The way the vault upgrade was triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The way the vault upgrade was triggered.",
        SerializedName = @"triggerType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("UserTriggered", "ForcedUpgrade")]
        string UpgradeDetailTriggerType { get;  }
        /// <summary>Resource ID of the upgraded vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource ID of the upgraded vault.",
        SerializedName = @"upgradedResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDetailUpgradedResourceId { get;  }

    }
    /// Properties of the vault.
    internal partial interface IVaultPropertiesInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get; set; }
        /// <summary>Backup storage version</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("V1", "V2", "Unassigned")]
        string BackupStorageVersion { get; set; }
        /// <summary>
        /// Security levels of Recovery Services Vault for business continuity and disaster recovery
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Poor", "Fair", "Good", "Excellent")]
        string BcdrSecurityLevel { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingAlertsForCriticalOperation { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingEmailNotificationsForSiteRecovery { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption Encryption { get; set; }
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionInfrastructureEncryption { get; set; }
        /// <summary>The details of the identity used for CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity EncryptionKekIdentity { get; set; }
        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties EncryptionKeyVaultProperty { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        bool? KekIdentityUseSystemAssignedIdentity { get; set; }
        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        string KekIdentityUserAssignedIdentity { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Monitoring Settings of the vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>Settings for classic alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings MonitoringSettingClassicAlertSetting { get; set; }
        /// <summary>The details of the latest move operation performed on the Azure Resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails MoveDetail { get; set; }
        /// <summary>End Time of the Resource Move Operation</summary>
        global::System.DateTime? MoveDetailCompletionTimeUtc { get; set; }
        /// <summary>OperationId of the Resource Move Operation</summary>
        string MoveDetailOperationId { get; set; }
        /// <summary>Source Resource of the Resource Move Operation</summary>
        string MoveDetailSourceResourceId { get; set; }
        /// <summary>Start Time of the Resource Move Operation</summary>
        global::System.DateTime? MoveDetailStartTimeUtc { get; set; }
        /// <summary>Target Resource of the Resource Move Operation</summary>
        string MoveDetailTargetResourceId { get; set; }
        /// <summary>The State of the Resource after the move operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Unknown", "InProgress", "PrepareFailed", "CommitFailed", "PrepareTimedout", "CommitTimedout", "MoveSucceeded", "Failure", "CriticalFailure", "PartialSuccess")]
        string MoveState { get; set; }
        /// <summary>List of private endpoint connection.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> PrivateEndpointConnection { get; set; }
        /// <summary>Private endpoint state for backup.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Enabled")]
        string PrivateEndpointStateForBackup { get; set; }
        /// <summary>Private endpoint state for site recovery.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Enabled")]
        string PrivateEndpointStateForSiteRecovery { get; set; }
        /// <summary>Provisioning State.</summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// property to enable or disable resource provider inbound network traffic from public clients
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>The redundancy Settings of a Vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings RedundancySetting { get; set; }
        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string RedundancySettingCrossRegionRestore { get; set; }
        /// <summary>The storage redundancy setting of a vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "LocallyRedundant", "GeoRedundant", "ZoneRedundant")]
        string RedundancySettingStandardTierStorageRedundancy { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Restore Settings of the vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings RestoreSetting { get; set; }
        /// <summary>Settings for CrossSubscriptionRestore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings RestoreSettingCrossSubscriptionRestoreSetting { get; set; }
        /// <summary>Secure Score of Recovery Services Vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("None", "Minimum", "Adequate", "Maximum")]
        string SecureScore { get; set; }
        /// <summary>Security Settings of the vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings SecuritySetting { get; set; }
        /// <summary>Immutability Settings of a vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings SecuritySettingImmutabilitySetting { get; set; }
        /// <summary>MUA Settings of a vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SecuritySettingMultiUserAuthorization { get; set; }
        /// <summary>Soft delete Settings of a vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings SecuritySettingSoftDeleteSetting { get; set; }
        /// <summary>Source scan configuration of vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration SecuritySettingSourceScanConfiguration { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingEnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingSoftDeleteState { get; set; }
        /// <summary>Identity details to be used for an operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity SourceScanConfigurationSourceScanIdentity { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SourceScanConfigurationState { get; set; }
        /// <summary>Identity type that should be used for an operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        string SourceScanIdentityUserAssignedIdentity { get; set; }
        /// <summary>Details for upgrading vault.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails UpgradeDetail { get; set; }
        /// <summary>UTC time at which the upgrade operation has ended.</summary>
        global::System.DateTime? UpgradeDetailEndTimeUtc { get; set; }
        /// <summary>UTC time at which the upgrade operation status was last updated.</summary>
        global::System.DateTime? UpgradeDetailLastUpdatedTimeUtc { get; set; }
        /// <summary>Message to the user containing information about the upgrade operation.</summary>
        string UpgradeDetailMessage { get; set; }
        /// <summary>ID of the vault upgrade operation.</summary>
        string UpgradeDetailOperationId { get; set; }
        /// <summary>Resource ID of the vault before the upgrade.</summary>
        string UpgradeDetailPreviousResourceId { get; set; }
        /// <summary>UTC time at which the upgrade operation has started.</summary>
        global::System.DateTime? UpgradeDetailStartTimeUtc { get; set; }
        /// <summary>Status of the vault upgrade operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Unknown", "InProgress", "Upgraded", "Failed")]
        string UpgradeDetailStatus { get; set; }
        /// <summary>The way the vault upgrade was triggered.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("UserTriggered", "ForcedUpgrade")]
        string UpgradeDetailTriggerType { get; set; }
        /// <summary>Resource ID of the upgraded vault.</summary>
        string UpgradeDetailUpgradedResourceId { get; set; }

    }
}