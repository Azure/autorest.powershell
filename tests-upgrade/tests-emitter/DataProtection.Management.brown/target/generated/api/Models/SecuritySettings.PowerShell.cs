// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Class containing security settings of vault</summary>
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecuritySettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecuritySettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecuritySettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecuritySettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings"
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
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings) content.GetValueForProperty("ImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings) content.GetValueForProperty("EncryptionSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingState = (string) content.GetValueForProperty("SoftDeleteSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteSettingRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionSettingKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionSettingKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingState = (string) content.GetValueForProperty("EncryptionSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionSettingInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityType = (string) content.GetValueForProperty("KekIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityId = (string) content.GetValueForProperty("KekIdentityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SecuritySettings"
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
            if (content.Contains("SoftDeleteSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings) content.GetValueForProperty("SoftDeleteSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImmutabilitySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings) content.GetValueForProperty("ImmutabilitySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings) content.GetValueForProperty("EncryptionSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeleteSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingState = (string) content.GetValueForProperty("SoftDeleteSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("SoftDeleteSettingRetentionDurationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingRetentionDurationInDay = (double?) content.GetValueForProperty("SoftDeleteSettingRetentionDurationInDay",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).SoftDeleteSettingRetentionDurationInDay, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("ImmutabilitySettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState = (string) content.GetValueForProperty("ImmutabilitySettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).ImmutabilitySettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties) content.GetValueForProperty("EncryptionSettingKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingKekIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKekIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity) content.GetValueForProperty("EncryptionSettingKekIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingKekIdentity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionSettingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingState = (string) content.GetValueForProperty("EncryptionSettingState",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionSettingInfrastructureEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingInfrastructureEncryption = (string) content.GetValueForProperty("EncryptionSettingInfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).EncryptionSettingInfrastructureEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityType = (string) content.GetValueForProperty("KekIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KeyVaultPropertyKeyUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyUri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KeyVaultPropertyKeyUri, global::System.Convert.ToString);
            }
            if (content.Contains("KekIdentityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityId = (string) content.GetValueForProperty("KekIdentityId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal)this).KekIdentityId, global::System.Convert.ToString);
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
    /// Class containing security settings of vault
    [System.ComponentModel.TypeConverter(typeof(SecuritySettingsTypeConverter))]
    public partial interface ISecuritySettings

    {

    }
}