// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Backup Vault Contract for Patch Backup Vault API.</summary>
    public partial class PatchBackupVaultInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSettingAlertsForAllJobFailure = value ?? null; }

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

        /// <summary>Internal Acessors for EncryptionSettingKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.EncryptionSettingKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionSettingKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.EncryptionSettingKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSettingKeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.FeatureSettings()); set { {_featureSetting = value;} } }

        /// <summary>Internal Acessors for FeatureSettingCrossRegionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.FeatureSettingCrossRegionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettings()); set { {_monitoringSetting = value;} } }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings()); set { {_securitySetting = value;} } }

        /// <summary>Internal Acessors for SecuritySettingEncryptionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.SecuritySettingEncryptionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuritySettingSoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal.SecuritySettingSoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="MonitoringSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings _monitoringSetting;

        /// <summary>Monitoring Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettings()); set => this._monitoringSetting = value; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

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

        /// <summary>Creates an new <see cref="PatchBackupVaultInput" /> instance.</summary>
        public PatchBackupVaultInput()
        {

        }
    }
    /// Backup Vault Contract for Patch Backup Vault API.
    public partial interface IPatchBackupVaultInput :
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

    }
    /// Backup Vault Contract for Patch Backup Vault API.
    internal partial interface IPatchBackupVaultInputInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }
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
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        System.Collections.Generic.List<string> ResourceGuardOperationRequest { get; set; }
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

    }
}