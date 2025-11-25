// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Information of the sku.</summary>
    [System.ComponentModel.TypeConverter(typeof(SkuInformationTypeConverter))]
    public partial class SkuInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SkuInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SkuInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkuInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SkuInformation" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SkuInformation(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuDisplayName = (string) content.GetValueForProperty("SkuDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuModel = (string) content.GetValueForProperty("SkuModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuModel, global::System.Convert.ToString);
            }
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataLocationToServiceLocationMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DataLocationToServiceLocationMap = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>) content.GetValueForProperty("DataLocationToServiceLocationMap",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DataLocationToServiceLocationMap, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataLocationToServiceLocationMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApiVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).ApiVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApiVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).ApiVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReason = (string) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReason, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).RequiredFeature = (string) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).RequiredFeature, global::System.Convert.ToString);
            }
            if (content.Contains("CountriesWithinCommerceBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CountriesWithinCommerceBoundary = (System.Collections.Generic.List<string>) content.GetValueForProperty("CountriesWithinCommerceBoundary",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CountriesWithinCommerceBoundary, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CapacityUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityUsable = (string) content.GetValueForProperty("CapacityUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityUsable, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityMaximum = (string) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityMaximum, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityIndividualSkuUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityIndividualSkuUsable = (string) content.GetValueForProperty("CapacityIndividualSkuUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityIndividualSkuUsable, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SkuInformation(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuDisplayName = (string) content.GetValueForProperty("SkuDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuModel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuModel = (string) content.GetValueForProperty("SkuModel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).SkuModel, global::System.Convert.ToString);
            }
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataLocationToServiceLocationMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DataLocationToServiceLocationMap = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>) content.GetValueForProperty("DataLocationToServiceLocationMap",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DataLocationToServiceLocationMap, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataLocationToServiceLocationMapTypeConverter.ConvertFrom));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApiVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).ApiVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApiVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).ApiVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReason = (string) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReason, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).RequiredFeature = (string) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).RequiredFeature, global::System.Convert.ToString);
            }
            if (content.Contains("CountriesWithinCommerceBoundary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CountriesWithinCommerceBoundary = (System.Collections.Generic.List<string>) content.GetValueForProperty("CountriesWithinCommerceBoundary",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CountriesWithinCommerceBoundary, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CapacityUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityUsable = (string) content.GetValueForProperty("CapacityUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityUsable, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityMaximum = (string) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityMaximum, global::System.Convert.ToString);
            }
            if (content.Contains("CapacityIndividualSkuUsable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityIndividualSkuUsable = (string) content.GetValueForProperty("CapacityIndividualSkuUsable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal)this).CapacityIndividualSkuUsable, global::System.Convert.ToString);
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
    /// Information of the sku.
    [System.ComponentModel.TypeConverter(typeof(SkuInformationTypeConverter))]
    public partial interface ISkuInformation

    {

    }
}