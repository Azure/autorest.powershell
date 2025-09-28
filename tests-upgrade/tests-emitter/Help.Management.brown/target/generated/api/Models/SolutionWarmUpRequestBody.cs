// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Solution WarmUpRequest body</summary>
    public partial class SolutionWarmUpRequestBody :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBody,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyParameters _parameter;

        /// <summary>Dictionary of <string></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.SolutionWarmUpRequestBodyParameters()); set => this._parameter = value; }

        /// <summary>Creates an new <see cref="SolutionWarmUpRequestBody" /> instance.</summary>
        public SolutionWarmUpRequestBody()
        {

        }
    }
    /// Solution WarmUpRequest body
    public partial interface ISolutionWarmUpRequestBody :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>Dictionary of <string></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dictionary of <string>",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyParameters Parameter { get; set; }

    }
    /// Solution WarmUpRequest body
    internal partial interface ISolutionWarmUpRequestBodyInternal

    {
        /// <summary>Dictionary of <string></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionWarmUpRequestBodyParameters Parameter { get; set; }

    }
}