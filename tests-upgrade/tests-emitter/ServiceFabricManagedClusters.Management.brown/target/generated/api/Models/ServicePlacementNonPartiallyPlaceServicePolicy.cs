// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The type of placement policy for a service fabric service. Following are the possible values.
    /// </summary>
    public partial class ServicePlacementNonPartiallyPlaceServicePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementNonPartiallyPlaceServicePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementNonPartiallyPlaceServicePolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy __servicePlacementPolicy = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicy();

        /// <summary>
        /// The type of placement policy for a service fabric service. Following are the possible values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string Type { get => "NonPartiallyPlaceService"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal)__servicePlacementPolicy).Type = "NonPartiallyPlaceService"; }

        /// <summary>
        /// Creates an new <see cref="ServicePlacementNonPartiallyPlaceServicePolicy" /> instance.
        /// </summary>
        public ServicePlacementNonPartiallyPlaceServicePolicy()
        {
            this.__servicePlacementPolicy.Type = "NonPartiallyPlaceService";
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
    /// The type of placement policy for a service fabric service. Following are the possible values.
    public partial interface IServicePlacementNonPartiallyPlaceServicePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy
    {

    }
    /// The type of placement policy for a service fabric service. Following are the possible values.
    internal partial interface IServicePlacementNonPartiallyPlaceServicePolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal
    {

    }
}