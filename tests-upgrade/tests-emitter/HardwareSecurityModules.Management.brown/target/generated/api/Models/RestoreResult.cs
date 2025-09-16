// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Restore operation properties</summary>
    public partial class RestoreResult :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResult,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IHeaderSerializable
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Detail; }

        /// <summary>The end time of the backup/restore operation in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).EndTime; }

        /// <summary>Identifier for the backup/restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string JobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).JobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).JobId = value ?? null; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultProperties Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupRestoreBaseResultProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Target = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultProperties _property;

        /// <summary>Backup and Restore operation common properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.BackupRestoreBaseResultProperties()); set => this._property = value; }

        /// <summary>The start time of the backup/restore operation in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).StartTime; }

        /// <summary>Status of the backup/restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Status; }

        /// <summary>The status details of backup/restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string StatusDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).StatusDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).StatusDetail = value ?? null; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultPropertiesInternal)Property).Target; }

        /// <summary>Backing field for <see cref="XmsRequestId" /> property.</summary>
        private string _xmsRequestId;

        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string XmsRequestId { get => this._xmsRequestId; set => this._xmsRequestId = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("x-ms-request-id", out var __xMSRequestIdHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IRestoreResultInternal)this).XmsRequestId = System.Linq.Enumerable.FirstOrDefault(__xMSRequestIdHeader0) is string __headerXMSRequestIdHeader0 ? __headerXMSRequestIdHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="RestoreResult" /> instance.</summary>
        public RestoreResult()
        {

        }
    }
    /// Restore operation properties
    public partial interface IRestoreResult :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail> Detail { get;  }
        /// <summary>The end time of the backup/restore operation in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The end time of the backup/restore operation in UTC",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>Identifier for the backup/restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identifier for the backup/restore operation.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The start time of the backup/restore operation in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The start time of the backup/restore operation in UTC",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Status of the backup/restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the backup/restore operation",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("InProgress", "Succeeded", "Failed", "Cancelled")]
        string Status { get;  }
        /// <summary>The status details of backup/restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status details of backup/restore operation",
        SerializedName = @"statusDetails",
        PossibleTypes = new [] { typeof(string) })]
        string StatusDetail { get; set; }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"x-ms-request-id",
        PossibleTypes = new [] { typeof(string) })]
        string XmsRequestId { get; set; }

    }
    /// Restore operation properties
    internal partial interface IRestoreResultInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail> Detail { get; set; }
        /// <summary>The end time of the backup/restore operation in UTC</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Error encountered, if any, during the backup/restore operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IErrorDetail Error { get; set; }
        /// <summary>Identifier for the backup/restore operation.</summary>
        string JobId { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>Backup and Restore operation common properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IBackupRestoreBaseResultProperties Property { get; set; }
        /// <summary>The start time of the backup/restore operation in UTC</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Status of the backup/restore operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Hsm.PSArgumentCompleterAttribute("InProgress", "Succeeded", "Failed", "Cancelled")]
        string Status { get; set; }
        /// <summary>The status details of backup/restore operation</summary>
        string StatusDetail { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

        string XmsRequestId { get; set; }

    }
}