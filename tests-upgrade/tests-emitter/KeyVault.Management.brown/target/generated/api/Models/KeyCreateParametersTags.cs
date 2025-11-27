// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The tags that will be assigned to the key.</summary>
    public partial class KeyCreateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyCreateParametersTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyCreateParametersTagsInternal
    {

        /// <summary>Creates an new <see cref="KeyCreateParametersTags" /> instance.</summary>
        public KeyCreateParametersTags()
        {

        }
    }
    /// The tags that will be assigned to the key.
    public partial interface IKeyCreateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags that will be assigned to the key.
    internal partial interface IKeyCreateParametersTagsInternal

    {

    }
}