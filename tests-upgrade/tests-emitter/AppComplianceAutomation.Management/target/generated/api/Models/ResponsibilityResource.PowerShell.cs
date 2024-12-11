// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>A class represent the resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResponsibilityResourceTypeConverter))]
    public partial class ResponsibilityResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResponsibilityResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResponsibilityResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResponsibilityResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ResponsibilityResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResponsibilityResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).AccountId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceOrigin = (string) content.GetValueForProperty("ResourceOrigin",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceOrigin, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatus = (string) content.GetValueForProperty("ResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatusChangeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatusChangeDate = (global::System.DateTime?) content.GetValueForProperty("ResourceStatusChangeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatusChangeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecommendationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).RecommendationId = (System.Collections.Generic.List<string>) content.GetValueForProperty("RecommendationId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).RecommendationId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResponsibilityResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).AccountId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceOrigin = (string) content.GetValueForProperty("ResourceOrigin",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceOrigin, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatus = (string) content.GetValueForProperty("ResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatusChangeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatusChangeDate = (global::System.DateTime?) content.GetValueForProperty("ResourceStatusChangeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).ResourceStatusChangeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecommendationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).RecommendationId = (System.Collections.Generic.List<string>) content.GetValueForProperty("RecommendationId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal)this).RecommendationId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A class represent the resource.
    [System.ComponentModel.TypeConverter(typeof(ResponsibilityResourceTypeConverter))]
    public partial interface IResponsibilityResource

    {

    }
}