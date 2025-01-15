// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell;

    /// <summary>Describes the properties of an AzureLargeStorageInstance.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureLargeStorageInstancePropertiesTypeConverter))]
    public partial class AzureLargeStorageInstanceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureLargeStorageInstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StorageProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties) content.GetValueForProperty("StorageProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureLargeStorageInstanceUniqueIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).AzureLargeStorageInstanceUniqueIdentifier = (string) content.GetValueForProperty("AzureLargeStorageInstanceUniqueIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).AzureLargeStorageInstanceUniqueIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyProvisioningState = (string) content.GetValueForProperty("StoragePropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyStorageBillingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageBillingProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties) content.GetValueForProperty("StoragePropertyStorageBillingProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageBillingProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("StoragePropertyOfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyOfferingType = (string) content.GetValueForProperty("StoragePropertyOfferingType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyOfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageType = (string) content.GetValueForProperty("StoragePropertyStorageType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyGeneration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyGeneration = (string) content.GetValueForProperty("StoragePropertyGeneration",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyGeneration, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyHardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyHardwareType = (string) content.GetValueForProperty("StoragePropertyHardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyHardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyWorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyWorkloadType = (string) content.GetValueForProperty("StoragePropertyWorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyWorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertyBillingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertyBillingMode = (string) content.GetValueForProperty("StorageBillingPropertyBillingMode",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertyBillingMode, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertySku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertySku = (string) content.GetValueForProperty("StorageBillingPropertySku",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertySku, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureLargeStorageInstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StorageProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties) content.GetValueForProperty("StorageProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StoragePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureLargeStorageInstanceUniqueIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).AzureLargeStorageInstanceUniqueIdentifier = (string) content.GetValueForProperty("AzureLargeStorageInstanceUniqueIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).AzureLargeStorageInstanceUniqueIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyProvisioningState = (string) content.GetValueForProperty("StoragePropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyStorageBillingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageBillingProperty = (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageBillingProperties) content.GetValueForProperty("StoragePropertyStorageBillingProperty",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageBillingProperty, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("StoragePropertyOfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyOfferingType = (string) content.GetValueForProperty("StoragePropertyOfferingType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyOfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageType = (string) content.GetValueForProperty("StoragePropertyStorageType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyGeneration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyGeneration = (string) content.GetValueForProperty("StoragePropertyGeneration",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyGeneration, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyHardwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyHardwareType = (string) content.GetValueForProperty("StoragePropertyHardwareType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyHardwareType, global::System.Convert.ToString);
            }
            if (content.Contains("StoragePropertyWorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyWorkloadType = (string) content.GetValueForProperty("StoragePropertyWorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StoragePropertyWorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertyBillingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertyBillingMode = (string) content.GetValueForProperty("StorageBillingPropertyBillingMode",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertyBillingMode, global::System.Convert.ToString);
            }
            if (content.Contains("StorageBillingPropertySku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertySku = (string) content.GetValueForProperty("StorageBillingPropertySku",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstancePropertiesInternal)this).StorageBillingPropertySku, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureLargeStorageInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeStorageInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureLargeStorageInstanceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureLargeStorageInstanceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureLargeStorageInstanceProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeStorageInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Describes the properties of an AzureLargeStorageInstance.
    [System.ComponentModel.TypeConverter(typeof(AzureLargeStorageInstancePropertiesTypeConverter))]
    public partial interface IAzureLargeStorageInstanceProperties

    {

    }
}