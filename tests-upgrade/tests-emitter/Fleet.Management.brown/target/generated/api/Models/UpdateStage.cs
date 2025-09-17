// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
    /// the next stage.
    /// </summary>
    public partial class UpdateStage :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageInternal
    {

        /// <summary>Backing field for <see cref="AfterGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> _afterGate;

        /// <summary>A list of Gates that will be created after this Stage is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get => this._afterGate; set => this._afterGate = value; }

        /// <summary>Backing field for <see cref="AfterStageWaitInSecond" /> property.</summary>
        private int? _afterStageWaitInSecond;

        /// <summary>
        /// The time in seconds to wait at the end of this stage before starting the next one. Defaults to 0 seconds if unspecified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public int? AfterStageWaitInSecond { get => this._afterStageWaitInSecond; set => this._afterStageWaitInSecond = value; }

        /// <summary>Backing field for <see cref="BeforeGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> _beforeGate;

        /// <summary>A list of Gates that will be created before this Stage is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get => this._beforeGate; set => this._beforeGate = value; }

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup> _group;

        /// <summary>
        /// Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup> Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the stage. Must be unique within the UpdateRun.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UpdateStage" /> instance.</summary>
        public UpdateStage()
        {

        }
    }
    /// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
    /// the next stage.
    public partial interface IUpdateStage :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>A list of Gates that will be created after this Stage is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of Gates that will be created after this Stage is executed.",
        SerializedName = @"afterGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get; set; }
        /// <summary>
        /// The time in seconds to wait at the end of this stage before starting the next one. Defaults to 0 seconds if unspecified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time in seconds to wait at the end of this stage before starting the next one. Defaults to 0 seconds if unspecified.",
        SerializedName = @"afterStageWaitInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? AfterStageWaitInSecond { get; set; }
        /// <summary>A list of Gates that will be created before this Stage is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of Gates that will be created before this Stage is executed.",
        SerializedName = @"beforeGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get; set; }
        /// <summary>
        /// Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup> Group { get; set; }
        /// <summary>The name of the stage. Must be unique within the UpdateRun.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the stage. Must be unique within the UpdateRun.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
    /// the next stage.
    internal partial interface IUpdateStageInternal

    {
        /// <summary>A list of Gates that will be created after this Stage is executed.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get; set; }
        /// <summary>
        /// The time in seconds to wait at the end of this stage before starting the next one. Defaults to 0 seconds if unspecified.
        /// </summary>
        int? AfterStageWaitInSecond { get; set; }
        /// <summary>A list of Gates that will be created before this Stage is executed.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get; set; }
        /// <summary>
        /// Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup> Group { get; set; }
        /// <summary>The name of the stage. Must be unique within the UpdateRun.</summary>
        string Name { get; set; }

    }
}