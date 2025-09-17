// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The definition of a single skip request.</summary>
    public partial class SkipTarget :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTargetInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The skip target's name.
        /// To skip a member/group/stage, use the member/group/stage's name;
        /// Tp skip an after stage wait, use the parent stage's name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The skip target type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SkipTarget" /> instance.</summary>
        public SkipTarget()
        {

        }
    }
    /// The definition of a single skip request.
    public partial interface ISkipTarget :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The skip target's name.
        /// To skip a member/group/stage, use the member/group/stage's name;
        /// Tp skip an after stage wait, use the parent stage's name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The skip target's name.
        To skip a member/group/stage, use the member/group/stage's name;
        Tp skip an after stage wait, use the parent stage's name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The skip target type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The skip target type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Member", "Group", "Stage", "AfterStageWait")]
        string Type { get; set; }

    }
    /// The definition of a single skip request.
    internal partial interface ISkipTargetInternal

    {
        /// <summary>
        /// The skip target's name.
        /// To skip a member/group/stage, use the member/group/stage's name;
        /// Tp skip an after stage wait, use the parent stage's name.
        /// </summary>
        string Name { get; set; }
        /// <summary>The skip target type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Member", "Group", "Stage", "AfterStageWait")]
        string Type { get; set; }

    }
}