// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Device capabilities for given sku in a region</summary>
    public partial class DeviceCapabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponseInternal
    {

        /// <summary>Backing field for <see cref="DeviceCapabilityDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> _deviceCapabilityDetail;

        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityDetail { get => this._deviceCapabilityDetail; }

        /// <summary>Internal Acessors for DeviceCapabilityDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponseInternal.DeviceCapabilityDetail { get => this._deviceCapabilityDetail; set { {_deviceCapabilityDetail = value;} } }

        /// <summary>Creates an new <see cref="DeviceCapabilityResponse" /> instance.</summary>
        public DeviceCapabilityResponse()
        {

        }
    }
    /// Device capabilities for given sku in a region
    public partial interface IDeviceCapabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of device capabilities available for a given region and a given sku",
        SerializedName = @"deviceCapabilityDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityDetail { get;  }

    }
    /// Device capabilities for given sku in a region
    internal partial interface IDeviceCapabilityResponseInternal

    {
        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityDetail { get; set; }

    }
}