// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The available private link resources for a provisioning service</summary>
    public partial class PrivateLinkResources :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateLinkResources,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateLinkResourcesInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IGroupIdInformation> _value;

        /// <summary>The list of available private link resources for a provisioning service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IGroupIdInformation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResources" /> instance.</summary>
        public PrivateLinkResources()
        {

        }
    }
    /// The available private link resources for a provisioning service
    public partial interface IPrivateLinkResources :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The list of available private link resources for a provisioning service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of available private link resources for a provisioning service",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IGroupIdInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IGroupIdInformation> Value { get; set; }

    }
    /// The available private link resources for a provisioning service
    internal partial interface IPrivateLinkResourcesInternal

    {
        /// <summary>The list of available private link resources for a provisioning service</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IGroupIdInformation> Value { get; set; }

    }
}