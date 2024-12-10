// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Contains the list of gallery applications that should be made available to the
    /// VM/VMSS
    /// </summary>
    public partial class ApplicationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApplicationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApplicationProfileInternal
    {

        /// <summary>Backing field for <see cref="GalleryApplication" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication> _galleryApplication;

        /// <summary>Specifies the gallery applications that should be made available to the VM/VMSS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication> GalleryApplication { get => this._galleryApplication; set => this._galleryApplication = value; }

        /// <summary>Creates an new <see cref="ApplicationProfile" /> instance.</summary>
        public ApplicationProfile()
        {

        }
    }
    /// Contains the list of gallery applications that should be made available to the
    /// VM/VMSS
    public partial interface IApplicationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the gallery applications that should be made available to the VM/VMSS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the gallery applications that should be made available to the VM/VMSS",
        SerializedName = @"galleryApplications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication> GalleryApplication { get; set; }

    }
    /// Contains the list of gallery applications that should be made available to the
    /// VM/VMSS
    internal partial interface IApplicationProfileInternal

    {
        /// <summary>Specifies the gallery applications that should be made available to the VM/VMSS</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication> GalleryApplication { get; set; }

    }
}