// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Tags assigned to the key vault resource.</summary>
    public partial class SecretTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTagsInternal
    {

        /// <summary>Creates an new <see cref="SecretTags" /> instance.</summary>
        public SecretTags()
        {

        }
    }
    /// Tags assigned to the key vault resource.
    public partial interface ISecretTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags assigned to the key vault resource.
    internal partial interface ISecretTagsInternal

    {

    }
}