// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.PowerShell;

    /// <summary>Solution PatchRequest body</summary>
    [System.ComponentModel.TypeConverter(typeof(SolutionPatchRequestBodyTypeConverter))]
    public partial class SolutionPatchRequestBody
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionPatchRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SolutionPatchRequestBody(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionPatchRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SolutionPatchRequestBody(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SolutionPatchRequestBody" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SolutionPatchRequestBody" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBody FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionPatchRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SolutionPatchRequestBody(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplacementMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMap = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMaps) content.GetValueForProperty("ReplacementMap",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMap, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ReplacementMapsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TriggerCriterion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).TriggerCriterion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion>) content.GetValueForProperty("TriggerCriterion",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).TriggerCriterion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TriggerCriterionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).SolutionId = (string) content.GetValueForProperty("SolutionId",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).SolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("Section"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Section = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection>) content.GetValueForProperty("Section",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Section, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapWebResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapWebResult = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult>) content.GetValueForProperty("ReplacementMapWebResult",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapWebResult, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.WebResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapDiagnostic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapDiagnostic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic>) content.GetValueForProperty("ReplacementMapDiagnostic",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapDiagnostic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionsDiagnosticTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapTroubleshooter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapTroubleshooter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters>) content.GetValueForProperty("ReplacementMapTroubleshooter",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapTroubleshooter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionsTroubleshootersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapVideo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo>) content.GetValueForProperty("ReplacementMapVideo",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.VideoTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapVideoGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideoGroup = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup>) content.GetValueForProperty("ReplacementMapVideoGroup",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideoGroup, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.VideoGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapMetricsBasedChart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapMetricsBasedChart = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart>) content.GetValueForProperty("ReplacementMapMetricsBasedChart",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapMetricsBasedChart, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.MetricsBasedChartTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionPatchRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SolutionPatchRequestBody(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplacementMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMap = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMaps) content.GetValueForProperty("ReplacementMap",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMap, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ReplacementMapsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TriggerCriterion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).TriggerCriterion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion>) content.GetValueForProperty("TriggerCriterion",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).TriggerCriterion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITriggerCriterion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.TriggerCriterionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).SolutionId = (string) content.GetValueForProperty("SolutionId",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).SolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("Section"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Section = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection>) content.GetValueForProperty("Section",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).Section, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapWebResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapWebResult = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult>) content.GetValueForProperty("ReplacementMapWebResult",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapWebResult, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.WebResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapDiagnostic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapDiagnostic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic>) content.GetValueForProperty("ReplacementMapDiagnostic",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapDiagnostic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsDiagnostic>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionsDiagnosticTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapTroubleshooter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapTroubleshooter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters>) content.GetValueForProperty("ReplacementMapTroubleshooter",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapTroubleshooter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsTroubleshooters>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionsTroubleshootersTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapVideo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo>) content.GetValueForProperty("ReplacementMapVideo",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.VideoTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapVideoGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideoGroup = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup>) content.GetValueForProperty("ReplacementMapVideoGroup",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapVideoGroup, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.VideoGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReplacementMapMetricsBasedChart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapMetricsBasedChart = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart>) content.GetValueForProperty("ReplacementMapMetricsBasedChart",((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionPatchRequestBodyInternal)this).ReplacementMapMetricsBasedChart, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IMetricsBasedChart>(__y, Microsoft.Azure.PowerShell.Cmdlets.Help.Models.MetricsBasedChartTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Solution PatchRequest body
    [System.ComponentModel.TypeConverter(typeof(SolutionPatchRequestBodyTypeConverter))]
    public partial interface ISolutionPatchRequestBody

    {

    }
}