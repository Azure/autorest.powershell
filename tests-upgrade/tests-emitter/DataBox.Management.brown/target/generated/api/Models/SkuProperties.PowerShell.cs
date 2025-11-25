// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Properties of the sku.</summary>
    [System.ComponentModel.TypeConverter(typeof(SkuPropertiesTypeConverter))]
    public partial class SkuProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SkuProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SkuProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkuProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SkuProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SkuProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataLocationToServiceLocationMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DataLocationToServiceLocationMap = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>) content.GetValueForProperty("DataLocationToServiceLocationMap",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DataLocationToServiceLocationMap, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataLocationToServiceLocationMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApiVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).ApiVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApiVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).ApiVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReason = (string) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReason, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).RequiredFeature = (string) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).RequiredFeature, global::System.Convert.ToString);
            }
            if (content.Contains("CountriesWithinCommerceBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CountriesWithinCommerceBoundary = (System.Collections.Generic.List<string>) content.GetValueForProperty("CountriesWithinCommerceBoundary",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CountriesWithinCommerceBoundary, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CapacityUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityUsable = (string) content.GetValueForProperty("CapacityUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityUsable, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityMaximum = (string) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityMaximum, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityIndividualSkuUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityIndividualSkuUsable = (string) content.GetValueForProperty("CapacityIndividualSkuUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityIndividualSkuUsable, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SkuProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataLocationToServiceLocationMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DataLocationToServiceLocationMap = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>) content.GetValueForProperty("DataLocationToServiceLocationMap",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DataLocationToServiceLocationMap, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataLocationToServiceLocationMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApiVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).ApiVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApiVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).ApiVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReason = (string) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReason, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).RequiredFeature = (string) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).RequiredFeature, global::System.Convert.ToString);
            }
            if (content.Contains("CountriesWithinCommerceBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CountriesWithinCommerceBoundary = (System.Collections.Generic.List<string>) content.GetValueForProperty("CountriesWithinCommerceBoundary",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CountriesWithinCommerceBoundary, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CapacityUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityUsable = (string) content.GetValueForProperty("CapacityUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityUsable, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityMaximum = (string) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityMaximum, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityIndividualSkuUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityIndividualSkuUsable = (string) content.GetValueForProperty("CapacityIndividualSkuUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)this).CapacityIndividualSkuUsable, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the sku.
    [System.ComponentModel.TypeConverter(typeof(SkuPropertiesTypeConverter))]
    public partial interface ISkuProperties

    {

    }
}