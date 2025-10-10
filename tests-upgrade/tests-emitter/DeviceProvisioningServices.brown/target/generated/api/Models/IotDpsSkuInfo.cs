// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>List of possible provisioning service SKUs.</summary>
    public partial class IotDpsSkuInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private long? _capacity;

        /// <summary>The number of units to provision</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public long? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Internal Acessors for Tier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfoInternal.Tier { get => this._tier; set { {_tier = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private string _tier;

        /// <summary>Pricing tier name of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Tier { get => this._tier; }

        /// <summary>Creates an new <see cref="IotDpsSkuInfo" /> instance.</summary>
        public IotDpsSkuInfo()
        {

        }
    }
    /// List of possible provisioning service SKUs.
    public partial interface IIotDpsSkuInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The number of units to provision</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of units to provision",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? Capacity { get; set; }
        /// <summary>Sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("S1")]
        string Name { get; set; }
        /// <summary>Pricing tier name of the provisioning service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Pricing tier name of the provisioning service.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string Tier { get;  }

    }
    /// List of possible provisioning service SKUs.
    internal partial interface IIotDpsSkuInfoInternal

    {
        /// <summary>The number of units to provision</summary>
        long? Capacity { get; set; }
        /// <summary>Sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("S1")]
        string Name { get; set; }
        /// <summary>Pricing tier name of the provisioning service.</summary>
        string Tier { get; set; }

    }
}