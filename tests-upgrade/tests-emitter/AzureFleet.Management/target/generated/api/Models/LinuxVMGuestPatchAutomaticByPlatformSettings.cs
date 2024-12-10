// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies additional settings to be applied when patch mode AutomaticByPlatform
    /// is selected in Linux patch settings.
    /// </summary>
    public partial class LinuxVMGuestPatchAutomaticByPlatformSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal
    {

        /// <summary>
        /// Backing field for <see cref="BypassPlatformSafetyChecksOnUserSchedule" /> property.
        /// </summary>
        private bool? _bypassPlatformSafetyChecksOnUserSchedule;

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? BypassPlatformSafetyChecksOnUserSchedule { get => this._bypassPlatformSafetyChecksOnUserSchedule; set => this._bypassPlatformSafetyChecksOnUserSchedule = value; }

        /// <summary>Backing field for <see cref="RebootSetting" /> property.</summary>
        private string _rebootSetting;

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string RebootSetting { get => this._rebootSetting; set => this._rebootSetting = value; }

        /// <summary>
        /// Creates an new <see cref="LinuxVMGuestPatchAutomaticByPlatformSettings" /> instance.
        /// </summary>
        public LinuxVMGuestPatchAutomaticByPlatformSettings()
        {

        }
    }
    /// Specifies additional settings to be applied when patch mode AutomaticByPlatform
    /// is selected in Linux patch settings.
    public partial interface ILinuxVMGuestPatchAutomaticByPlatformSettings :
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
        bool? BypassPlatformSafetyChecksOnUserSchedule { get; set; }
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
        string RebootSetting { get; set; }

    }
    /// Specifies additional settings to be applied when patch mode AutomaticByPlatform
    /// is selected in Linux patch settings.
    internal partial interface ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal

    {
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? BypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string RebootSetting { get; set; }

    }
}