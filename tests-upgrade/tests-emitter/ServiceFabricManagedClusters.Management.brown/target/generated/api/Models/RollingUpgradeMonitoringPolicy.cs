// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The policy used for monitoring the application upgrade</summary>
    public partial class RollingUpgradeMonitoringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal
    {

        /// <summary>Backing field for <see cref="FailureAction" /> property.</summary>
        private string _failureAction;

        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string FailureAction { get => this._failureAction; set => this._failureAction = value; }

        /// <summary>Backing field for <see cref="HealthCheckRetryTimeout" /> property.</summary>
        private string _healthCheckRetryTimeout;

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckRetryTimeout { get => this._healthCheckRetryTimeout; set => this._healthCheckRetryTimeout = value; }

        /// <summary>Backing field for <see cref="HealthCheckStableDuration" /> property.</summary>
        private string _healthCheckStableDuration;

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckStableDuration { get => this._healthCheckStableDuration; set => this._healthCheckStableDuration = value; }

        /// <summary>Backing field for <see cref="HealthCheckWaitDuration" /> property.</summary>
        private string _healthCheckWaitDuration;

        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckWaitDuration { get => this._healthCheckWaitDuration; set => this._healthCheckWaitDuration = value; }

        /// <summary>Backing field for <see cref="UpgradeDomainTimeout" /> property.</summary>
        private string _upgradeDomainTimeout;

        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeDomainTimeout { get => this._upgradeDomainTimeout; set => this._upgradeDomainTimeout = value; }

        /// <summary>Backing field for <see cref="UpgradeTimeout" /> property.</summary>
        private string _upgradeTimeout;

        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeTimeout { get => this._upgradeTimeout; set => this._upgradeTimeout = value; }

        /// <summary>Creates an new <see cref="RollingUpgradeMonitoringPolicy" /> instance.</summary>
        public RollingUpgradeMonitoringPolicy()
        {

        }
    }
    /// The policy used for monitoring the application upgrade
    public partial interface IRollingUpgradeMonitoringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.",
        SerializedName = @"failureAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Rollback", "Manual")]
        string FailureAction { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckStableDuration { get; set; }
        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeTimeout { get; set; }

    }
    /// The policy used for monitoring the application upgrade
    internal partial interface IRollingUpgradeMonitoringPolicyInternal

    {
        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Rollback", "Manual")]
        string FailureAction { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string HealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string HealthCheckStableDuration { get; set; }
        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string HealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string UpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string UpgradeTimeout { get; set; }

    }
}