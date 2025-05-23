// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The type used for update operations of the Product.</summary>
    public partial class ProductUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateInternal
    {

        /// <summary>Description of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdatePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdatePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ProductUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateProperties _property;

        /// <summary>The updatable properties of the Product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ProductUpdateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="ProductUpdate" /> instance.</summary>
        public ProductUpdate()
        {

        }
    }
    /// The type used for update operations of the Product.
    public partial interface IProductUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Description of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the product",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

    }
    /// The type used for update operations of the Product.
    internal partial interface IProductUpdateInternal

    {
        /// <summary>Description of the product</summary>
        string Description { get; set; }
        /// <summary>The updatable properties of the Product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateProperties Property { get; set; }

    }
}