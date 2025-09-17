// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes the policy to be used for placement of a Service Fabric service where the instances or replicas of that service
    /// must be placed in a particular domain.
    /// </summary>
    public partial class ServicePlacementRequiredDomainPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementRequiredDomainPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementRequiredDomainPolicyInternal,
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
        public string Type { get => "RequiredDomain"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal)__servicePlacementPolicy).Type = "RequiredDomain"; }

        /// <summary>Creates an new <see cref="ServicePlacementRequiredDomainPolicy" /> instance.</summary>
        public ServicePlacementRequiredDomainPolicy()
        {
            this.__servicePlacementPolicy.Type = "RequiredDomain";
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
    /// Describes the policy to be used for placement of a Service Fabric service where the instances or replicas of that service
    /// must be placed in a particular domain.
    public partial interface IServicePlacementRequiredDomainPolicy :
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
    /// Describes the policy to be used for placement of a Service Fabric service where the instances or replicas of that service
    /// must be placed in a particular domain.
    internal partial interface IServicePlacementRequiredDomainPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal
    {
        /// <summary>The name of the domain that should used for placement as per this policy.</summary>
        string DomainName { get; set; }

    }
}