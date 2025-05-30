// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The type used for update operations of the Catalog.</summary>
    public partial class CatalogUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICatalogUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICatalogUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="CatalogUpdate" /> instance.</summary>
        public CatalogUpdate()
        {

        }
    }
    /// The type used for update operations of the Catalog.
    public partial interface ICatalogUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the Catalog.
    internal partial interface ICatalogUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ITags Tag { get; set; }

    }
}