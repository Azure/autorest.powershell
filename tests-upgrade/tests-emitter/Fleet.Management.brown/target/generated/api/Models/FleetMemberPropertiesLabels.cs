// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The labels for the fleet member.</summary>
    public partial class FleetMemberPropertiesLabels :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabelsInternal
    {

        /// <summary>Creates an new <see cref="FleetMemberPropertiesLabels" /> instance.</summary>
        public FleetMemberPropertiesLabels()
        {

        }
    }
    /// The labels for the fleet member.
    public partial interface IFleetMemberPropertiesLabels :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IAssociativeArray<string>
    {

    }
    /// The labels for the fleet member.
    internal partial interface IFleetMemberPropertiesLabelsInternal

    {

    }
}