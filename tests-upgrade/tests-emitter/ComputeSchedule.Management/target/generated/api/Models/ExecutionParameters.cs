// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>Extra details needed to run the user's request</summary>
    public partial class ExecutionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal
    {

        /// <summary>Internal Acessors for RetryPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal.RetryPolicy { get => (this._retryPolicy = this._retryPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.RetryPolicy()); set { {_retryPolicy = value;} } }

        /// <summary>Backing field for <see cref="OptimizationPreference" /> property.</summary>
        private string _optimizationPreference;

        /// <summary>Details that could optimize the user's request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string OptimizationPreference { get => this._optimizationPreference; set => this._optimizationPreference = value; }

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

        /// <summary>Creates an new <see cref="ExecutionParameters" /> instance.</summary>
        public ExecutionParameters()
        {

        }
    }
    /// Extra details needed to run the user's request
    public partial interface IExecutionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>Details that could optimize the user's request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details that could optimize the user's request",
        SerializedName = @"optimizationPreference",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Cost", "Availability", "CostAvailabilityBalanced")]
        string OptimizationPreference { get; set; }
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

    }
    /// Extra details needed to run the user's request
    internal partial interface IExecutionParametersInternal

    {
        /// <summary>Details that could optimize the user's request</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Cost", "Availability", "CostAvailabilityBalanced")]
        string OptimizationPreference { get; set; }
        /// <summary>Retry policy the user can pass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy RetryPolicy { get; set; }
        /// <summary>Retry count for user request</summary>
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        int? RetryPolicyRetryWindowInMinute { get; set; }

    }
}