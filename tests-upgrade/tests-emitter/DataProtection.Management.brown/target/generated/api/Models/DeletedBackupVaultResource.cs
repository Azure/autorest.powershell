// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Deleted Backup Vault Resource (available from version 2025-09-01)</summary>
    public partial class DeletedBackupVaultResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ProxyResource();

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).AzureMonitorAlertSettingAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).AzureMonitorAlertSettingAlertsForAllJobFailure = value ?? null; }

        /// <summary>Security Level of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string BcdrSecurityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).BcdrSecurityLevel; }

        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossRegionRestoreSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).CrossRegionRestoreSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).CrossRegionRestoreSettingState = value ?? null; }

        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string CrossSubscriptionRestoreSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).CrossSubscriptionRestoreSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).CrossSubscriptionRestoreSettingState = value ?? null; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingInfrastructureEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingInfrastructureEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingInfrastructureEncryption = value ?? null; }

        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingState = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ImmutabilitySettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ImmutabilitySettingState = value ?? null; }

        /// <summary>Is vault protected by resource guard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? IsVaultProtectedByResourceGuard { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).IsVaultProtectedByResourceGuard; }

        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KekIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KekIdentityId = value ?? null; }

        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KekIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KekIdentityType = value ?? null; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KeyVaultPropertyKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).KeyVaultPropertyKeyUri = value ?? null; }

        /// <summary>Internal Acessors for BcdrSecurityLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.BcdrSecurityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).BcdrSecurityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).BcdrSecurityLevel = value ?? null; }

        /// <summary>Internal Acessors for EncryptionSettingKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.EncryptionSettingKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingKekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingKekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionSettingKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.EncryptionSettingKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).EncryptionSettingKeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.FeatureSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSettingCrossRegionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.FeatureSettingCrossRegionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSettingCrossRegionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSettingCrossRegionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSettingCrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).FeatureSettingCrossSubscriptionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IsVaultProtectedByResourceGuard</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.IsVaultProtectedByResourceGuard { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).IsVaultProtectedByResourceGuard; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).IsVaultProtectedByResourceGuard = value ?? default(bool); }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.MonitoringSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).MonitoringSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).MonitoringSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).MonitoringSettingAzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).MonitoringSettingAzureMonitorAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OriginalBackupVaultId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.OriginalBackupVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultId = value ?? null; }

        /// <summary>Internal Acessors for OriginalBackupVaultName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.OriginalBackupVaultName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultName = value ?? null; }

        /// <summary>Internal Acessors for OriginalBackupVaultResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.OriginalBackupVaultResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultResourcePath = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVault Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupVault()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ResourceDeletionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceDeletionInfo Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceDeletionInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ResourceDeletionInfoDeleteActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceDeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeleteActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeleteActivityId = value ?? null; }

        /// <summary>Internal Acessors for ResourceDeletionInfoDeletionTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceDeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeletionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeletionTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ResourceDeletionInfoScheduledPurgeTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceDeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoScheduledPurgeTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoScheduledPurgeTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ResourceMoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceMoveDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ResourceMoveDetailCompletionTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailCompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailCompletionTimeUtc = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailOperationId = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailSourceResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailSourceResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailSourceResourcePath = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailStartTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailStartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailStartTimeUtc = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveDetailTargetResourcePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailTargetResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailTargetResourcePath = value ?? null; }

        /// <summary>Internal Acessors for ResourceMoveState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.ResourceMoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveState = value ?? null; }

        /// <summary>Internal Acessors for SecureScore</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.SecureScore { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecureScore; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecureScore = value ?? null; }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.SecuritySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingEncryptionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.SecuritySettingEncryptionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingEncryptionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingEncryptionSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingImmutabilitySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingSoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultResourceInternal.SecuritySettingSoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingSoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecuritySettingSoftDeleteSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Resource Id of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string OriginalBackupVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultId; }

        /// <summary>Resource name of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string OriginalBackupVaultName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultName; }

        /// <summary>Resource path of the original backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string OriginalBackupVaultResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).OriginalBackupVaultResourcePath; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVault _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVault Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DeletedBackupVault()); set => this._property = value; }

        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ProvisioningState; }

        /// <summary>List of replicated regions for Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ReplicatedRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ReplicatedRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ReplicatedRegion = value ?? null /* arrayOf */; }

        /// <summary>Delete activity ID for troubleshooting the deletion of the tracked resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceDeletionInfoDeleteActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeleteActivityId; }

        /// <summary>Specifies time of deletion for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public global::System.DateTime? ResourceDeletionInfoDeletionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoDeletionTime; }

        /// <summary>Specifies the scheduled purge time for the tracked resource (Backup Vault)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public global::System.DateTime? ResourceDeletionInfoScheduledPurgeTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceDeletionInfoScheduledPurgeTime; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailCompletionTimeUtc; }

        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailOperationId; }

        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailSourceResourcePath; }

        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailStartTimeUtc; }

        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveDetailTargetResourcePath; }

        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).ResourceMoveState; }

        /// <summary>Secure Score of Backup Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string SecureScore { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SecureScore; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteSettingRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SoftDeleteSettingRetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SoftDeleteSettingRetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SoftDeleteSettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).SoftDeleteSettingState = value ?? null; }

        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> StorageSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).StorageSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVaultInternal)Property).StorageSetting = value ?? null /* arrayOf */; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="DeletedBackupVaultResource" /> instance.</summary>
        public DeletedBackupVaultResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Deleted Backup Vault Resource (available from version 2025-09-01)
    public partial interface IDeletedBackupVaultResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResource
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
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage Settings",
        SerializedName = @"storageSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IStorageSetting> StorageSetting { get; set; }

    }
    /// Deleted Backup Vault Resource (available from version 2025-09-01)
    internal partial interface IDeletedBackupVaultResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProxyResourceInternal
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDeletedBackupVault Property { get; set; }
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