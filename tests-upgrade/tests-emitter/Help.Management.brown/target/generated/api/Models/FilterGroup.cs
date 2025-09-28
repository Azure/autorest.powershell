// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Filter group</summary>
    public partial class FilterGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilterGroup,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilterGroupInternal
    {

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilter> _filter;

        /// <summary>List of filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilter> Filter { get => this._filter; set => this._filter = value; }

        /// <summary>Creates an new <see cref="FilterGroup" /> instance.</summary>
        public FilterGroup()
        {

        }
    }
    /// Filter group
    public partial interface IFilterGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>List of filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of filters",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilter) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilter> Filter { get; set; }

    }
    /// Filter group
    internal partial interface IFilterGroupInternal

    {
        /// <summary>List of filters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IFilter> Filter { get; set; }

    }
}