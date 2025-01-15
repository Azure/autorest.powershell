// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell;

    /// <summary>described the storage properties of the azure large storage instance</summary>
    [System.ComponentModel.TypeConverter(typeof(StoragePropertiesTypeConverter))]
    public partial class StorageProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="StorageProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StorageBillingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties) content.GetValueForProperty("StorageBillingProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("OfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).OfferingType = (string) content.GetValueForProperty("OfferingType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).OfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageType = (string) content.GetValueForProperty("StorageType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageType, global::System.Convert.ToString);
            }
            if (content.Contains("Generation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).Generation = (string) content.GetValueForProperty("Generation",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).Generation, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).HardwareType = (string) content.GetValueForProperty("HardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).HardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertyBillingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertyBillingMode = (string) content.GetValueForProperty("StorageBillingPropertyBillingMode",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertyBillingMode, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertySku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertySku = (string) content.GetValueForProperty("StorageBillingPropertySku",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertySku, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StorageBillingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties) content.GetValueForProperty("StorageBillingProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("OfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).OfferingType = (string) content.GetValueForProperty("OfferingType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).OfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageType = (string) content.GetValueForProperty("StorageType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageType, global::System.Convert.ToString);
            }
            if (content.Contains("Generation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).Generation = (string) content.GetValueForProperty("Generation",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).Generation, global::System.Convert.ToString);
            }
            if (content.Contains("HardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).HardwareType = (string) content.GetValueForProperty("HardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).HardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertyBillingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertyBillingMode = (string) content.GetValueForProperty("StorageBillingPropertyBillingMode",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertyBillingMode, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertySku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertySku = (string) content.GetValueForProperty("StorageBillingPropertySku",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStoragePropertiesInternal)this).StorageBillingPropertySku, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// described the storage properties of the azure large storage instance
    [System.ComponentModel.TypeConverter(typeof(StoragePropertiesTypeConverter))]
    public partial interface IStorageProperties

    {

    }
}