// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Properties of the vault.</summary>
    [System.ComponentModel.TypeConverter(typeof(VaultPropertiesTypeConverter))]
    public partial class VaultProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VaultProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VaultProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VaultProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VaultProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VaultProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UpgradeDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails) content.GetValueForProperty("UpgradeDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesEncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails) content.GetValueForProperty("MoveDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesMoveDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings) content.GetValueForProperty("RestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RedundancySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings) content.GetValueForProperty("RedundancySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesRedundancySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointStateForBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForBackup = (string) content.GetValueForProperty("PrivateEndpointStateForBackup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForBackup, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointStateForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForSiteRecovery = (string) content.GetValueForProperty("PrivateEndpointStateForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForSiteRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("MoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveState = (string) content.GetValueForProperty("MoveState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveState, global::System.Convert.ToString);
            }
            if (content.Contains("BackupStorageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BackupStorageVersion = (string) content.GetValueForProperty("BackupStorageVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BackupStorageVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("SecureScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecureScore = (string) content.GetValueForProperty("SecureScore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecureScore, global::System.Convert.ToString);
            }
            if (content.Contains("BcdrSecurityLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BcdrSecurityLevel = (string) content.GetValueForProperty("BcdrSecurityLevel",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BcdrSecurityLevel, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("UpgradeDetailTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailTriggerType = (string) content.GetValueForProperty("UpgradeDetailTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailTriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailOperationId = (string) content.GetValueForProperty("UpgradeDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailLastUpdatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailLastUpdatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailLastUpdatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailLastUpdatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStatus = (string) content.GetValueForProperty("UpgradeDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailMessage = (string) content.GetValueForProperty("UpgradeDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailUpgradedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailUpgradedResourceId = (string) content.GetValueForProperty("UpgradeDetailUpgradedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailUpgradedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailPreviousResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailPreviousResourceId = (string) content.GetValueForProperty("UpgradeDetailPreviousResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailPreviousResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailOperationId = (string) content.GetValueForProperty("MoveDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("MoveDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MoveDetailCompletionTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailCompletionTimeUtc = (global::System.DateTime?) content.GetValueForProperty("MoveDetailCompletionTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailCompletionTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MoveDetailSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailSourceResourceId = (string) content.GetValueForProperty("MoveDetailSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailTargetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailTargetResourceId = (string) content.GetValueForProperty("MoveDetailTargetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailTargetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingClassicAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingClassicAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings) content.GetValueForProperty("MonitoringSettingClassicAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingClassicAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("RestoreSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RedundancySettingStandardTierStorageRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingStandardTierStorageRedundancy = (string) content.GetValueForProperty("RedundancySettingStandardTierStorageRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingStandardTierStorageRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("RedundancySettingCrossRegionRestore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingCrossRegionRestore = (string) content.GetValueForProperty("RedundancySettingCrossRegionRestore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingCrossRegionRestore, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingSoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings) content.GetValueForProperty("SecuritySettingSoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingSourceScanConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSourceScanConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration) content.GetValueForProperty("SecuritySettingSourceScanConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSourceScanConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingMultiUserAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingMultiUserAuthorization = (string) content.GetValueForProperty("SecuritySettingMultiUserAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingMultiUserAuthorization, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationState = (string) content.GetValueForProperty("SourceScanConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationState, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("KekIdentityUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("KekIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUserAssignedIdentity = (string) content.GetValueForProperty("KekIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUserAssignedIdentity, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllReplicationIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllReplicationIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllFailoverIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllFailoverIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingAlertsForCriticalOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingAlertsForCriticalOperation = (string) content.GetValueForProperty("ClassicAlertSettingAlertsForCriticalOperation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingAlertsForCriticalOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingEmailNotificationsForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery = (string) content.GetValueForProperty("ClassicAlertSettingEmailNotificationsForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState = (string) content.GetValueForProperty("CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteState = (string) content.GetValueForProperty("SoftDeleteSettingSoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteSettingSoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SoftDeleteSettingEnhancedSecurityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingEnhancedSecurityState = (string) content.GetValueForProperty("SoftDeleteSettingEnhancedSecurityState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingEnhancedSecurityState, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationSourceScanIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationSourceScanIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity) content.GetValueForProperty("SourceScanConfigurationSourceScanIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationSourceScanIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanIdentityOperationIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityOperationIdentityType = (string) content.GetValueForProperty("SourceScanIdentityOperationIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityOperationIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityUserAssignedIdentity = (string) content.GetValueForProperty("SourceScanIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityUserAssignedIdentity, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VaultProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UpgradeDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails) content.GetValueForProperty("UpgradeDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesEncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesMoveDetails) content.GetValueForProperty("MoveDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesMoveDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings) content.GetValueForProperty("RestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RedundancySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings) content.GetValueForProperty("RedundancySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesRedundancySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings) content.GetValueForProperty("SecuritySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointStateForBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForBackup = (string) content.GetValueForProperty("PrivateEndpointStateForBackup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForBackup, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointStateForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForSiteRecovery = (string) content.GetValueForProperty("PrivateEndpointStateForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PrivateEndpointStateForSiteRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("MoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveState = (string) content.GetValueForProperty("MoveState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveState, global::System.Convert.ToString);
            }
            if (content.Contains("BackupStorageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BackupStorageVersion = (string) content.GetValueForProperty("BackupStorageVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BackupStorageVersion, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("SecureScore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecureScore = (string) content.GetValueForProperty("SecureScore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecureScore, global::System.Convert.ToString);
            }
            if (content.Contains("BcdrSecurityLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BcdrSecurityLevel = (string) content.GetValueForProperty("BcdrSecurityLevel",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).BcdrSecurityLevel, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("UpgradeDetailTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailTriggerType = (string) content.GetValueForProperty("UpgradeDetailTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailTriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings) content.GetValueForProperty("SecuritySettingImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailOperationId = (string) content.GetValueForProperty("UpgradeDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailLastUpdatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailLastUpdatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailLastUpdatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailLastUpdatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailEndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("UpgradeDetailEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpgradeDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStatus = (string) content.GetValueForProperty("UpgradeDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailMessage = (string) content.GetValueForProperty("UpgradeDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailMessage, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailUpgradedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailUpgradedResourceId = (string) content.GetValueForProperty("UpgradeDetailUpgradedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailUpgradedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeDetailPreviousResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailPreviousResourceId = (string) content.GetValueForProperty("UpgradeDetailPreviousResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).UpgradeDetailPreviousResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).EncryptionInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailOperationId = (string) content.GetValueForProperty("MoveDetailOperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailStartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("MoveDetailStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MoveDetailCompletionTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailCompletionTimeUtc = (global::System.DateTime?) content.GetValueForProperty("MoveDetailCompletionTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailCompletionTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MoveDetailSourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailSourceResourceId = (string) content.GetValueForProperty("MoveDetailSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailSourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MoveDetailTargetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailTargetResourceId = (string) content.GetValueForProperty("MoveDetailTargetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MoveDetailTargetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSettingClassicAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingClassicAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings) content.GetValueForProperty("MonitoringSettingClassicAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).MonitoringSettingClassicAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestoreSettingCrossSubscriptionRestoreSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSettingCrossSubscriptionRestoreSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings) content.GetValueForProperty("RestoreSettingCrossSubscriptionRestoreSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RestoreSettingCrossSubscriptionRestoreSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CrossSubscriptionRestoreSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RedundancySettingStandardTierStorageRedundancy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingStandardTierStorageRedundancy = (string) content.GetValueForProperty("RedundancySettingStandardTierStorageRedundancy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingStandardTierStorageRedundancy, global::System.Convert.ToString);
            }
            if (content.Contains("RedundancySettingCrossRegionRestore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingCrossRegionRestore = (string) content.GetValueForProperty("RedundancySettingCrossRegionRestore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).RedundancySettingCrossRegionRestore, global::System.Convert.ToString);
            }
            if (content.Contains("SecuritySettingSoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings) content.GetValueForProperty("SecuritySettingSoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingSourceScanConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSourceScanConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration) content.GetValueForProperty("SecuritySettingSourceScanConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingSourceScanConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuritySettingMultiUserAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingMultiUserAuthorization = (string) content.GetValueForProperty("SecuritySettingMultiUserAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SecuritySettingMultiUserAuthorization, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationState = (string) content.GetValueForProperty("SourceScanConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationState, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityUseSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUseSystemAssignedIdentity = (bool?) content.GetValueForProperty("KekIdentityUseSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUseSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("KekIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUserAssignedIdentity = (string) content.GetValueForProperty("KekIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).KekIdentityUserAssignedIdentity, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllReplicationIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllReplicationIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllFailoverIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllFailoverIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingAlertsForCriticalOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingAlertsForCriticalOperation = (string) content.GetValueForProperty("ClassicAlertSettingAlertsForCriticalOperation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingAlertsForCriticalOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingEmailNotificationsForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery = (string) content.GetValueForProperty("ClassicAlertSettingEmailNotificationsForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState = (string) content.GetValueForProperty("CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteState = (string) content.GetValueForProperty("SoftDeleteSettingSoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteSettingSoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SoftDeleteSettingEnhancedSecurityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingEnhancedSecurityState = (string) content.GetValueForProperty("SoftDeleteSettingEnhancedSecurityState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SoftDeleteSettingEnhancedSecurityState, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationSourceScanIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationSourceScanIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity) content.GetValueForProperty("SourceScanConfigurationSourceScanIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanConfigurationSourceScanIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanIdentityOperationIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityOperationIdentityType = (string) content.GetValueForProperty("SourceScanIdentityOperationIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityOperationIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityUserAssignedIdentity = (string) content.GetValueForProperty("SourceScanIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesInternal)this).SourceScanIdentityUserAssignedIdentity, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Properties of the vault.
    [System.ComponentModel.TypeConverter(typeof(VaultPropertiesTypeConverter))]
    public partial interface IVaultProperties

    {

    }
}