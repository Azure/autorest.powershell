// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.PowerShell;

    /// <summary>The OS profile of the machines in the pool.</summary>
    [System.ComponentModel.TypeConverter(typeof(OSProfileTypeConverter))]
    public partial class OSProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OSProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OSProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OSProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OSProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OSProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SecretsManagementSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretsManagementSetting = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings) content.GetValueForProperty("SecretsManagementSetting",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretsManagementSetting, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogonType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).LogonType = (string) content.GetValueForProperty("LogonType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).LogonType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingObservedCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingObservedCertificate = (System.Collections.Generic.List<string>) content.GetValueForProperty("SecretManagementSettingObservedCertificate",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingObservedCertificate, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecretManagementSettingCertificateStoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreLocation = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreName = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingKeyExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingKeyExportable = (bool?) content.GetValueForProperty("SecretManagementSettingKeyExportable",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingKeyExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OSProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SecretsManagementSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretsManagementSetting = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings) content.GetValueForProperty("SecretsManagementSetting",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretsManagementSetting, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogonType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).LogonType = (string) content.GetValueForProperty("LogonType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).LogonType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingObservedCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingObservedCertificate = (System.Collections.Generic.List<string>) content.GetValueForProperty("SecretManagementSettingObservedCertificate",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingObservedCertificate, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecretManagementSettingCertificateStoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreLocation = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreName = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingCertificateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingKeyExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingKeyExportable = (bool?) content.GetValueForProperty("SecretManagementSettingKeyExportable",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfileInternal)this).SecretManagementSettingKeyExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The OS profile of the machines in the pool.
    [System.ComponentModel.TypeConverter(typeof(OSProfileTypeConverter))]
    public partial interface IOSProfile

    {

    }
}