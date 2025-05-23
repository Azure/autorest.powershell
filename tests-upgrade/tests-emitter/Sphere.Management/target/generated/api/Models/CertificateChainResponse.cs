// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The certificate chain response.</summary>
    public partial class CertificateChainResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateChainResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateChainResponseInternal
    {

        /// <summary>Backing field for <see cref="CertificateChain" /> property.</summary>
        private string _certificateChain;

        /// <summary>The certificate chain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string CertificateChain { get => this._certificateChain; }

        /// <summary>Internal Acessors for CertificateChain</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateChainResponseInternal.CertificateChain { get => this._certificateChain; set { {_certificateChain = value;} } }

        /// <summary>Creates an new <see cref="CertificateChainResponse" /> instance.</summary>
        public CertificateChainResponse()
        {

        }
    }
    /// The certificate chain response.
    public partial interface ICertificateChainResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The certificate chain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate chain.",
        SerializedName = @"certificateChain",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateChain { get;  }

    }
    /// The certificate chain response.
    internal partial interface ICertificateChainResponseInternal

    {
        /// <summary>The certificate chain.</summary>
        string CertificateChain { get; set; }

    }
}