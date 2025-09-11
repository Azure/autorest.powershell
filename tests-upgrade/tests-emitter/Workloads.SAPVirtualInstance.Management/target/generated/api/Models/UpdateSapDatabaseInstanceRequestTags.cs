// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Gets or sets the Resource tags.</summary>
    public partial class UpdateSapDatabaseInstanceRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapDatabaseInstanceRequestTags,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapDatabaseInstanceRequestTagsInternal
    {

        /// <summary>Creates an new <see cref="UpdateSapDatabaseInstanceRequestTags" /> instance.</summary>
        public UpdateSapDatabaseInstanceRequestTags()
        {

        }
    }
    /// Gets or sets the Resource tags.
    public partial interface IUpdateSapDatabaseInstanceRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets the Resource tags.
    internal partial interface IUpdateSapDatabaseInstanceRequestTagsInternal

    {

    }
}