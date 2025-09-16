// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form:
    /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class ManagedIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="ManagedIdentityUserAssignedIdentities" /> instance.</summary>
        public ManagedIdentityUserAssignedIdentities()
        {

        }
    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form:
    /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IManagedIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IUserAssignedIdentity>
    {

    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form:
    /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IManagedIdentityUserAssignedIdentitiesInternal

    {

    }
}