// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    /// </summary>
    public partial class StandbyVirtualMachinePoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal
    {

        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastValueInstancesRequestedCount; }

        /// <summary>Backing field for <see cref="InstanceCountSummary" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> _instanceCountSummary;

        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without
        /// zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get => this._instanceCountSummary; }

        /// <summary>Internal Acessors for ForecastValueInstancesRequestedCount</summary>
        System.Collections.Generic.List<long> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastValueInstancesRequestedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastValueInstancesRequestedCount = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for InstanceCountSummary</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.InstanceCountSummary { get => this._instanceCountSummary; set { {_instanceCountSummary = value;} } }

        /// <summary>Internal Acessors for Prediction</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.Prediction { get => (this._prediction = this._prediction ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolPrediction()); set { {_prediction = value;} } }

        /// <summary>Internal Acessors for PredictionForecastInfo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.PredictionForecastInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastInfo = value ?? null; }

        /// <summary>Internal Acessors for PredictionForecastStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.PredictionForecastStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for PredictionForecastValue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.PredictionForecastValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastValue = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.PoolStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Code = value ?? null; }

        /// <summary>Internal Acessors for StatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Message = value ?? null; }

        /// <summary>Backing field for <see cref="Prediction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction _prediction;

        /// <summary>Displays prediction information of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction Prediction { get => (this._prediction = this._prediction ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolPrediction()); }

        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string PredictionForecastInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastInfo; }

        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public global::System.DateTime? PredictionForecastStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPredictionInternal)Prediction).ForecastStartTime; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus _status;

        /// <summary>Display status of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.PoolStatus()); }

        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Code; }

        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal)Status).Message; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolRuntimeViewResourceProperties" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolRuntimeViewResourceProperties()
        {

        }
    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    public partial interface IStandbyVirtualMachinePoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the predicted count of instances to be requested from the standby pool.",
        SerializedName = @"instancesRequestedCount",
        PossibleTypes = new [] { typeof(long) })]
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get;  }
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without
        /// zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned.",
        SerializedName = @"instanceCountSummary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get;  }
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
        string PredictionForecastInfo { get;  }
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
        global::System.DateTime? PredictionForecastStartTime { get;  }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the provisioning state of the standby pool",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the healthy state of the StandbyPool.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string StatusCode { get;  }
        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the StandbyPool health state details.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get;  }

    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    internal partial interface IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal

    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get; set; }
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without
        /// zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get; set; }
        /// <summary>Displays prediction information of the standby pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction Prediction { get; set; }
        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        string PredictionForecastInfo { get; set; }
        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        global::System.DateTime? PredictionForecastStartTime { get; set; }
        /// <summary>Displays the forecast information of the standby pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues PredictionForecastValue { get; set; }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Display status of the standby pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus Status { get; set; }
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string StatusCode { get; set; }
        /// <summary>Displays the StandbyPool health state details.</summary>
        string StatusMessage { get; set; }

    }
}