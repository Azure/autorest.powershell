// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Displays the counts of pooled resources in each state, as known by the StandbyPool resource provider.
    /// </summary>
    public partial class PoolResourceStateCount :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCountInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private long _count;

        /// <summary>The count of pooled resources in the given state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The state that the pooled resources count is for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="PoolResourceStateCount" /> instance.</summary>
        public PoolResourceStateCount()
        {

        }
    }
    /// Displays the counts of pooled resources in each state, as known by the StandbyPool resource provider.
    public partial interface IPoolResourceStateCount :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The count of pooled resources in the given state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of pooled resources in the given state.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long Count { get; set; }
        /// <summary>The state that the pooled resources count is for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state that the pooled resources count is for.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

    }
    /// Displays the counts of pooled resources in each state, as known by the StandbyPool resource provider.
    internal partial interface IPoolResourceStateCountInternal

    {
        /// <summary>The count of pooled resources in the given state.</summary>
        long Count { get; set; }
        /// <summary>The state that the pooled resources count is for.</summary>
        string State { get; set; }

    }
}