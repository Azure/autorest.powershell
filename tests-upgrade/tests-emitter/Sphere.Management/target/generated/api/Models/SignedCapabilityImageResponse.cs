// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Signed device capability image response</summary>
    public partial class SignedCapabilityImageResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISignedCapabilityImageResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISignedCapabilityImageResponseInternal
    {

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private string _image;

        /// <summary>The signed device capability image as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Image { get => this._image; }

        /// <summary>Internal Acessors for Image</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISignedCapabilityImageResponseInternal.Image { get => this._image; set { {_image = value;} } }

        /// <summary>Creates an new <see cref="SignedCapabilityImageResponse" /> instance.</summary>
        public SignedCapabilityImageResponse()
        {

        }
    }
    /// Signed device capability image response
    public partial interface ISignedCapabilityImageResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The signed device capability image as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The signed device capability image as a UTF-8 encoded base 64 string.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string Image { get;  }

    }
    /// Signed device capability image response
    internal partial interface ISignedCapabilityImageResponseInternal

    {
        /// <summary>The signed device capability image as a UTF-8 encoded base 64 string.</summary>
        string Image { get; set; }

    }
}