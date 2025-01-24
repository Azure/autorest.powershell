// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    public partial class LinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration __osConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfiguration();

        /// <summary>Backing field for <see cref="DisablePasswordAuthentication" /> property.</summary>
        private bool? _disablePasswordAuthentication;

        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? DisablePasswordAuthentication { get => this._disablePasswordAuthentication; set => this._disablePasswordAuthentication = value; }

        /// <summary>Internal Acessors for Ssh</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal.Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshConfiguration()); set { {_ssh = value;} } }

        /// <summary>Internal Acessors for SshKeyPair</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILinuxConfigurationInternal.SshKeyPair { get => (this._sshKeyPair = this._sshKeyPair ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshKeyPair()); set { {_sshKeyPair = value;} } }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string OSType { get => "Linux"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)__osConfiguration).OSType = "Linux"; }

        /// <summary>Backing field for <see cref="Ssh" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration _ssh;

        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS. (This property is deprecated, please use 'sshKeyPair' instead)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshConfiguration()); set => this._ssh = value; }

        /// <summary>Backing field for <see cref="SshKeyPair" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair _sshKeyPair;

        /// <summary>The SSH Key-pair used to authenticate with the VM's.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair SshKeyPair { get => (this._sshKeyPair = this._sshKeyPair ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SshKeyPair()); set => this._sshKeyPair = value; }

        /// <summary>SSH private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString SshKeyPairPrivateKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPairInternal)SshKeyPair).PrivateKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPairInternal)SshKeyPair).PrivateKey = value ?? null; }

        /// <summary>SSH public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SshKeyPairPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPairInternal)SshKeyPair).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPairInternal)SshKeyPair).PublicKey = value ?? null; }

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey> SshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfigurationInternal)Ssh).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfigurationInternal)Ssh).PublicKey = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LinuxConfiguration" /> instance.</summary>
        public LinuxConfiguration()
        {
            this.__osConfiguration.OSType = "Linux";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__osConfiguration), __osConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__osConfiguration), __osConfiguration);
        }
    }
    /// Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    public partial interface ILinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration
    {
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether password authentication should be disabled.",
        SerializedName = @"disablePasswordAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisablePasswordAuthentication { get; set; }
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
        System.Security.SecureString SshKeyPairPrivateKey { get; set; }
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
        string SshKeyPairPublicKey { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of SSH public keys used to authenticate with linux based VMs.",
        SerializedName = @"publicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey> SshPublicKey { get; set; }

    }
    /// Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    internal partial interface ILinuxConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal
    {
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        bool? DisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS. (This property is deprecated, please use 'sshKeyPair' instead)
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshConfiguration Ssh { get; set; }
        /// <summary>The SSH Key-pair used to authenticate with the VM's.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshKeyPair SshKeyPair { get; set; }
        /// <summary>SSH private key.</summary>
        System.Security.SecureString SshKeyPairPrivateKey { get; set; }
        /// <summary>SSH public key</summary>
        string SshKeyPairPublicKey { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey> SshPublicKey { get; set; }

    }
}