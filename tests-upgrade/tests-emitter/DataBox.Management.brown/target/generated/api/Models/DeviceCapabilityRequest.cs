// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the device capabilities for given sku.</summary>
    public partial class DeviceCapabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequestInternal
    {

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="SkuName" /> property.</summary>
        private string _skuName;

        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SkuName { get => this._skuName; set => this._skuName = value; }

        /// <summary>Creates an new <see cref="DeviceCapabilityRequest" /> instance.</summary>
        public DeviceCapabilityRequest()
        {

        }
    }
    /// Request body to get the device capabilities for given sku.
    public partial interface IDeviceCapabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the device.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }

    }
    /// Request body to get the device capabilities for given sku.
    internal partial interface IDeviceCapabilityRequestInternal

    {
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Type of the device.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }

    }
}