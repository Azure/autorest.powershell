// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>The parameters of a capacity reservation Profile.</summary>
    public partial class CapacityReservationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ICapacityReservationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ICapacityReservationProfileInternal
    {

        /// <summary>Backing field for <see cref="CapacityReservationGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource _capacityReservationGroup;

        /// <summary>
        /// Specifies the capacity reservation group resource id that should be used for
        /// allocating the virtual machine or scaleset vm instances provided enough
        /// capacity has been reserved. Please refer to https://aka.ms/CapacityReservation
        /// for more details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource CapacityReservationGroup { get => (this._capacityReservationGroup = this._capacityReservationGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set => this._capacityReservationGroup = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string CapacityReservationGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)CapacityReservationGroup).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)CapacityReservationGroup).Id = value ?? null; }

        /// <summary>Internal Acessors for CapacityReservationGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ICapacityReservationProfileInternal.CapacityReservationGroup { get => (this._capacityReservationGroup = this._capacityReservationGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set { {_capacityReservationGroup = value;} } }

        /// <summary>Creates an new <see cref="CapacityReservationProfile" /> instance.</summary>
        public CapacityReservationProfile()
        {

        }
    }
    /// The parameters of a capacity reservation Profile.
    public partial interface ICapacityReservationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string CapacityReservationGroupId { get; set; }

    }
    /// The parameters of a capacity reservation Profile.
    internal partial interface ICapacityReservationProfileInternal

    {
        /// <summary>
        /// Specifies the capacity reservation group resource id that should be used for
        /// allocating the virtual machine or scaleset vm instances provided enough
        /// capacity has been reserved. Please refer to https://aka.ms/CapacityReservation
        /// for more details.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource CapacityReservationGroup { get; set; }
        /// <summary>Resource Id</summary>
        string CapacityReservationGroupId { get; set; }

    }
}