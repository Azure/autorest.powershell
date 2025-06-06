// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    public partial class LinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal
    {

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string AutomaticByPlatformSettingRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingRebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingRebootSetting = value ?? null; }

        /// <summary>Backing field for <see cref="DisablePasswordAuthentication" /> property.</summary>
        private bool? _disablePasswordAuthentication;

        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? DisablePasswordAuthentication { get => this._disablePasswordAuthentication; set => this._disablePasswordAuthentication = value; }

        /// <summary>Backing field for <see cref="EnableVMAgentPlatformUpdate" /> property.</summary>
        private bool? _enableVMAgentPlatformUpdate;

        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableVMAgentPlatformUpdate { get => this._enableVMAgentPlatformUpdate; set => this._enableVMAgentPlatformUpdate = value; }

        /// <summary>Internal Acessors for PatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal.PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettings()); set { {_patchSetting = value;} } }

        /// <summary>Internal Acessors for PatchSettingAutomaticByPlatformSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal.PatchSettingAutomaticByPlatformSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AutomaticByPlatformSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Ssh</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal.Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfiguration()); set { {_ssh = value;} } }

        /// <summary>Backing field for <see cref="PatchSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings _patchSetting;

        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettings()); set => this._patchSetting = value; }

        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PatchSettingAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).AssessmentMode = value ?? null; }

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PatchSettingPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).PatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal)PatchSetting).PatchMode = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisionVMAgent" /> property.</summary>
        private bool? _provisionVMAgent;

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, default
        /// behavior is to set it to true. This will ensure that VM Agent is installed on
        /// the VM so that extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? ProvisionVMAgent { get => this._provisionVMAgent; set => this._provisionVMAgent = value; }

        /// <summary>Backing field for <see cref="Ssh" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration _ssh;

        /// <summary>Specifies the ssh key configuration for a Linux OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfiguration()); set => this._ssh = value; }

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey> SshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfigurationInternal)Ssh).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfigurationInternal)Ssh).PublicKey = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LinuxConfiguration" /> instance.</summary>
        public LinuxConfiguration()
        {

        }
    }
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    public partial interface ILinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
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
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
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
        string AutomaticByPlatformSettingRebootSetting { get; set; }
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
        bool? DisablePasswordAuthentication { get; set; }
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
        bool? EnableVMAgentPlatformUpdate { get; set; }
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
        string PatchSettingAssessmentMode { get; set; }
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
        string PatchSettingPatchMode { get; set; }
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
        bool? ProvisionVMAgent { get; set; }
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

    }
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    internal partial interface ILinuxConfigurationInternal

    {
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string AutomaticByPlatformSettingRebootSetting { get; set; }
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        bool? DisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Linux virtual
        /// machine. Default value is false.
        /// </summary>
        bool? EnableVMAgentPlatformUpdate { get; set; }
        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings PatchSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string PatchSettingAssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings PatchSettingAutomaticByPlatformSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string PatchSettingPatchMode { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, default
        /// behavior is to set it to true. This will ensure that VM Agent is installed on
        /// the VM so that extensions can be added to the VM later.
        /// </summary>
        bool? ProvisionVMAgent { get; set; }
        /// <summary>Specifies the ssh key configuration for a Linux OS.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration Ssh { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey> SshPublicKey { get; set; }

    }
}