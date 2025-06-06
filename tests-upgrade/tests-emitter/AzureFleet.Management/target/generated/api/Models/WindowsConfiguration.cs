// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
    public partial class WindowsConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal
    {

        /// <summary>Backing field for <see cref="AdditionalUnattendContent" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> _additionalUnattendContent;

        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be
        /// included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> AdditionalUnattendContent { get => this._additionalUnattendContent; set => this._additionalUnattendContent = value; }

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string AutomaticByPlatformSettingRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingRebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSettingRebootSetting = value ?? null; }

        /// <summary>Backing field for <see cref="EnableAutomaticUpdate" /> property.</summary>
        private bool? _enableAutomaticUpdate;

        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        /// Default value is true. For virtual machine scale sets, this property can be
        /// updated and updates will take effect on OS reprovisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableAutomaticUpdate { get => this._enableAutomaticUpdate; set => this._enableAutomaticUpdate = value; }

        /// <summary>Backing field for <see cref="EnableVMAgentPlatformUpdate" /> property.</summary>
        private bool? _enableVMAgentPlatformUpdate;

        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        /// machine. Default value is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableVMAgentPlatformUpdate { get => this._enableVMAgentPlatformUpdate; set => this._enableVMAgentPlatformUpdate = value; }

        /// <summary>Internal Acessors for PatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal.PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettings()); set { {_patchSetting = value;} } }

        /// <summary>Internal Acessors for PatchSettingAutomaticByPlatformSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal.PatchSettingAutomaticByPlatformSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AutomaticByPlatformSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for WinRm</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal.WinRm { get => (this._winRm = this._winRm ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfiguration()); set { {_winRm = value;} } }

        /// <summary>Backing field for <see cref="PatchSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings _patchSetting;

        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettings()); set => this._patchSetting = value; }

        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PatchSettingAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).AssessmentMode = value ?? null; }

        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? PatchSettingEnableHotpatching { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).EnableHotpatching; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).EnableHotpatching = value ?? default(bool); }

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
        public string PatchSettingPatchMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).PatchMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettingsInternal)PatchSetting).PatchMode = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisionVMAgent" /> property.</summary>
        private bool? _provisionVMAgent;

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, it is set to
        /// true by default. This will ensure that VM Agent is installed on the VM so that
        /// extensions can be added to the VM later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? ProvisionVMAgent { get => this._provisionVMAgent; set => this._provisionVMAgent = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Backing field for <see cref="WinRm" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration _winRm;

        /// <summary>
        /// Specifies the Windows Remote Management listeners. This enables remote Windows
        /// PowerShell.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration WinRm { get => (this._winRm = this._winRm ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfiguration()); set => this._winRm = value; }

        /// <summary>The list of Windows Remote Management listeners</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> WinRmListener { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfigurationInternal)WinRm).Listener; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfigurationInternal)WinRm).Listener = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="WindowsConfiguration" /> instance.</summary>
        public WindowsConfiguration()
        {

        }
    }
    /// Specifies Windows operating system settings on the virtual machine.
    public partial interface IWindowsConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> AdditionalUnattendContent { get; set; }
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
        bool? EnableAutomaticUpdate { get; set; }
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
        bool? EnableVMAgentPlatformUpdate { get; set; }
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
        string PatchSettingAssessmentMode { get; set; }
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
        string PatchSettingPatchMode { get; set; }
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
        bool? ProvisionVMAgent { get; set; }
        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the time zone of the virtual machine. e.g. ""Pacific Standard Time"".
        Possible values can be
        [TimeZoneInfo.Id](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        value from time zones returned by
        [TimeZoneInfo.GetSystemTimeZones](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }
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

    }
    /// Specifies Windows operating system settings on the virtual machine.
    internal partial interface IWindowsConfigurationInternal

    {
        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be
        /// included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent> AdditionalUnattendContent { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string AutomaticByPlatformSettingRebootSetting { get; set; }
        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine.
        /// Default value is true. For virtual machine scale sets, this property can be
        /// updated and updates will take effect on OS reprovisioning.
        /// </summary>
        bool? EnableAutomaticUpdate { get; set; }
        /// <summary>
        /// Indicates whether VMAgent Platform Updates is enabled for the Windows virtual
        /// machine. Default value is false.
        /// </summary>
        bool? EnableVMAgentPlatformUpdate { get; set; }
        /// <summary>[Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings PatchSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest patch assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine.<br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string PatchSettingAssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Windows.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings PatchSettingAutomaticByPlatformSetting { get; set; }
        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For
        /// enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode'
        /// must be set to 'AutomaticByPlatform'.
        /// </summary>
        bool? PatchSettingEnableHotpatching { get; set; }
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
        string PatchSettingPatchMode { get; set; }
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual
        /// machine. When this property is not specified in the request body, it is set to
        /// true by default. This will ensure that VM Agent is installed on the VM so that
        /// extensions can be added to the VM later.
        /// </summary>
        bool? ProvisionVMAgent { get; set; }
        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time".
        /// Possible values can be
        /// [TimeZoneInfo.Id](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id)
        /// value from time zones returned by
        /// [TimeZoneInfo.GetSystemTimeZones](https://learn.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        string TimeZone { get; set; }
        /// <summary>
        /// Specifies the Windows Remote Management listeners. This enables remote Windows
        /// PowerShell.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration WinRm { get; set; }
        /// <summary>The list of Windows Remote Management listeners</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener> WinRmListener { get; set; }

    }
}