// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Details of the filtering the transfer of data.</summary>
    public partial class TransferFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal
    {

        /// <summary>Backing field for <see cref="AzureFileFilterDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails _azureFileFilterDetail;

        /// <summary>Filter details to transfer Azure files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails AzureFileFilterDetail { get => (this._azureFileFilterDetail = this._azureFileFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetails()); set => this._azureFileFilterDetail = value; }

        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FilePathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FilePathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FilePrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FilePrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FileShareList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetailsInternal)AzureFileFilterDetail).FileShareList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="BlobFilterDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails _blobFilterDetail;

        /// <summary>Filter details to transfer blobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails BlobFilterDetail { get => (this._blobFilterDetail = this._blobFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetails()); set => this._blobFilterDetail = value; }

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).BlobPathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).BlobPathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).BlobPrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).BlobPrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailContainerList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).ContainerList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetailsInternal)BlobFilterDetail).ContainerList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="DataAccountType" /> property.</summary>
        private string _dataAccountType;

        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataAccountType { get => this._dataAccountType; set => this._dataAccountType = value; }

        /// <summary>Backing field for <see cref="FilterFileDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> _filterFileDetail;

        /// <summary>Details of the filter files to be used for data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> FilterFileDetail { get => this._filterFileDetail; set => this._filterFileDetail = value; }

        /// <summary>Internal Acessors for AzureFileFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal.AzureFileFilterDetail { get => (this._azureFileFilterDetail = this._azureFileFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AzureFileFilterDetails()); set { {_azureFileFilterDetail = value;} } }

        /// <summary>Internal Acessors for BlobFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal.BlobFilterDetail { get => (this._blobFilterDetail = this._blobFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.BlobFilterDetails()); set { {_blobFilterDetail = value;} } }

        /// <summary>Creates an new <see cref="TransferFilterDetails" /> instance.</summary>
        public TransferFilterDetails()
        {

        }
    }
    /// Details of the filtering the transfer of data.
    public partial interface ITransferFilterDetails :
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
        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the account of data.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> FilterFileDetail { get; set; }

    }
    /// Details of the filtering the transfer of data.
    internal partial interface ITransferFilterDetailsInternal

    {
        /// <summary>Filter details to transfer Azure files.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails AzureFileFilterDetail { get; set; }
        /// <summary>List of full path of the files to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get; set; }
        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get; set; }
        /// <summary>List of file shares to be transferred.</summary>
        System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get; set; }
        /// <summary>Filter details to transfer blobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails BlobFilterDetail { get; set; }
        /// <summary>List of full path of the blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        System.Collections.Generic.List<string> BlobFilterDetailContainerList { get; set; }
        /// <summary>Type of the account of data.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string DataAccountType { get; set; }
        /// <summary>Details of the filter files to be used for data transfer.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> FilterFileDetail { get; set; }

    }
}