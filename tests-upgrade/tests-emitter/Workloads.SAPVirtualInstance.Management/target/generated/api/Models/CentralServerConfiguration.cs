// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the central server configuration.</summary>
    public partial class CentralServerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal
    {

        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ImageReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceId = value ?? null; }

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ImageReferenceOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceOffer = value ?? null; }

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ImageReferencePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferencePublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferencePublisher = value ?? null; }

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ImageReferenceSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceSku = value ?? null; }

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ImageReferenceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReferenceVersion = value ?? null; }

        /// <summary>Backing field for <see cref="InstanceCount" /> property.</summary>
        private long _instanceCount;

        /// <summary>The number of central server VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long InstanceCount { get => this._instanceCount; set => this._instanceCount = value; }

        /// <summary>Internal Acessors for OSProfileOsconfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal.OSProfileOsconfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for VirtualMachineConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal.VirtualMachineConfiguration { get => (this._virtualMachineConfiguration = this._virtualMachineConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration()); set { {_virtualMachineConfiguration = value;} } }

        /// <summary>Internal Acessors for VirtualMachineConfigurationImageReference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal.VirtualMachineConfigurationImageReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).ImageReference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for VirtualMachineConfigurationOSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerConfigurationInternal.VirtualMachineConfigurationOSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfile = value ?? null /* model class */; }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string OSConfigurationOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSConfigurationOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSConfigurationOstype = value ?? null; }

        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Security.SecureString OSProfileAdminPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileAdminPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileAdminPassword = value ?? null; }

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string OSProfileAdminUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileAdminUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileAdminUsername = value ?? null; }

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration OSProfileOsconfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileOsconfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).OSProfileOsconfiguration = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="VirtualMachineConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration _virtualMachineConfiguration;

        /// <summary>Gets or sets the virtual machine configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration VirtualMachineConfiguration { get => (this._virtualMachineConfiguration = this._virtualMachineConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineConfiguration()); set => this._virtualMachineConfiguration = value; }

        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string VirtualMachineConfigurationVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).VMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfigurationInternal)VirtualMachineConfiguration).VMSize = value ; }

        /// <summary>Creates an new <see cref="CentralServerConfiguration" /> instance.</summary>
        public CentralServerConfiguration()
        {

        }
    }
    /// Gets or sets the central server configuration.
    public partial interface ICentralServerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceVersion { get; set; }
        /// <summary>The number of central server VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of central server VMs.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long InstanceCount { get; set; }
        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OS Type",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string OSConfigurationOstype { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** ""abc@123"", ""P@$$w0rd"", ""P@ssw0rd"", ""P@ssword123"", ""Pa$$word"", ""pass@word1"", ""Password!"", ""Password1"", ""Password22"", ""iloveyou!"" <br><br> For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp) <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString OSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br> **Windows-only restriction:** Cannot end in ""."" <br><br> **Disallowed values:** ""administrator"", ""admin"", ""user"", ""user1"", ""test"", ""user2"", ""test1"", ""user3"", ""admin1"", ""1"", ""123"", ""a"", ""actuser"", ""adm"", ""admin2"", ""aspnet"", ""backup"", ""console"", ""david"", ""guest"", ""john"", ""owner"", ""root"", ""server"", ""sql"", ""support"", ""support_388945a0"", ""sys"", ""test2"", ""test3"", ""user4"", ""user5"". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters.",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileAdminUsername { get; set; }
        /// <summary>The subnet id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subnet id.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine size.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineConfigurationVMSize { get; set; }

    }
    /// Gets or sets the central server configuration.
    internal partial interface ICentralServerConfigurationInternal

    {
        /// <summary>
        /// Specifies the ARM resource ID of the Azure Compute Gallery image version used for creating ACSS VMs. You will need to
        /// provide this input when you choose to deploy virtual machines in ACSS with OS image from the Azure Compute gallery.
        /// </summary>
        string ImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        string ImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        string ImageReferencePublisher { get; set; }
        /// <summary>The image SKU.</summary>
        string ImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        string ImageReferenceVersion { get; set; }
        /// <summary>The number of central server VMs.</summary>
        long InstanceCount { get; set; }
        /// <summary>The OS Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string OSConfigurationOstype { get; set; }
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length (Windows):** 8 characters <br><br> **Minimum-length
        /// (Linux):** 6 characters <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length (Linux):** 72 characters
        /// <br><br> **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled <br> Has lower characters <br>Has
        /// upper characters <br> Has a digit <br> Has a special character (Regex match [\W_]) <br><br> **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" <br><br>
        /// For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://learn.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        System.Security.SecureString OSProfileAdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        string OSProfileAdminUsername { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration OSProfileOsconfiguration { get; set; }
        /// <summary>The subnet id.</summary>
        string SubnetId { get; set; }
        /// <summary>Gets or sets the virtual machine configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        /// <summary>The image reference.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IImageReference VirtualMachineConfigurationImageReference { get; set; }
        /// <summary>The OS profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile VirtualMachineConfigurationOSProfile { get; set; }
        /// <summary>The virtual machine size.</summary>
        string VirtualMachineConfigurationVMSize { get; set; }

    }
}