// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>Object that includes all the content for single compliance result.</summary>
    [System.ComponentModel.TypeConverter(typeof(ComplianceReportItemTypeConverter))]
    public partial class ComplianceReportItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ComplianceReportItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CategoryName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).CategoryName = (string) content.GetValueForProperty("CategoryName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).CategoryName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlFamilyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlFamilyName = (string) content.GetValueForProperty("ControlFamilyName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlFamilyName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlId = (string) content.GetValueForProperty("ControlId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlId, global::System.Convert.ToString);
            }
            if (content.Contains("ControlName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlName = (string) content.GetValueForProperty("ControlName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlStatus = (string) content.GetValueForProperty("ControlStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResponsibilityTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityTitle = (string) content.GetValueForProperty("ResponsibilityTitle",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityTitle, global::System.Convert.ToString);
            }
            if (content.Contains("ResponsibilityDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityDescription = (string) content.GetValueForProperty("ResponsibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceOrigin = (string) content.GetValueForProperty("ResourceOrigin",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceOrigin, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatus = (string) content.GetValueForProperty("ResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatusChangeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatusChangeDate = (global::System.DateTime?) content.GetValueForProperty("ResourceStatusChangeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatusChangeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ComplianceReportItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CategoryName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).CategoryName = (string) content.GetValueForProperty("CategoryName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).CategoryName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlFamilyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlFamilyName = (string) content.GetValueForProperty("ControlFamilyName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlFamilyName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlId = (string) content.GetValueForProperty("ControlId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlId, global::System.Convert.ToString);
            }
            if (content.Contains("ControlName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlName = (string) content.GetValueForProperty("ControlName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlStatus = (string) content.GetValueForProperty("ControlStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ControlStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResponsibilityTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityTitle = (string) content.GetValueForProperty("ResponsibilityTitle",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityTitle, global::System.Convert.ToString);
            }
            if (content.Contains("ResponsibilityDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityDescription = (string) content.GetValueForProperty("ResponsibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResponsibilityDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceOrigin = (string) content.GetValueForProperty("ResourceOrigin",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceOrigin, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatus = (string) content.GetValueForProperty("ResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceStatusChangeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatusChangeDate = (global::System.DateTime?) content.GetValueForProperty("ResourceStatusChangeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItemInternal)this).ResourceStatusChangeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ComplianceReportItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ComplianceReportItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ComplianceReportItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ComplianceReportItem" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Object that includes all the content for single compliance result.
    [System.ComponentModel.TypeConverter(typeof(ComplianceReportItemTypeConverter))]
    public partial interface IComplianceReportItem

    {

    }
}