// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The updatable properties of the FleetMember.</summary>
    public partial class FleetMemberUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private string _group;

        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels _label;

        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels Label { get => (this._label = this._label ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberUpdatePropertiesLabels()); set => this._label = value; }

        /// <summary>Creates an new <see cref="FleetMemberUpdateProperties" /> instance.</summary>
        public FleetMemberUpdateProperties()
        {

        }
    }
    /// The updatable properties of the FleetMember.
    public partial interface IFleetMemberUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The group this member belongs to for multi-cluster update management.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The labels for the fleet member.",
        SerializedName = @"labels",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels Label { get; set; }

    }
    /// The updatable properties of the FleetMember.
    internal partial interface IFleetMemberUpdatePropertiesInternal

    {
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels Label { get; set; }

    }
}