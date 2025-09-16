// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Represents a scaling trigger related to an average load of a metric/resource of a partition.
    /// </summary>
    public partial class AveragePartitionLoadScalingTrigger :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAveragePartitionLoadScalingTrigger,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAveragePartitionLoadScalingTriggerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTrigger"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTrigger __scalingTrigger = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingTrigger();

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Kind { get => "AveragePartitionLoadTrigger"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTriggerInternal)__scalingTrigger).Kind = "AveragePartitionLoadTrigger"; }

        /// <summary>Backing field for <see cref="LowerLoadThreshold" /> property.</summary>
        private double _lowerLoadThreshold;

        /// <summary>
        /// The lower limit of the load below which a scale in operation should be performed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public double LowerLoadThreshold { get => this._lowerLoadThreshold; set => this._lowerLoadThreshold = value; }

        /// <summary>Backing field for <see cref="MetricName" /> property.</summary>
        private string _metricName;

        /// <summary>The name of the metric for which usage should be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string MetricName { get => this._metricName; set => this._metricName = value; }

        /// <summary>Backing field for <see cref="ScaleInterval" /> property.</summary>
        private string _scaleInterval;

        /// <summary>
        /// The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ScaleInterval { get => this._scaleInterval; set => this._scaleInterval = value; }

        /// <summary>Backing field for <see cref="UpperLoadThreshold" /> property.</summary>
        private double _upperLoadThreshold;

        /// <summary>
        /// The upper limit of the load beyond which a scale out operation should be performed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public double UpperLoadThreshold { get => this._upperLoadThreshold; set => this._upperLoadThreshold = value; }

        /// <summary>Creates an new <see cref="AveragePartitionLoadScalingTrigger" /> instance.</summary>
        public AveragePartitionLoadScalingTrigger()
        {
            this.__scalingTrigger.Kind = "AveragePartitionLoadTrigger";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scalingTrigger), __scalingTrigger);
            await eventListener.AssertObjectIsValid(nameof(__scalingTrigger), __scalingTrigger);
        }
    }
    /// Represents a scaling trigger related to an average load of a metric/resource of a partition.
    public partial interface IAveragePartitionLoadScalingTrigger :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTrigger
    {
        /// <summary>
        /// The lower limit of the load below which a scale in operation should be performed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The lower limit of the load below which a scale in operation should be performed.",
        SerializedName = @"lowerLoadThreshold",
        PossibleTypes = new [] { typeof(double) })]
        double LowerLoadThreshold { get; set; }
        /// <summary>The name of the metric for which usage should be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the metric for which usage should be tracked.",
        SerializedName = @"metricName",
        PossibleTypes = new [] { typeof(string) })]
        string MetricName { get; set; }
        /// <summary>
        /// The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format ""hh:mm:ss"".",
        SerializedName = @"scaleInterval",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleInterval { get; set; }
        /// <summary>
        /// The upper limit of the load beyond which a scale out operation should be performed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The upper limit of the load beyond which a scale out operation should be performed.",
        SerializedName = @"upperLoadThreshold",
        PossibleTypes = new [] { typeof(double) })]
        double UpperLoadThreshold { get; set; }

    }
    /// Represents a scaling trigger related to an average load of a metric/resource of a partition.
    internal partial interface IAveragePartitionLoadScalingTriggerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTriggerInternal
    {
        /// <summary>
        /// The lower limit of the load below which a scale in operation should be performed.
        /// </summary>
        double LowerLoadThreshold { get; set; }
        /// <summary>The name of the metric for which usage should be tracked.</summary>
        string MetricName { get; set; }
        /// <summary>
        /// The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        string ScaleInterval { get; set; }
        /// <summary>
        /// The upper limit of the load beyond which a scale out operation should be performed.
        /// </summary>
        double UpperLoadThreshold { get; set; }

    }
}