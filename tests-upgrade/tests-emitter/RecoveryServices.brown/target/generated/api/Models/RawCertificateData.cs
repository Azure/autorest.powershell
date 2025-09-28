// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Raw certificate data.</summary>
    public partial class RawCertificateData :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateData,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateDataInternal
    {

        /// <summary>Backing field for <see cref="AuthType" /> property.</summary>
        private string _authType;

        /// <summary>Specifies the authentication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AuthType { get => this._authType; set => this._authType = value; }

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private byte[] _certificate;

        /// <summary>The base64 encoded certificate raw data string</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public byte[] Certificate { get => this._certificate; set => this._certificate = value; }

        /// <summary>Creates an new <see cref="RawCertificateData" /> instance.</summary>
        public RawCertificateData()
        {

        }
    }
    /// Raw certificate data.
    public partial interface IRawCertificateData :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the authentication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the authentication type.",
        SerializedName = @"authType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "ACS", "AAD", "AccessControlService", "AzureActiveDirectory")]
        string AuthType { get; set; }
        /// <summary>The base64 encoded certificate raw data string</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The base64 encoded certificate raw data string",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] Certificate { get; set; }

    }
    /// Raw certificate data.
    internal partial interface IRawCertificateDataInternal

    {
        /// <summary>Specifies the authentication type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "ACS", "AAD", "AccessControlService", "AzureActiveDirectory")]
        string AuthType { get; set; }
        /// <summary>The base64 encoded certificate raw data string</summary>
        byte[] Certificate { get; set; }

    }
}