// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Represents the configuration for additional locations where Fleet resources may be deployed.
    /// </summary>
    public partial class AdditionalLocationsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalLocationsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalLocationsProfileInternal
    {

        /// <summary>Backing field for <see cref="LocationProfile" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile> _locationProfile;

        /// <summary>The list of location profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile> LocationProfile { get => this._locationProfile; set => this._locationProfile = value; }

        /// <summary>Creates an new <see cref="AdditionalLocationsProfile" /> instance.</summary>
        public AdditionalLocationsProfile()
        {

        }
    }
    /// Represents the configuration for additional locations where Fleet resources may be deployed.
    public partial interface IAdditionalLocationsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The list of location profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of location profiles.",
        SerializedName = @"locationProfiles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile> LocationProfile { get; set; }

    }
    /// Represents the configuration for additional locations where Fleet resources may be deployed.
    internal partial interface IAdditionalLocationsProfileInternal

    {
        /// <summary>The list of location profiles.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile> LocationProfile { get; set; }

    }
}