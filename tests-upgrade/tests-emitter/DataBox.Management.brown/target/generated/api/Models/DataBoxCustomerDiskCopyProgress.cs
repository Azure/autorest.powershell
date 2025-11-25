// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>DataBox CustomerDisk Copy Progress</summary>
    public partial class DataBoxCustomerDiskCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgressInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress __copyProgress = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyProgress();

        /// <summary>Id of the account where the data needs to be uploaded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AccountId; }

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Action; }

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AdditionalInfo; }

        /// <summary>To indicate bytes transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? BytesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).BytesProcessed; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Code; }

        /// <summary>Backing field for <see cref="CopyStatus" /> property.</summary>
        private string _copyStatus;

        /// <summary>The Status of the copy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CopyStatus { get => this._copyStatus; }

        /// <summary>Data Account Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DataAccountType; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Detail; }

        /// <summary>To indicate directories errored out in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? DirectoriesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DirectoriesErroredOut; }

        /// <summary>Error, if any, in the stage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Error = value ?? null /* model class */; }

        /// <summary>Number of files which could not be copied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? FilesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesErroredOut; }

        /// <summary>Number of files processed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? FilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesProcessed; }

        /// <summary>To indicate directories renamed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidDirectoriesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidDirectoriesProcessed; }

        /// <summary>
        /// Total amount of data not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidFileBytesUploaded { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFileBytesUploaded; }

        /// <summary>
        /// Number of files not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? InvalidFilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFilesProcessed; }

        /// <summary>
        /// To indicate if enumeration of data is in progress.
        /// Until this is true, the TotalBytesToProcess may not be valid.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? IsEnumerationInProgress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).IsEnumerationInProgress; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Message; }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AccountId = value ?? null; }

        /// <summary>Internal Acessors for Action</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Action = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for BytesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.BytesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).BytesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).BytesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Code = value ?? null; }

        /// <summary>Internal Acessors for DataAccountType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.DataAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DataAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DataAccountType = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DirectoriesErroredOut</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.DirectoriesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DirectoriesErroredOut; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).DirectoriesErroredOut = value ?? default(long); }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FilesErroredOut</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.FilesErroredOut { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesErroredOut; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesErroredOut = value ?? default(long); }

        /// <summary>Internal Acessors for FilesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.FilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).FilesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidDirectoriesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.InvalidDirectoriesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidDirectoriesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidDirectoriesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidFileBytesUploaded</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.InvalidFileBytesUploaded { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFileBytesUploaded; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFileBytesUploaded = value ?? default(long); }

        /// <summary>Internal Acessors for InvalidFilesProcessed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.InvalidFilesProcessed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFilesProcessed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).InvalidFilesProcessed = value ?? default(long); }

        /// <summary>Internal Acessors for IsEnumerationInProgress</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.IsEnumerationInProgress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).IsEnumerationInProgress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).IsEnumerationInProgress = value ?? default(bool); }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Message = value ?? null; }

        /// <summary>Internal Acessors for RenamedContainerCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.RenamedContainerCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).RenamedContainerCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).RenamedContainerCount = value ?? default(long); }

        /// <summary>Internal Acessors for StorageAccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).StorageAccountName = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Target = value ?? null; }

        /// <summary>Internal Acessors for TotalBytesToProcess</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.TotalBytesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalBytesToProcess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalBytesToProcess = value ?? default(long); }

        /// <summary>Internal Acessors for TotalFilesToProcess</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.TotalFilesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalFilesToProcess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalFilesToProcess = value ?? default(long); }

        /// <summary>Internal Acessors for TransferType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal.TransferType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TransferType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TransferType = value ?? null; }

        /// <summary>Internal Acessors for CopyStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgressInternal.CopyStatus { get => this._copyStatus; set { {_copyStatus = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgressInternal.SerialNumber { get => this._serialNumber; set { {_serialNumber = value;} } }

        /// <summary>
        /// Number of folders not adhering to azure naming conventions which were processed by automatic renaming
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? RenamedContainerCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).RenamedContainerCount; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Disk Serial Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; }

        /// <summary>
        /// Name of the storage account. This will be empty for data account types other than storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).StorageAccountName; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).Target; }

        /// <summary>Total amount of data to be processed by the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? TotalBytesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalBytesToProcess; }

        /// <summary>Total files to process</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public long? TotalFilesToProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TotalFilesToProcess; }

        /// <summary>Transfer type of data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string TransferType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal)__copyProgress).TransferType; }

        /// <summary>Creates an new <see cref="DataBoxCustomerDiskCopyProgress" /> instance.</summary>
        public DataBoxCustomerDiskCopyProgress()
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
            await eventListener.AssertNotNull(nameof(__copyProgress), __copyProgress);
            await eventListener.AssertObjectIsValid(nameof(__copyProgress), __copyProgress);
        }
    }
    /// DataBox CustomerDisk Copy Progress
    public partial interface IDataBoxCustomerDiskCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgress
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
    /// DataBox CustomerDisk Copy Progress
    internal partial interface IDataBoxCustomerDiskCopyProgressInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyProgressInternal
    {
        /// <summary>The Status of the copy</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Completed", "CompletedWithErrors", "Failed", "NotReturned", "HardwareError", "DeviceFormatted", "DeviceMetadataModified", "StorageAccountNotAccessible", "UnsupportedData", "DriveNotReceived", "UnsupportedDrive", "OtherServiceError", "OtherUserError", "DriveNotDetected", "DriveCorrupted", "MetadataFilesModifiedOrRemoved")]
        string CopyStatus { get; set; }
        /// <summary>Disk Serial Number.</summary>
        string SerialNumber { get; set; }

    }
}