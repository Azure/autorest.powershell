// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The response of a Image list operation.</summary>
    public partial class ImageListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> _value;

        /// <summary>The Image items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ImageListResult" /> instance.</summary>
        public ImageListResult()
        {

        }
    }
    /// The response of a Image list operation.
    public partial interface IImageListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The Image items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Image items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> Value { get; set; }

    }
    /// The response of a Image list operation.
    internal partial interface IImageListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The Image items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage> Value { get; set; }

    }
}