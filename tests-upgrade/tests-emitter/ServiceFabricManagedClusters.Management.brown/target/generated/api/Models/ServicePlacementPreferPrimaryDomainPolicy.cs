// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes the policy to be used for placement of a Service Fabric service where the service's
    /// Primary replicas should optimally be placed in a particular domain.
    /// This placement policy is usually used with fault domains in scenarios where the Service Fabric
    /// cluster is geographically distributed in order to indicate that a service's primary replica should
    /// be located in a particular fault domain, which in geo-distributed scenarios usually aligns with regional
    /// or datacenter boundaries. Note that since this is an optimization it is possible that the Primary replica
    /// may not end up located in this domain due to failures, capacity limits, or other constraints.
    /// </summary>
    public partial class ServicePlacementPreferPrimaryDomainPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPreferPrimaryDomainPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPreferPrimaryDomainPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy __servicePlacementPolicy = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicy();

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>The name of the domain that should used for placement as per this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DomainName { get => this._domainName; set => this._domainName = value; }

        /// <summary>
        /// The type of placement policy for a service fabric service. Following are the possible values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Type { get => "PreferredPrimaryDomain"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal)__servicePlacementPolicy).Type = "PreferredPrimaryDomain"; }

        /// <summary>
        /// Creates an new <see cref="ServicePlacementPreferPrimaryDomainPolicy" /> instance.
        /// </summary>
        public ServicePlacementPreferPrimaryDomainPolicy()
        {
            this.__servicePlacementPolicy.Type = "PreferredPrimaryDomain";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__servicePlacementPolicy), __servicePlacementPolicy);
            await eventListener.AssertObjectIsValid(nameof(__servicePlacementPolicy), __servicePlacementPolicy);
        }
    }
    /// Describes the policy to be used for placement of a Service Fabric service where the service's
    /// Primary replicas should optimally be placed in a particular domain.
    /// This placement policy is usually used with fault domains in scenarios where the Service Fabric
    /// cluster is geographically distributed in order to indicate that a service's primary replica should
    /// be located in a particular fault domain, which in geo-distributed scenarios usually aligns with regional
    /// or datacenter boundaries. Note that since this is an optimization it is possible that the Primary replica
    /// may not end up located in this domain due to failures, capacity limits, or other constraints.
    public partial interface IServicePlacementPreferPrimaryDomainPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy
    {
        /// <summary>The name of the domain that should used for placement as per this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the domain that should used for placement as per this policy.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get; set; }

    }
    /// Describes the policy to be used for placement of a Service Fabric service where the service's
    /// Primary replicas should optimally be placed in a particular domain.
    /// This placement policy is usually used with fault domains in scenarios where the Service Fabric
    /// cluster is geographically distributed in order to indicate that a service's primary replica should
    /// be located in a particular fault domain, which in geo-distributed scenarios usually aligns with regional
    /// or datacenter boundaries. Note that since this is an optimization it is possible that the Primary replica
    /// may not end up located in this domain due to failures, capacity limits, or other constraints.
    internal partial interface IServicePlacementPreferPrimaryDomainPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal
    {
        /// <summary>The name of the domain that should used for placement as per this policy.</summary>
        string DomainName { get; set; }

    }
}