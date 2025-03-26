// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Displays the counts of container groups in each state, as known by the StandbyPool resource provider.
    /// </summary>
    public partial class ContainerGroupInstanceCountSummary :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummaryInternal
    {

        /// <summary>Backing field for <see cref="InstanceCountsByState" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolContainerGroupStateCount> _instanceCountsByState;

        /// <summary>The count of pooled container groups in each state for the given zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolContainerGroupStateCount> InstanceCountsByState { get => this._instanceCountsByState; set => this._instanceCountsByState = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private long? _zone;

        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long? Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="ContainerGroupInstanceCountSummary" /> instance.</summary>
        public ContainerGroupInstanceCountSummary()
        {

        }
    }
    /// Displays the counts of container groups in each state, as known by the StandbyPool resource provider.
    public partial interface IContainerGroupInstanceCountSummary :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The count of pooled container groups in each state for the given zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of pooled container groups in each state for the given zone.",
        SerializedName = @"instanceCountsByState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolContainerGroupStateCount) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolContainerGroupStateCount> InstanceCountsByState { get; set; }
        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The zone that the provided counts are in. It will not have a value if zones are not enabled.",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(long) })]
        long? Zone { get; set; }

    }
    /// Displays the counts of container groups in each state, as known by the StandbyPool resource provider.
    internal partial interface IContainerGroupInstanceCountSummaryInternal

    {
        /// <summary>The count of pooled container groups in each state for the given zone.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolContainerGroupStateCount> InstanceCountsByState { get; set; }
        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled.
        /// </summary>
        long? Zone { get; set; }

    }
}