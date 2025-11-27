// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The tags that will be assigned to the secret.</summary>
    public partial class SecretCreateOrUpdateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTagsInternal
    {

        /// <summary>Creates an new <see cref="SecretCreateOrUpdateParametersTags" /> instance.</summary>
        public SecretCreateOrUpdateParametersTags()
        {

        }
    }
    /// The tags that will be assigned to the secret.
    public partial interface ISecretCreateOrUpdateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags that will be assigned to the secret.
    internal partial interface ISecretCreateOrUpdateParametersTagsInternal

    {

    }
}