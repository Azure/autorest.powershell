// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>Fabric model properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(FabricModelPropertiesTypeConverter))]
    public partial class FabricModelProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FabricModelProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FabricModelProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FabricModelProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceEndpoint = (string) content.GetValueForProperty("ServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceResourceId = (string) content.GetValueForProperty("ServiceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FabricModelProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceEndpoint = (string) content.GetValueForProperty("ServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceResourceId = (string) content.GetValueForProperty("ServiceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).ServiceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FabricModelProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FabricModelProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Fabric model properties.
    [System.ComponentModel.TypeConverter(typeof(FabricModelPropertiesTypeConverter))]
    public partial interface IFabricModelProperties

    {

    }
}