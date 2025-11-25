// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Transport options availability details for given region.</summary>
    public partial class TransportAvailabilityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetailsInternal
    {

        /// <summary>Internal Acessors for ShipmentType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetailsInternal.ShipmentType { get => this._shipmentType; set { {_shipmentType = value;} } }

        /// <summary>Backing field for <see cref="ShipmentType" /> property.</summary>
        private string _shipmentType;

        /// <summary>Transport Shipment Type supported for given region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ShipmentType { get => this._shipmentType; }

        /// <summary>Creates an new <see cref="TransportAvailabilityDetails" /> instance.</summary>
        public TransportAvailabilityDetails()
        {

        }
    }
    /// Transport options availability details for given region.
    public partial interface ITransportAvailabilityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Transport Shipment Type supported for given region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Transport Shipment Type supported for given region.",
        SerializedName = @"shipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ShipmentType { get;  }

    }
    /// Transport options availability details for given region.
    internal partial interface ITransportAvailabilityDetailsInternal

    {
        /// <summary>Transport Shipment Type supported for given region.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ShipmentType { get; set; }

    }
}