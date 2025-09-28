// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Settings for Cross Subscription Restore Settings</summary>
    public partial class CrossSubscriptionRestoreSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICrossSubscriptionRestoreSettingsInternal
    {

        /// <summary>Backing field for <see cref="CrossSubscriptionRestoreState" /> property.</summary>
        private string _crossSubscriptionRestoreState;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string CrossSubscriptionRestoreState { get => this._crossSubscriptionRestoreState; set => this._crossSubscriptionRestoreState = value; }

        /// <summary>Creates an new <see cref="CrossSubscriptionRestoreSettings" /> instance.</summary>
        public CrossSubscriptionRestoreSettings()
        {

        }
    }
    /// Settings for Cross Subscription Restore Settings
    public partial interface ICrossSubscriptionRestoreSettings :
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
        string CrossSubscriptionRestoreState { get; set; }

    }
    /// Settings for Cross Subscription Restore Settings
    internal partial interface ICrossSubscriptionRestoreSettingsInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled", "PermanentlyDisabled")]
        string CrossSubscriptionRestoreState { get; set; }

    }
}