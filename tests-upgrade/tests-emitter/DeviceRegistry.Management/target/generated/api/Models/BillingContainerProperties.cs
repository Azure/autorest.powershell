// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the billingContainer properties.</summary>
    public partial class BillingContainerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IBillingContainerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="BillingContainerProperties" /> instance.</summary>
        public BillingContainerProperties()
        {

        }
    }
    /// Defines the billingContainer properties.
    public partial interface IBillingContainerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get;  }

    }
    /// Defines the billingContainer properties.
    internal partial interface IBillingContainerPropertiesInternal

    {
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get; set; }

    }
}