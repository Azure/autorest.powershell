// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The properties of a stateless service resource.</summary>
    public partial class StatelessServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IStatelessServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IStatelessServicePropertiesInternal,
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

        /// <summary>Backing field for <see cref="InstanceCount" /> property.</summary>
        private int _instanceCount;

        /// <summary>The instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int InstanceCount { get => this._instanceCount; set => this._instanceCount = value; }

        /// <summary>Internal Acessors for PartitionDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.PartitionDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).PartitionDescription = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ProvisioningState = value ?? null; }

        /// <summary>Backing field for <see cref="MinInstanceCount" /> property.</summary>
        private int? _minInstanceCount;

        /// <summary>
        /// MinInstanceCount is the minimum number of instances that must be up to meet the EnsureAvailability safety check during
        /// operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil( MinInstancePercentage/100.0
        /// * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstanceCount computation -1 is first converted into
        /// the number of nodes on which the instances are allowed to be placed according to the placement constraints on the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? MinInstanceCount { get => this._minInstanceCount; set => this._minInstanceCount = value; }

        /// <summary>Backing field for <see cref="MinInstancePercentage" /> property.</summary>
        private int? _minInstancePercentage;

        /// <summary>
        /// MinInstancePercentage is the minimum percentage of InstanceCount that must be up to meet the EnsureAvailability safety
        /// check during operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil(
        /// MinInstancePercentage/100.0 * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstancePercentage computation,
        /// -1 is first converted into the number of nodes on which the instances are allowed to be placed according to the placement
        /// constraints on the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? MinInstancePercentage { get => this._minInstancePercentage; set => this._minInstancePercentage = value; }

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
        public string ServiceKind { get => "Stateless"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceKind = "Stateless"; }

        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServiceLoadMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServiceLoadMetric = value ?? null /* arrayOf */; }

        /// <summary>The activation Mode of the service package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServicePackageActivationMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServicePackageActivationMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServicePackageActivationMode = value ?? null; }

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServicePlacementPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourceProperties).ServicePlacementPolicy = value ?? null /* arrayOf */; }

        /// <summary>The name of the service type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string ServiceTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceTypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal)__serviceResourceProperties).ServiceTypeName = value ; }

        /// <summary>Creates an new <see cref="StatelessServiceProperties" /> instance.</summary>
        public StatelessServiceProperties()
        {
            this.__serviceResourceProperties.ServiceKind = "Stateless";
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
    /// The properties of a stateless service resource.
    public partial interface IStatelessServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties
    {
        /// <summary>The instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The instance count.",
        SerializedName = @"instanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int InstanceCount { get; set; }
        /// <summary>
        /// MinInstanceCount is the minimum number of instances that must be up to meet the EnsureAvailability safety check during
        /// operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil( MinInstancePercentage/100.0
        /// * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstanceCount computation -1 is first converted into
        /// the number of nodes on which the instances are allowed to be placed according to the placement constraints on the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"MinInstanceCount is the minimum number of instances that must be up to meet the EnsureAvailability safety check during operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil( MinInstancePercentage/100.0 * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstanceCount computation -1 is first converted into the number of nodes on which the instances are allowed to be placed according to the placement constraints on the service.",
        SerializedName = @"minInstanceCount",
        PossibleTypes = new [] { typeof(int) })]
        int? MinInstanceCount { get; set; }
        /// <summary>
        /// MinInstancePercentage is the minimum percentage of InstanceCount that must be up to meet the EnsureAvailability safety
        /// check during operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil(
        /// MinInstancePercentage/100.0 * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstancePercentage computation,
        /// -1 is first converted into the number of nodes on which the instances are allowed to be placed according to the placement
        /// constraints on the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"MinInstancePercentage is the minimum percentage of InstanceCount that must be up to meet the EnsureAvailability safety check during operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil( MinInstancePercentage/100.0 * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstancePercentage computation, -1 is first converted into the number of nodes on which the instances are allowed to be placed according to the placement constraints on the service.",
        SerializedName = @"minInstancePercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? MinInstancePercentage { get; set; }

    }
    /// The properties of a stateless service resource.
    internal partial interface IStatelessServicePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal
    {
        /// <summary>The instance count.</summary>
        int InstanceCount { get; set; }
        /// <summary>
        /// MinInstanceCount is the minimum number of instances that must be up to meet the EnsureAvailability safety check during
        /// operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil( MinInstancePercentage/100.0
        /// * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstanceCount computation -1 is first converted into
        /// the number of nodes on which the instances are allowed to be placed according to the placement constraints on the service.
        /// </summary>
        int? MinInstanceCount { get; set; }
        /// <summary>
        /// MinInstancePercentage is the minimum percentage of InstanceCount that must be up to meet the EnsureAvailability safety
        /// check during operations like upgrade or deactivate node. The actual number that is used is max( MinInstanceCount, ceil(
        /// MinInstancePercentage/100.0 * InstanceCount) ). Note, if InstanceCount is set to -1, during MinInstancePercentage computation,
        /// -1 is first converted into the number of nodes on which the instances are allowed to be placed according to the placement
        /// constraints on the service.
        /// </summary>
        int? MinInstancePercentage { get; set; }

    }
}