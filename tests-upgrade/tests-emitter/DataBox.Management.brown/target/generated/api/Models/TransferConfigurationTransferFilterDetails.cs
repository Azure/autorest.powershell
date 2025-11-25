// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    /// </summary>
    public partial class TransferConfigurationTransferFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal
    {

        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFilePathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFilePathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFilePrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFilePrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFileShareList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetailFileShareList = value ?? null /* arrayOf */; }

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailBlobPathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailBlobPathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailBlobPrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailBlobPrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailContainerList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailContainerList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetailContainerList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Include" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails _include;

        /// <summary>Details of the filtering the transfer of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails Include { get => (this._include = this._include ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails()); set => this._include = value; }

        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IncludeDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).DataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).DataAccountType = value ?? null; }

        /// <summary>Details of the filter files to be used for data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).FilterFileDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).FilterFileDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Include</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal.Include { get => (this._include = this._include ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferFilterDetails()); set { {_include = value;} } }

        /// <summary>Internal Acessors for IncludeAzureFileFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal.IncludeAzureFileFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).AzureFileFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IncludeBlobFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetailsInternal.IncludeBlobFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetailsInternal)Include).BlobFilterDetail = value ?? null /* model class */; }

        /// <summary>
        /// Creates an new <see cref="TransferConfigurationTransferFilterDetails" /> instance.
        /// </summary>
        public TransferConfigurationTransferFilterDetails()
        {

        }
    }
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    public partial interface ITransferConfigurationTransferFilterDetails :
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
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the account of data.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string IncludeDataAccountType { get; set; }
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

    }
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    internal partial interface ITransferConfigurationTransferFilterDetailsInternal

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
        /// <summary>Details of the filtering the transfer of data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails Include { get; set; }
        /// <summary>Filter details to transfer Azure files.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails IncludeAzureFileFilterDetail { get; set; }
        /// <summary>Filter details to transfer blobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails IncludeBlobFilterDetail { get; set; }
        /// <summary>Type of the account of data.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string IncludeDataAccountType { get; set; }
        /// <summary>Details of the filter files to be used for data transfer.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get; set; }

    }
}