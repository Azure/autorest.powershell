// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
    /// </summary>
    public partial class VaultCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificateInternal
    {

        /// <summary>Backing field for <see cref="CertificateStore" /> property.</summary>
        private string _certificateStore;

        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The
        /// specified certificate store is implicitly in the LocalMachine account. For Linux VMs, the certificate file is placed under
        /// the /var/lib/waagent directory, with the file name {UppercaseThumbprint}.crt for the X509 certificate file and {UppercaseThumbprint}.prv
        /// for private key. Both of these files are .pem formatted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string CertificateStore { get => this._certificateStore; set => this._certificateStore = value; }

        /// <summary>Backing field for <see cref="CertificateUrl" /> property.</summary>
        private string _certificateUrl;

        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault,
        /// see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string CertificateUrl { get => this._certificateUrl; set => this._certificateUrl = value; }

        /// <summary>Creates an new <see cref="VaultCertificate" /> instance.</summary>
        public VaultCertificate()
        {

        }
    }
    /// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
    public partial interface IVaultCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The
        /// specified certificate store is implicitly in the LocalMachine account. For Linux VMs, the certificate file is placed under
        /// the /var/lib/waagent directory, with the file name {UppercaseThumbprint}.crt for the X509 certificate file and {UppercaseThumbprint}.prv
        /// for private key. Both of these files are .pem formatted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account. For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name {UppercaseThumbprint}.crt for the X509 certificate file and {UppercaseThumbprint}.prv for private key. Both of these files are .pem formatted.",
        SerializedName = @"certificateStore",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateStore { get; set; }
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault,
        /// see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).",
        SerializedName = @"certificateUrl",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateUrl { get; set; }

    }
    /// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
    internal partial interface IVaultCertificateInternal

    {
        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The
        /// specified certificate store is implicitly in the LocalMachine account. For Linux VMs, the certificate file is placed under
        /// the /var/lib/waagent directory, with the file name {UppercaseThumbprint}.crt for the X509 certificate file and {UppercaseThumbprint}.prv
        /// for private key. Both of these files are .pem formatted.
        /// </summary>
        string CertificateStore { get; set; }
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault,
        /// see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// </summary>
        string CertificateUrl { get; set; }

    }
}