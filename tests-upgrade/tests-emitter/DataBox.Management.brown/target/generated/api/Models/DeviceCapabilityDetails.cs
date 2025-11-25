// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Device capability details for a given sku for a given region.</summary>
    public partial class DeviceCapabilityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetailsInternal
    {

        /// <summary>Backing field for <see cref="HardwareEncryption" /> property.</summary>
        private string _hardwareEncryption;

        /// <summary>Hardware encryption support for a given sku for a given region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string HardwareEncryption { get => this._hardwareEncryption; }

        /// <summary>Internal Acessors for HardwareEncryption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetailsInternal.HardwareEncryption { get => this._hardwareEncryption; set { {_hardwareEncryption = value;} } }

        /// <summary>Creates an new <see cref="DeviceCapabilityDetails" /> instance.</summary>
        public DeviceCapabilityDetails()
        {

        }
    }
    /// Device capability details for a given sku for a given region.
    public partial interface IDeviceCapabilityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Hardware encryption support for a given sku for a given region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Hardware encryption support for a given sku for a given region.",
        SerializedName = @"hardwareEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string HardwareEncryption { get;  }

    }
    /// Device capability details for a given sku for a given region.
    internal partial interface IDeviceCapabilityDetailsInternal

    {
        /// <summary>Hardware encryption support for a given sku for a given region.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string HardwareEncryption { get; set; }

    }
}