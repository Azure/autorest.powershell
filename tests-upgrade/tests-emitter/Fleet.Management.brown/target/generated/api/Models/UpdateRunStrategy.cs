// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// Defines the update sequence of the clusters via stages and groups.
    /// Stages within a run are executed sequentially one after another.
    /// Groups within a stage are executed in parallel.
    /// Member clusters within a group are updated sequentially one after another.
    /// A valid strategy contains no duplicate groups within or across stages.
    /// </summary>
    public partial class UpdateRunStrategy :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategy,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategyInternal
    {

        /// <summary>Backing field for <see cref="Stage" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> _stage;

        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> Stage { get => this._stage; set => this._stage = value; }

        /// <summary>Creates an new <see cref="UpdateRunStrategy" /> instance.</summary>
        public UpdateRunStrategy()
        {

        }
    }
    /// Defines the update sequence of the clusters via stages and groups.
    /// Stages within a run are executed sequentially one after another.
    /// Groups within a stage are executed in parallel.
    /// Member clusters within a group are updated sequentially one after another.
    /// A valid strategy contains no duplicate groups within or across stages.
    public partial interface IUpdateRunStrategy :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of stages that compose this update run. Min size: 1.",
        SerializedName = @"stages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> Stage { get; set; }

    }
    /// Defines the update sequence of the clusters via stages and groups.
    /// Stages within a run are executed sequentially one after another.
    /// Groups within a stage are executed in parallel.
    /// Member clusters within a group are updated sequentially one after another.
    /// A valid strategy contains no duplicate groups within or across stages.
    internal partial interface IUpdateRunStrategyInternal

    {
        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> Stage { get; set; }

    }
}