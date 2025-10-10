// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The JSON-serialized array of Certificate objects.</summary>
    public partial class CertificateListDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateListDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateListDescriptionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse> _value;

        /// <summary>The array of Certificate objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CertificateListDescription" /> instance.</summary>
        public CertificateListDescription()
        {

        }
    }
    /// The JSON-serialized array of Certificate objects.
    public partial interface ICertificateListDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The array of Certificate objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The array of Certificate objects.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse> Value { get; set; }

    }
    /// The JSON-serialized array of Certificate objects.
    internal partial interface ICertificateListDescriptionInternal

    {
        /// <summary>The array of Certificate objects.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse> Value { get; set; }

    }
}