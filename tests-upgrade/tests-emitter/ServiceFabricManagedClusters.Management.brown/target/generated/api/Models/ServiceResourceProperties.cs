// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The service resource properties.</summary>
    public partial class ServiceResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase __serviceResourcePropertiesBase = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesBase();

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation> CorrelationScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).CorrelationScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).CorrelationScheme = value ?? null /* arrayOf */; }

        /// <summary>Specifies the move cost for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string DefaultMoveCost { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).DefaultMoveCost; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).DefaultMoveCost = value ?? null; }

        /// <summary>Internal Acessors for PartitionDescription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.PartitionDescription { get => (this._partitionDescription = this._partitionDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Partition()); set { {_partitionDescription = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PartitionDescription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition _partitionDescription;

        /// <summary>Describes how the service is partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition PartitionDescription { get => (this._partitionDescription = this._partitionDescription ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Partition()); set => this._partitionDescription = value; }

        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string PartitionDescriptionPartitionScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal)PartitionDescription).Scheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartitionInternal)PartitionDescription).Scheme = value ; }

        /// <summary>
        /// The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for
        /// restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes
        /// where NodeType is blue specify the following: "NodeColor == blue)".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string PlacementConstraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).PlacementConstraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).PlacementConstraint = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Scaling policies for this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy> ScalingPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ScalingPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ScalingPolicy = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServiceDnsName" /> property.</summary>
        private string _serviceDnsName;

        /// <summary>
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service
        /// endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServiceDnsName { get => this._serviceDnsName; set => this._serviceDnsName = value; }

        /// <summary>Backing field for <see cref="ServiceKind" /> property.</summary>
        private string _serviceKind;

        /// <summary>The kind of service (Stateless or Stateful).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServiceKind { get => this._serviceKind; set => this._serviceKind = value; }

        /// <summary>The service load metrics is given as an array of ServiceLoadMetric objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric> ServiceLoadMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ServiceLoadMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ServiceLoadMetric = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServicePackageActivationMode" /> property.</summary>
        private string _servicePackageActivationMode;

        /// <summary>The activation Mode of the service package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServicePackageActivationMode { get => this._servicePackageActivationMode; set => this._servicePackageActivationMode = value; }

        /// <summary>A list that describes the correlation of the service with other services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy> ServicePlacementPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ServicePlacementPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)__serviceResourcePropertiesBase).ServicePlacementPolicy = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServiceTypeName" /> property.</summary>
        private string _serviceTypeName;

        /// <summary>The name of the service type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ServiceTypeName { get => this._serviceTypeName; set => this._serviceTypeName = value; }

        /// <summary>Creates an new <see cref="ServiceResourceProperties" /> instance.</summary>
        public ServiceResourceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__serviceResourcePropertiesBase), __serviceResourcePropertiesBase);
            await eventListener.AssertObjectIsValid(nameof(__serviceResourcePropertiesBase), __serviceResourcePropertiesBase);
        }
    }
    /// The service resource properties.
    public partial interface IServiceResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase
    {
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enumerates the ways that a service can be partitioned.",
        SerializedName = @"partitionScheme",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Singleton", "UniformInt64Range", "Named")]
        string PartitionDescriptionPartitionScheme { get; set; }
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
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service
        /// endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service endpoints for application layer protocols (e.g., HTTP).
        When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.",
        SerializedName = @"serviceDnsName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceDnsName { get; set; }
        /// <summary>The kind of service (Stateless or Stateful).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The kind of service (Stateless or Stateful).",
        SerializedName = @"serviceKind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Stateless", "Stateful")]
        string ServiceKind { get; set; }
        /// <summary>The activation Mode of the service package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The activation Mode of the service package",
        SerializedName = @"servicePackageActivationMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("SharedProcess", "ExclusiveProcess")]
        string ServicePackageActivationMode { get; set; }
        /// <summary>The name of the service type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the service type",
        SerializedName = @"serviceTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceTypeName { get; set; }

    }
    /// The service resource properties.
    internal partial interface IServiceResourcePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal
    {
        /// <summary>Describes how the service is partitioned.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPartition PartitionDescription { get; set; }
        /// <summary>Enumerates the ways that a service can be partitioned.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Singleton", "UniformInt64Range", "Named")]
        string PartitionDescriptionPartitionScheme { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service
        /// endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        /// </summary>
        string ServiceDnsName { get; set; }
        /// <summary>The kind of service (Stateless or Stateful).</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Stateless", "Stateful")]
        string ServiceKind { get; set; }
        /// <summary>The activation Mode of the service package</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("SharedProcess", "ExclusiveProcess")]
        string ServicePackageActivationMode { get; set; }
        /// <summary>The name of the service type</summary>
        string ServiceTypeName { get; set; }

    }
}