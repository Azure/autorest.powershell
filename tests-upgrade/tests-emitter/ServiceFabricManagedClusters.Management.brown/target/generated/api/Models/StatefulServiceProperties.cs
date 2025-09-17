// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The properties of a stateful service resource.</summary>
    public partial class StatefulServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IStatefulServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IStatefulServicePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties __serviceResourceProperties = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourceProperties();

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> CorrelationScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).CorrelationScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).CorrelationScheme = value ?? null /* arrayOf */; }

        /// <summary>Specifies the move cost for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string DefaultMoveCost { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).DefaultMoveCost; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).DefaultMoveCost = value ?? null; }

        /// <summary>Backing field for <see cref="HasPersistedState" /> property.</summary>
        private bool? _hasPersistedState;

        /// <summary>
        /// A flag indicating whether this is a persistent service which stores states on the local disk. If it is then the value
        /// of this property is true, if not it is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? HasPersistedState { get => this._hasPersistedState; set => this._hasPersistedState = value; }

        /// <summary>Internal Acessors for PartitionDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.PartitionDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ProvisioningState = value ?? null; }

        /// <summary>Backing field for <see cref="MinReplicaSetSize" /> property.</summary>
        private int? _minReplicaSetSize;

        /// <summary>The minimum replica set size as a number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? MinReplicaSetSize { get => this._minReplicaSetSize; set => this._minReplicaSetSize = value; }

        /// <summary>Describes how the service is partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition PartitionDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription = value ?? null /* model class */; }

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string PartitionDescriptionPartitionScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescriptionPartitionScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescriptionPartitionScheme = value ; }

        /// <summary>
        /// The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for
        /// restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes
        /// where NodeType is blue specify the following: "NodeColor == blue)".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string PlacementConstraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).PlacementConstraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).PlacementConstraint = value ?? null; }

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ProvisioningState; }

        /// <summary>Backing field for <see cref="QuorumLossWaitDuration" /> property.</summary>
        private string _quorumLossWaitDuration;

        /// <summary>
        /// The maximum duration for which a partition is allowed to be in a state of quorum loss, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string QuorumLossWaitDuration { get => this._quorumLossWaitDuration; set => this._quorumLossWaitDuration = value; }

        /// <summary>Backing field for <see cref="ReplicaRestartWaitDuration" /> property.</summary>
        private string _replicaRestartWaitDuration;

        /// <summary>
        /// The duration between when a replica goes down and when a new replica is created, represented in ISO 8601 format "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ReplicaRestartWaitDuration { get => this._replicaRestartWaitDuration; set => this._replicaRestartWaitDuration = value; }

        /// <summary>Scaling policies for this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> ScalingPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ScalingPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ScalingPolicy = value ?? null /* arrayOf */; }

        /// <summary>
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service
        /// endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServiceDnsName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceDnsName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceDnsName = value ?? null; }

        /// <summary>The kind of service (Stateless or Stateful).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServiceKind { get => "Stateful"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceKind = "Stateful"; }

        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServiceLoadMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServiceLoadMetric = value ?? null /* arrayOf */; }

        /// <summary>The activation Mode of the service package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServicePackageActivationMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServicePackageActivationMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServicePackageActivationMode = value ?? null; }

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServicePlacementPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServicePlacementPolicy = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServicePlacementTimeLimit" /> property.</summary>
        private string _servicePlacementTimeLimit;

        /// <summary>
        /// The duration for which replicas can stay InBuild before reporting that build is stuck, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServicePlacementTimeLimit { get => this._servicePlacementTimeLimit; set => this._servicePlacementTimeLimit = value; }

        /// <summary>The name of the service type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServiceTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceTypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceTypeName = value ; }

        /// <summary>Backing field for <see cref="StandByReplicaKeepDuration" /> property.</summary>
        private string _standByReplicaKeepDuration;

        /// <summary>
        /// The definition on how long StandBy replicas should be maintained before being removed, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string StandByReplicaKeepDuration { get => this._standByReplicaKeepDuration; set => this._standByReplicaKeepDuration = value; }

        /// <summary>Backing field for <see cref="TargetReplicaSetSize" /> property.</summary>
        private int? _targetReplicaSetSize;

        /// <summary>The target replica set size as a number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? TargetReplicaSetSize { get => this._targetReplicaSetSize; set => this._targetReplicaSetSize = value; }

        /// <summary>Creates an new <see cref="StatefulServiceProperties" /> instance.</summary>
        public StatefulServiceProperties()
        {
            this.__serviceResourceProperties.ServiceKind = "Stateful";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__serviceResourceProperties), __serviceResourceProperties);
            await eventListener.AssertObjectIsValid(nameof(__serviceResourceProperties), __serviceResourceProperties);
        }
    }
    /// The properties of a stateful service resource.
    public partial interface IStatefulServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties
    {
        /// <summary>
        /// A flag indicating whether this is a persistent service which stores states on the local disk. If it is then the value
        /// of this property is true, if not it is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag indicating whether this is a persistent service which stores states on the local disk. If it is then the value of this property is true, if not it is false.",
        SerializedName = @"hasPersistedState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasPersistedState { get; set; }
        /// <summary>The minimum replica set size as a number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The minimum replica set size as a number.",
        SerializedName = @"minReplicaSetSize",
        PossibleTypes = new [] { typeof(int) })]
        int? MinReplicaSetSize { get; set; }
        /// <summary>
        /// The maximum duration for which a partition is allowed to be in a state of quorum loss, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum duration for which a partition is allowed to be in a state of quorum loss, represented in ISO 8601 format ""hh:mm:ss"".",
        SerializedName = @"quorumLossWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string QuorumLossWaitDuration { get; set; }
        /// <summary>
        /// The duration between when a replica goes down and when a new replica is created, represented in ISO 8601 format "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The duration between when a replica goes down and when a new replica is created, represented in ISO 8601 format ""hh:mm:ss"".",
        SerializedName = @"replicaRestartWaitDuration",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaRestartWaitDuration { get; set; }
        /// <summary>
        /// The duration for which replicas can stay InBuild before reporting that build is stuck, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The duration for which replicas can stay InBuild before reporting that build is stuck, represented in ISO 8601 format ""hh:mm:ss"".",
        SerializedName = @"servicePlacementTimeLimit",
        PossibleTypes = new [] { typeof(string) })]
        string ServicePlacementTimeLimit { get; set; }
        /// <summary>
        /// The definition on how long StandBy replicas should be maintained before being removed, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The definition on how long StandBy replicas should be maintained before being removed, represented in ISO 8601 format ""hh:mm:ss"".",
        SerializedName = @"standByReplicaKeepDuration",
        PossibleTypes = new [] { typeof(string) })]
        string StandByReplicaKeepDuration { get; set; }
        /// <summary>The target replica set size as a number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The target replica set size as a number.",
        SerializedName = @"targetReplicaSetSize",
        PossibleTypes = new [] { typeof(int) })]
        int? TargetReplicaSetSize { get; set; }

    }
    /// The properties of a stateful service resource.
    internal partial interface IStatefulServicePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal
    {
        /// <summary>
        /// A flag indicating whether this is a persistent service which stores states on the local disk. If it is then the value
        /// of this property is true, if not it is false.
        /// </summary>
        bool? HasPersistedState { get; set; }
        /// <summary>The minimum replica set size as a number.</summary>
        int? MinReplicaSetSize { get; set; }
        /// <summary>
        /// The maximum duration for which a partition is allowed to be in a state of quorum loss, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        string QuorumLossWaitDuration { get; set; }
        /// <summary>
        /// The duration between when a replica goes down and when a new replica is created, represented in ISO 8601 format "hh:mm:ss".
        /// </summary>
        string ReplicaRestartWaitDuration { get; set; }
        /// <summary>
        /// The duration for which replicas can stay InBuild before reporting that build is stuck, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        string ServicePlacementTimeLimit { get; set; }
        /// <summary>
        /// The definition on how long StandBy replicas should be maintained before being removed, represented in ISO 8601 format
        /// "hh:mm:ss".
        /// </summary>
        string StandByReplicaKeepDuration { get; set; }
        /// <summary>The target replica set size as a number.</summary>
        int? TargetReplicaSetSize { get; set; }

    }
}