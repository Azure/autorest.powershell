// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Restore Settings of the vault</summary>
    public partial class RestoreSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal
    {

        /// <summary>Backing field for <see cref="CrossSubscriptionRestoreSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings _crossSubscriptionRestoreSetting;

        /// <summary>Settings for CrossSubscriptionRestore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings CrossSubscriptionRestoreSetting { get => (this._crossSubscriptionRestoreSetting = this._crossSubscriptionRestoreSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CrossSubscriptionRestoreSettings()); set => this._crossSubscriptionRestoreSetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettingsInternal)CrossSubscriptionRestoreSetting).CrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettingsInternal)CrossSubscriptionRestoreSetting).CrossSubscriptionRestoreState = value ?? null; }

        /// <summary>Internal Acessors for CrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IRestoreSettingsInternal.CrossSubscriptionRestoreSetting { get => (this._crossSubscriptionRestoreSetting = this._crossSubscriptionRestoreSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CrossSubscriptionRestoreSettings()); set { {_crossSubscriptionRestoreSetting = value;} } }

        /// <summary>Creates an new <see cref="RestoreSettings" /> instance.</summary>
        public RestoreSettings()
        {

        }
    }
    /// Restore Settings of the vault
    public partial interface IRestoreSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"crossSubscriptionRestoreState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get; set; }

    }
    /// Restore Settings of the vault
    internal partial interface IRestoreSettingsInternal

    {
        /// <summary>Settings for CrossSubscriptionRestore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings CrossSubscriptionRestoreSetting { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        string CrossSubscriptionRestoreSettingCrossSubscriptionRestoreState { get; set; }

    }
}