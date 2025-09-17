// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Represents a scaling mechanism for adding or removing instances of stateless service partition.
    /// </summary>
    public partial class PartitionInstanceCountScaleMechanism :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInstanceCountScaleMechanism,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInstanceCountScaleMechanismInternal,
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
        public string Kind { get => "ScalePartitionInstanceCount"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanismInternal)__scalingMechanism).Kind = "ScalePartitionInstanceCount"; }

        /// <summary>Backing field for <see cref="MaxInstanceCount" /> property.</summary>
        private int _maxInstanceCount;

        /// <summary>Maximum number of instances of the partition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MaxInstanceCount { get => this._maxInstanceCount; set => this._maxInstanceCount = value; }

        /// <summary>Backing field for <see cref="MinInstanceCount" /> property.</summary>
        private int _minInstanceCount;

        /// <summary>Minimum number of instances of the partition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int MinInstanceCount { get => this._minInstanceCount; set => this._minInstanceCount = value; }

        /// <summary>Backing field for <see cref="ScaleIncrement" /> property.</summary>
        private int _scaleIncrement;

        /// <summary>The number of instances to add or remove during a scaling operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int ScaleIncrement { get => this._scaleIncrement; set => this._scaleIncrement = value; }

        /// <summary>Creates an new <see cref="PartitionInstanceCountScaleMechanism" /> instance.</summary>
        public PartitionInstanceCountScaleMechanism()
        {
            this.__scalingMechanism.Kind = "ScalePartitionInstanceCount";
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
    /// Represents a scaling mechanism for adding or removing instances of stateless service partition.
    public partial interface IPartitionInstanceCountScaleMechanism :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanism
    {
        /// <summary>Maximum number of instances of the partition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum number of instances of the partition.",
        SerializedName = @"maxInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int MaxInstanceCount { get; set; }
        /// <summary>Minimum number of instances of the partition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum number of instances of the partition.",
        SerializedName = @"minInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int MinInstanceCount { get; set; }
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
    /// Represents a scaling mechanism for adding or removing instances of stateless service partition.
    internal partial interface IPartitionInstanceCountScaleMechanismInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanismInternal
    {
        /// <summary>Maximum number of instances of the partition.</summary>
        int MaxInstanceCount { get; set; }
        /// <summary>Minimum number of instances of the partition.</summary>
        int MinInstanceCount { get; set; }
        /// <summary>The number of instances to add or remove during a scaling operation.</summary>
        int ScaleIncrement { get; set; }

    }
}