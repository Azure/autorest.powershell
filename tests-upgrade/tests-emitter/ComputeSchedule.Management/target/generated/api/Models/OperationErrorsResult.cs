// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    /// </summary>
    public partial class OperationErrorsResult :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResult,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorsResultInternal
    {

        /// <summary>Backing field for <see cref="ActivationTime" /> property.</summary>
        private global::System.DateTime? _activationTime;

        /// <summary>The activation time of a vm operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? ActivationTime { get => this._activationTime; set => this._activationTime = value; }

        /// <summary>Backing field for <see cref="CompletedAt" /> property.</summary>
        private global::System.DateTime? _completedAt;

        /// <summary>The completion time of the operation if the operation was completed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? CompletedAt { get => this._completedAt; set => this._completedAt = value; }

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private global::System.DateTime? _creationTime;

        /// <summary>The creation time of the error result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationTime { get => this._creationTime; set => this._creationTime = value; }

        /// <summary>Backing field for <see cref="OperationError" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails> _operationError;

        /// <summary>A list of errors associated with the operationid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails> OperationError { get => this._operationError; set => this._operationError = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>The operationId identifying a vm operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="RequestErrorCode" /> property.</summary>
        private string _requestErrorCode;

        /// <summary>Request level error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string RequestErrorCode { get => this._requestErrorCode; set => this._requestErrorCode = value; }

        /// <summary>Backing field for <see cref="RequestErrorDetail" /> property.</summary>
        private string _requestErrorDetail;

        /// <summary>Request level error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string RequestErrorDetail { get => this._requestErrorDetail; set => this._requestErrorDetail = value; }

        /// <summary>Creates an new <see cref="OperationErrorsResult" /> instance.</summary>
        public OperationErrorsResult()
        {

        }
    }
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    public partial interface IOperationErrorsResult :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>The activation time of a vm operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The activation time of a vm operation",
        SerializedName = @"activationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ActivationTime { get; set; }
        /// <summary>The completion time of the operation if the operation was completed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The completion time of the operation if the operation was completed",
        SerializedName = @"completedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CompletedAt { get; set; }
        /// <summary>The creation time of the error result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The creation time of the error result",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>A list of errors associated with the operationid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of errors associated with the operationid",
        SerializedName = @"operationErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails> OperationError { get; set; }
        /// <summary>The operationId identifying a vm operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The operationId identifying a vm operation",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>Request level error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Request level error code",
        SerializedName = @"requestErrorCode",
        PossibleTypes = new [] { typeof(string) })]
        string RequestErrorCode { get; set; }
        /// <summary>Request level error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Request level error details",
        SerializedName = @"requestErrorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string RequestErrorDetail { get; set; }

    }
    /// This is the first level of operation errors from the request when clients get errors per vm operation
    internal partial interface IOperationErrorsResultInternal

    {
        /// <summary>The activation time of a vm operation</summary>
        global::System.DateTime? ActivationTime { get; set; }
        /// <summary>The completion time of the operation if the operation was completed</summary>
        global::System.DateTime? CompletedAt { get; set; }
        /// <summary>The creation time of the error result</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>A list of errors associated with the operationid</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IOperationErrorDetails> OperationError { get; set; }
        /// <summary>The operationId identifying a vm operation</summary>
        string OperationId { get; set; }
        /// <summary>Request level error code</summary>
        string RequestErrorCode { get; set; }
        /// <summary>Request level error details</summary>
        string RequestErrorDetail { get; set; }

    }
}