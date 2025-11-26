// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>
    /// Deleted Backup Vault - uses composition with BackupVault and additional deletion metadata
    /// </summary>
    public partial class DeletedBackupVault :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVault,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure = value ?? null; }

        /// <summary>Backing field for <see cref="BcdrSecurityLevel" /> property.</summary>
        private string _bcdrSecurityLevel;

        /// <summary>Security Level of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string BcdrSecurityLevel { get => this._bcdrSecurityLevel; }

        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossRegionRestoreSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSettingState = value ?? null; }

        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossSubscriptionRestoreSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSettingState = value ?? null; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingInfrastructureEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingInfrastructureEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingInfrastructureEncryption = value ?? null; }

        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingState = value ?? null; }

        /// <summary>Backing field for <see cref="FeatureSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings _featureSetting;

        /// <summary>Feature Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.FeatureSettings()); set => this._featureSetting = value; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySettingState = value ?? null; }

        /// <summary>Backing field for <see cref="IsVaultProtectedByResourceGuard" /> property.</summary>
        private bool? _isVaultProtectedByResourceGuard;

        /// <summary>Is vault protected by resource guard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public bool? IsVaultProtectedByResourceGuard { get => this._isVaultProtectedByResourceGuard; }

        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KekIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KekIdentityId = value ?? null; }

        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KekIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KekIdentityType = value ?? null; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KeyVaultPropertyKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).KeyVaultPropertyKeyUri = value ?? null; }

        /// <summary>Internal Acessors for BcdrSecurityLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.BcdrSecurityLevel { get => this._bcdrSecurityLevel; set { {_bcdrSecurityLevel = value;} } }

        /// <summary>Internal Acessors for EncryptionSettingKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.EncryptionSettingKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionSettingKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.EncryptionSettingKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.FeatureSettings()); set { {_featureSetting = value;} } }

        /// <summary>Internal Acessors for FeatureSettingCrossRegionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.FeatureSettingCrossRegionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IsVaultProtectedByResourceGuard</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.IsVaultProtectedByResourceGuard { get => this._isVaultProtectedByResourceGuard; set { {_isVaultProtectedByResourceGuard = value;} } }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettings()); set { {_monitoringSetting = value;} } }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OriginalBackupVaultId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.OriginalBackupVaultId { get => this._originalBackupVaultId; set { {_originalBackupVaultId = value;} } }

        /// <summary>Internal Acessors for OriginalBackupVaultName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.OriginalBackupVaultName { get => this._originalBackupVaultName; set { {_originalBackupVaultName = value;} } }

        /// <summary>Internal Acessors for OriginalBackupVaultResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.OriginalBackupVaultResourcePath { get => this._originalBackupVaultResourcePath; set { {_originalBackupVaultResourcePath = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceDeletionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceDeletionInfo { get => (this._resourceDeletionInfo = this._resourceDeletionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ResourceDeletionInfo()); set { {_resourceDeletionInfo = value;} } }

        /// <summary>Internal Acessors for ResourceDeletionInfoDeleteActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceDeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeleteActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeleteActivityId = value ?? null; }

        /// <summary>Internal Acessors for ResourceDeletionInfoDeletionTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceDeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeletionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeletionTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ResourceDeletionInfoScheduledPurgeTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceDeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).ScheduledPurgeTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).ScheduledPurgeTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ResourceMoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetail { get => (this._resourceMoveDetail = this._resourceMoveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ResourceMoveDetails()); set { {_resourceMoveDetail = value;} } }

        /// <summary>Internal Acessors for ResourceMoveDetailCompletionTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).CompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).CompletionTimeUtc = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).OperationId = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailSourceResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).SourceResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).SourceResourcePath = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailStartTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).StartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).StartTimeUtc = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailTargetResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).TargetResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).TargetResourcePath = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.ResourceMoveState { get => this._resourceMoveState; set { {_resourceMoveState = value;} } }

        /// <summary>Internal Acessors for SecureScore</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.SecureScore { get => this._secureScore; set { {_secureScore = value;} } }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings()); set { {_securitySetting = value;} } }

        /// <summary>Internal Acessors for SecuritySettingEncryptionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.SecuritySettingEncryptionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingSoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal.SecuritySettingSoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="MonitoringSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings _monitoringSetting;

        /// <summary>Monitoring Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettings()); set => this._monitoringSetting = value; }

        /// <summary>Backing field for <see cref="OriginalBackupVaultId" /> property.</summary>
        private string _originalBackupVaultId;

        /// <summary>Resource Id of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string OriginalBackupVaultId { get => this._originalBackupVaultId; }

        /// <summary>Backing field for <see cref="OriginalBackupVaultName" /> property.</summary>
        private string _originalBackupVaultName;

        /// <summary>Resource name of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string OriginalBackupVaultName { get => this._originalBackupVaultName; }

        /// <summary>Backing field for <see cref="OriginalBackupVaultResourcePath" /> property.</summary>
        private string _originalBackupVaultResourcePath;

        /// <summary>Resource path of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string OriginalBackupVaultResourcePath { get => this._originalBackupVaultResourcePath; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ReplicatedRegion" /> property.</summary>
        private System.Collections.Generic.List<string> _replicatedRegion;

        /// <summary>List of replicated regions for Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ReplicatedRegion { get => this._replicatedRegion; set => this._replicatedRegion = value; }

        /// <summary>Backing field for <see cref="ResourceDeletionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfo _resourceDeletionInfo;

        /// <summary>Deletion info for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfo ResourceDeletionInfo { get => (this._resourceDeletionInfo = this._resourceDeletionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ResourceDeletionInfo()); }

        /// <summary>Delete activity ID for troubleshooting the deletion of the tracked resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceDeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeleteActivityId; }

        /// <summary>Specifies time of deletion for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public global::System.DateTime? ResourceDeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).DeletionTime; }

        /// <summary>Specifies the scheduled purge time for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public global::System.DateTime? ResourceDeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfoInternal)ResourceDeletionInfo).ScheduledPurgeTime; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="ResourceMoveDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetails _resourceMoveDetail;

        /// <summary>Resource move details for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetails ResourceMoveDetail { get => (this._resourceMoveDetail = this._resourceMoveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ResourceMoveDetails()); }

        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).CompletionTimeUtc; }

        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).OperationId; }

        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).SourceResourcePath; }

        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).StartTimeUtc; }

        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetailsInternal)ResourceMoveDetail).TargetResourcePath; }

        /// <summary>Backing field for <see cref="ResourceMoveState" /> property.</summary>
        private string _resourceMoveState;

        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ResourceMoveState { get => this._resourceMoveState; }

        /// <summary>Backing field for <see cref="SecureScore" /> property.</summary>
        private string _secureScore;

        /// <summary>Secure Score of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string SecureScore { get => this._secureScore; }

        /// <summary>Backing field for <see cref="SecuritySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings _securitySetting;

        /// <summary>Security Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings()); set => this._securitySetting = value; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteSettingRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingRetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingRetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSettingState = value ?? null; }

        /// <summary>Backing field for <see cref="StorageSetting" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> _storageSetting;

        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> StorageSetting { get => this._storageSetting; set => this._storageSetting = value; }

        /// <summary>Creates an new <see cref="DeletedBackupVault" /> instance.</summary>
        public DeletedBackupVault()
        {

        }
    }
    /// Deleted Backup Vault - uses composition with BackupVault and additional deletion metadata
    public partial interface IDeletedBackupVault :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }
        /// <summary>Security Level of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Security Level of Backup Vault",
        SerializedName = @"bcdrSecurityLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Poor", "Fair", "Good", "Excellent", "NotSupported")]
        string BcdrSecurityLevel { get;  }
        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CrossRegionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string CrossRegionRestoreSettingState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CrossSubscriptionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "PermanentlyDisabled", "Enabled")]
        string CrossSubscriptionRestoreSettingState { get; set; }
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabling/Disabling the Double Encryption state",
        SerializedName = @"infrastructureEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionSettingInfrastructureEncryption { get; set; }
        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption state of the Backup Vault.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled", "Inconsistent")]
        string EncryptionSettingState { get; set; }
        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Immutability state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>Is vault protected by resource guard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Is vault protected by resource guard",
        SerializedName = @"isVaultProtectedByResourceGuard",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsVaultProtectedByResourceGuard { get;  }
        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types: 'UserAssigned' only.",
        SerializedName = @"identityId",
        PossibleTypes = new [] { typeof(string) })]
        string KekIdentityId { get; set; }
        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created managed identity.",
        SerializedName = @"identityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string KekIdentityType { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key uri of the Customer Managed Key",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Resource Id of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of the original backup vault",
        SerializedName = @"originalBackupVaultId",
        PossibleTypes = new [] { typeof(string) })]
        string OriginalBackupVaultId { get;  }
        /// <summary>Resource name of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource name of the original backup vault",
        SerializedName = @"originalBackupVaultName",
        PossibleTypes = new [] { typeof(string) })]
        string OriginalBackupVaultName { get;  }
        /// <summary>Resource path of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource path of the original backup vault",
        SerializedName = @"originalBackupVaultResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string OriginalBackupVaultResourcePath { get;  }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the BackupVault resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Failed", "Provisioning", "Succeeded", "Unknown", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>List of replicated regions for Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of replicated regions for Backup Vault",
        SerializedName = @"replicatedRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ReplicatedRegion { get; set; }
        /// <summary>Delete activity ID for troubleshooting the deletion of the tracked resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Delete activity ID for troubleshooting the deletion of the tracked resource",
        SerializedName = @"deleteActivityId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceDeletionInfoDeleteActivityId { get;  }
        /// <summary>Specifies time of deletion for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies time of deletion for the tracked resource (Backup Vault)",
        SerializedName = @"deletionTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResourceDeletionInfoDeletionTime { get;  }
        /// <summary>Specifies the scheduled purge time for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the scheduled purge time for the tracked resource (Backup Vault)",
        SerializedName = @"scheduledPurgeTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResourceDeletionInfoScheduledPurgeTime { get;  }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"completionTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailCompletionTimeUtc { get;  }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"CorrelationId of latest ResourceMove operation attempted",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailOperationId { get;  }
        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ARM resource path of source resource",
        SerializedName = @"sourceResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailSourceResourcePath { get;  }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailStartTimeUtc { get;  }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ARM resource path of target resource used in latest ResourceMove operation",
        SerializedName = @"targetResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailTargetResourcePath { get;  }
        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource move state for backup vault",
        SerializedName = @"resourceMoveState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Unknown", "InProgress", "PrepareFailed", "CommitFailed", "Failed", "PrepareTimedout", "CommitTimedout", "CriticalFailure", "PartialSuccess", "MoveSucceeded")]
        string ResourceMoveState { get;  }
        /// <summary>Secure Score of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Secure Score of Backup Vault",
        SerializedName = @"secureScore",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("None", "Minimum", "Adequate", "Maximum", "NotSupported")]
        string SecureScore { get;  }
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? SoftDeleteSettingRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Off", "On", "AlwaysOn")]
        string SoftDeleteSettingState { get; set; }
        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage Settings",
        SerializedName = @"storageSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> StorageSetting { get; set; }

    }
    /// Deleted Backup Vault - uses composition with BackupVault and additional deletion metadata
    internal partial interface IDeletedBackupVaultInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }
        /// <summary>Security Level of Backup Vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Poor", "Fair", "Good", "Excellent", "NotSupported")]
        string BcdrSecurityLevel { get; set; }
        /// <summary>CrossRegionRestore state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string CrossRegionRestoreSettingState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "PermanentlyDisabled", "Enabled")]
        string CrossSubscriptionRestoreSettingState { get; set; }
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionSettingInfrastructureEncryption { get; set; }
        /// <summary>The details of the managed identity used for CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity EncryptionSettingKekIdentity { get; set; }
        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties EncryptionSettingKeyVaultProperty { get; set; }
        /// <summary>Encryption state of the Backup Vault.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled", "Inconsistent")]
        string EncryptionSettingState { get; set; }
        /// <summary>Feature Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings FeatureSetting { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings FeatureSettingCrossRegionRestoreSetting { get; set; }
        /// <summary>CrossSubscriptionRestore Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings FeatureSettingCrossSubscriptionRestoreSetting { get; set; }
        /// <summary>Immutability state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>Is vault protected by resource guard</summary>
        bool? IsVaultProtectedByResourceGuard { get; set; }
        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        string KekIdentityId { get; set; }
        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string KekIdentityType { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Monitoring Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>Resource Id of the original backup vault</summary>
        string OriginalBackupVaultId { get; set; }
        /// <summary>Resource name of the original backup vault</summary>
        string OriginalBackupVaultName { get; set; }
        /// <summary>Resource path of the original backup vault</summary>
        string OriginalBackupVaultResourcePath { get; set; }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Failed", "Provisioning", "Succeeded", "Unknown", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>List of replicated regions for Backup Vault</summary>
        System.Collections.Generic.List<string> ReplicatedRegion { get; set; }
        /// <summary>Deletion info for the tracked resource (Backup Vault)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfo ResourceDeletionInfo { get; set; }
        /// <summary>Delete activity ID for troubleshooting the deletion of the tracked resource</summary>
        string ResourceDeletionInfoDeleteActivityId { get; set; }
        /// <summary>Specifies time of deletion for the tracked resource (Backup Vault)</summary>
        global::System.DateTime? ResourceDeletionInfoDeletionTime { get; set; }
        /// <summary>Specifies the scheduled purge time for the tracked resource (Backup Vault)</summary>
        global::System.DateTime? ResourceDeletionInfoScheduledPurgeTime { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
        /// <summary>Resource move details for backup vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetails ResourceMoveDetail { get; set; }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        string ResourceMoveDetailCompletionTimeUtc { get; set; }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        string ResourceMoveDetailOperationId { get; set; }
        /// <summary>ARM resource path of source resource</summary>
        string ResourceMoveDetailSourceResourcePath { get; set; }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        string ResourceMoveDetailStartTimeUtc { get; set; }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        string ResourceMoveDetailTargetResourcePath { get; set; }
        /// <summary>Resource move state for backup vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Unknown", "InProgress", "PrepareFailed", "CommitFailed", "Failed", "PrepareTimedout", "CommitTimedout", "CriticalFailure", "PartialSuccess", "MoveSucceeded")]
        string ResourceMoveState { get; set; }
        /// <summary>Secure Score of Backup Vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("None", "Minimum", "Adequate", "Maximum", "NotSupported")]
        string SecureScore { get; set; }
        /// <summary>Security Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings SecuritySetting { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings SecuritySettingEncryptionSetting { get; set; }
        /// <summary>Immutability Settings at vault level</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings SecuritySettingImmutabilitySetting { get; set; }
        /// <summary>Soft delete related settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings SecuritySettingSoftDeleteSetting { get; set; }
        /// <summary>Soft delete retention duration</summary>
        double? SoftDeleteSettingRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Off", "On", "AlwaysOn")]
        string SoftDeleteSettingState { get; set; }
        /// <summary>Storage Settings</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> StorageSetting { get; set; }

    }
}