// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class IdentityDataUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IIdentityDataUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="IdentityDataUserAssignedIdentities" /> instance.</summary>
        public IdentityDataUserAssignedIdentities()
        {

        }
    }
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IIdentityDataUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUserIdentity>
    {

    }
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IIdentityDataUserAssignedIdentitiesInternal

    {

    }
}