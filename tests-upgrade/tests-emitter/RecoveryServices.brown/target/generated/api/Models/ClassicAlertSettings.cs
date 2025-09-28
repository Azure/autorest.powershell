// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Settings for classic alerts</summary>
    public partial class ClassicAlertSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettingsInternal
    {

        /// <summary>Backing field for <see cref="AlertsForCriticalOperation" /> property.</summary>
        private string _alertsForCriticalOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AlertsForCriticalOperation { get => this._alertsForCriticalOperation; set => this._alertsForCriticalOperation = value; }

        /// <summary>Backing field for <see cref="EmailNotificationsForSiteRecovery" /> property.</summary>
        private string _emailNotificationsForSiteRecovery;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string EmailNotificationsForSiteRecovery { get => this._emailNotificationsForSiteRecovery; set => this._emailNotificationsForSiteRecovery = value; }

        /// <summary>Creates an new <see cref="ClassicAlertSettings" /> instance.</summary>
        public ClassicAlertSettings()
        {

        }
    }
    /// Settings for classic alerts
    public partial interface IClassicAlertSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForCriticalOperations",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForCriticalOperation { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"emailNotificationsForSiteRecovery",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EmailNotificationsForSiteRecovery { get; set; }

    }
    /// Settings for classic alerts
    internal partial interface IClassicAlertSettingsInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForCriticalOperation { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EmailNotificationsForSiteRecovery { get; set; }

    }
}