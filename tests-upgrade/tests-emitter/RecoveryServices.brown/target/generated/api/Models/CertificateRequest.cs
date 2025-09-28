// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Details of the certificate to be uploaded to the vault.</summary>
    public partial class CertificateRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICertificateRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICertificateRequestInternal
    {

        /// <summary>Specifies the authentication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AuthType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateDataInternal)Property).AuthType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateDataInternal)Property).AuthType = value ?? null; }

        /// <summary>The base64 encoded certificate raw data string</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public byte[] Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateDataInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateDataInternal)Property).Certificate = value ?? null /* byte array */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICertificateRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RawCertificateData()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateData _property;

        /// <summary>Raw certificate data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateData Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RawCertificateData()); set => this._property = value; }

        /// <summary>Creates an new <see cref="CertificateRequest" /> instance.</summary>
        public CertificateRequest()
        {

        }
    }
    /// Details of the certificate to be uploaded to the vault.
    public partial interface ICertificateRequest :
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
    /// Details of the certificate to be uploaded to the vault.
    internal partial interface ICertificateRequestInternal

    {
        /// <summary>Specifies the authentication type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "ACS", "AAD", "AccessControlService", "AzureActiveDirectory")]
        string AuthType { get; set; }
        /// <summary>The base64 encoded certificate raw data string</summary>
        byte[] Certificate { get; set; }
        /// <summary>Raw certificate data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRawCertificateData Property { get; set; }

    }
}