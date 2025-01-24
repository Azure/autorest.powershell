// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The SSH Key-pair used to authenticate with the VM. The key needs to be at least 2048-bit and in ssh-rsa format. For creating
    /// ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
    /// </summary>
    public partial class SshKeyPair :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPairInternal
    {

        /// <summary>Backing field for <see cref="PrivateKey" /> property.</summary>
        private System.Security.SecureString _privateKey;

        /// <summary>SSH private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Security.SecureString PrivateKey { get => this._privateKey; set => this._privateKey = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        /// <summary>SSH public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Creates an new <see cref="SshKeyPair" /> instance.</summary>
        public SshKeyPair()
        {

        }
    }
    /// The SSH Key-pair used to authenticate with the VM. The key needs to be at least 2048-bit and in ssh-rsa format. For creating
    /// ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
    public partial interface ISshKeyPair :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>SSH private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SSH private key.",
        SerializedName = @"privateKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString PrivateKey { get; set; }
        /// <summary>SSH public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SSH public key",
        SerializedName = @"publicKey",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKey { get; set; }

    }
    /// The SSH Key-pair used to authenticate with the VM. The key needs to be at least 2048-bit and in ssh-rsa format. For creating
    /// ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
    internal partial interface ISshKeyPairInternal

    {
        /// <summary>SSH private key.</summary>
        System.Security.SecureString PrivateKey { get; set; }
        /// <summary>SSH public key</summary>
        string PublicKey { get; set; }

    }
}