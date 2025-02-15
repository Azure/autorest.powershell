namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The updatable properties of the Product.</summary>
    public partial class ProductUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProductUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Creates an new <see cref="ProductUpdateProperties" /> instance.</summary>
        public ProductUpdateProperties()
        {

        }
    }
    /// The updatable properties of the Product.
    public partial interface IProductUpdateProperties :
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
    /// The updatable properties of the Product.
    internal partial interface IProductUpdatePropertiesInternal

    {
        /// <summary>Description of the product</summary>
        string Description { get; set; }

    }
}