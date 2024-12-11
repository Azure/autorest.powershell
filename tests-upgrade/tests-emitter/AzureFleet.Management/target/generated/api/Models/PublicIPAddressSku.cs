// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes the public IP Sku. It can only be set with OrchestrationMode as
    /// Flexible.
    /// </summary>
    public partial class PublicIPAddressSku :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSku,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSkuInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Specify public IP sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private string _tier;

        /// <summary>Specify public IP sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Tier { get => this._tier; set => this._tier = value; }

        /// <summary>Creates an new <see cref="PublicIPAddressSku" /> instance.</summary>
        public PublicIPAddressSku()
        {

        }
    }
    /// Describes the public IP Sku. It can only be set with OrchestrationMode as
    /// Flexible.
    public partial interface IPublicIPAddressSku :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specify public IP sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify public IP sku name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Basic", "Standard")]
        string Name { get; set; }
        /// <summary>Specify public IP sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify public IP sku tier",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Regional", "Global")]
        string Tier { get; set; }

    }
    /// Describes the public IP Sku. It can only be set with OrchestrationMode as
    /// Flexible.
    internal partial interface IPublicIPAddressSkuInternal

    {
        /// <summary>Specify public IP sku name</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Basic", "Standard")]
        string Name { get; set; }
        /// <summary>Specify public IP sku tier</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Regional", "Global")]
        string Tier { get; set; }

    }
}