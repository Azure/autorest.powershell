// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>List of solutions</summary>
    public partial class Solutions :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutions,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionsInternal
    {

        /// <summary>Backing field for <see cref="Solution" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> _solution;

        /// <summary>List of metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get => this._solution; set => this._solution = value; }

        /// <summary>Creates an new <see cref="Solutions" /> instance.</summary>
        public Solutions()
        {

        }
    }
    /// List of solutions
    public partial interface ISolutions :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>List of metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of metadata.",
        SerializedName = @"solutions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get; set; }

    }
    /// List of solutions
    internal partial interface ISolutionsInternal

    {
        /// <summary>List of metadata.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ISolutionMetadataProperties> Solution { get; set; }

    }
}