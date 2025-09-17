// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the mechanism for performing a scaling operation.</summary>
    public partial class ScalingMechanism :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanism,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingMechanismInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="ScalingMechanism" /> instance.</summary>
        public ScalingMechanism()
        {

        }
    }
    /// Describes the mechanism for performing a scaling operation.
    public partial interface IScalingMechanism :
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
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("ScalePartitionInstanceCount", "AddRemoveIncrementalNamedPartition")]
        string Kind { get; set; }

    }
    /// Describes the mechanism for performing a scaling operation.
    internal partial interface IScalingMechanismInternal

    {
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("ScalePartitionInstanceCount", "AddRemoveIncrementalNamedPartition")]
        string Kind { get; set; }

    }
}