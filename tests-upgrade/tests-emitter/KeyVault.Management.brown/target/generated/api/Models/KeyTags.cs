// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class KeyTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyTagsInternal
    {

        /// <summary>Creates an new <see cref="KeyTags" /> instance.</summary>
        public KeyTags()
        {

        }
    }
    /// Resource tags
    public partial interface IKeyTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IKeyTagsInternal

    {

    }
}