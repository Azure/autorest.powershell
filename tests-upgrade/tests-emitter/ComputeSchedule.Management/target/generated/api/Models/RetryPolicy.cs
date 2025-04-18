// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The retry policy for the user request</summary>
    public partial class RetryPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicyInternal
    {

        /// <summary>Backing field for <see cref="RetryCount" /> property.</summary>
        private int? _retryCount;

        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public int? RetryCount { get => this._retryCount; set => this._retryCount = value; }

        /// <summary>Backing field for <see cref="RetryWindowInMinute" /> property.</summary>
        private int? _retryWindowInMinute;

        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public int? RetryWindowInMinute { get => this._retryWindowInMinute; set => this._retryWindowInMinute = value; }

        /// <summary>Creates an new <see cref="RetryPolicy" /> instance.</summary>
        public RetryPolicy()
        {

        }
    }
    /// The retry policy for the user request
    public partial interface IRetryPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
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
        int? RetryCount { get; set; }
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
        int? RetryWindowInMinute { get; set; }

    }
    /// The retry policy for the user request
    internal partial interface IRetryPolicyInternal

    {
        /// <summary>Retry count for user request</summary>
        int? RetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        int? RetryWindowInMinute { get; set; }

    }
}