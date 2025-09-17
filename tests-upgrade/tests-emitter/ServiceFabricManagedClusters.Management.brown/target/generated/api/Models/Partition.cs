// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes how the service is partitioned.</summary>
    public partial class Partition :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal
    {

        /// <summary>Backing field for <see cref="Scheme" /> property.</summary>
        private string _scheme;

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Scheme { get => this._scheme; set => this._scheme = value; }

        /// <summary>Creates an new <see cref="Partition" /> instance.</summary>
        public Partition()
        {

        }
    }
    /// Describes how the service is partitioned.
    public partial interface IPartition :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enumerates the ways that a service can be partitioned.",
        SerializedName = @"partitionScheme",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Singleton", "UniformInt64Range", "Named")]
        string Scheme { get; set; }

    }
    /// Describes how the service is partitioned.
    internal partial interface IPartitionInternal

    {
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Singleton", "UniformInt64Range", "Named")]
        string Scheme { get; set; }

    }
}