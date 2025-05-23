// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Request to the action call to bulk claim devices.</summary>
    public partial class ClaimDevicesRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IClaimDevicesRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IClaimDevicesRequestInternal
    {

        /// <summary>Backing field for <see cref="DeviceIdentifier" /> property.</summary>
        private System.Collections.Generic.List<string> _deviceIdentifier;

        /// <summary>Device identifiers of the devices to be claimed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DeviceIdentifier { get => this._deviceIdentifier; set => this._deviceIdentifier = value; }

        /// <summary>Creates an new <see cref="ClaimDevicesRequest" /> instance.</summary>
        public ClaimDevicesRequest()
        {

        }
    }
    /// Request to the action call to bulk claim devices.
    public partial interface IClaimDevicesRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Device identifiers of the devices to be claimed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device identifiers of the devices to be claimed.",
        SerializedName = @"deviceIdentifiers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DeviceIdentifier { get; set; }

    }
    /// Request to the action call to bulk claim devices.
    internal partial interface IClaimDevicesRequestInternal

    {
        /// <summary>Device identifiers of the devices to be claimed.</summary>
        System.Collections.Generic.List<string> DeviceIdentifier { get; set; }

    }
}