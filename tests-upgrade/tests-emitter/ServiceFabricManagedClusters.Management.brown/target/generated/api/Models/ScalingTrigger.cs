// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the trigger for performing a scaling operation.</summary>
    public partial class ScalingTrigger :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTrigger,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingTriggerInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="ScalingTrigger" /> instance.</summary>
        public ScalingTrigger()
        {

        }
    }
    /// Describes the trigger for performing a scaling operation.
    public partial interface IScalingTrigger :
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
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("AveragePartitionLoadTrigger", "AverageServiceLoadTrigger")]
        string Kind { get; set; }

    }
    /// Describes the trigger for performing a scaling operation.
    internal partial interface IScalingTriggerInternal

    {
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("AveragePartitionLoadTrigger", "AverageServiceLoadTrigger")]
        string Kind { get; set; }

    }
}