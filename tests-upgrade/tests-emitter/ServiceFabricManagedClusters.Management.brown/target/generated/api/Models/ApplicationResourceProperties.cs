// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The application resource properties.</summary>
    public partial class ApplicationResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal
    {

        /// <summary>Indicates whether warnings are treated with the same severity as errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ApplicationHealthPolicyConsiderWarningAsError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyConsiderWarningAsError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyConsiderWarningAsError = value ?? default(bool); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application
        /// is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application
        /// is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = value ?? default(int); }

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap ApplicationHealthPolicyServiceTypeHealthPolicyMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyServiceTypeHealthPolicyMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyServiceTypeHealthPolicyMap = value ?? null /* model class */; }

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
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = value ?? default(int); }

        /// <summary>
        /// The maximum allowed percentage of unhealthy replicas per partition.
        /// The percentage represents the maximum tolerated percentage of replicas that can be unhealthy before the partition is considered
        /// in error.
        /// If the percentage is respected but there is at least one unhealthy replica, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy replicas over the total number of replicas in the partition.
        /// The computation rounds up to tolerate one failure on small numbers of replicas.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = value ?? default(int); }

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
        public int? DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = value ?? default(int); }

        /// <summary>Backing field for <see cref="ManagedIdentity" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity> _managedIdentity;

        /// <summary>
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity> ManagedIdentity { get => this._managedIdentity; set => this._managedIdentity = value; }

        /// <summary>Internal Acessors for ApplicationHealthPolicyDefaultServiceTypeHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal.ApplicationHealthPolicyDefaultServiceTypeHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for UpgradePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal.UpgradePolicy { get => (this._upgradePolicy = this._upgradePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy()); set { {_upgradePolicy = value;} } }

        /// <summary>Internal Acessors for UpgradePolicyApplicationHealthPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal.UpgradePolicyApplicationHealthPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ApplicationHealthPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpgradePolicyRollingUpgradeMonitoringPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal.UpgradePolicyRollingUpgradeMonitoringPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicy = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters _parameter;

        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesParameters()); set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
        /// Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically.
        /// Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyFailureAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyFailureAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyFailureAction = value ?? null; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = value ?? null; }

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckStableDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckStableDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = value ?? null; }

        /// <summary>
        /// The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a
        /// string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyHealthCheckWaitDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = value ?? null; }

        /// <summary>
        /// The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyUpgradeDomainTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = value ?? null; }

        /// <summary>
        /// The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours.
        /// It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string RollingUpgradeMonitoringPolicyUpgradeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyUpgradeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RollingUpgradeMonitoringPolicyUpgradeTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="UpgradePolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy _upgradePolicy;

        /// <summary>Describes the policy for a monitored application upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy UpgradePolicy { get => (this._upgradePolicy = this._upgradePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy()); set => this._upgradePolicy = value; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UpgradePolicyForceRestart { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ForceRestart; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).ForceRestart = value ?? default(bool); }

        /// <summary>
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public long? UpgradePolicyInstanceCloseDelayDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).InstanceCloseDelayDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).InstanceCloseDelayDuration = value ?? default(long); }

        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? UpgradePolicyRecreateApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RecreateApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).RecreateApplication = value ?? default(bool); }

        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string UpgradePolicyUpgradeMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).UpgradeMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).UpgradeMode = value ?? null; }

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public long? UpgradePolicyUpgradeReplicaSetCheckTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).UpgradeReplicaSetCheckTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)UpgradePolicy).UpgradeReplicaSetCheckTimeout = value ?? default(long); }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// The version of the application type as defined in the application manifest.
        /// This name must be the full Arm Resource ID for the referenced application type version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ApplicationResourceProperties" /> instance.</summary>
        public ApplicationResourceProperties()
        {

        }
    }
    /// The application resource properties.
    public partial interface IApplicationResourceProperties :
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
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of user assigned identities for the application, each mapped to a friendly name.",
        SerializedName = @"managedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity> ManagedIdentity { get; set; }
        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of application parameters with overridden values from their default values specified in the application manifest.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters Parameter { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The current deployment or provisioning state, which only appears in the response",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
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
        bool? UpgradePolicyForceRestart { get; set; }
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
        long? UpgradePolicyInstanceCloseDelayDuration { get; set; }
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
        bool? UpgradePolicyRecreateApplication { get; set; }
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
        string UpgradePolicyUpgradeMode { get; set; }
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
        long? UpgradePolicyUpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary>
        /// The version of the application type as defined in the application manifest.
        /// This name must be the full Arm Resource ID for the referenced application type version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the application type as defined in the application manifest.
        This name must be the full Arm Resource ID for the referenced application type version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// The application resource properties.
    internal partial interface IApplicationResourcePropertiesInternal

    {
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
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity> ManagedIdentity { get; set; }
        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters Parameter { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        string ProvisioningState { get; set; }
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
        /// <summary>Describes the policy for a monitored application upgrade.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy UpgradePolicy { get; set; }
        /// <summary>
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy UpgradePolicyApplicationHealthPolicy { get; set; }
        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade
        /// only changes configuration or data).
        /// </summary>
        bool? UpgradePolicyForceRestart { get; set; }
        /// <summary>
        /// Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully.
        /// This would be effective when the instance is closing during the application/cluster upgrade, only for those instances
        /// which have a non-zero delay duration configured in the service description.
        /// </summary>
        long? UpgradePolicyInstanceCloseDelayDuration { get; set; }
        /// <summary>
        /// Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters
        /// are not allowed.
        /// </summary>
        bool? UpgradePolicyRecreateApplication { get; set; }
        /// <summary>The policy used for monitoring the application upgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy UpgradePolicyRollingUpgradeMonitoringPolicy { get; set; }
        /// <summary>
        /// The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Monitored", "UnmonitoredAuto")]
        string UpgradePolicyUpgradeMode { get; set; }
        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected
        /// issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues.
        /// The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned
        /// 32-bit integer). Unit is in seconds.
        /// </summary>
        long? UpgradePolicyUpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary>
        /// The version of the application type as defined in the application manifest.
        /// This name must be the full Arm Resource ID for the referenced application type version.
        /// </summary>
        string Version { get; set; }

    }
}