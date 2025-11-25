// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Details of the data to be used for exporting data from azure.</summary>
    public partial class DataExportDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal
    {

        /// <summary>Backing field for <see cref="AccountDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails _accountDetail;

        /// <summary>Account details of the data to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails AccountDetail { get => (this._accountDetail = this._accountDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetails()); set => this._accountDetail = value; }

        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string AccountDetailDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).DataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).DataAccountType = value ; }

        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Security.SecureString AccountDetailSharePassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).SharePassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetailsInternal)AccountDetail).SharePassword = value ?? null; }

        /// <summary>List of full path of the files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFilePathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFilePathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure files to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFilePrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFilePrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFilePrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of file shares to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AzureFileFilterDetailFileShareList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFileShareList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).AzureFileFilterDetailFileShareList = value ?? null /* arrayOf */; }

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPathList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailBlobPathList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailBlobPathList = value ?? null /* arrayOf */; }

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailBlobPrefixList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailBlobPrefixList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailBlobPrefixList = value ?? null /* arrayOf */; }

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> BlobFilterDetailContainerList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailContainerList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).BlobFilterDetailContainerList = value ?? null /* arrayOf */; }

        /// <summary>Details of the filter files to be used for data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IFilterFileDetails> IncludeFilterFileDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeFilterFileDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeFilterFileDetail = value ?? null /* arrayOf */; }

        /// <summary>To indicate if all Azure blobs have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IncludeTransferAllBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeTransferAllBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeTransferAllBlob = value ?? default(bool); }

        /// <summary>To indicate if all Azure Files have to be transferred</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IncludeTransferAllFile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeTransferAllFile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeTransferAllFile = value ?? default(bool); }

        /// <summary>Backing field for <see cref="LogCollectionLevel" /> property.</summary>
        private string _logCollectionLevel;

        /// <summary>Level of the logs to be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string LogCollectionLevel { get => this._logCollectionLevel; set => this._logCollectionLevel = value; }

        /// <summary>Internal Acessors for AccountDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.AccountDetail { get => (this._accountDetail = this._accountDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataAccountDetails()); set { {_accountDetail = value;} } }

        /// <summary>Internal Acessors for IncludeAzureFileFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAzureFileFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.IncludeAzureFileFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeAzureFileFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeAzureFileFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IncludeBlobFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IBlobFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.IncludeBlobFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeBlobFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).IncludeBlobFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferAllDetailInclude</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.TransferAllDetailInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetailInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetailInclude = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.TransferConfiguration { get => (this._transferConfiguration = this._transferConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfiguration()); set { {_transferConfiguration = value;} } }

        /// <summary>Internal Acessors for TransferConfigurationTransferAllDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.TransferConfigurationTransferAllDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferConfigurationTransferFilterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.TransferConfigurationTransferFilterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransferFilterDetailInclude</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetailsInternal.TransferFilterDetailInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetailInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetailInclude = value ?? null /* model class */; }

        /// <summary>Type of the account of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferAllDetailsIncludeDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetailsIncludeDataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferAllDetailsIncludeDataAccountType = value ?? null; }

        /// <summary>Backing field for <see cref="TransferConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration _transferConfiguration;

        /// <summary>Configuration for the data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration TransferConfiguration { get => (this._transferConfiguration = this._transferConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransferConfiguration()); set => this._transferConfiguration = value; }

        /// <summary>Type of the configuration for transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).Type = value ; }

        /// <summary>Type of the account of data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferFilterDetailsIncludeDataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetailsIncludeDataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationInternal)TransferConfiguration).TransferFilterDetailsIncludeDataAccountType = value ?? null; }

        /// <summary>Creates an new <see cref="DataExportDetails" /> instance.</summary>
        public DataExportDetails()
        {

        }
    }
    /// Details of the data to be used for exporting data from azure.
    public partial interface IDataExportDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Account Type of the data to be transferred.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string AccountDetailDataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+",
        SerializedName = @"sharePassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AccountDetailSharePassword { get; set; }
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
        /// <summary>Level of the logs to be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Level of the logs to be collected.",
        SerializedName = @"logCollectionLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Error", "Verbose")]
        string LogCollectionLevel { get; set; }
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
        string TransferConfigurationType { get; set; }
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

    }
    /// Details of the data to be used for exporting data from azure.
    internal partial interface IDataExportDetailsInternal

    {
        /// <summary>Account details of the data to be transferred</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataAccountDetails AccountDetail { get; set; }
        /// <summary>Account Type of the data to be transferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string AccountDetailDataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        System.Security.SecureString AccountDetailSharePassword { get; set; }
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
        /// <summary>Level of the logs to be collected.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Error", "Verbose")]
        string LogCollectionLevel { get; set; }
        /// <summary>Details to transfer all data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferAllDetails TransferAllDetailInclude { get; set; }
        /// <summary>Type of the account of data</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferAllDetailsIncludeDataAccountType { get; set; }
        /// <summary>Configuration for the data transfer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfiguration TransferConfiguration { get; set; }
        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferAllDetails TransferConfigurationTransferAllDetail { get; set; }
        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferConfigurationTransferFilterDetails TransferConfigurationTransferFilterDetail { get; set; }
        /// <summary>Type of the configuration for transfer.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("TransferAll", "TransferUsingFilter")]
        string TransferConfigurationType { get; set; }
        /// <summary>Details of the filtering the transfer of data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransferFilterDetails TransferFilterDetailInclude { get; set; }
        /// <summary>Type of the account of data.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("StorageAccount", "ManagedDisk")]
        string TransferFilterDetailsIncludeDataAccountType { get; set; }

    }
}