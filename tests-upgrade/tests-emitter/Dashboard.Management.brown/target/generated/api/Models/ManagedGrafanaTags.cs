// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class ManagedGrafanaTags :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTags,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTagsInternal
    {

        /// <summary>Creates an new <see cref="ManagedGrafanaTags" /> instance.</summary>
        public ManagedGrafanaTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IManagedGrafanaTags :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IManagedGrafanaTagsInternal

    {

    }
}