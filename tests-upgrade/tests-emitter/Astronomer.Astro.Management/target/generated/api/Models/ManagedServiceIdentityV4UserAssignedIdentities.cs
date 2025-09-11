// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>The identities assigned to this resource by the user.</summary>
    public partial class ManagedServiceIdentityV4UserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IManagedServiceIdentityV4UserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IManagedServiceIdentityV4UserAssignedIdentitiesInternal
    {

        /// <summary>
        /// Creates an new <see cref="ManagedServiceIdentityV4UserAssignedIdentities" /> instance.
        /// </summary>
        public ManagedServiceIdentityV4UserAssignedIdentities()
        {

        }
    }
    /// The identities assigned to this resource by the user.
    public partial interface IManagedServiceIdentityV4UserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserAssignedIdentity>
    {

    }
    /// The identities assigned to this resource by the user.
    internal partial interface IManagedServiceIdentityV4UserAssignedIdentitiesInternal

    {

    }
}