// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Package carrier details.</summary>
    public partial class PackageCarrierDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal
    {

        /// <summary>Backing field for <see cref="CarrierAccountNumber" /> property.</summary>
        private System.Security.SecureString _carrierAccountNumber;

        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Security.SecureString CarrierAccountNumber { get => this._carrierAccountNumber; set => this._carrierAccountNumber = value; }

        /// <summary>Backing field for <see cref="CarrierName" /> property.</summary>
        private string _carrierName;

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CarrierName { get => this._carrierName; set => this._carrierName = value; }

        /// <summary>Backing field for <see cref="TrackingId" /> property.</summary>
        private string _trackingId;

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string TrackingId { get => this._trackingId; set => this._trackingId = value; }

        /// <summary>Creates an new <see cref="PackageCarrierDetails" /> instance.</summary>
        public PackageCarrierDetails()
        {

        }
    }
    /// Package carrier details.
    public partial interface IPackageCarrierDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Carrier Account Number of customer for customer disk.",
        SerializedName = @"carrierAccountNumber",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString CarrierAccountNumber { get; set; }
        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the carrier.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string CarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tracking Id of shipment.",
        SerializedName = @"trackingId",
        PossibleTypes = new [] { typeof(string) })]
        string TrackingId { get; set; }

    }
    /// Package carrier details.
    internal partial interface IPackageCarrierDetailsInternal

    {
        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        System.Security.SecureString CarrierAccountNumber { get; set; }
        /// <summary>Name of the carrier.</summary>
        string CarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string TrackingId { get; set; }

    }
}