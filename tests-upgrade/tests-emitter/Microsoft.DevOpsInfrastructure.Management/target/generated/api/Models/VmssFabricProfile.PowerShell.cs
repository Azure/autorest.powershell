// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.PowerShell;

    /// <summary>The agents will run on Virtual Machine Scale Sets.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmssFabricProfileTypeConverter))]
    public partial class VmssFabricProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.VmssFabricProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VmssFabricProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.VmssFabricProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VmssFabricProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VmssFabricProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VmssFabricProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.VmssFabricProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VmssFabricProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DevOpsAzureSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.StorageProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Image = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage>) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Image, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolImageTypeConverter.ConvertFrom));
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileLogonType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileLogonType = (string) content.GetValueForProperty("OSProfileLogonType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileLogonType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileDataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk>) content.GetValueForProperty("StorageProfileDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileDataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfileSubnetId = (string) content.GetValueForProperty("NetworkProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileSecretsManagementSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileSecretsManagementSetting = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings) content.GetValueForProperty("OSProfileSecretsManagementSetting",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileSecretsManagementSetting, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecretManagementSettingObservedCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingObservedCertificate = (System.Collections.Generic.List<string>) content.GetValueForProperty("SecretManagementSettingObservedCertificate",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingObservedCertificate, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("StorageProfileOSDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileOSDiskStorageAccountType = (string) content.GetValueForProperty("StorageProfileOSDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileOSDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreLocation = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreName = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingKeyExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingKeyExportable = (bool?) content.GetValueForProperty("SecretManagementSettingKeyExportable",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingKeyExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.VmssFabricProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VmssFabricProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDevOpsAzureSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DevOpsAzureSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.StorageProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.NetworkProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Image = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage>) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).Image, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolImageTypeConverter.ConvertFrom));
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfileInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileLogonType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileLogonType = (string) content.GetValueForProperty("OSProfileLogonType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileLogonType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageProfileDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileDataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk>) content.GetValueForProperty("StorageProfileDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileDataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.DataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfileSubnetId = (string) content.GetValueForProperty("NetworkProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).NetworkProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfileSecretsManagementSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileSecretsManagementSetting = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISecretsManagementSettings) content.GetValueForProperty("OSProfileSecretsManagementSetting",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).OSProfileSecretsManagementSetting, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.SecretsManagementSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecretManagementSettingObservedCertificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingObservedCertificate = (System.Collections.Generic.List<string>) content.GetValueForProperty("SecretManagementSettingObservedCertificate",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingObservedCertificate, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("StorageProfileOSDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileOSDiskStorageAccountType = (string) content.GetValueForProperty("StorageProfileOSDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).StorageProfileOSDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreLocation = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingCertificateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreName = (string) content.GetValueForProperty("SecretManagementSettingCertificateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingCertificateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretManagementSettingKeyExportable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingKeyExportable = (bool?) content.GetValueForProperty("SecretManagementSettingKeyExportable",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IVmssFabricProfileInternal)this).SecretManagementSettingKeyExportable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The agents will run on Virtual Machine Scale Sets.
    [System.ComponentModel.TypeConverter(typeof(VmssFabricProfileTypeConverter))]
    public partial interface IVmssFabricProfile

    {

    }
}