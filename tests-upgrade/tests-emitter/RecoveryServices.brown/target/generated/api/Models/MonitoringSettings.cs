// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Monitoring Settings of the vault</summary>
    public partial class MonitoringSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal
    {

        /// <summary>Backing field for <see cref="AzureMonitorAlertSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings _azureMonitorAlertSetting;

        /// <summary>Settings for Azure Monitor based alerts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings AzureMonitorAlertSetting { get => (this._azureMonitorAlertSetting = this._azureMonitorAlertSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettings()); set => this._azureMonitorAlertSetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllFailoverIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllFailoverIssue = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllJobFailure = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllReplicationIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettingsInternal)AzureMonitorAlertSetting).AlertsForAllReplicationIssue = value ?? null; }

        /// <summary>Backing field for <see cref="ClassicAlertSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings _classicAlertSetting;

        /// <summary>Settings for classic alerts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings ClassicAlertSetting { get => (this._classicAlertSetting = this._classicAlertSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettings()); set => this._classicAlertSetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingAlertsForCriticalOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettingsInternal)ClassicAlertSetting).AlertsForCriticalOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettingsInternal)ClassicAlertSetting).AlertsForCriticalOperation = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ClassicAlertSettingEmailNotificationsForSiteRecovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettingsInternal)ClassicAlertSetting).EmailNotificationsForSiteRecovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettingsInternal)ClassicAlertSetting).EmailNotificationsForSiteRecovery = value ?? null; }

        /// <summary>Internal Acessors for AzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal.AzureMonitorAlertSetting { get => (this._azureMonitorAlertSetting = this._azureMonitorAlertSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.AzureMonitorAlertSettings()); set { {_azureMonitorAlertSetting = value;} } }

        /// <summary>Internal Acessors for ClassicAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IMonitoringSettingsInternal.ClassicAlertSetting { get => (this._classicAlertSetting = this._classicAlertSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClassicAlertSettings()); set { {_classicAlertSetting = value;} } }

        /// <summary>Creates an new <see cref="MonitoringSettings" /> instance.</summary>
        public MonitoringSettings()
        {

        }
    }
    /// Monitoring Settings of the vault
    public partial interface IMonitoringSettings :
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
        string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get; set; }

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
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }

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
        string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get; set; }

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
        string ClassicAlertSettingAlertsForCriticalOperation { get; set; }

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
        string ClassicAlertSettingEmailNotificationsForSiteRecovery { get; set; }

    }
    /// Monitoring Settings of the vault
    internal partial interface IMonitoringSettingsInternal

    {
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAzureMonitorAlertSettings AzureMonitorAlertSetting { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllFailoverIssue { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllJobFailure { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AzureMonitorAlertSettingAlertsForAllReplicationIssue { get; set; }
        /// <summary>Settings for classic alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClassicAlertSettings ClassicAlertSetting { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingAlertsForCriticalOperation { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string ClassicAlertSettingEmailNotificationsForSiteRecovery { get; set; }

    }
}