// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the monitoring policies for the cluster upgrade.</summary>
    public partial class ClusterMonitoringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal
    {

        /// <summary>Backing field for <see cref="HealthCheckRetryTimeout" /> property.</summary>
        private string _healthCheckRetryTimeout;

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckRetryTimeout { get => this._healthCheckRetryTimeout; set => this._healthCheckRetryTimeout = value; }

        /// <summary>Backing field for <see cref="HealthCheckStableDuration" /> property.</summary>
        private string _healthCheckStableDuration;

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckStableDuration { get => this._healthCheckStableDuration; set => this._healthCheckStableDuration = value; }

        /// <summary>Backing field for <see cref="HealthCheckWaitDuration" /> property.</summary>
        private string _healthCheckWaitDuration;

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string HealthCheckWaitDuration { get => this._healthCheckWaitDuration; set => this._healthCheckWaitDuration = value; }

        /// <summary>Backing field for <see cref="UpgradeDomainTimeout" /> property.</summary>
        private string _upgradeDomainTimeout;

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeDomainTimeout { get => this._upgradeDomainTimeout; set => this._upgradeDomainTimeout = value; }

        /// <summary>Backing field for <see cref="UpgradeTimeout" /> property.</summary>
        private string _upgradeTimeout;

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeTimeout { get => this._upgradeTimeout; set => this._upgradeTimeout = value; }

        /// <summary>Creates an new <see cref="ClusterMonitoringPolicy" /> instance.</summary>
        public ClusterMonitoringPolicy()
        {

        }
    }
    /// Describes the monitoring policies for the cluster upgrade.
    public partial interface IClusterMonitoringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeTimeout { get; set; }

    }
    /// Describes the monitoring policies for the cluster upgrade.
    internal partial interface IClusterMonitoringPolicyInternal

    {
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string HealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string HealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string HealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string UpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string UpgradeTimeout { get; set; }

    }
}