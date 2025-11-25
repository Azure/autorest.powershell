// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>DataBox Disk Copy Progress</summary>
    public partial class DataBoxDiskCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgress,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private System.Collections.Generic.List<string> _action;

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Action { get => this._action; }

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; }

        /// <summary>Backing field for <see cref="BytesCopied" /> property.</summary>
        private long? _bytesCopied;

        /// <summary>Bytes copied during the copy of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public long? BytesCopied { get => this._bytesCopied; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError _error;

        /// <summary>Error, if any, in the stage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Action</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for BytesCopied</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.BytesCopied { get => this._bytesCopied; set { {_bytesCopied = value;} } }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for PercentComplete</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.PercentComplete { get => this._percentComplete; set { {_percentComplete = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.SerialNumber { get => this._serialNumber; set { {_serialNumber = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgressInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target = value ?? null; }

        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private int? _percentComplete;

        /// <summary>Indicates the percentage completed for the copy of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public int? PercentComplete { get => this._percentComplete; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>The serial number of the disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The Status of the copy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; }

        /// <summary>Creates an new <see cref="DataBoxDiskCopyProgress" /> instance.</summary>
        public DataBoxDiskCopyProgress()
        {

        }
    }
    /// DataBox Disk Copy Progress
    public partial interface IDataBoxDiskCopyProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Available actions on the job.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        System.Collections.Generic.List<string> Action { get;  }
        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets additional error info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get;  }
        /// <summary>Bytes copied during the copy of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Bytes copied during the copy of disk.",
        SerializedName = @"bytesCopied",
        PossibleTypes = new [] { typeof(long) })]
        long? BytesCopied { get;  }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets details for the error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get;  }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message parsed from the body of the http error response.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Indicates the percentage completed for the copy of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates the percentage completed for the copy of the disk.",
        SerializedName = @"percentComplete",
        PossibleTypes = new [] { typeof(int) })]
        int? PercentComplete { get;  }
        /// <summary>The serial number of the disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The serial number of the disk",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get;  }
        /// <summary>The Status of the copy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Status of the copy",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Completed", "CompletedWithErrors", "Failed", "NotReturned", "HardwareError", "DeviceFormatted", "DeviceMetadataModified", "StorageAccountNotAccessible", "UnsupportedData", "DriveNotReceived", "UnsupportedDrive", "OtherServiceError", "OtherUserError", "DriveNotDetected", "DriveCorrupted", "MetadataFilesModifiedOrRemoved")]
        string Status { get;  }
        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// DataBox Disk Copy Progress
    internal partial interface IDataBoxDiskCopyProgressInternal

    {
        /// <summary>Available actions on the job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        System.Collections.Generic.List<string> Action { get; set; }
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>Bytes copied during the copy of disk.</summary>
        long? BytesCopied { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get; set; }
        /// <summary>Error, if any, in the stage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Indicates the percentage completed for the copy of the disk.</summary>
        int? PercentComplete { get; set; }
        /// <summary>The serial number of the disk</summary>
        string SerialNumber { get; set; }
        /// <summary>The Status of the copy</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Completed", "CompletedWithErrors", "Failed", "NotReturned", "HardwareError", "DeviceFormatted", "DeviceMetadataModified", "StorageAccountNotAccessible", "UnsupportedData", "DriveNotReceived", "UnsupportedDrive", "OtherServiceError", "OtherUserError", "DriveNotDetected", "DriveCorrupted", "MetadataFilesModifiedOrRemoved")]
        string Status { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }

    }
}