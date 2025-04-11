// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Displays prediction information of the standby pool.</summary>
    public partial class StandbyVirtualMachinePoolPrediction :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal
    {

        /// <summary>Backing field for <see cref="ForecastInfo" /> property.</summary>
        private string _forecastInfo;

        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ForecastInfo { get => this._forecastInfo; }

        /// <summary>Backing field for <see cref="ForecastStartTime" /> property.</summary>
        private global::System.DateTime? _forecastStartTime;

        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public global::System.DateTime? ForecastStartTime { get => this._forecastStartTime; }

        /// <summary>Backing field for <see cref="ForecastValue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues _forecastValue;

        /// <summary>Displays the forecast information of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues ForecastValue { get => (this._forecastValue = this._forecastValue ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolForecastValues()); }

        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValuesInternal)ForecastValue).InstancesRequestedCount; }

        /// <summary>Internal Acessors for ForecastInfo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal.ForecastInfo { get => this._forecastInfo; set { {_forecastInfo = value;} } }

        /// <summary>Internal Acessors for ForecastStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal.ForecastStartTime { get => this._forecastStartTime; set { {_forecastStartTime = value;} } }

        /// <summary>Internal Acessors for ForecastValue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal.ForecastValue { get => (this._forecastValue = this._forecastValue ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolForecastValues()); set { {_forecastValue = value;} } }

        /// <summary>Internal Acessors for ForecastValueInstancesRequestedCount</summary>
        System.Collections.Generic.List<long> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal.ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValuesInternal)ForecastValue).InstancesRequestedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValuesInternal)ForecastValue).InstancesRequestedCount = value; }

        /// <summary>Creates an new <see cref="StandbyVirtualMachinePoolPrediction" /> instance.</summary>
        public StandbyVirtualMachinePoolPrediction()
        {

        }
    }
    /// Displays prediction information of the standby pool.
    public partial interface IStandbyVirtualMachinePoolPrediction :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays additional information for the prediction of the standby pool.",
        SerializedName = @"forecastInfo",
        PossibleTypes = new [] { typeof(string) })]
        string ForecastInfo { get;  }
        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the UTC timestamp of when the prediction was retrieved for the standby pool.",
        SerializedName = @"forecastStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ForecastStartTime { get;  }
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
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get;  }

    }
    /// Displays prediction information of the standby pool.
    internal partial interface IStandbyVirtualMachinePoolPredictionInternal

    {
        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        string ForecastInfo { get; set; }
        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        global::System.DateTime? ForecastStartTime { get; set; }
        /// <summary>Displays the forecast information of the standby pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues ForecastValue { get; set; }
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get; set; }

    }
}