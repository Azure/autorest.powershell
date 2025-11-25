// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Configuration for defining the transfer of data.</summary>
    public partial class TransferConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal
    {

        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFilePathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFilePathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFilePrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFilePrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFileShareList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).AzureFileFilterDetailFileShareList = value ?? null /* arrayOf */; }

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailBlobPathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailBlobPathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailBlobPrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailBlobPrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailContainerList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailContainerList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).BlobFilterDetailContainerList = value ?? null /* arrayOf */; }

        /// <summary>Details of the filter files to be used for data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeFilterFileDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeFilterFileDetail = value ?? null /* arrayOf */; }

        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IncludeTransferAllBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeTransferAllBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeTransferAllBlob = value ?? default(bool); }

        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IncludeTransferAllFile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeTransferAllFile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeTransferAllFile = value ?? default(bool); }

        /// <summary>Internal Acessors for IncludeAzureFileFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.IncludeAzureFileFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeAzureFileFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeAzureFileFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IncludeBlobFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.IncludeBlobFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeBlobFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeBlobFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferAllDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.TransferAllDetail { get => (this._transferAllDetail = this._transferAllDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferAllDetails()); set { {_transferAllDetail = value;} } }

        /// <summary>Internal Acessors for TransferAllDetailInclude</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.TransferAllDetailInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).Include; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).Include = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.TransferFilterDetail { get => (this._transferFilterDetail = this._transferFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails()); set { {_transferFilterDetail = value;} } }

        /// <summary>Internal Acessors for TransferFilterDetailInclude</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal.TransferFilterDetailInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).Include; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).Include = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="TransferAllDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails _transferAllDetail;

        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails TransferAllDetail { get => (this._transferAllDetail = this._transferAllDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferAllDetails()); set => this._transferAllDetail = value; }

        /// <summary>Type of the account of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferAllDetailsIncludeDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeDataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetailsInternal)TransferAllDetail).IncludeDataAccountType = value ?? null; }

        /// <summary>Backing field for <see cref="TransferFilterDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails _transferFilterDetail;

        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails TransferFilterDetail { get => (this._transferFilterDetail = this._transferFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfigurationTransferFilterDetails()); set => this._transferFilterDetail = value; }

        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferFilterDetailsIncludeDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeDataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal)TransferFilterDetail).IncludeDataAccountType = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the configuration for transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="TransferConfiguration" /> instance.</summary>
        public TransferConfiguration()
        {

        }
    }
    /// Configuration for defining the transfer of data.
    public partial interface ITransferConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of full path of the files to be transferred.",
        SerializedName = @"filePathList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get; set; }
        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Prefix list of the Azure files to be transferred.",
        SerializedName = @"filePrefixList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get; set; }
        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of file shares to be transferred.",
        SerializedName = @"fileShareList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get; set; }
        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of full path of the blobs to be transferred.",
        SerializedName = @"blobPathList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Prefix list of the Azure blobs to be transferred.",
        SerializedName = @"blobPrefixList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of blob containers to be transferred.",
        SerializedName = @"containerList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BlobFilterDetailContainerList { get; set; }
        /// <summary>Details of the filter files to be used for data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of the filter files to be used for data transfer.",
        SerializedName = @"filterFileDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get; set; }
        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To indicate if all Azure blobs have to be transferred",
        SerializedName = @"transferAllBlobs",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeTransferAllBlob { get; set; }
        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To indicate if all Azure Files have to be transferred",
        SerializedName = @"transferAllFiles",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeTransferAllFile { get; set; }
        /// <summary>Type of the account of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the account of data",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferAllDetailsIncludeDataAccountType { get; set; }
        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the account of data.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferFilterDetailsIncludeDataAccountType { get; set; }
        /// <summary>Type of the configuration for transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the configuration for transfer.",
        SerializedName = @"transferConfigurationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("TransferAll", "TransferUsingFilter")]
        string Type { get; set; }

    }
    /// Configuration for defining the transfer of data.
    internal partial interface ITransferConfigurationInternal

    {
        /// <summary>List of full path of the files to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get; set; }
        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get; set; }
        /// <summary>List of file shares to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get; set; }
        /// <summary>List of full path of the blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailContainerList { get; set; }
        /// <summary>Filter details to transfer Azure files.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails IncludeAzureFileFilterDetail { get; set; }
        /// <summary>Filter details to transfer blobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails IncludeBlobFilterDetail { get; set; }
        /// <summary>Details of the filter files to be used for data transfer.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get; set; }
        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        bool? IncludeTransferAllBlob { get; set; }
        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        bool? IncludeTransferAllFile { get; set; }
        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails TransferAllDetail { get; set; }
        /// <summary>Details to transfer all data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails TransferAllDetailInclude { get; set; }
        /// <summary>Type of the account of data</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferAllDetailsIncludeDataAccountType { get; set; }
        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails TransferFilterDetail { get; set; }
        /// <summary>Details of the filtering the transfer of data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails TransferFilterDetailInclude { get; set; }
        /// <summary>Type of the account of data.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferFilterDetailsIncludeDataAccountType { get; set; }
        /// <summary>Type of the configuration for transfer.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("TransferAll", "TransferUsingFilter")]
        string Type { get; set; }

    }
}