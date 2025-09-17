// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The type used for update operations of the FleetMember.</summary>
    public partial class FleetMemberUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateInternal
    {

        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Group { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesInternal)Property).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesInternal)Property).Group = value ?? null; }

        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels Label { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesInternal)Property).Label; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesInternal)Property).Label = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberUpdateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="FleetMemberUpdate" /> instance.</summary>
        public FleetMemberUpdate()
        {

        }
    }
    /// The type used for update operations of the FleetMember.
    public partial interface IFleetMemberUpdate :
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
    /// The type used for update operations of the FleetMember.
    internal partial interface IFleetMemberUpdateInternal

    {
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdatePropertiesLabels Label { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberUpdateProperties Property { get; set; }

    }
}