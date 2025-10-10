// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Available SKUs of tier and units.</summary>
    public partial class IotDpsSkuDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="IotDpsSkuDefinition" /> instance.</summary>
        public IotDpsSkuDefinition()
        {

        }
    }
    /// Available SKUs of tier and units.
    public partial interface IIotDpsSkuDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
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

    }
    /// Available SKUs of tier and units.
    internal partial interface IIotDpsSkuDefinitionInternal

    {
        /// <summary>Sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("S1")]
        string Name { get; set; }

    }
}