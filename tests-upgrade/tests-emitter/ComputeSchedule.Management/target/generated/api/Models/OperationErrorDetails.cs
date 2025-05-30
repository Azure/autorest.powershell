// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This defines a list of operation errors associated with a unique operationId</summary>
    public partial class OperationErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetailsInternal
    {

        /// <summary>Backing field for <see cref="AzureOperationName" /> property.</summary>
        private string _azureOperationName;

        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string AzureOperationName { get => this._azureOperationName; set => this._azureOperationName = value; }

        /// <summary>Backing field for <see cref="CrpOperationId" /> property.</summary>
        private string _crpOperationId;

        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string CrpOperationId { get => this._crpOperationId; set => this._crpOperationId = value; }

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>The error code of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private string _errorDetail;

        /// <summary>The error details of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Backing field for <see cref="TimeStamp" /> property.</summary>
        private global::System.DateTime? _timeStamp;

        /// <summary>The timestamp of the error occurence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeStamp { get => this._timeStamp; set => this._timeStamp = value; }

        /// <summary>Backing field for <see cref="Timestamp" /> property.</summary>
        private global::System.DateTime? _timestamp;

        /// <summary>The timestamp of the error occurence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? Timestamp { get => this._timestamp; set => this._timestamp = value; }

        /// <summary>Creates an new <see cref="OperationErrorDetails" /> instance.</summary>
        public OperationErrorDetails()
        {

        }
    }
    /// This defines a list of operation errors associated with a unique operationId
    public partial interface IOperationErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The compute operationid of the Start/Deallocate/Hibernate request",
        SerializedName = @"azureOperationName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureOperationName { get; set; }
        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The compute operationid of the Start/Deallocate/Hibernate request",
        SerializedName = @"crpOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string CrpOperationId { get; set; }
        /// <summary>The error code of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error code of the operation",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorCode { get; set; }
        /// <summary>The error details of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error details of the operation",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetail { get; set; }
        /// <summary>The timestamp of the error occurence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of the error occurence",
        SerializedName = @"timeStamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeStamp { get; set; }
        /// <summary>The timestamp of the error occurence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of the error occurence",
        SerializedName = @"timestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Timestamp { get; set; }

    }
    /// This defines a list of operation errors associated with a unique operationId
    internal partial interface IOperationErrorDetailsInternal

    {
        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        string AzureOperationName { get; set; }
        /// <summary>The compute operationid of the Start/Deallocate/Hibernate request</summary>
        string CrpOperationId { get; set; }
        /// <summary>The error code of the operation</summary>
        string ErrorCode { get; set; }
        /// <summary>The error details of the operation</summary>
        string ErrorDetail { get; set; }
        /// <summary>The timestamp of the error occurence</summary>
        global::System.DateTime? TimeStamp { get; set; }
        /// <summary>The timestamp of the error occurence</summary>
        global::System.DateTime? Timestamp { get; set; }

    }
}