// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Shipment pick up request details.</summary>
    public partial class ShipmentPickUpRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShipmentPickUpRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShipmentPickUpRequestInternal
    {

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime _endTime;

        /// <summary>
        /// Maximum date before which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="ShipmentLocation" /> property.</summary>
        private string _shipmentLocation;

        /// <summary>Shipment Location in the pickup place. Eg.front desk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ShipmentLocation { get => this._shipmentLocation; set => this._shipmentLocation = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime _startTime;

        /// <summary>
        /// Minimum date after which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Creates an new <see cref="ShipmentPickUpRequest" /> instance.</summary>
        public ShipmentPickUpRequest()
        {

        }
    }
    /// Shipment pick up request details.
    public partial interface IShipmentPickUpRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Maximum date before which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum date before which the pick up should commence, this must be in local time of pick up area.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EndTime { get; set; }
        /// <summary>Shipment Location in the pickup place. Eg.front desk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Shipment Location in the pickup place. Eg.front desk",
        SerializedName = @"shipmentLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ShipmentLocation { get; set; }
        /// <summary>
        /// Minimum date after which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum date after which the pick up should commence, this must be in local time of pick up area.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTime { get; set; }

    }
    /// Shipment pick up request details.
    internal partial interface IShipmentPickUpRequestInternal

    {
        /// <summary>
        /// Maximum date before which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        global::System.DateTime EndTime { get; set; }
        /// <summary>Shipment Location in the pickup place. Eg.front desk</summary>
        string ShipmentLocation { get; set; }
        /// <summary>
        /// Minimum date after which the pick up should commence, this must be in local time of pick up area.
        /// </summary>
        global::System.DateTime StartTime { get; set; }

    }
}