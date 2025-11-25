// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Details of the filtering the transfer of data.</summary>
    [System.ComponentModel.TypeConverter(typeof(TransferFilterDetailsTypeConverter))]
    public partial class TransferFilterDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TransferFilterDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TransferFilterDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TransferFilterDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TransferFilterDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TransferFilterDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("BlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("BlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("AzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).DataAccountType = (string) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).DataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("FilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).FilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("FilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).FilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TransferFilterDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("BlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("BlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("AzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).DataAccountType = (string) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).DataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("FilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).FilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("FilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).FilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Details of the filtering the transfer of data.
    [System.ComponentModel.TypeConverter(typeof(TransferFilterDetailsTypeConverter))]
    public partial interface ITransferFilterDetails

    {

    }
}