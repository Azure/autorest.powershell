// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>The response of a OrganizationResource list operation.</summary>
    public partial class OrganizationResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> _value;

        /// <summary>The OrganizationResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OrganizationResourceListResult" /> instance.</summary>
        public OrganizationResourceListResult()
        {

        }
    }
    /// The response of a OrganizationResource list operation.
    public partial interface IOrganizationResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The OrganizationResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OrganizationResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> Value { get; set; }

    }
    /// The response of a OrganizationResource list operation.
    internal partial interface IOrganizationResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The OrganizationResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationResource> Value { get; set; }

    }
}