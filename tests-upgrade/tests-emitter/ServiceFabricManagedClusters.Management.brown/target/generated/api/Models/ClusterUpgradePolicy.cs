// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the policy used when upgrading the cluster.</summary>
    public partial class ClusterUpgradePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal
    {

        /// <summary>Backing field for <see cref="DeltaHealthPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy _deltaHealthPolicy;

        /// <summary>
        /// The cluster delta health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy DeltaHealthPolicy { get => (this._deltaHealthPolicy = this._deltaHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicy()); set => this._deltaHealthPolicy = value; }

        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentDeltaUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentDeltaUnhealthyApplication = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentUpgradeDomainDeltaUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicyInternal)DeltaHealthPolicy).MaxPercentUpgradeDomainDeltaUnhealthyNode = value ?? default(int); }

        /// <summary>Backing field for <see cref="ForceRestart" /> property.</summary>
        private bool? _forceRestart;

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? ForceRestart { get => this._forceRestart; set => this._forceRestart = value; }

        /// <summary>Backing field for <see cref="HealthPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy _healthPolicy;

        /// <summary>
        /// The cluster health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy HealthPolicy { get => (this._healthPolicy = this._healthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicy()); set => this._healthPolicy = value; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HealthPolicyMaxPercentUnhealthyApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicyInternal)HealthPolicy).MaxPercentUnhealthyApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicyInternal)HealthPolicy).MaxPercentUnhealthyApplication = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? HealthPolicyMaxPercentUnhealthyNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicyInternal)HealthPolicy).MaxPercentUnhealthyNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicyInternal)HealthPolicy).MaxPercentUnhealthyNode = value ?? default(int); }

        /// <summary>Internal Acessors for DeltaHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal.DeltaHealthPolicy { get => (this._deltaHealthPolicy = this._deltaHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicy()); set { {_deltaHealthPolicy = value;} } }

        /// <summary>Internal Acessors for HealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal.HealthPolicy { get => (this._healthPolicy = this._healthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicy()); set { {_healthPolicy = value;} } }

        /// <summary>Internal Acessors for MonitoringPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal.MonitoringPolicy { get => (this._monitoringPolicy = this._monitoringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicy()); set { {_monitoringPolicy = value;} } }

        /// <summary>Backing field for <see cref="MonitoringPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy _monitoringPolicy;

        /// <summary>
        /// The cluster monitoring policy describes the parameters for monitoring an upgrade in Monitored mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy MonitoringPolicy { get => (this._monitoringPolicy = this._monitoringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicy()); set => this._monitoringPolicy = value; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckRetryTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckRetryTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckRetryTimeout = value ?? null; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckStableDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckStableDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckStableDuration = value ?? null; }

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyHealthCheckWaitDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckWaitDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).HealthCheckWaitDuration = value ?? null; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeDomainTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).UpgradeDomainTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).UpgradeDomainTimeout = value ?? null; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string MonitoringPolicyUpgradeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).UpgradeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicyInternal)MonitoringPolicy).UpgradeTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="UpgradeReplicaSetCheckTimeout" /> property.</summary>
        private string _upgradeReplicaSetCheckTimeout;

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeReplicaSetCheckTimeout { get => this._upgradeReplicaSetCheckTimeout; set => this._upgradeReplicaSetCheckTimeout = value; }

        /// <summary>Creates an new <see cref="ClusterUpgradePolicy" /> instance.</summary>
        public ClusterUpgradePolicy()
        {

        }
    }
    /// Describes the policy used when upgrading the cluster.
    public partial interface IClusterUpgradePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits. System services are not included in this.
        NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications",
        SerializedName = @"maxPercentDeltaUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.",
        SerializedName = @"maxPercentDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade domain nodes at the time of the health evaluation.
        The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the state of the upgrade domains is within tolerated limits.",
        SerializedName = @"maxPercentUpgradeDomainDeltaUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).",
        SerializedName = @"forceRestart",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForceRestart { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? HealthPolicyMaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.

        The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.
        If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.

        In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.",
        SerializedName = @"maxPercentUnhealthyNodes",
        PossibleTypes = new [] { typeof(int) })]
        int? HealthPolicyMaxPercentUnhealthyNode { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues.
        When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)",
        SerializedName = @"upgradeReplicaSetCheckTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeReplicaSetCheckTimeout { get; set; }

    }
    /// Describes the policy used when upgrading the cluster.
    internal partial interface IClusterUpgradePolicyInternal

    {
        /// <summary>
        /// The cluster delta health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy DeltaHealthPolicy { get; set; }
        /// <summary>
        /// The maximum allowed percentage of applications health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the applications at the beginning of upgrade and the state of the applications
        /// at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits. System services are not included in this.
        /// NOTE: This value will overwrite the value specified in properties.UpgradeDescription.HealthPolicy.MaxPercentUnhealthyApplications
        /// </summary>
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the nodes at the beginning of upgrade and the state of the nodes at the time
        /// of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </summary>
        int? DeltaHealthPolicyMaxPercentDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// The maximum allowed percentage of upgrade domain nodes health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the upgrade domain nodes at the beginning of upgrade and the state of the upgrade
        /// domain nodes at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion for all completed upgrade domains to make sure the
        /// state of the upgrade domains is within tolerated limits.
        /// </summary>
        int? DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        bool? ForceRestart { get; set; }
        /// <summary>
        /// The cluster health policy defines a health policy used to evaluate the health of the cluster during a cluster upgrade.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy HealthPolicy { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications
        /// to be unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in
        /// the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        /// </summary>
        int? HealthPolicyMaxPercentUnhealthyApplication { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be
        /// unhealthy, this value would be 10.
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate
        /// that.
        /// </summary>
        int? HealthPolicyMaxPercentUnhealthyNode { get; set; }
        /// <summary>
        /// The cluster monitoring policy describes the parameters for monitoring an upgrade in Monitored mode.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy MonitoringPolicy { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back.
        /// The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in
        /// either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss
        /// or in d.hh:mm:ss.ms format.
        /// </summary>
        string MonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues.
        /// When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// This value must be between 00:00:00 and 49710.06:28:15 (unsigned 32 bit integer for seconds)
        /// </summary>
        string UpgradeReplicaSetCheckTimeout { get; set; }

    }
}