// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Settings for Azure Monitor based alerts</summary>
    public partial class AzureMonitorAlertSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal
    {

        /// <summary>Backing field for <see cref="AlertsForAllFailoverIssue" /> property.</summary>
        private string _alertsForAllFailoverIssue;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AlertsForAllFailoverIssue { get => this._alertsForAllFailoverIssue; set => this._alertsForAllFailoverIssue = value; }

        /// <summary>Backing field for <see cref="AlertsForAllJobFailure" /> property.</summary>
        private string _alertsForAllJobFailure;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AlertsForAllJobFailure { get => this._alertsForAllJobFailure; set => this._alertsForAllJobFailure = value; }

        /// <summary>Backing field for <see cref="AlertsForAllReplicationIssue" /> property.</summary>
        private string _alertsForAllReplicationIssue;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AlertsForAllReplicationIssue { get => this._alertsForAllReplicationIssue; set => this._alertsForAllReplicationIssue = value; }

        /// <summary>Creates an new <see cref="AzureMonitorAlertSettings" /> instance.</summary>
        public AzureMonitorAlertSettings()
        {

        }
    }
    /// Settings for Azure Monitor based alerts
    public partial interface IAzureMonitorAlertSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllFailoverIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllFailoverIssue { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllJobFailure { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"alertsForAllReplicationIssues",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllReplicationIssue { get; set; }

    }
    /// Settings for Azure Monitor based alerts
    internal partial interface IAzureMonitorAlertSettingsInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllFailoverIssue { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllJobFailure { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AlertsForAllReplicationIssue { get; set; }

    }
}