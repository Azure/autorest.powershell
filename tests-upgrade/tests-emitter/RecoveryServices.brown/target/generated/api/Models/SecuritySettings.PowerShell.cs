// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Security Settings of the vault</summary>
    [System.ComponentModel.TypeConverter(typeof(SecuritySettingsTypeConverter))]
    public partial class SecuritySettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecuritySettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecuritySettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecuritySettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecuritySettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecuritySettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings) content.GetValueForProperty("ImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration) content.GetValueForProperty("SourceScanConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MultiUserAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).MultiUserAuthorization = (string) content.GetValueForProperty("MultiUserAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).MultiUserAuthorization, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationState = (string) content.GetValueForProperty("SourceScanConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationState, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteState = (string) content.GetValueForProperty("SoftDeleteSettingSoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteSettingSoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SoftDeleteSettingEnhancedSecurityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingEnhancedSecurityState = (string) content.GetValueForProperty("SoftDeleteSettingEnhancedSecurityState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingEnhancedSecurityState, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationSourceScanIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationSourceScanIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity) content.GetValueForProperty("SourceScanConfigurationSourceScanIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationSourceScanIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanIdentityOperationIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityOperationIdentityType = (string) content.GetValueForProperty("SourceScanIdentityOperationIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityOperationIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityUserAssignedIdentity = (string) content.GetValueForProperty("SourceScanIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityUserAssignedIdentity, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecuritySettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings) content.GetValueForProperty("ImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration) content.GetValueForProperty("SourceScanConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MultiUserAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).MultiUserAuthorization = (string) content.GetValueForProperty("MultiUserAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).MultiUserAuthorization, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationState = (string) content.GetValueForProperty("SourceScanConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationState, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteState = (string) content.GetValueForProperty("SoftDeleteSettingSoftDeleteState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingSoftDeleteRetentionPeriodInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay = (int?) content.GetValueForProperty("SoftDeleteSettingSoftDeleteRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingSoftDeleteRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SoftDeleteSettingEnhancedSecurityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingEnhancedSecurityState = (string) content.GetValueForProperty("SoftDeleteSettingEnhancedSecurityState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SoftDeleteSettingEnhancedSecurityState, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanConfigurationSourceScanIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationSourceScanIdentity = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity) content.GetValueForProperty("SourceScanConfigurationSourceScanIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanConfigurationSourceScanIdentity, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AssociatedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceScanIdentityOperationIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityOperationIdentityType = (string) content.GetValueForProperty("SourceScanIdentityOperationIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityOperationIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceScanIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityUserAssignedIdentity = (string) content.GetValueForProperty("SourceScanIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal)this).SourceScanIdentityUserAssignedIdentity, global::System.Convert.ToString);
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
    /// Security Settings of the vault
    [System.ComponentModel.TypeConverter(typeof(SecuritySettingsTypeConverter))]
    public partial interface ISecuritySettings

    {

    }
}