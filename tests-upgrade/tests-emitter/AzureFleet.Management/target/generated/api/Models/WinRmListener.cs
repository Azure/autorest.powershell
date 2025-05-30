// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
    public partial class WinRmListener :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListenerInternal
    {

        /// <summary>Backing field for <see cref="CertificateUrl" /> property.</summary>
        private string _certificateUrl;

        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be the Base64 encoding of the following
        /// JSON Object which is encoded in UTF-8: <br><br> {<br>
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

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>
        /// Specifies the protocol of WinRM listener. Possible values are: **http,**
        /// **https.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Creates an new <see cref="WinRmListener" /> instance.</summary>
        public WinRmListener()
        {

        }
    }
    /// Describes Protocol and thumbprint of Windows Remote Management listener
    public partial interface IWinRmListener :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be the Base64 encoding of the following
        /// JSON Object which is encoded in UTF-8: <br><br> {<br>
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
        In this case, your certificate needs to be the Base64 encoding of the following
        JSON Object which is encoded in UTF-8: <br><br> {<br>
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
        /// <summary>
        /// Specifies the protocol of WinRM listener. Possible values are: **http,**
        /// **https.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the protocol of WinRM listener. Possible values are: **http,**
        **https.**",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Http", "Https")]
        string Protocol { get; set; }

    }
    /// Describes Protocol and thumbprint of Windows Remote Management listener
    internal partial interface IWinRmListenerInternal

    {
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a
        /// secret. For adding a secret to the Key Vault, see [Add a key or secret to the
        /// key
        /// vault](https://learn.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be the Base64 encoding of the following
        /// JSON Object which is encoded in UTF-8: <br><br> {<br>
        /// "data":"<Base64-encoded-certificate>",<br> "dataType":"pfx",<br>
        /// "password":"<pfx-file-password>"<br>} <br> To install certificates on a virtual
        /// machine it is recommended to use the [Azure Key Vault virtual machine extension
        /// for
        /// Linux](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://learn.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        string CertificateUrl { get; set; }
        /// <summary>
        /// Specifies the protocol of WinRM listener. Possible values are: **http,**
        /// **https.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Http", "Https")]
        string Protocol { get; set; }

    }
}