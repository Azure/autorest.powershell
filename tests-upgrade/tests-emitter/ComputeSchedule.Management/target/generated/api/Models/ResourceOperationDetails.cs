// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The details of a response from an operation on a resource</summary>
    public partial class ResourceOperationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal
    {

        /// <summary>Backing field for <see cref="CompletedAt" /> property.</summary>
        private global::System.DateTime? _completedAt;

        /// <summary>Time the operation was complete if errors are null</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? CompletedAt { get => this._completedAt; set => this._completedAt = value; }

        /// <summary>Backing field for <see cref="Deadline" /> property.</summary>
        private global::System.DateTime? _deadline;

        /// <summary>Deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? Deadline { get => this._deadline; set => this._deadline = value; }

        /// <summary>Backing field for <see cref="DeadlineType" /> property.</summary>
        private string _deadlineType;

        /// <summary>Type of deadline of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string DeadlineType { get => this._deadlineType; set => this._deadlineType = value; }

        /// <summary>Internal Acessors for ResourceOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal.ResourceOperationError { get => (this._resourceOperationError = this._resourceOperationError ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationError()); set { {_resourceOperationError = value;} } }

        /// <summary>Internal Acessors for RetryPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal.RetryPolicy { get => (this._retryPolicy = this._retryPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicy()); set { {_retryPolicy = value;} } }

        /// <summary>Backing field for <see cref="OpType" /> property.</summary>
        private string _opType;

        /// <summary>Type of operation performed on the resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string OpType { get => this._opType; set => this._opType = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>Operation identifier for the unique operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ResourceOperationError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError _resourceOperationError;

        /// <summary>Operation level errors if they exist</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError ResourceOperationError { get => (this._resourceOperationError = this._resourceOperationError ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationError()); set => this._resourceOperationError = value; }

        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string ResourceOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationErrorInternal)ResourceOperationError).ErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationErrorInternal)ResourceOperationError).ErrorCode = value ?? null; }

        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string ResourceOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationErrorInternal)ResourceOperationError).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationErrorInternal)ResourceOperationError).ErrorDetail = value ?? null; }

        /// <summary>Backing field for <see cref="RetryPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy _retryPolicy;

        /// <summary>Retry policy the user can pass</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy RetryPolicy { get => (this._retryPolicy = this._retryPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicy()); set => this._retryPolicy = value; }

        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicyInternal)RetryPolicy).RetryCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicyInternal)RetryPolicy).RetryCount = value ?? default(int); }

        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryWindowInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicyInternal)RetryPolicy).RetryWindowInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicyInternal)RetryPolicy).RetryWindowInMinute = value ?? default(int); }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Current state of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Subscription id attached to the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Backing field for <see cref="Timezone" /> property.</summary>
        private string _timezone;

        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string Timezone { get => this._timezone; set => this._timezone = value; }

        /// <summary>Creates an new <see cref="ResourceOperationDetails" /> instance.</summary>
        public ResourceOperationDetails()
        {

        }
    }
    /// The details of a response from an operation on a resource
    public partial interface IResourceOperationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>Time the operation was complete if errors are null</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time the operation was complete if errors are null",
        SerializedName = @"completedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CompletedAt { get; set; }
        /// <summary>Deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Deadline for the operation",
        SerializedName = @"deadline",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Deadline { get; set; }
        /// <summary>Type of deadline of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of deadline of the operation",
        SerializedName = @"deadlineType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string DeadlineType { get; set; }
        /// <summary>Type of operation performed on the resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of operation performed on the resources",
        SerializedName = @"opType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "Start", "Deallocate", "Hibernate")]
        string OpType { get; set; }
        /// <summary>Operation identifier for the unique operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operation identifier for the unique operation",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier for the resource involved in the operation, eg ArmId",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Code for the error eg 404, 500",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceOperationErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Detailed message about the error",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceOperationErrorDetail { get; set; }
        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retry count for user request",
        SerializedName = @"retryCount",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retry window in minutes for user request",
        SerializedName = @"retryWindowInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryPolicyRetryWindowInMinute { get; set; }
        /// <summary>Current state of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current state of the operation",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "PendingScheduling", "Scheduled", "PendingExecution", "Executing", "Succeeded", "Failed", "Cancelled", "Blocked")]
        string State { get; set; }
        /// <summary>Subscription id attached to the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription id attached to the request",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timezone for the operation",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }
        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timezone for the operation",
        SerializedName = @"timezone",
        PossibleTypes = new [] { typeof(string) })]
        string Timezone { get; set; }

    }
    /// The details of a response from an operation on a resource
    internal partial interface IResourceOperationDetailsInternal

    {
        /// <summary>Time the operation was complete if errors are null</summary>
        global::System.DateTime? CompletedAt { get; set; }
        /// <summary>Deadline for the operation</summary>
        global::System.DateTime? Deadline { get; set; }
        /// <summary>Type of deadline of the operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string DeadlineType { get; set; }
        /// <summary>Type of operation performed on the resources</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "Start", "Deallocate", "Hibernate")]
        string OpType { get; set; }
        /// <summary>Operation identifier for the unique operation</summary>
        string OperationId { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        string ResourceId { get; set; }
        /// <summary>Operation level errors if they exist</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError ResourceOperationError { get; set; }
        /// <summary>Code for the error eg 404, 500</summary>
        string ResourceOperationErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        string ResourceOperationErrorDetail { get; set; }
        /// <summary>Retry policy the user can pass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy RetryPolicy { get; set; }
        /// <summary>Retry count for user request</summary>
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        int? RetryPolicyRetryWindowInMinute { get; set; }
        /// <summary>Current state of the operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "PendingScheduling", "Scheduled", "PendingExecution", "Executing", "Succeeded", "Failed", "Cancelled", "Blocked")]
        string State { get; set; }
        /// <summary>Subscription id attached to the request</summary>
        string SubscriptionId { get; set; }
        /// <summary>Timezone for the operation</summary>
        string TimeZone { get; set; }
        /// <summary>Timezone for the operation</summary>
        string Timezone { get; set; }

    }
}