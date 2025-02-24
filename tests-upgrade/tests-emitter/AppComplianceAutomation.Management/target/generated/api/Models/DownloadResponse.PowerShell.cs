// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>Object that includes all the possible response for the download operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(DownloadResponseTypeConverter))]
    public partial class DownloadResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DownloadResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DownloadResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DownloadResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CompliancePdfReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReport = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport) content.GetValueForProperty("CompliancePdfReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReport, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseCompliancePdfReportTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComplianceDetailedPdfReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReport = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport) content.GetValueForProperty("ComplianceDetailedPdfReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReport, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseComplianceDetailedPdfReportTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ResourceList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem>) content.GetValueForProperty("ResourceList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ResourceList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResourceItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("ComplianceReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceReport = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem>) content.GetValueForProperty("ComplianceReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceReport, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("CompliancePdfReportSasUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReportSasUri = (string) content.GetValueForProperty("CompliancePdfReportSasUri",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReportSasUri, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceDetailedPdfReportSasUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReportSasUri = (string) content.GetValueForProperty("ComplianceDetailedPdfReportSasUri",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReportSasUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DownloadResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CompliancePdfReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReport = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseCompliancePdfReport) content.GetValueForProperty("CompliancePdfReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReport, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseCompliancePdfReportTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComplianceDetailedPdfReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReport = (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseComplianceDetailedPdfReport) content.GetValueForProperty("ComplianceDetailedPdfReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReport, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseComplianceDetailedPdfReportTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ResourceList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem>) content.GetValueForProperty("ResourceList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ResourceList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResourceItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("ComplianceReport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceReport = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem>) content.GetValueForProperty("ComplianceReport",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceReport, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("CompliancePdfReportSasUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReportSasUri = (string) content.GetValueForProperty("CompliancePdfReportSasUri",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).CompliancePdfReportSasUri, global::System.Convert.ToString);
            }
            if (content.Contains("ComplianceDetailedPdfReportSasUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReportSasUri = (string) content.GetValueForProperty("ComplianceDetailedPdfReportSasUri",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponseInternal)this).ComplianceDetailedPdfReportSasUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DownloadResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DownloadResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Object that includes all the possible response for the download operation.
    [System.ComponentModel.TypeConverter(typeof(DownloadResponseTypeConverter))]
    public partial interface IDownloadResponse

    {

    }
}