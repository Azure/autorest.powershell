// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Metadata of user assigned identity.</summary>
    public partial class MySqlServerIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>
        /// Creates an new <see cref="MySqlServerIdentityUserAssignedIdentities" /> instance.
        /// </summary>
        public MySqlServerIdentityUserAssignedIdentities()
        {

        }
    }
    /// Metadata of user assigned identity.
    public partial interface IMySqlServerIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IUserAssignedIdentity>
    {

    }
    /// Metadata of user assigned identity.
    internal partial interface IMySqlServerIdentityUserAssignedIdentitiesInternal

    {

    }
}