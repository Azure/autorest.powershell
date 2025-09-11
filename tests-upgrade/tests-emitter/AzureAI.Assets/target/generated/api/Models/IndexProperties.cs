// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    /// </summary>
    public partial class IndexProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexPropertiesInternal
    {

        /// <summary>Creates an new <see cref="IndexProperties" /> instance.</summary>
        public IndexProperties()
        {

        }
    }
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    public partial interface IIndexProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IAssociativeArray<string>
    {

    }
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    internal partial interface IIndexPropertiesInternal

    {

    }
}