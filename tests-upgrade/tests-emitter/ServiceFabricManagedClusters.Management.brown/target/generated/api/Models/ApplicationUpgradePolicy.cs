// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the policy for a monitored application upgrade.</summary>
    public partial class ApplicationUpgradePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal
    {

        /// <summary>Backing field for <see cref="ApplicationHealthPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy _applicationHealthPolicy;

        /// <summary>
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy ApplicationHealthPolicy { get => (this._applicationHealthPolicy = this._applicationHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicy()); set => this._applicationHealthPolicy = value; }

        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ApplicationHealthPolicyConsiderWarningAsError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).ConsiderWarningAsError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).ConsiderWarningAsError = value ?? default(bool); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).MaxPercentUnhealthyDeployedApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).MaxPercentUnhealthyDeployedApplication = value ?? default(int); }

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ApplicationHealthPolicyServiceTypeHealthPolicyMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).ServiceTypeHealthPolicyMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).ServiceTypeHealthPolicyMap = value ?? null /* model class */; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = value ?? default(int); }

        /// <summary>Backing field for <see cref="ForceRestart" /> property.</summary>
        private bool? _forceRestart;

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? ForceRestart { get => this._forceRestart; set => this._forceRestart = value; }

        /// <summary>Backing field for <see cref="InstanceCloseDelayDuration" /> property.</summary>
        private long? _instanceCloseDelayDuration;

        /// <summary>
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public long? InstanceCloseDelayDuration { get => this._instanceCloseDelayDuration; set => this._instanceCloseDelayDuration = value; }

        /// <summary>Internal Acessors for ApplicationHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal.ApplicationHealthPolicy { get => (this._applicationHealthPolicy = this._applicationHealthPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicy()); set { {_applicationHealthPolicy = value;} } }

        /// <summary>Internal Acessors for ApplicationHealthPolicyDefaultServiceTypeHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal.ApplicationHealthPolicyDefaultServiceTypeHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyInternal)ApplicationHealthPolicy).DefaultServiceTypeHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RollingUpgradeMonitoringPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal.RollingUpgradeMonitoringPolicy { get => (this._rollingUpgradeMonitoringPolicy = this._rollingUpgradeMonitoringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicy()); set { {_rollingUpgradeMonitoringPolicy = value;} } }

        /// <summary>Backing field for <see cref="RecreateApplication" /> property.</summary>
        private bool? _recreateApplication;

        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? RecreateApplication { get => this._recreateApplication; set => this._recreateApplication = value; }

        /// <summary>Backing field for <see cref="RollingUpgradeMonitoringPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy _rollingUpgradeMonitoringPolicy;

        /// <summary>The policy used for monitoring the application upgrade</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy RollingUpgradeMonitoringPolicy { get => (this._rollingUpgradeMonitoringPolicy = this._rollingUpgradeMonitoringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicy()); set => this._rollingUpgradeMonitoringPolicy = value; }

        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyFailureAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).FailureAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).FailureAction = value ?? null; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckRetryTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckRetryTimeout = value ?? null; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckStableDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckStableDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckStableDuration = value ?? null; }

        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckWaitDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckWaitDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).HealthCheckWaitDuration = value ?? null; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyUpgradeDomainTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).UpgradeDomainTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).UpgradeDomainTimeout = value ?? null; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyUpgradeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).UpgradeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicyInternal)RollingUpgradeMonitoringPolicy).UpgradeTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="UpgradeMode" /> property.</summary>
        private string _upgradeMode;

        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpgradeMode { get => this._upgradeMode; set => this._upgradeMode = value; }

        /// <summary>Backing field for <see cref="UpgradeReplicaSetCheckTimeout" /> property.</summary>
        private long? _upgradeReplicaSetCheckTimeout;

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public long? UpgradeReplicaSetCheckTimeout { get => this._upgradeReplicaSetCheckTimeout; set => this._upgradeReplicaSetCheckTimeout = value; }

        /// <summary>Creates an new <see cref="ApplicationUpgradePolicy" /> instance.</summary>
        public ApplicationUpgradePolicy()
        {

        }
    }
    /// Describes the policy for a monitored application upgrade.
    public partial interface IApplicationUpgradePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether warnings are treated with the same severity as errors.",
        SerializedName = @"considerWarningAsError",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApplicationHealthPolicyConsiderWarningAsError { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.
        This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.
        The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.",
        SerializedName = @"maxPercentUnhealthyDeployedApplications",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication { get; set; }
        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The map with service type health policy per service type name. The map is empty by default.",
        SerializedName = @"serviceTypeHealthPolicyMap",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ApplicationHealthPolicyServiceTypeHealthPolicyMap { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy partitions per service.

        The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered in error.
        If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the service.
        The computation rounds up to tolerate one failure on small numbers of partitions.",
        SerializedName = @"maxPercentUnhealthyPartitionsPerService",
        PossibleTypes = new [] { typeof(int) })]
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy replicas per partition.

        The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered in error.
        If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        The computation rounds up to tolerate one failure on small numbers of replicas.",
        SerializedName = @"maxPercentUnhealthyReplicasPerPartition",
        PossibleTypes = new [] { typeof(int) })]
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum allowed percentage of unhealthy services.

        The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is considered in error.
        If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        This is calculated by dividing the number of unhealthy services of the specific service type over the total number of services of the specific service type.
        The computation rounds up to tolerate one failure on small numbers of services.",
        SerializedName = @"maxPercentUnhealthyServices",
        PossibleTypes = new [] { typeof(int) })]
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get; set; }
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
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully. This would be effective when the instance is closing during the application/cluster upgrade, only for those instances which have a non-zero delay duration configured in the service description.",
        SerializedName = @"instanceCloseDelayDuration",
        PossibleTypes = new [] { typeof(long) })]
        long? InstanceCloseDelayDuration { get; set; }
        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed.",
        SerializedName = @"recreateApplication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RecreateApplication { get; set; }
        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.",
        SerializedName = @"failureAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Rollback", "Manual")]
        string RollingUpgradeMonitoringPolicyFailureAction { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckRetryTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckStableDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RollingUpgradeMonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"healthCheckWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RollingUpgradeMonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeDomainTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string RollingUpgradeMonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format ""hh:mm:ss.fff"".",
        SerializedName = @"upgradeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string RollingUpgradeMonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.",
        SerializedName = @"upgradeMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Monitored", "UnmonitoredAuto")]
        string UpgradeMode { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). Unit is in seconds.",
        SerializedName = @"upgradeReplicaSetCheckTimeout",
        PossibleTypes = new [] { typeof(long) })]
        long? UpgradeReplicaSetCheckTimeout { get; set; }

    }
    /// Describes the policy for a monitored application upgrade.
    internal partial interface IApplicationUpgradePolicyInternal

    {
        /// <summary>
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy ApplicationHealthPolicy { get; set; }
        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        bool? ApplicationHealthPolicyConsiderWarningAsError { get; set; }
        /// <summary>The health policy used by default to evaluate the health of a service type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy ApplicationHealthPolicyDefaultServiceTypeHealthPolicy { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        int? ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication { get; set; }
        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ApplicationHealthPolicyServiceTypeHealthPolicyMap { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy partitions per service.
        /// The percentage represents the maximum tolerated percentage of partitions that can be unhealthy before the service is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy partition, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy partitions over the total number of partitions in the
        /// service.
        /// The computation rounds up to tolerate one failure on small numbers of partitions.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy services.
        /// The percentage represents the maximum tolerated percentage of services that can be unhealthy before the application is
        /// considered in error.
        /// If the percentage is respected but there is at least one unhealthy service, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy services of the specific service type over the total number of
        /// services of the specific service type.
        /// The computation rounds up to tolerate one failure on small numbers of services.
        /// </summary>
        int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        bool? ForceRestart { get; set; }
        /// <summary>
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        long? InstanceCloseDelayDuration { get; set; }
        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        bool? RecreateApplication { get; set; }
        /// <summary>The policy used for monitoring the application upgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy RollingUpgradeMonitoringPolicy { get; set; }
        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Rollback", "Manual")]
        string RollingUpgradeMonitoringPolicyFailureAction { get; set; }
        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout { get; set; }
        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string RollingUpgradeMonitoringPolicyHealthCheckStableDuration { get; set; }
        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string RollingUpgradeMonitoringPolicyHealthCheckWaitDuration { get; set; }
        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string RollingUpgradeMonitoringPolicyUpgradeDomainTimeout { get; set; }
        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        string RollingUpgradeMonitoringPolicyUpgradeTimeout { get; set; }
        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Monitored", "UnmonitoredAuto")]
        string UpgradeMode { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        long? UpgradeReplicaSetCheckTimeout { get; set; }

    }
}