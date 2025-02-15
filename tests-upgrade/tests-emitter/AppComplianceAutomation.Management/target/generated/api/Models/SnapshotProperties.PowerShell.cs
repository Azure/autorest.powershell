// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>Snapshot's properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(SnapshotPropertiesTypeConverter))]
    public partial class SnapshotProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SnapshotProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SnapshotProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SnapshotProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SnapshotProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SnapshotProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ReportSystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData) content.GetValueForProperty("ReportSystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemData, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).SnapshotName = (string) content.GetValueForProperty("SnapshotName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).SnapshotName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ComplianceResult = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult>) content.GetValueForProperty("ComplianceResult",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ComplianceResult, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReportProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportProperty = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties) content.GetValueForProperty("ReportProperty",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportProperty, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReportSystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedBy = (string) content.GetValueForProperty("ReportSystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedByType = (string) content.GetValueForProperty("ReportSystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("ReportSystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReportSystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedBy = (string) content.GetValueForProperty("ReportSystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedByType = (string) content.GetValueForProperty("ReportSystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("ReportSystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SnapshotProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ReportSystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData) content.GetValueForProperty("ReportSystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemData, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).SnapshotName = (string) content.GetValueForProperty("SnapshotName",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).SnapshotName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceResult"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ComplianceResult = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult>) content.GetValueForProperty("ComplianceResult",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ComplianceResult, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceResultTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReportProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportProperty = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties) content.GetValueForProperty("ReportProperty",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportProperty, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ReportPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReportSystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedBy = (string) content.GetValueForProperty("ReportSystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedByType = (string) content.GetValueForProperty("ReportSystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("ReportSystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ReportSystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedBy = (string) content.GetValueForProperty("ReportSystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedByType = (string) content.GetValueForProperty("ReportSystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("ReportSystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("ReportSystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)this).ReportSystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
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
    /// Snapshot's properties.
    [System.ComponentModel.TypeConverter(typeof(SnapshotPropertiesTypeConverter))]
    public partial interface ISnapshotProperties

    {

    }
}