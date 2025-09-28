// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>List of Elastic Sans</summary>
    public partial class ElasticSanList :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanList,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSan> _value;

        /// <summary>The ElasticSan items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSan> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ElasticSanList" /> instance.</summary>
        public ElasticSanList()
        {

        }
    }
    /// List of Elastic Sans
    public partial interface IElasticSanList :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ElasticSan items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ElasticSan items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSan) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSan> Value { get; set; }

    }
    /// List of Elastic Sans
    internal partial interface IElasticSanListInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ElasticSan items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSan> Value { get; set; }

    }
}