// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Patch Resource information, as returned by the resource provider.</summary>
    public partial class PatchVault :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVault,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResource __patchTrackedResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PatchTrackedResource();

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllFailoverIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllFailoverIssue = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllJobFailure = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllReplicationIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).AzureMonitorAlertSettingAlertsForAllReplicationIssue = value ?? null; }

        /// <summary>Backup storage version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string BackupStorageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BackupStorageVersion; }

        /// <summary>
        /// Security levels of Recovery Services Vault for business continuity and disaster recovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string BcdrSecurityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BcdrSecurityLevel; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingAlertsForCriticalOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ClassicAlertSettingAlertsForCriticalOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ClassicAlertSettingAlertsForCriticalOperation = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingEmailNotificationsForSiteRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ClassicAlertSettingEmailNotificationsForSiteRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ClassicAlertSettingEmailNotificationsForSiteRecovery = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState = value ?? null; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string EncryptionInfrastructureEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionInfrastructureEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionInfrastructureEncryption = value ?? null; }

        /// <summary>Optional ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Etag = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityData _identity;

        /// <summary>Identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityData Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IdentityData()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).TenantId; }

        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).Type = value ?? null; }

        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ImmutabilitySettingState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ImmutabilitySettingState = value ?? null; }

        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public bool? KekIdentityUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KekIdentityUseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KekIdentityUseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KekIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KekIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KekIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KeyVaultPropertyKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).KeyVaultPropertyKeyUri = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for BackupStorageVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.BackupStorageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BackupStorageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BackupStorageVersion = value ?? null; }

        /// <summary>Internal Acessors for BcdrSecurityLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.BcdrSecurityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BcdrSecurityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).BcdrSecurityLevel = value ?? null; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.Encryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).Encryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).Encryption = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.EncryptionKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionKekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionKekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.EncryptionKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).EncryptionKeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IdentityData()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MonitoringSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSettingAzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSettingAzureMonitorAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSettingClassicAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MonitoringSettingClassicAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSettingClassicAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MonitoringSettingClassicAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MoveDetailCompletionTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailCompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailCompletionTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MoveDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailOperationId = value ?? null; }

        /// <summary>Internal Acessors for MoveDetailSourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetailSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailSourceResourceId = value ?? null; }

        /// <summary>Internal Acessors for MoveDetailStartTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailStartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailStartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MoveDetailTargetResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveDetailTargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailTargetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailTargetResourceId = value ?? null; }

        /// <summary>Internal Acessors for MoveState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.MoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveState = value ?? null; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for PrivateEndpointStateForBackup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.PrivateEndpointStateForBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForBackup = value ?? null; }

        /// <summary>Internal Acessors for PrivateEndpointStateForSiteRecovery</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.PrivateEndpointStateForSiteRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForSiteRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForSiteRecovery = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for RedundancySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.RedundancySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.RestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RestoreSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.RestoreSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RestoreSettingCrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RestoreSettingCrossSubscriptionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecureScore</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecureScore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecureScore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecureScore = value ?? null; }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecuritySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingImmutabilitySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingMultiUserAuthorization</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecuritySettingMultiUserAuthorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingMultiUserAuthorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingMultiUserAuthorization = value ?? null; }

        /// <summary>Internal Acessors for SecuritySettingSoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecuritySettingSoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingSoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingSoftDeleteSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingSourceScanConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SecuritySettingSourceScanConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingSourceScanConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingSourceScanConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SourceScanConfigurationSourceScanIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.SourceScanConfigurationSourceScanIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanConfigurationSourceScanIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanConfigurationSourceScanIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradeDetailEndTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailEndTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailEndTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailLastUpdatedTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailLastUpdatedTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailLastUpdatedTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailLastUpdatedTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailOperationId = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailPreviousResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailPreviousResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailPreviousResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailPreviousResourceId = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailStartTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for UpgradeDetailStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStatus = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailTriggerType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailTriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailTriggerType = value ?? null; }

        /// <summary>Internal Acessors for UpgradeDetailUpgradedResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchVaultInternal.UpgradeDetailUpgradedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailUpgradedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailUpgradedResourceId = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Type = value ?? null; }

        /// <summary>End Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? MoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailCompletionTimeUtc; }

        /// <summary>OperationId of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailOperationId; }

        /// <summary>Source Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailSourceResourceId; }

        /// <summary>Start Time of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? MoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailStartTimeUtc; }

        /// <summary>Target Resource of the Resource Move Operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveDetailTargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveDetailTargetResourceId; }

        /// <summary>The State of the Resource after the move operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string MoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).MoveState; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Name; }

        /// <summary>List of private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties> PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Private endpoint state for backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateEndpointStateForBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForBackup; }

        /// <summary>Private endpoint state for site recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrivateEndpointStateForSiteRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PrivateEndpointStateForSiteRecovery; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties _property;

        /// <summary>Properties of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties()); set => this._property = value; }

        /// <summary>Provisioning State.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// property to enable or disable resource provider inbound network traffic from public clients
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string RedundancySettingCrossRegionRestore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySettingCrossRegionRestore; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySettingCrossRegionRestore = value ?? null; }

        /// <summary>The storage redundancy setting of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string RedundancySettingStandardTierStorageRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySettingStandardTierStorageRedundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).RedundancySettingStandardTierStorageRedundancy = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Secure Score of Recovery Services Vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SecureScore { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecureScore; }

        /// <summary>MUA Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SecuritySettingMultiUserAuthorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SecuritySettingMultiUserAuthorization; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISku _sku;

        /// <summary>Identifies the unique system identifier for each Azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Sku()); set => this._sku = value; }

        /// <summary>The sku capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Capacity = value ?? null; }

        /// <summary>The sku family</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Family = value ?? null; }

        /// <summary>
        /// Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage
        /// redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>The sku size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SkuSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Size; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Size = value ?? null; }

        /// <summary>The Sku tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISkuInternal)Sku).Tier = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingEnhancedSecurityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingEnhancedSecurityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingEnhancedSecurityState = value ?? null; }

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingSoftDeleteRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingSoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingSoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SoftDeleteSettingSoftDeleteState = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanConfigurationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanConfigurationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanConfigurationState = value ?? null; }

        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityOperationIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanIdentityOperationIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanIdentityOperationIdentityType = value ?? null; }

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).SourceScanIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal)__patchTrackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__patchTrackedResource).Type; }

        /// <summary>UTC time at which the upgrade operation has ended.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailEndTimeUtc; }

        /// <summary>UTC time at which the upgrade operation status was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailLastUpdatedTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailLastUpdatedTimeUtc; }

        /// <summary>Message to the user containing information about the upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailMessage; }

        /// <summary>ID of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailOperationId; }

        /// <summary>Resource ID of the vault before the upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailPreviousResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailPreviousResourceId; }

        /// <summary>UTC time at which the upgrade operation has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpgradeDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStartTimeUtc; }

        /// <summary>Status of the vault upgrade operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailStatus; }

        /// <summary>The way the vault upgrade was triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailTriggerType; }

        /// <summary>Resource ID of the upgraded vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string UpgradeDetailUpgradedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)Property).UpgradeDetailUpgradedResourceId; }

        /// <summary>Creates an new <see cref="PatchVault" /> instance.</summary>
        public PatchVault()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__patchTrackedResource), __patchTrackedResource);
            await eventListener.AssertObjectIsValid(nameof(__patchTrackedResource), __patchTrackedResource);
        }
    }
    /// Patch Resource information, as returned by the resource provider.
    public partial interface IPatchVault :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResource
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
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "None", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

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
        /// <summary>The sku capacity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku capacity",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(string) })]
        string SkuCapacity { get; set; }
        /// <summary>The sku family</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku family",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get; set; }
        /// <summary>
        /// Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage
        /// redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Standard", "RS0")]
        string SkuName { get; set; }
        /// <summary>The sku size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku size",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        string SkuSize { get; set; }
        /// <summary>The Sku tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Sku tier.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }

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
    /// Patch Resource information, as returned by the resource provider.
    internal partial interface IPatchVaultInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPatchTrackedResourceInternal
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
        /// <summary>Identity for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityData Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity
        /// and a set of user-assigned identities. The type 'None' will remove any identities.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "None", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

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
        /// <summary>Properties of the vault.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties Property { get; set; }
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
        /// <summary>Identifies the unique system identifier for each Azure resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISku Sku { get; set; }
        /// <summary>The sku capacity</summary>
        string SkuCapacity { get; set; }
        /// <summary>The sku family</summary>
        string SkuFamily { get; set; }
        /// <summary>
        /// Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage
        /// redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Standard", "RS0")]
        string SkuName { get; set; }
        /// <summary>The sku size</summary>
        string SkuSize { get; set; }
        /// <summary>The Sku tier.</summary>
        string SkuTier { get; set; }

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