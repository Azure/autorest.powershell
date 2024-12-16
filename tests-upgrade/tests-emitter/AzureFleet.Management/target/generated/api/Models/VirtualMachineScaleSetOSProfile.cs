// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set OS profile.</summary>
    public partial class VirtualMachineScaleSetOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal
    {

        /// <summary>Backing field for <see cref="AdminPassword" /> property.</summary>
        private System.Security.SecureString _adminPassword;

        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length
        /// (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters
        /// <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length
        /// (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4
        /// conditions below need to be fulfilled <br> Has lower characters <br>Has upper
        /// characters <br> Has a digit <br> Has a special character (Regex match [\W_])
        /// <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",
        /// "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",
        /// "Password22", "iloveyou!" <br><br> For resetting the password, see [How to
        /// reset the Remote Desktop service or its login password in a Windows
        /// VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or
        /// repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Security.SecureString AdminPassword { get => this._adminPassword; set => this._adminPassword = value; }

        /// <summary>Backing field for <see cref="AdminUsername" /> property.</summary>
        private string _adminUsername;

        /// <summary>
        /// Specifies the name of the administrator account. <br><br> **Windows-only
        /// restriction:** Cannot end in "." <br><br> **Disallowed values:**
        /// "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",
        /// "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",
        /// "console", "david", "guest", "john", "owner", "root", "server", "sql",
        /// "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".
        /// <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length
        /// (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AdminUsername { get => this._adminUsername; set => this._adminUsername = value; }

        /// <summary>Backing field for <see cref="AllowExtensionOperation" /> property.</summary>
        private bool? _allowExtensionOperation;

        /// <summary>
        /// Specifies whether extension operations should be allowed on the virtual machine
        /// scale set. This may only be set to False when no extensions are present on the
        /// virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? AllowExtensionOperation { get => this._allowExtensionOperation; set => this._allowExtensionOperation = value; }

        /// <summary>Backing field for <see cref="ComputerNamePrefix" /> property.</summary>
        private string _computerNamePrefix;

        /// <summary>
        /// Specifies the computer name prefix for all of the virtual machines in the scale
        /// set. Computer name prefixes must be 1 to 15 characters long.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ComputerNamePrefix { get => this._computerNamePrefix; set => this._computerNamePrefix = value; }

        /// <summary>Backing field for <see cref="CustomData" /> property.</summary>
        private System.Security.SecureString _customData;

        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string
        /// is decoded to a binary array that is saved as a file on the Virtual Machine.
        /// The maximum length of the binary array is 65535 bytes. For using cloud-init for
        /// your VM, see [Using cloud-init to customize a Linux VM during
        /// creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Security.SecureString CustomData { get => this._customData; set => this._customData = value; }

        /// <summary>Backing field for <see cref="LinuxConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration _linuxConfiguration;

        /// <summary>
        /// Specifies the Linux operating system settings on the virtual machine. For a
        /// list of supported Linux distributions, see [Linux on Azure-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration LinuxConfiguration { get => (this._linuxConfiguration = this._linuxConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration()); set => this._linuxConfiguration = value; }

        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? LinuxConfigurationDisablePasswordAuthentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).DisablePasswordAuthentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).DisablePasswordAuthentication = value ?? default(bool); }

        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? LinuxConfigurationEnableVMAgentPlatformUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).EnableVMAgentPlatformUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).EnableVMAgentPlatformUpdate = value ?? default(bool); }

        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string LinuxConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingAssessmentMode = value ?? null; }

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).AutomaticByPlatformSettingRebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).AutomaticByPlatformSettingRebootSetting = value ?? null; }

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string LinuxConfigurationPatchSettingsPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingPatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingPatchMode = value ?? null; }

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, default
        /// behavior is to set it to true. This will ensure that VM Agent is installed on
        /// the VM so that extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? LinuxConfigurationProvisionVMAgent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).ProvisionVMAgent; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).ProvisionVMAgent = value ?? default(bool); }

        /// <summary>Internal Acessors for LinuxConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.LinuxConfiguration { get => (this._linuxConfiguration = this._linuxConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration()); set { {_linuxConfiguration = value;} } }

        /// <summary>Internal Acessors for LinuxConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.LinuxConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSetting = value; }

        /// <summary>Internal Acessors for LinuxConfigurationPatchSettingsAutomaticByPlatformSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.LinuxConfigurationPatchSettingsAutomaticByPlatformSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingAutomaticByPlatformSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).PatchSettingAutomaticByPlatformSetting = value; }

        /// <summary>Internal Acessors for LinuxConfigurationSsh</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.LinuxConfigurationSsh { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).Ssh; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).Ssh = value; }

        /// <summary>Internal Acessors for WindowConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.WindowConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSetting = value; }

        /// <summary>Internal Acessors for WindowConfigurationWinRm</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.WindowConfigurationWinRm { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).WinRm; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).WinRm = value; }

        /// <summary>Internal Acessors for WindowsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.WindowsConfiguration { get => (this._windowsConfiguration = this._windowsConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration()); set { {_windowsConfiguration = value;} } }

        /// <summary>
        /// Internal Acessors for WindowsConfigurationPatchSettingsAutomaticByPlatformSetting
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal.WindowsConfigurationPatchSettingsAutomaticByPlatformSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAutomaticByPlatformSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAutomaticByPlatformSetting = value; }

        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? PatchSettingEnableHotpatching { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingEnableHotpatching; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingEnableHotpatching = value ?? default(bool); }

        /// <summary>Backing field for <see cref="RequireGuestProvisionSignal" /> property.</summary>
        private bool? _requireGuestProvisionSignal;

        /// <summary>Optional property which must either be set to True or omitted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? RequireGuestProvisionSignal { get => this._requireGuestProvisionSignal; set => this._requireGuestProvisionSignal = value; }

        /// <summary>Backing field for <see cref="Secret" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup> _secret;

        /// <summary>
        /// Specifies set of certificates that should be installed onto the virtual
        /// machines in the scale set. To install certificates on a virtual machine it is
        /// recommended to use the [Azure Key Vault virtual machine extension for
        /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup> Secret { get => this._secret; set => this._secret = value; }

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey> SshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).SshPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)LinuxConfiguration).SshPublicKey = value ?? null /* arrayOf */; }

        /// <summary>The list of Windows Remote Management listeners</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> WinRmListener { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).WinRmListener; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).WinRmListener = value ?? null /* arrayOf */; }

        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be
        /// included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> WindowConfigurationAdditionalUnattendContent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AdditionalUnattendContent; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AdditionalUnattendContent = value ?? null /* arrayOf */; }

        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        /// Default value is true. For virtual machine scale sets, this property can be
        /// updated and updates will take effect on OS reprovisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? WindowConfigurationEnableAutomaticUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).EnableAutomaticUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).EnableAutomaticUpdate = value ?? default(bool); }

        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? WindowConfigurationEnableVMAgentPlatformUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).EnableVMAgentPlatformUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).EnableVMAgentPlatformUpdate = value ?? default(bool); }

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, it is set to
        /// true by default. This will ensure that VM Agent is installed on the VM so that
        /// extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? WindowConfigurationProvisionVMAgent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).ProvisionVMAgent; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).ProvisionVMAgent = value ?? default(bool); }

        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string WindowConfigurationTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).TimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="WindowsConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration _windowsConfiguration;

        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration WindowsConfiguration { get => (this._windowsConfiguration = this._windowsConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration()); set => this._windowsConfiguration = value; }

        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string WindowsConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAssessmentMode = value ?? null; }

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AutomaticByPlatformSettingRebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).AutomaticByPlatformSettingRebootSetting = value ?? null; }

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You
        /// control the application of patches to a virtual machine. You do this by
        /// applying patches manually inside the VM. In this mode, automatic updates are
        /// disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
        /// false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be
        /// updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates
        /// must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will
        /// automatically updated by the platform. The properties provisionVMAgent and
        /// WindowsConfiguration.enableAutomaticUpdates must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string WindowsConfigurationPatchSettingsPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingPatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)WindowsConfiguration).PatchSettingPatchMode = value ?? null; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetOSProfile" /> instance.</summary>
        public VirtualMachineScaleSetOSProfile()
        {

        }
    }
    /// Describes a virtual machine scale set OS profile.
    public partial interface IVirtualMachineScaleSetOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length
        /// (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters
        /// <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length
        /// (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4
        /// conditions below need to be fulfilled <br> Has lower characters <br>Has upper
        /// characters <br> Has a digit <br> Has a special character (Regex match [\W_])
        /// <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",
        /// "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",
        /// "Password22", "iloveyou!" <br><br> For resetting the password, see [How to
        /// reset the Remote Desktop service or its login password in a Windows
        /// VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or
        /// repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the password of the administrator account. <br><br> **Minimum-length
        (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters
        <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length
        (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4
        conditions below need to be fulfilled <br> Has lower characters <br>Has upper
        characters <br> Has a digit <br> Has a special character (Regex match [\W_])
        <br><br> **Disallowed values:** ""abc@123"", ""P@$$w0rd"", ""P@ssw0rd"",
        ""P@ssword123"", ""Pa$$word"", ""pass@word1"", ""Password!"", ""Password1"",
        ""Password22"", ""iloveyou!"" <br><br> For resetting the password, see [How to
        reset the Remote Desktop service or its login password in a Windows
        VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        <br><br> For resetting root password, see [Manage users, SSH, and check or
        repair disks on Azure Linux VMs using the VMAccess
        Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)",
        SerializedName = @"adminPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> **Windows-only
        /// restriction:** Cannot end in "." <br><br> **Disallowed values:**
        /// "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",
        /// "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",
        /// "console", "david", "guest", "john", "owner", "root", "server", "sql",
        /// "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".
        /// <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length
        /// (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the administrator account. <br><br> **Windows-only
        restriction:** Cannot end in ""."" <br><br> **Disallowed values:**
        ""administrator"", ""admin"", ""user"", ""user1"", ""test"", ""user2"", ""test1"", ""user3"",
        ""admin1"", ""1"", ""123"", ""a"", ""actuser"", ""adm"", ""admin2"", ""aspnet"", ""backup"",
        ""console"", ""david"", ""guest"", ""john"", ""owner"", ""root"", ""server"", ""sql"",
        ""support"", ""support_388945a0"", ""sys"", ""test2"", ""test3"", ""user4"", ""user5"".
        <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length
        (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters",
        SerializedName = @"adminUsername",
        PossibleTypes = new [] { typeof(string) })]
        string AdminUsername { get; set; }
        /// <summary>
        /// Specifies whether extension operations should be allowed on the virtual machine
        /// scale set. This may only be set to False when no extensions are present on the
        /// virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether extension operations should be allowed on the virtual machine
        scale set. This may only be set to False when no extensions are present on the
        virtual machine scale set.",
        SerializedName = @"allowExtensionOperations",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowExtensionOperation { get; set; }
        /// <summary>
        /// Specifies the computer name prefix for all of the virtual machines in the scale
        /// set. Computer name prefixes must be 1 to 15 characters long.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the computer name prefix for all of the virtual machines in the scale
        set. Computer name prefixes must be 1 to 15 characters long.",
        SerializedName = @"computerNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerNamePrefix { get; set; }
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string
        /// is decoded to a binary array that is saved as a file on the Virtual Machine.
        /// The maximum length of the binary array is 65535 bytes. For using cloud-init for
        /// your VM, see [Using cloud-init to customize a Linux VM during
        /// creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies a base-64 encoded string of custom data. The base-64 encoded string
        is decoded to a binary array that is saved as a file on the Virtual Machine.
        The maximum length of the binary array is 65535 bytes. For using cloud-init for
        your VM, see [Using cloud-init to customize a Linux VM during
        creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)",
        SerializedName = @"customData",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString CustomData { get; set; }
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether password authentication should be disabled.",
        SerializedName = @"disablePasswordAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LinuxConfigurationDisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        machine. Default value is false.",
        SerializedName = @"enableVMAgentPlatformUpdates",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LinuxConfigurationEnableVMAgentPlatformUpdate { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        control the timing of patch assessments on a virtual machine. <br /><br />
        **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        The property provisionVMAgent must be true.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enables customer to schedule patching without accidental upgrades",
        SerializedName = @"bypassPlatformSafetyChecksOnUserSchedule",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the reboot setting for all AutomaticByPlatform patch installation
        operations.",
        SerializedName = @"rebootSetting",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        machines associated to virtual machine scale set with OrchestrationMode as
        Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        virtual machine's default patching configuration is used. <br /><br />
        **AutomaticByPlatform** - The virtual machine will be automatically updated by
        the platform. The property provisionVMAgent must be true",
        SerializedName = @"patchMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string LinuxConfigurationPatchSettingsPatchMode { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, default
        /// behavior is to set it to true. This will ensure that VM Agent is installed on
        /// the VM so that extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether virtual machine agent should be provisioned on the virtual
        machine. When this property is not specified in the request body, default
        behavior is to set it to true. This will ensure that VM Agent is installed on
        the VM so that extensions can be added to the VM later.",
        SerializedName = @"provisionVMAgent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LinuxConfigurationProvisionVMAgent { get; set; }
        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enables customers to patch their Azure VMs without requiring a reboot. For
        enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        must be set to 'AutomaticByPlatform'.",
        SerializedName = @"enableHotpatching",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PatchSettingEnableHotpatching { get; set; }
        /// <summary>Optional property which must either be set to True or omitted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional property which must either be set to True or omitted.",
        SerializedName = @"requireGuestProvisionSignal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequireGuestProvisionSignal { get; set; }
        /// <summary>
        /// Specifies set of certificates that should be installed onto the virtual
        /// machines in the scale set. To install certificates on a virtual machine it is
        /// recommended to use the [Azure Key Vault virtual machine extension for
        /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies set of certificates that should be installed onto the virtual
        machines in the scale set. To install certificates on a virtual machine it is
        recommended to use the [Azure Key Vault virtual machine extension for
        Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        or the [Azure Key Vault virtual machine extension for
        Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).",
        SerializedName = @"secrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup> Secret { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of SSH public keys used to authenticate with linux based VMs.",
        SerializedName = @"publicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey> SshPublicKey { get; set; }
        /// <summary>The list of Windows Remote Management listeners</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of Windows Remote Management listeners",
        SerializedName = @"listeners",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> WinRmListener { get; set; }
        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be
        /// included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies additional base-64 encoded XML formatted information that can be
        included in the Unattend.xml file, which is used by Windows Setup.",
        SerializedName = @"additionalUnattendContent",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> WindowConfigurationAdditionalUnattendContent { get; set; }
        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        /// Default value is true. For virtual machine scale sets, this property can be
        /// updated and updates will take effect on OS reprovisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        Default value is true. For virtual machine scale sets, this property can be
        updated and updates will take effect on OS reprovisioning.",
        SerializedName = @"enableAutomaticUpdates",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowConfigurationEnableAutomaticUpdate { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        machine. Default value is false.",
        SerializedName = @"enableVMAgentPlatformUpdates",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowConfigurationEnableVMAgentPlatformUpdate { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, it is set to
        /// true by default. This will ensure that VM Agent is installed on the VM so that
        /// extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether virtual machine agent should be provisioned on the virtual
        machine. When this property is not specified in the request body, it is set to
        true by default. This will ensure that VM Agent is installed on the VM so that
        extensions can be added to the VM later.",
        SerializedName = @"provisionVMAgent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowConfigurationProvisionVMAgent { get; set; }
        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the time zone of the virtual machine. e.g. ""Pacific Standard Time"".
        Possible values can be
        [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        value from time zones returned by
        [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string WindowConfigurationTimeZone { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest patch assessment for the IaaS virtual
        machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        control the timing of patch assessments on a virtual machine.<br /><br />
        **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        The property provisionVMAgent must be true.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enables customer to schedule patching without accidental upgrades",
        SerializedName = @"bypassPlatformSafetyChecksOnUserSchedule",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the reboot setting for all AutomaticByPlatform patch installation
        operations.",
        SerializedName = @"rebootSetting",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You
        /// control the application of patches to a virtual machine. You do this by
        /// applying patches manually inside the VM. In this mode, automatic updates are
        /// disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
        /// false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be
        /// updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates
        /// must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will
        /// automatically updated by the platform. The properties provisionVMAgent and
        /// WindowsConfiguration.enableAutomaticUpdates must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        machines associated to virtual machine scale set with OrchestrationMode as
        Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You
        control the application of patches to a virtual machine. You do this by
        applying patches manually inside the VM. In this mode, automatic updates are
        disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
        false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be
        updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates
        must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will
        automatically updated by the platform. The properties provisionVMAgent and
        WindowsConfiguration.enableAutomaticUpdates must be true",
        SerializedName = @"patchMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Manual", "AutomaticByOS", "AutomaticByPlatform")]
        string WindowsConfigurationPatchSettingsPatchMode { get; set; }

    }
    /// Describes a virtual machine scale set OS profile.
    internal partial interface IVirtualMachineScaleSetOSProfileInternal

    {
        /// <summary>
        /// Specifies the password of the administrator account. <br><br> **Minimum-length
        /// (Windows):** 8 characters <br><br> **Minimum-length (Linux):** 6 characters
        /// <br><br> **Max-length (Windows):** 123 characters <br><br> **Max-length
        /// (Linux):** 72 characters <br><br> **Complexity requirements:** 3 out of 4
        /// conditions below need to be fulfilled <br> Has lower characters <br>Has upper
        /// characters <br> Has a digit <br> Has a special character (Regex match [\W_])
        /// <br><br> **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd",
        /// "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1",
        /// "Password22", "iloveyou!" <br><br> For resetting the password, see [How to
        /// reset the Remote Desktop service or its login password in a Windows
        /// VM](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/reset-rdp)
        /// <br><br> For resetting root password, see [Manage users, SSH, and check or
        /// repair disks on Azure Linux VMs using the VMAccess
        /// Extension](https://docs.microsoft.com/troubleshoot/azure/virtual-machines/troubleshoot-ssh-connection)
        /// </summary>
        System.Security.SecureString AdminPassword { get; set; }
        /// <summary>
        /// Specifies the name of the administrator account. <br><br> **Windows-only
        /// restriction:** Cannot end in "." <br><br> **Disallowed values:**
        /// "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3",
        /// "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup",
        /// "console", "david", "guest", "john", "owner", "root", "server", "sql",
        /// "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".
        /// <br><br> **Minimum-length (Linux):** 1 character <br><br> **Max-length
        /// (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters
        /// </summary>
        string AdminUsername { get; set; }
        /// <summary>
        /// Specifies whether extension operations should be allowed on the virtual machine
        /// scale set. This may only be set to False when no extensions are present on the
        /// virtual machine scale set.
        /// </summary>
        bool? AllowExtensionOperation { get; set; }
        /// <summary>
        /// Specifies the computer name prefix for all of the virtual machines in the scale
        /// set. Computer name prefixes must be 1 to 15 characters long.
        /// </summary>
        string ComputerNamePrefix { get; set; }
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string
        /// is decoded to a binary array that is saved as a file on the Virtual Machine.
        /// The maximum length of the binary array is 65535 bytes. For using cloud-init for
        /// your VM, see [Using cloud-init to customize a Linux VM during
        /// creation](https://docs.microsoft.com/azure/virtual-machines/linux/using-cloud-init)
        /// </summary>
        System.Security.SecureString CustomData { get; set; }
        /// <summary>
        /// Specifies the Linux operating system settings on the virtual machine. For a
        /// list of supported Linux distributions, see [Linux on Azure-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration LinuxConfiguration { get; set; }
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        bool? LinuxConfigurationDisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        /// machine. Default value is false.
        /// </summary>
        bool? LinuxConfigurationEnableVMAgentPlatformUpdate { get; set; }
        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings LinuxConfigurationPatchSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings LinuxConfigurationPatchSettingsAutomaticByPlatformSetting { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string LinuxConfigurationPatchSettingsPatchMode { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, default
        /// behavior is to set it to true. This will ensure that VM Agent is installed on
        /// the VM so that extensions can be added to the VM later.
        /// </summary>
        bool? LinuxConfigurationProvisionVMAgent { get; set; }
        /// <summary>Specifies the ssh key configuration for a Linux OS.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration LinuxConfigurationSsh { get; set; }
        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        bool? PatchSettingEnableHotpatching { get; set; }
        /// <summary>Optional property which must either be set to True or omitted.</summary>
        bool? RequireGuestProvisionSignal { get; set; }
        /// <summary>
        /// Specifies set of certificates that should be installed onto the virtual
        /// machines in the scale set. To install certificates on a virtual machine it is
        /// recommended to use the [Azure Key Vault virtual machine extension for
        /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux)
        /// or the [Azure Key Vault virtual machine extension for
        /// Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup> Secret { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey> SshPublicKey { get; set; }
        /// <summary>The list of Windows Remote Management listeners</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> WinRmListener { get; set; }
        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be
        /// included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> WindowConfigurationAdditionalUnattendContent { get; set; }
        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        /// Default value is true. For virtual machine scale sets, this property can be
        /// updated and updates will take effect on OS reprovisioning.
        /// </summary>
        bool? WindowConfigurationEnableAutomaticUpdate { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        /// machine. Default value is false.
        /// </summary>
        bool? WindowConfigurationEnableVMAgentPlatformUpdate { get; set; }
        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings WindowConfigurationPatchSetting { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, it is set to
        /// true by default. This will ensure that VM Agent is installed on the VM so that
        /// extensions can be added to the VM later.
        /// </summary>
        bool? WindowConfigurationProvisionVMAgent { get; set; }
        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        string WindowConfigurationTimeZone { get; set; }
        /// <summary>
        /// Specifies the Windows Remote Management listeners. This enables remote Windows
        /// PowerShell.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration WindowConfigurationWinRm { get; set; }
        /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Windows.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings WindowsConfigurationPatchSettingsAutomaticByPlatformSetting { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **Manual** - You
        /// control the application of patches to a virtual machine. You do this by
        /// applying patches manually inside the VM. In this mode, automatic updates are
        /// disabled; the property WindowsConfiguration.enableAutomaticUpdates must be
        /// false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be
        /// updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates
        /// must be true. <br /><br /> **AutomaticByPlatform** - the virtual machine will
        /// automatically updated by the platform. The properties provisionVMAgent and
        /// WindowsConfiguration.enableAutomaticUpdates must be true
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Manual", "AutomaticByOS", "AutomaticByPlatform")]
        string WindowsConfigurationPatchSettingsPatchMode { get; set; }

    }
}