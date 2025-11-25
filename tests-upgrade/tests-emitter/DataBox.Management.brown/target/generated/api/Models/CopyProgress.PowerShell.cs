// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Copy progress.</summary>
    [System.ComponentModel.TypeConverter(typeof(CopyProgressTypeConverter))]
    public partial class CopyProgress
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CopyProgress(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).StorageAccountName = (string) content.GetValueForProperty("StorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).StorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TransferType = (string) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TransferType, global::System.Convert.ToString);
            }
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DataAccountType = (string) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("AccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AccountId, global::System.Convert.ToString);
            }
            if (content.Contains("BytesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).BytesProcessed = (long?) content.GetValueForProperty("BytesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).BytesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalBytesToProcess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalBytesToProcess = (long?) content.GetValueForProperty("TotalBytesToProcess",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalBytesToProcess, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FilesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesProcessed = (long?) content.GetValueForProperty("FilesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalFilesToProcess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalFilesToProcess = (long?) content.GetValueForProperty("TotalFilesToProcess",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalFilesToProcess, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidFilesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFilesProcessed = (long?) content.GetValueForProperty("InvalidFilesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFilesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidFileBytesUploaded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFileBytesUploaded = (long?) content.GetValueForProperty("InvalidFileBytesUploaded",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFileBytesUploaded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RenamedContainerCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).RenamedContainerCount = (long?) content.GetValueForProperty("RenamedContainerCount",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).RenamedContainerCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FilesErroredOut"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesErroredOut = (long?) content.GetValueForProperty("FilesErroredOut",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesErroredOut, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DirectoriesErroredOut"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DirectoriesErroredOut = (long?) content.GetValueForProperty("DirectoriesErroredOut",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DirectoriesErroredOut, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidDirectoriesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidDirectoriesProcessed = (long?) content.GetValueForProperty("InvalidDirectoriesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidDirectoriesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("IsEnumerationInProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).IsEnumerationInProgress = (bool?) content.GetValueForProperty("IsEnumerationInProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).IsEnumerationInProgress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Action = (System.Collections.Generic.List<string>) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Action, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CopyProgress(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("StorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).StorageAccountName = (string) content.GetValueForProperty("StorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).StorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TransferType = (string) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TransferType, global::System.Convert.ToString);
            }
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DataAccountType = (string) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DataAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("AccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AccountId, global::System.Convert.ToString);
            }
            if (content.Contains("BytesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).BytesProcessed = (long?) content.GetValueForProperty("BytesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).BytesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalBytesToProcess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalBytesToProcess = (long?) content.GetValueForProperty("TotalBytesToProcess",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalBytesToProcess, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FilesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesProcessed = (long?) content.GetValueForProperty("FilesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalFilesToProcess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalFilesToProcess = (long?) content.GetValueForProperty("TotalFilesToProcess",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).TotalFilesToProcess, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidFilesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFilesProcessed = (long?) content.GetValueForProperty("InvalidFilesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFilesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidFileBytesUploaded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFileBytesUploaded = (long?) content.GetValueForProperty("InvalidFileBytesUploaded",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidFileBytesUploaded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RenamedContainerCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).RenamedContainerCount = (long?) content.GetValueForProperty("RenamedContainerCount",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).RenamedContainerCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("FilesErroredOut"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesErroredOut = (long?) content.GetValueForProperty("FilesErroredOut",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).FilesErroredOut, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DirectoriesErroredOut"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DirectoriesErroredOut = (long?) content.GetValueForProperty("DirectoriesErroredOut",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).DirectoriesErroredOut, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InvalidDirectoriesProcessed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidDirectoriesProcessed = (long?) content.GetValueForProperty("InvalidDirectoriesProcessed",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).InvalidDirectoriesProcessed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("IsEnumerationInProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).IsEnumerationInProgress = (bool?) content.GetValueForProperty("IsEnumerationInProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).IsEnumerationInProgress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Action = (System.Collections.Generic.List<string>) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Action, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CopyProgress(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyProgress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CopyProgress(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CopyProgress" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CopyProgress" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Copy progress.
    [System.ComponentModel.TypeConverter(typeof(CopyProgressTypeConverter))]
    public partial interface ICopyProgress

    {

    }
}