// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Extensions;

    /// <summary>The identities assigned to this resource by the user.</summary>
    public partial class UserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="UserAssignedIdentities" /> instance.</summary>
        public UserAssignedIdentities()
        {

        }
    }
    /// The identities assigned to this resource by the user.
    public partial interface IUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IUserAssignedIdentity>
    {

    }
    /// The identities assigned to this resource by the user.
    internal partial interface IUserAssignedIdentitiesInternal

    {

    }
}