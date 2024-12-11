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
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount> _instanceCountsByState;

        /// <summary>The count of pooled resources in each state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount> InstanceCountsByState { get => this._instanceCountsByState; set => this._instanceCountsByState = value; }

        /// <summary>Creates an new <see cref="ContainerGroupInstanceCountSummary" /> instance.</summary>
        public ContainerGroupInstanceCountSummary()
        {

        }
    }
    /// Displays the counts of container groups in each state, as known by the StandbyPool resource provider.
    public partial interface IContainerGroupInstanceCountSummary :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The count of pooled resources in each state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of pooled resources in each state.",
        SerializedName = @"instanceCountsByState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount> InstanceCountsByState { get; set; }

    }
    /// Displays the counts of container groups in each state, as known by the StandbyPool resource provider.
    internal partial interface IContainerGroupInstanceCountSummaryInternal

    {
        /// <summary>The count of pooled resources in each state.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolResourceStateCount> InstanceCountsByState { get; set; }

    }
}