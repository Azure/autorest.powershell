// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies settings related to VM Guest Patching on Windows.</summary>
    public partial class PatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal
    {

        /// <summary>Backing field for <see cref="AssessmentMode" /> property.</summary>
        private string _assessmentMode;

        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AssessmentMode { get => this._assessmentMode; set => this._assessmentMode = value; }

        /// <summary>Backing field for <see cref="AutomaticByPlatformSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings _automaticByPlatformSetting;

        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Windows.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSetting { get => (this._automaticByPlatformSetting = this._automaticByPlatformSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettings()); set => this._automaticByPlatformSetting = value; }

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).BypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).BypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string AutomaticByPlatformSettingRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).RebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).RebootSetting = value ?? null; }

        /// <summary>Backing field for <see cref="EnableHotpatching" /> property.</summary>
        private bool? _enableHotpatching;

        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableHotpatching { get => this._enableHotpatching; set => this._enableHotpatching = value; }

        /// <summary>Internal Acessors for AutomaticByPlatformSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal.AutomaticByPlatformSetting { get => (this._automaticByPlatformSetting = this._automaticByPlatformSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettings()); set { {_automaticByPlatformSetting = value;} } }

        /// <summary>Backing field for <see cref="PatchMode" /> property.</summary>
        private string _patchMode;

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
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PatchMode { get => this._patchMode; set => this._patchMode = value; }

        /// <summary>Creates an new <see cref="PatchSettings" /> instance.</summary>
        public PatchSettings()
        {

        }
    }
    /// Specifies settings related to VM Guest Patching on Windows.
    public partial interface IPatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
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
        string AssessmentMode { get; set; }
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
        bool? EnableHotpatching { get; set; }
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
        string PatchMode { get; set; }

    }
    /// Specifies settings related to VM Guest Patching on Windows.
    internal partial interface IPatchSettingsInternal

    {
        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string AssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Windows.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSetting { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string AutomaticByPlatformSettingRebootSetting { get; set; }
        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        bool? EnableHotpatching { get; set; }
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
        string PatchMode { get; set; }

    }
}