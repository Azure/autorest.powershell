// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The ExecuteDeallocateRequest request for executeDeallocate operations</summary>
    public partial class ExecuteDeallocateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecuteDeallocateRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecuteDeallocateRequestInternal
    {

        /// <summary>Backing field for <see cref="Correlationid" /> property.</summary>
        private string _correlationid;

        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string Correlationid { get => this._correlationid; set => this._correlationid = value; }

        /// <summary>Backing field for <see cref="ExecutionParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters _executionParameter;

        /// <summary>The execution parameters for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters ExecutionParameter { get => (this._executionParameter = this._executionParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ExecutionParameters()); set => this._executionParameter = value; }

        /// <summary>Details that could optimize the user's request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string ExecutionParameterOptimizationPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).OptimizationPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).OptimizationPreference = value ?? null; }

        /// <summary>Internal Acessors for ExecutionParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecuteDeallocateRequestInternal.ExecutionParameter { get => (this._executionParameter = this._executionParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ExecutionParameters()); set { {_executionParameter = value;} } }

        /// <summary>Internal Acessors for ExecutionParameterRetryPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecuteDeallocateRequestInternal.ExecutionParameterRetryPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicy = value; }

        /// <summary>Internal Acessors for Resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecuteDeallocateRequestInternal.Resource { get => (this._resource = this._resource ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.Resources()); set { {_resource = value;} } }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources _resource;

        /// <summary>The resources for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources Resource { get => (this._resource = this._resource ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.Resources()); set => this._resource = value; }

        /// <summary>The resource ids used for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourcesInternal)Resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourcesInternal)Resource).Id = value ; }

        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicyRetryCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicyRetryCount = value ?? default(int); }

        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryWindowInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicyRetryWindowInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParametersInternal)ExecutionParameter).RetryPolicyRetryWindowInMinute = value ?? default(int); }

        /// <summary>Creates an new <see cref="ExecuteDeallocateRequest" /> instance.</summary>
        public ExecuteDeallocateRequest()
        {

        }
    }
    /// The ExecuteDeallocateRequest request for executeDeallocate operations
    public partial interface IExecuteDeallocateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CorrelationId item",
        SerializedName = @"correlationid",
        PossibleTypes = new [] { typeof(string) })]
        string Correlationid { get; set; }
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
        string ExecutionParameterOptimizationPreference { get; set; }
        /// <summary>The resource ids used for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource ids used for the request",
        SerializedName = @"ids",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceId { get; set; }
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
    /// The ExecuteDeallocateRequest request for executeDeallocate operations
    internal partial interface IExecuteDeallocateRequestInternal

    {
        /// <summary>CorrelationId item</summary>
        string Correlationid { get; set; }
        /// <summary>The execution parameters for the request</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IExecutionParameters ExecutionParameter { get; set; }
        /// <summary>Details that could optimize the user's request</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Cost", "Availability", "CostAvailabilityBalanced")]
        string ExecutionParameterOptimizationPreference { get; set; }
        /// <summary>Retry policy the user can pass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy ExecutionParameterRetryPolicy { get; set; }
        /// <summary>The resources for the request</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources Resource { get; set; }
        /// <summary>The resource ids used for the request</summary>
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>Retry count for user request</summary>
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        int? RetryPolicyRetryWindowInMinute { get; set; }

    }
}