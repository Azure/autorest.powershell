// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of image</summary>
    public partial class ImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ComponentId" /> property.</summary>
        private string _componentId;

        /// <summary>The image component id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ComponentId { get => this._componentId; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The image description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private string _image;

        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Image { get => this._image; set => this._image = value; }

        /// <summary>Backing field for <see cref="ImageId" /> property.</summary>
        private string _imageId;

        /// <summary>Image ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ImageId { get => this._imageId; set => this._imageId = value; }

        /// <summary>Backing field for <see cref="ImageName" /> property.</summary>
        private string _imageName;

        /// <summary>Image name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ImageName { get => this._imageName; }

        /// <summary>Backing field for <see cref="ImageType" /> property.</summary>
        private string _imageType;

        /// <summary>The image type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ImageType { get => this._imageType; }

        /// <summary>Internal Acessors for ComponentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.ComponentId { get => this._componentId; set { {_componentId = value;} } }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for ImageName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.ImageName { get => this._imageName; set { {_imageName = value;} } }

        /// <summary>Internal Acessors for ImageType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.ImageType { get => this._imageType; set { {_imageType = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Uri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal.Uri { get => this._uri; set { {_uri = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RegionalDataBoundary" /> property.</summary>
        private string _regionalDataBoundary;

        /// <summary>Regional data boundary for an image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string RegionalDataBoundary { get => this._regionalDataBoundary; set => this._regionalDataBoundary = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Location the image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; }

        /// <summary>Creates an new <see cref="ImageProperties" /> instance.</summary>
        public ImageProperties()
        {

        }
    }
    /// The properties of image
    public partial interface IImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The image component id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image component id.",
        SerializedName = @"componentId",
        PossibleTypes = new [] { typeof(string) })]
        string ComponentId { get;  }
        /// <summary>The image description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string Image { get; set; }
        /// <summary>Image ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Image ID",
        SerializedName = @"imageId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageId { get; set; }
        /// <summary>Image name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Image name",
        SerializedName = @"imageName",
        PossibleTypes = new [] { typeof(string) })]
        string ImageName { get;  }
        /// <summary>The image type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image type.",
        SerializedName = @"imageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("InvalidImageType", "OneBl", "PlutonRuntime", "WifiFirmware", "SecurityMonitor", "NormalWorldLoader", "NormalWorldDtb", "NormalWorldKernel", "RootFs", "Services", "Applications", "FwConfig", "BootManifest", "Nwfs", "TrustedKeystore", "Policy", "CustomerBoardConfig", "UpdateCertStore", "BaseSystemUpdateManifest", "FirmwareUpdateManifest", "CustomerUpdateManifest", "RecoveryManifest", "ManifestSet", "Other")]
        string ImageType { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Regional data boundary for an image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Regional data boundary for an image",
        SerializedName = @"regionalDataBoundary",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Location the image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Location the image",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get;  }

    }
    /// The properties of image
    internal partial interface IImagePropertiesInternal

    {
        /// <summary>The image component id.</summary>
        string ComponentId { get; set; }
        /// <summary>The image description.</summary>
        string Description { get; set; }
        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        string Image { get; set; }
        /// <summary>Image ID</summary>
        string ImageId { get; set; }
        /// <summary>Image name</summary>
        string ImageName { get; set; }
        /// <summary>The image type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("InvalidImageType", "OneBl", "PlutonRuntime", "WifiFirmware", "SecurityMonitor", "NormalWorldLoader", "NormalWorldDtb", "NormalWorldKernel", "RootFs", "Services", "Applications", "FwConfig", "BootManifest", "Nwfs", "TrustedKeystore", "Policy", "CustomerBoardConfig", "UpdateCertStore", "BaseSystemUpdateManifest", "FirmwareUpdateManifest", "CustomerUpdateManifest", "RecoveryManifest", "ManifestSet", "Other")]
        string ImageType { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Regional data boundary for an image</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }
        /// <summary>Location the image</summary>
        string Uri { get; set; }

    }
}