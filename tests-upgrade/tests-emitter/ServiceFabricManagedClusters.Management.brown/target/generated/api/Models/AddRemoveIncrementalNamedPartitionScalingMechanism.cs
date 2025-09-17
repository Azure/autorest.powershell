// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Represents a scaling mechanism for adding or removing named partitions of a stateless service. Partition names are in
    /// the format '0','1'...'N-1'.
    /// </summary>
    public partial class AddRemoveIncrementalNamedPartitionScalingMechanism :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAddRemoveIncrementalNamedPartitionScalingMechanism,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAddRemoveIncrementalNamedPartitionScalingMechanismInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanism"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanism __scalingMechanism = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingMechanism();

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Kind { get => "AddRemoveIncrementalNamedPartition"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanismInternal)__scalingMechanism).Kind = "AddRemoveIncrementalNamedPartition"; }

        /// <summary>Backing field for <see cref="MaxPartitionCount" /> property.</summary>
        private int _maxPartitionCount;

        /// <summary>Maximum number of named partitions of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxPartitionCount { get => this._maxPartitionCount; set => this._maxPartitionCount = value; }

        /// <summary>Backing field for <see cref="MinPartitionCount" /> property.</summary>
        private int _minPartitionCount;

        /// <summary>Minimum number of named partitions of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MinPartitionCount { get => this._minPartitionCount; set => this._minPartitionCount = value; }

        /// <summary>Backing field for <see cref="ScaleIncrement" /> property.</summary>
        private int _scaleIncrement;

        /// <summary>The number of instances to add or remove during a scaling operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int ScaleIncrement { get => this._scaleIncrement; set => this._scaleIncrement = value; }

        /// <summary>
        /// Creates an new <see cref="AddRemoveIncrementalNamedPartitionScalingMechanism" /> instance.
        /// </summary>
        public AddRemoveIncrementalNamedPartitionScalingMechanism()
        {
            this.__scalingMechanism.Kind = "AddRemoveIncrementalNamedPartition";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scalingMechanism), __scalingMechanism);
            await eventListener.AssertObjectIsValid(nameof(__scalingMechanism), __scalingMechanism);
        }
    }
    /// Represents a scaling mechanism for adding or removing named partitions of a stateless service. Partition names are in
    /// the format '0','1'...'N-1'.
    public partial interface IAddRemoveIncrementalNamedPartitionScalingMechanism :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanism
    {
        /// <summary>Maximum number of named partitions of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum number of named partitions of the service.",
        SerializedName = @"maxPartitionCount",
        PossibleTypes = new [] { typeof(int) })]
        int MaxPartitionCount { get; set; }
        /// <summary>Minimum number of named partitions of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum number of named partitions of the service.",
        SerializedName = @"minPartitionCount",
        PossibleTypes = new [] { typeof(int) })]
        int MinPartitionCount { get; set; }
        /// <summary>The number of instances to add or remove during a scaling operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of instances to add or remove during a scaling operation.",
        SerializedName = @"scaleIncrement",
        PossibleTypes = new [] { typeof(int) })]
        int ScaleIncrement { get; set; }

    }
    /// Represents a scaling mechanism for adding or removing named partitions of a stateless service. Partition names are in
    /// the format '0','1'...'N-1'.
    internal partial interface IAddRemoveIncrementalNamedPartitionScalingMechanismInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanismInternal
    {
        /// <summary>Maximum number of named partitions of the service.</summary>
        int MaxPartitionCount { get; set; }
        /// <summary>Minimum number of named partitions of the service.</summary>
        int MinPartitionCount { get; set; }
        /// <summary>The number of instances to add or remove during a scaling operation.</summary>
        int ScaleIncrement { get; set; }

    }
}