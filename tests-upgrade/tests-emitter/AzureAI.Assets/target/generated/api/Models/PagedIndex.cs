// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Paged collection of IndexVersion items.</summary>
    public partial class PagedIndex :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IPagedIndex,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IPagedIndexInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex> _value;

        /// <summary>The list of Indexes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PagedIndex" /> instance.</summary>
        public PagedIndex()
        {

        }
    }
    /// Paged collection of IndexVersion items.
    public partial interface IPagedIndex :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of Indexes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of Indexes.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex> Value { get; set; }

    }
    /// Paged collection of IndexVersion items.
    internal partial interface IPagedIndexInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The list of Indexes.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex> Value { get; set; }

    }
}