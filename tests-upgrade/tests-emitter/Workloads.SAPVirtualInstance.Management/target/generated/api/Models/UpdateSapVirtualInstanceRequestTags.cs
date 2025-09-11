// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the Resource tags.</summary>
    public partial class UpdateSapVirtualInstanceRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequestTags,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapVirtualInstanceRequestTagsInternal
    {

        /// <summary>Creates an new <see cref="UpdateSapVirtualInstanceRequestTags" /> instance.</summary>
        public UpdateSapVirtualInstanceRequestTags()
        {

        }
    }
    /// Gets or sets the Resource tags.
    public partial interface IUpdateSapVirtualInstanceRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets the Resource tags.
    internal partial interface IUpdateSapVirtualInstanceRequestTagsInternal

    {

    }
}