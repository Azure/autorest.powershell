// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Monitoring Settings of the vault</summary>
    [System.ComponentModel.TypeConverter(typeof(MonitoringSettingsTypeConverter))]
    public partial class MonitoringSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonitoringSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonitoringSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonitoringSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MonitoringSettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonitoringSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("AzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClassicAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings) content.GetValueForProperty("ClassicAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllReplicationIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllReplicationIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllFailoverIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllFailoverIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingAlertsForCriticalOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingAlertsForCriticalOperation = (string) content.GetValueForProperty("ClassicAlertSettingAlertsForCriticalOperation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingAlertsForCriticalOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingEmailNotificationsForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery = (string) content.GetValueForProperty("ClassicAlertSettingEmailNotificationsForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonitoringSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings) content.GetValueForProperty("AzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClassicAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings) content.GetValueForProperty("ClassicAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllJobFailure, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllReplicationIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllReplicationIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllReplicationIssue, global::System.Convert.ToString);
            }
            if (content.Contains("AzureMonitorAlertSettingAlertsForAllFailoverIssue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue = (string) content.GetValueForProperty("AzureMonitorAlertSettingAlertsForAllFailoverIssue",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).AzureMonitorAlertSettingAlertsForAllFailoverIssue, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingAlertsForCriticalOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingAlertsForCriticalOperation = (string) content.GetValueForProperty("ClassicAlertSettingAlertsForCriticalOperation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingAlertsForCriticalOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ClassicAlertSettingEmailNotificationsForSiteRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery = (string) content.GetValueForProperty("ClassicAlertSettingEmailNotificationsForSiteRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal)this).ClassicAlertSettingEmailNotificationsForSiteRecovery, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    }
    /// Monitoring Settings of the vault
    [System.ComponentModel.TypeConverter(typeof(MonitoringSettingsTypeConverter))]
    public partial interface IMonitoringSettings

    {

    }
}