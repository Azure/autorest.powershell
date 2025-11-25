// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>User Assigned Identities</summary>
    public partial class ResourceIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="ResourceIdentityUserAssignedIdentities" /> instance.</summary>
        public ResourceIdentityUserAssignedIdentities()
        {

        }
    }
    /// User Assigned Identities
    public partial interface IResourceIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedIdentity>
    {

    }
    /// User Assigned Identities
    internal partial interface IResourceIdentityUserAssignedIdentitiesInternal

    {

    }
}