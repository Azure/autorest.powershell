// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    /// </summary>
    public partial class PromptProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IPromptProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IPromptPropertiesInternal
    {

        /// <summary>Creates an new <see cref="PromptProperties" /> instance.</summary>
        public PromptProperties()
        {

        }
    }
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    public partial interface IPromptProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IAssociativeArray<string>
    {

    }
    /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
    internal partial interface IPromptPropertiesInternal

    {

    }
}