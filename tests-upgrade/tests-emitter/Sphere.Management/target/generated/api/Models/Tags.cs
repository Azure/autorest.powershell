// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class Tags :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITagsInternal
    {

        /// <summary>Creates an new <see cref="Tags" /> instance.</summary>
        public Tags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITags :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITagsInternal

    {

    }
}