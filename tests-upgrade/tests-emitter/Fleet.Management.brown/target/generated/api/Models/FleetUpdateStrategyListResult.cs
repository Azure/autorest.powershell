// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The response of a FleetUpdateStrategy list operation.</summary>
    public partial class FleetUpdateStrategyListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategyListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategyListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategy> _value;

        /// <summary>The FleetUpdateStrategy items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategy> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FleetUpdateStrategyListResult" /> instance.</summary>
        public FleetUpdateStrategyListResult()
        {

        }
    }
    /// The response of a FleetUpdateStrategy list operation.
    public partial interface IFleetUpdateStrategyListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The FleetUpdateStrategy items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The FleetUpdateStrategy items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategy) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategy> Value { get; set; }

    }
    /// The response of a FleetUpdateStrategy list operation.
    internal partial interface IFleetUpdateStrategyListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The FleetUpdateStrategy items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetUpdateStrategy> Value { get; set; }

    }
}