// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(TransferConfigurationTransferFilterDetailsTypeConverter))]
    public partial class TransferConfigurationTransferFilterDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TransferConfigurationTransferFilterDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TransferConfigurationTransferFilterDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TransferConfigurationTransferFilterDetails" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="TransferConfigurationTransferFilterDetails" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TransferConfigurationTransferFilterDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Include"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).Include = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails) content.GetValueForProperty("Include",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).Include, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType = (string) content.GetValueForProperty("IncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TransferConfigurationTransferFilterDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Include"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).Include = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails) content.GetValueForProperty("Include",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).Include, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType = (string) content.GetValueForProperty("IncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    [System.ComponentModel.TypeConverter(typeof(TransferConfigurationTransferFilterDetailsTypeConverter))]
    public partial interface ITransferConfigurationTransferFilterDetails

    {

    }
}