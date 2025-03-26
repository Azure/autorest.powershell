// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Displays the forecast information of the standby pool.</summary>
    public partial class StandbyContainerGroupPoolForecastValues :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolForecastValues,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolForecastValuesInternal
    {

        /// <summary>Backing field for <see cref="InstancesRequestedCount" /> property.</summary>
        private System.Collections.Generic.List<long> _instancesRequestedCount;

        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<long> InstancesRequestedCount { get => this._instancesRequestedCount; }

        /// <summary>Internal Acessors for InstancesRequestedCount</summary>
        System.Collections.Generic.List<long> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolForecastValuesInternal.InstancesRequestedCount { get => this._instancesRequestedCount; set { {_instancesRequestedCount = value;} } }

        /// <summary>Creates an new <see cref="StandbyContainerGroupPoolForecastValues" /> instance.</summary>
        public StandbyContainerGroupPoolForecastValues()
        {

        }
    }
    /// Displays the forecast information of the standby pool.
    public partial interface IStandbyContainerGroupPoolForecastValues :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the predicted count of instances to be requested from the standby pool.",
        SerializedName = @"instancesRequestedCount",
        PossibleTypes = new [] { typeof(long) })]
        System.Collections.Generic.List<long> InstancesRequestedCount { get;  }

    }
    /// Displays the forecast information of the standby pool.
    internal partial interface IStandbyContainerGroupPoolForecastValuesInternal

    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        System.Collections.Generic.List<long> InstancesRequestedCount { get; set; }

    }
}