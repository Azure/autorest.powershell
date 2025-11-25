// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Details of the data to be used for exporting data from azure.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataExportDetailsTypeConverter))]
    public partial class DataExportDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataExportDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TransferConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration) content.GetValueForProperty("TransferConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfiguration, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails) content.GetValueForProperty("AccountDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogCollectionLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).LogCollectionLevel = (string) content.GetValueForProperty("LogCollectionLevel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).LogCollectionLevel, global::System.Convert.ToString);
            }
            if (content.Contains("TransferConfigurationTransferFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails) content.GetValueForProperty("TransferConfigurationTransferFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferConfigurationTransferAllDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferAllDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails) content.GetValueForProperty("TransferConfigurationTransferAllDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferAllDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferAllDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationType = (string) content.GetValueForProperty("TransferConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("TransferFilterDetailInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailInclude = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails) content.GetValueForProperty("TransferFilterDetailInclude",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailInclude, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferAllDetailInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailInclude = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails) content.GetValueForProperty("TransferAllDetailInclude",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailInclude, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferAllDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountDetailDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailDataAccountType = (string) content.GetValueForProperty("AccountDetailDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("AccountDetailSharePassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailSharePassword = (System.Security.SecureString) content.GetValueForProperty("AccountDetailSharePassword",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailSharePassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferFilterDetailsIncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailsIncludeDataAccountType = (string) content.GetValueForProperty("TransferFilterDetailsIncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailsIncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeFilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("TransferAllDetailsIncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailsIncludeDataAccountType = (string) content.GetValueForProperty("TransferAllDetailsIncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailsIncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeTransferAllBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllBlob = (bool?) content.GetValueForProperty("IncludeTransferAllBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllBlob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IncludeTransferAllFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllFile = (bool?) content.GetValueForProperty("IncludeTransferAllFile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataExportDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TransferConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration) content.GetValueForProperty("TransferConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfiguration, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails) content.GetValueForProperty("AccountDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogCollectionLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).LogCollectionLevel = (string) content.GetValueForProperty("LogCollectionLevel",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).LogCollectionLevel, global::System.Convert.ToString);
            }
            if (content.Contains("TransferConfigurationTransferFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails) content.GetValueForProperty("TransferConfigurationTransferFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferConfigurationTransferAllDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferAllDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails) content.GetValueForProperty("TransferConfigurationTransferAllDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationTransferAllDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferAllDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferConfigurationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationType = (string) content.GetValueForProperty("TransferConfigurationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferConfigurationType, global::System.Convert.ToString);
            }
            if (content.Contains("TransferFilterDetailInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailInclude = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails) content.GetValueForProperty("TransferFilterDetailInclude",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailInclude, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferAllDetailInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailInclude = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails) content.GetValueForProperty("TransferAllDetailInclude",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailInclude, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferAllDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountDetailDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailDataAccountType = (string) content.GetValueForProperty("AccountDetailDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("AccountDetailSharePassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailSharePassword = (System.Security.SecureString) content.GetValueForProperty("AccountDetailSharePassword",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AccountDetailSharePassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferFilterDetailsIncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailsIncludeDataAccountType = (string) content.GetValueForProperty("TransferFilterDetailsIncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferFilterDetailsIncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeFilterFileDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("TransferAllDetailsIncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailsIncludeDataAccountType = (string) content.GetValueForProperty("TransferAllDetailsIncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).TransferAllDetailsIncludeDataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeTransferAllBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllBlob = (bool?) content.GetValueForProperty("IncludeTransferAllBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllBlob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IncludeTransferAllFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllFile = (bool?) content.GetValueForProperty("IncludeTransferAllFile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).IncludeTransferAllFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailContainerList = (System.Collections.Generic.List<string>) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePathList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFileShareList = (System.Collections.Generic.List<string>) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataExportDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataExportDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataExportDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataExportDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Details of the data to be used for exporting data from azure.
    [System.ComponentModel.TypeConverter(typeof(DataExportDetailsTypeConverter))]
    public partial interface IDataExportDetails

    {

    }
}