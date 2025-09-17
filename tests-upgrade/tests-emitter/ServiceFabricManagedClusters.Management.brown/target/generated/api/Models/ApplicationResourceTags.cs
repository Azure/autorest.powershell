// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class ApplicationResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ApplicationResourceTags" /> instance.</summary>
        public ApplicationResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IApplicationResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IApplicationResourceTagsInternal

    {

    }
}