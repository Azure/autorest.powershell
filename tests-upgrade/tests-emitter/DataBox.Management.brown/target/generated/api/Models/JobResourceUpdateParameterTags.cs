// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
    /// resource groups).
    /// </summary>
    public partial class JobResourceUpdateParameterTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTags,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceUpdateParameterTagsInternal
    {

        /// <summary>Creates an new <see cref="JobResourceUpdateParameterTags" /> instance.</summary>
        public JobResourceUpdateParameterTags()
        {

        }
    }
    /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
    /// resource groups).
    public partial interface IJobResourceUpdateParameterTags :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IAssociativeArray<string>
    {

    }
    /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
    /// resource groups).
    internal partial interface IJobResourceUpdateParameterTagsInternal

    {

    }
}