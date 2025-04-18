// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.
    /// </summary>
    public partial class OSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfileInternal
    {

        /// <summary>Backing field for <see cref="AdminPassword" /> property.</summary>
        private System.Security.SecureString _adminPassword;

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
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Security.SecureString AdminPassword { get => this._adminPassword; set => this._adminPassword = value; }

        /// <summary>Backing field for <see cref="AdminUsername" /> property.</summary>
        private string _adminUsername;

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AdminUsername { get => this._adminUsername; set => this._adminUsername = value; }

        /// <summary>Internal Acessors for OSConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSProfileInternal.OSConfiguration { get => (this._oSConfiguration = this._oSConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfiguration()); set { {_oSConfiguration = value;} } }

        /// <summary>Backing field for <see cref="OSConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration _oSConfiguration;

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration OSConfiguration { get => (this._oSConfiguration = this._oSConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.OSConfiguration()); set => this._oSConfiguration = value; }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string OSConfigurationOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)OSConfiguration).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfigurationInternal)OSConfiguration).OSType = value ?? null; }

        /// <summary>Creates an new <see cref="OSProfile" /> instance.</summary>
        public OSProfile()
        {

        }
    }
    /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.
    public partial interface IOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
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
        System.Security.SecureString AdminPassword { get; set; }
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
        string AdminUsername { get; set; }
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

    }
    /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.
    internal partial interface IOSProfileInternal

    {
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
        System.Security.SecureString AdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> This property cannot be updated after the VM is created. <br><br>
        /// **Windows-only restriction:** Cannot end in "." <br><br> **Disallowed values:** "administrator", "admin", "user", "user1",
        /// "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console",
        /// "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4",
        /// "user5". <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length
        /// (Windows):** 20 characters.
        /// </summary>
        string AdminUsername { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSConfiguration OSConfiguration { get; set; }
        /// <summary>The OS Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Linux", "Windows")]
        string OSConfigurationOstype { get; set; }

    }
}