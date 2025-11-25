// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>DataBox Disk Granular Copy Progress</summary>
    public partial class DataBoxDiskGranularCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgress,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgressInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgress"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgress __granularCopyProgress = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.GranularCopyProgress();

        /// <summary>Id of the account where the data needs to be uploaded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AccountId; }

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Action; }

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AdditionalInfo; }

        /// <summary>To indicate bytes transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? BytesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).BytesProcessed; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Code; }

        /// <summary>Backing field for <see cref="CopyStatus" /> property.</summary>
        private string _copyStatus;

        /// <summary>The Status of the copy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CopyStatus { get => this._copyStatus; }

        /// <summary>Data Account Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DataAccountType; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Detail; }

        /// <summary>To indicate directories errored out in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? DirectoriesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DirectoriesErroredOut; }

        /// <summary>Error, if any, in the stage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Error = value ?? null /* model class */; }

        /// <summary>Number of files which could not be copied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? FilesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesErroredOut; }

        /// <summary>Number of files processed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? FilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesProcessed; }

        /// <summary>To indicate directories renamed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidDirectoriesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidDirectoriesProcessed; }

        /// <summary>
        /// Total amount of data not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidFileBytesUploaded { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFileBytesUploaded; }

        /// <summary>
        /// Number of files not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidFilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFilesProcessed; }

        /// <summary>
        /// To indicate if enumeration of data is in progress.
        /// Until this is true, the TotalBytesToProcess may not be valid.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? IsEnumerationInProgress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).IsEnumerationInProgress; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Message; }

        /// <summary>Internal Acessors for CopyStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgressInternal.CopyStatus { get => this._copyStatus; set { {_copyStatus = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgressInternal.SerialNumber { get => this._serialNumber; set { {_serialNumber = value;} } }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AccountId = value ?? null; }

        /// <summary>Internal Acessors for Action</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Action = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for BytesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.BytesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).BytesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).BytesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Code = value ?? null; }

        /// <summary>Internal Acessors for DataAccountType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.DataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DataAccountType = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DirectoriesErroredOut</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.DirectoriesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DirectoriesErroredOut; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).DirectoriesErroredOut = value ?? default(long); }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FilesErroredOut</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.FilesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesErroredOut; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesErroredOut = value ?? default(long); }

        /// <summary>Internal Acessors for FilesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.FilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).FilesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidDirectoriesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.InvalidDirectoriesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidDirectoriesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidDirectoriesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidFileBytesUploaded</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.InvalidFileBytesUploaded { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFileBytesUploaded; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFileBytesUploaded = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidFilesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.InvalidFilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFilesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).InvalidFilesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for IsEnumerationInProgress</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.IsEnumerationInProgress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).IsEnumerationInProgress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).IsEnumerationInProgress = value ?? default(bool); }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Message = value ?? null; }

        /// <summary>Internal Acessors for RenamedContainerCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.RenamedContainerCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).RenamedContainerCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).RenamedContainerCount = value ?? default(long); }

        /// <summary>Internal Acessors for StorageAccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).StorageAccountName = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Target = value ?? null; }

        /// <summary>Internal Acessors for TotalBytesToProcess</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.TotalBytesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalBytesToProcess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalBytesToProcess = value ?? default(long); }

        /// <summary>Internal Acessors for TotalFilesToProcess</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.TotalFilesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalFilesToProcess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalFilesToProcess = value ?? default(long); }

        /// <summary>Internal Acessors for TransferType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal.TransferType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TransferType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TransferType = value ?? null; }

        /// <summary>
        /// Number of folders not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? RenamedContainerCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).RenamedContainerCount; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Disk Serial Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; }

        /// <summary>
        /// Name of the storage account. This will be empty for data account types other than storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).StorageAccountName; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).Target; }

        /// <summary>Total amount of data to be processed by the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? TotalBytesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalBytesToProcess; }

        /// <summary>Total files to process</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? TotalFilesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TotalFilesToProcess; }

        /// <summary>Transfer type of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string TransferType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal)__granularCopyProgress).TransferType; }

        /// <summary>Creates an new <see cref="DataBoxDiskGranularCopyProgress" /> instance.</summary>
        public DataBoxDiskGranularCopyProgress()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__granularCopyProgress), __granularCopyProgress);
            await eventListener.AssertObjectIsValid(nameof(__granularCopyProgress), __granularCopyProgress);
        }
    }
    /// DataBox Disk Granular Copy Progress
    public partial interface IDataBoxDiskGranularCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgress
    {
        /// <summary>The Status of the copy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Status of the copy",
        SerializedName = @"copyStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Completed", "CompletedWithErrors", "Failed", "NotReturned", "HardwareError", "DeviceFormatted", "DeviceMetadataModified", "StorageAccountNotAccessible", "UnsupportedData", "DriveNotReceived", "UnsupportedDrive", "OtherServiceError", "OtherUserError", "DriveNotDetected", "DriveCorrupted", "MetadataFilesModifiedOrRemoved")]
        string CopyStatus { get;  }
        /// <summary>Disk Serial Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Disk Serial Number.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get;  }

    }
    /// DataBox Disk Granular Copy Progress
    internal partial interface IDataBoxDiskGranularCopyProgressInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IGranularCopyProgressInternal
    {
        /// <summary>The Status of the copy</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Completed", "CompletedWithErrors", "Failed", "NotReturned", "HardwareError", "DeviceFormatted", "DeviceMetadataModified", "StorageAccountNotAccessible", "UnsupportedData", "DriveNotReceived", "UnsupportedDrive", "OtherServiceError", "OtherUserError", "DriveNotDetected", "DriveCorrupted", "MetadataFilesModifiedOrRemoved")]
        string CopyStatus { get; set; }
        /// <summary>Disk Serial Number.</summary>
        string SerialNumber { get; set; }

    }
}