// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    /// </summary>
    public partial class VaultCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultCertificateInternal
    {

        /// <summary>Backing field for <see cref="CertificateStore" /> property.</summary>
        private string _certificateStore;

        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to
        /// which the certificate should be added. The specified certificate store is
        /// implicitly in the LocalMachine account. For Linux VMs, the certificate file is
        /// placed under the /var/lib/waagent directory, with the file name
        /// &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and
        /// &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem
        /// formatted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string CertificateStore { get => this._certificateStore; set => this._certificateStore = value; }

        /// <summary>Backing field for <see cref="CertificateUrl" /> property.</summary>
        private string _certificateUrl;

        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64 encoding of the
        /// following JSON Object which is encoded in UTF-8: <br><br> {<br>
        /// "data":"<Base64-encoded-certificate>",<br> "dataType":"pfx",<br>
        /// "password":"<pfx-file-password>"<br>} <br> To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string CertificateUrl { get => this._certificateUrl; set => this._certificateUrl = value; }

        /// <summary>Creates an new <see cref="VaultCertificate" /> instance.</summary>
        public VaultCertificate()
        {

        }
    }
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    public partial interface IVaultCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to
        /// which the certificate should be added. The specified certificate store is
        /// implicitly in the LocalMachine account. For Linux VMs, the certificate file is
        /// placed under the /var/lib/waagent directory, with the file name
        /// &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and
        /// &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem
        /// formatted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For Windows VMs, specifies the certificate store on the Virtual Machine to
        which the certificate should be added. The specified certificate store is
        implicitly in the LocalMachine account. For Linux VMs, the certificate file is
        placed under the /var/lib/waagent directory, with the file name
        &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and
        &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem
        formatted.",
        SerializedName = @"certificateStore",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateStore { get; set; }
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64 encoding of the
        /// following JSON Object which is encoded in UTF-8: <br><br> {<br>
        /// "data":"<Base64-encoded-certificate>",<br> "dataType":"pfx",<br>
        /// "password":"<pfx-file-password>"<br>} <br> To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This is the URL of a certificate that has been uploaded to Key Vault as a
        secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        key
        vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        In this case, your certificate needs to be It is the Base64 encoding of the
        following JSON Object which is encoded in UTF-8: <br><br> {<br>
        ""data"":""<Base64-encoded-certificate>"",<br>  ""dataType"":""pfx"",<br>
        ""password"":""<pfx-file-password>""<br>} <br> To install certificates on a virtual
        machine it is recommended to use the [Azure Key Vault virtual machine extension
        for
        Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        or the [Azure Key Vault virtual machine extension for
        Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).",
        SerializedName = @"certificateUrl",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateUrl { get; set; }

    }
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    internal partial interface IVaultCertificateInternal

    {
        /// <summary>
        /// For Windows VMs, specifies the certificate store on the Virtual Machine to
        /// which the certificate should be added. The specified certificate store is
        /// implicitly in the LocalMachine account. For Linux VMs, the certificate file is
        /// placed under the /var/lib/waagent directory, with the file name
        /// &lt;UppercaseThumbprint&gt;.crt for the X509 certificate file and
        /// &lt;UppercaseThumbprint&gt;.prv for private key. Both of these files are .pem
        /// formatted.
        /// </summary>
        string CertificateStore { get; set; }
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64 encoding of the
        /// following JSON Object which is encoded in UTF-8: <br><br> {<br>
        /// "data":"<Base64-encoded-certificate>",<br> "dataType":"pfx",<br>
        /// "password":"<pfx-file-password>"<br>} <br> To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        string CertificateUrl { get; set; }

    }
}