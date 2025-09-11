// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Asset's tags. Unlike properties, tags are fully mutable.</summary>
    public partial class IndexTags :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTagsInternal
    {

        /// <summary>Creates an new <see cref="IndexTags" /> instance.</summary>
        public IndexTags()
        {

        }
    }
    /// Asset's tags. Unlike properties, tags are fully mutable.
    public partial interface IIndexTags :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IAssociativeArray<string>
    {

    }
    /// Asset's tags. Unlike properties, tags are fully mutable.
    internal partial interface IIndexTagsInternal

    {

    }
}