// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes a partitioning scheme where an integer range is allocated evenly across a number of partitions.
    /// </summary>
    public partial class UniformInt64RangePartitionScheme :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IUniformInt64RangePartitionScheme,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IUniformInt64RangePartitionSchemeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition __partition = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Partition();

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int _count;

        /// <summary>The number of partitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="HighKey" /> property.</summary>
        private long _highKey;

        /// <summary>
        /// The upper bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public long HighKey { get => this._highKey; set => this._highKey = value; }

        /// <summary>Backing field for <see cref="LowKey" /> property.</summary>
        private long _lowKey;

        /// <summary>
        /// The lower bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public long LowKey { get => this._lowKey; set => this._lowKey = value; }

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Scheme { get => "UniformInt64Range"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal)__partition).Scheme = "UniformInt64Range"; }

        /// <summary>Creates an new <see cref="UniformInt64RangePartitionScheme" /> instance.</summary>
        public UniformInt64RangePartitionScheme()
        {
            this.__partition.Scheme = "UniformInt64Range";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__partition), __partition);
            await eventListener.AssertObjectIsValid(nameof(__partition), __partition);
        }
    }
    /// Describes a partitioning scheme where an integer range is allocated evenly across a number of partitions.
    public partial interface IUniformInt64RangePartitionScheme :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition
    {
        /// <summary>The number of partitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of partitions.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int Count { get; set; }
        /// <summary>
        /// The upper bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The upper bound of the partition key range that
        should be split between the partition ‘Count’",
        SerializedName = @"highKey",
        PossibleTypes = new [] { typeof(long) })]
        long HighKey { get; set; }
        /// <summary>
        /// The lower bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The lower bound of the partition key range that
        should be split between the partition ‘Count’",
        SerializedName = @"lowKey",
        PossibleTypes = new [] { typeof(long) })]
        long LowKey { get; set; }

    }
    /// Describes a partitioning scheme where an integer range is allocated evenly across a number of partitions.
    internal partial interface IUniformInt64RangePartitionSchemeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal
    {
        /// <summary>The number of partitions.</summary>
        int Count { get; set; }
        /// <summary>
        /// The upper bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        long HighKey { get; set; }
        /// <summary>
        /// The lower bound of the partition key range that
        /// should be split between the partition ‘Count’
        /// </summary>
        long LowKey { get; set; }

    }
}