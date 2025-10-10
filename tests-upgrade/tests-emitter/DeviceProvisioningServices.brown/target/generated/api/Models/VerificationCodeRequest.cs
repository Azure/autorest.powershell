// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The JSON-serialized leaf certificate</summary>
    public partial class VerificationCodeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeRequestInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private string _certificate;

        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Certificate { get => this._certificate; set => this._certificate = value; }

        /// <summary>Creates an new <see cref="VerificationCodeRequest" /> instance.</summary>
        public VerificationCodeRequest()
        {

        }
    }
    /// The JSON-serialized leaf certificate
    public partial interface IVerificationCodeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"base-64 representation of X509 certificate .cer file or just .pem file content.",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(string) })]
        string Certificate { get; set; }

    }
    /// The JSON-serialized leaf certificate
    internal partial interface IVerificationCodeRequestInternal

    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        string Certificate { get; set; }

    }
}