// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>List of SKU Information objects</summary>
    public partial class SkuInformationList :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformationList,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformationListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation> Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformationListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation> _value;

        /// <summary>The SkuInformation items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation> Value { get => this._value; }

        /// <summary>Creates an new <see cref="SkuInformationList" /> instance.</summary>
        public SkuInformationList()
        {

        }
    }
    /// List of SKU Information objects
    public partial interface ISkuInformationList :
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
        /// <summary>The SkuInformation items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The SkuInformation items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation> Value { get;  }

    }
    /// List of SKU Information objects
    internal partial interface ISkuInformationListInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The SkuInformation items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISkuInformation> Value { get; set; }

    }
}