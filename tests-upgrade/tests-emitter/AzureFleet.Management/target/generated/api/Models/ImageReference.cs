// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies information about the image to use. You can specify information about
    /// platform images, marketplace images, or virtual machine images. This element is
    /// required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image
    /// reference publisher and offer can only be set when you create the scale set.
    /// </summary>
    public partial class ImageReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal
    {

        /// <summary>Backing field for <see cref="CommunityGalleryImageId" /> property.</summary>
        private string _communityGalleryImageId;

        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string CommunityGalleryImageId { get => this._communityGalleryImageId; set => this._communityGalleryImageId = value; }

        /// <summary>Backing field for <see cref="ExactVersion" /> property.</summary>
        private string _exactVersion;

        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ExactVersion { get => this._exactVersion; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for ExactVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal.ExactVersion { get => this._exactVersion; set { {_exactVersion = value;} } }

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; set => this._offer = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="SharedGalleryImageId" /> property.</summary>
        private string _sharedGalleryImageId;

        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string SharedGalleryImageId { get => this._sharedGalleryImageId; set => this._sharedGalleryImageId = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ImageReference" /> instance.</summary>
        public ImageReference()
        {

        }
    }
    /// Specifies information about the image to use. You can specify information about
    /// platform images, marketplace images, or virtual machine images. This element is
    /// required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image
    /// reference publisher and offer can only be set when you create the scale set.
    public partial interface IImageReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specified the community gallery image unique id for vm deployment. This can be
        fetched from community gallery image GET call.",
        SerializedName = @"communityGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        string CommunityGalleryImageId { get; set; }
        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies in decimal numbers, the version of platform image or marketplace
        image used to create the virtual machine. This readonly field differs from 'version',
        only if the value specified in 'version' field is 'latest'.",
        SerializedName = @"exactVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ExactVersion { get;  }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create
        the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specified the shared gallery image unique id for vm deployment. This can be
        fetched from shared gallery image GET call.",
        SerializedName = @"sharedGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        string SharedGalleryImageId { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create
        the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        version of an image available at deploy time. Even if you use 'latest', the VM
        image will not automatically update after deploy time even if a new version
        becomes available. Please do not use field 'version' for gallery image
        deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        version of gallery image, just set
        '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        in the 'id' field without version input.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Specifies information about the image to use. You can specify information about
    /// platform images, marketplace images, or virtual machine images. This element is
    /// required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image
    /// reference publisher and offer can only be set when you create the scale set.
    internal partial interface IImageReferenceInternal

    {
        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        string CommunityGalleryImageId { get; set; }
        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        string ExactVersion { get; set; }
        /// <summary>Resource Id</summary>
        string Id { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        string Offer { get; set; }
        /// <summary>The image publisher.</summary>
        string Publisher { get; set; }
        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        string SharedGalleryImageId { get; set; }
        /// <summary>The image SKU.</summary>
        string Sku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        string Version { get; set; }

    }
}