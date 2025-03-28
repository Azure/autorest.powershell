// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Details of the ResourceDetailsObject.</summary>
    public partial class ResourceDetailsObjectProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private string _image;

        /// <summary>The image name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Image { get => this._image; set => this._image = value; }

        /// <summary>Backing field for <see cref="ImageVersion" /> property.</summary>
        private string _imageVersion;

        /// <summary>The version of the image running on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string ImageVersion { get => this._imageVersion; set => this._imageVersion = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ResourceDetailsObjectProperties" /> instance.</summary>
        public ResourceDetailsObjectProperties()
        {

        }
    }
    /// Details of the ResourceDetailsObject.
    public partial interface IResourceDetailsObjectProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>The image name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image name of the resource.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string Image { get; set; }
        /// <summary>The version of the image running on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the image running on the resource.",
        SerializedName = @"imageVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ImageVersion { get; set; }
        /// <summary>The status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the resource.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Ready", "NotReady", "Allocated", "PendingReturn", "Returned", "Leased", "Provisioning", "Updating", "Starting", "PendingReimage", "Reimaging")]
        string Status { get; set; }

    }
    /// Details of the ResourceDetailsObject.
    internal partial interface IResourceDetailsObjectPropertiesInternal

    {
        /// <summary>The image name of the resource.</summary>
        string Image { get; set; }
        /// <summary>The version of the image running on the resource.</summary>
        string ImageVersion { get; set; }
        /// <summary>The status of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Ready", "NotReady", "Allocated", "PendingReturn", "Returned", "Leased", "Provisioning", "Updating", "Starting", "PendingReimage", "Reimaging")]
        string Status { get; set; }

    }
}