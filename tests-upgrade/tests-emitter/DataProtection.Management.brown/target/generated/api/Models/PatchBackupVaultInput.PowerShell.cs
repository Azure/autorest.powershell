// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Backup Vault Contract for Patch Backup Vault API.</summary>
    [System.ComponentModel.TypeConverter(typeof(PatchBackupVaultInputTypeConverter))]
    public partial class PatchBackupVaultInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PatchBackupVaultInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PatchBackupVaultInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PatchBackupVaultInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PatchBackupVaultInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PatchBackupVaultInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PatchBackupVaultInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PatchBackupVaultInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PatchBackupVaultInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings) content.GetValueForProperty("FeatureSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.FeatureSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingEncryptionSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingEncryptionSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings) content.GetValueForProperty("SecuritySettingEncryptionSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingEncryptionSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingSoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingSoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings) content.GetValueForProperty("SecuritySettingSoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingSoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossRegionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossRegionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossRegionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossRegionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingState = (string) content.GetValueForProperty("SoftDeleteSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteSettingRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionSettingKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionSettingKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingState = (string) content.GetValueForProperty("EncryptionSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionSettingInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityType = (string) content.GetValueForProperty("KekIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("CrossSubscriptionRestoreSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossSubscriptionRestoreSettingState = (string) content.GetValueForProperty("CrossSubscriptionRestoreSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossSubscriptionRestoreSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossRegionRestoreSettingState = (string) content.GetValueForProperty("CrossRegionRestoreSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossRegionRestoreSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityId = (string) content.GetValueForProperty("KekIdentityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.PatchBackupVaultInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PatchBackupVaultInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IFeatureSettings) content.GetValueForProperty("FeatureSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.FeatureSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingEncryptionSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingEncryptionSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings) content.GetValueForProperty("SecuritySettingEncryptionSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingEncryptionSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingSoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingSoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings) content.GetValueForProperty("SecuritySettingSoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SecuritySettingSoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureSettingCrossRegionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossRegionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICrossRegionRestoreSettings) content.GetValueForProperty("FeatureSettingCrossRegionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).FeatureSettingCrossRegionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CrossRegionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingState = (string) content.GetValueForProperty("SoftDeleteSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteSettingRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).SoftDeleteSettingRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionSettingKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionSettingKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingState = (string) content.GetValueForProperty("EncryptionSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionSettingInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).EncryptionSettingInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityType = (string) content.GetValueForProperty("KekIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("CrossSubscriptionRestoreSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossSubscriptionRestoreSettingState = (string) content.GetValueForProperty("CrossSubscriptionRestoreSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossSubscriptionRestoreSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("CrossRegionRestoreSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossRegionRestoreSettingState = (string) content.GetValueForProperty("CrossRegionRestoreSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).CrossRegionRestoreSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityId = (string) content.GetValueForProperty("KekIdentityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IPatchBackupVaultInputInternal)this).KekIdentityId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Backup Vault Contract for Patch Backup Vault API.
    [System.ComponentModel.TypeConverter(typeof(PatchBackupVaultInputTypeConverter))]
    public partial interface IPatchBackupVaultInput

    {

    }
}